using System.Windows.Forms;

namespace LossControl
{
    public static class OpenForm
    {
        public static void OpenUserControl(UserControl userControl, string nameUserControl)
        {
            if (!FrmLossCollector.Instance.PnPageContainer.Controls.ContainsKey(nameUserControl))
            {
                userControl.Dock = DockStyle.Fill;
                FrmLossCollector.Instance.PnPageContainer.Controls.Add(userControl);
            }

            FrmLossCollector.Instance.PnPageContainer.Controls[nameUserControl].BringToFront();
        }

        public static void ShowForm(Form form, Form formCurrent)
        {
            if (formCurrent.Name != "FrmLossCollector")
                formCurrent.Close();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            FrmLossCollector.Instance.PnPageContainer.Controls.Add(form);
            FrmLossCollector.Instance.PnPageContainer.Tag = form;
            form.BringToFront();
            form.Show();
        }
    }
}
