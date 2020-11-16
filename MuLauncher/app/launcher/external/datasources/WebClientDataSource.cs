using Crc32C;
using MuLauncher.app.launcher.domain.entities;
using MuLauncher.app.launcher.domain.errors;
using MuLauncher.app.launcher.external.routes;
using MuLauncher.app.launcher.infra.datasource;
using MuLauncher.app.launcher.infra.models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MuLauncher.app.launcher.external.datasources
{
    class WebClientDataSource : LauncherDatasource
    {
        LauncherConfig config; 
        public WebClientDataSource(LauncherConfig config) {
            this.config = config;
        }
        public override async System.Threading.Tasks.Task<List<FileModel>> getFilesOutDatedAsync()
        {
            WebClient client = new WebClient();

            Uri uri = new Uri(config.BaseURL + Routes.UPDATE_FILE_LIST);

            String updateJson;

            try
            {
                updateJson = await client.DownloadStringTaskAsync(uri); 
            }
            catch (Exception e )
            {
                throw new CheckUpdateError(e.Message);
            }

            List<FileModel > list = JsonConvert.DeserializeObject<List<FileModel>>(updateJson);

            List<FileModel> lists = list.FindAll(delegate(FileModel model) {

                if (!File.Exists(model.ClientPath))
                    return true;

                byte[] clientFile = File.ReadAllBytes(model.ClientPath);

                uint crc = Crc32CAlgorithm.Compute(clientFile);

                return !model.cCRC.Equals(crc.ToString());
            
            });

            return lists;
        }


    }
}
