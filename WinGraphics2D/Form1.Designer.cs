namespace WinGraphics2D
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxScalingY = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxScaling = new System.Windows.Forms.CheckBox();
            this.checkBoxRotationAround = new System.Windows.Forms.CheckBox();
            this.checkBoxRotation = new System.Windows.Forms.CheckBox();
            this.checkBoxTranslation = new System.Windows.Forms.CheckBox();
            this.textBoxRotationAroundX = new System.Windows.Forms.TextBox();
            this.textBoxRotationAroundY = new System.Windows.Forms.TextBox();
            this.textBoxTranslationY = new System.Windows.Forms.TextBox();
            this.textBoxRotationAroundAngle = new System.Windows.Forms.TextBox();
            this.textBoxScalingX = new System.Windows.Forms.TextBox();
            this.textBoxRotation = new System.Windows.Forms.TextBox();
            this.textBoxTranslationX = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(293, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(898, 422);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1200, 612);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 159);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1194, 450);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.textBoxScalingY);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.textBoxRotationAroundX);
            this.groupBox2.Controls.Add(this.textBoxRotationAroundY);
            this.groupBox2.Controls.Add(this.textBoxTranslationY);
            this.groupBox2.Controls.Add(this.textBoxRotationAroundAngle);
            this.groupBox2.Controls.Add(this.textBoxScalingX);
            this.groupBox2.Controls.Add(this.textBoxRotation);
            this.groupBox2.Controls.Add(this.textBoxTranslationX);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1194, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(900, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxScalingY
            // 
            this.textBoxScalingY.Location = new System.Drawing.Point(677, 100);
            this.textBoxScalingY.Name = "textBoxScalingY";
            this.textBoxScalingY.Size = new System.Drawing.Size(43, 20);
            this.textBoxScalingY.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxScaling);
            this.panel1.Controls.Add(this.checkBoxRotationAround);
            this.panel1.Controls.Add(this.checkBoxRotation);
            this.panel1.Controls.Add(this.checkBoxTranslation);
            this.panel1.Location = new System.Drawing.Point(409, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 107);
            this.panel1.TabIndex = 12;
            // 
            // checkBoxScaling
            // 
            this.checkBoxScaling.AutoSize = true;
            this.checkBoxScaling.Location = new System.Drawing.Point(4, 83);
            this.checkBoxScaling.Name = "checkBoxScaling";
            this.checkBoxScaling.Size = new System.Drawing.Size(61, 17);
            this.checkBoxScaling.TabIndex = 3;
            this.checkBoxScaling.Text = "Scaling";
            this.checkBoxScaling.UseVisualStyleBackColor = true;
            // 
            // checkBoxRotationAround
            // 
            this.checkBoxRotationAround.AutoSize = true;
            this.checkBoxRotationAround.Location = new System.Drawing.Point(4, 55);
            this.checkBoxRotationAround.Name = "checkBoxRotationAround";
            this.checkBoxRotationAround.Size = new System.Drawing.Size(131, 17);
            this.checkBoxRotationAround.TabIndex = 2;
            this.checkBoxRotationAround.Text = "RotationAround(x0,y0)";
            this.checkBoxRotationAround.UseVisualStyleBackColor = true;
            // 
            // checkBoxRotation
            // 
            this.checkBoxRotation.AutoSize = true;
            this.checkBoxRotation.Location = new System.Drawing.Point(4, 29);
            this.checkBoxRotation.Name = "checkBoxRotation";
            this.checkBoxRotation.Size = new System.Drawing.Size(66, 17);
            this.checkBoxRotation.TabIndex = 1;
            this.checkBoxRotation.Text = "Rotation";
            this.checkBoxRotation.UseVisualStyleBackColor = true;
            // 
            // checkBoxTranslation
            // 
            this.checkBoxTranslation.AutoSize = true;
            this.checkBoxTranslation.Location = new System.Drawing.Point(4, 4);
            this.checkBoxTranslation.Name = "checkBoxTranslation";
            this.checkBoxTranslation.Size = new System.Drawing.Size(78, 17);
            this.checkBoxTranslation.TabIndex = 0;
            this.checkBoxTranslation.Text = "Translation";
            this.checkBoxTranslation.UseVisualStyleBackColor = true;
            this.checkBoxTranslation.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBoxRotationAroundX
            // 
            this.textBoxRotationAroundX.Location = new System.Drawing.Point(615, 71);
            this.textBoxRotationAroundX.Name = "textBoxRotationAroundX";
            this.textBoxRotationAroundX.Size = new System.Drawing.Size(43, 20);
            this.textBoxRotationAroundX.TabIndex = 11;
            // 
            // textBoxRotationAroundY
            // 
            this.textBoxRotationAroundY.Location = new System.Drawing.Point(677, 71);
            this.textBoxRotationAroundY.Name = "textBoxRotationAroundY";
            this.textBoxRotationAroundY.Size = new System.Drawing.Size(43, 20);
            this.textBoxRotationAroundY.TabIndex = 10;
            // 
            // textBoxTranslationY
            // 
            this.textBoxTranslationY.Location = new System.Drawing.Point(677, 21);
            this.textBoxTranslationY.Name = "textBoxTranslationY";
            this.textBoxTranslationY.Size = new System.Drawing.Size(43, 20);
            this.textBoxTranslationY.TabIndex = 9;
            // 
            // textBoxRotationAroundAngle
            // 
            this.textBoxRotationAroundAngle.Location = new System.Drawing.Point(736, 71);
            this.textBoxRotationAroundAngle.Name = "textBoxRotationAroundAngle";
            this.textBoxRotationAroundAngle.Size = new System.Drawing.Size(43, 20);
            this.textBoxRotationAroundAngle.TabIndex = 8;
            // 
            // textBoxScalingX
            // 
            this.textBoxScalingX.Location = new System.Drawing.Point(615, 99);
            this.textBoxScalingX.Name = "textBoxScalingX";
            this.textBoxScalingX.Size = new System.Drawing.Size(43, 20);
            this.textBoxScalingX.TabIndex = 7;
            // 
            // textBoxRotation
            // 
            this.textBoxRotation.Location = new System.Drawing.Point(615, 45);
            this.textBoxRotation.Name = "textBoxRotation";
            this.textBoxRotation.Size = new System.Drawing.Size(43, 20);
            this.textBoxRotation.TabIndex = 6;
            // 
            // textBoxTranslationX
            // 
            this.textBoxTranslationX.Location = new System.Drawing.Point(615, 21);
            this.textBoxTranslationX.Name = "textBoxTranslationX";
            this.textBoxTranslationX.Size = new System.Drawing.Size(43, 20);
            this.textBoxTranslationX.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(900, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Location = new System.Drawing.Point(3, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 450);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(278, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 612);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxScaling;
        private System.Windows.Forms.CheckBox checkBoxRotationAround;
        private System.Windows.Forms.CheckBox checkBoxRotation;
        private System.Windows.Forms.CheckBox checkBoxTranslation;
        private System.Windows.Forms.TextBox textBoxRotationAroundX;
        private System.Windows.Forms.TextBox textBoxRotationAroundY;
        private System.Windows.Forms.TextBox textBoxTranslationY;
        private System.Windows.Forms.TextBox textBoxRotationAroundAngle;
        private System.Windows.Forms.TextBox textBoxScalingX;
        private System.Windows.Forms.TextBox textBoxRotation;
        private System.Windows.Forms.TextBox textBoxTranslationX;
        private System.Windows.Forms.TextBox textBoxScalingY;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

