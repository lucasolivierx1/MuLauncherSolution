using MuLauncher.app.launcher.domain.entities;


namespace MuLauncher.variants.mubrgames.config
{
    internal class MuBrGamesConfig : LauncherConfig
    {
        public MuBrGamesConfig() {

            this.MainName = "Main.exe";
            this.ServerName = "Mu BRGames";
            this.BaseURL = "http://localhost/launcher/";
            this.ForumURL = "http://google.com.br";
            this.WebSiteURL = "http://google.com.br";

        }
    }
}
