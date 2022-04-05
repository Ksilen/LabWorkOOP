using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace WindowsFormsBulldozer
{
    public partial class DataBaseForm : Form
    {
        public static DataBase dateBase;
        MyDelegate d;
        public DataBaseForm(MyDelegate sender)
        {
            InitializeComponent();
            d = sender;
            StartPosition = FormStartPosition.CenterParent;
            dateBase = new DataBase();
            if (!dateBase.IsOpen())
                dateBase.OpenConnection();
            setComboBox();
            upadateTextBox();
        }
        private void setComboBox()
        {
            List<string> ParkingsName = dateBase.ListParkingsName();
            for (int i = 0; i < ParkingsName.Count(); ++i)
                comboBox1.Items.Add(ParkingsName[i]);
            if (ParkingsName.Count() > 0)
                comboBox1.SelectedIndex = 0;
        }
        private void bulldozersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bulldozersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet1);
        }

        private void DataBaseForm_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'database1DataSet1.Parkings' table. You can move, or remove it, as needed.
            this.parkingsTableAdapter.Fill(this.database1DataSet1.Parkings);
            // TODO: This line of code loads data into the 'database1DataSet1.Bulldozers' table. You can move, or remove it, as needed.
            this.bulldozersTableAdapter.Fill(this.database1DataSet1.Bulldozers);
            // TODO: This line of code loads data into the 'database1DataSet1.Ev' table. You can move, or remove it, as needed.
            try
            {
                this.evTableAdapter.Fill(this.database1DataSet1.Ev);
            }
            catch (DataException) { }
        }

        //Очистить БД
        private void DeleteBD_Click(object sender, EventArgs e)
        {
            dateBase.DeleteAllFromBD();
            d();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            upadateTextBox();
        }
        private void upadateTextBox()
        {
            string ComboBoxSelectedParking = comboBox1.SelectedItem.ToString();
            DateTime OnDate = dateTimePicker1.Value;
            DateTime ToDate = dateTimePicker2.Value;
            string textForReport = dateBase.textReport(ComboBoxSelectedParking, OnDate, ToDate);
            richTextBox1.Clear();
            richTextBox1.AppendText(textForReport);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            upadateTextBox();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            upadateTextBox();
        }
        //Сохранить в Word
        private void toWord_Click(object sender, EventArgs e)
        {
            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog.Filter = "doc|*.doc";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((saveFileDialog.FileName.Count() > 0))
                {
                    string textReport = string.Format("Отчёт по парковке {0}\n", comboBox1.SelectedItem.ToString());
                    RichTextBox WordReport = new RichTextBox();
                    WordReport.Font = new System.Drawing.Font("Times New Roman", 14);
                    WordReport.SelectionAlignment = HorizontalAlignment.Center;
                    WordReport.AppendText(textReport);
                    string textDate = string.Format("за период {0} - {1}\n\n", dateTimePicker1.Value.Date.ToShortDateString(),
                        dateTimePicker2.Value.Date.ToShortDateString());
                    WordReport.AppendText(textDate);
                    WordReport.SelectionAlignment = HorizontalAlignment.Left;
                    if (richTextBox1.Text != "")
                        WordReport.AppendText(richTextBox1.Text);
                    else
                        WordReport.AppendText("Нет данных");
                    WordReport.SaveFile(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно",
                    "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        //Сохранить в PDF
        private void toPDF_Click(object sender, EventArgs e)
        {
            saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            saveFileDialog.Filter = "pdf|*.pdf";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((saveFileDialog.FileName.Count() > 0))
                {
                    var document = new Document(PageSize.A4, 20, 20, 30, 20);
                    string ttf = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIAL.TTF");
                    var baseFont = BaseFont.CreateFont(ttf, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    var font = new iTextSharp.text.Font(baseFont, iTextSharp.text.Font.DEFAULTSIZE, iTextSharp.text.Font.NORMAL);
                    var writer = PdfWriter.GetInstance(document, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    document.Open();
                    document.NewPage();
                    string textReport = string.Format("Отчёт по парковке {0}\n", comboBox1.SelectedItem.ToString());
                    Paragraph index = new Paragraph(textReport, font);
                    index.Alignment = 1;
                    document.Add(index);
                    string textDate = string.Format("за период {0} - {1}\n\n", dateTimePicker1.Value.Date.ToShortDateString(), dateTimePicker2.Value.Date.ToShortDateString());
                    Paragraph index2 = new Paragraph(textDate, font);
                    index2.Alignment = 1;
                    document.Add(index2);
                    if (richTextBox1.Text == "")
                        document.Add(new Paragraph("Нет данных", font));
                    else
                        document.Add(new Paragraph(richTextBox1.Text, font));
                    PdfContentByte cb = writer.DirectContent;
                    cb.Rectangle(10f, 10f, document.PageSize.Width - 20f, document.PageSize.Height - 20f);
                    cb.Stroke();
                    document.Close();
                    writer.Close();
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
