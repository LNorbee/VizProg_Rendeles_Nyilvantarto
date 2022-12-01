namespace RendelesNyilvantarto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dsRendelesNyilvantarto = new RendelesNyilvantarto.dsRendelesNyilvantarto();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiRendelések = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKilépés = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dsRendelesNyilvantarto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dsRendelesNyilvantarto
            // 
            this.dsRendelesNyilvantarto.CaseSensitive = true;
            this.dsRendelesNyilvantarto.DataSetName = "dsRendelesNyilvantarto";
            this.dsRendelesNyilvantarto.Namespace = "http://tempuri.org/dsRendelesNyilvantarto.xsd";
            this.dsRendelesNyilvantarto.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRendelések,
            this.mentésToolStripMenuItem,
            this.tsmiKilépés});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiRendelések
            // 
            this.tsmiRendelések.Name = "tsmiRendelések";
            this.tsmiRendelések.Size = new System.Drawing.Size(116, 29);
            this.tsmiRendelések.Text = "Rendelések";
            this.tsmiRendelések.Click += new System.EventHandler(this.tsmiRendelések_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(86, 29);
            this.mentésToolStripMenuItem.Text = "Mentés";
            // 
            // tsmiKilépés
            // 
            this.tsmiKilépés.Name = "tsmiKilépés";
            this.tsmiKilépés.Size = new System.Drawing.Size(83, 29);
            this.tsmiKilépés.Text = "Kilépés";
            this.tsmiKilépés.Click += new System.EventHandler(this.tsmiKilépés_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(30, 49);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 33;
            this.dgv.Size = new System.Drawing.Size(360, 225);
            this.dgv.TabIndex = 1;
            this.dgv.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Rendelés nyilvántartó";
            ((System.ComponentModel.ISupportInitialize)(this.dsRendelesNyilvantarto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsRendelesNyilvantarto dsRendelesNyilvantarto;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiRendelések;
        private ToolStripMenuItem mentésToolStripMenuItem;
        private ToolStripMenuItem tsmiKilépés;
        private DataGridView dgv;
    }
}