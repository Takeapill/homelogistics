namespace homelogistics
{
  partial class FrmEvents
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
      this.lblTitre = new System.Windows.Forms.Label();
      this.pnlMenu = new System.Windows.Forms.Panel();
      this.btnTaches = new System.Windows.Forms.Button();
      this.btnRepas = new System.Windows.Forms.Button();
      this.btnCourses = new System.Windows.Forms.Button();
      this.btnComm = new System.Windows.Forms.Button();
      this.btnGestion = new System.Windows.Forms.Button();
      this.cdrEvents = new System.Windows.Forms.MonthCalendar();
      this.pnlMenu.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblTitre
      // 
      this.lblTitre.AutoEllipsis = true;
      this.lblTitre.AutoSize = true;
      this.lblTitre.Dock = System.Windows.Forms.DockStyle.Right;
      this.lblTitre.Font = new System.Drawing.Font("JetBrainsMono NF", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitre.Location = new System.Drawing.Point(282, 20);
      this.lblTitre.Margin = new System.Windows.Forms.Padding(0);
      this.lblTitre.Name = "lblTitre";
      this.lblTitre.Size = new System.Drawing.Size(404, 63);
      this.lblTitre.TabIndex = 5;
      this.lblTitre.Text = "Homelogistics";
      this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // pnlMenu
      // 
      this.pnlMenu.BackColor = System.Drawing.Color.Transparent;
      this.pnlMenu.Controls.Add(this.btnTaches);
      this.pnlMenu.Controls.Add(this.btnRepas);
      this.pnlMenu.Controls.Add(this.btnCourses);
      this.pnlMenu.Controls.Add(this.btnComm);
      this.pnlMenu.Controls.Add(this.btnGestion);
      this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlMenu.Font = new System.Drawing.Font("JetBrainsMono NF", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.pnlMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.pnlMenu.Location = new System.Drawing.Point(20, 20);
      this.pnlMenu.Margin = new System.Windows.Forms.Padding(0);
      this.pnlMenu.Name = "pnlMenu";
      this.pnlMenu.Size = new System.Drawing.Size(188, 388);
      this.pnlMenu.TabIndex = 6;
      // 
      // btnTaches
      // 
      this.btnTaches.BackColor = System.Drawing.Color.LightGray;
      this.btnTaches.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnTaches.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btnTaches.FlatAppearance.BorderColor = System.Drawing.Color.Black;
      this.btnTaches.FlatAppearance.BorderSize = 2;
      this.btnTaches.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.btnTaches.Font = new System.Drawing.Font("JetBrainsMono NF ExtraBold", 14F, System.Drawing.FontStyle.Bold);
      this.btnTaches.Location = new System.Drawing.Point(0, 83);
      this.btnTaches.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnTaches.Name = "btnTaches";
      this.btnTaches.Size = new System.Drawing.Size(188, 61);
      this.btnTaches.TabIndex = 5;
      this.btnTaches.Text = "Tâches";
      this.btnTaches.UseVisualStyleBackColor = false;
      this.btnTaches.Click += new System.EventHandler(this.btnTaches_Click);
      // 
      // btnRepas
      // 
      this.btnRepas.BackColor = System.Drawing.Color.LightGray;
      this.btnRepas.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnRepas.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btnRepas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
      this.btnRepas.FlatAppearance.BorderSize = 2;
      this.btnRepas.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.btnRepas.Font = new System.Drawing.Font("JetBrainsMono NF ExtraBold", 14F, System.Drawing.FontStyle.Bold);
      this.btnRepas.Location = new System.Drawing.Point(0, 144);
      this.btnRepas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnRepas.Name = "btnRepas";
      this.btnRepas.Size = new System.Drawing.Size(188, 61);
      this.btnRepas.TabIndex = 1;
      this.btnRepas.Text = "Repas";
      this.btnRepas.UseVisualStyleBackColor = false;
      this.btnRepas.Click += new System.EventHandler(this.btnRepas_Click);
      // 
      // btnCourses
      // 
      this.btnCourses.BackColor = System.Drawing.Color.LightGray;
      this.btnCourses.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnCourses.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btnCourses.FlatAppearance.BorderColor = System.Drawing.Color.Black;
      this.btnCourses.FlatAppearance.BorderSize = 2;
      this.btnCourses.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.btnCourses.Font = new System.Drawing.Font("JetBrainsMono NF ExtraBold", 14F, System.Drawing.FontStyle.Bold);
      this.btnCourses.Location = new System.Drawing.Point(0, 205);
      this.btnCourses.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnCourses.Name = "btnCourses";
      this.btnCourses.Size = new System.Drawing.Size(188, 61);
      this.btnCourses.TabIndex = 4;
      this.btnCourses.Text = "Courses";
      this.btnCourses.UseVisualStyleBackColor = false;
      this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
      // 
      // btnComm
      // 
      this.btnComm.BackColor = System.Drawing.Color.LightGray;
      this.btnComm.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnComm.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btnComm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
      this.btnComm.FlatAppearance.BorderSize = 2;
      this.btnComm.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.btnComm.Font = new System.Drawing.Font("JetBrainsMono NF ExtraBold", 14F, System.Drawing.FontStyle.Bold);
      this.btnComm.Location = new System.Drawing.Point(0, 266);
      this.btnComm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnComm.Name = "btnComm";
      this.btnComm.Size = new System.Drawing.Size(188, 61);
      this.btnComm.TabIndex = 3;
      this.btnComm.Text = "Communication";
      this.btnComm.UseVisualStyleBackColor = false;
      // 
      // btnGestion
      // 
      this.btnGestion.BackColor = System.Drawing.Color.LightGray;
      this.btnGestion.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnGestion.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.btnGestion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
      this.btnGestion.FlatAppearance.BorderSize = 2;
      this.btnGestion.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.btnGestion.Font = new System.Drawing.Font("JetBrainsMono NF ExtraBold", 14F, System.Drawing.FontStyle.Bold);
      this.btnGestion.Location = new System.Drawing.Point(0, 327);
      this.btnGestion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnGestion.Name = "btnGestion";
      this.btnGestion.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
      this.btnGestion.Size = new System.Drawing.Size(188, 61);
      this.btnGestion.TabIndex = 2;
      this.btnGestion.Text = "Famille";
      this.btnGestion.UseVisualStyleBackColor = false;
      // 
      // cdrEvents
      // 
      this.cdrEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cdrEvents.CalendarDimensions = new System.Drawing.Size(2, 2);
      this.cdrEvents.Font = new System.Drawing.Font("JetBrainsMono NF", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cdrEvents.Location = new System.Drawing.Point(228, 98);
      this.cdrEvents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.cdrEvents.Name = "cdrEvents";
      this.cdrEvents.TabIndex = 5;
      this.cdrEvents.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cdrEvents_DateChanged);
      // 
      // FrmEvents
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.BackColor = System.Drawing.Color.Thistle;
      this.ClientSize = new System.Drawing.Size(706, 428);
      this.Controls.Add(this.lblTitre);
      this.Controls.Add(this.cdrEvents);
      this.Controls.Add(this.pnlMenu);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.MaximizeBox = false;
      this.MaximumSize = new System.Drawing.Size(722, 483);
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(722, 445);
      this.Name = "FrmEvents";
      this.Padding = new System.Windows.Forms.Padding(20, 20, 20, 20);
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Evenements";
      this.pnlMenu.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label lblTitre;
    private System.Windows.Forms.Panel pnlMenu;
    private System.Windows.Forms.Button btnGestion;
    private System.Windows.Forms.Button btnRepas;
    private System.Windows.Forms.Button btnCourses;
    private System.Windows.Forms.Button btnComm;
    private System.Windows.Forms.MonthCalendar cdrEvents;
    private System.Windows.Forms.Button btnTaches;
  }
}

