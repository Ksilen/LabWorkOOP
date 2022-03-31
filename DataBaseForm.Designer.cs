namespace WindowsFormsBulldozer
{
    partial class DataBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseForm));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.toWord = new System.Windows.Forms.Button();
            this.toPDF = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteBD = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bulldozersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet1 = new WindowsFormsBulldozer.Database1DataSet1();
            this.parkingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bulldozersTableAdapter = new WindowsFormsBulldozer.Database1DataSet1TableAdapters.BulldozersTableAdapter();
            this.tableAdapterManager = new WindowsFormsBulldozer.Database1DataSet1TableAdapters.TableAdapterManager();
            this.parkingsTableAdapter = new WindowsFormsBulldozer.Database1DataSet1TableAdapters.ParkingsTableAdapter();
            this.eventsInProgramBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsInProgramBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.evBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.evTableAdapter = new WindowsFormsBulldozer.Database1DataSet1TableAdapters.EvTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bulldozersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsInProgramBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsInProgramBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.evBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Парковки:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вывести за период с:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "до:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(18, 227);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // toWord
            // 
            this.toWord.Location = new System.Drawing.Point(16, 290);
            this.toWord.Name = "toWord";
            this.toWord.Size = new System.Drawing.Size(123, 23);
            this.toWord.TabIndex = 6;
            this.toWord.Text = "Экспорт в Word";
            this.toWord.UseVisualStyleBackColor = true;
            this.toWord.Click += new System.EventHandler(this.toWord_Click);
            // 
            // toPDF
            // 
            this.toPDF.Location = new System.Drawing.Point(16, 319);
            this.toPDF.Name = "toPDF";
            this.toPDF.Size = new System.Drawing.Size(123, 23);
            this.toPDF.TabIndex = 7;
            this.toPDF.Text = "Экспорт в PDF";
            this.toPDF.UseVisualStyleBackColor = true;
            this.toPDF.Click += new System.EventHandler(this.toPDF_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.DeleteBD);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.toPDF);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.toWord);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(483, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 446);
            this.panel1.TabIndex = 8;
            // 
            // DeleteBD
            // 
            this.DeleteBD.Location = new System.Drawing.Point(16, 417);
            this.DeleteBD.Name = "DeleteBD";
            this.DeleteBD.Size = new System.Drawing.Size(121, 23);
            this.DeleteBD.TabIndex = 10;
            this.DeleteBD.Text = "Очистить БД";
            this.DeleteBD.UseVisualStyleBackColor = true;
            this.DeleteBD.Click += new System.EventHandler(this.DeleteBD_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(16, 262);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(123, 1);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(16, 156);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(123, 1);
            this.panel2.TabIndex = 8;
            // 
            // bulldozersBindingSource
            // 
            this.bulldozersBindingSource.DataMember = "Bulldozers";
            this.bulldozersBindingSource.DataSource = this.database1DataSet1;
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet1";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parkingsBindingSource
            // 
            this.parkingsBindingSource.DataMember = "Parkings";
            this.parkingsBindingSource.DataSource = this.database1DataSet1;
            // 
            // bulldozersTableAdapter
            // 
            this.bulldozersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BulldozersTableAdapter = this.bulldozersTableAdapter;
            this.tableAdapterManager.EvTableAdapter = null;
            this.tableAdapterManager.ParkingsTableAdapter = this.parkingsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsBulldozer.Database1DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // parkingsTableAdapter
            // 
            this.parkingsTableAdapter.ClearBeforeFill = true;
            // 
            // evBindingSource
            // 
            this.evBindingSource.DataMember = "Ev";
            this.evBindingSource.DataSource = this.database1DataSet1;
            // 
            // evTableAdapter
            // 
            this.evTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.richTextBox1);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 446);
            this.panel4.TabIndex = 111;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(483, 446);
            this.richTextBox1.TabIndex = 111;
            this.richTextBox1.Text = "";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Location = new System.Drawing.Point(5, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 436);
            this.panel5.TabIndex = 11;
            // 
            // DataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 446);
            this.Controls.Add(this.panel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataBaseForm";
            this.Text = "Добавленные и извлеченные объекты";
            this.Load += new System.EventHandler(this.DataBaseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bulldozersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parkingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsInProgramBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsInProgramBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.evBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button toWord;
        private System.Windows.Forms.Button toPDF;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Database1DataSet1 database1DataSet1;
        private System.Windows.Forms.BindingSource bulldozersBindingSource;
        private Database1DataSet1TableAdapters.BulldozersTableAdapter bulldozersTableAdapter;
        private Database1DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSet1TableAdapters.ParkingsTableAdapter parkingsTableAdapter;
        private System.Windows.Forms.BindingSource parkingsBindingSource;
        private System.Windows.Forms.Button DeleteBD;
        private System.Windows.Forms.BindingSource eventsInProgramBindingSource;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.BindingSource eventsInProgramBindingSource1;
        private System.Windows.Forms.BindingSource evBindingSource;
        private Database1DataSet1TableAdapters.EvTableAdapter evTableAdapter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel panel5;
    }
}