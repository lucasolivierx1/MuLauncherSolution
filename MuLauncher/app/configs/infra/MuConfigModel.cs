using MuLauncher.app.configs.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.configs.infra
{
   public  class MuConfigModel : MuConfig
    {
        public MuConfigModel() {}

        public MuConfigModel(int windowMode, int soundOnOff, int resolution, int musicOnOff, string iD, string langSelection)
        {
            WindowMode = windowMode;
            SoundOnOff = soundOnOff;
            Resolution = resolution;
            MusicOnOff = musicOnOff;
            ID = iD;
            LangSelection = langSelection;
        }



    }
}
