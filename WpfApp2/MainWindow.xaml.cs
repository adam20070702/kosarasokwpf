using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kosarlabda
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public class Jatekos
    {
        public string JatekosNeve { get; set; } = "";
        public string Csapat { get; set; } = "";
        public int LejatszottMeccsek { get; set; }
        public int PontAtlag { get; set; }
        public int LepattanoAtlag { get; set; }
        public int HatekonysagiMutato
        {
            get { return PontAtlag + LepattanoAtlag; }
        }

        public Jatekos(string nev, string csapat, int meccsek, int pont, int lepatto)
        {
            JatekosNeve = nev;
            Csapat = csapat;
            LejatszottMeccsek = meccsek;
            PontAtlag = pont;
            LepattanoAtlag = lepatto;
        }
    }

    public partial class MainWindow : Window
    {
        List<Jatekos> lista = new List<Jatekos>();

        public MainWindow()
        {
            InitializeComponent();

            lista.Add(new Jatekos("Zsótér Máté", "Falco KC Szombathely", 22, 15, 5));
            lista.Add(new Jatekos("György Ákos", "Falco KC Szombathely", 20, 12, 4));
            lista.Add(new Jatekos("Bognár Tamás", "Alba Fehérvár", 21, 18, 6));
            lista.Add(new Jatekos("Váradi Dávid", "Alba Fehérvár", 19, 14, 7));
            lista.Add(new Jatekos("Hortobágyi Márk", "PVSK-Pannonpower", 22, 16, 5));
            lista.Add(new Jatekos("Pásztor Dávid", "PVSK-Pannonpower", 18, 10, 3));
            lista.Add(new Jatekos("Szabó Péter", "Sopron KC", 20, 20, 8));
            lista.Add(new Jatekos("Kiss Ádám", "Sopron KC", 21, 17, 6));
            lista.Add(new Jatekos("Nagy Levente", "DEAC", 19, 13, 5));
            lista.Add(new Jatekos("Tóth Bence", "DEAC", 22, 19, 7));
            lista.Add(new Jatekos("Farkas Máté", "ZTE KK", 20, 21, 9));
            lista.Add(new Jatekos("Kovács Balázs", "ZTE KK", 21, 16, 6));
            lista.Add(new Jatekos("Szalai Kristóf", "Falco KC Szombathely", 18, 14, 4));
            lista.Add(new Jatekos("Vincze Dániel", "Alba Fehérvár", 22, 22, 8));
            lista.Add(new Jatekos("Molnár Dávid", "Sopron KC", 17, 11, 5));

            tabla.ItemsSource = lista;
        }

        // sorok színezése
        private void tabla_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            Jatekos j = e.Row.Item as Jatekos;
            if (j == null)
            {
                return;
            }

            if (j.HatekonysagiMutato < 20)
            {
                e.Row.Background = Brushes.LightCoral;
            }
            else if (j.HatekonysagiMutato >= 25)
            {
                e.Row.Background = Brushes.LightGreen;
            }
            else
            {
                e.Row.Background = Brushes.White;
            }
        }
    }
}