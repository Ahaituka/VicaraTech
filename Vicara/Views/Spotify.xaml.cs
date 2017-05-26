using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Vicara.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Vicara.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Vicara.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Spotify : Page
    {
        private List<Models.Spotify> Books;

        #region Properties
        public ObservableCollection<SpotifyViewModel> spotify = new ObservableCollection<SpotifyViewModel>();
        #endregion


        public Spotify()
        {
            Books = SpotifyManager.GetGestures();

          //  SpotifyViewModel.FillSpotify(spotify);
       //     this.DataContextChanged += (s, e) => Bindings.Update();

          //  this.InitializeComponent();
        }
    }
}
