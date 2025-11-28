using System.Windows;
using NelayanGo.Helpers;
using System.Windows.Input;
using NelayanGo.ViewModels;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Controls;
using System.Xml.Linq;

namespace NelayanGo
{
    /// <summary>
    /// Interaction logic for PetaWindow.xaml
    /// </summary>
    // Pastikan x:Class di XAML cocok dengan nama kelas ini
    public partial class PetaWindow : Window
    {
        public PetaWindow()
        {
            // InitializeComponent() akan ditemukan setelah XAML (PetaWindow.xaml)
            // berhasil dikompilasi tanpa error styling (Padding/CornerRadius pada StackPanel).
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