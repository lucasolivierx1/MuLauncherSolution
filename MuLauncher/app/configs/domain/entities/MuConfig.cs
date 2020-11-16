using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.configs.domain
{
    public abstract class MuConfig
    {

        public static String WEBZEN_DIR = @"Software\Webzen\Mu\Config";

        private int windowMode;
        private int soundOnOff;
        private int resolution;
        private int musicOnOff;
        private String iD;
        private String langSelection;

        public int WindowMode { get => windowMode; set => windowMode = value; }
        public int SoundOnOff { get => soundOnOff; set => soundOnOff = value; }
        public int Resolution { get => resolution; set => resolution = value; }
        public int MusicOnOff { get => musicOnOff; set => musicOnOff = value; }
        public string ID { get => iD; set => iD = value; }
        public string LangSelection { get => langSelection; set => langSelection = value; }
    }

    public enum Resolutions
    {
        R640x480 = 0,
        R800x600 = 1,
        R1024x768 = 2,
        R1280x1024 = 3,
        R1336x768 = 4,
        R1440x900 = 5,
        R1600x900 = 6,
        R1680x1050 = 7,
        R1920x1080 = 8

    }

    /*
     *     reg.RootKey := HKEY_CURRENT_USER;
    reg.OpenKey('Software\Webzen\Mu\Config', true);*/
}
