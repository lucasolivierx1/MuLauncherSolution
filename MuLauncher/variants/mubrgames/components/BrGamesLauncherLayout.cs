using MuLauncher.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuLauncher.variants.mubrgames.components
{
    class BrGamesLauncherLayout : LauncherLayout
    {
        public override void Build(Form pForm)
        {
            pForm.Size = getSize();
            pForm.BackgroundImage = getBackgroundImage();
            pForm.Refresh();
        }

        public override Image getBackgroundImage()
        {
            return Resources.mubrgames_launcher_background;
        }

        public override Color getPrimaryColor()
        {
            throw new NotImplementedException();
        }

        public override Color getPrimaryColorAccent()
        {
            throw new NotImplementedException();
        }

        public override Color getPrimaryColorDark()
        {
            throw new NotImplementedException();
        }

        public override Size getSize()
        {
            return new Size(1030, 620);
        }

    }
}
