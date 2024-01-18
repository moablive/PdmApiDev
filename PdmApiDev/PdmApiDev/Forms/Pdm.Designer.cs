namespace PdmApiDev
{
    partial class Pdm
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
            this.LoginGRB = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnUserLogin = new System.Windows.Forms.Button();
            this.LoginGRB.SuspendLayout();
            this.SuspendLayout();
            // 
            // LoginGRB
            // 
            this.LoginGRB.Controls.Add(this.btnUserLogin);
            this.LoginGRB.Controls.Add(this.btnLogin);
            this.LoginGRB.Location = new System.Drawing.Point(48, 45);
            this.LoginGRB.Name = "LoginGRB";
            this.LoginGRB.Size = new System.Drawing.Size(280, 125);
            this.LoginGRB.TabIndex = 0;
            this.LoginGRB.TabStop = false;
            this.LoginGRB.Text = "Login PDM";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(27, 48);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(98, 49);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnUserLogin
            // 
            this.btnUserLogin.Location = new System.Drawing.Point(148, 48);
            this.btnUserLogin.Name = "btnUserLogin";
            this.btnUserLogin.Size = new System.Drawing.Size(98, 49);
            this.btnUserLogin.TabIndex = 1;
            this.btnUserLogin.Text = "User Login";
            this.btnUserLogin.UseVisualStyleBackColor = true;
            this.btnUserLogin.Click += new System.EventHandler(this.btnUserLogin_Click);
            // 
            // Pdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 206);
            this.Controls.Add(this.LoginGRB);
            this.Name = "Pdm";
            this.Text = "PDM - API";
            this.LoginGRB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox LoginGRB;
        private System.Windows.Forms.Button btnUserLogin;
        private System.Windows.Forms.Button btnLogin;
    }
}

