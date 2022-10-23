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
    public partial class Form1 : Form
    {
        Giris1EntitiesConnectionDb db = new Giris1EntitiesConnectionDb();
        public Form1()
        {
            InitializeComponent();
        }
        public static int Id;
        private void button1_Click(object sender, EventArgs e)
        {
            var Durum = db.GirisBilgileri.FirstOrDefault(x => x.e_mail == textBox1.Text && x.sifre == textBox2.Text);
            if (Durum != null)
            {
                Id = Durum.id;
                GirisBasarili gb = new GirisBasarili();
                gb.ShowDialog();

            }
            else
            {
                MessageBox.Show("Girilen bilgiler gerçeği ile uyuşmamaktadır", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sifretazele st = new sifretazele();
            st.ShowDialog();
        }
    }
}
