namespace homelogistics
{
  partial class FrmPersoTasks
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
      this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lblTasks = new System.Windows.Forms.Label();
      this.btnFilter = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgvTaches)).BeginInit();
      this.SuspendLayout();
      // 
      // dgvTaches
      // 
      this.dgvTaches.AllowUserToAddRows = false;
      this.dgvTaches.AllowUserToDeleteRows = false;
      this.dgvTaches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.dgvTaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvTaches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.num,
            this.nom,
            this.date,
            this.status});
      this.dgvTaches.Location = new System.Drawing.Point(20, 82);
      this.dgvTaches.Name = "dgvTaches";
      this.dgvTaches.ReadOnly = true;
      this.dgvTaches.Size = new System.Drawing.Size(494, 559);
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
      // date
      // 
      this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.date.HeaderText = "Date";
      this.date.Name = "date";
      this.date.ReadOnly = true;
      // 
      // status
      // 
      this.status.HeaderText = "Status";
      this.status.Name = "status";
      this.status.ReadOnly = true;
      // 
      // lblVosTaches
      // 
      this.lblTasks.AutoSize = true;
      this.lblTasks.Font = new System.Drawing.Font("JetBrains Mono NL", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lblTasks.Location = new System.Drawing.Point(9, 20);
      this.lblTasks.Name = "lblVosTaches";
      this.lblTasks.Size = new System.Drawing.Size(317, 63);
      this.lblTasks.TabIndex = 4;
      this.lblTasks.Text = "Vos tâches";
      this.lblTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lblTasks.UseWaitCursor = true;
      // 
      // btnAll
      // 
      this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnFilter.Font = new System.Drawing.Font("JetBrainsMono NF", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnFilter.Location = new System.Drawing.Point(360, 53);
      this.btnFilter.Name = "btnAll";
      this.btnFilter.Size = new System.Drawing.Size(154, 23);
      this.btnFilter.TabIndex = 5;
      this.btnFilter.Text = "Toutes les tâches";
      this.btnFilter.UseVisualStyleBackColor = true;
      this.btnFilter.Click += new System.EventHandler(this.btnAll_Click);
      // 
      // FrmPersoTasks
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Thistle;
      this.ClientSize = new System.Drawing.Size(534, 661);
      this.Controls.Add(this.btnFilter);
      this.Controls.Add(this.dgvTaches);
      this.Controls.Add(this.lblTasks);
      this.Font = new System.Drawing.Font("JetBrainsMono NF", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "FrmPersoTasks";
      this.Padding = new System.Windows.Forms.Padding(20);
      this.Text = "Tâches";
      this.Load += new System.EventHandler(this.FrmPersoTasks_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvTaches)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvTaches;
    private System.Windows.Forms.Label lblTasks;
    private System.Windows.Forms.Button btnFilter;
    private System.Windows.Forms.DataGridViewTextBoxColumn num;
    private System.Windows.Forms.DataGridViewTextBoxColumn nom;
    private System.Windows.Forms.DataGridViewTextBoxColumn date;
    private System.Windows.Forms.DataGridViewTextBoxColumn status;
  }
}