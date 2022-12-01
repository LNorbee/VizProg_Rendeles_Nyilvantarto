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
            this.rendelésFelvételToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTermék = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMentés = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiKilépés = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ucTermek = new RendelesNyilvantarto.UCTermek();
            this.ucRendelesFelvetel = new RendelesNyilvantarto.ucRendelesFelvetel();
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
            this.rendelésFelvételToolStripMenuItem,
            this.tsmiTermék,
            this.tsmMentés,
            this.tsmiKilépés});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiRendelések
            // 
            this.tsmiRendelések.Name = "tsmiRendelések";
            this.tsmiRendelések.Size = new System.Drawing.Size(78, 22);
            this.tsmiRendelések.Text = "Rendelések";
            this.tsmiRendelések.Click += new System.EventHandler(this.tsmiRendelések_Click);
            // 
            // rendelésFelvételToolStripMenuItem
            // 
            this.rendelésFelvételToolStripMenuItem.Name = "rendelésFelvételToolStripMenuItem";
            this.rendelésFelvételToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.rendelésFelvételToolStripMenuItem.Text = "Rendelés Felvétel";
            this.rendelésFelvételToolStripMenuItem.Click += new System.EventHandler(this.rendelésFelvételToolStripMenuItem_Click);
            // 
            // tsmiTermék
            // 
            this.tsmiTermék.Name = "tsmiTermék";
            this.tsmiTermék.Size = new System.Drawing.Size(57, 22);
            this.tsmiTermék.Text = "Termék";
            this.tsmiTermék.Click += new System.EventHandler(this.tsmiTermék_Click);
            // 
            // tsmMentés
            // 
            this.tsmMentés.Name = "tsmMentés";
            this.tsmMentés.Size = new System.Drawing.Size(58, 22);
            this.tsmMentés.Text = "Mentés";
            this.tsmMentés.Click += new System.EventHandler(this.tsmMentés_Click);
            // 
            // tsmiKilépés
            // 
            this.tsmiKilépés.Name = "tsmiKilépés";
            this.tsmiKilépés.Size = new System.Drawing.Size(56, 22);
            this.tsmiKilépés.Text = "Kilépés";
            this.tsmiKilépés.Click += new System.EventHandler(this.tsmiKilépés_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(21, 29);
            this.dgv.Margin = new System.Windows.Forms.Padding(2);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 62;
            this.dgv.RowTemplate.Height = 33;
            this.dgv.Size = new System.Drawing.Size(252, 135);
            this.dgv.TabIndex = 1;
            this.dgv.Visible = false;
            // 
            // ucTermek
            // 
            this.ucTermek.dsRendelesNyilvantarto = null;
            this.ucTermek.Location = new System.Drawing.Point(258, 27);
            this.ucTermek.Name = "ucTermek";
            this.ucTermek.Size = new System.Drawing.Size(524, 325);
            this.ucTermek.TabIndex = 2;
            this.ucTermek.Visible = false;
            // 
            // ucRendelesFelvetel
            // 
            this.ucRendelesFelvetel.Location = new System.Drawing.Point(293, 310);
            this.ucRendelesFelvetel.Name = "ucRendelesFelvetel";
            this.ucRendelesFelvetel.Size = new System.Drawing.Size(617, 409);
            this.ucRendelesFelvetel.TabIndex = 3;
            this.ucRendelesFelvetel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 459);
            this.Controls.Add(this.ucRendelesFelvetel);
            this.Controls.Add(this.ucTermek);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private ToolStripMenuItem tsmMentés;
        private ToolStripMenuItem tsmiKilépés;
        private DataGridView dgv;
        private ToolStripMenuItem tsmiTermék;
        private UCTermek ucTermek;
        private ToolStripMenuItem rendelésFelvételToolStripMenuItem;
        private ucRendelesFelvetel ucRendelesFelvetel;
    }
}