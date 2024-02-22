using GemBox.Spreadsheet;
using GemBox.Spreadsheet.WinFormsUtilities;
using System.Diagnostics;
using System.Windows.Forms;

namespace W4Act_Gembox_Spreadsheet
{
    public partial class MainForm : Form
    {
        public string variable1;
        public MainForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
            string[] columnNames = { "Column 1", "Column 2", "Column 3", "C4", "C5" }; // Example column names

            foreach (string columnName in columnNames)
            {
                DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn();
                column.HeaderText = columnName; 
                dgvList.Columns.Add(column);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            openFileDialog.Filter =
            "XLS files(*.xls, *.xlt)|*.xls; *.xlt|" +
            "XLSX files(*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx; *.xlsm; *.xltx; *.xltm|" +
            "ODS files (*.ods, *.ots)|*.ods; *.ots|" +
            "CSV files (*.csv, *.tsv)|*.csv; *.tsv|" +
            "HTML files (*.html, *.htm)|*.html; *.htm";

            openFileDialog.FilterIndex = 2;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = ExcelFile.Load(openFileDialog.FileName);
                var worksheet = workbook.Worksheets.ActiveWorksheet;

                DataGridViewConverter.ExportToDataGridView(
                worksheet,
                this.dgvList,
                new ExportToDataGridViewOptions() { ColumnHeaders = true }
            );

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter =
                "XLS (*.xls)|*.xls|" +
                "XLT (*.xlt)|*.xlt|" +
                "XLSX (*.xlsx)|*.xlsx|" +
                "XLSM (*.xlsm)|*.xlsm|" +
                "XLTX (*.xltx)|*.xltx|" +
                "XLTM (*.xltm)|*.xltm|" +
                "ODS (*.ods)|*.ods|" +
                "OTS (*.ots)|*.ots|" +
                "CSV (*.csv)|*.csv|" +
                "TSV (*.tsv)|*.tsv|" +
                "HTML (*.html)|*.html|" +
                "MHTML (*.mhtml)|*.mhtml|" +
                "PDF (*.pdf)|*.pdf|" +
                "XPS (*.xps)|*.xps|" +
                "BMP (*.bmp)|*.bmp|" +
                "GIF (*.gif)|*.gif|" +
                "JPEG (*.jpg)|*.jpg|" +
                "PNG (*.png)|*.png|" +
                "TIFF (*.tif)|*.tif|" +
                "WMP (*.wdp)|*.wdp";

            saveFileDialog.FilterIndex = 3;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Sheet1");

                DataGridViewConverter.ImportFromDataGridView(
                    worksheet,
                    this.dgvList,
                    new ImportFromDataGridViewOptions() { ColumnHeaders = true }
                    );
                workbook.Save(saveFileDialog.FileName);
            }

        }

        private void btnAddInput_Click(object sender, EventArgs e)
        {
            DataInfoForm dataInfoForm = new DataInfoForm(this);
            dataInfoForm.FormClosed += DataInfoForm_FormClosed;
            dataInfoForm.Show();
            this.Enabled = false; 
        }

      
        private void DataInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
        }

        internal void AddRows(DataGridViewRow row)
        {
            dgvList.Rows.Add(row);
        }
    }
}
