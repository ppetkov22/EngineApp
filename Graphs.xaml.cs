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
using System.Windows.Shapes;

namespace EngineApp
{
    /// <summary>
    /// Interaction logic for Graphs.xaml
    /// </summary>
    public partial class Graphs : Window
    {
        private readonly MainWindow mainWindow;

        public Graphs(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Hide();
            this.mainWindow.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.mainWindow.Close();
        }
    }
}
