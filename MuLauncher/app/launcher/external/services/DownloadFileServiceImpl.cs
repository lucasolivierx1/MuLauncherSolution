using MuLauncher.app.domain.entities;
using MuLauncher.app.launcher.domain.callbacks;
using MuLauncher.app.launcher.domain.entities;
using MuLauncher.app.launcher.domain.errors;
using MuLauncher.app.launcher.infra.models;
using MuLauncher.app.launcher.infra.services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MuLauncher.app.launcher.external.services
{
    public class DownloadFileServiceImpl : LauncherService
    {
        IDownloadFileCallback callback;
        List<FileModel> files = new List<FileModel>();
        FileModel file;
        LauncherConfig config;

        bool isBusy = false;

        public DownloadFileServiceImpl(MuLauncher.app.launcher.domain.entities.LauncherConfig config)
        {
            this.config = config;
        }

        private void download(FileModel file)
        {
            this.file = file;

            WebClient client = new WebClient();

            Uri uri = new Uri(config.BaseURL + file.Url);

            client.DownloadFileCompleted += new AsyncCompletedEventHandler(DownloadFileCallback2);

            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressCallback);

            Directory.CreateDirectory(Path.GetDirectoryName(file.ClientPath));

            client.DownloadFileAsync(uri, file.ClientPath + ".zip");

        }

        private void callNext() {

            if (this.files.Count > 0)
            {
                download(files.First());
            }
            else {
                isBusy = false;
            }
        
        }

        public override void downloadFile(FileModel file, IDownloadFileCallback callback)
        {
            this.callback = callback;

            this.files.Add(file);

            if (!isBusy){

                download(files.First());

                isBusy = true;
            }

        }

        private void DownloadProgressCallback(object sender, DownloadProgressChangedEventArgs e)
        {
            if (callback != null)
                callback.onProgress(file, e.ProgressPercentage);
        }

        private void DownloadFileCallback2(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                if (File.Exists(file.ClientPath))
                    File.Delete(file.ClientPath);

                ZipFile.ExtractToDirectory(file.ClientPath + ".zip", Path.GetDirectoryName(file.ClientPath));

                if (callback != null)
                    callback.onSucess();

                File.Delete(file.ClientPath + ".zip");

                this.files.Remove(file);
                callNext();
            }
            catch (Exception exc)
            {
                throw new ExtractError(exc.Message);
            }

        }
    }
}
