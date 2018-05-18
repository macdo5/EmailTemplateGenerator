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
    public partial class FormSettingsDialog : Form
    {
        public FormSettingsDialog()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public string GetiBrainPath()
        {
            return iBrainPathTextBox.Text;
        }

        public string GetUserSignoff()
        {
            return richTextBoxUserSignoff.Text;
        }
    }
}
