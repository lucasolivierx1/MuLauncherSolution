using MuLauncher.app.configs.presenters;
using MuLauncher.app.domain.entities;
using MuLauncher.app.domain.usecases;
using MuLauncher.app.launcher.domain.callbacks;
using MuLauncher.app.launcher.domain.entities;
using MuLauncher.app.launcher.domain.repositories;
using MuLauncher.app.launcher.domain.usecases;
using MuLauncher.app.launcher.external.datasources;
using MuLauncher.app.launcher.external.services;
using MuLauncher.app.launcher.infra.datasource;
using MuLauncher.app.launcher.infra.repositories;
using MuLauncher.app.launcher.infra.services;
using MuLauncher.ui;
using MuLauncher.variants;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace MuLauncher
{

    public partial class ifMain : Form
    {

        #region MoveForm with Mouse Definitions
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private MainController controller;

        public ifMain(MainController controller)
        {

            this.controller = controller;

            controller.buildComponents(this);

            controller.Container.PlayButton.component.Click += btnPlay_Click;
            controller.Container.PlayButton.component.MouseDown += btn_play_MouseDown;
            controller.Container.PlayButton.component.MouseUp += btn_play_MouseUp;

            controller.Container.WebSiteButton.component.MouseDown += btn_website_MouseDown;
            controller.Container.WebSiteButton.component.MouseUp += btn_website_MouseUp;
            controller.Container.WebSiteButton.component.Click += btn_website_Click;


            controller.Container.ConfigButton.component.Click += btn_config_Click;
            controller.Container.ConfigButton.component.MouseDown += btn_config_MouseDown;
            controller.Container.ConfigButton.component.MouseUp += btn_config_MouseUp;


            controller.Container.CloseButton.component.Click += btn_close_Click;

            controller.Container.MinimizeButton.component.Click += btn_minimize_Click;

            #region Subscribles
            controller.MsgSubj.Subscribe((value) => this.Invoke((MethodInvoker)delegate
            {
                controller.Container.MessageUpdate.component.Text = value.ToString();
            }));

            controller.PlayButtonEnabledSubj.Subscribe((value) => this.Invoke((MethodInvoker)delegate
            {
                if (value)
                    controller.Container.PlayButton.component.BackgroundImage = controller.Container.PlayButton.getButtonEnabledImage();
                else
                    controller.Container.PlayButton.component.BackgroundImage = controller.Container.PlayButton.getButtonDisabledImage();

                controller.Container.PlayButton.component.Enabled = value;
                controller.Container.PlayButton.component.Refresh();
                
            }));

            #endregion

            (controller.Container.WebView.component as WebBrowser).Navigate(controller.Config.BaseURL);
            InitializeComponent();
        }

        private void ifMain_Shown(object sender, EventArgs e)
        {
            controller.Container.LauncherLayout.Build(this);

            (controller.Container.TotalProgressBar.component as SmoothProgressBar).Value = 50;
            (controller.Container.TotalProgressBar.component as SmoothProgressBar).Maximum = 100;
            (controller.Container.CurrentProgressBar.component as SmoothProgressBar).Value = 50;
            (controller.Container.CurrentProgressBar.component as SmoothProgressBar).Maximum = 100;

            timer1.Enabled = true;

         }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            controller.startGameCall();
            controller.Container.CurrentUpdate.component.Focus();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            controller.checkUpdateCall();
        }

        #region MoveForm with Mouse Implementation
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region btn_config_mouse
        private void btn_config_MouseDown(object sender, MouseEventArgs e)
        {
            setConfigButtonPressed(true);
        }

        private void btn_config_MouseUp(object sender, MouseEventArgs e)
        {
            setConfigButtonPressed(false);
        }

        private void setConfigButtonPressed(bool isPressed)
        {
            if (isPressed)
                controller.Container.ConfigButton.component.BackgroundImage = controller.Container.ConfigButton.getButtonOnPressedImage();
            else
                controller.Container.ConfigButton.component.BackgroundImage = controller.Container.ConfigButton.getButtonEnabledImage();

        }



        #endregion

        #region btn_website_mouse

        private void btn_website_MouseDown(object sender, MouseEventArgs e)
        {
            setWebSiteButtonPressed(true);
        }

        private void btn_website_MouseUp(object sender, MouseEventArgs e)
        {
            setWebSiteButtonPressed(false);
        }

        private void btn_website_Click(object sender, EventArgs e)
        {
            controller.openExternalLinkCall(controller.Config.WebSiteURL);
        }


        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void setWebSiteButtonPressed(bool isPressed)
        {
            if (isPressed)
                controller.Container.WebSiteButton.component.BackgroundImage = controller.Container.WebSiteButton.getButtonOnPressedImage();
            else
                controller.Container.WebSiteButton.component.BackgroundImage = controller.Container.WebSiteButton.getButtonEnabledImage();
        }


        #endregion

        #region btn_play_mouse

        private void btn_play_MouseDown(object sender, MouseEventArgs e)
        {
            setPlayButtonPressed(true);
        }

        private void btn_play_MouseUp(object sender, MouseEventArgs e)
        {
            setPlayButtonPressed(false);
        }

        private void setPlayButtonPressed(bool isPressed)
        {

            if (!controller.Container.PlayButton.component.Enabled) return;

            if (isPressed)
                controller.Container.PlayButton.component.BackgroundImage = controller.Container.PlayButton.getButtonOnPressedImage();
            else
                controller.Container.PlayButton.component.BackgroundImage = controller.Container.PlayButton.getButtonEnabledImage();

        }

        #endregion


        #region ConfigButton 
 

        private void btn_config_Click(object sender, EventArgs e)
        {
              
            ifConfig config = new ifConfig();
            config.Show();
        }

        private void btn_play_Paint(object sender, PaintEventArgs e)
        {

        }



        #endregion
    }
}
