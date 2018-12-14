using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PracaMgr
{

    public partial class OknoGlowne : Form
    {
        List<double[]> Obiekty = new List<double[]>();
        List<int> Decyzje = new List<int>();
        List<int> DecyzjeObliczone = new List<int>();
        double Miara = 0;
        public OknoGlowne()
        {
            InitializeComponent();
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnWczytajPlik_Click(object sender, EventArgs e)
        {
            opfWczytaj.Filter = "CSV|*.csv";
            opfWczytaj.Title = "Wybierz plik";

            if (opfWczytaj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    txtSciezka.Text = opfWczytaj.FileName;
                    Obiekty.Clear();
                    Decyzje.Clear();
                    WczytajDane(opfWczytaj.FileName);
                }
                catch
                {
                    MessageBox.Show("Bład odczytu pliku");
                    txtSciezka.Text = "";
                }
            }
        }

        private void WczytajDane(string p_sciezka)
        {
            StreamReader obiekty = new StreamReader(p_sciezka);
            while(!obiekty.EndOfStream)
            {
                string[] v_wiersz = obiekty.ReadLine().Split(',');
                double[] v_arg = new double[v_wiersz.Length-1];
                for (int i = 0; i < v_wiersz.Length-1; i++)
                {
                    v_arg[i] = (double.Parse(v_wiersz[i].Replace('.',','))); 
                }
                Obiekty.Add(v_arg);
                Decyzje.Add(int.Parse(v_wiersz.Last()));
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OknoGlowne_Load(object sender, EventArgs e)
        {
            InicjujCombo();
            txtMiara.Text = "0";
            cbMiary.SelectedIndex = 0;
        }

        private void InicjujCombo()
        {
            cbMiary.Items.Add("Średnia arytmetyczna");
            cbMiary.Items.Add("Maximum");
        }

        private double[] miaraSredniaArytmetyczna()
        {
            double[] klasyf = new double[Decyzje.Count+1];
            for (int i = 0; i < Obiekty.Count; i++)
            {
                double[] arg = Obiekty[i];
                double miara = 0;
                for (int j = 0; j < arg.Length; j++)
                {
                    miara += arg[j];  
                }
                miara = miara / arg.Length;
                klasyf[i] = miara;
               // MessageBox.Show(miara.ToString());
            }
            return klasyf;
        }

        private double[] miaraMaksimum()
        {
            double[] klasyf = new double[Decyzje.Count + 1];
            for (int i = 0; i < Obiekty.Count; i++)
            {
                double[] arg = Obiekty[i];
                klasyf[i] = arg.Max();
                // MessageBox.Show(miara.ToString());
            }
            return klasyf;
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            Miara = double.Parse(txtMiara.Text);
            if (Decyzje.Count < 1)
            {
                txtSciezka.Text = "Nie wczytano pliku";
                return;
            }
            else if (cbMiary.SelectedIndex < 0) 
            {
                MessageBox.Show("Nie wybrano miary");
                return;
            }

            double[] miary = new double[Decyzje.Count];
            switch (cbMiary.SelectedIndex)
            {
                case 0:
                    miary = miaraSredniaArytmetyczna();
                    break;
                case 1:
                    miary = miaraMaksimum();
                    break;
                default:
                    MessageBox.Show(cbMiary.SelectedIndex.ToString());
                    break;
            }

            for (int i = 0; i < miary.Length; i++)
            {
                if (miary[i] >= Miara)
                    DecyzjeObliczone.Add(1);
                else
                    DecyzjeObliczone.Add(0);
            }
            wyznaczmacierz();
            DecyzjeObliczone.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
            if (e.KeyChar == ',' && txtMiara.Text.IndexOf(",")!= -1)
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void wyznaczmacierz()
        {
            int truePositive = 0;
            int trueNegative = 0;
            int falseNegative = 0;
            int falsePositive = 0;

            for (int i = 0; i < Decyzje.Count; i++)
            {
                if (Decyzje[i] == 1 && DecyzjeObliczone[i] == 1)
                    truePositive++;
                else if (Decyzje[i] == 1 && DecyzjeObliczone[i] == 0)
                    falsePositive++;
                else if (Decyzje[i] == 0 && DecyzjeObliczone[i] == 0)
                    trueNegative++;
                else if (Decyzje[i] == 0 && DecyzjeObliczone[i] == 1)
                    falseNegative++;

                //MessageBox.Show("DEC: " + Decyzje[i].ToString() + " OBL: " + DecyzjeObliczone[i].ToString());
            }
            MessageBox.Show("TP: " + truePositive.ToString() + "\n" +
                "FP: " + falsePositive.ToString() + "\n" +
                "TN: " + trueNegative.ToString() + "\n" +
                "FN: " + falseNegative.ToString() + "\n");

            MacierzBledu okno = new MacierzBledu(truePositive,trueNegative,falsePositive,falseNegative);
            okno.Show();
        }

        private void txtMiara_TextChanged(object sender, EventArgs e)
        {
            if (txtMiara.Text != "" && float.Parse(txtMiara.Text)>1)
            {
                txtMiara.Text = "1";
            }
        }
    }
}
