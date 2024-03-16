namespace homelogistics
{
  partial class FrmTachesPerso
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
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.lblVosTaches = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(23, 119);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(488, 519);
      this.dataGridView1.TabIndex = 0;
      // 
      // lblVosTaches
      // 
      this.lblVosTaches.AutoSize = true;
      this.lblVosTaches.Font = new System.Drawing.Font("JetBrains Mono NL", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblVosTaches.Location = new System.Drawing.Point(12, 20);
      this.lblVosTaches.Name = "lblVosTaches";
      this.lblVosTaches.Size = new System.Drawing.Size(317, 63);
      this.lblVosTaches.TabIndex = 4;
      this.lblVosTaches.Text = "Vos tâches";
      // 
      // button1
      // 
      this.button1.Font = new System.Drawing.Font("JetBrainsMono NF", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(357, 40);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(154, 23);
      this.button1.TabIndex = 5;
      this.button1.Text = "Toutes les tâches";
      this.button1.UseVisualStyleBackColor = true;
      // 
      // FrmTaches
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Thistle;
      this.ClientSize = new System.Drawing.Size(534, 661);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.lblVosTaches);
      this.Controls.Add(this.dataGridView1);
      this.Font = new System.Drawing.Font("JetBrainsMono NF", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
      this.Name = "FrmTaches";
      this.Padding = new System.Windows.Forms.Padding(20);
      this.Text = "Tâches";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Label lblVosTaches;
    private System.Windows.Forms.Button button1;
  }
}