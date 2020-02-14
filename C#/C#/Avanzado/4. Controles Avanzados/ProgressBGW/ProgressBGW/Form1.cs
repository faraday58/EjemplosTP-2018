﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace ProgressBGW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            BGW.RunWorkerAsync();
        }

        // No deben existir componentes gui acá (esto estará en background)
        private void BGW_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                // Si hay petición de cancelaci´´on lo cancelamos
                if (BGW.CancellationPending)
                    e.Cancel = true;

                Thread.Sleep(200);
                BGW.ReportProgress(i);
            }
        }

        // Acá si podemos poner componentes
        private void BGW_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            Random r = new Random();
            LblOutput.Text = RandomString(r.Next(8,14));

        }

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void BGW_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
                MessageBox.Show("I have been cancelled");
            else
                MessageBox.Show("I have finished!");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            BGW.CancelAsync();
        }
    }
}
