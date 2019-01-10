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
                    WczytajDane(opfWczytaj.FileName);
                }
                catch
                {
                    MessageBox.Show("Bład wczytania danych");
                    txtSciezka.Text = "";
                }
            }
        }

        private void WczytajDane(string p_sciezka)
        {
            StreamReader obiekty = new StreamReader(p_sciezka);
            while(!obiekty.EndOfStream)
            {
                string[] v_wiersz = obiekty.ReadLine().Split(';');
                double[] v_arg = new double[v_wiersz.Length];
                for (int i = 0; i < v_wiersz.Length; i++)
                {
                    v_arg[i] = (double.Parse(v_wiersz[i]));
                }
                Obiekty.Add(v_arg);
            }
        }

        private void WczytajDecyzje(string p_sciezka)
        {
            StreamReader obiekty = new StreamReader(p_sciezka);
            while (!obiekty.EndOfStream)
            {
                string[] v_wiersz = obiekty.ReadLine().Split(';');
                Decyzje.Add(int.Parse(v_wiersz.Last()));
            }
        }

        private void btnOblicz_Click(object sender, EventArgs e)
        {
            string blad = walidujDane();
            if (blad == "")
                generujZestawienie();
            else
                MessageBox.Show(blad);
        }

        private string walidujDane()
        {
            string blad = "";
            if (Decyzje.Count != Obiekty.Count)
                blad = "Nieprawidłowe dane";
            if (Decyzje.Count == 0)
                blad = "Brak decyzji";
            if (Obiekty.Count == 0)
                blad = "Brak macierzy przynależności";


            return blad;
        }

        private List<MecierzBledu> generujMiary()
        {
            List<MecierzBledu> miary = new List<MecierzBledu>();
            double[] miara = new double[Decyzje.Count];
            for (int i = 0; i < Obiekty.First().Length; i++)
            {
                miara = new double[Decyzje.Count];
                for (int k = 0; k < Obiekty.Count; k++)
                {
                    miara[k] = Obiekty[k][i];
                }
                miary.Add(new MecierzBledu(miara,Decyzje));
            }

            return miary;
        }

        private void generujZestawienie()
        {
            double Lambda = 0;
            List<double[]> wynik = new List<double[]>();
            List<MecierzBledu> miary = generujMiary();

            for (float i = 0; i < 11; i++)
            {
                double[] wynikMiar = new double[Obiekty[1].Length];
                Lambda = Math.Round(i/10,2);

                for (int j = 0; j < miary.Count; j++)
                {
                    miary[j].wyznaczMacierzBledu(Lambda);
                    wynikMiar[j] = miary[j].wyliczAcc();
                }
                wynik.Add(wynikMiar);
            }
            zapiszDoCsv(wynik);
        }

        private void zapiszDoCsv(List<double[]> wyniki)
        {
            StringBuilder sb = new StringBuilder();
            double index = 0;
            string kolumny = generujNazwyKolumn(wyniki[1].Count());
            sb.AppendLine(kolumny);
            foreach (var item in wyniki)
            {
                string str = (index / 10).ToString("0.0");
                foreach (double linia in item)
                {
                    str = str +";"+linia.ToString("0.00");    
                }
                index++;
                sb.AppendLine(str);
            }

            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.FileName = "wynik";
                dlg.DefaultExt = "csv";
                dlg.ValidateNames = true;

                dlg.Filter = "CSV (.csv)|*.csv";

                if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.WriteAllText(dlg.FileName, sb.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Bład zapisu pliku");
            }

        }

        private string generujNazwyKolumn(int liczbaKolumn)
        {
            string wynik = "lambda";
            for (int i = 0; i < liczbaKolumn; i++)
            {
                wynik = wynik + ";M" + (i+1); 
            }
            return wynik;
        }

        private void btDecyzje_Click(object sender, EventArgs e)
        {
            opfWczytaj.Filter = "CSV|*.csv";
            opfWczytaj.Title = "Wybierz plik";

            if (opfWczytaj.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    txtDecyzje.Text = opfWczytaj.FileName;
                    Decyzje.Clear();
                    WczytajDecyzje(opfWczytaj.FileName);
                }
                catch
                {
                    MessageBox.Show("Bład wczytania decyzji");
                    txtDecyzje.Text = "";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
