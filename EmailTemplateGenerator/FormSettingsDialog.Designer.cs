namespace EmailTemplateGenerator
{
    partial class FormSettingsDialog
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
            this.iBrainPathTextBox = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.richTextBoxUserSignoff = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the complete path to the iBrain Data directory on your computer.";
            // 
            // iBrainPathTextBox
            // 
            this.iBrainPathTextBox.Location = new System.Drawing.Point(13, 30);
            this.iBrainPathTextBox.Name = "iBrainPathTextBox";
            this.iBrainPathTextBox.Size = new System.Drawing.Size(370, 20);
            this.iBrainPathTextBox.TabIndex = 1;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(160, 271);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // richTextBoxUserSignoff
            // 
            this.richTextBoxUserSignoff.Location = new System.Drawing.Point(13, 78);
            this.richTextBoxUserSignoff.Name = "richTextBoxUserSignoff";
            this.richTextBoxUserSignoff.Size = new System.Drawing.Size(368, 187);
            this.richTextBoxUserSignoff.TabIndex = 3;
            this.richTextBoxUserSignoff.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Please enter your email signoff";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 306);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxUserSignoff);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.iBrainPathTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iBrainPathTextBox;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.RichTextBox richTextBoxUserSignoff;
        private System.Windows.Forms.Label label2;
    }
}