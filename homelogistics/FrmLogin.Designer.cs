namespace homelogistics
{
  partial class FrmLogin
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
      this.lblTitle = new System.Windows.Forms.Label();
      this.lblUsername = new System.Windows.Forms.Label();
      this.lblPassword = new System.Windows.Forms.Label();
      this.btnLogin = new System.Windows.Forms.Button();
      this.txtUsername = new System.Windows.Forms.TextBox();
      this.txtPassword = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblTitle.Font = new System.Drawing.Font("JetBrains Mono NL", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.Location = new System.Drawing.Point(10, 10);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(181, 27);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "Homelogistics";
      // 
      // lblUsername
      // 
      this.lblUsername.AutoSize = true;
      this.lblUsername.Location = new System.Drawing.Point(12, 60);
      this.lblUsername.Name = "lblUsername";
      this.lblUsername.Size = new System.Drawing.Size(133, 14);
      this.lblUsername.TabIndex = 1;
      this.lblUsername.Text = "Nom d\'utilisateur:";
      // 
      // lblPassword
      // 
      this.lblPassword.AutoSize = true;
      this.lblPassword.Location = new System.Drawing.Point(12, 114);
      this.lblPassword.Name = "lblPassword";
      this.lblPassword.Size = new System.Drawing.Size(63, 14);
      this.lblPassword.TabIndex = 2;
      this.lblPassword.Text = "Password";
      // 
      // btnLogin
      // 
      this.btnLogin.Location = new System.Drawing.Point(107, 180);
      this.btnLogin.Name = "btnLogin";
      this.btnLogin.Size = new System.Drawing.Size(143, 23);
      this.btnLogin.TabIndex = 3;
      this.btnLogin.Text = "Se connecter";
      this.btnLogin.UseVisualStyleBackColor = true;
      this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
      // 
      // txtUsername
      // 
      this.txtUsername.Location = new System.Drawing.Point(15, 77);
      this.txtUsername.Name = "txtUsername";
      this.txtUsername.Size = new System.Drawing.Size(235, 22);
      this.txtUsername.TabIndex = 4;
      // 
      // txtPassword
      // 
      this.txtPassword.Location = new System.Drawing.Point(15, 131);
      this.txtPassword.Name = "txtPassword";
      this.txtPassword.PasswordChar = '*';
      this.txtPassword.Size = new System.Drawing.Size(235, 22);
      this.txtPassword.TabIndex = 5;
      // 
      // FrmLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Thistle;
      this.ClientSize = new System.Drawing.Size(263, 216);
      this.Controls.Add(this.txtPassword);
      this.Controls.Add(this.txtUsername);
      this.Controls.Add(this.btnLogin);
      this.Controls.Add(this.lblPassword);
      this.Controls.Add(this.lblUsername);
      this.Controls.Add(this.lblTitle);
      this.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "FrmLogin";
      this.Padding = new System.Windows.Forms.Padding(10);
      this.Text = "Login";
      this.Load += new System.EventHandler(this.Login_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblUsername;
    private System.Windows.Forms.Label lblPassword;
    private System.Windows.Forms.Button btnLogin;
    private System.Windows.Forms.TextBox txtUsername;
    private System.Windows.Forms.TextBox txtPassword;
  }
}