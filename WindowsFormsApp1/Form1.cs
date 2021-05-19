using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {   const int size = 5;
        double[] aboba = new double[size];
        double hit = 9.488f;
        
        public Form1()
        {
            InitializeComponent();

        }
        
        private void InitializationGeomProb(double prob0)
        {
            double S = 0;
            for (int i=0;i< size - 1;i++)
            {
                aboba[i] = prob0 * Math.Pow(1 - prob0, i);
                S += aboba[i];
            }
            aboba[size - 1] = 1 - S;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            Random rand = new Random();
            double prob0 = (double)Num1.Value;
            InitializationGeomProb(prob0);

            int[] stats = new int[size];
            var n = (int)Trials.Value;

            for (int i = 0; i<n; i++)
            {
                var x = (int)(Math.Log(rand.NextDouble()) / Math.Log(1 - prob0));
                if (x > size - 1)  stats[size - 1]++;
                else stats[x]++;
            }

            double[] brat_aboba = new double[5];
            double Cs = 0;
            
            for (int i = 0; i< size; i++)
            {
                brat_aboba[i] = (double)stats[i] / n;
                Cs += (double)Math.Pow(stats[i], 2) / (aboba[i] * n);
                chart1.Series[0].Points.AddXY(i+1,(double)stats[i]/n);
            }
            Cs -= n;

            double chiki1 = 0, chiki2 = 0, briki1 = 0, briki2 = 0;
            for (int i=0;i< size; i++)
            {
                chiki1 += (i + 1) * aboba[i];
                chiki2 += (i + 1) * brat_aboba[i];
                briki1 += (double)Math.Pow(i + 1, 2) * aboba[i];
                briki2 += (double)Math.Pow(i + 1, 2) * brat_aboba[i];
            }

            briki1 -= (double)Math.Pow(chiki1, 2);
            briki2 -= (double)Math.Pow(chiki2, 2);

            RelA.Text = $"{chiki2} <Error = {Math.Round(Math.Abs(chiki2 - chiki1) / Math.Abs(chiki2) * 100)}%>";
            RelV.Text = $"{briki2} <Error = {Math.Round(Math.Abs(briki2 - briki1) / Math.Abs(briki2) * 100, 2)}%>";

            RelC.Text = Cs < hit ? $"{Cs} < {hit}  is {false}" : $"{Cs} > {hit}  is {true}";
        }
    }
}