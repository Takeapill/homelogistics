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
      this.lblCourses = new System.Windows.Forms.Label();
      this.btnFilter = new System.Windows.Forms.Button();
      this.lblTextDate = new System.Windows.Forms.Label();
      this.btnDone = new System.Windows.Forms.Button();
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
            this.Acheté});
      this.dgvTaches.Location = new System.Drawing.Point(20, 66);
      this.dgvTaches.Name = "dgvTaches";
      this.dgvTaches.ReadOnly = true;
      this.dgvTaches.Size = new System.Drawing.Size(556, 525);
      this.dgvTaches.TabIndex = 0;
      this.dgvTaches.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaches_CellClick);
      this.dgvTaches.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaches_CellContentClick);
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
      // lblCourses
      // 
      this.lblCourses.AutoSize = true;
      this.lblCourses.Font = new System.Drawing.Font("JetBrains Mono NL", 22F, System.Drawing.FontStyle.Bold);
      this.lblCourses.Location = new System.Drawing.Point(13, 20);
      this.lblCourses.Name = "lblCourses";
      this.lblCourses.Size = new System.Drawing.Size(341, 40);
      this.lblCourses.TabIndex = 4;
      this.lblCourses.Text = "Prochaines Courses";
      // 
      // btnFilter
      // 
      this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnFilter.Font = new System.Drawing.Font("JetBrainsMono NF", 8F, System.Drawing.FontStyle.Bold);
      this.btnFilter.Location = new System.Drawing.Point(457, 37);
      this.btnFilter.Name = "btnFilter";
      this.btnFilter.Size = new System.Drawing.Size(122, 23);
      this.btnFilter.TabIndex = 5;
      this.btnFilter.Text = "semaine";
      this.btnFilter.UseVisualStyleBackColor = true;
      this.btnFilter.Click += new System.EventHandler(this.btnAll_Click);
      // 
      // lblTextDate
      // 
      this.lblTextDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblTextDate.AutoSize = true;
      this.lblTextDate.Font = new System.Drawing.Font("JetBrainsMono NF", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTextDate.Location = new System.Drawing.Point(454, 20);
      this.lblTextDate.Name = "lblTextDate";
      this.lblTextDate.Size = new System.Drawing.Size(42, 14);
      this.lblTextDate.TabIndex = 6;
      this.lblTextDate.Text = "Date:";
      // 
      // btnDone
      // 
      this.btnDone.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btnDone.Location = new System.Drawing.Point(20, 611);
      this.btnDone.Name = "btnDone";
      this.btnDone.Size = new System.Drawing.Size(559, 40);
      this.btnDone.TabIndex = 8;
      this.btnDone.Text = "J\'ai fais les courses!";
      this.btnDone.UseVisualStyleBackColor = true;
      this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
      // 
      // FrmNextShop
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Thistle;
      this.ClientSize = new System.Drawing.Size(599, 671);
      this.Controls.Add(this.btnDone);
      this.Controls.Add(this.lblTextDate);
      this.Controls.Add(this.btnFilter);
      this.Controls.Add(this.lblCourses);
      this.Controls.Add(this.dgvTaches);
      this.Font = new System.Drawing.Font("JetBrainsMono NF", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.MinimumSize = new System.Drawing.Size(615, 710);
      this.Name = "FrmNextShop";
      this.Padding = new System.Windows.Forms.Padding(20);
      this.Text = "Tâches";
      this.Load += new System.EventHandler(this.FrmNextShop_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgvTaches)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dgvTaches;
    private System.Windows.Forms.Label lblCourses;
    private System.Windows.Forms.Button btnFilter;
    private System.Windows.Forms.DataGridViewTextBoxColumn num;
    private System.Windows.Forms.DataGridViewTextBoxColumn nom;
    private System.Windows.Forms.DataGridViewCheckBoxColumn Acheté;
    private System.Windows.Forms.Label lblTextDate;
    private System.Windows.Forms.Button btnDone;
  }
}
