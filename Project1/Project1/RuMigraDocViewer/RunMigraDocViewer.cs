#region PDFsharp - a viewer control to use MigraDoc DDL files
//
// Authors: Klaus Ruttkowski
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and associated documentation files (the "Software"),
// to deal in the Software without restriction, including without limitation
// the rights to use, copy, modify, merge, publish, distribute, sublicense,
// and/or sell copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
// THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
// DEALINGS IN THE SOFTWARE.
#endregion

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

// MigraDoc and PdfSharp
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using MigraDoc.RtfRendering;
using PdfSharp;
/*
  using RuFramework;
  
  private void button_Click(object sender, EventArgs e)
  {
     string filename = @"MyDDLFile.mdddl";
     
     RunMigraDocViewer viever = new RunMigraDocViewer(filename);
     // or
     RunMigraDocViewer viever = new RunMigraDocViewer();
     // or
     RunMigraDocViewer viever = new RunMigraDocViewer(filename, allowPrint: false);
     // or
     RunMigraDocViewer viever = new RunMigraDocViewer(filename, allowPrint: false);
     // or
     RunMigraDocViewer viever = new RunMigraDocViewer(filename,false,false,false,false);
 
     viever.WorkDirectory = @"D:\tmp";
     viever.Show();
  }
 */

