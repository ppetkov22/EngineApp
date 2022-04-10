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

namespace EngineApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OurModel ourModel;
        private Progress progress;
        private Graphs graphs;
        private TheEngine theEngine;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.progress == null)
            {
                this.progress = new Progress(this);
            }

            this.Hide();
            this.progress.Show();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.graphs == null)
            {
                this.graphs = new Graphs(this);
            }

            this.Hide();
            this.graphs.Show();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (this.ourModel == null)
            {
                this.ourModel = new OurModel(this);
            }

            this.Hide();
            this.ourModel.Show();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (this.theEngine == null)
            {
                this.theEngine = new TheEngine(this);
            }

            this.Hide();
            this.theEngine.Show();
        }

    }
}
