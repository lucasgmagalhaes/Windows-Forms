using Microsoft.Win32;
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
using System.IO;
using Leitor_Contas.Classes;
namespace Leitor_Contas
{
    public class DataItem
    {
        public string Column1 { get; set; }
        public string Column2 { get; set; }
        public string Column3 { get; set; }
        public string Column4 { get; set; }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Arvore tree = new Arvore();
        private void btnopenfile_OnClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            bool? get = openfile.ShowDialog();
            if (get ?? false && Path.GetExtension(openfile.FileName) == "txt")
            {
                txtnamefile.Text = openfile.FileName;
                using(StreamReader read = new StreamReader(openfile.FileName))
                {
                    string line;
                    while ((line = read.ReadLine()) != null)
                    {
                        string[] spt = line.Split(';');
                        string cpf = spt[1];
                        cpf = cpf.Replace(".", "").Replace("-", "");
                        Titular pessoa = new Titular(spt[1]);
                        if(spt[2] == "1") pessoa.AddConta(new Energia(Convert.ToInt32(spt[0]), 0, 0, 0));
                        else pessoa.AddConta(new Agua(Convert.ToInt32(spt[0]), 0, 0, 0));
                        tree.Inserir(pessoa);
                        dataBills.Items.Add(pessoa);
                    }
                }
            }
        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
