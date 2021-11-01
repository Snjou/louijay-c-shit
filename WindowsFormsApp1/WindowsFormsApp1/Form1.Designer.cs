
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(275, 108);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(195, 20);
            this.txtname.TabIndex = 0;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // btnsubmit
            // 
            this.btnsubmit.Location = new System.Drawing.Point(345, 217);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(75, 23);
            this.btnsubmit.TabIndex = 1;
            this.btnsubmit.Text = "Submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(275, 155);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(195, 20);
            this.txtpass.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.txtname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.MaskedTextBox txtpass;
    }
}

