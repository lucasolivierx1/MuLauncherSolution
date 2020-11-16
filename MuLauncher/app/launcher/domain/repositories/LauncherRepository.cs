using MuLauncher.app.launcher.domain.callbacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.launcher.domain.repositories
{
    interface LauncherRepository
    {
        bool startGame();

        Task checkUpdateAsync(IDownloadFileCallback callback);
    }
}
