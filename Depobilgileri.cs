﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Petrol_Istasyonu_Ve_Marketcilik_Otomasyonu
{
    public partial class Depobilgileri : Form
    {
        public Depobilgileri()
        {
            InitializeComponent();
        }
        double M_Benzin = 0, M_Dizel = 0, M_LPG = 0;
        double E_Benzin = 0, E_Dizel = 0, E_LPG = 0;
        string[] depo_bilgileri;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                E_Benzin = Convert.ToDouble(textBox1.Text);
                if (1000 < M_Benzin + E_Benzin || E_Benzin <= 0)
                    textBox1.Text = "YANLIŞ!!!";
                else
                    depo_bilgileri[0] = Convert.ToString(M_Benzin + E_Benzin);
            }
            catch (Exception)
            {
                textBox1.Text = "YANLIŞ!!!";
            }
            try
            {
                E_Dizel = Convert.ToDouble(textBox2.Text);
                if (1000 < M_Dizel + E_Dizel || E_Dizel <= 0)
                    textBox2.Text = "YANLIŞ!!!";
                else
                    depo_bilgileri[1] = Convert.ToString(M_Dizel + E_Dizel);
            }
            catch (Exception)
            {
                textBox2.Text = "YANLIŞ!!!";
            }
            try
            {
                E_LPG = Convert.ToDouble(textBox3.Text);
                if (1000 < M_LPG + E_LPG || E_LPG <= 0)
                    textBox3.Text = "YANLIŞ!!!";
                else
                    depo_bilgileri[2] = Convert.ToString(M_LPG + E_LPG);
            }
            catch (Exception)
            {
                textBox3.Text = "YANLIŞ!!!";
            }
            System.IO.File.WriteAllLines(Application.StartupPath + "\\Depo.txt", depo_bilgileri);
            txt_depo_oku();
            txt_depo_yaz();
            progressBar_guncelle();
        }



        private void txt_depo_oku()
        {
            depo_bilgileri = System.IO.File.ReadAllLines(Application.StartupPath + "\\Depo.txt");
            M_Benzin = Convert.ToDouble(depo_bilgileri[0]);
            M_Dizel = Convert.ToDouble(depo_bilgileri[1]);
            M_LPG = Convert.ToDouble(depo_bilgileri[2]);

        }
        private void txt_depo_yaz()
        {
            label1.Text = M_Benzin.ToString("N");
            label7.Text = M_Dizel.ToString("N");
            label3.Text = M_LPG.ToString("N");
        }
        private void progressBar_guncelle()
        {
            progressBar1.Value = Convert.ToInt16(M_Benzin);
            progressBar2.Value = Convert.ToInt16(M_Dizel);
            progressBar3.Value = Convert.ToInt16(M_LPG);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            progressBar1.Maximum = 1000;
            progressBar2.Maximum = 1000;
            progressBar3.Maximum = 1000;
            txt_depo_oku();
            txt_depo_yaz();
            progressBar_guncelle();
        }
    }
    
}

