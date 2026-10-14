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
using _6TTI_DPMael_WPFMultiPage.Views;

namespace _6TTI_DPMael_WPFMultiPage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainFrame.Content = new Accueil();
            btnPage1.Click += BtnPage1_Click;
            btnPage2.Click += BtnPage2_Click;
        }

        private void BtnPage2_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new Page2();
        }

        private void BtnPage1_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Content = new Page1();
        }
    }
}