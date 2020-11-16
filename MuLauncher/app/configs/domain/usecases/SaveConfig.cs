using MuLauncher.app.configs.domain.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.configs.domain.usecases
{
    public abstract class SaveConfig
    {
        public abstract void Execute(MuConfig pConfig);
    }

    public class SaveConfigImpl : SaveConfig
    {
        ConfigRepository repository;

        public SaveConfigImpl(ConfigRepository pConfigRepository) {
            repository = pConfigRepository;
        }

        public override void Execute(MuConfig pConfig)
        {
            repository.SaveConfig(pConfig);
        }
    }
}
