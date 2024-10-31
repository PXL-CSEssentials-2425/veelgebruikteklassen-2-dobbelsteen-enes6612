using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace dobbelsteen
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

        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);
            int worp = 0;
            resultTextBox.Text = "";

            do
            {
                randomNumber = random.Next(1, 7);
                worp++;
                resultTextBox.AppendText($"Worp {worp} geeft {randomNumber}\r\n");

            } while (randomNumber != 6);
        }

        private void againButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
            startButton.Focus();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}