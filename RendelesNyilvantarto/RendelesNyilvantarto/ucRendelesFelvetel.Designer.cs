namespace RendelesNyilvantarto
{
    partial class ucRendelesFelvetel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cLBTermékek = new System.Windows.Forms.CheckedListBox();
            this.tbVevőNeve = new System.Windows.Forms.TextBox();
            this.btRendeles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vevő neve:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Termékek";
            // 
            // cLBTermékek
            // 
            this.cLBTermékek.FormattingEnabled = true;
            this.cLBTermékek.Location = new System.Drawing.Point(33, 120);
            this.cLBTermékek.Name = "cLBTermékek";
            this.cLBTermékek.Size = new System.Drawing.Size(352, 94);
            this.cLBTermékek.TabIndex = 2;
            // 
            // tbVevőNeve
            // 
            this.tbVevőNeve.Location = new System.Drawing.Point(33, 54);
            this.tbVevőNeve.Name = "tbVevőNeve";
            this.tbVevőNeve.Size = new System.Drawing.Size(352, 23);
            this.tbVevőNeve.TabIndex = 3;
            // 
            // btRendeles
            // 
            this.btRendeles.Location = new System.Drawing.Point(33, 254);
            this.btRendeles.Name = "btRendeles";
            this.btRendeles.Size = new System.Drawing.Size(149, 23);
            this.btRendeles.TabIndex = 4;
            this.btRendeles.Text = "Rendelés leadása";
            this.btRendeles.UseVisualStyleBackColor = true;
            this.btRendeles.Click += new System.EventHandler(this.btRendeles_Click);
            // 
            // ucRendelesFelvetel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btRendeles);
            this.Controls.Add(this.tbVevőNeve);
            this.Controls.Add(this.cLBTermékek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucRendelesFelvetel";
            this.Size = new System.Drawing.Size(617, 409);
            this.VisibleChanged += new System.EventHandler(this.ucRendelesFelvetel_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private CheckedListBox cLBTermékek;
        private TextBox tbVevőNeve;
        private Button btRendeles;
    }
}
