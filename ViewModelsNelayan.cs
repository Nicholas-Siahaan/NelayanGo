// ViewModels/FishermanViewModel.cs
using NelayanGo.Models;
using NelayanGo.DataServices;
using System.ComponentModel; // Penting untuk INotifyPropertyChanged
using System.Runtime.CompilerServices;

namespace NelayanGo.ViewModels
{
    // INotifyPropertyChanged memberitahu UI bahwa data telah berubah
    public class ViewModelsNelayan : INotifyPropertyChanged
    {
        private Nelayan _currentNelayan;
        public event PropertyChangedEventHandler PropertyChanged;

        private DataServiceNelayan _dataService = new DataServiceNelayan();

        public Nelayan CurrentNelayan
        {
            get { return _currentNelayan; }
            set
            {
                _currentNelayan = value;
                OnPropertyChanged(nameof(CurrentNelayan));
            }
        }

        public ViewModelsNelayan()
        {
            // Ambil data nelayan dengan kode TGL-32 saat ViewModel dibuat
            LoadDataNelayan("TGL-32");
        }

        private void LoadDataNelayan(string kode)
        {
            // Panggil Data Service untuk mengambil data dari DB
            CurrentNelayan = _dataService.GetDataNelayan(kode);

            // Jika gagal, isi dengan data default/error untuk sementara
            if (CurrentNelayan == null)
            {
                CurrentNelayan = new Nelayan { Nama = "Data Tidak Ditemukan", KodeIdentik = kode };
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}