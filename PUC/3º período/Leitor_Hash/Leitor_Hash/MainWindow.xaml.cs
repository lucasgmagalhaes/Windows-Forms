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
using Leitor_Hash.Classes;
using Microsoft.Win32;
using System.IO;

namespace Leitor_Hash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Passageiro> passageiros = new List<Passageiro>();
        List<Valores> val = new List<Valores>();
        StreamWriter write = new StreamWriter("infos.txt", false);
        List<int> vals = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Saveinfos(int val)
        {
            vals.Add(val);
        }
        private void btnopen_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == true)
            {
                TabelaHash table = new TabelaHash(1600);
                using (StreamReader read = new StreamReader(open.FileName))
                {
                    string line;
                    while ((line = read.ReadLine()) != null)
                    {
                        string[] spt = line.Split(';');
                        Passageiro aux = new Passageiro(spt[0], spt[1]);
                        passageiros.Add(aux);
                        int get = table.GetPosition(spt[0]);
                        Saveinfos(get);
                    }
                    listpassageiros.ItemsSource = passageiros;
                    vals.Sort();
                    foreach (int val in vals) write.WriteLine(val);
                }
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            int i = 21320 % 2100;
        }
    }
}
