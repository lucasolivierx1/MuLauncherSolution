using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuLauncher.variants
{
    public interface IPosition
    {
        Point GetPosition();
    }

    public abstract class ComponentDefault
    {
        public Control component;
        public abstract Size getSize();

        public abstract void Build(Form pForm);

    }

    public abstract class WebViewComponent : ComponentDefault, IPosition
    {
        virtual public Point GetPosition()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class LauncherLayout : ComponentDefault
    {
        public abstract Color getPrimaryColor();

        public abstract Color getPrimaryColorDark();

        public abstract Color getPrimaryColorAccent();

        public abstract Image getBackgroundImage();

    }

    public abstract class LauncherButton : ComponentDefault, IPosition
    {
        public abstract Image getButtonDisabledImage();

        public abstract Image getButtonEnabledImage();

        public abstract Image getButtonOnHolderImage();

        public abstract Image getButtonOnPressedImage();

        virtual public Point GetPosition()
        {
            throw new NotImplementedException();
        }
    }

    public abstract class LauncherText : ComponentDefault, IPosition
    {

        public abstract Font getFont();

        virtual public Point GetPosition()
        {
            throw new NotImplementedException();
        }

        public abstract Color getTextColor();

        public abstract bool IsBold();

    }
}
