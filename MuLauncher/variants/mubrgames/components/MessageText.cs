using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuLauncher.variants.mubrgames.components
{
    public class MessageText : LauncherText
    {
        public override Point GetPosition()
        {
            return new Point(420, 550);
        }
        public override Font getFont()
        {
            throw new NotImplementedException();
        }

        public override Size getSize()
        {
            return new Size(550, 20);
        }

        public override Color getTextColor()
        {
            return Color.FromArgb(171, 171, 171);
        }

        public override bool IsBold()
        {
            return true;
        }

        public override void Build(Form pForm)
        {
            Label label = new Label();
            label.ForeColor = getTextColor();
            label.Location = GetPosition();
            label.Text = "";
            label.Size = getSize();
            label.TextAlign = ContentAlignment.MiddleCenter;

            if (IsBold())
                label.Font = new Font(Label.DefaultFont, FontStyle.Bold);

            label.BackColor = Color.Transparent;
            component = label;

            pForm.Controls.Add(component);
        }
    }
}
