using MuLauncher.variants.mubrgames.components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.variants.mubrgames
{
    class MuBrGamesContainer : LauncherContainer
    {
        public MuBrGamesContainer() {
            this.LauncherLayout = new BrGamesLauncherLayout();
            this.PlayButton = new PlayButton();
            this.ConfigButton = new ConfigButton();
            this.CloseButton = new CloseButton();
            this.MinimizeButton = new MinimizeButton();
            this.SaveButton = new SaveButton();
            this.WebSiteButton = new WebSiteButton();
            this.CurrentUpdate = new CurrentUpdate();
            this.UpdateTotal = new UpdateTotal();
            this.MessageUpdate = new MessageText();
            this.WebView = new BrWebView();
        }
    }
}
