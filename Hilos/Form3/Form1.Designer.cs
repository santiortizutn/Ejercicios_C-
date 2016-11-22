namespace Form3
{
    partial class Form1
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
            this.btn_CRear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnDestruir = new System.Windows.Forms.Button();
            this.btnReanuadar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumeroPelotitas = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblColorp = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_CRear
            // 
            this.btn_CRear.Location = new System.Drawing.Point(12, 235);
            this.btn_CRear.Name = "btn_CRear";
            this.btn_CRear.Size = new System.Drawing.Size(78, 23);
            this.btn_CRear.TabIndex = 0;
            this.btn_CRear.Text = "&Crear Pelotita";
            this.btn_CRear.UseVisualStyleBackColor = true;
            this.btn_CRear.Click += new System.EventHandler(this.btn_CRear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(468, 231);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(12, 265);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(68, 23);
            this.btnPausar.TabIndex = 2;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnDestruir
            // 
            this.btnDestruir.Location = new System.Drawing.Point(96, 235);
            this.btnDestruir.Name = "btnDestruir";
            this.btnDestruir.Size = new System.Drawing.Size(75, 24);
            this.btnDestruir.TabIndex = 3;
            this.btnDestruir.Text = "Destruir";
            this.btnDestruir.UseVisualStyleBackColor = true;
            this.btnDestruir.Click += new System.EventHandler(this.btnDestruir_Click);
            // 
            // btnReanuadar
            // 
            this.btnReanuadar.Location = new System.Drawing.Point(96, 265);
            this.btnReanuadar.Name = "btnReanuadar";
            this.btnReanuadar.Size = new System.Drawing.Size(75, 23);
            this.btnReanuadar.TabIndex = 4;
            this.btnReanuadar.Text = "Reanudar";
            this.btnReanuadar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(322, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad de pelotas";
            // 
            // lblNumeroPelotitas
            // 
            this.lblNumeroPelotitas.AutoSize = true;
            this.lblNumeroPelotitas.Location = new System.Drawing.Point(363, 265);
            this.lblNumeroPelotitas.Name = "lblNumeroPelotitas";
            this.lblNumeroPelotitas.Size = new System.Drawing.Size(13, 13);
            this.lblNumeroPelotitas.TabIndex = 6;
            this.lblNumeroPelotitas.Text = "0";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rojo",
            "Azul",
            "Verde",
            "Amarillo",
            "Marron",
            "Naranja",
            "Celeste",
            "Rosa",
            "Gris",
            "Negro",
            "Violeta"});
            this.comboBox1.Location = new System.Drawing.Point(196, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblColorp
            // 
            this.lblColorp.AutoSize = true;
            this.lblColorp.Location = new System.Drawing.Point(193, 246);
            this.lblColorp.Name = "lblColorp";
            this.lblColorp.Size = new System.Drawing.Size(83, 13);
            this.lblColorp.TabIndex = 8;
            this.lblColorp.Text = "Color de pelotita";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 300);
            this.Controls.Add(this.lblColorp);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblNumeroPelotitas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReanuadar);
            this.Controls.Add(this.btnDestruir);
            this.Controls.Add(this.btnPausar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_CRear);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CRear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnDestruir;
        private System.Windows.Forms.Button btnReanuadar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumeroPelotitas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblColorp;
    }
}

