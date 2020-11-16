using MuLauncher.app.configs.domain.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.PeerToPeer.Collaboration;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.configs.domain.usecases
{
    public abstract class LoadConfig
    {
        public abstract MuConfig Execute();
    }


    public class LoadConfigImpl : LoadConfig
    {
        ConfigRepository repository;

        public LoadConfigImpl(ConfigRepository pRepository)
        {
            repository = pRepository;
        }

        public override MuConfig Execute()
        {
            return repository.LoadConfig();
        }
    }


}
