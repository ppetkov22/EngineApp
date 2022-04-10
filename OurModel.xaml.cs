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
    /// Interaction logic for OurModel.xaml
    /// </summary>
    public partial class OurModel : Window
    {
        private readonly MainWindow mainWindow;

        public OurModel(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
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
