using MuLauncher.app.launcher.domain.callbacks;
using MuLauncher.app.launcher.domain.entities;
using MuLauncher.app.launcher.domain.errors;
using MuLauncher.app.launcher.domain.repositories;
using MuLauncher.app.launcher.infra.datasource;
using MuLauncher.app.launcher.infra.models;
using MuLauncher.app.launcher.infra.services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.launcher.infra.repositories
{
    class LauncherRepositoryImpl : LauncherRepository
    {
        LauncherDatasource datasource;
        LauncherService service;
        LauncherConfig config;

        public LauncherRepositoryImpl(LauncherDatasource launcherDataSource, LauncherService service, LauncherConfig config) {
            this.datasource = launcherDataSource;
            this.service = service;
            this.config = config;
        }
        public async Task checkUpdateAsync(IDownloadFileCallback callback)
        {
            try
            {
                List<FileModel> filesOutdated = await datasource.getFilesOutDatedAsync();

                if (filesOutdated.Count > 0)
                    filesOutdated.ForEach(delegate (FileModel model)
                    {

                        downloadFile(model, callback);

                    });
                else
                    callback.onSucess();


            }
            catch (Exception e)
            {
                callback.onError(new CheckUpdateError("Erro ao verficar arquivos " + e.Message));
            }
           
        }

       public bool startGame()
        {

            throw new NotFoundError(config.MainName);
        }

        private void downloadFile(FileModel filesModel , IDownloadFileCallback callback) {

            try
            {
                service.downloadFile(filesModel, callback);
            }
            catch (Exception e )
            {
                callback.onError(new DownloadFileError(e.Message));
            }  
        }
    }
}
