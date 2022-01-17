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
            LoadItemsProductsInComboBox();
            cbxProduct.SelectedIndex = -1;
        }

        private void LoadItemsProductsInComboBox()
        {
            cbxProduct.DataSource = lossProductCollections.FindAllProduct();
            cbxProduct.DisplayMember = "product";
        }

        LossProductCollections lossProductCollections = new LossProductCollections();

        public FrmSaveListLossColletor(int id)
        {
            InitializeComponent();
            LoadItemsProductsInComboBox();
            cbxProduct.SelectedIndex = -1;
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
            if (btnSave.Text == "Salvar")
            {
                if (!ValidateFields()) return;

                lossProductCollections.id = id;
                lossProductCollections.product = cbxProduct.Text.ToUpper().Trim();
                lossProductCollections.wheigth = decimal.Parse(txtWeigth.Text.Trim());
                lossProductCollections.removal_date = DateTime.Now.ToShortDateString();
                lossProductCollections.Save();
                LoadItemsProductsInComboBox();
            }
            else
                LimparFields();

            btnSave.Text = (btnSave.Text == "Salvar" && id == 0) ? "Novo" : "Salvar";
            if (id > 0)
                this.Close();
            listHasBeenSaved = true;            
        }

        private void LimparFields()
        {
            cbxProduct.SelectedIndex = -1;
            txtWeigth.Clear();
        }

        ErrorProvider errorProvider = new ErrorProvider();

        private bool ValidateFields()
        {
            bool isFieldsValidated = false;

            if (string.IsNullOrWhiteSpace(cbxProduct.Text))
            {
                errorProvider.SetError(cbxProduct, "Preencha o campo Produto!");
                MessageBox.Show("Preencha o campo Produto!", "COLETOR DE PERDAS DE FRUTAS E VERDURAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbxProduct.Focus();
            }
            else if (string.IsNullOrWhiteSpace(cbxProduct.Text))
            {
                errorProvider.SetError(txtWeigth, "Preencha o campo Peso!");
                MessageBox.Show("Preencha o campo Peso!", "COLETOR DE PERDAS DE FRUTAS E VERDURAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtWeigth.Focus();
            }
            else
                isFieldsValidated = true;

            return isFieldsValidated;
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

        private void FrmSaveListLossCollector_KeyDown(object sender, KeyEventArgs e)
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

        private void cbxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }

        private void txtWeigth_TextChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
        }
    }
}
