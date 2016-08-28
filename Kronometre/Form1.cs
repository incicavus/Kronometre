using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();//timer1 artık interval çalışma aralığında tanımlanan sürede sürekli olarak çalıştırılacak.

            //bir döngü başlatır.

            btnStart.Visible = false; //görünürlüğünü kaldır
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            salise++;
            if (salise == 60)
            {
                saniye++;
                salise = 0;
            }

            lblSaniye.Text = saniye.ToString();
            lblSalise.Text = salise.ToString();
            //sayılar Text özelliğine .ToString() dönüşümü yapılarak aktarılmalı.
        }

        int saniye = 0, salise = 0;//değişkenleri global olarak tanımlamak form içindeki tüm metotlarda kullanılabilmesi sağlar.

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();//timer ın yapmış olduğu işleri durdur.
            //döngüyü breakler.
            btnStart.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblSaniye_Click(object sender, EventArgs e)
        {

        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            saniye = 0; salise = 0;
            btnStart.Visible = true;
            lblSaniye.Text = saniye.ToString();
            lblSalise.Text = salise.ToString();

        }

        int sayac = 0;

        bool aktif = false;
        private void btnStartStop_Click(object sender, EventArgs e)
        {
            #region Sayısal Değer Kullanımı
            //sayac++;
            ////sayacın her tek değeri timerı başlatır ve çift değeri durdurur.
            //if (sayac % 2 == 1)
            //{
            //    timer1.Start();
            //    btnStartStop.Text = "||";
            //}
            //else
            //{
            //    timer1.Stop();
            //    btnStartStop.Text = ">";
            //}
            #endregion

            #region Mantıksal Kullanımı

            if (aktif == false)
            {
                timer1.Start();
                aktif = true;
                btnStartStop.Text = "||";
            }
            else
            {
                aktif = false;
                timer1.Stop();
                btnStartStop.Text = ">";
            }

            #endregion


        }
        
    }
}
