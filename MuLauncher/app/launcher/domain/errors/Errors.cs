using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.launcher.domain.errors
{
    public abstract class Failure : Exception {
        public Failure() : base() { 
        
        }

        public Failure(String pMsg) : base(pMsg) { }
    }
    class NotFoundError : Failure
    {
        public NotFoundError(String pFileName) :
           base("Arquivo : " + pFileName + " não encontrado") {
        }

        public NotFoundError() { }
    }

    class CheckUpdateError : Failure
    {

        public CheckUpdateError(String pMsg) : base(pMsg)
        {
        }

    }

    class DownloadFileError : Failure
    {
        public DownloadFileError(String pMsg) : base(pMsg) { }
    }
    class ExtractError : Failure
    {
        public ExtractError(String pMsg) : base(pMsg) { }
    }

}
