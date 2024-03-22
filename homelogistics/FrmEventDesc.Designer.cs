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
      this.lblDate = new System.Windows.Forms.Label();
      this.txtNom = new System.Windows.Forms.TextBox();
      this.txtDate = new System.Windows.Forms.TextBox();
      this.btnApply = new System.Windows.Forms.Button();
      this.btnNoSave = new System.Windows.Forms.Button();
      this.btnParticipants = new System.Windows.Forms.Button();
      this.cmbStatus = new System.Windows.Forms.ComboBox();
      this.lblStatus = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // rtxDesc
      // 
      this.rtxDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.rtxDesc.Location = new System.Drawing.Point(23, 78);
      this.rtxDesc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.rtxDesc.MinimumSize = new System.Drawing.Size(460, 211);
      this.rtxDesc.Name = "rtxDesc";
      this.rtxDesc.Size = new System.Drawing.Size(460, 211);
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
      // lblDate
      // 
      this.lblDate.AutoSize = true;
      this.lblDate.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDate.Location = new System.Drawing.Point(317, 22);
      this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(60, 21);
      this.lblDate.TabIndex = 3;
      this.lblDate.Text = "Date:";
      // 
      // txtNom
      // 
      this.txtNom.Location = new System.Drawing.Point(76, 21);
      this.txtNom.Name = "txtNom";
      this.txtNom.Size = new System.Drawing.Size(129, 22);
      this.txtNom.TabIndex = 4;
      // 
      // txtDate
      // 
      this.txtDate.Location = new System.Drawing.Point(375, 21);
      this.txtDate.Name = "txtDate";
      this.txtDate.Size = new System.Drawing.Size(108, 22);
      this.txtDate.TabIndex = 5;
      // 
      // btnApply
      // 
      this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnApply.Location = new System.Drawing.Point(401, 295);
      this.btnApply.Name = "btnApply";
      this.btnApply.Size = new System.Drawing.Size(83, 23);
      this.btnApply.TabIndex = 6;
      this.btnApply.Text = "Appliquer";
      this.btnApply.UseVisualStyleBackColor = true;
      this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
      // 
      // btnNoSave
      // 
      this.btnNoSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnNoSave.Location = new System.Drawing.Point(312, 295);
      this.btnNoSave.Name = "btnNoSave";
      this.btnNoSave.Size = new System.Drawing.Size(83, 23);
      this.btnNoSave.TabIndex = 7;
      this.btnNoSave.Text = "Annuler";
      this.btnNoSave.UseVisualStyleBackColor = true;
      this.btnNoSave.Click += new System.EventHandler(this.btnNoSave_Click);
      // 
      // btnParticipants
      // 
      this.btnParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnParticipants.Location = new System.Drawing.Point(23, 295);
      this.btnParticipants.Name = "btnParticipants";
      this.btnParticipants.Size = new System.Drawing.Size(116, 23);
      this.btnParticipants.TabIndex = 8;
      this.btnParticipants.Text = "Participants";
      this.btnParticipants.UseVisualStyleBackColor = true;
      this.btnParticipants.Click += new System.EventHandler(this.btnParticipants_Click);
      // 
      // cmbStatus
      // 
      this.cmbStatus.FormattingEnabled = true;
      this.cmbStatus.Location = new System.Drawing.Point(375, 53);
      this.cmbStatus.Name = "cmbStatus";
      this.cmbStatus.Size = new System.Drawing.Size(109, 22);
      this.cmbStatus.TabIndex = 9;
      // 
      // lblStatus
      // 
      this.lblStatus.AutoSize = true;
      this.lblStatus.Font = new System.Drawing.Font("JetBrains Mono NL", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblStatus.Location = new System.Drawing.Point(297, 51);
      this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(80, 21);
      this.lblStatus.TabIndex = 10;
      this.lblStatus.Text = "Status:";
      // 
      // FrmEventDesc
      // 
      this.AcceptButton = this.btnApply;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Thistle;
      this.ClientSize = new System.Drawing.Size(510, 325);
      this.Controls.Add(this.cmbStatus);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.btnParticipants);
      this.Controls.Add(this.btnNoSave);
      this.Controls.Add(this.btnApply);
      this.Controls.Add(this.txtDate);
      this.Controls.Add(this.txtNom);
      this.Controls.Add(this.lblDate);
      this.Controls.Add(this.lblDesc);
      this.Controls.Add(this.lblNom);
      this.Controls.Add(this.rtxDesc);
      this.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.MinimumSize = new System.Drawing.Size(526, 364);
      this.Name = "FrmEventDesc";
      this.Padding = new System.Windows.Forms.Padding(23, 22, 23, 22);
      this.Text = "FrmEventDesc";
      this.Load += new System.EventHandler(this.FrmEventDesc_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox rtxDesc;
    private System.Windows.Forms.Label lblNom;
    private System.Windows.Forms.Label lblDesc;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.TextBox txtNom;
    private System.Windows.Forms.TextBox txtDate;
    private System.Windows.Forms.Button btnApply;
    private System.Windows.Forms.Button btnNoSave;
    private System.Windows.Forms.Button btnParticipants;
    private System.Windows.Forms.ComboBox cmbStatus;
    private System.Windows.Forms.Label lblStatus;
  }
}