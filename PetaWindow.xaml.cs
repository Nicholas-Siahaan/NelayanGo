using System.Windows;
using NelayanGo.ViewModels;

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
    }
}