using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows.licenser
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            AddEventHandlers();
        }

        private void AddEventHandlers()
        {
            Load += OnFormLoad;
            licenseRenewBtnElem.Click += OnLicenseRenew;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            editionSelectorElem.DataSource =
                LicenseEditionProvider.GetLicensePairs().Select(x => x.Value.edition).ToList();
        }

        private void OnLicenseRenew(object sender, EventArgs e)
        {
            try
            {
                var edition = editionSelectorElem.SelectedItem.ToString();
                var toRenewPair = LicenseEditionProvider.GetLicensePairs().FirstOrDefault(x => x.Value.edition == edition);
                if (toRenewPair == null) throw new Exception("Invalid edition");
                licenseRenewBtnElem.Text = "Renewing...";
                var bgw = new BackgroundWorker();
                bgw.DoWork += (object _, DoWorkEventArgs args) =>
                {
                    RenewHelper.TryRenew(toRenewPair);
                };
                bgw.RunWorkerCompleted += (object _, RunWorkerCompletedEventArgs args) =>
                {
                    if (args.Error == null)
                    {
                        MessageBox.Show("License sucussfully renewed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        var msg = args.Error?.Message ?? "Error during operation";
                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
                bgw.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                licenseRenewBtnElem.Text = "Renew License";
            }
        }
       
    }
}