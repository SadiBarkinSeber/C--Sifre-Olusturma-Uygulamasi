using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sifreOlustur
{
    public partial class Form1 : Form
    {
        private static readonly Random rnd = new Random();
        private const string KucukHarfKarakterler = "abcdefghijklmnopqrstuvwxyz";
        private const string BuyukHarfKarakterler = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string RakamKarakterler = "0123456789";
        private const string OzelKarakterler = "!@#$%^&*()_+-=[]{}|;:'\"<>,.?/";

        public Form1()
        {
            InitializeComponent();
        }

        private string KarakterSeti()
        {
            StringBuilder charSet = new StringBuilder();
            if (chbKucukHarf.Checked)
                charSet.Append(KucukHarfKarakterler);

            if (chbBuyukHarf.Checked)
                charSet.Append(BuyukHarfKarakterler);

            if (chbRakam.Checked)
                charSet.Append(RakamKarakterler);

            if (chbOzelKarakter.Checked)
                charSet.Append(OzelKarakterler);

            return charSet.ToString();
        }

        private void btnUret_Click_1(object sender, EventArgs e)
        {
            int sifreUzunlugu = (int)nudSifreUzunlugu.Value;
            int sifreSayisi = (int)nudSifreSayisi.Value;
            StringBuilder olusturulanSifreler = new StringBuilder();

            for (int i = 0; i < sifreSayisi; i++)
            {
                StringBuilder sifre = new StringBuilder();

                if (chbKucukHarf.Checked)
                    sifre.Append(KucukHarfKarakterler[rnd.Next(KucukHarfKarakterler.Length)]);

                if (chbBuyukHarf.Checked)
                    sifre.Append(BuyukHarfKarakterler[rnd.Next(BuyukHarfKarakterler.Length)]);

                if (chbRakam.Checked)
                    sifre.Append(RakamKarakterler[rnd.Next(RakamKarakterler.Length)]);

                if (chbOzelKarakter.Checked)
                    sifre.Append(OzelKarakterler[rnd.Next(OzelKarakterler.Length)]);

                while (sifre.Length < sifreUzunlugu)
                {
                    string charSet = KarakterSeti();
                    sifre.Append(charSet[rnd.Next(charSet.Length)]);
                }

                olusturulanSifreler.AppendLine(sifre.ToString());
            }

            rtbSifreler.Text = olusturulanSifreler.ToString();
        }
    }
}
