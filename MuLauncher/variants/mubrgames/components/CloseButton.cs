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
    class CloseButton : LauncherButton
    {
        public override Image getButtonDisabledImage()
        {
            return Resources.mubrgames_close;
        }

        public override Image getButtonEnabledImage()
        {
            return Resources.mubrgames_close;
        }

        public override Image getButtonOnHolderImage()
        {
            throw new NotImplementedException();
        }

        public override Image getButtonOnPressedImage()
        {
            throw new NotImplementedException();
        }

        public override Size getSize()
        {
            return new Size(12, 12);
        }

        public override Point GetPosition()
        {
            return new Point(1000,10);
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
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.BackColor = Color.Transparent;

            component = button;

            pForm.Controls.Add(component);

        }
    }
}
