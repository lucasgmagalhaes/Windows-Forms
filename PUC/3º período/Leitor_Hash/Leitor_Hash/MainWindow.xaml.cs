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

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnopen_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == true)
            {
                using (StreamReader read = new StreamReader(open.FileName))
                {
                    string line;
                    while ((line = read.ReadLine()) != null)
                    {
                        string[] spt = line.Split(';');
                        Passageiro aux = new Passageiro(spt[0], spt[1]);
                        aux.Reservas = new List<string>();
                        passageiros.Add(aux);
                    }
                    listpassageiros.ItemsSource = passageiros;               
                }
            }
        }
    }
}
