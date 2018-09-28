namespace CommunalPayments
{
    partial class fmMain
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
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            this.welcomePage = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationBar = new DevExpress.XtraBars.Navigation.TileBar();
            this.grPatient = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tbiApartment = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.grRecords = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tileBarGroup1 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.tileBarItem1 = new DevExpress.XtraBars.Navigation.TileBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomePage
            // 
            this.welcomePage.Caption = "welcomePage";
            this.welcomePage.ImageUri.Uri = "New";
            this.welcomePage.Name = "welcomePage";
            this.welcomePage.Size = new System.Drawing.Size(871, 516);
            // 
            // navigationBar
            // 
            this.navigationBar.AllowDrag = false;
            this.navigationBar.AllowDragTilesBetweenGroups = false;
            this.navigationBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationBar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.navigationBar.Groups.Add(this.grPatient);
            this.navigationBar.Groups.Add(this.grRecords);
            this.navigationBar.Location = new System.Drawing.Point(0, 0);
            this.navigationBar.MaxId = 11;
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.navigationBar.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.navigationBar.Size = new System.Drawing.Size(412, 516);
            this.navigationBar.TabIndex = 2;
            this.navigationBar.WideTileWidth = 160;
            // 
            // grPatient
            // 
            this.grPatient.Items.Add(this.tbiApartment);
            this.grPatient.Name = "grPatient";
            this.grPatient.Text = "Объект недвижимости";
            // 
            // tbiApartment
            // 
            this.tbiApartment.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.tbiApartment.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Black;
            this.tbiApartment.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbiApartment.AppearanceItem.Normal.ForeColor = System.Drawing.Color.Black;
            this.tbiApartment.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tbiApartment.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tbiApartment.AppearanceItem.Normal.Options.UseFont = true;
            this.tbiApartment.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tbiApartment.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement5.Image")));
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement5.ImageLocation = new System.Drawing.Point(0, -2);
            tileItemElement5.Text = "Выбрать квартиру";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement6.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.5F);
            tileItemElement6.Appearance.Normal.Options.UseFont = true;
            tileItemElement6.Text = "";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement6.TextLocation = new System.Drawing.Point(0, -2);
            tileItemElement7.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 9.5F);
            tileItemElement7.Appearance.Normal.Options.UseFont = true;
            tileItemElement7.Text = "";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement7.TextLocation = new System.Drawing.Point(0, -2);
            this.tbiApartment.Elements.Add(tileItemElement5);
            this.tbiApartment.Elements.Add(tileItemElement6);
            this.tbiApartment.Elements.Add(tileItemElement7);
            this.tbiApartment.Id = 0;
            this.tbiApartment.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tbiApartment.Name = "tbiApartment";
            this.tbiApartment.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tbiPayer_ItemClick);
            // 
            // grRecords
            // 
            this.grRecords.Name = "grRecords";
            this.grRecords.Text = "Коммунальные услуги";
            // 
            // tileBarGroup1
            // 
            this.tileBarGroup1.Name = "tileBarGroup1";
            // 
            // navigationFrame
            // 
            this.navigationFrame.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.navigationFrame.Controls.Add(this.welcomePage);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 0);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPage[] {
            this.welcomePage});
            this.navigationFrame.SelectedPage = this.welcomePage;
            this.navigationFrame.SelectedPageIndex = 0;
            this.navigationFrame.Size = new System.Drawing.Size(871, 516);
            this.navigationFrame.TabIndex = 3;
            // 
            // tileBarItem1
            // 
            this.tileBarItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.PaleGreen;
            this.tileBarItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileBarItem1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement8.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 11F);
            tileItemElement8.Appearance.Normal.ForeColor = System.Drawing.Color.Black;
            tileItemElement8.Appearance.Normal.Options.UseFont = true;
            tileItemElement8.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement8.Image = ((System.Drawing.Image)(resources.GetObject("tileItemElement8.Image")));
            tileItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft;
            tileItemElement8.Text = "Температура";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.tileBarItem1.Elements.Add(tileItemElement8);
            this.tileBarItem1.Id = 3;
            this.tileBarItem1.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileBarItem1.Name = "tileBarItem1";
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 516);
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.navigationFrame);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Коммунальные платежи";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPage welcomePage;
        private DevExpress.XtraBars.Navigation.TileBar navigationBar;
        private DevExpress.XtraBars.Navigation.TileBarGroup grPatient;
        private DevExpress.XtraBars.Navigation.TileBarItem tbiApartment;
        private DevExpress.XtraBars.Navigation.TileBarGroup grRecords;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup1;
        private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
        private DevExpress.XtraBars.Navigation.TileBarItem tileBarItem1;
    }
}

