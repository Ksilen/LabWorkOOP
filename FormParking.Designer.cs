namespace WindowsFormsBulldozer
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.ButtonSetBulldozer = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ButtonSetSuperBulldozer = new System.Windows.Forms.Button();
            this.ButtonTakeBulldozer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(811, 348);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // ButtonSetBulldozer
            // 
            this.ButtonSetBulldozer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSetBulldozer.Location = new System.Drawing.Point(6, 19);
            this.ButtonSetBulldozer.Name = "ButtonSetBulldozer";
            this.ButtonSetBulldozer.Size = new System.Drawing.Size(100, 39);
            this.ButtonSetBulldozer.TabIndex = 1;
            this.ButtonSetBulldozer.Text = "Припарковать трактор";
            this.ButtonSetBulldozer.UseVisualStyleBackColor = true;
            this.ButtonSetBulldozer.Click += new System.EventHandler(this.ButtonSetBulldozer_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox.Location = new System.Drawing.Point(68, 148);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(32, 20);
            this.maskedTextBox.TabIndex = 2;
            // 
            // ButtonSetSuperBulldozer
            // 
            this.ButtonSetSuperBulldozer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSetSuperBulldozer.Location = new System.Drawing.Point(6, 64);
            this.ButtonSetSuperBulldozer.Name = "ButtonSetSuperBulldozer";
            this.ButtonSetSuperBulldozer.Size = new System.Drawing.Size(100, 48);
            this.ButtonSetSuperBulldozer.TabIndex = 3;
            this.ButtonSetSuperBulldozer.Text = "Припарковать трактор с навесом";
            this.ButtonSetSuperBulldozer.UseVisualStyleBackColor = true;
            this.ButtonSetSuperBulldozer.Click += new System.EventHandler(this.ButtonSetSuperBulldozer_Click);
            // 
            // ButtonTakeBulldozer
            // 
            this.ButtonTakeBulldozer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTakeBulldozer.Location = new System.Drawing.Point(6, 206);
            this.ButtonTakeBulldozer.Name = "ButtonTakeBulldozer";
            this.ButtonTakeBulldozer.Size = new System.Drawing.Size(100, 30);
            this.ButtonTakeBulldozer.TabIndex = 4;
            this.ButtonTakeBulldozer.Text = "Забрать";
            this.ButtonTakeBulldozer.UseVisualStyleBackColor = true;
            this.ButtonTakeBulldozer.Click += new System.EventHandler(this.ButtonTakeBulldozer_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Забрать трактор";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ButtonSetBulldozer);
            this.groupBox1.Controls.Add(this.ButtonTakeBulldozer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.ButtonSetSuperBulldozer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(693, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 348);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Место:";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 348);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Стоянка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button ButtonSetBulldozer;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Button ButtonSetSuperBulldozer;
        private System.Windows.Forms.Button ButtonTakeBulldozer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}