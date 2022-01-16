using Bussiness;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LossControl
{
    public partial class FrmLoadSystem : Form
    {
        public FrmLoadSystem()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pbLoadProgress.Value < 100)
            {
                pbLoadProgress.Value += 4;
            }
            else
            {
                 timer.Enabled = false;

                this.Visible = false;
                new FrmLossCollector().ShowDialog();
            }
        }

       [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pbLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
