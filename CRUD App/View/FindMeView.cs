using System.Diagnostics;
using System.Windows.Forms;

namespace CRUD_App.View
{
    public partial class FindMeView : Form, InterfaceFindMe
    {
        public FindMeView()
        {
            InitializeComponent();
            buttonClose.Click += delegate { this.Close(); };
        }
        private static FindMeView instance;
        public static FindMeView getInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FindMeView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();

                if (instance != null || instance.IsAccessible)
                {
                    instance.Dispose();
                }
            }
            return instance;
        }
        //Microsoft bug where if you click many times on the button that opens the view it bugs out the validator reference :( (Solution: close it with the X button and open it again with the exmple: Animals button))
        private void findME()
        {
            Process.Start("https://github.com/PinkFlamingoz");
        }
        private void pictureBox5_Click(object sender, System.EventArgs e)
        {
            findME();
        }

        private void pictureBox4_Click(object sender, System.EventArgs e)
        {
            findME();
        }

        private void pictureBox3_Click(object sender, System.EventArgs e)
        {
            findME();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            findME();
        }
    }
}
