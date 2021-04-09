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
    class ConfigButton : LauncherButton
    {
        public override Image getButtonDisabledImage()
        {
            throw new NotImplementedException();
        }

        public override Image getButtonEnabledImage()
        {
            return Resources.mubrgames_options;
        }

        public override Image getButtonOnHolderImage()
        {
            throw new NotImplementedException();
        }

        public override Image getButtonOnPressedImage()
        {
            return Resources.mubrgames_options_pressed;
        }

        public override Size getSize()
        {
            return new Size(149, 50);
        }

        public override Point GetPosition()
        {
            return new Point(730, 70);
        }

        public override void Build(Form pForm)
        {
            Button button = new Button();
            button.Size = getSize();
            button.Location = GetPosition();
            button.Text = "";
            button.BackgroundImage = getButtonEnabledImage();
            button.TabStop = false;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            
            component = button;
            pForm.Controls.Add(component);

        }
    }

}
