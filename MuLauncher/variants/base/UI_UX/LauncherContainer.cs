using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.variants
{
    public class LauncherContainer {

        private LauncherLayout launcherLayout;

        private LauncherButton playButton;

        private LauncherButton configButton;

        private LauncherButton minimizeButton;

        private LauncherButton closeButton;

        private LauncherButton saveButton;

        private LauncherButton webSiteButton;

        private LauncherText updateTotal;

        private LauncherText currentUpdate;

        private LauncherText updateMessage;

        private LauncherText updatePercent;

        private LauncherText messageUpdate;

        private WebViewComponent webView;

        private LauncherProgressBar totalProgressBar;

        private LauncherProgressBar currentProgressBar;

        public LauncherLayout LauncherLayout { get => launcherLayout; set => launcherLayout = value; }
        public LauncherButton PlayButton { get => playButton; set => playButton = value; }
        public LauncherButton ConfigButton { get => configButton; set => configButton = value; }
        public LauncherButton MinimizeButton { get => minimizeButton; set => minimizeButton = value; }
        public LauncherButton CloseButton { get => closeButton; set => closeButton = value; }
        public LauncherButton SaveButton { get => saveButton; set => saveButton = value; }

        public LauncherButton WebSiteButton { get => webSiteButton; set => webSiteButton = value; }
        public LauncherText UpdateTotal { get => updateTotal; set => updateTotal = value; }
        public LauncherText CurrentUpdate { get => currentUpdate; set => currentUpdate = value; }
        public LauncherText UpdateMessage { get => updateMessage; set => updateMessage = value; }
        public LauncherText UpdatePercent { get => updatePercent; set => updatePercent = value; }
        public LauncherText MessageUpdate { get => messageUpdate; set => messageUpdate = value; }
        public WebViewComponent WebView { get => webView; set => webView = value; }
        public LauncherProgressBar TotalProgressBar { get => totalProgressBar; set => totalProgressBar = value; }
        public LauncherProgressBar CurrentProgressBar { get => currentProgressBar; set => currentProgressBar = value; }

        public LauncherContainer() { 
        
        }

        public LauncherContainer(LauncherLayout launcherLayout, 
                                 LauncherButton playButton, 
                                 LauncherButton configButton, 
                                 LauncherButton minimizeButton, 
                                 LauncherButton closeButton, 
                                 LauncherButton saveButton){

            this.LauncherLayout = launcherLayout;
            this.PlayButton = playButton;
            this.ConfigButton = configButton;
            this.MinimizeButton = minimizeButton;
            this.CloseButton = closeButton;
            this.SaveButton = saveButton;
        }
    }

}
