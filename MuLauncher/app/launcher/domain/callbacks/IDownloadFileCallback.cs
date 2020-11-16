using MuLauncher.app.domain.entities;
using MuLauncher.app.launcher.domain.errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.launcher.domain.callbacks
{
    public interface IDownloadFileCallback
    {
        void onProgress(DownloadFile file, float percent);

        void onSucess();
        void onError(Failure error);
    }
}
