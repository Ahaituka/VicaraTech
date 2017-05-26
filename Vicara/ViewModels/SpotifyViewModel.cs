using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vicara.ViewModels
{
    public class SpotifyViewModel
    {
        public string Name;
        public string CoverImage;

        public SpotifyViewModel()
        {
            Name = "Swipe Right";
            CoverImage = "ms-appx:///Assets/Logo.jpg";
        }

        public static void FillSpotify( ObservableCollection<SpotifyViewModel> spotfiy )
        {
            spotfiy.Add(new SpotifyViewModel());
            spotfiy.Add(new SpotifyViewModel());
            spotfiy.Add(new SpotifyViewModel());
            spotfiy.Add(new SpotifyViewModel());

        }

    }
}

