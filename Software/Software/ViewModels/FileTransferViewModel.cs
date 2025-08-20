using Software.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Software.ViewModels
{
    internal class FileTransferViewModel : ViewModelBase
    {
        private readonly ObservableCollection<TrackViewModel> _tracks;

        public IEnumerable<TrackViewModel> Tracks => _tracks;

        public ICommand? SelectMusicCommand { get; }
        public ICommand? TransferMusicCommand { get; }

        public FileTransferViewModel()
        {
            _tracks = [];
        }
    }
}
