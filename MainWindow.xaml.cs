using MaterialDesignThemes.Wpf;
using System.Windows;

namespace ColorZoneBug
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

        private void txbCut_Loaded(object sender, RoutedEventArgs e)
        {
            ShadowAssist.SetShadowDepth(colorZone, ShadowDepth.Depth0);
        }
    }
}
