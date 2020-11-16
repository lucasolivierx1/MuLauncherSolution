using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuLauncher.variants.mubrgames.components
{
    public class CurrentUpdate : LauncherText, IPosition
    {
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
            return Color.Green;
        }

        public override bool IsBold()
        {
            return true;
        }

        public override Point GetPosition()
        {
            return new Point(355,580);
        }
        public override void Build(Form pForm)
        {
            Label label = new Label();
            label.Name = "current_update";
            label.FlatStyle = FlatStyle.Flat;
            label.ForeColor = getTextColor();
            label.Location = GetPosition();


            if (IsBold())
                label.Font = new Font(Label.DefaultFont, FontStyle.Bold);

            label.BackColor = Color.Transparent;
            label.Text = "UPDATE";

            component = label;
            pForm.Controls.Add(label);
        }
    }
}