namespace RuFramework
{
    /// <summary>
    /// Shows a MigraDoc DDL file, Save to PDF, RTF, BMP, JPEG, GIF and print
    /// 
    /// A MigraDoc DDL file is a text based serialization of a MigraDoc document.
    /// </summary>
    public partial class RunMigraDocViewer : Form
    {
        #region Init
        Document document = new Document();
        /// <summary>
        /// Init without filename
        /// </summary>
        /// <param name="allowSaveToPdf"></param>
        /// <param name="allowSaveToRtf"></param>
        /// <param name="allowSaveToPicture"></param>
        /// <param name="allowPrint"></param>
        public RunMigraDocViewer(bool allowSaveToPdf = true,
                                bool allowSaveToRtf = true,
                                bool allowSaveToPicture = true,
                                bool allowPrint = true)
        {
            InitializeComponent();

            // Set Menue default
            this.toolStripButtonMakePdf.Visible = allowSaveToPdf;
            this.toolStripButtonMakeRtf.Visible = allowSaveToRtf;
            this.toolStripSplitButtonPicture.Visible = allowSaveToPicture;
            this.toolStripButtonPrinting.Visible = allowPrint;

            UpdateStatusBar();
        }
        /// <summary>
        /// Init with filename
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="allowSaveToPdf"></param>
        /// <param name="allowSaveToRtf"></param>
        /// <param name="allowSaveToPicture"></param>
        /// <param name="allowPrint"></param>
        public RunMigraDocViewer(string filename,
                                bool allowSaveToPdf = true,
                                bool allowSaveToRtf = true,
                                bool allowSaveToPicture = true,
                                bool allowPrint = true)
        {
            InitializeComponent();

            // Open MigraDoc document
            document = MigraDoc.DocumentObjectModel.IO.DdlReader.DocumentFromFile(filename);
            string ddl = MigraDoc.DocumentObjectModel.IO.DdlWriter.WriteToString(document);
            this.pagePreview.Ddl = ddl;

            this.toolStripButtonOpen.Visible = false;
            this.toolStripSeparator1.Visible = false;

            // Set Menue default
            this.toolStripButtonMakePdf.Visible = allowSaveToPdf;
            this.toolStripButtonMakeRtf.Visible = allowSaveToRtf;
            this.toolStripSplitButtonPicture.Visible = allowSaveToPicture;
            this.toolStripButtonPrinting.Visible = allowPrint;
            UpdatePageInfo();
            UpdateStatusBar();
        }
        #endregion
        #region Update
        /// <summary>
        /// Update statusbar
        /// </summary>
        void UpdateStatusBar()
        {
            string status = String.Format("Format: {0} Size: {1}pt x {2}pt, Author: {3}, Title: {4}, TotalMemory: {5}",
              this.document.DefaultPageSetup.PageFormat,
              this.pagePreview.PageSize.Width, this.pagePreview.PageSize.Height,
              this.document.Info.Author,
              this.document.Info.Title,
              GC.GetTotalMemory(true));
            this.statusBar.Text = status;
            toolStripTextBoxProcent.Text = this.pagePreview.ZoomPercent.ToString() + " %";
        }
        /// <summary>
        /// Update pagenumber ans zoom procent
        /// </summary>
        void UpdatePageInfo()
        {
            this.toolStripTextBoxPageCount.Text = this.pagePreview.Page.ToString();
            this.toolStripLabelPage.Text = "/" + this.pagePreview.PageCount.ToString();
        }
        #endregion
        #region Print
        /// <summary>
        /// Prints the current document on a printer.
        /// </summary>
        private void Print()
        {
            // Reuse the renderer from the preview
            DocumentRenderer renderer = this.pagePreview.Renderer;
            if (renderer != null)
            {
                int pageCount = renderer.FormattedDocument.PageCount;

                // Creates a PrintDocument that simplyfies printing of MigraDoc documents
                MigraDoc.Rendering.Printing.MigraDocPrintDocument printDocument = new MigraDoc.Rendering.Printing.MigraDocPrintDocument();

                System.Drawing.Printing.PrinterSettings printerSettings = new System.Drawing.Printing.PrinterSettings();
                using (PrintDialog dialog = new PrintDialog())
                {
                    dialog.PrinterSettings = printerSettings;
                    dialog.AllowSelection = true;
                    dialog.AllowSomePages = true;
                    DialogResult result = dialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        printerSettings = dialog.PrinterSettings;
                        if (printerSettings.PrintRange == System.Drawing.Printing.PrintRange.Selection)
                            printDocument.SelectedPage = this.pagePreview.Page;

                        // Attach the current document renderer
                        printDocument.Renderer = renderer;
                        printDocument.PrinterSettings = printerSettings;

                        // Print the document
                        printDocument.Print();
                    }
                }
            }
        }
        #endregion
        #region Save
        /// <summary>
        /// Creates a PDF file from the current document.
        /// </summary>
        void MakePdf()
        {
            // Render Document
            PdfDocumentRenderer renderer = new PdfDocumentRenderer(true, PdfSharp.Pdf.PdfFontEmbedding.Always);
            renderer.Document = document;
            renderer.RenderDocument();

            // Save Document as PDF
            saveFileDialog.FileName = Path.GetFileNameWithoutExtension(document.DdlFile) + ".pdf";
            saveFileDialog.Title = "Save PDF";
            saveFileDialog.DefaultExt = "Pdf";
            saveFileDialog.InitialDirectory = WorkDirectory;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                WorkDirectory = Path.GetDirectoryName(filename);

                // Delete old document if exist
                if (File.Exists(filename)) File.Delete(filename);

                // Save
                renderer.PdfDocument.Save(filename);
                UpdateStatusBar();
                Process.Start(filename);
            }
        }
        /// <summary>
        /// Creates a RTF file from the current document.
        /// </summary>     
        private void MakeRtf()
        {
            RtfDocumentRenderer rtf = new RtfDocumentRenderer();

            // Save Document as Rtf
            saveFileDialog.FileName = Path.GetFileNameWithoutExtension(document.DdlFile) + ".rtf";
            saveFileDialog.Title = "Save RTF";
            saveFileDialog.DefaultExt = "Rtf";
            saveFileDialog.InitialDirectory = WorkDirectory;
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                WorkDirectory = Path.GetDirectoryName(filename);

                // Delete old document if exist
                if (File.Exists(filename)) File.Delete(filename);


                rtf.Render(this.pagePreview.Document, filename, null);
                Process.Start(filename);
            }
        }
        /// <summary>
        /// Creates a BMP, JPEG, PGN or GIF file from the current document.
        /// </summary>     
        private void MakePicture(string extension)
        {

            int page = this.pagePreview.Page;

            // Reuse the renderer from the preview
            DocumentRenderer renderer = this.pagePreview.Renderer;
            PageInfo info = renderer.FormattedDocument.GetPageInfo(page);

            // Create an image
            int dpi = 150;
            int dx, dy;
            if (info.Orientation == PdfSharp.PageOrientation.Portrait)
            {
                dx = (int)(info.Width.Inch * dpi);
                dy = (int)(info.Height.Inch * dpi);
            }
            else
            {
                dx = (int)(info.Height.Inch * dpi);
                dy = (int)(info.Width.Inch * dpi);
            }

            Image image = new Bitmap(dx, dy, System.Drawing.Imaging.PixelFormat.Format32bppRgb);

            // Create a Graphics object for the image and scale it for drawing with 72 dpi
            Graphics graphics = Graphics.FromImage(image);
            graphics.Clear(System.Drawing.Color.White);
            float scale = dpi / 72f;
            graphics.ScaleTransform(scale, scale);

            // Create an XGraphics object and render the page
            PdfSharp.Drawing.XGraphics gfx = PdfSharp.Drawing.XGraphics.FromGraphics(graphics, new PdfSharp.Drawing.XSize(info.Width.Point, info.Height.Point));
            renderer.RenderPage(gfx, page);
            gfx.Dispose();

            // Save Document as Bmp
            saveFileDialog.FileName = Path.GetFileNameWithoutExtension(document.DdlFile) + "." + extension;
            saveFileDialog.Title = "Save Picture";
            saveFileDialog.DefaultExt = extension;
            saveFileDialog.InitialDirectory = WorkDirectory;

            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filename = saveFileDialog.FileName;
                WorkDirectory = Path.GetDirectoryName(filename);

                // Delete old document if exist
                if (File.Exists(filename)) File.Delete(filename);

                switch (extension)
                {
                    case "BMP":
                        image.Save(filename, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "JPEG":
                        image.Save(filename, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "PNG":
                        image.Save(filename, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case "GIF":
                        image.Save(filename, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    default:
                        return;
                }

                // Start MSPaint
                ProcessStartInfo startInfo = new ProcessStartInfo("mspaint.exe");
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                startInfo.Arguments = "\"" + filename + "\"";
                Process.Start(startInfo);
            }
        }
        #endregion
        #region Click
        /// <summary>
        /// Opens and shows a MigraDoc DDL file.
        /// 
        /// A MigraDoc DDL file is a text based serialization of a MigraDoc document.
        /// </summary>
        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = null;
            try
            {
                dialog = new OpenFileDialog();
                dialog.CheckFileExists = true;
                dialog.CheckPathExists = true;
                dialog.Filter = "MigraDoc DDL (*.mdddl)|*.mdddl|All Files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.InitialDirectory = WorkDirectory;
                dialog.Title = "Open MigraDoc DDL file";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    document = MigraDoc.DocumentObjectModel.IO.DdlReader.DocumentFromFile(dialog.FileName);
                    string ddl = MigraDoc.DocumentObjectModel.IO.DdlWriter.WriteToString(document);
                    this.pagePreview.Ddl = ddl;
                    WorkDirectory = Path.GetDirectoryName(dialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text);
                this.pagePreview.Ddl = null; // TODO has no effect
            }
            finally
            {
                if (dialog != null)
                    dialog.Dispose();
            }
            UpdatePageInfo();
            UpdateStatusBar();
        }
        /// <summary>
        /// Click toolStrip for various functions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            {
                object tag = e.ClickedItem.Tag;
                if (tag != null)
                {
                    switch (tag.ToString())
                    {
                        case "OriginalSize":
                            this.pagePreview.Zoom = (MigraDoc.Rendering.Forms.Zoom)PdfSharp.Forms.Zoom.OriginalSize;
                            break;

                        case "FullPage":
                            this.pagePreview.Zoom = (MigraDoc.Rendering.Forms.Zoom)PdfSharp.Forms.Zoom.FullPage;
                            break;

                        case "BestFit":
                            this.pagePreview.Zoom = (MigraDoc.Rendering.Forms.Zoom)PdfSharp.Forms.Zoom.BestFit;
                            break;

                        case "Smaller":
                            this.pagePreview.ZoomPercent = GetNewZoom((int)this.pagePreview.ZoomPercent, false);
                            break;

                        case "Larger":
                            this.pagePreview.ZoomPercent = GetNewZoom((int)this.pagePreview.ZoomPercent, true);
                            break;

                        case "MakePdf":
                            MakePdf();
                            break;

                        case "MakeRtf":
                            MakeRtf();
                            break;

                        case "Printing":
                            Print();
                            break;
                    }
                    UpdateStatusBar();
                }

            }
        }
        /// <summary>
        /// Save as BMP
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemBmp_Click(object sender, EventArgs e)
        {
            MakePicture("BMP");
        }
        /// <summary>
        /// Save as PNG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemPng_Click(object sender, EventArgs e)
        {
            MakePicture("PNG");
        }
        /// <summary>
        /// Save as JEPG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemJepg_Click(object sender, EventArgs e)
        {
            MakePicture("JPEG");
        }
        /// <summary>
        /// Save as GIF
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripMenuItemGif_Click(object sender, EventArgs e)
        {
            MakePicture("GIF");
        }
        /// <summary>
        /// Goto first page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonFirstPage_Click(object sender, EventArgs e)
        {
            this.pagePreview.FirstPage();
            UpdatePageInfo();
        }
        /// <summary>
        /// Goto previous page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonPrevPage_Click(object sender, EventArgs e)
        {
            this.pagePreview.PrevPage();
            UpdatePageInfo();

        }
        /// <summary>
        /// Goto next page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonNextPage_Click(object sender, EventArgs e)
        {
            this.pagePreview.NextPage();
            UpdatePageInfo();

        }
        /// <summary>
        /// Goto last page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButtonLastPage_Click(object sender, EventArgs e)
        {
            this.pagePreview.LastPage();
            UpdatePageInfo();

        }
        #endregion
        #region Zoom
        /// <summary>
        /// Get zoom
        /// </summary>
        /// <param name="currentZoom"></param>
        /// <param name="larger"></param>
        /// <returns></returns>
        int GetNewZoom(int currentZoom, bool larger)
        {
            int[] values = new int[]
            {
                10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 120, 140, 160, 180, 200, 
                250, 300, 350, 400, 450, 500, 600, 700, 800
            };

            if (currentZoom <= (int)PdfSharp.Forms.Zoom.Mininum && !larger)
                return (int)PdfSharp.Forms.Zoom.Mininum;
            else if (currentZoom >= (int)PdfSharp.Forms.Zoom.Maximum && larger)
                return (int)PdfSharp.Forms.Zoom.Maximum;

            if (larger)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    if (currentZoom < values[i])
                        return values[i];
                }
            }
            else
            {
                for (int i = values.Length - 1; i >= 0; i--)
                {
                    if (currentZoom > values[i])
                        return values[i];
                }
            }
            return (int)PdfSharp.Forms.Zoom.Percent100;
        }
        /// <summary>
        /// Set Set various zooms
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void toolStripMenuItem800_Click(object sender, EventArgs e)
        {
            this.pagePreview.Zoom = (MigraDoc.Rendering.Forms.Zoom)PdfSharp.Forms.Zoom.Percent800;
            UpdateStatusBar();
        }
        private void toolStripMenuItem600_Click(object sender, EventArgs e)
        {
            this.pagePreview.Zoom = (MigraDoc.Rendering.Forms.Zoom)PdfSharp.Forms.Zoom.Percent600;
            UpdateStatusBar();
        }
        private void toolStripMenuItem400_Click(object sender, EventArgs e)
        {
            this.pagePreview.Zoom = (MigraDoc.Rendering.Forms.Zoom)PdfSharp.Forms.Zoom.Percent400;
            UpdateStatusBar();
        }
        private void toolStripMenuItem200_Click(object sender, EventArgs e)
        {
            this.pagePreview.Zoom = (MigraDoc.Rendering.Forms.Zoom)PdfSharp.Forms.Zoom.Percent200;
            UpdateStatusBar();
        }
        private void toolStripMenuItem150_Click(object sender, EventArgs e)
        {
            this.pagePreview.Zoom = (MigraDoc.Rendering.Forms.Zoom)PdfSharp.Forms.Zoom.Percent150;
            UpdateStatusBar();
        }
        private void toolStripMenuItem100_Click(object sender, EventArgs e)
        {
            this.pagePreview.Zoom = (MigraDoc.Rendering.Forms.Zoom)PdfSharp.Forms.Zoom.Percent100;
            UpdateStatusBar();
        }
        private void toolStripMenuItem75_Click(object sender, EventArgs e)
        {
            this.pagePreview.Zoom = (MigraDoc.Rendering.Forms.Zoom)PdfSharp.Forms.Zoom.Percent75;
            UpdateStatusBar();
        }
        private void toolStripMenuItem50_Click(object sender, EventArgs e)
        {
            this.pagePreview.Zoom = (MigraDoc.Rendering.Forms.Zoom)PdfSharp.Forms.Zoom.Percent50;
            UpdateStatusBar();
        }
        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            this.pagePreview.Zoom = (MigraDoc.Rendering.Forms.Zoom)PdfSharp.Forms.Zoom.Percent25;
            UpdateStatusBar();
        }
        private void toolStripMenuItem10_Click_1(object sender, EventArgs e)
        {
            this.pagePreview.Zoom = (MigraDoc.Rendering.Forms.Zoom)PdfSharp.Forms.Zoom.Percent10;
            UpdateStatusBar();
        }
        private void ToolStripMenuItemBestFit_Click(object sender, EventArgs e)
        {
            this.pagePreview.Zoom = (MigraDoc.Rendering.Forms.Zoom)PdfSharp.Forms.Zoom.BestFit;
            UpdateStatusBar();
        }

        private void ToolStripMenuItemFullPage_Click(object sender, EventArgs e)
        {
            this.pagePreview.Zoom = (MigraDoc.Rendering.Forms.Zoom)PdfSharp.Forms.Zoom.FullPage;
            UpdateStatusBar();
        }
        #endregion
        #region Property
        /// <summary>
        /// Working directory
        /// </summary>
        public string WorkDirectory { get; set; }
        #endregion
    }
}
