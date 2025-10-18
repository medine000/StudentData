namespace BMUdata
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            button3 = new Button();
            panel1 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            maskedTextBox4 = new MaskedTextBox();
            maskedTextBox5 = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            maskedTextBox7 = new MaskedTextBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 233);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "SDF1 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 293);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "SDF2 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 365);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 2;
            label3.Text = "FF :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 423);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Seminar :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 488);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 4;
            label5.Text = "Final :";
            label5.Click += label5_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dataGridView1.Location = new Point(594, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(400, 303);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Ad ve Soyad";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Telebe nomresi";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Netice";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // button3
            // 
            button3.Location = new Point(872, 542);
            button3.Name = "button3";
            button3.Size = new Size(122, 49);
            button3.TabIndex = 17;
            button3.Text = "Cixis";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 0, 0);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 204);
            panel1.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Stencil", 34.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(458, 45);
            label6.Name = "label6";
            label6.Size = new Size(540, 69);
            label6.TabIndex = 1;
            label6.Text = "Imtahan Sistemi";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bmu_logo;
            pictureBox1.Location = new Point(0, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(452, 111);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(104, 226);
            maskedTextBox1.Mask = "00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(72, 27);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(104, 286);
            maskedTextBox2.Mask = "00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(72, 27);
            maskedTextBox2.TabIndex = 19;
            maskedTextBox2.ValidatingType = typeof(int);
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(104, 358);
            maskedTextBox3.Mask = "00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(72, 27);
            maskedTextBox3.TabIndex = 20;
            maskedTextBox3.ValidatingType = typeof(int);
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(104, 416);
            maskedTextBox4.Mask = "00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(72, 27);
            maskedTextBox4.TabIndex = 21;
            maskedTextBox4.ValidatingType = typeof(int);
            // 
            // maskedTextBox5
            // 
            maskedTextBox5.Location = new Point(104, 485);
            maskedTextBox5.Mask = "00";
            maskedTextBox5.Name = "maskedTextBox5";
            maskedTextBox5.Size = new Size(72, 27);
            maskedTextBox5.TabIndex = 22;
            maskedTextBox5.ValidatingType = typeof(int);
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Location = new Point(28, 161);
            button1.Name = "button1";
            button1.Size = new Size(279, 47);
            button1.TabIndex = 2;
            button1.Text = "Hesabla";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Brown;
            button2.Location = new Point(28, 228);
            button2.Name = "button2";
            button2.Size = new Size(279, 47);
            button2.TabIndex = 3;
            button2.Text = "Xanalari sifirla";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // maskedTextBox7
            // 
            maskedTextBox7.Location = new Point(28, 97);
            maskedTextBox7.Mask = "000000000000000";
            maskedTextBox7.Name = "maskedTextBox7";
            maskedTextBox7.Size = new Size(279, 27);
            maskedTextBox7.TabIndex = 8;
            maskedTextBox7.ValidatingType = typeof(int);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(maskedTextBox7);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(232, 211);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(333, 303);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Telebenin melumatlari";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(29, 45);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(275, 28);
            textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 624);
            Controls.Add(maskedTextBox5);
            Controls.Add(maskedTextBox4);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private Button button3;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Panel panel1;
        private Label label6;
        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private MaskedTextBox maskedTextBox4;
        private MaskedTextBox maskedTextBox5;
        private Button button1;
        private Button button2;
        private MaskedTextBox maskedTextBox7;
        private GroupBox groupBox1;
        private TextBox textBox1;
    }
}
