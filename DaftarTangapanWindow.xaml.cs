using NelayanGo.Helpers;
using System.Windows;
using System.Windows.Input;

namespace NelayanGo
{
    /// <summary>
    /// Interaction logic for DaftarTangapanWindow.xaml
    /// </summary>
    public partial class DaftarTangapanWindow : Window
    {
        public DaftarTangapanWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Menangani klik tombol "INPUT TANGKAPAN" dan membuka jendela input.
        /// </summary>
        private void InputTangapanButton_Click(object sender, RoutedEventArgs e)
        {
            // Pastikan Anda telah membuat InputTangapanWindow di proyek Anda
            var inputWindow = new InputTangapanWindow();
            inputWindow.Show();
            // Opsional: Sembunyikan jendela daftar ini
            // this.Hide();
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