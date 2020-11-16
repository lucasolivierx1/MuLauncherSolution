using MuLauncher.app.launcher.infra.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.launcher.infra.datasource
{
    abstract class LauncherDatasource
    {
      public abstract System.Threading.Tasks.Task<List<FileModel>> getFilesOutDatedAsync();

    }
}
