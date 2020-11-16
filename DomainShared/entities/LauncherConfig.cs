using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuLauncher.app.launcher.domain.entities
{
    public abstract class LauncherConfig
    {
        String mainName;
        String baseURL;
        String forumURL;
        String webSiteURL;
        String serverName;

        public string MainName { get => mainName; set => mainName = value; }
        public string BaseURL { get => baseURL; set => baseURL = value; }
        public string ForumURL { get => forumURL; set => forumURL = value; }
        public string WebSiteURL { get => webSiteURL; set => webSiteURL = value; }
        public string ServerName { get => serverName; set => serverName = value; }
    }
}
