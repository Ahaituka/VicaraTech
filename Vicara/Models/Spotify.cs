using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vicara.Models
{
    public class Spotify
    {
        public int GestureBackground { get; set; }
        public string GestureName { get; set; }
        public string GestureAction { get; set; }
        public string CoverImage { get; set; }
    }

    public class SpotifyManager
    {
        public static List<Spotify> GetGestures()
        {
            var gestures = new List<Spotify>();

            gestures.Add(new Spotify { GestureBackground = 1, GestureName = "Vulpate", GestureAction = "Futurum", CoverImage="Assets/1.png" });
            gestures.Add(new Spotify { GestureBackground = 2, GestureName = "Mazim", GestureAction = "Sequiter Que", CoverImage = "Assets/2.png" });
            gestures.Add(new Spotify { GestureBackground = 3, GestureName = "Elit", GestureAction = "Tempor", CoverImage = "Assets/3.png" });
            gestures.Add(new Spotify { GestureBackground = 4, GestureName = "Etiam", GestureAction = "Option", CoverImage = "Assets/4.png" });
            gestures.Add(new Spotify { GestureBackground = 5, GestureName = "Feugait Eros Libex", GestureAction = "Accumsan", CoverImage = "Assets/5.png" });
            gestures.Add(new Spotify { GestureBackground = 6, GestureName = "Nonummy Erat", GestureAction = "Legunt Xaepius", CoverImage = "Assets/6.png" });
            gestures.Add(new Spotify { GestureBackground = 7, GestureName = "Nostrud", GestureAction = "Eleifend", CoverImage = "Assets/7.png" });
            gestures.Add(new Spotify { GestureBackground = 8, GestureName = "Per Modo", GestureAction = "Vero Tation", CoverImage = "Assets/8.png" });
            gestures.Add(new Spotify { GestureBackground = 9, GestureName = "Suscipit Ad", GestureAction = "Jack Tibbles", CoverImage = "Assets/9.png" });
            gestures.Add(new Spotify { GestureBackground = 10, GestureName = "Decima", GestureAction = "Tuffy Tibbles", CoverImage = "Assets/10.png" });
            gestures.Add(new Spotify { GestureBackground = 11, GestureName = "Erat", GestureAction = "Volupat", CoverImage = "Assets/11.png" });
            gestures.Add(new Spotify { GestureBackground = 12, GestureName = "Consequat", GestureAction = "Est Possim", CoverImage = "Assets/12.png" });
            gestures.Add(new Spotify { GestureBackground = 13, GestureName = "Aliquip", GestureAction = "Magna", CoverImage = "Assets/13.png" });

            return gestures;
        }
    }
}
