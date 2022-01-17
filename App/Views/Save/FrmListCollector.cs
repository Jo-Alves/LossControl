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
            dgvDatalostProductCollections.Rows.Clear();           

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
                int coutRow = dgvDatalostProductCollections.Rows.Add();
                dgvDatalostProductCollections.Rows[coutRow].Cells["edit"].Value = Properties.Resources.icons8_pencil_25px;
                dgvDatalostProductCollections.Rows[coutRow].Cells["delete"].Value = Properties.Resources.icons8_trash_25px;
                dgvDatalostProductCollections.Rows[coutRow].Cells["id"].Value = cbShowItem.Checked ? dr["id"].ToString() : "";
                dgvDatalostProductCollections.Rows[coutRow].Cells["product"].Value = dr["product"].ToString();
                dgvDatalostProductCollections.Rows[coutRow].Cells["wheigth"].Value = dr["wheigth"].ToString();
                dgvDatalostProductCollections.Rows[coutRow].Cells["removalDate"].Value = dr["removal_date"].ToString();

                dgvDatalostProductCollections.Rows[coutRow].MinimumHeight = 45;

                dgvDatalostProductCollections.ClearSelection();
            }
        }

      
        private void txtSearchProduct_TextChanged(object sender, EventArgs e)
        {
            LoadListLossProductCollections();
        }

        private void cbShowItem_CheckedChanged(object sender, EventArgs e)
        {
            LoadListLossProductCollections();
            dgvDatalostProductCollections.Columns["edit"].Visible = cbShowItem.Checked ?  true: false;
            dgvDatalostProductCollections.Columns["delete"].Visible = cbShowItem.Checked ? true : false;
        }

        private void btnAddListLossProductCollector_Click(object sender, EventArgs e)
        {
            var saveListLossCollector = new FrmSaveListLossColletor();
            saveListLossCollector.ShowDialog();
            if (saveListLossCollector.listHasBeenSaved)
            {
                LoadListLossProductCollections();
            }
        }

        private void dgvDatalostProductCollections_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    dgvDatalostProductCollections.ClearSelection();

                    int id = int.Parse(dgvDatalostProductCollections.CurrentRow.Cells["id"].Value.ToString());

                    if (dgvDatalostProductCollections.CurrentCell.ColumnIndex == 0)
                    {
                        var frmSaveListLossColletor = new FrmSaveListLossColletor(id);
                        frmSaveListLossColletor.ShowDialog();
                        if (frmSaveListLossColletor.listHasBeenSaved)
                            LoadListLossProductCollections();
                    }
                    else if (dgvDatalostProductCollections.CurrentCell.ColumnIndex == 1)
                    {
                        if (MessageBox.Show($"Deseja realmente excluir os dados de {dgvDatalostProductCollections.CurrentRow.Cells["product"].Value}?", "COLETOR DE PERDAS DE FRUTAS E VERDURAS", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            lossProductCollections.Delete(id);
                            dgvDatalostProductCollections.Rows.Remove(dgvDatalostProductCollections.CurrentRow);
                            dgvDatalostProductCollections.ClearSelection();
                            //if (dgvDatalostProductCollections.Rows.Count == 0)
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

        private void btnListtems_Click(object sender, EventArgs e)
        {
            LoadListLossProductCollections();

            if (listLostProductCollection.Rows.Count == 0)
            {
                MessageBox.Show($"Não há items de perdas de produtos listado no dia {DateTime.Now.ToShortDateString()}!", "COLETOR DE PERDAS DE FRUTAS E VERDURAS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            btnListtems.Visible = false;
        }
    }
}