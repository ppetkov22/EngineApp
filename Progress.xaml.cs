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
    /// Interaction logic for Progress.xaml
    /// </summary>
    public partial class Progress : Window
    {
        private readonly MainWindow mainWindow;

        private BitmapSource[] images = new BitmapSource[] 
        {
            new BitmapImage(new Uri("pack://application:,,,/EngineApp;component/Screenshot (67).png", UriKind.Absolute)),
            new BitmapImage(new Uri("pack://application:,,,/EngineApp;component/EngineCapture.PNG", UriKind.Absolute)),
            new BitmapImage(new Uri("pack://application:,,,/EngineApp;component/Screenshot (68).png", UriKind.Absolute)),
            new TransformedBitmap( new BitmapImage(new Uri("pack://application:,,,/EngineApp;component/IMG_20220301_131650.jpg", UriKind.Absolute)), new RotateTransform(90)),
            new TransformedBitmap( new BitmapImage(new Uri("pack://application:,,,/EngineApp;component/IMG_20220225_093859.jpg" , UriKind.Absolute)) , new RotateTransform(90))
        };

        private int currentImage;

        public Progress(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 3);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            this.currentImage = (this.currentImage + 1) % images.Length;
            this.progressImage.Source = this.images[currentImage];
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
