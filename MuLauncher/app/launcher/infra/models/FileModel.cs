using Crc32C;
using MuLauncher.app.domain.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuLauncher.app.launcher.infra.models
{
    public class FileModel : DownloadFile
    {

        public override string ClientPath { get => @".\" + this.clientPath; set => clientPath = value; }

        public FileModel(String pFileName, String pURL, String pCRC , int pSize, String pClientPath) {
            this.FileName = pFileName;
            this.Url = pURL;
            this.cCRC = pCRC;
            this.Size = pSize;
        }

        static FileModel fromJson(String json) {
            return JsonConvert.DeserializeObject<FileModel>(json);
        }

      
        DownloadFile toDownloadFile() {
            return this as DownloadFile;
        }

        public override bool Equals(object obj)
        {
            return obj is FileModel model &&
                   cCRC == model.cCRC;
        }

    }
}
