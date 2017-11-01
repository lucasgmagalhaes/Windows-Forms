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
        private TabelaHash table;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnopen_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == true)
            {
                txtfile.Text = open.FileName;
                if (System.IO.Path.GetFileNameWithoutExtension(open.FileName).ToUpper() == "PASSAGEIROS")
                {
                    table = new TabelaHash(1600);
                    using (StreamReader read = new StreamReader(open.FileName))
                    {
                        string line;
                        while ((line = read.ReadLine()) != null)
                        {
                            string[] spt = line.Split(';');
                            Passageiro aux = new Passageiro(spt[0], spt[1]);
                            passageiros.Add(aux);
                            table.Inserir(aux);
                        }
                        listpassageiros.ItemsSource = passageiros;
                    }
                }
                else if (System.IO.Path.GetFileNameWithoutExtension(open.FileName).ToUpper() == "RESERVAS")
                {
                    using (StreamReader read = new StreamReader(open.FileName))
                    {
                        string line;
                        while ((line = read.ReadLine()) != null)
                        {
                            string[] spt = line.Split(';');
                            Passageiro aux = table.Buscar(spt[0]);
                            if(aux != null)
                            {
                                aux.Reservas.Add(spt[1]);
                            }
                        }
                        listpassageiros.ItemsSource = passageiros;
                    }
                }
            }
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void txtsearch_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            expander.ExpandDirection = ExpandDirection.Down;
            expander.IsExpanded = true;
        }
    }
}
