using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuLauncher.variants.mubrgames.components
{
    public class UpdateTotal : LauncherText
    {
        public override Point GetPosition()
        {
            return new Point(355, 560);
        }

        public override Font getFont()
        {
            throw new NotImplementedException();
        }

        public override Size getSize()
        {
            return new Size(460, 20);
        }

        public override Color getTextColor()
        {
            return Color.FromArgb(0,167,250);
        }

        public override bool IsBold()
        {
            return true;
        }

        public override void Build(Form pForm)
        {

            Label label = new Label();
            label.FlatStyle = FlatStyle.Flat;
            label.ForeColor = getTextColor();
            label.Location = GetPosition();


            if (IsBold())
                label.Font = new Font(Label.DefaultFont, FontStyle.Bold);

            label.BackColor = Color.Transparent;
            label.Text = "TOTAL";

            component = label;
            pForm.Controls.Add(label);
        }
    }
}
