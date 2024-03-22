namespace homelogistics
{
  partial class FrmParticipants
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
      this.dgvParticipants = new System.Windows.Forms.DataGridView();
      this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.participation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.btnSave = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btnCancel = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // dgvParticipants
      // 
      this.dgvParticipants.AllowUserToAddRows = false;
      this.dgvParticipants.AllowUserToDeleteRows = false;
      this.dgvParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvParticipants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvParticipants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.participation});
      this.dgvParticipants.Location = new System.Drawing.Point(20, 20);
      this.dgvParticipants.Name = "dgvParticipants";
      this.dgvParticipants.ReadOnly = true;
      this.dgvParticipants.Size = new System.Drawing.Size(320, 402);
      this.dgvParticipants.TabIndex = 0;
      this.dgvParticipants.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvParticipants_CellContentClick);
      // 
      // Nom
      // 
      this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.Nom.HeaderText = "Nom";
      this.Nom.Name = "Nom";
      this.Nom.ReadOnly = true;
      // 
      // participation
      // 
      this.participation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.participation.HeaderText = "Participe?";
      this.participation.Name = "participation";
      this.participation.ReadOnly = true;
      this.participation.Width = 83;
      // 
      // btnSave
      // 
      this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSave.Location = new System.Drawing.Point(163, 0);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(157, 22);
      this.btnSave.TabIndex = 1;
      this.btnSave.Text = "Valider";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btnCancel);
      this.panel1.Controls.Add(this.btnSave);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel1.Location = new System.Drawing.Point(20, 429);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(320, 22);
      this.panel1.TabIndex = 2;
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnCancel.Location = new System.Drawing.Point(0, 0);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(161, 22);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Annuler";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
      // 
      // FrmParticipants
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Thistle;
      this.ClientSize = new System.Drawing.Size(360, 471);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.dgvParticipants);
      this.Font = new System.Drawing.Font("JetBrains Mono NL", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.MinimumSize = new System.Drawing.Size(376, 510);
      this.Name = "FrmParticipants";
      this.Padding = new System.Windows.Forms.Padding(20);
      this.Text = "FrmParticipants";
      this.Load += new System.EventHandler(this.FrmParticipants_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvParticipants)).EndInit();
      this.panel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvParticipants;
    private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
    private System.Windows.Forms.DataGridViewCheckBoxColumn participation;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnCancel;
  }
}