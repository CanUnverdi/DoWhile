using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
             public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void btnWhile1_Click(object sender, EventArgs e)
            {


                int sayac = 1;

                while (sayac <= 100)
                {
                    listBox1.Items.Add(sayac);
                    sayac++;
                }
            }

            private void btnWhile2_Click(object sender, EventArgs e)
            {
   
                int sayac = 0;

                while (sayac < Controls.Count)
                {
                    Controls[sayac].Width = 100;
                    Controls[sayac].Top += 20;
                    sayac++;
                }
            }

            private void btnWhile3_Click(object sender, EventArgs e)
            {

                int i = 1;
                int sonuc = 1;

                while (i <= 8)
                {
                    sonuc = sonuc * i;
                    i++;
                }

                MessageBox.Show("8 sayısının faktöriyeli " + sonuc);
            }

            private void btnDoWhile1_Click(object sender, EventArgs e)
            {


                int i = 1;
                do
                {
                    listBox1.Items.Add(i);
                    i++;
                } while (i <= 100);
            }

            private void btnDoWhile2_Click(object sender, EventArgs e)
            {


                int girilenSayi = Convert.ToInt32(textBox1.Text);
                int sayac = 1;
                int faktoriyelSonucu = 1;

                do
                {
                    faktoriyelSonucu *= sayac;
                    sayac++;
                } while (sayac <= girilenSayi);

                MessageBox.Show("Faktörüyel Sonucu: " + faktoriyelSonucu);
            }

            private void Form1_Load(object sender, EventArgs e)
        }
    }
}
