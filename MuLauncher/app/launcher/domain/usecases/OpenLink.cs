using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.launcher.domain.usecases
{
    abstract class OpenLinkExternal
    {
        public abstract void execute(String pLink);
    }

    class OpenLinkImpl : OpenLinkExternal
    {

        public override void execute(String pLink)
        {
            System.Diagnostics.Process.Start(pLink);
        }
    }
}
