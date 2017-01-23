using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using System.IO;

namespace PdfStamp
{
    public partial class PdfTest : Form
    {
        public PdfTest()
        {
            InitializeComponent();
        }

        private void bShowGrade_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\src\Visual Studio 2015\Projects\GitTest\PdfStamp\files\betygA.pdf";
            System.Diagnostics.Process.Start(filePath);

            /*Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            process.StartInfo = startInfo;
            startInfo.FileName = @"C:\src\Visual Studio 2015\Projects\GitTest\PdfStamp\files\betyg.pdf";
            process.Start();*/
        }

        private void bShowStamp_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\src\Visual Studio 2015\Projects\GitTest\PdfStamp\files\stampel.pdf";
            System.Diagnostics.Process.Start(filePath);
        }

        private void bCreateAndShow_Click(object sender, EventArgs e)
        {
            String gradePath = @"C:\src\Visual Studio 2015\Projects\GitTest\PdfStamp\files\betygA.pdf";
            String stampPath = @"C:\src\Visual Studio 2015\Projects\GitTest\PdfStamp\files\stampel.pdf";
            //TODO: Valbar eller ta bort
            String stampedGradePath = @"C:\temp\stampedGrade.pdf";

            StampPdf(gradePath, stampPath, stampedGradePath);

            //Visa
            System.Diagnostics.Process.Start(stampedGradePath);
        }

        private void StampPdf(String iPdfPath, String iStampPath, String iStampedPdfPath)
        {
            PdfReader pdfReader = new PdfReader(iPdfPath);
            PdfReader stampReader = new PdfReader(iStampPath);

            FileStream stampedFile = new FileStream(iStampedPdfPath, FileMode.Create);
            PdfStamper PDFStamper = new PdfStamper(pdfReader, stampedFile);

            // Stamp every page
            PdfImportedPage page = PDFStamper.GetImportedPage(stampReader, 1);
            int n = pdfReader.NumberOfPages;
            PdfContentByte stampInfo;
            for (int i = 1; i <= n; i++)
            {
                stampInfo = PDFStamper.GetOverContent(i);
                stampInfo.AddTemplate(page, 100, 100);
            }
            // Close the stamper
            PDFStamper.Close();

        }
    }
}
