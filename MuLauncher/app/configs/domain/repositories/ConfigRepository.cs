using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.configs.domain.repositories
{
    public abstract class ConfigRepository
    {
        public abstract void SaveConfig(MuConfig pConfig);
        public abstract MuConfig LoadConfig();
    }
}
