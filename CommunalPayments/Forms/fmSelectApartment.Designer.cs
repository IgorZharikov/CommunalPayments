namespace CommunalPayments
{
    partial class fmSelectApartment
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
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            this.tbApartments = new DevExpress.XtraBars.Navigation.TileBar();
            this.tbgApartments = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.tsmiNewAppartment = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbApartments
            // 
            this.tbApartments.AllowDrag = false;
            this.tbApartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbApartments.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tbApartments.Groups.Add(this.tbgApartments);
            this.tbApartments.Location = new System.Drawing.Point(0, 0);
            this.tbApartments.MaxId = 6;
            this.tbApartments.Name = "tbApartments";
            this.tbApartments.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tbApartments.Size = new System.Drawing.Size(447, 101);
            this.tbApartments.TabIndex = 0;
            this.tbApartments.Text = "tileBar1";
            // 
            // tbgApartments
            // 
            this.tbgApartments.Items.Add(this.tsmiNewAppartment);
            this.tbgApartments.Name = "tbgApartments";
            // 
            // tsmiNewAppartment
            // 
            this.tsmiNewAppartment.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Image = global::CommunalPayments.Properties.Resources.add_32x32;
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement3.Text = "Новый";
            this.tsmiNewAppartment.Elements.Add(tileItemElement3);
            this.tsmiNewAppartment.Id = 4;
            this.tsmiNewAppartment.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Medium;
            this.tsmiNewAppartment.Name = "tsmiNewAppartment";
            this.tsmiNewAppartment.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tsmiNewAppartment_ItemClick);
            // 
            // cmsMenu
            // 
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEdit,
            this.tsmiDelete});
            this.cmsMenu.Name = "cmsMenu";
            this.cmsMenu.Size = new System.Drawing.Size(181, 70);
            // 
            // tsmiEdit
            // 
            this.tsmiEdit.Name = "tsmiEdit";
            this.tsmiEdit.Size = new System.Drawing.Size(180, 22);
            this.tsmiEdit.Text = "Редактировать";
            this.tsmiEdit.Click += new System.EventHandler(this.tsmiEdit_Click);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(180, 22);
            this.tsmiDelete.Text = "Удалить";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // fmSelectApartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 101);
            this.Controls.Add(this.tbApartments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fmSelectApartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Объекты недвижимости";
            this.cmsMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tbApartments;
        private DevExpress.XtraBars.Navigation.TileBarGroup tbgApartments;
        private DevExpress.XtraBars.Navigation.TileBarItem tsmiNewAppartment;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiEdit;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}