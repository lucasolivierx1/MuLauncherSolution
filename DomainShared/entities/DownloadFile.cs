using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.domain.entities
{
    public abstract class DownloadFile
    {
        protected String fileName;
        protected String url;
        protected String CRC;
        protected String clientPath;
        protected int size;

        public string FileName { get => fileName; set => fileName = value; }
        public string Url { get => url; set => url = value; }
        public string cCRC { get => CRC; set => CRC = value; }
        public int Size { get => size; set => size = value; }
        virtual public string ClientPath { get => clientPath; set => clientPath = value; }
    }
}
