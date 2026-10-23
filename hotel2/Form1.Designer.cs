namespace hotel2
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.cmb_n1 = new System.Windows.Forms.ComboBox();
            this.lbl_n4 = new System.Windows.Forms.Label();
            this.cmb_n2 = new System.Windows.Forms.ComboBox();
            this.lbl_n5 = new System.Windows.Forms.Label();
            this.chk_n1 = new System.Windows.Forms.CheckBox();
            this.btn_n1 = new System.Windows.Forms.Button();
            this.lbl_n6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_n8 = new System.Windows.Forms.Label();
            this.txt_n1 = new System.Windows.Forms.TextBox();
            this.btn_n2 = new System.Windows.Forms.Button();
            this.grb_n1 = new System.Windows.Forms.GroupBox();
            this.lbl_n9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grb_n1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_n1.Location = new System.Drawing.Point(178, 7);
            this.lbl_n1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(181, 26);
            this.lbl_n1.TabIndex = 0;
            this.lbl_n1.Text = "BENVENUTO/A";
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_n2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_n2.Location = new System.Drawing.Point(5, 61);
            this.lbl_n2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(335, 20);
            this.lbl_n2.TabIndex = 1;
            this.lbl_n2.Text = "Completare le seguenti richieste per prenotare";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_n3.Location = new System.Drawing.Point(4, 101);
            this.lbl_n3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(115, 13);
            this.lbl_n3.TabIndex = 2;
            this.lbl_n3.Text = "Scegliere una stagione";
            // 
            // cmb_n1
            // 
            this.cmb_n1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_n1.FormattingEnabled = true;
            this.cmb_n1.Items.AddRange(new object[] {
            "Bassa Stagione",
            "Media Stagione",
            "Alta Stagione"});
            this.cmb_n1.Location = new System.Drawing.Point(7, 116);
            this.cmb_n1.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_n1.Name = "cmb_n1";
            this.cmb_n1.Size = new System.Drawing.Size(124, 21);
            this.cmb_n1.TabIndex = 3;
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_n4.Location = new System.Drawing.Point(4, 161);
            this.lbl_n4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(127, 13);
            this.lbl_n4.TabIndex = 4;
            this.lbl_n4.Text = "Scegliere il tipo di camera";
            // 
            // cmb_n2
            // 
            this.cmb_n2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_n2.FormattingEnabled = true;
            this.cmb_n2.Items.AddRange(new object[] {
            "Base",
            "Media",
            "Alta"});
            this.cmb_n2.Location = new System.Drawing.Point(7, 176);
            this.cmb_n2.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_n2.Name = "cmb_n2";
            this.cmb_n2.Size = new System.Drawing.Size(124, 21);
            this.cmb_n2.TabIndex = 5;
            // 
            // lbl_n5
            // 
            this.lbl_n5.AutoSize = true;
            this.lbl_n5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_n5.Location = new System.Drawing.Point(4, 263);
            this.lbl_n5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n5.Name = "lbl_n5";
            this.lbl_n5.Size = new System.Drawing.Size(241, 13);
            this.lbl_n5.TabIndex = 6;
            this.lbl_n5.Text = "Spuntare la casella per avere anche il parcheggio";
            // 
            // chk_n1
            // 
            this.chk_n1.AutoSize = true;
            this.chk_n1.Location = new System.Drawing.Point(7, 279);
            this.chk_n1.Margin = new System.Windows.Forms.Padding(2);
            this.chk_n1.Name = "chk_n1";
            this.chk_n1.Size = new System.Drawing.Size(104, 17);
            this.chk_n1.TabIndex = 7;
            this.chk_n1.Text = "Parcheggio (5 €)";
            this.chk_n1.UseVisualStyleBackColor = true;
            // 
            // btn_n1
            // 
            this.btn_n1.Location = new System.Drawing.Point(7, 324);
            this.btn_n1.Margin = new System.Windows.Forms.Padding(2);
            this.btn_n1.Name = "btn_n1";
            this.btn_n1.Size = new System.Drawing.Size(117, 36);
            this.btn_n1.TabIndex = 8;
            this.btn_n1.Text = "PRENOTA";
            this.btn_n1.UseVisualStyleBackColor = true;
            this.btn_n1.Click += new System.EventHandler(this.btn_n1_Click);
            // 
            // lbl_n6
            // 
            this.lbl_n6.AutoSize = true;
            this.lbl_n6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_n6.Location = new System.Drawing.Point(7, 362);
            this.lbl_n6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n6.Name = "lbl_n6";
            this.lbl_n6.Size = new System.Drawing.Size(72, 13);
            this.lbl_n6.TabIndex = 9;
            this.lbl_n6.Text = "Spesa totale: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.No;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(501, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Bista Grand Hotel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(449, 92);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(242, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_n8
            // 
            this.lbl_n8.AutoSize = true;
            this.lbl_n8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbl_n8.Location = new System.Drawing.Point(7, 212);
            this.lbl_n8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_n8.Name = "lbl_n8";
            this.lbl_n8.Size = new System.Drawing.Size(106, 13);
            this.lbl_n8.TabIndex = 12;
            this.lbl_n8.Text = "Giorni di permanenza";
            // 
            // txt_n1
            // 
            this.txt_n1.Location = new System.Drawing.Point(9, 228);
            this.txt_n1.Margin = new System.Windows.Forms.Padding(2);
            this.txt_n1.Name = "txt_n1";
            this.txt_n1.Size = new System.Drawing.Size(93, 20);
            this.txt_n1.TabIndex = 13;
            // 
            // btn_n2
            // 
            this.btn_n2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_n2.Location = new System.Drawing.Point(696, 302);
            this.btn_n2.Margin = new System.Windows.Forms.Padding(2);
            this.btn_n2.Name = "btn_n2";
            this.btn_n2.Size = new System.Drawing.Size(30, 30);
            this.btn_n2.TabIndex = 14;
            this.btn_n2.Text = "?";
            this.btn_n2.UseVisualStyleBackColor = true;
            this.btn_n2.Click += new System.EventHandler(this.btn_n2_Click);
            // 
            // grb_n1
            // 
            this.grb_n1.Controls.Add(this.lbl_n9);
            this.grb_n1.Location = new System.Drawing.Point(166, 311);
            this.grb_n1.Name = "grb_n1";
            this.grb_n1.Size = new System.Drawing.Size(525, 113);
            this.grb_n1.TabIndex = 15;
            this.grb_n1.TabStop = false;
            this.grb_n1.Text = "Informazioni";
            this.grb_n1.Visible = false;
            // 
            // lbl_n9
            // 
            this.lbl_n9.AutoSize = true;
            this.lbl_n9.Location = new System.Drawing.Point(7, 20);
            this.lbl_n9.Name = "lbl_n9";
            this.lbl_n9.Size = new System.Drawing.Size(514, 78);
            this.lbl_n9.TabIndex = 0;
            this.lbl_n9.Text = resources.GetString("lbl_n9.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(735, 516);
            this.Controls.Add(this.btn_n2);
            this.Controls.Add(this.grb_n1);
            this.Controls.Add(this.txt_n1);
            this.Controls.Add(this.lbl_n8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_n6);
            this.Controls.Add(this.btn_n1);
            this.Controls.Add(this.chk_n1);
            this.Controls.Add(this.lbl_n5);
            this.Controls.Add(this.cmb_n2);
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.cmb_n1);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.lbl_n1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "  ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grb_n1.ResumeLayout(false);
            this.grb_n1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.ComboBox cmb_n1;
        private System.Windows.Forms.Label lbl_n4;
        private System.Windows.Forms.ComboBox cmb_n2;
        private System.Windows.Forms.Label lbl_n5;
        private System.Windows.Forms.CheckBox chk_n1;
        private System.Windows.Forms.Button btn_n1;
        private System.Windows.Forms.Label lbl_n6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_n8;
        private System.Windows.Forms.TextBox txt_n1;
        private System.Windows.Forms.Button btn_n2;
        private System.Windows.Forms.GroupBox grb_n1;
        private System.Windows.Forms.Label lbl_n9;
    }
}

