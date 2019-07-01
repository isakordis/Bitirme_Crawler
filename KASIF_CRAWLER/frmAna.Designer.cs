namespace KASIF_CRAWLER
{
    partial class frmAna
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
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.loading = new System.Windows.Forms.ProgressBar();
            this.kayitBtn = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            this.outPutTxt = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonHeader1 = new ComponentFactory.Krypton.Toolkit.KryptonHeader();
            this.kryptonPanel2 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.gezintiBtn = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.siteAdresList = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.kryptonRibbon1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.kryptonRibbonTab1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.kryptonRibbonGroup1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.kryptonRibbonGroupButton1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupButton3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).BeginInit();
            this.kryptonPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonNavigator1);
            this.kryptonPanel1.Controls.Add(this.kryptonRibbon1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(761, 580);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 143);
            this.kryptonNavigator1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.NavigatorMode = ComponentFactory.Krypton.Navigator.NavigatorMode.StackCheckButtonGroup;
            this.kryptonNavigator1.PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage1,
            this.kryptonPage2});
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(761, 437);
            this.kryptonNavigator1.TabIndex = 1;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage1
            // 
            this.kryptonPage1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage1.Controls.Add(this.loading);
            this.kryptonPage1.Controls.Add(this.kayitBtn);
            this.kryptonPage1.Controls.Add(this.outPutTxt);
            this.kryptonPage1.Controls.Add(this.kryptonHeader1);
            this.kryptonPage1.Controls.Add(this.kryptonPanel2);
            this.kryptonPage1.Flags = 65534;
            this.kryptonPage1.LastVisibleSet = true;
            this.kryptonPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPage1.MinimumSize = new System.Drawing.Size(38, 41);
            this.kryptonPage1.Name = "kryptonPage1";
            this.kryptonPage1.Size = new System.Drawing.Size(759, 385);
            this.kryptonPage1.Text = "CRAWLER İŞLEM YÖNETİCİSİ";
            this.kryptonPage1.ToolTipTitle = "Page ToolTip";
            this.kryptonPage1.UniqueName = "BC10F47928EA4F3D0EBAF9FEB7DBBD5B";
            // 
            // loading
            // 
            this.loading.Location = new System.Drawing.Point(166, 369);
            this.loading.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loading.MarqueeAnimationSpeed = 10;
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(477, 19);
            this.loading.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.loading.TabIndex = 4;
            this.loading.Visible = false;
            // 
            // kayitBtn
            // 
            this.kayitBtn.Location = new System.Drawing.Point(647, 369);
            this.kayitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kayitBtn.Name = "kayitBtn";
            this.kayitBtn.Size = new System.Drawing.Size(107, 20);
            this.kayitBtn.TabIndex = 3;
            this.kayitBtn.Values.Text = "Çıktıyı Kaydet[***]";
            this.kayitBtn.LinkClicked += new System.EventHandler(this.kayitBtn_LinkClicked);
            // 
            // outPutTxt
            // 
            this.outPutTxt.DetectUrls = false;
            this.outPutTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.outPutTxt.Location = new System.Drawing.Point(160, 26);
            this.outPutTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.outPutTxt.Name = "outPutTxt";
            this.outPutTxt.ReadOnly = true;
            this.outPutTxt.Size = new System.Drawing.Size(599, 339);
            this.outPutTxt.TabIndex = 2;
            this.outPutTxt.Text = "";
            this.outPutTxt.TextChanged += new System.EventHandler(this.outPutTxt_TextChanged);
            // 
            // kryptonHeader1
            // 
            this.kryptonHeader1.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonHeader1.HeaderStyle = ComponentFactory.Krypton.Toolkit.HeaderStyle.DockActive;
            this.kryptonHeader1.Location = new System.Drawing.Point(160, 0);
            this.kryptonHeader1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonHeader1.Name = "kryptonHeader1";
            this.kryptonHeader1.Size = new System.Drawing.Size(599, 26);
            this.kryptonHeader1.TabIndex = 1;
            this.kryptonHeader1.Values.Description = "Gezinti sonuçlarını bildirir";
            this.kryptonHeader1.Values.Heading = "GEZİNTİ PENCERESİ";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.gezintiBtn);
            this.kryptonPanel2.Controls.Add(this.panel1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.PanelBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.PanelRibbonInactive;
            this.kryptonPanel2.Size = new System.Drawing.Size(160, 385);
            this.kryptonPanel2.TabIndex = 0;
            // 
            // gezintiBtn
            // 
            this.gezintiBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gezintiBtn.Location = new System.Drawing.Point(0, 352);
            this.gezintiBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gezintiBtn.Name = "gezintiBtn";
            this.gezintiBtn.Size = new System.Drawing.Size(160, 33);
            this.gezintiBtn.TabIndex = 1;
            this.gezintiBtn.Values.Text = "Gezintiyi Başlat !";
            this.gezintiBtn.Click += new System.EventHandler(this.gezintiBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.siteAdresList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 352);
            this.panel1.TabIndex = 0;
            // 
            // siteAdresList
            // 
            this.siteAdresList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siteAdresList.Items.AddRange(new object[] {
            "https://www.kizlarsoruyor.com/sitemaps/sitemaps.xml",
            "https://docs.microsoft.com/_sitemaps/sitemapindex.xml",
            "https://www.hepsiburada.com/sitemaps/sitemap.xml",
            "https://eksisozluk.com/sitemap.xml",
            "https://www.turkiye.gov.tr/sitemap.xml",
            "https://www.mynet.com/sitemap.xml",
            "https://www.fullhdfilmizlesene.net/smap.php",
            "https://www.haberturk.com/sitemap.xml",
            "https://www.neoldu.com/sitemap.xsd",
            "https://www.whatsapp.com/sitemap.xml",
            "https://www.sabah.com.tr/sitemap/index.xml",
            "https://www.donanimhaber.com/sitemap.xml",
            "https://onedio.com/secure/sitemap.xml",
            "https://yemek.com/sitemap_index.xml",
            "https://www.superhaber.tv/export/sitemap",
            "https://www.olay.com.tr/sitemap.xsd",
            "https://www.diyadinnet.com/sitemap.xml",
            "https://www.tripadvisor.com.tr/sitemap/2/tr/sitemap_tr_index.xml",
            "https://www.bakiciburada.com/sitemap.xml",
            "https://www.kimnereli.net/sitemap_index.xml",
            "https://www.csharpstar.com/sitemap.xml",
            "https://www.bulurum.com/sitemap.xml",
            "https://www.enuygun.com/sitemap-otel.xml",
            "https://www.arabam.com/sitemap/sitemap.xml"});
            this.siteAdresList.Location = new System.Drawing.Point(0, 0);
            this.siteAdresList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.siteAdresList.Name = "siteAdresList";
            this.siteAdresList.Size = new System.Drawing.Size(160, 352);
            this.siteAdresList.TabIndex = 0;
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(38, 41);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(75, 81);
            this.kryptonPage2.Text = "kryptonPage2";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "FA9F111453E14205289C7E4CF74E81D9";
            // 
            // kryptonRibbon1
            // 
            this.kryptonRibbon1.InDesignHelperMode = true;
            this.kryptonRibbon1.Name = "kryptonRibbon1";
            this.kryptonRibbon1.RibbonStyles.BackInactiveStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.SeparatorCustom1;
            this.kryptonRibbon1.RibbonStyles.GroupDialogButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.kryptonRibbon1.RibbonStyles.QATButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.BreadCrumb;
            this.kryptonRibbon1.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.kryptonRibbonTab1});
            this.kryptonRibbon1.SelectedTab = this.kryptonRibbonTab1;
            this.kryptonRibbon1.Size = new System.Drawing.Size(761, 143);
            this.kryptonRibbon1.TabIndex = 0;
            // 
            // kryptonRibbonTab1
            // 
            this.kryptonRibbonTab1.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.kryptonRibbonGroup1});
            this.kryptonRibbonTab1.Text = "İşlemler";
            // 
            // kryptonRibbonGroup1
            // 
            this.kryptonRibbonGroup1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple1});
            this.kryptonRibbonGroup1.TextLine1 = "Site İşlemleri";
            // 
            // kryptonRibbonGroupTriple1
            // 
            this.kryptonRibbonGroupTriple1.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.kryptonRibbonGroupButton1,
            this.kryptonRibbonGroupButton2,
            this.kryptonRibbonGroupButton3});
            // 
            // kryptonRibbonGroupButton1
            // 
            this.kryptonRibbonGroupButton1.TextLine1 = "Site Kayıt";
            // 
            // kryptonRibbonGroupButton2
            // 
            this.kryptonRibbonGroupButton2.TextLine1 = "Kayıtlı Tüm Siteler";
            // 
            // kryptonRibbonGroupButton3
            // 
            this.kryptonRibbonGroupButton3.TextLine1 = "Özet";
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 580);
            this.Controls.Add(this.kryptonPanel1);
            this.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ButtonAlternate;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAna";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.Text = "KAŞİF.CRAWLER v1.0.1";
            this.Load += new System.EventHandler(this.frmAna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage1)).EndInit();
            this.kryptonPage1.ResumeLayout(false);
            this.kryptonPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonRibbon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon kryptonRibbon1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab kryptonRibbonTab1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup kryptonRibbonGroup1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton kryptonRibbonGroupButton3;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonListBox siteAdresList;
        private ComponentFactory.Krypton.Toolkit.KryptonButton gezintiBtn;
        private ComponentFactory.Krypton.Toolkit.KryptonHeader kryptonHeader1;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox outPutTxt;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel kayitBtn;
        private System.Windows.Forms.ProgressBar loading;
    }
}