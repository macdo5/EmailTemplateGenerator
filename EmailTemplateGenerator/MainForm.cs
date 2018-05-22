using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailTemplateGenerator
{
    public partial class MainForm : Form
    {
        TemplateFactory templateFactory;
        Ini iBrainData;
        public MainForm()
        {
            InitializeComponent();
            templateFactory = new TemplateFactory();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // check if user settings have been loaded
            if (Properties.Settings.Default.iBrainDataPath == "" || Properties.Settings.Default.userSignOff == "")
            {
                ShowiBrainPathDialogBox();
            }
            iBrainData = new Ini(Properties.Settings.Default.iBrainDataPath);
            comboBoxClients.DataSource = iBrainData.GetKeys(Constants.CLIENT_IDS);
            comboBoxTemplates.DataSource = templates.GetKeys();
        }

        private void ShowiBrainPathDialogBox()
        {
            FormSettingsDialog iBrainPathDialogBox = new FormSettingsDialog();
            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (iBrainPathDialogBox.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                Properties.Settings.Default.iBrainDataPath = iBrainPathDialogBox.GetiBrainPath();
                Properties.Settings.Default.userSignOff = iBrainPathDialogBox.GetUserSignoff();
            }
            else
            {
                iBrainPathDialogBox.Dispose();
                this.Close();
            }
            iBrainPathDialogBox.Dispose();
        }

        private void comboBoxTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            string templateName = comboBoxTemplates.Text;
            Template template = templateFactory.BuildTemplate(templateName);
        }
    }
}
