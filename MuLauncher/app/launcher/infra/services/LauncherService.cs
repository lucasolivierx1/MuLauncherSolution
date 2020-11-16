using MuLauncher.app.launcher.domain.callbacks;
using MuLauncher.app.launcher.infra.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.launcher.infra.services
{
    public abstract class LauncherService
    {
        public abstract void downloadFile(FileModel file, IDownloadFileCallback callback);
    }
}
