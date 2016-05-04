using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplication1
{
    public partial class MailingListGetter : Form
    {
        public MailingListGetter()
        {
            InitializeComponent();
        }

        private void datraBrowseButton_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                dataTextbox.Text = file;
            }
        }

        private void mailBrowseButton_Click(object sender, EventArgs e)
        {
            openFileDialog.FileName = "";
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog.FileName;
                mailTextbox.Text = file;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(dataTextbox.Text))
            {
                dataErrorProvider.SetError(dataTextbox, "Please enter a valid path");
            }
            else
            {
                dataErrorProvider.Clear();
            }
            if (String.IsNullOrWhiteSpace(mailTextbox.Text))
            {
                mailErrorProvider.SetError(mailTextbox, "Please enter a valid path");
            }
            else
            {
                mailErrorProvider.Clear();
            }
            if(!String.IsNullOrWhiteSpace(dataTextbox.Text) && !String.IsNullOrWhiteSpace(mailTextbox.Text))
            {
                ReadData(dataTextbox.Text, mailTextbox.Text);
            }
        }

        private void ReadData(string datafile, string mailinglistfile)
        {
            startButton.Enabled = false;
            startButton.Text = "Loading";

            Excel.Application excelFileObject = new Excel.Application();
            excelFileObject.Visible = false;
            Excel.Workbook dataWorkbook = excelFileObject.Workbooks.Open(datafile);
            Excel.Worksheet dataWorkSheet = dataWorkbook.ActiveSheet;

            Excel.Workbook mailWorkbook = excelFileObject.Workbooks.Open(mailinglistfile);
            Excel.Worksheet mailWorkSheet = mailWorkbook.ActiveSheet;
          
            int mailLastRow = mailWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing).Row + 1;
            int dataLastRow = dataWorkSheet.Cells.SpecialCells(Excel.XlCellType.xlCellTypeLastCell, Type.Missing).Row + 1;

            for (int i = 1; i < mailLastRow; i++) {

                Excel.Range tempR = (Excel.Range) mailWorkSheet.Cells[i, 1];
                string temp = tempR.Value.ToString();

                Excel.Range rng = GetSpecifiedRange(temp.ToString(), dataWorkSheet,dataLastRow);

                if (rng != null)
                {
                    //MessageBox.Show("Text found, position is Row:" + oRng.Row + " and column:" + oRng.Column);
                    mailWorkSheet.Cells[i, 4] = dataWorkSheet.Cells[rng.Row, 3];
                    mailWorkSheet.Cells[i, 5] = dataWorkSheet.Cells[rng.Row, 4];
                    mailWorkSheet.Cells[i, 6] = dataWorkSheet.Cells[rng.Row, 5];
                    mailWorkSheet.Cells[i, 7] = dataWorkSheet.Cells[rng.Row, 7];
                }

            }                 

            mailWorkbook.Save();
            //dataWorkbook.Save();

            mailWorkbook.Close();
            dataWorkbook.Close();

            excelFileObject.Workbooks.Close();
            excelFileObject.Quit();

            Marshal.FinalReleaseComObject(mailWorkSheet);
            Marshal.FinalReleaseComObject(dataWorkSheet);
            Marshal.FinalReleaseComObject(mailWorkbook);
            Marshal.FinalReleaseComObject(dataWorkbook);
            Marshal.FinalReleaseComObject(excelFileObject.Workbooks);
            Marshal.FinalReleaseComObject(excelFileObject);

            GC.Collect();

            startButton.Enabled = true;
            startButton.Text = "Start";

            MessageBox.Show("Script complete", "Finish", MessageBoxButtons.OK);
        }

        private static Excel.Range GetSpecifiedRange(string matchStr, Excel.Worksheet objWs, int count)
        {
            object missing = System.Reflection.Missing.Value;
            Excel.Range currentFind = null;
            Excel.Range r1 = objWs.Cells[1, 1];
            Excel.Range r2 = objWs.Cells[count, 1];
            currentFind = objWs.get_Range(r1,r2).Find(matchStr, missing,
                           Excel.XlFindLookIn.xlValues,
                           Excel.XlLookAt.xlPart,
                           Excel.XlSearchOrder.xlByRows,
                           Excel.XlSearchDirection.xlNext, false, missing, missing);
            return currentFind;
        }
    }
}
