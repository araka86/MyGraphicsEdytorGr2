namespace MyGraphicsEdytorGr2
{
    partial class myCircle
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nuvx1 = new System.Windows.Forms.NumericUpDown();
            this.nuvy1 = new System.Windows.Forms.NumericUpDown();
            this.nuvy0 = new System.Windows.Forms.NumericUpDown();
            this.nuvx0 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnNone = new System.Windows.Forms.Button();
            this.custumLine = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.CnmX = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.CnmR = new System.Windows.Forms.NumericUpDown();
            this.lblR = new System.Windows.Forms.Label();
            this.CnmY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.rbup = new System.Windows.Forms.RadioButton();
            this.rbdown = new System.Windows.Forms.RadioButton();
            this.rbleft = new System.Windows.Forms.RadioButton();
            this.rbright = new System.Windows.Forms.RadioButton();
            this.rbfull = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.myElipse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvy0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvx0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CnmX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CnmR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CnmY)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1032, 429);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(135, 5);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(75, 23);
            this.btnLine.TabIndex = 2;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(695, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(760, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(851, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(760, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y1";
            // 
            // nuvx1
            // 
            this.nuvx1.Location = new System.Drawing.Point(877, 49);
            this.nuvx1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuvx1.Name = "nuvx1";
            this.nuvx1.Size = new System.Drawing.Size(48, 20);
            this.nuvx1.TabIndex = 11;
            // 
            // nuvy1
            // 
            this.nuvy1.Location = new System.Drawing.Point(786, 83);
            this.nuvy1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuvy1.Name = "nuvy1";
            this.nuvy1.Size = new System.Drawing.Size(48, 20);
            this.nuvy1.TabIndex = 12;
            // 
            // nuvy0
            // 
            this.nuvy0.Location = new System.Drawing.Point(786, 14);
            this.nuvy0.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuvy0.Name = "nuvy0";
            this.nuvy0.Size = new System.Drawing.Size(48, 20);
            this.nuvy0.TabIndex = 13;
            // 
            // nuvx0
            // 
            this.nuvx0.Location = new System.Drawing.Point(721, 52);
            this.nuvx0.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nuvx0.Name = "nuvx0";
            this.nuvx0.Size = new System.Drawing.Size(48, 20);
            this.nuvx0.TabIndex = 14;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(571, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(938, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(12, 43);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(75, 23);
            this.btnNone.TabIndex = 17;
            this.btnNone.Text = "None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.btnNone_Click);
            // 
            // custumLine
            // 
            this.custumLine.Location = new System.Drawing.Point(571, 17);
            this.custumLine.Name = "custumLine";
            this.custumLine.Size = new System.Drawing.Size(75, 23);
            this.custumLine.TabIndex = 18;
            this.custumLine.Text = "CustomLine";
            this.custumLine.UseVisualStyleBackColor = true;
            this.custumLine.Click += new System.EventHandler(this.custumLine_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.Location = new System.Drawing.Point(135, 42);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(75, 23);
            this.btnCircle.TabIndex = 19;
            this.btnCircle.Text = "Circle";
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // CnmX
            // 
            this.CnmX.Location = new System.Drawing.Point(450, 8);
            this.CnmX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CnmX.Name = "CnmX";
            this.CnmX.Size = new System.Drawing.Size(48, 20);
            this.CnmX.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "X0";
            // 
            // CnmR
            // 
            this.CnmR.Location = new System.Drawing.Point(450, 50);
            this.CnmR.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CnmR.Name = "CnmR";
            this.CnmR.Size = new System.Drawing.Size(48, 20);
            this.CnmR.TabIndex = 23;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(424, 55);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(15, 13);
            this.lblR.TabIndex = 22;
            this.lblR.Text = "R";
            // 
            // CnmY
            // 
            this.CnmY.Location = new System.Drawing.Point(450, 83);
            this.CnmY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CnmY.Name = "CnmY";
            this.CnmY.Size = new System.Drawing.Size(48, 20);
            this.CnmY.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Y0";
            // 
            // rbup
            // 
            this.rbup.AutoSize = true;
            this.rbup.Location = new System.Drawing.Point(301, 5);
            this.rbup.Name = "rbup";
            this.rbup.Size = new System.Drawing.Size(37, 17);
            this.rbup.TabIndex = 26;
            this.rbup.Text = "up";
            this.rbup.UseVisualStyleBackColor = true;
            // 
            // rbdown
            // 
            this.rbdown.AutoSize = true;
            this.rbdown.Location = new System.Drawing.Point(301, 63);
            this.rbdown.Name = "rbdown";
            this.rbdown.Size = new System.Drawing.Size(51, 17);
            this.rbdown.TabIndex = 27;
            this.rbdown.TabStop = true;
            this.rbdown.Text = "down";
            this.rbdown.UseVisualStyleBackColor = true;
            // 
            // rbleft
            // 
            this.rbleft.AutoSize = true;
            this.rbleft.Location = new System.Drawing.Point(243, 37);
            this.rbleft.Name = "rbleft";
            this.rbleft.Size = new System.Drawing.Size(39, 17);
            this.rbleft.TabIndex = 28;
            this.rbleft.Text = "left";
            this.rbleft.UseVisualStyleBackColor = true;
            // 
            // rbright
            // 
            this.rbright.AutoSize = true;
            this.rbright.Location = new System.Drawing.Point(353, 37);
            this.rbright.Name = "rbright";
            this.rbright.Size = new System.Drawing.Size(45, 17);
            this.rbright.TabIndex = 29;
            this.rbright.TabStop = true;
            this.rbright.Text = "right";
            this.rbright.UseVisualStyleBackColor = true;
            // 
            // rbfull
            // 
            this.rbfull.AutoSize = true;
            this.rbfull.Checked = true;
            this.rbfull.Location = new System.Drawing.Point(301, 37);
            this.rbfull.Name = "rbfull";
            this.rbfull.Size = new System.Drawing.Size(38, 17);
            this.rbfull.TabIndex = 30;
            this.rbfull.TabStop = true;
            this.rbfull.Text = "full";
            this.rbfull.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Y0";
            // 
            // myElipse
            // 
            this.myElipse.Location = new System.Drawing.Point(135, 83);
            this.myElipse.Name = "myElipse";
            this.myElipse.Size = new System.Drawing.Size(75, 23);
            this.myElipse.TabIndex = 32;
            this.myElipse.Text = "Elipse";
            this.myElipse.UseVisualStyleBackColor = true;
            this.myElipse.Click += new System.EventHandler(this.myElipse_Click);
            // 
            // myCircle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 572);
            this.Controls.Add(this.myElipse);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rbfull);
            this.Controls.Add(this.rbright);
            this.Controls.Add(this.rbleft);
            this.Controls.Add(this.rbdown);
            this.Controls.Add(this.rbup);
            this.Controls.Add(this.CnmY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CnmR);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.CnmX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCircle);
            this.Controls.Add(this.custumLine);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.nuvx0);
            this.Controls.Add(this.nuvy0);
            this.Controls.Add(this.nuvy1);
            this.Controls.Add(this.nuvx1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "myCircle";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvy0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuvx0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CnmX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CnmR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CnmY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nuvx1;
        private System.Windows.Forms.NumericUpDown nuvy1;
        private System.Windows.Forms.NumericUpDown nuvy0;
        private System.Windows.Forms.NumericUpDown nuvx0;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button custumLine;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.NumericUpDown CnmX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown CnmR;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.NumericUpDown CnmY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbup;
        private System.Windows.Forms.RadioButton rbdown;
        private System.Windows.Forms.RadioButton rbleft;
        private System.Windows.Forms.RadioButton rbright;
        private System.Windows.Forms.RadioButton rbfull;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button myElipse;
    }
}

