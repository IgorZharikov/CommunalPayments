using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunalPayments
{
    public partial class fmSelectApartment : Form
    {
        internal int ApartmentId;

        public fmSelectApartment()
        {
            InitializeComponent();
            LoadApartments();
        }

        private void LoadApartments()
        {
            using (var db = ModelDB.Context)
            {
                foreach (var app in db.Apartments)
                    tbgApartments.Items.Insert(tbgApartments.Items.Count - 1, GetApartmentItem(new TileBarItem(), app.Id));
            }
        }

        private void tsmiNewAppartment_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            fmApartment form = new fmApartment();
            if (form.ShowDialog() == DialogResult.OK)
                tbgApartments.Items.Insert(tbgApartments.Items.Count - 1, GetApartmentItem(new TileBarItem(), form.ApartmentId));
        }

        private TileBarItem GetApartmentItem(TileBarItem item, int id)
        {
            using (var db = ModelDB.Context)
            {
                var app = db.Apartments.ById(id);
                item.Text = app.Address;
                item.Name = app.Address;
                item.Elements[0].TextAlignment = TileItemContentAlignment.BottomRight;
                item.Elements[0].ImageAlignment = TileItemContentAlignment.MiddleLeft;
                item.Elements[0].Image = Properties.Resources.home_32x32;
                item.Elements[0].ImageLocation = new Point(-10, -10);
                item.Elements[0].TextLocation = new Point(5, 0);
                item.Elements[0].Width = 145;
                item.Elements.Add(new TileItemElement() { Text = "Площадь: " + app.Square + " кв.м.", TextAlignment = TileItemContentAlignment.TopRight, TextLocation = new Point(5, 0) });
                item.Elements.Add(new TileItemElement() { Text = "Прописано: " + app.Residents + " чел.", TextAlignment = TileItemContentAlignment.MiddleRight, TextLocation = new Point(5, 0) });
                item.Tag = id;
                item.ItemClick += AppartmentSelect;
                item.RightItemClick += AppartmentContextMenu;
                return item;
            }
        }

        private void AppartmentSelect(object sender, TileItemEventArgs e)
        {
            this.ApartmentId = Convert.ToInt32(e.Item.Tag);
            this.DialogResult = DialogResult.OK;
        }

        private string currentItemName = "";
        private void AppartmentContextMenu(object sender, TileItemEventArgs e)
        {
            this.ApartmentId = Convert.ToInt32(e.Item.Tag);
            this.currentItemName = e.Item.Name;
            cmsMenu.Show(MousePosition, ToolStripDropDownDirection.AboveLeft);           
        }       

        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            if (this.ApartmentId > 0)
            {
                fmApartment form = new fmApartment(this.ApartmentId);
                if (form.ShowDialog() == DialogResult.OK)
                    GetApartmentItem(tbgApartments.Items[currentItemName] as TileBarItem, form.ApartmentId);
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (this.ApartmentId > 0 && MessageBox.Show("Удалить выбранный адрес ?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = ModelDB.Context)
                {
                    var app = db.Apartments.ById(this.ApartmentId);
                    db.Apartments.Remove(app);
                    db.SaveChanges();
                    tbgApartments.Items.Remove(tbgApartments.Items[currentItemName] as TileBarItem);
                }
            }
        }
    }
}
