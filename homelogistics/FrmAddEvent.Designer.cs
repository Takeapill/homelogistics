namespace homelogistics
{
  partial class FrmAddEvent
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
      this.lblAjouterEvenement = new System.Windows.Forms.Label();
      this.txtNom = new System.Windows.Forms.TextBox();
      this.dtpEvent = new System.Windows.Forms.DateTimePicker();
      this.lblNom = new System.Windows.Forms.Label();
      this.lblDate = new System.Windows.Forms.Label();
      this.lblDesc = new System.Windows.Forms.Label();
      this.rtxDesc = new System.Windows.Forms.RichTextBox();
      this.lblStatus = new System.Windows.Forms.Label();
      this.cmbStatus = new System.Windows.Forms.ComboBox();
      this.btnAjouter = new System.Windows.Forms.Button();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.lblType = new System.Windows.Forms.Label();
      this.btnParticipants = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblAjouterEvenement
      // 
      this.lblAjouterEvenement.AutoSize = true;
      this.lblAjouterEvenement.Font = new System.Drawing.Font("JetBrains Mono NL", 20F, System.Drawing.FontStyle.Bold);
      this.lblAjouterEvenement.Location = new System.Drawing.Point(23, 20);
      this.lblAjouterEvenement.Name = "lblAjouterEvenement";
      this.lblAjouterEvenement.Size = new System.Drawing.Size(335, 36);
      this.lblAjouterEvenement.TabIndex = 5;
      this.lblAjouterEvenement.Text = "Ajouter un événement";
      // 
      // txtNom
      // 
      this.txtNom.Location = new System.Drawing.Point(202, 101);
      this.txtNom.Name = "txtNom";
      this.txtNom.Size = new System.Drawing.Size(200, 20);
      this.txtNom.TabIndex = 6;
      // 
      // dtpEvent
      // 
      this.dtpEvent.Location = new System.Drawing.Point(202, 141);
      this.dtpEvent.Name = "dtpEvent";
      this.dtpEvent.Size = new System.Drawing.Size(200, 20);
      this.dtpEvent.TabIndex = 7;
      // 
      // lblNom
      // 
      this.lblNom.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNom.Location = new System.Drawing.Point(23, 101);
      this.lblNom.Name = "lblNom";
      this.lblNom.Size = new System.Drawing.Size(100, 20);
      this.lblNom.TabIndex = 9;
      this.lblNom.Text = "Nom";
      // 
      // lblDate
      // 
      this.lblDate.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDate.Location = new System.Drawing.Point(23, 141);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(100, 20);
      this.lblDate.TabIndex = 10;
      this.lblDate.Text = "Date et Heure";
      // 
      // lblDesc
      // 
      this.lblDesc.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDesc.Location = new System.Drawing.Point(23, 181);
      this.lblDesc.Name = "lblDesc";
      this.lblDesc.Size = new System.Drawing.Size(100, 20);
      this.lblDesc.TabIndex = 12;
      this.lblDesc.Text = "Description";
      // 
      // rtxDesc
      // 
      this.rtxDesc.Location = new System.Drawing.Point(202, 181);
      this.rtxDesc.Name = "rtxDesc";
      this.rtxDesc.Size = new System.Drawing.Size(200, 100);
      this.rtxDesc.TabIndex = 13;
      this.rtxDesc.Text = "";
      // 
      // lblStatus
      // 
      this.lblStatus.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblStatus.Location = new System.Drawing.Point(23, 301);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(100, 20);
      this.lblStatus.TabIndex = 14;
      this.lblStatus.Text = "Status";
      // 
      // cmbStatus
      // 
      this.cmbStatus.FormattingEnabled = true;
      this.cmbStatus.Location = new System.Drawing.Point(202, 301);
      this.cmbStatus.Name = "cmbStatus";
      this.cmbStatus.Size = new System.Drawing.Size(200, 21);
      this.cmbStatus.TabIndex = 15;
      // 
      // btnAjouter
      // 
      this.btnAjouter.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAjouter.Location = new System.Drawing.Point(327, 387);
      this.btnAjouter.Name = "btnAjouter";
      this.btnAjouter.Size = new System.Drawing.Size(75, 23);
      this.btnAjouter.TabIndex = 16;
      this.btnAjouter.Text = "Ajouter";
      this.btnAjouter.UseVisualStyleBackColor = true;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(202, 344);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(200, 21);
      this.comboBox1.TabIndex = 17;
      // 
      // lblType
      // 
      this.lblType.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblType.Location = new System.Drawing.Point(23, 347);
      this.lblType.Name = "lblType";
      this.lblType.Size = new System.Drawing.Size(100, 20);
      this.lblType.TabIndex = 18;
      this.lblType.Text = "Type";
      // 
      // btnParticipants
      // 
      this.btnParticipants.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnParticipants.Location = new System.Drawing.Point(202, 387);
      this.btnParticipants.Name = "btnParticipants";
      this.btnParticipants.Size = new System.Drawing.Size(119, 23);
      this.btnParticipants.TabIndex = 19;
      this.btnParticipants.Text = "Participants";
      this.btnParticipants.UseVisualStyleBackColor = true;
      this.btnParticipants.Click += new System.EventHandler(this.BtnParticipants_Click);
      // 
      // FrmAddEvent
      // 
      this.AcceptButton = this.btnAjouter;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Thistle;
      this.ClientSize = new System.Drawing.Size(425, 433);
      this.Controls.Add(this.btnParticipants);
      this.Controls.Add(this.lblType);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.btnAjouter);
      this.Controls.Add(this.cmbStatus);
      this.Controls.Add(this.lblStatus);
      this.Controls.Add(this.rtxDesc);
      this.Controls.Add(this.lblDesc);
      this.Controls.Add(this.lblDate);
      this.Controls.Add(this.lblNom);
      this.Controls.Add(this.dtpEvent);
      this.Controls.Add(this.txtNom);
      this.Controls.Add(this.lblAjouterEvenement);
      this.Name = "FrmAddEvent";
      this.Padding = new System.Windows.Forms.Padding(20);
      this.Text = "FrmAddEvent";
      this.Load += new System.EventHandler(this.FrmAddEvent_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblAjouterEvenement;
    private System.Windows.Forms.TextBox txtNom;
    private System.Windows.Forms.DateTimePicker dtpEvent;
    private System.Windows.Forms.Label lblNom;
    private System.Windows.Forms.Label lblDate;
    private System.Windows.Forms.Label lblDesc;
    private System.Windows.Forms.RichTextBox rtxDesc;
    private System.Windows.Forms.Label lblStatus;
    private System.Windows.Forms.ComboBox cmbStatus;
    private System.Windows.Forms.Button btnAjouter;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.Label lblType;
    private System.Windows.Forms.Button btnParticipants;
  }
}