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
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
            navigationBar.WideTileWidth = 200;
            LoadServices();
        }

        private void tbiPayer_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            fmSelectApartment form = new fmSelectApartment();
            if (form.ShowDialog() == DialogResult.OK)
            {               
                LoadApartmentInfo(form.ApartmentId);
                navigationFrame.SelectedPage = welcomePage;
            }
        }

        private void LoadServices()
        {
            using (var db = ModelDB.Context)
            {

            }
        }

        private void LoadApartmentInfo(int apartmentId)
        {
            using (var db = ModelDB.Context)
            {
                navigationBar.WideTileWidth = 200;
                tbiApartment.Elements.Clear();

                var app = db.Apartments.ById(apartmentId);
                tbiApartment.Name = app.Address;
                tbiApartment.Tag = apartmentId;

                TileItemElement square = new TileItemElement() { Text = "Площадь: " + app.Square + " кв.м.", TextAlignment = TileItemContentAlignment.TopRight, TextLocation = new Point(5, 0) };
                square.Appearance.Normal.Font = new Font("MS Sans Serif", 8.25f, FontStyle.Regular);
                tbiApartment.Elements.Add(square);

                TileItemElement residents = new TileItemElement() { Text = "Прописано: " + app.Residents + " чел.", TextAlignment = TileItemContentAlignment.MiddleRight, TextLocation = new Point(5, 0) };
                residents.Appearance.Normal.Font = new Font("MS Sans Serif", 8.25f, FontStyle.Regular);
                tbiApartment.Elements.Add(residents);

                TileItemElement address = new TileItemElement();
                address.Text = app.Address;
                address.Appearance.Normal.Font = new Font("MS Sans Serif", 8.25f, FontStyle.Bold);
                address.TextAlignment = TileItemContentAlignment.BottomRight;
                address.ImageAlignment = TileItemContentAlignment.MiddleLeft;
                address.Image = Properties.Resources.home_32x32;
                address.ImageLocation = new Point(0, -8);
                address.TextLocation = new Point(25, 0);
                address.Width = 200;
                tbiApartment.Elements.Add(address);

               
            }
        }
    }
}
