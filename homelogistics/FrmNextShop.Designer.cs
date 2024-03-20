namespace homelogistics
{
  partial class FrmNextShop
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
      this.dgvTaches = new System.Windows.Forms.DataGridView();
      this.num = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Acheté = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.lblVosTaches = new System.Windows.Forms.Label();
      this.btnAll = new System.Windows.Forms.Button();
      this.lblTextDate = new System.Windows.Forms.Label();
      this.lblDate = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.dgvTaches)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvTaches
      // 
      this.dgvTaches.AllowUserToAddRows = false;
      this.dgvTaches.AllowUserToDeleteRows = false;
      this.dgvTaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvTaches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.nom,
            this.Acheté});
      this.dgvTaches.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.dgvTaches.Location = new System.Drawing.Point(20, 122);
      this.dgvTaches.Name = "dgvTaches";
      this.dgvTaches.ReadOnly = true;
      this.dgvTaches.Size = new System.Drawing.Size(494, 519);
      this.dgvTaches.TabIndex = 0;
      this.dgvTaches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaches_CellClick);
      // 
      // num
      // 
      this.num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.num.HeaderText = "N°";
      this.num.Name = "num";
      this.num.ReadOnly = true;
      this.num.Width = 46;
      // 
      // nom
      // 
      this.nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.nom.HeaderText = "Nom";
      this.nom.Name = "nom";
      this.nom.ReadOnly = true;
      // 
      // Acheté
      // 
      this.Acheté.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
      this.Acheté.HeaderText = "Acheté?";
      this.Acheté.Name = "Acheté";
      this.Acheté.ReadOnly = true;
      this.Acheté.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.Acheté.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.Acheté.Width = 81;
      // 
      // lblVosTaches
      // 
      this.lblVosTaches.AutoSize = true;
      this.lblVosTaches.Font = new System.Drawing.Font("JetBrains Mono NL", 22F, System.Drawing.FontStyle.Bold);
      this.lblVosTaches.Location = new System.Drawing.Point(13, 20);
      this.lblVosTaches.Name = "lblVosTaches";
      this.lblVosTaches.Size = new System.Drawing.Size(341, 40);
      this.lblVosTaches.TabIndex = 4;
      this.lblVosTaches.Text = "Prochaines Courses";
      // 
      // btnAll
      // 
      this.btnAll.Font = new System.Drawing.Font("JetBrainsMono NF", 8F, System.Drawing.FontStyle.Bold);
      this.btnAll.Location = new System.Drawing.Point(370, 29);
      this.btnAll.Name = "btnAll";
      this.btnAll.Size = new System.Drawing.Size(144, 23);
      this.btnAll.TabIndex = 5;
      this.btnAll.Text = "Toutes les courses";
      this.btnAll.UseVisualStyleBackColor = true;
      this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
      // 
      // lblTextDate
      // 
      this.lblTextDate.AutoSize = true;
      this.lblTextDate.Font = new System.Drawing.Font("JetBrainsMono NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTextDate.Location = new System.Drawing.Point(16, 88);
      this.lblTextDate.Name = "lblTextDate";
      this.lblTextDate.Size = new System.Drawing.Size(60, 21);
      this.lblTextDate.TabIndex = 6;
      this.lblTextDate.Text = "Date:";
      // 
      // lblDate
      // 
      this.lblDate.AutoSize = true;
      this.lblDate.Font = new System.Drawing.Font("JetBrainsMono NF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDate.Location = new System.Drawing.Point(82, 88);
      this.lblDate.Name = "lblDate";
      this.lblDate.Size = new System.Drawing.Size(0, 21);
      this.lblDate.TabIndex = 7;
      // 
      // FrmProCourses
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Thistle;
      this.ClientSize = new System.Drawing.Size(534, 661);
      this.Controls.Add(this.lblDate);
      this.Controls.Add(this.lblTextDate);
      this.Controls.Add(this.btnAll);
      this.Controls.Add(this.lblVosTaches);
      this.Controls.Add(this.dgvTaches);
      this.Font = new System.Drawing.Font("JetBrainsMono NF", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.MaximumSize = new System.Drawing.Size(550, 700);
      this.MinimumSize = new System.Drawing.Size(550, 700);
      this.Name = "FrmProCourses";
      this.Padding = new System.Windows.Forms.Padding(20);
      this.Text = "Tâches";
      this.Load += new System.EventHandler(this.FrmNextShop_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvTaches)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvTaches;
    private System.Windows.Forms.Label lblVosTaches;
    private System.Windows.Forms.Button btnAll;
    private System.Windows.Forms.DataGridViewTextBoxColumn num;
    private System.Windows.Forms.DataGridViewTextBoxColumn nom;
    private System.Windows.Forms.DataGridViewCheckBoxColumn Acheté;
    private System.Windows.Forms.Label lblTextDate;
    private System.Windows.Forms.Label lblDate;
  }
}
