using Software.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Software.ViewModels
{
    internal class TrackViewModel(TrackInfo trackInfo) : ViewModelBase
    {
        private readonly TrackInfo _trackInfo = trackInfo;

        public string Title => _trackInfo.Title;
        public string Artists => _trackInfo.Artists;
        public string Album => _trackInfo.Album;
        public TimeSpan Duration => _trackInfo.Duration;
    }
}
