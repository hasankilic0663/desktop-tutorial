using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GirrisKonsol.Models;

namespace GirrisKonsol
{
    public partial class GirisBasarili : Form
    {
        Giris1EntitiesConnectionDb db = new Giris1EntitiesConnectionDb();
        public GirisBasarili()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GirisBasarili_Load(object sender, EventArgs e)
        {
            label1.Text = $@"Hoş geldiniz. Sayın{db.GirisBilgileri.FirstOrDefault(x => x.id== Form1.Id).kullanici_adi}";
            
        }
    }
}
