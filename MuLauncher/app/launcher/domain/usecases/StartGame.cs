using MuLauncher.app.launcher.domain.entities;
using MuLauncher.app.launcher.domain.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.domain.usecases
{
    abstract class StartGame
    {
        public abstract void execute();
    }


    class StartGameImpl : StartGame
    {
        LauncherRepository repository;
        
        public StartGameImpl(LauncherRepository repository) {
            this.repository = repository;
        }

        public override void execute() {
            repository.startGame();
        }
    }
}
