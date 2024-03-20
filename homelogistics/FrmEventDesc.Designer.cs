namespace homelogistics
{
  partial class FrmEventDesc
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
      this.rtxDesc = new System.Windows.Forms.RichTextBox();
      this.lblNom = new System.Windows.Forms.Label();
      this.lblDesc = new System.Windows.Forms.Label();
      this.lblTextDate = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // rtxDesc
      // 
      this.rtxDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.rtxDesc.Location = new System.Drawing.Point(23, 78);
      this.rtxDesc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.rtxDesc.Name = "rtxDesc";
      this.rtxDesc.Size = new System.Drawing.Size(437, 225);
      this.rtxDesc.TabIndex = 0;
      this.rtxDesc.Text = "";
      // 
      // lblNom
      // 
      this.lblNom.AutoSize = true;
      this.lblNom.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNom.Location = new System.Drawing.Point(19, 22);
      this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblNom.Name = "lblNom";
      this.lblNom.Size = new System.Drawing.Size(50, 21);
      this.lblNom.TabIndex = 1;
      this.lblNom.Text = "Nom:";
      // 
      // lblDesc
      // 
      this.lblDesc.AutoSize = true;
      this.lblDesc.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDesc.Location = new System.Drawing.Point(19, 54);
      this.lblDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblDesc.Name = "lblDesc";
      this.lblDesc.Size = new System.Drawing.Size(120, 21);
      this.lblDesc.TabIndex = 2;
      this.lblDesc.Text = "Description";
      // 
      // lblTextDate
      // 
      this.lblTextDate.AutoSize = true;
      this.lblTextDate.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTextDate.Location = new System.Drawing.Point(294, 22);
      this.lblTextDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblTextDate.Name = "lblTextDate";
      this.lblTextDate.Size = new System.Drawing.Size(60, 21);
      this.lblTextDate.TabIndex = 3;
      this.lblTextDate.Text = "Date:";
      // 
      // FrmEventDesc
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Thistle;
      this.ClientSize = new System.Drawing.Size(483, 325);
      this.Controls.Add(this.lblTextDate);
      this.Controls.Add(this.lblDesc);
      this.Controls.Add(this.lblNom);
      this.Controls.Add(this.rtxDesc);
      this.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "FrmEventDesc";
      this.Padding = new System.Windows.Forms.Padding(23, 22, 23, 22);
      this.Text = "FrmEventDesc";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox rtxDesc;
    private System.Windows.Forms.Label lblNom;
    private System.Windows.Forms.Label lblDesc;
    private System.Windows.Forms.Label lblTextDate;
  }
}