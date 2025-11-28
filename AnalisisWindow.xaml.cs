using NelayanGo.Helpers;
using System.Windows;
using System.Windows.Input;

namespace NelayanGo
{
    /// <summary>
    /// Interaction logic for AnalisisWindow.xaml
    /// </summary>
    public partial class AnalisisWindow : Window
    {
        public AnalisisWindow()
        {
            InitializeComponent();
        }
        private void HomeLink_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            // Cukup panggil helper, dan berikan tujuan sebagai string
            //NavigationHelper.NavigateFromHeaderClick(sender, "Home");
            var analisisWindow = new AnalisisWindow();
            analisisWindow.Show();

            this.Close();
        }
        private void MapsLink_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var petaWindow = new PetaWindow();
            petaWindow.Show();
            this.Close();
        }

        private void HargaPasar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var hargaPasarWindow = new HargaPasarWindow();
            hargaPasarWindow.Show();
            this.Close();
        }

        private void HasilTangkapanLink_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var DaftarTangapanWindow = new DaftarTangapanWindow();
            DaftarTangapanWindow.Show();
            this.Close();
        }
    }
    
}