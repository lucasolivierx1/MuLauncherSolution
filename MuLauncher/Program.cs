using MuLauncher.ui;
using MuLauncher.variants.mubrgames.config;
using System;
using System.Windows.Forms;

namespace MuLauncher.variants.mubrgames
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
         
            MainController controller = new MainController(new MuBrGamesConfig(), new MuBrGamesContainer());
            
            ifMain main = new ifMain(controller);

            Application.Run(main);
        }
    }
}
