namespace EmailTemplateGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAdressee = new System.Windows.Forms.TextBox();
            this.comboBoxTemplates = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTemplate = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client code";
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(13, 34);
            this.comboBoxClients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(280, 24);
            this.comboBoxClients.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adressee";
            // 
            // textBoxAdressee
            // 
            this.textBoxAdressee.Location = new System.Drawing.Point(12, 92);
            this.textBoxAdressee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxAdressee.Name = "textBoxAdressee";
            this.textBoxAdressee.Size = new System.Drawing.Size(160, 22);
            this.textBoxAdressee.TabIndex = 3;
            // 
            // comboBoxTemplates
            // 
            this.comboBoxTemplates.FormattingEnabled = true;
            this.comboBoxTemplates.Location = new System.Drawing.Point(12, 153);
            this.comboBoxTemplates.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTemplates.Name = "comboBoxTemplates";
            this.comboBoxTemplates.Size = new System.Drawing.Size(281, 24);
            this.comboBoxTemplates.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Template";
            // 
            // panelTemplate
            // 
            this.panelTemplate.Location = new System.Drawing.Point(13, 194);
            this.panelTemplate.Name = "panelTemplate";
            this.panelTemplate.Size = new System.Drawing.Size(1039, 418);
            this.panelTemplate.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 624);
            this.Controls.Add(this.panelTemplate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTemplates);
            this.Controls.Add(this.textBoxAdressee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxClients);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAdressee;
        private System.Windows.Forms.ComboBox comboBoxTemplates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTemplate;
    }
}

