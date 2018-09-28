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
    public partial class fmApartment : Form
    {
        internal int ApartmentId;

        public fmApartment (int apartmentId = 0)
        {
            InitializeComponent();
            this.ApartmentId = apartmentId;
            if (apartmentId > 0)
                LoadAppartment();
        }

        private void LoadAppartment()
        {
            using (var db = ModelDB.Context)
            {
                var app = db.Apartments.ById(this.ApartmentId);
                tbAddress.Text = app.Address;
                tbSquare.Text = app.Square.ToSafeString();
                tbResidents.Text = app.Residents.ToSafeString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = ModelDB.Context)
            {
                var app = db.Apartments.ById(this.ApartmentId);
                if (app == null)
                {
                    app = new Apartments();
                    db.Apartments.Add(app);
                }
                app.Address = tbAddress.Text;
                app.Square = tbSquare.Text.ToDouble();
                app.Residents = tbResidents.Text.ToInt();
                db.SaveChanges();
                this.ApartmentId = app.Id;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
