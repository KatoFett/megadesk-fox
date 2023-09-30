using System;
using System.Drawing;
using System.Windows.Forms;

namespace MegaDesk_Fox
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            foreach (ProductionDays item in Enum.GetValues(typeof(ProductionDays)))
                cbProductionDays.Items.Add(item);
            foreach (DesktopMaterial item in Enum.GetValues(typeof(DesktopMaterial)))
                cbMaterial.Items.Add(item);

            // Set constraints.
            nmWidth.Minimum = Desk.MINWIDTH;
            nmWidth.Maximum = Desk.MAXWIDTH;

            nmDepth.Minimum = Desk.MINDEPTH;
            nmDepth.Maximum = Desk.MAXDEPTH;

            nmDrawers.Minimum = Desk.MINDRAWERS;
            nmDrawers.Maximum = Desk.MAXDRAWERS;

            // Set default values.
            cbProductionDays.SelectedIndex = 0;
            nmWidth.Value = Desk.MINWIDTH;
            nmDepth.Value = Desk.MINDEPTH;
            nmDrawers.Value = Desk.MINDRAWERS;
        }

        #region Events

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner?.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var quote = new DeskQuote
                {
                    CustomerName = txtCustomer.Text,
                    ProductionDays = (ProductionDays)cbProductionDays.SelectedItem,
                    Desk = new Desk
                    {
                        Width = (int)nmWidth.Value,
                        Depth = (int)nmDepth.Value,
                        Drawers = (int)nmDrawers.Value,
                        Material = (DesktopMaterial)cbMaterial.SelectedItem
                    }
                };

                var form = new DisplayQuote(quote);
                form.Show(Owner);
                Owner = null;
                Close();
            }
        }

        #endregion

        #region Validation

        private void txtCustomer_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCustomer.Text))
            {
                errorProvider1.SetError(txtCustomer, "The customer name is required.");
                e.Cancel = true;
            }
        }

        private void cbMaterial_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cbMaterial.SelectedItem == null)
            {
                errorProvider1.SetError(cbMaterial, "The material is required.");
                e.Cancel = true;
            }
        }

        private void Control_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, null);
        }

        private void txtCustomer_TextChanged(object sender, EventArgs e)
        {
            Validate();
        }

        private void cbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validate();
        }

        #endregion
    }
}
