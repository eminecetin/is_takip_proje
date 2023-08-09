using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using is_takip_proje.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace is_takip_proje.Formlar
{
    public partial class FrmDepartmanlar : Form
    {
        public FrmDepartmanlar()
        {
            InitializeComponent();
        }

       
        void Listele()
        {
            DbisTakipEntities db=new DbisTakipEntities();
            var degerler=(from x in db.TblDepartmanlar
                         select new
                         {
                             x.ID,
                             x.Ad
                         }).ToList();
            gridControl1.DataSource = db.TblDepartmanlar.ToList();
        }
        private void Btnlistele_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblDepartmanlar t=new TblDepartmanlar();
            t.Ad = TxtAd.Text;
        }
    }
}
