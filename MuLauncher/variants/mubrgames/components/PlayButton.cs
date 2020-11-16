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
    class PlayButton : LauncherButton
    {
        public override Image getButtonDisabledImage()
        {
            return Resources.mubrgames_jogar_disabled;
        }

        public override Image getButtonEnabledImage()
        {
            return Resources.mubrgames_jogar_enabled;
        }

        public override Image getButtonOnHolderImage()
        {
            throw new NotImplementedException();
        }

        public override Image getButtonOnPressedImage()
        {
            return Resources.mubrgames_jogar_pressed;
        }

        public override Size getSize()
        {
           return new Size(287, 77);
        }
        public override Point GetPosition()
        {
            return new Point(36, 520);
        }

        public override void Build(Form pForm)
        {
            Button button = new Button();
            button.Size = getSize();
            button.Location =GetPosition();
            button.Text = "";
            button.BackgroundImage = getButtonDisabledImage();
            button.TabStop = false;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.BackColor = Color.Transparent;
            button.Enabled = false;

            component = button;
            pForm.Controls.Add(component);
        }
    }
}
