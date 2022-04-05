namespace WindowsFormsBulldozer
{
    partial class FormBulldozerConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBulldozerConfig));
            this.label1 = new System.Windows.Forms.Label();
            this.SimpleBulldozer = new System.Windows.Forms.Label();
            this.labelSuperBulldozer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numeriсMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericWeight = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flasher = new System.Windows.Forms.CheckBox();
            this.sportLine = new System.Windows.Forms.CheckBox();
            this.backBucket = new System.Windows.Forms.CheckBox();
            this.frontBucket = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxBulldozer = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.labelСomplementaryСolor = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.buttonAddCarFromConfig = new System.Windows.Forms.Button();
            this.buttonCloseConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numeriсMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBulldozer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип кузова";
            // 
            // SimpleBulldozer
            // 
            this.SimpleBulldozer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SimpleBulldozer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SimpleBulldozer.Location = new System.Drawing.Point(9, 35);
            this.SimpleBulldozer.Name = "SimpleBulldozer";
            this.SimpleBulldozer.Size = new System.Drawing.Size(109, 39);
            this.SimpleBulldozer.TabIndex = 1;
            this.SimpleBulldozer.Text = "Обычный трактор";
            this.SimpleBulldozer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SimpleBulldozer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelObject_MouseDown);
            // 
            // labelSuperBulldozer
            // 
            this.labelSuperBulldozer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSuperBulldozer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSuperBulldozer.Location = new System.Drawing.Point(9, 84);
            this.labelSuperBulldozer.Name = "labelSuperBulldozer";
            this.labelSuperBulldozer.Size = new System.Drawing.Size(109, 39);
            this.labelSuperBulldozer.TabIndex = 2;
            this.labelSuperBulldozer.Text = "Трактор с навесом";
            this.labelSuperBulldozer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSuperBulldozer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelObject_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Параметры";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Максимальная скорость:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Вес трактора:";
            // 
            // numeriсMaxSpeed
            // 
            this.numeriсMaxSpeed.Location = new System.Drawing.Point(74, 41);
            this.numeriсMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numeriсMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numeriсMaxSpeed.Name = "numeriсMaxSpeed";
            this.numeriсMaxSpeed.Size = new System.Drawing.Size(63, 20);
            this.numeriсMaxSpeed.TabIndex = 6;
            this.numeriсMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericWeight
            // 
            this.numericWeight.Location = new System.Drawing.Point(74, 101);
            this.numericWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericWeight.Name = "numericWeight";
            this.numericWeight.Size = new System.Drawing.Size(63, 20);
            this.numericWeight.TabIndex = 7;
            this.numericWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flasher);
            this.groupBox1.Controls.Add(this.sportLine);
            this.groupBox1.Controls.Add(this.backBucket);
            this.groupBox1.Controls.Add(this.frontBucket);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericWeight);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.numeriсMaxSpeed);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(0, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 127);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // flasher
            // 
            this.flasher.AutoSize = true;
            this.flasher.Checked = true;
            this.flasher.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flasher.Location = new System.Drawing.Point(165, 101);
            this.flasher.Name = "flasher";
            this.flasher.Size = new System.Drawing.Size(112, 17);
            this.flasher.TabIndex = 11;
            this.flasher.Text = "Боковые полосы";
            this.flasher.UseVisualStyleBackColor = true;
            // 
            // sportLine
            // 
            this.sportLine.AutoSize = true;
            this.sportLine.Checked = true;
            this.sportLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sportLine.Location = new System.Drawing.Point(165, 75);
            this.sportLine.Name = "sportLine";
            this.sportLine.Size = new System.Drawing.Size(145, 17);
            this.sportLine.TabIndex = 10;
            this.sportLine.Text = "Проблесковый маячок ";
            this.sportLine.UseVisualStyleBackColor = true;
            // 
            // backBucket
            // 
            this.backBucket.AutoSize = true;
            this.backBucket.Checked = true;
            this.backBucket.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backBucket.Location = new System.Drawing.Point(165, 49);
            this.backBucket.Name = "backBucket";
            this.backBucket.Size = new System.Drawing.Size(99, 17);
            this.backBucket.TabIndex = 9;
            this.backBucket.Text = "Задний  навес";
            this.backBucket.UseVisualStyleBackColor = true;
            // 
            // frontBucket
            // 
            this.frontBucket.AutoSize = true;
            this.frontBucket.Checked = true;
            this.frontBucket.CheckState = System.Windows.Forms.CheckState.Checked;
            this.frontBucket.Location = new System.Drawing.Point(165, 22);
            this.frontBucket.Name = "frontBucket";
            this.frontBucket.Size = new System.Drawing.Size(109, 17);
            this.frontBucket.TabIndex = 8;
            this.frontBucket.Text = "Передний навес";
            this.frontBucket.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.labelSuperBulldozer);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.SimpleBulldozer);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(298, 152);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.Location = new System.Drawing.Point(124, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 91);
            this.panel1.TabIndex = 11;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.PanelCar_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.PanelCar_DragEnter);
            // 
            // pictureBoxBulldozer
            // 
            this.pictureBoxBulldozer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxBulldozer.Enabled = false;
            this.pictureBoxBulldozer.Location = new System.Drawing.Point(127, 35);
            this.pictureBoxBulldozer.Name = "pictureBoxBulldozer";
            this.pictureBoxBulldozer.Size = new System.Drawing.Size(147, 91);
            this.pictureBoxBulldozer.TabIndex = 10;
            this.pictureBoxBulldozer.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Цвета:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Location = new System.Drawing.Point(307, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(38, 39);
            this.panel2.TabIndex = 12;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBaseColor.Location = new System.Drawing.Point(307, 35);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(80, 39);
            this.labelBaseColor.TabIndex = 13;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragEnter);
            // 
            // labelСomplementaryСolor
            // 
            this.labelСomplementaryСolor.AllowDrop = true;
            this.labelСomplementaryСolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelСomplementaryСolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelСomplementaryСolor.Location = new System.Drawing.Point(444, 35);
            this.labelСomplementaryСolor.Name = "labelСomplementaryСolor";
            this.labelСomplementaryСolor.Size = new System.Drawing.Size(80, 39);
            this.labelСomplementaryСolor.TabIndex = 14;
            this.labelСomplementaryСolor.Text = "Доп.  цвет";
            this.labelСomplementaryСolor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelСomplementaryСolor.DragDrop += new System.Windows.Forms.DragEventHandler(this.LabelDopColor_DragDrop);
            this.labelСomplementaryСolor.DragEnter += new System.Windows.Forms.DragEventHandler(this.LabelBaseColor_DragEnter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lime;
            this.panel3.Location = new System.Drawing.Point(370, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(38, 39);
            this.panel3.TabIndex = 13;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(370, 145);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(38, 39);
            this.panel4.TabIndex = 15;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.Location = new System.Drawing.Point(307, 145);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(38, 39);
            this.panel5.TabIndex = 14;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Coral;
            this.panel6.Location = new System.Drawing.Point(502, 145);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(38, 39);
            this.panel6.TabIndex = 19;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Orange;
            this.panel7.Location = new System.Drawing.Point(439, 145);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(38, 39);
            this.panel7.TabIndex = 18;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Blue;
            this.panel8.Location = new System.Drawing.Point(502, 87);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(38, 39);
            this.panel8.TabIndex = 17;
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Red;
            this.panel9.Location = new System.Drawing.Point(439, 87);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(38, 39);
            this.panel9.TabIndex = 16;
            this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelColor_MouseDown);
            // 
            // buttonAddCarFromConfig
            // 
            this.buttonAddCarFromConfig.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonAddCarFromConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCarFromConfig.Location = new System.Drawing.Point(444, 207);
            this.buttonAddCarFromConfig.Name = "buttonAddCarFromConfig";
            this.buttonAddCarFromConfig.Size = new System.Drawing.Size(80, 29);
            this.buttonAddCarFromConfig.TabIndex = 20;
            this.buttonAddCarFromConfig.Text = "Добавить";
            this.buttonAddCarFromConfig.UseVisualStyleBackColor = true;
            this.buttonAddCarFromConfig.Click += new System.EventHandler(this.buttonAddCarFromConfig_Click);
            // 
            // buttonCloseConfig
            // 
            this.buttonCloseConfig.Cursor = System.Windows.Forms.Cursors.Default;
            this.buttonCloseConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseConfig.Location = new System.Drawing.Point(444, 250);
            this.buttonCloseConfig.Name = "buttonCloseConfig";
            this.buttonCloseConfig.Size = new System.Drawing.Size(80, 29);
            this.buttonCloseConfig.TabIndex = 21;
            this.buttonCloseConfig.Text = "Отмена";
            this.buttonCloseConfig.UseVisualStyleBackColor = true;
            this.buttonCloseConfig.Click += new System.EventHandler(this.buttonCloseConfig_Click);
            // 
            // FormBulldozerConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 294);
            this.Controls.Add(this.buttonCloseConfig);
            this.Controls.Add(this.buttonAddCarFromConfig);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelСomplementaryСolor);
            this.Controls.Add(this.labelBaseColor);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxBulldozer);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBulldozerConfig";
            this.Text = "FormClassConfig";
            ((System.ComponentModel.ISupportInitialize)(this.numeriсMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericWeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBulldozer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SimpleBulldozer;
        private System.Windows.Forms.Label labelSuperBulldozer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numeriсMaxSpeed;
        private System.Windows.Forms.NumericUpDown numericWeight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox flasher;
        private System.Windows.Forms.CheckBox sportLine;
        private System.Windows.Forms.CheckBox backBucket;
        private System.Windows.Forms.CheckBox frontBucket;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBoxBulldozer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Label labelСomplementaryСolor;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button buttonAddCarFromConfig;
        private System.Windows.Forms.Button buttonCloseConfig;
    }
}