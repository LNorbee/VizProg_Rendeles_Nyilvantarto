namespace RendelesNyilvantarto
{
    partial class UCTermek
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
            this.cbTermékNév = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTermékNeve = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTermékÁra = new System.Windows.Forms.TextBox();
            this.tbTermékKód = new System.Windows.Forms.TextBox();
            this.btÚjTermék = new System.Windows.Forms.Button();
            this.btTörlés = new System.Windows.Forms.Button();
            this.btMent = new System.Windows.Forms.Button();
            this.btMégse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbTermékNév
            // 
            this.cbTermékNév.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTermékNév.FormattingEnabled = true;
            this.cbTermékNév.Location = new System.Drawing.Point(49, 36);
            this.cbTermékNév.Name = "cbTermékNév";
            this.cbTermékNév.Size = new System.Drawing.Size(345, 23);
            this.cbTermékNév.TabIndex = 0;
            this.cbTermékNév.SelectedIndexChanged += new System.EventHandler(this.cbTermékNév_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Termékek listája";
            // 
            // tbTermékNeve
            // 
            this.tbTermékNeve.Location = new System.Drawing.Point(49, 92);
            this.tbTermékNeve.Name = "tbTermékNeve";
            this.tbTermékNeve.Size = new System.Drawing.Size(345, 23);
            this.tbTermékNeve.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Termék neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Termék ára:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Termék kódja:";
            // 
            // tbTermékÁra
            // 
            this.tbTermékÁra.Location = new System.Drawing.Point(49, 140);
            this.tbTermékÁra.Name = "tbTermékÁra";
            this.tbTermékÁra.Size = new System.Drawing.Size(345, 23);
            this.tbTermékÁra.TabIndex = 6;
            // 
            // tbTermékKód
            // 
            this.tbTermékKód.Location = new System.Drawing.Point(49, 193);
            this.tbTermékKód.Name = "tbTermékKód";
            this.tbTermékKód.Size = new System.Drawing.Size(345, 23);
            this.tbTermékKód.TabIndex = 7;
            // 
            // btÚjTermék
            // 
            this.btÚjTermék.Location = new System.Drawing.Point(427, 36);
            this.btÚjTermék.Name = "btÚjTermék";
            this.btÚjTermék.Size = new System.Drawing.Size(75, 23);
            this.btÚjTermék.TabIndex = 8;
            this.btÚjTermék.Text = "Új termék";
            this.btÚjTermék.UseVisualStyleBackColor = true;
            this.btÚjTermék.Click += new System.EventHandler(this.btÚjTermék_Click);
            // 
            // btTörlés
            // 
            this.btTörlés.Location = new System.Drawing.Point(427, 91);
            this.btTörlés.Name = "btTörlés";
            this.btTörlés.Size = new System.Drawing.Size(75, 23);
            this.btTörlés.TabIndex = 9;
            this.btTörlés.Text = "Törlés";
            this.btTörlés.UseVisualStyleBackColor = true;
            this.btTörlés.Click += new System.EventHandler(this.btTörlés_Click);
            // 
            // btMent
            // 
            this.btMent.Location = new System.Drawing.Point(49, 239);
            this.btMent.Name = "btMent";
            this.btMent.Size = new System.Drawing.Size(75, 23);
            this.btMent.TabIndex = 10;
            this.btMent.Text = "Mentés";
            this.btMent.UseVisualStyleBackColor = true;
            this.btMent.Click += new System.EventHandler(this.btMent_Click);
            // 
            // btMégse
            // 
            this.btMégse.Enabled = false;
            this.btMégse.Location = new System.Drawing.Point(180, 239);
            this.btMégse.Name = "btMégse";
            this.btMégse.Size = new System.Drawing.Size(75, 23);
            this.btMégse.TabIndex = 11;
            this.btMégse.Text = "Mégse";
            this.btMégse.UseVisualStyleBackColor = true;
            this.btMégse.Click += new System.EventHandler(this.btMégse_Click);
            // 
            // UCTermek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btMégse);
            this.Controls.Add(this.btMent);
            this.Controls.Add(this.btTörlés);
            this.Controls.Add(this.btÚjTermék);
            this.Controls.Add(this.tbTermékKód);
            this.Controls.Add(this.tbTermékÁra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTermékNeve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTermékNév);
            this.Name = "UCTermek";
            this.Size = new System.Drawing.Size(524, 325);
            this.VisibleChanged += new System.EventHandler(this.UCTermek_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbTermékNév;
        private Label label1;
        private TextBox tbTermékNeve;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbTermékÁra;
        private TextBox tbTermékKód;
        private Button btÚjTermék;
        private Button btTörlés;
        private Button btMent;
        private Button btMégse;
    }
}
