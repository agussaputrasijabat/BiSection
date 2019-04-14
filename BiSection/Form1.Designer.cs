namespace BiSection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.HeaderLine = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DBGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Val1 = new System.Windows.Forms.TextBox();
            this.Val2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAnswer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnReset = new BiSection.FlatButton();
            this.BtnCalculate = new BiSection.FlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FXU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fxm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FXL_FXM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Es = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.HeaderLine);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1429, 95);
            this.panel1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(988, 26);
            this.label7.TabIndex = 5;
            this.label7.Text = "Metode Bisection adalah salah satu jenis metode pencarian instrumental dimana sel" +
    "ang/range selalu dibagi dua atau membagi range menjadi 2 bagian.";
            // 
            // HeaderLine
            // 
            this.HeaderLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.HeaderLine.Location = new System.Drawing.Point(0, 87);
            this.HeaderLine.Name = "HeaderLine";
            this.HeaderLine.Size = new System.Drawing.Size(1317, 1);
            this.HeaderLine.TabIndex = 4;
            this.HeaderLine.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Metode Bisection";
            // 
            // DBGrid
            // 
            this.DBGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DBGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.DBGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DBGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DBGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.XL,
            this.XU,
            this.fxl,
            this.FXU,
            this.XM,
            this.fxm,
            this.FXL_FXM,
            this.Es});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DBGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.DBGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.DBGrid.Location = new System.Drawing.Point(309, 181);
            this.DBGrid.Name = "DBGrid";
            this.DBGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DBGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DBGrid.RowTemplate.Height = 25;
            this.DBGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DBGrid.Size = new System.Drawing.Size(1108, 538);
            this.DBGrid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Batas bawah";
            // 
            // Val1
            // 
            this.Val1.Location = new System.Drawing.Point(403, 114);
            this.Val1.Name = "Val1";
            this.Val1.Size = new System.Drawing.Size(130, 25);
            this.Val1.TabIndex = 4;
            // 
            // Val2
            // 
            this.Val2.Location = new System.Drawing.Point(673, 114);
            this.Val2.Name = "Val2";
            this.Val2.Size = new System.Drawing.Size(130, 25);
            this.Val2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Batas Atas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblAnswer);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(17, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 133);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // LblAnswer
            // 
            this.LblAnswer.Location = new System.Drawing.Point(10, 56);
            this.LblAnswer.Name = "LblAnswer";
            this.LblAnswer.Size = new System.Drawing.Size(262, 61);
            this.LblAnswer.TabIndex = 1;
            this.LblAnswer.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Jawaban";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(14, 702);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "© 2019 Agus Saputra Sijabat";
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BtnReset.DisableBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(176)))), ((int)(((byte)(199)))));
            this.BtnReset.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.BtnReset.ForeColor = System.Drawing.Color.White;
            this.BtnReset.Location = new System.Drawing.Point(85, 325);
            this.BtnReset.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BtnReset.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BtnReset.Size = new System.Drawing.Size(143, 25);
            this.BtnReset.TabIndex = 9;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BtnCalculate.DisableBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(176)))), ((int)(((byte)(199)))));
            this.BtnCalculate.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.BtnCalculate.ForeColor = System.Drawing.Color.White;
            this.BtnCalculate.Location = new System.Drawing.Point(827, 114);
            this.BtnCalculate.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.BtnCalculate.MouseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.NormalBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.BtnCalculate.Size = new System.Drawing.Size(143, 25);
            this.BtnCalculate.TabIndex = 7;
            this.BtnCalculate.Text = "Tetapkan Batas";
            this.BtnCalculate.UseVisualStyleBackColor = false;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1208, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "NIM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1208, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1208, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Kelas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1273, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = ": MC-MTI";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1273, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = ": Agus Saputra Sijabat";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1273, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = ": 1610307055047";
            // 
            // No
            // 
            this.No.HeaderText = "Iterasi";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            // 
            // XL
            // 
            this.XL.HeaderText = "xl";
            this.XL.Name = "XL";
            this.XL.ReadOnly = true;
            // 
            // XU
            // 
            this.XU.HeaderText = "xu";
            this.XU.Name = "XU";
            this.XU.ReadOnly = true;
            // 
            // fxl
            // 
            this.fxl.HeaderText = "f(xl)";
            this.fxl.Name = "fxl";
            this.fxl.ReadOnly = true;
            // 
            // FXU
            // 
            this.FXU.HeaderText = "f(xu)";
            this.FXU.Name = "FXU";
            this.FXU.ReadOnly = true;
            // 
            // XM
            // 
            this.XM.HeaderText = "xm";
            this.XM.Name = "XM";
            this.XM.ReadOnly = true;
            // 
            // fxm
            // 
            this.fxm.HeaderText = "f(xm)";
            this.fxm.Name = "fxm";
            this.fxm.ReadOnly = true;
            // 
            // FXL_FXM
            // 
            this.FXL_FXM.HeaderText = "f(xl)*f(xm)";
            this.FXL_FXM.Name = "FXL_FXM";
            this.FXL_FXM.ReadOnly = true;
            // 
            // Es
            // 
            this.Es.HeaderText = "|Es|<0.001";
            this.Es.Name = "Es";
            this.Es.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1429, 731);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.Val2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Val1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DBGrid);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metode Bisection";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DBGrid;
        private System.Windows.Forms.PictureBox HeaderLine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Val1;
        private System.Windows.Forms.TextBox Val2;
        private System.Windows.Forms.Label label3;
        private FlatButton BtnCalculate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblAnswer;
        private FlatButton BtnReset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn XL;
        private System.Windows.Forms.DataGridViewTextBoxColumn XU;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxl;
        private System.Windows.Forms.DataGridViewTextBoxColumn FXU;
        private System.Windows.Forms.DataGridViewTextBoxColumn XM;
        private System.Windows.Forms.DataGridViewTextBoxColumn fxm;
        private System.Windows.Forms.DataGridViewTextBoxColumn FXL_FXM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Es;
    }
}

