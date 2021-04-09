using MuLauncher.app.domain.entities;
using MuLauncher.app.domain.usecases;
using MuLauncher.app.launcher.domain.callbacks;
using MuLauncher.app.launcher.domain.entities;
using MuLauncher.app.launcher.domain.errors;
using MuLauncher.app.launcher.domain.repositories;
using MuLauncher.app.launcher.domain.usecases;
using MuLauncher.app.launcher.external.datasources;
using MuLauncher.app.launcher.external.services;
using MuLauncher.app.launcher.infra.datasource;
using MuLauncher.app.launcher.infra.repositories;
using MuLauncher.app.launcher.infra.services;
using MuLauncher.variants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuLauncher.ui
{
    public class MainController : IDownloadFileCallback
    {
        #region Attributes

        private int progress;
        private String fileName;
        private bool playButtonEnabled;


        private Subject<String> _msgSubj = new Subject<String>();
        private Subject<Boolean> _playButtonEnabledSubj = new Subject<Boolean>();


        #endregion

        #region Dependencies

        LauncherConfig config;
        LauncherRepository repository;
        LauncherService service;
        LauncherDatasource dataSource;



        LauncherContainer container;

        #endregion

        internal void buildComponents(Form pForm)
        {
            container.LauncherLayout.Build(pForm);
            container.CloseButton.Build(pForm);
            container.ConfigButton.Build(pForm);
            container.CurrentUpdate.Build(pForm);
            container.MessageUpdate.Build(pForm);
            container.MinimizeButton.Build(pForm);
            container.PlayButton.Build(pForm);
            container.SaveButton.Build(pForm);

            container.WebSiteButton.Build(pForm);
            container.UpdateTotal.Build(pForm);
            container.WebView.Build(pForm);
            container.TotalProgressBar.Build(pForm);
            container.CurrentProgressBar.Build(pForm);
        }

        #region UseCases

        CheckUpdate checkUpdate;
        OpenLinkExternal openLink;
        StartGame startGame;

        #endregion

        #region Constructor
        public MainController(LauncherConfig config, LauncherContainer container)
        {
            this.config = config;
            //Dependency
            service = new DownloadFileServiceImpl(config);
            dataSource = new WebClientDataSource(config);
            repository = new LauncherRepositoryImpl(dataSource, service, config);

            //UseCases
            checkUpdate = new CheckUpdateImpl(repository);
            openLink = new OpenLinkImpl();
            startGame = new StartGameImpl(repository);

            Container = container;

        }

        #endregion

        #region Properties

        public LauncherConfig Config { get => config; set => config = value; }
        public LauncherContainer Container { get => container; set => container = value; }
        public Subject<string> MsgSubj { get => _msgSubj; set => _msgSubj = value; }
        public Subject<bool> PlayButtonEnabledSubj { get => _playButtonEnabledSubj; set => _playButtonEnabledSubj = value; }

        #endregion

        #region UseCases Call

        public void startGameCall()
        {
            try
            {
                startGame.execute();
            }
            catch (Failure e)
            {
                MsgSubj.OnNext(e.Message);
            }

        }
        public void openExternalLinkCall(String pLink)
        {
            try
            {
                openLink.execute(pLink);
            }
            catch (Failure e)
            {
                MsgSubj.OnNext(e.Message);
            }

        }

        public void checkUpdateCall()
        {
            MsgSubj.OnNext("Verificando update...");
            try { 
            
                checkUpdate.execute(this);

            }
            catch (Failure e)
            {
                onError(e);
            }

        }

        #endregion

        #region IDownloadFileCallback Implementation
        public void onProgress(DownloadFile file, float percent)
        {
            MsgSubj.OnNext(file.FileName + "(" + ((int)Math.Round(percent)).ToString() + ")");
        }

        public void onSucess()
        {
            MsgSubj.OnNext("Cliente atualizado, bom jogo!");
            _playButtonEnabledSubj.OnNext(true);
        }

        public void onError(Failure error)
        {
            MsgSubj.OnNext(error.Message);
            _playButtonEnabledSubj.OnNext(true);
        }

        #endregion
    }
}
