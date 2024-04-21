namespace WindowsFormsApp1
{
    partial class İşlem
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txttemizle = new System.Windows.Forms.Button();
            this.txttoplama = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.Button();
            this.txt3 = new System.Windows.Forms.Button();
            this.txt4 = new System.Windows.Forms.Button();
            this.txt6 = new System.Windows.Forms.Button();
            this.txt7 = new System.Windows.Forms.Button();
            this.txt9 = new System.Windows.Forms.Button();
            this.txt8 = new System.Windows.Forms.Button();
            this.txtgerigel = new System.Windows.Forms.Button();
            this.txt5 = new System.Windows.Forms.Button();
            this.txtesittir = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.Button();
            this.txtcıkarma = new System.Windows.Forms.Button();
            this.txtcarpma = new System.Windows.Forms.Button();
            this.txtbolme = new System.Windows.Forms.Button();
            this.txtislem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txttc = new System.Windows.Forms.TextBox();
            this.txtbarkod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_kameraaç = new System.Windows.Forms.Button();
            this.pctbox_kamera = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmd_kamerasec = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_kamera)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1185, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txttemizle);
            this.groupBox2.Controls.Add(this.txttoplama);
            this.groupBox2.Controls.Add(this.txt2);
            this.groupBox2.Controls.Add(this.txt3);
            this.groupBox2.Controls.Add(this.txt4);
            this.groupBox2.Controls.Add(this.txt6);
            this.groupBox2.Controls.Add(this.txt7);
            this.groupBox2.Controls.Add(this.txt9);
            this.groupBox2.Controls.Add(this.txt8);
            this.groupBox2.Controls.Add(this.txtgerigel);
            this.groupBox2.Controls.Add(this.txt5);
            this.groupBox2.Controls.Add(this.txtesittir);
            this.groupBox2.Controls.Add(this.txt1);
            this.groupBox2.Controls.Add(this.txtcıkarma);
            this.groupBox2.Controls.Add(this.txtcarpma);
            this.groupBox2.Controls.Add(this.txtbolme);
            this.groupBox2.Controls.Add(this.txtislem);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(809, 329);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 387);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HESAP MAKİNESİ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 334);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 47);
            this.button2.TabIndex = 15;
            this.button2.Text = "0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.secilentus);
            // 
            // txttemizle
            // 
            this.txttemizle.Location = new System.Drawing.Point(301, 161);
            this.txttemizle.Name = "txttemizle";
            this.txttemizle.Size = new System.Drawing.Size(69, 49);
            this.txttemizle.TabIndex = 14;
            this.txttemizle.Text = "C";
            this.txttemizle.UseVisualStyleBackColor = true;
            this.txttemizle.Click += new System.EventHandler(this.txttemizle_Click);
            // 
            // txttoplama
            // 
            this.txttoplama.Location = new System.Drawing.Point(301, 101);
            this.txttoplama.Name = "txttoplama";
            this.txttoplama.Size = new System.Drawing.Size(69, 51);
            this.txttoplama.TabIndex = 13;
            this.txttoplama.Text = "+";
            this.txttoplama.UseVisualStyleBackColor = true;
            this.txttoplama.Click += new System.EventHandler(this.txttoplama_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(127, 161);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(69, 49);
            this.txt2.TabIndex = 12;
            this.txt2.Text = "2";
            this.txt2.UseVisualStyleBackColor = true;
            this.txt2.Click += new System.EventHandler(this.secilentus);
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(214, 159);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(69, 49);
            this.txt3.TabIndex = 11;
            this.txt3.Text = "3";
            this.txt3.UseVisualStyleBackColor = true;
            this.txt3.Click += new System.EventHandler(this.secilentus);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(46, 219);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(69, 51);
            this.txt4.TabIndex = 10;
            this.txt4.Text = "4";
            this.txt4.UseVisualStyleBackColor = true;
            this.txt4.Click += new System.EventHandler(this.secilentus);
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(214, 219);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(69, 51);
            this.txt6.TabIndex = 9;
            this.txt6.Text = "6";
            this.txt6.UseVisualStyleBackColor = true;
            this.txt6.Click += new System.EventHandler(this.secilentus);
            // 
            // txt7
            // 
            this.txt7.Location = new System.Drawing.Point(46, 276);
            this.txt7.Name = "txt7";
            this.txt7.Size = new System.Drawing.Size(69, 51);
            this.txt7.TabIndex = 8;
            this.txt7.Text = "7";
            this.txt7.UseVisualStyleBackColor = true;
            this.txt7.Click += new System.EventHandler(this.secilentus);
            // 
            // txt9
            // 
            this.txt9.Location = new System.Drawing.Point(214, 276);
            this.txt9.Name = "txt9";
            this.txt9.Size = new System.Drawing.Size(69, 51);
            this.txt9.TabIndex = 7;
            this.txt9.Text = "9";
            this.txt9.UseVisualStyleBackColor = true;
            this.txt9.Click += new System.EventHandler(this.secilentus);
            // 
            // txt8
            // 
            this.txt8.Location = new System.Drawing.Point(127, 276);
            this.txt8.Name = "txt8";
            this.txt8.Size = new System.Drawing.Size(69, 51);
            this.txt8.TabIndex = 7;
            this.txt8.Text = "8";
            this.txt8.UseVisualStyleBackColor = true;
            this.txt8.Click += new System.EventHandler(this.secilentus);
            // 
            // txtgerigel
            // 
            this.txtgerigel.Location = new System.Drawing.Point(45, 330);
            this.txtgerigel.Name = "txtgerigel";
            this.txtgerigel.Size = new System.Drawing.Size(238, 51);
            this.txtgerigel.TabIndex = 5;
            this.txtgerigel.Text = "<GERİ GEL";
            this.txtgerigel.UseVisualStyleBackColor = true;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(127, 219);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(69, 51);
            this.txt5.TabIndex = 6;
            this.txt5.Text = "5";
            this.txt5.UseVisualStyleBackColor = true;
            this.txt5.Click += new System.EventHandler(this.secilentus);
            // 
            // txtesittir
            // 
            this.txtesittir.Location = new System.Drawing.Point(301, 219);
            this.txtesittir.Name = "txtesittir";
            this.txtesittir.Size = new System.Drawing.Size(69, 104);
            this.txtesittir.TabIndex = 5;
            this.txtesittir.Text = "=";
            this.txtesittir.UseVisualStyleBackColor = true;
            this.txtesittir.Click += new System.EventHandler(this.txtesittir_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(46, 159);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(69, 49);
            this.txt1.TabIndex = 4;
            this.txt1.Text = "1";
            this.txt1.UseVisualStyleBackColor = true;
            this.txt1.Click += new System.EventHandler(this.secilentus);
            // 
            // txtcıkarma
            // 
            this.txtcıkarma.Location = new System.Drawing.Point(214, 101);
            this.txtcıkarma.Name = "txtcıkarma";
            this.txtcıkarma.Size = new System.Drawing.Size(69, 49);
            this.txtcıkarma.TabIndex = 3;
            this.txtcıkarma.Text = "-";
            this.txtcıkarma.UseVisualStyleBackColor = true;
            this.txtcıkarma.Click += new System.EventHandler(this.txtcıkarma_Click);
            // 
            // txtcarpma
            // 
            this.txtcarpma.Location = new System.Drawing.Point(127, 101);
            this.txtcarpma.Name = "txtcarpma";
            this.txtcarpma.Size = new System.Drawing.Size(69, 49);
            this.txtcarpma.TabIndex = 2;
            this.txtcarpma.Text = "X";
            this.txtcarpma.UseVisualStyleBackColor = true;
            this.txtcarpma.Click += new System.EventHandler(this.txtcarpma_Click);
            // 
            // txtbolme
            // 
            this.txtbolme.Location = new System.Drawing.Point(45, 101);
            this.txtbolme.Name = "txtbolme";
            this.txtbolme.Size = new System.Drawing.Size(69, 49);
            this.txtbolme.TabIndex = 1;
            this.txtbolme.Text = "/";
            this.txtbolme.UseVisualStyleBackColor = true;
            this.txtbolme.Click += new System.EventHandler(this.txtbolme_Click);
            // 
            // txtislem
            // 
            this.txtislem.Location = new System.Drawing.Point(45, 25);
            this.txtislem.Multiline = true;
            this.txtislem.Name = "txtislem";
            this.txtislem.Size = new System.Drawing.Size(325, 68);
            this.txtislem.TabIndex = 0;
            this.txtislem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtislem.Click += new System.EventHandler(this.secilentus);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(505, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 46);
            this.label4.TabIndex = 8;
            this.label4.Text = "ECZANEM";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txttc);
            this.groupBox1.Controls.Add(this.txtbarkod);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(27, 329);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 182);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reçete İşlemi";
            // 
            // txttc
            // 
            this.txttc.Location = new System.Drawing.Point(115, 23);
            this.txttc.Multiline = true;
            this.txttc.Name = "txttc";
            this.txttc.Size = new System.Drawing.Size(173, 29);
            this.txttc.TabIndex = 7;
            // 
            // txtbarkod
            // 
            this.txtbarkod.Location = new System.Drawing.Point(115, 68);
            this.txtbarkod.Multiline = true;
            this.txtbarkod.Name = "txtbarkod";
            this.txtbarkod.Size = new System.Drawing.Size(173, 29);
            this.txtbarkod.TabIndex = 6;
            this.txtbarkod.TextChanged += new System.EventHandler(this.txtbarkod_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "BARKOD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "TC NO";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btn_kameraaç);
            this.groupBox3.Controls.Add(this.pctbox_kamera);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cmd_kamerasec);
            this.groupBox3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(350, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(402, 367);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Qr Koda Reçeteyi Okut";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(194, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "Kamerayı Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_kameraaç
            // 
            this.btn_kameraaç.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kameraaç.Location = new System.Drawing.Point(19, 258);
            this.btn_kameraaç.Name = "btn_kameraaç";
            this.btn_kameraaç.Size = new System.Drawing.Size(169, 45);
            this.btn_kameraaç.TabIndex = 3;
            this.btn_kameraaç.Text = "Kamerayı Aç";
            this.btn_kameraaç.UseVisualStyleBackColor = true;
            this.btn_kameraaç.Click += new System.EventHandler(this.btn_kameraaç_Click);
            // 
            // pctbox_kamera
            // 
            this.pctbox_kamera.Image = global::WindowsFormsApp1.Properties.Resources.kamera;
            this.pctbox_kamera.Location = new System.Drawing.Point(80, 21);
            this.pctbox_kamera.Name = "pctbox_kamera";
            this.pctbox_kamera.Size = new System.Drawing.Size(235, 170);
            this.pctbox_kamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbox_kamera.TabIndex = 2;
            this.pctbox_kamera.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Kamera Seç:";
            // 
            // cmd_kamerasec
            // 
            this.cmd_kamerasec.FormattingEnabled = true;
            this.cmd_kamerasec.Location = new System.Drawing.Point(139, 219);
            this.cmd_kamerasec.Name = "cmd_kamerasec";
            this.cmd_kamerasec.Size = new System.Drawing.Size(154, 30);
            this.cmd_kamerasec.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(58, 103);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "Tamam";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // İşlem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1209, 703);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "İşlem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İşlem";
            this.Load += new System.EventHandler(this.İşlem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbox_kamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button txtesittir;
        private System.Windows.Forms.Button txt1;
        private System.Windows.Forms.Button txtcıkarma;
        private System.Windows.Forms.Button txtcarpma;
        private System.Windows.Forms.Button txtbolme;
        private System.Windows.Forms.TextBox txtislem;
        private System.Windows.Forms.Button txttemizle;
        private System.Windows.Forms.Button txttoplama;
        private System.Windows.Forms.Button txt2;
        private System.Windows.Forms.Button txt3;
        private System.Windows.Forms.Button txt4;
        private System.Windows.Forms.Button txt6;
        private System.Windows.Forms.Button txt7;
        private System.Windows.Forms.Button txt8;
        private System.Windows.Forms.Button txt5;
        private System.Windows.Forms.Button txt9;
        private System.Windows.Forms.Button txtgerigel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttc;
        private System.Windows.Forms.TextBox txtbarkod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_kameraaç;
        private System.Windows.Forms.PictureBox pctbox_kamera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmd_kamerasec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
    }
}