using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmailTemplateGenerator
{
    public class Template
    {
        private string emailTemplate;
        private UserControl templateControls;
        public Template(string emailTemplate, UserControl templateControls)
        {
            this.emailTemplate = emailTemplate;
            this.templateControls = templateControls;
        }
    }
}
