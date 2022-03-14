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
            this.DelParking = new System.Windows.Forms.Button();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.labelParkings = new System.Windows.Forms.Label();
            this.AddParking = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
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
            this.pictureBoxParking.Size = new System.Drawing.Size(834, 472);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // ButtonSetBulldozer
            // 
            this.ButtonSetBulldozer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSetBulldozer.Location = new System.Drawing.Point(3, 267);
            this.ButtonSetBulldozer.Name = "ButtonSetBulldozer";
            this.ButtonSetBulldozer.Size = new System.Drawing.Size(120, 35);
            this.ButtonSetBulldozer.TabIndex = 1;
            this.ButtonSetBulldozer.Text = "Припарковать трактор";
            this.ButtonSetBulldozer.UseVisualStyleBackColor = true;
            this.ButtonSetBulldozer.Click += new System.EventHandler(this.ButtonSetBulldozer_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTextBox.Location = new System.Drawing.Point(71, 374);
            this.maskedTextBox.Mask = "00";
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(32, 20);
            this.maskedTextBox.TabIndex = 2;
            // 
            // ButtonSetSuperBulldozer
            // 
            this.ButtonSetSuperBulldozer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSetSuperBulldozer.Location = new System.Drawing.Point(3, 312);
            this.ButtonSetSuperBulldozer.Name = "ButtonSetSuperBulldozer";
            this.ButtonSetSuperBulldozer.Size = new System.Drawing.Size(120, 35);
            this.ButtonSetSuperBulldozer.TabIndex = 3;
            this.ButtonSetSuperBulldozer.Text = "Припарковать трактор с навесом";
            this.ButtonSetSuperBulldozer.UseVisualStyleBackColor = true;
            this.ButtonSetSuperBulldozer.Click += new System.EventHandler(this.ButtonSetSuperBulldozer_Click);
            // 
            // ButtonTakeBulldozer
            // 
            this.ButtonTakeBulldozer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTakeBulldozer.Location = new System.Drawing.Point(3, 399);
            this.ButtonTakeBulldozer.Name = "ButtonTakeBulldozer";
            this.ButtonTakeBulldozer.Size = new System.Drawing.Size(120, 25);
            this.ButtonTakeBulldozer.TabIndex = 4;
            this.ButtonTakeBulldozer.Text = "Забрать";
            this.ButtonTakeBulldozer.UseVisualStyleBackColor = true;
            this.ButtonTakeBulldozer.Click += new System.EventHandler(this.ButtonTakeBulldozer_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Забрать трактор";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DelParking);
            this.groupBox1.Controls.Add(this.listBoxParkings);
            this.groupBox1.Controls.Add(this.labelParkings);
            this.groupBox1.Controls.Add(this.AddParking);
            this.groupBox1.Controls.Add(this.textBoxNewLevelName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ButtonSetBulldozer);
            this.groupBox1.Controls.Add(this.ButtonTakeBulldozer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.ButtonSetSuperBulldozer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(704, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 472);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // DelParking
            // 
            this.DelParking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelParking.Location = new System.Drawing.Point(3, 192);
            this.DelParking.Name = "DelParking";
            this.DelParking.Size = new System.Drawing.Size(120, 25);
            this.DelParking.TabIndex = 11;
            this.DelParking.Text = "Удалить парковку";
            this.DelParking.UseVisualStyleBackColor = true;
            this.DelParking.Click += new System.EventHandler(this.DelParking_Click);
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.Location = new System.Drawing.Point(3, 91);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(120, 95);
            this.listBoxParkings.TabIndex = 10;
            this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // labelParkings
            // 
            this.labelParkings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelParkings.AutoSize = true;
            this.labelParkings.Location = new System.Drawing.Point(32, 8);
            this.labelParkings.Name = "labelParkings";
            this.labelParkings.Size = new System.Drawing.Size(60, 13);
            this.labelParkings.TabIndex = 9;
            this.labelParkings.Text = "Парковки:";
            // 
            // AddParking
            // 
            this.AddParking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddParking.Location = new System.Drawing.Point(3, 54);
            this.AddParking.Name = "AddParking";
            this.AddParking.Size = new System.Drawing.Size(120, 25);
            this.AddParking.TabIndex = 8;
            this.AddParking.Text = "Добавить парковку";
            this.AddParking.UseVisualStyleBackColor = true;
            this.AddParking.Click += new System.EventHandler(this.AddParking_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNewLevelName.Location = new System.Drawing.Point(3, 26);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(120, 20);
            this.textBoxNewLevelName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Место:";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 472);
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
        private System.Windows.Forms.Button DelParking;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Label labelParkings;
        private System.Windows.Forms.Button AddParking;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
    }
}