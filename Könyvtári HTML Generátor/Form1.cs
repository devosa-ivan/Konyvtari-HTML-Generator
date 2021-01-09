using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Könyvtári_HTML_Generátor
{

//  2018.09.09. + 2018.10.12.

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string fajlnev = String.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            toolStripStatusLabel_version.Text += ProductVersion;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            Excel.Range range;

            string str = string.Empty;
            int rCnt;
            int cCnt;
            int rw = 0;
            int cl = 0;
            string szoveg = String.Empty;

            xlApp = new Excel.Application();
            //@"d:\jegyzet_DB.xls"
            xlWorkBook = xlApp.Workbooks.Open(fajlnev, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            range = xlWorkSheet.UsedRange;
            rw = range.Rows.Count;
            cl = range.Columns.Count;

            richTextBox1.Clear();

            //kezdőszöveg
            szoveg += richTextBox_kezdoszoveg.Text;


            // kezdőszöveg vége
            //rCnt 2 ről indul, mert a fejléc sor nem dolgozzusk fel 
            for (rCnt = 2; rCnt <= rw; rCnt++)
            {
                for (cCnt = 1; cCnt <= cl; cCnt++)
                {
                    //str = (string)(range.Cells[rCnt, cCnt] as Excel.Range).Value2;
                    str = Convert.ToString((range.Cells[rCnt, cCnt] as Excel.Range).Value2);
                    //MessageBox.Show(str);
                    //ADATBÁZIS
                    string url = "https://sites.google.com/site/njekikdokumentumtar/";

                    if (cCnt == 1)
                    {
                        szoveg +=
                     "<hr> <br> " +
                    /*"<img border=\"0\" src=\"http://kik.kefo.hu/c/document_library/get_file?p_l_id=10132&folderId=306859&name=DLFE-4744.png\" width=\"130\" height=\"96\" align=\"right\">" +*/
                    "<p font size=\"10\" face=\"Arial\"" + Environment.NewLine +
                    "<br>Kódszám:    " + str + Environment.NewLine; };
                    if (cCnt == 2) { szoveg += "<br>ISBN:    " + str + Environment.NewLine; };
                    if (cCnt == 3) { szoveg += "<br>Szerzők, szerkesztők, összeállítók:    " + str + Environment.NewLine; };
                    if (cCnt == 4 && str=="igen") { szoveg += "<br>A fentiek szerkesztők.    "  + Environment.NewLine; };
                    if (cCnt == 5) { szoveg += "<br>Kiadás ideje: " + str + Environment.NewLine; };
                    if (cCnt == 6) { szoveg += "<br>Kötet címe:<b>    " + str + "</b>" + Environment.NewLine;};
                    if (cCnt == 7) { szoveg += "<br>Sorozat címe:<b>    " + str + "</b>" + Environment.NewLine; };                   
                    if (cCnt == 8) { szoveg += "<br>Kiadó: " + str + Environment.NewLine; };
                    if (cCnt == 9) { szoveg += "<br>Kiadás helye: " + str + Environment.NewLine; };
                    if (cCnt == 10) { szoveg += "<br>Leírás: " + str + Environment.NewLine; };
                    if (cCnt == 11){ szoveg += "<br>e-kiadvány ára:    " + str + Environment.NewLine; };
                    if (cCnt == 12){ szoveg += "<br>nyomtatott kiadvány ára:     " + str + Environment.NewLine; };
                    //if (cCnt == 13 && str!=string.Empty){ szoveg += "<br>Letöltési URL:  <a href=\"" + str + "\">IDE KATTINTVA </a> </p>" + Environment.NewLine+""; };
                    //"</body></html>"




                    //ADATBÁZIS VÉGE
                }
            }


            richTextBox1.AppendText(szoveg);
            button_webbongeszo.Enabled = true;
            button_vagolapra.Enabled = true;

            xlWorkBook.Close(true, null, null);
            xlApp.Quit();

            Marshal.ReleaseComObject(xlWorkSheet);
            Marshal.ReleaseComObject(xlWorkBook);
            Marshal.ReleaseComObject(xlApp);

        }

        private void button_1_adatbazis_betoltese_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            fajlnev = openFileDialog1.FileName;
            toolStripStatusLabel_fajlnev.Text = fajlnev;
            button_kodgeneralas.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel_ora.Text = DateTime.Now.ToLongTimeString();
        }

        private void button_webbongeszo_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(Path.Combine(Path.GetTempPath(), "tmp.htm"), RichTextBoxStreamType.PlainText);
            webBrowser1.Navigate(Path.Combine(Path.GetTempPath(), "tmp.htm"));
        }

        private void button_About_Click(object sender, EventArgs e)
        {
            AboutBox1 programrol = new AboutBox1();
            programrol.ShowDialog();
        }

        private void button_vagolapra_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Copy();
        }
    }
}
