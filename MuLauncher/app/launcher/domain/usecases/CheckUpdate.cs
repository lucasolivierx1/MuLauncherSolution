using MuLauncher.app.launcher.domain.callbacks;
using MuLauncher.app.launcher.domain.errors;
using MuLauncher.app.launcher.domain.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.launcher.domain.usecases
{
    abstract class CheckUpdate
    {
        public abstract void execute(IDownloadFileCallback callback);
    }
    class CheckUpdateImpl : CheckUpdate
    {
        LauncherRepository reposity;

        public CheckUpdateImpl(LauncherRepository pRepository)
        {
            this.reposity = pRepository;
        }
        public override void execute(IDownloadFileCallback callback)
        {
            reposity.checkUpdateAsync(callback);

        }

    }

}
