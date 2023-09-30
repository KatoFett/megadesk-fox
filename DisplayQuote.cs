using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Fox
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(DeskQuote quote)
        {
            this.quote = quote;
            InitializeComponent();
            lblCustomer.Text = quote.CustomerName;
            lblDimensions.Text = $"{quote.Desk.Width}x{quote.Desk.Depth}";
            lblArea.Text = $"{quote.Desk.SurfaceArea} sq. in";
            lblDrawers.Text = quote.Desk.Drawers.ToString();
            lblMaterial.Text = quote.Desk.Material.ToString();
            lblProductionDays.Text = quote.ProductionDays.ToString();
            try
            {
                lblCost.Text = quote.TotalCost.ToString("C");
            }
            catch
            {
                lblCost.Text = "Invalid configuration";
            }
        }

        private DeskQuote quote;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner?.Show();
        }
    }
}
