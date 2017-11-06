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

namespace Ordenador
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private static Random RAM = new Random();
        private List<int> valores = new List<int>();
        private void btngerar_Click(object sender, RoutedEventArgs e)
        {
            if (listvalores.Items.Count > 0)
            {
                valores.Clear();
                listvalores.Items.Refresh();
            } 
            for (int i = 0; i < int.Parse(txtfrom.Text); i++) valores.Add(RAM.Next(i, int.Parse(txtfrom.Text)));
            listvalores.ItemsSource = valores;
        }
    }
}
