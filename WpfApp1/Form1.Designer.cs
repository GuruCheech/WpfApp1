namespace WpfApp1
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
            this.nametxtbox = new System.Windows.Forms.TextBox();
            this.pwdtxtbox = new System.Windows.Forms.TextBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.Usermanetxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // nametxtbox
            // 
            this.nametxtbox.AccessibleName = "nametxtbox";
            this.nametxtbox.BackColor = System.Drawing.SystemColors.Window;
            this.nametxtbox.Location = new System.Drawing.Point(37, 67);
            this.nametxtbox.Name = "nametxtbox";
            this.nametxtbox.Size = new System.Drawing.Size(196, 20);
            this.nametxtbox.TabIndex = 0;
            // 
            // pwdtxtbox
            // 
            this.pwdtxtbox.AccessibleName = "pwdtxtbox";
            this.pwdtxtbox.Location = new System.Drawing.Point(37, 108);
            this.pwdtxtbox.Name = "pwdtxtbox";
            this.pwdtxtbox.Size = new System.Drawing.Size(196, 20);
            this.pwdtxtbox.TabIndex = 1;
            // 
            // loginbutton
            // 
            this.loginbutton.AccessibleName = "loginbutton";
            this.loginbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginbutton.Location = new System.Drawing.Point(158, 174);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(75, 23);
            this.loginbutton.TabIndex = 2;
            this.loginbutton.Text = "LOGIN";
            this.loginbutton.UseVisualStyleBackColor = false;
            // 
            // Usermanetxt
            // 
            this.Usermanetxt.AutoSize = true;
            this.Usermanetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usermanetxt.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Usermanetxt.Location = new System.Drawing.Point(91, 51);
            this.Usermanetxt.Name = "Usermanetxt";
            this.Usermanetxt.Size = new System.Drawing.Size(76, 13);
            this.Usermanetxt.TabIndex = 3;
            this.Usermanetxt.Text = "USERNAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(91, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PASSWORD";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(22, 178);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(124, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "FORGOT PASSWORD?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(266, 244);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Usermanetxt);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.pwdtxtbox);
            this.Controls.Add(this.nametxtbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nametxtbox;
        private System.Windows.Forms.TextBox pwdtxtbox;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label Usermanetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}