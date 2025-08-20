using System.Windows.Input;

namespace Software.ViewModels
{
    internal class SettingsViewModel : ViewModelBase
    {
        public ICommand? SaveCommand { get; }
        public ICommand? ResetCommand { get; }

        private int _maxVolume;
        private int _volumeBalance;
        private int _trebleGain;
        private int _trebleLimitFreq;
        private int _bassGain;
        private int _bassLimitFreq;
        private bool _spatialEffect;

        public int MaxVolume
        {
            get => _maxVolume;
            set { _maxVolume = Math.Clamp(value, 0, 100); OnPropertyChanged(nameof(MaxVolume)); }
        }

        public int VolumeBalance
        {
            get => _volumeBalance;
            set { _volumeBalance = Math.Clamp(value, -50, 50); OnPropertyChanged(nameof(VolumeBalance)); }
        }

        public int TrebleGain
        {
            get => _trebleGain;
            set { _trebleGain = Math.Clamp(value, -8, 7); OnPropertyChanged(nameof(TrebleGain)); }
        }

        public int TrebleLimitFreq
        {
            get => _trebleLimitFreq;
            set { _trebleLimitFreq = Math.Clamp(value, 1, 15); OnPropertyChanged(nameof(TrebleLimitFreq)); }
        }

        public int BassGain
        {
            get => _bassGain;
            set { _bassGain = Math.Clamp(value, 0, 15); OnPropertyChanged(nameof(BassGain)); }
        }

        public int BassLimitFreq
        {
            get => _bassLimitFreq;
            set { _bassLimitFreq = Math.Clamp(value, 2, 15); OnPropertyChanged(nameof(BassLimitFreq)); }
        }

        public bool SpatialEffect
        {
            get => _spatialEffect;
            set { _spatialEffect = value; OnPropertyChanged(nameof(SpatialEffect)); }
        }

        public SettingsViewModel()
        {
            MaxVolume = 50;
            VolumeBalance = 0;
            TrebleGain = 0;
            TrebleLimitFreq = 15;
            BassGain = 0;
            BassLimitFreq = 20;
            SpatialEffect = true;
        }
    }
}
