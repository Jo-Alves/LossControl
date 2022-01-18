using Bussiness;
using System;
using System.Data;
using System.Windows.Forms;

namespace LossControl
{
    public partial class FrmOptionsSave : Form
    {

        LossProductCollections lossProductCollections = new LossProductCollections();
        public FrmOptionsSave()
        {
            InitializeComponent();
        }

        DataTable listLostProductCollection = null;

        private void LoadListLossProductCollections()
        {
            dgvDataLossProductCollections.Rows.Clear();           

            if (cbShowItem.Checked)
            {
                listLostProductCollection = string.IsNullOrWhiteSpace(txtSearchProduct.Text) ?
                  lossProductCollections.FindAllByDate(DateTime.Now.ToShortDateString()) :
                  lossProductCollections.FindAllByDate(DateTime.Now.ToShortDateString(), txtSearchProduct.Text.Trim());
            }
            else
                listLostProductCollection = string.IsNullOrWhiteSpace(txtSearchProduct.Text) ?
                  lossProductCollections.FindAllByDateSumWheigth(DateTime.Now.ToShortDateString()) :
                  lossProductCollections.FindAllByDateSumWheigth(DateTime.Now.ToShortDateString(), txtSearchProduct.Text.Trim());


            foreach (DataRow dr in listLostProductCollection.Rows)
            {
                int coutRow = dgvDataLossProductCollections.Rows.Add();
                dgvDataLossProductCollections.Rows[coutRow].Cells["edit"].Value = Properties.Resources.icons8_pencil_25px;
                dgvDataLossProductCollections.Rows[coutRow].Cells["delete"].Value = Properties.Resources.icons8_trash_25px;
                dgvDataLossProductCollections.Rows[coutRow].Cells["id"].Value = cbShowItem.Checked ? dr["id"].ToString() : "";
                dgvDataLossProductCollections.Rows[coutRow].Cells["product"].Value = dr["product"].ToString();
                dgvDataLossProductCollections.Rows[coutRow].Cells["wheigth"].Value = dr["wheigth"].ToString();
                dgvDataLossProductCollections.Rows[coutRow].Cells["removalDate"].Value = dr["removal_date"].ToString();

                dgvDataLossProductCollections.Rows[coutRow].MinimumHeight = 45;

                dgvDataLossProductCollections.ClearSelection();
            }
        }

      
        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            LoadListLossProductCollections();
        }

        private void cbShowItem_CheckedChanged(object sender, EventArgs e)
        {
            if (btnListItems.Visible == true) return;

            LoadListLossProductCollections();
            dgvDataLossProductCollections.Columns["edit"].Visible = cbShowItem.Checked ?  true: false;
            dgvDataLossProductCollections.Columns["delete"].Visible = cbShowItem.Checked ? true : false;
        }

        private void btnAddListLossProductCollector_Click(object sender, EventArgs e)
        {
            var saveListLossCollector = new FrmSaveListLossColletor();
            saveListLossCollector.ShowDialog();
            if (saveListLossCollector.listHasBeenSaved)
            {
                btnListItems.Visible = false;
                LoadListLossProductCollections();
            }
        }

        private void dgvDataLossProductCollections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    dgvDataLossProductCollections.ClearSelection();

                    int id = int.Parse(dgvDataLossProductCollections.CurrentRow.Cells["id"].Value.ToString());

                    if (dgvDataLossProductCollections.Columns["edit"].Visible == false && dgvDataLossProductCollections.Columns["delete"].Visible == false)
                        return;

                    if (dgvDataLossProductCollections.CurrentCell.ColumnIndex == 0)
                    {
                        var frmSaveListLossColletor = new FrmSaveListLossColletor(id);
                        frmSaveListLossColletor.ShowDialog();
                        if (frmSaveListLossColletor.listHasBeenSaved)
                            LoadListLossProductCollections();
                    }
                    else if (dgvDataLossProductCollections.CurrentCell.ColumnIndex == 1)
                    {
                        if (MessageBox.Show($"Deseja realmente excluir os dados de {dgvDataLossProductCollections.CurrentRow.Cells["product"].Value}?", "COLETOR DE PERDAS DE FRUTAS E VERDURAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            lossProductCollections.Delete(id);
                            dgvDataLossProductCollections.Rows.Remove(dgvDataLossProductCollections.CurrentRow);
                            dgvDataLossProductCollections.ClearSelection();
                            //if (dgvDataLossProductCollections.Rows.Count == 0)
                            //{
                            //    OpenForm.ShowForm(new FrmOptionsSave(), this);
                            //}
                        }
                    }                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "COLETOR DE PERDAS DE FRUTAS E VERDURAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnListItems_Click(object sender, EventArgs e)
        {
            LoadListLossProductCollections();

            if (listLostProductCollection.Rows.Count == 0)
            {
                MessageBox.Show($"Não há items de perdas de produtos listado no dia {DateTime.Now.ToShortDateString()}!", "COLETOR DE PERDAS DE FRUTAS E VERDURAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            btnListItems.Visible = false;
        }
    }
}