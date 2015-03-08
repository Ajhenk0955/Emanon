namespace RuFramework
{
    partial class RunMigraDocViewer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RunMigraDocViewer));
            this.migraDocPrintDocument = new MigraDoc.Rendering.Printing.MigraDocPrintDocument();
            this.pagePreview = new MigraDoc.Rendering.Forms.DocumentPreview();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusBar = new System.Windows.Forms.StatusBar();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButtonZoom = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripMenuItem800 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem600 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem400 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem200 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem150 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem100 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem75 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem50 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemBestFit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemFullPage = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButtonFirstPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonPrevPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonNextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLastPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxPageCount = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabelPage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonOriginalSize = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFullsize = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBestFit = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSmaller = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLarger = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBoxProcent = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonMakePdf = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonMakeRtf = new System.Windows.Forms.ToolStripButton();
            this.toolStripSplitButtonPicture = new System.Windows.Forms.ToolStripSplitButton();
            this.ToolStripMenuItemBmp = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemPng = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemJepg = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemGif = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonPrinting = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // migraDocPrintDocument
            // 
            this.migraDocPrintDocument.Renderer = null;
            this.migraDocPrintDocument.SelectedPage = 0;
            // 
            // pagePreview
            // 
            this.pagePreview.Ddl = null;
            this.pagePreview.DesktopColor = System.Drawing.SystemColors.ControlDark;
            this.pagePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagePreview.Document = null;
            this.pagePreview.Location = new System.Drawing.Point(0, 24);
            this.pagePreview.Name = "pagePreview";
            this.pagePreview.Page = 0;
            this.pagePreview.PageColor = System.Drawing.Color.GhostWhite;
            this.pagePreview.PageSize = new System.Drawing.Size(595, 842);
            this.pagePreview.PrivateFonts = null;
            this.pagePreview.Size = new System.Drawing.Size(667, 485);
            this.pagePreview.TabIndex = 0;
            this.pagePreview.ZoomPercent = 40;
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(667, 24);
            this.menuStrip.TabIndex = 3;
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 489);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(667, 20);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusBar";
            // 
            // toolStrip
            // 
            this.toolStrip.AllowDrop = true;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripSeparator1,
            this.toolStripSplitButtonZoom,
            this.toolStripButtonFirstPage,
            this.toolStripButtonPrevPage,
            this.toolStripButtonNextPage,
            this.toolStripButtonLastPage,
            this.toolStripTextBoxPageCount,
            this.toolStripLabelPage,
            this.toolStripSeparator2,
            this.toolStripButtonOriginalSize,
            this.toolStripButtonFullsize,
            this.toolStripButtonBestFit,
            this.toolStripButtonSmaller,
            this.toolStripButtonLarger,
            this.toolStripTextBoxProcent,
            this.toolStripSeparator3,
            this.toolStripButtonMakePdf,
            this.toolStripButtonMakeRtf,
            this.toolStripSplitButtonPicture,
            this.toolStripSeparator4,
            this.toolStripButtonPrinting});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(667, 25);
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOpen.Text = "Open MigraDoc DDL";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButtonZoom
            // 
            this.toolStripSplitButtonZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem800,
            this.toolStripMenuItem600,
            this.toolStripMenuItem400,
            this.toolStripMenuItem200,
            this.toolStripMenuItem150,
            this.toolStripMenuItem100,
            this.toolStripMenuItem75,
            this.toolStripMenuItem50,
            this.toolStripMenuItem25,
            this.toolStripMenuItem10,
            this.ToolStripMenuItemBestFit,
            this.ToolStripMenuItemFullPage});
            this.toolStripSplitButtonZoom.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonZoom.Image")));
            this.toolStripSplitButtonZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonZoom.Name = "toolStripSplitButtonZoom";
            this.toolStripSplitButtonZoom.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButtonZoom.Text = "Document size";
            // 
            // toolStripMenuItem800
            // 
            this.toolStripMenuItem800.Name = "toolStripMenuItem800";
            this.toolStripMenuItem800.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem800.Text = "800 %";
            this.toolStripMenuItem800.Click += new System.EventHandler(this.toolStripMenuItem800_Click);
            // 
            // toolStripMenuItem600
            // 
            this.toolStripMenuItem600.Name = "toolStripMenuItem600";
            this.toolStripMenuItem600.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem600.Text = "600 %";
            this.toolStripMenuItem600.Click += new System.EventHandler(this.toolStripMenuItem600_Click);
            // 
            // toolStripMenuItem400
            // 
            this.toolStripMenuItem400.Name = "toolStripMenuItem400";
            this.toolStripMenuItem400.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem400.Text = "400 %";
            this.toolStripMenuItem400.Click += new System.EventHandler(this.toolStripMenuItem400_Click);
            // 
            // toolStripMenuItem200
            // 
            this.toolStripMenuItem200.Name = "toolStripMenuItem200";
            this.toolStripMenuItem200.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem200.Text = "200 %";
            this.toolStripMenuItem200.Click += new System.EventHandler(this.toolStripMenuItem200_Click);
            // 
            // toolStripMenuItem150
            // 
            this.toolStripMenuItem150.Name = "toolStripMenuItem150";
            this.toolStripMenuItem150.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem150.Text = "150 %";
            this.toolStripMenuItem150.Click += new System.EventHandler(this.toolStripMenuItem150_Click);
            // 
            // toolStripMenuItem100
            // 
            this.toolStripMenuItem100.Name = "toolStripMenuItem100";
            this.toolStripMenuItem100.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem100.Text = "100 %";
            this.toolStripMenuItem100.Click += new System.EventHandler(this.toolStripMenuItem100_Click);
            // 
            // toolStripMenuItem75
            // 
            this.toolStripMenuItem75.Name = "toolStripMenuItem75";
            this.toolStripMenuItem75.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem75.Text = "75 %";
            this.toolStripMenuItem75.Click += new System.EventHandler(this.toolStripMenuItem75_Click);
            // 
            // toolStripMenuItem50
            // 
            this.toolStripMenuItem50.Name = "toolStripMenuItem50";
            this.toolStripMenuItem50.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem50.Text = "50 %";
            this.toolStripMenuItem50.Click += new System.EventHandler(this.toolStripMenuItem50_Click);
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem25.Text = "25 %";
            this.toolStripMenuItem25.Click += new System.EventHandler(this.toolStripMenuItem25_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(122, 22);
            this.toolStripMenuItem10.Text = "10 %";
            this.toolStripMenuItem10.Click += new System.EventHandler(this.toolStripMenuItem10_Click_1);
            // 
            // ToolStripMenuItemBestFit
            // 
            this.ToolStripMenuItemBestFit.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemBestFit.Image")));
            this.ToolStripMenuItemBestFit.Name = "ToolStripMenuItemBestFit";
            this.ToolStripMenuItemBestFit.Size = new System.Drawing.Size(122, 22);
            this.ToolStripMenuItemBestFit.Text = "Best fit";
            this.ToolStripMenuItemBestFit.Click += new System.EventHandler(this.ToolStripMenuItemBestFit_Click);
            // 
            // ToolStripMenuItemFullPage
            // 
            this.ToolStripMenuItemFullPage.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemFullPage.Image")));
            this.ToolStripMenuItemFullPage.Name = "ToolStripMenuItemFullPage";
            this.ToolStripMenuItemFullPage.Size = new System.Drawing.Size(122, 22);
            this.ToolStripMenuItemFullPage.Text = "Full Page";
            this.ToolStripMenuItemFullPage.Click += new System.EventHandler(this.ToolStripMenuItemFullPage_Click);
            // 
            // toolStripButtonFirstPage
            // 
            this.toolStripButtonFirstPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFirstPage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFirstPage.Image")));
            this.toolStripButtonFirstPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFirstPage.Name = "toolStripButtonFirstPage";
            this.toolStripButtonFirstPage.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFirstPage.Text = "First page";
            this.toolStripButtonFirstPage.Click += new System.EventHandler(this.toolStripButtonFirstPage_Click);
            // 
            // toolStripButtonPrevPage
            // 
            this.toolStripButtonPrevPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrevPage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrevPage.Image")));
            this.toolStripButtonPrevPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrevPage.Name = "toolStripButtonPrevPage";
            this.toolStripButtonPrevPage.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrevPage.Text = "Previous page";
            this.toolStripButtonPrevPage.Click += new System.EventHandler(this.toolStripButtonPrevPage_Click);
            // 
            // toolStripButtonNextPage
            // 
            this.toolStripButtonNextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonNextPage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNextPage.Image")));
            this.toolStripButtonNextPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNextPage.Name = "toolStripButtonNextPage";
            this.toolStripButtonNextPage.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonNextPage.Text = "Next page";
            this.toolStripButtonNextPage.Click += new System.EventHandler(this.toolStripButtonNextPage_Click);
            // 
            // toolStripButtonLastPage
            // 
            this.toolStripButtonLastPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLastPage.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLastPage.Image")));
            this.toolStripButtonLastPage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLastPage.Name = "toolStripButtonLastPage";
            this.toolStripButtonLastPage.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLastPage.Text = "Last page";
            this.toolStripButtonLastPage.Click += new System.EventHandler(this.toolStripButtonLastPage_Click);
            // 
            // toolStripTextBoxPageCount
            // 
            this.toolStripTextBoxPageCount.Name = "toolStripTextBoxPageCount";
            this.toolStripTextBoxPageCount.Size = new System.Drawing.Size(25, 25);
            this.toolStripTextBoxPageCount.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStripLabelPage
            // 
            this.toolStripLabelPage.Name = "toolStripLabelPage";
            this.toolStripLabelPage.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabelPage.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonOriginalSize
            // 
            this.toolStripButtonOriginalSize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonOriginalSize.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOriginalSize.Image")));
            this.toolStripButtonOriginalSize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOriginalSize.Name = "toolStripButtonOriginalSize";
            this.toolStripButtonOriginalSize.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonOriginalSize.Tag = "OriginalSize";
            this.toolStripButtonOriginalSize.Text = "Original size";
            // 
            // toolStripButtonFullsize
            // 
            this.toolStripButtonFullsize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFullsize.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFullsize.Image")));
            this.toolStripButtonFullsize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFullsize.Name = "toolStripButtonFullsize";
            this.toolStripButtonFullsize.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonFullsize.Tag = "FullPage";
            this.toolStripButtonFullsize.Text = "Full page";
            // 
            // toolStripButtonBestFit
            // 
            this.toolStripButtonBestFit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBestFit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBestFit.Image")));
            this.toolStripButtonBestFit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBestFit.Name = "toolStripButtonBestFit";
            this.toolStripButtonBestFit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBestFit.Tag = "BestFit";
            this.toolStripButtonBestFit.Text = "Best fit";
            // 
            // toolStripButtonSmaller
            // 
            this.toolStripButtonSmaller.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSmaller.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSmaller.Image")));
            this.toolStripButtonSmaller.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSmaller.Name = "toolStripButtonSmaller";
            this.toolStripButtonSmaller.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSmaller.Tag = "Smaller";
            this.toolStripButtonSmaller.Text = "Smaller";
            // 
            // toolStripButtonLarger
            // 
            this.toolStripButtonLarger.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonLarger.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonLarger.Image")));
            this.toolStripButtonLarger.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLarger.Name = "toolStripButtonLarger";
            this.toolStripButtonLarger.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonLarger.Tag = "Larger";
            this.toolStripButtonLarger.Text = "Larger";
            // 
            // toolStripTextBoxProcent
            // 
            this.toolStripTextBoxProcent.Name = "toolStripTextBoxProcent";
            this.toolStripTextBoxProcent.Size = new System.Drawing.Size(30, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonMakePdf
            // 
            this.toolStripButtonMakePdf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMakePdf.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMakePdf.Image")));
            this.toolStripButtonMakePdf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMakePdf.Name = "toolStripButtonMakePdf";
            this.toolStripButtonMakePdf.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMakePdf.Tag = "MakePdf";
            this.toolStripButtonMakePdf.Text = "Save to Pdf";
            // 
            // toolStripButtonMakeRtf
            // 
            this.toolStripButtonMakeRtf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonMakeRtf.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonMakeRtf.Image")));
            this.toolStripButtonMakeRtf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonMakeRtf.Name = "toolStripButtonMakeRtf";
            this.toolStripButtonMakeRtf.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonMakeRtf.Tag = "MakeRtf";
            this.toolStripButtonMakeRtf.Text = "Save to Rtf";
            // 
            // toolStripSplitButtonPicture
            // 
            this.toolStripSplitButtonPicture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitButtonPicture.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemBmp,
            this.ToolStripMenuItemPng,
            this.ToolStripMenuItemJepg,
            this.ToolStripMenuItemGif});
            this.toolStripSplitButtonPicture.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonPicture.Image")));
            this.toolStripSplitButtonPicture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonPicture.Name = "toolStripSplitButtonPicture";
            this.toolStripSplitButtonPicture.Size = new System.Drawing.Size(32, 22);
            this.toolStripSplitButtonPicture.Tag = "";
            this.toolStripSplitButtonPicture.Text = "Save to picture";
            // 
            // ToolStripMenuItemBmp
            // 
            this.ToolStripMenuItemBmp.Name = "ToolStripMenuItemBmp";
            this.ToolStripMenuItemBmp.Size = new System.Drawing.Size(99, 22);
            this.ToolStripMenuItemBmp.Tag = "";
            this.ToolStripMenuItemBmp.Text = "BMP";
            this.ToolStripMenuItemBmp.Click += new System.EventHandler(this.ToolStripMenuItemBmp_Click);
            // 
            // ToolStripMenuItemPng
            // 
            this.ToolStripMenuItemPng.Name = "ToolStripMenuItemPng";
            this.ToolStripMenuItemPng.Size = new System.Drawing.Size(99, 22);
            this.ToolStripMenuItemPng.Tag = "";
            this.ToolStripMenuItemPng.Text = "PNG";
            this.ToolStripMenuItemPng.Click += new System.EventHandler(this.ToolStripMenuItemPng_Click);
            // 
            // ToolStripMenuItemJepg
            // 
            this.ToolStripMenuItemJepg.Name = "ToolStripMenuItemJepg";
            this.ToolStripMenuItemJepg.Size = new System.Drawing.Size(99, 22);
            this.ToolStripMenuItemJepg.Tag = "";
            this.ToolStripMenuItemJepg.Text = "JPEG";
            this.ToolStripMenuItemJepg.Click += new System.EventHandler(this.ToolStripMenuItemJepg_Click);
            // 
            // ToolStripMenuItemGif
            // 
            this.ToolStripMenuItemGif.Name = "ToolStripMenuItemGif";
            this.ToolStripMenuItemGif.Size = new System.Drawing.Size(99, 22);
            this.ToolStripMenuItemGif.Tag = "";
            this.ToolStripMenuItemGif.Text = "GIF";
            this.ToolStripMenuItemGif.Click += new System.EventHandler(this.ToolStripMenuItemGif_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonPrinting
            // 
            this.toolStripButtonPrinting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPrinting.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPrinting.Image")));
            this.toolStripButtonPrinting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPrinting.Name = "toolStripButtonPrinting";
            this.toolStripButtonPrinting.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPrinting.Tag = "Printing";
            this.toolStripButtonPrinting.Text = "Print document";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Title = "Save Picture";
            // 
            // RuMigraDocViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 509);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.pagePreview);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "RuMigraDocViewer";
            this.Text = "RuMigraDocViewer";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MigraDoc.Rendering.Printing.MigraDocPrintDocument migraDocPrintDocument;
        private MigraDoc.Rendering.Forms.DocumentPreview pagePreview;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusBar statusBar;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonFirstPage;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrevPage;
        private System.Windows.Forms.ToolStripButton toolStripButtonNextPage;
        private System.Windows.Forms.ToolStripButton toolStripButtonLastPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButtonOriginalSize;
        private System.Windows.Forms.ToolStripButton toolStripButtonFullsize;
        private System.Windows.Forms.ToolStripButton toolStripButtonBestFit;
        private System.Windows.Forms.ToolStripButton toolStripButtonSmaller;
        private System.Windows.Forms.ToolStripButton toolStripButtonLarger;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButtonMakePdf;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonZoom;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem800;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem600;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem400;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem200;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem150;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem100;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem75;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem50;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem25;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBestFit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFullPage;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ToolStripButton toolStripButtonMakeRtf;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonPrinting;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonPicture;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemBmp;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPng;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemJepg;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemGif;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxPageCount;
        private System.Windows.Forms.ToolStripLabel toolStripLabelPage;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxProcent;
    }
}

