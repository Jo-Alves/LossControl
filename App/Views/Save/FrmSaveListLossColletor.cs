using Bussiness;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LossControl
{
    public partial class FrmSaveListLossColletor : Form
    {
        int id;
       public bool listHasBeenSaved = false;

        public FrmSaveListLossColletor()
        {
            InitializeComponent();
            cbxProduct.Focus();
            cbxProduct.DataSource = lossProductCollections.FindAllProduct();
            cbxProduct.DisplayMember = "product";
        }

        LossProductCollections lossProductCollections = new LossProductCollections();

        public FrmSaveListLossColletor(int id)
        {
            InitializeComponent();            
            var listLostProductCollections = lossProductCollections.FindById(id);
            this.id = id;
            if (listLostProductCollections.Rows.Count > 0)
            {                
                cbxProduct.Text = listLostProductCollections.Rows[0]["product"].ToString();
                txtWeigth.Text = listLostProductCollections.Rows[0]["wheigth"].ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            this.btnClose.Image = Properties.Resources.icons8_close_window_32px_enter;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            this.btnClose.Image = Properties.Resources.icons8_close_window_32px_leave;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lossProductCollections.id = id;
            lossProductCollections.product = cbxProduct.Text.Trim();
            lossProductCollections.wheigth = decimal.Parse(txtWeigth.Text.Trim());
            lossProductCollections.removal_date = DateTime.Now.ToShortDateString();
            lossProductCollections.Save();

            listHasBeenSaved = true;
            this.Close();
        }     

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]

        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmResponsiblesStudent_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void FrmResponsiblesStudent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave_Click(sender, e);
            else if (e.KeyCode == Keys.Escape)
                btnCancel_Click(sender, e);

        }

        private void txtWeigth_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormatTextBox.HandleFormatTextBox(txtWeigth, e);
        }

        private void txtweigth_Leave(object sender, EventArgs e)
        {
            txtWeigth.Text = FormatTextBox.FormatValueDecimal(txtWeigth.Text);
        }
    }
}
