using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecodation_Mayin_Tarlasi_Antrenman
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static Random r_mayin = new Random();
        static Random r_puan = new Random();
        int can = 3;
        int puan = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            

            button2.BackgroundImage = Properties.Resources.number_one;
            button3.BackgroundImage = Properties.Resources.number_2;
            button4.BackgroundImage = Properties.Resources.number_3;
            button5.BackgroundImage = Properties.Resources.number_four;
            button6.BackgroundImage = Properties.Resources.number_5;
            button7.BackgroundImage = Properties.Resources.six;
            button8.BackgroundImage = Properties.Resources.seven;
            button9.BackgroundImage = Properties.Resources.number_8;
            button10.BackgroundImage = Properties.Resources.number_9;
            button11.BackgroundImage = Properties.Resources.number_10;
            button12.BackgroundImage = Properties.Resources.number_11;
            button13.BackgroundImage = Properties.Resources.number_12;
            button14.BackgroundImage = Properties.Resources.number_13;
            button15.BackgroundImage = Properties.Resources.number_14;
            button16.BackgroundImage = Properties.Resources.number_15;
            button17.BackgroundImage = Properties.Resources.number_16;


            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;


        }

        int mayin1 = r_mayin.Next(1, 17);
        int mayin2 = r_mayin.Next(1, 17);
        int mayin3 = r_mayin.Next(1, 17);

        int puanlama_1 = r_puan.Next(1, 11);
        
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Mayın Tarlası Oyununa Hoşgeldiniz!";
            can = 3;
            puan = 0;
            label5.Text = "0";
            label3.Text = "3";

            mayin1 = r_mayin.Next(1, 17);
            mayin2 = r_mayin.Next(1, 17);
            mayin3 = r_mayin.Next(1, 17);


            puanlama_1 = r_puan.Next(1, 11);



            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            button17.Text = "";
            button15.Text = "";
            button14.Text = "";
            button16.Text = "";



            button2.BackgroundImage = Properties.Resources.number_one;
            button3.BackgroundImage = Properties.Resources.number_2;
            button4.BackgroundImage = Properties.Resources.number_3;
            button5.BackgroundImage = Properties.Resources.number_four;
            button6.BackgroundImage = Properties.Resources.number_5;
            button7.BackgroundImage = Properties.Resources.six;
            button8.BackgroundImage = Properties.Resources.seven;
            button9.BackgroundImage = Properties.Resources.number_8;
            button10.BackgroundImage = Properties.Resources.number_9;
            button11.BackgroundImage = Properties.Resources.number_10;
            button12.BackgroundImage = Properties.Resources.number_11;
            button13.BackgroundImage = Properties.Resources.number_12;
            button14.BackgroundImage = Properties.Resources.number_13;
            button15.BackgroundImage = Properties.Resources.number_14;
            button16.BackgroundImage = Properties.Resources.number_15;
            button17.BackgroundImage = Properties.Resources.number_16;

            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button1.Enabled = false;


            while (mayin3==mayin2||mayin1==mayin2||mayin3==mayin1)
            {
                mayin1 = r_mayin.Next(1, 14);
                mayin2 = r_mayin.Next(1, 14);
                mayin3 = r_mayin.Next(1, 14);
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (mayin1==1)
            {
                button2.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2==1)
            {
                button2.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3==1)
            {
                button2.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button2.BackgroundImage = Properties.Resources.star;
                button2.Enabled = false;
                button2.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);

            }
            if (can==0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mayin1 == 2)
            {
                button3.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2 == 2)
            {
                button3.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3 == 2)
            {
                button3.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button3.BackgroundImage = Properties.Resources.star;
                button3.Enabled = false;
                button3.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);
            }
            if (can == 0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = true;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mayin1 == 3)
            {
                button4.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2 == 3)
            {
                button4.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3 == 3)
            {
                button4.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button4.BackgroundImage = Properties.Resources.star;
                button4.Enabled = false;
                button4.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);
            }

            if (can == 0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = true;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mayin1 == 4)
            {
                button5.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2 == 4)
            {
                button5.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3 == 4)
            {
                button5.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button5.BackgroundImage = Properties.Resources.star;
                button5.Enabled = false;
                button5.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);
            }

            if (can == 0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = true;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mayin1 == 5)
            {
                button6.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2 == 5)
            {
                button6.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3 == 5)
            {
                button6.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button6.BackgroundImage = Properties.Resources.star;
                button6.Enabled = false;
                button6.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);
            }

            if (can == 0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = true;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (mayin1 == 6)
            {
                button7.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2 == 6)
            {
                button7.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3 == 6)
            {
                button7.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button7.BackgroundImage = Properties.Resources.star;
                button7.Enabled = false;
                button7.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);
            }

            if (can == 0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = true;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (mayin1 == 7)
            {
                button8.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2 == 7)
            {
                button8.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3 == 7)
            {
                button8.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button8.BackgroundImage = Properties.Resources.star;
                button8.Enabled = false;
                button8.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);
            }

            if (can == 0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = true;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (mayin1 == 8)
            {
                button9.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2 == 8)
            {
                button9.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3 == 8)
            {
                button9.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button9.BackgroundImage = Properties.Resources.star;
                button9.Enabled = false;
                button9.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);
            }

            if (can == 0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = true;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (mayin1 == 9)
            {
                button10.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2 == 9)
            {
                button10.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3 == 9)
            {
                button10.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button10.BackgroundImage = Properties.Resources.star;
                button10.Enabled = false;
                button10.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);
            }

            if (can == 0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = true;

            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (mayin1 == 10)
            {
                button11.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2 == 10)
            {
                button11.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3 == 10)
            {
                button11.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button11.BackgroundImage = Properties.Resources.star;
                button11.Enabled = false;
                button11.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);
            }

            if (can == 0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = true;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (mayin1 == 11)
            {
                button12.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2 == 11)
            {
                button12.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3 == 11)
            {
                button12.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button12.BackgroundImage = Properties.Resources.star;
                button12.Enabled = false;
                button12.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);
            }

            if (can == 0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = true;

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (mayin1 == 12)
            {
                button13.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2 == 12)
            {
                button13.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3 == 12)
            {
                button13.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button13.BackgroundImage = Properties.Resources.star;
                button13.Enabled = false;
                button13.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);
            }

            if (can == 0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = true;

            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (mayin1 == 13)
            {
                button14.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2 == 13)
            {
                button14.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3 == 13)
            {
                button14.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button14.BackgroundImage = Properties.Resources.star;
                button14.Enabled = false;
                button14.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);
            }

            if (can == 0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = true;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (mayin1 == 14)
            {
                button15.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2 == 14)
            {
                button15.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3 == 14)
            {
                button15.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button15.BackgroundImage = Properties.Resources.star;
                button15.Enabled = false;
                button15.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);
            }

            if (can == 0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = true;

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (mayin1 == 15)
            {
                button16.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2 == 15)
            {
                button16.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3 == 15)
            {
                button16.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button16.BackgroundImage = Properties.Resources.star;
                button16.Enabled = false;
                button16.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);
            }

            if (can == 0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = true;

            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (mayin1 == 16)
            {
                button17.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin2 == 16)
            {
                button17.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else if (mayin3 == 16)
            {
                button17.BackgroundImage = Properties.Resources.bomb;
                can--;
                label3.Text = Convert.ToString(can);
                label1.Text = "OPPSSS MAYINA BASTIN!!!!";
            }
            else
            {
                button17.BackgroundImage = Properties.Resources.star;
                button17.Enabled = false;
                button17.Text = Convert.ToString(puanlama_1);
                label1.Text = "Harika Mayına Basmadın Böyle Devam Et";
                puan += puanlama_1;
                label5.Text = Convert.ToString(puan);
                puanlama_1 = r_puan.Next(1, 11);
            }

            if (can == 0)
            {
                label1.Text = "OYUNU KAYBETTİN CANIN KALMADI";
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                button10.Enabled = false;
                button11.Enabled = false;
                button12.Enabled = false;
                button13.Enabled = false;
                button14.Enabled = false;
                button15.Enabled = false;
                button16.Enabled = false;
                button17.Enabled = false;
                button1.Enabled = true;
            }
        }
    }
}
