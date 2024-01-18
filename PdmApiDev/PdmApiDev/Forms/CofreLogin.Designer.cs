namespace PdmApiDev
{
    partial class CofreLogin
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
            this.lbCofre = new System.Windows.Forms.Label();
            this.cofreTxt = new System.Windows.Forms.TextBox();
            this.btnLogar = new System.Windows.Forms.Button();
            this.lbUser = new System.Windows.Forms.Label();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.passTxt = new System.Windows.Forms.TextBox();
            this.lbPASS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbCofre
            // 
            this.lbCofre.AutoSize = true;
            this.lbCofre.Location = new System.Drawing.Point(31, 34);
            this.lbCofre.Name = "lbCofre";
            this.lbCofre.Size = new System.Drawing.Size(32, 13);
            this.lbCofre.TabIndex = 0;
            this.lbCofre.Text = "Cofre";
            // 
            // cofreTxt
            // 
            this.cofreTxt.Location = new System.Drawing.Point(69, 31);
            this.cofreTxt.Name = "cofreTxt";
            this.cofreTxt.Size = new System.Drawing.Size(100, 20);
            this.cofreTxt.TabIndex = 1;
            // 
            // btnLogar
            // 
            this.btnLogar.Location = new System.Drawing.Point(78, 110);
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLogar.TabIndex = 2;
            this.btnLogar.Text = "Logar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.btnLogar_Click);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Location = new System.Drawing.Point(26, 61);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(37, 13);
            this.lbUser.TabIndex = 3;
            this.lbUser.Text = "USER";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(69, 57);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(100, 20);
            this.userTxt.TabIndex = 4;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(69, 84);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(100, 20);
            this.passTxt.TabIndex = 5;
            // 
            // lbPASS
            // 
            this.lbPASS.AutoSize = true;
            this.lbPASS.Location = new System.Drawing.Point(29, 90);
            this.lbPASS.Name = "lbPASS";
            this.lbPASS.Size = new System.Drawing.Size(35, 13);
            this.lbPASS.TabIndex = 6;
            this.lbPASS.Text = "PASS";
            // 
            // CofreLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 142);
            this.Controls.Add(this.lbPASS);
            this.Controls.Add(this.passTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.btnLogar);
            this.Controls.Add(this.cofreTxt);
            this.Controls.Add(this.lbCofre);
            this.Name = "CofreLogin";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCofre;
        private System.Windows.Forms.TextBox cofreTxt;
        private System.Windows.Forms.Button btnLogar;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox passTxt;
        private System.Windows.Forms.Label lbPASS;
    }
}