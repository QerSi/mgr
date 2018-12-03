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
                    v_arg[i] = (double.Parse(v_wiersz[i])); 
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
                MessageBox.Show(miara.ToString());
            }
            return klasyf;
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            if (Decyzje.Count < 1)
            {
                MessageBox.Show("Nie wczytano danych");
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
                default:
                    MessageBox.Show(cbMiary.SelectedIndex.ToString());
                    break;
            }
            //tutaj wywołanie porównania do miary
        }
    }
}
