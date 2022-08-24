using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CRUD_App.View
{
    public partial class MainView : Form, MainInterface
    {
        public MainView()
        {
            InitializeComponent();
            CollapseMenu();
            iconButtonAnimals.Click += delegate { showAnimalView?.Invoke(this, EventArgs.Empty); };
            iconButtonFindMe.Click += delegate { showFindMeView?.Invoke(this, EventArgs.Empty); };
            iconButtonAnimals.Select();
            setColorUI(iconButtonAnimals);
        }

        public event EventHandler showAnimalView;
        public event EventHandler showFindMeView;

        private IconButton clickedButton;
        private void setColorUI(object button)
        {
            var btn = (IconButton)button;
            btn.BackColor = Color.FromArgb(181, 223, 204);
            btn.ForeColor = Color.Black;
            btn.IconColor = Color.Black;
            if (clickedButton != null & clickedButton != btn)
            {
                clickedButton.BackColor = Color.FromArgb(60, 65, 74);
                clickedButton.ForeColor = Color.White;
                clickedButton.IconColor = Color.White;
            }
            clickedButton = btn;
        }

        private void iconButtonFindMe_Click(object sender, EventArgs e)
        {
            setColorUI(sender);
        }

        private void iconButtonAnimals_Click(object sender, EventArgs e)
        {
            setColorUI(sender);
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200)
            {
                panelMenu.Width = 70;
                panelTitle.Height = 0;
                iconPictureBoxTitle.Visible = false;
                labelTitle.Visible = false;
                labelSubTitle.Visible = false;
                iconButtonMenuOpenClose.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }
            }
            else
            {
                panelMenu.Width = 241;
                panelTitle.Height = 95;
                iconPictureBoxTitle.Visible = true;
                labelTitle.Visible = true;
                labelSubTitle.Visible = true;
                iconButtonMenuOpenClose.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }
            }
        }
        private void iconButtonMenuOpenClose_Click(object sender, EventArgs e)
        {
            CollapseMenu();
            setColorUI(sender);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            iconButtonAnimals.PerformClick();
        }

        private void iconButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
