namespace Software.Models
{
    internal class HeadphoneSettings
    {
        public int MaxVolume { get; set; }
        public int VolumeBalance { get; set; }
        public int TrebleGain { get; set; }
        public int TrebleLimitFreq { get; set; }
        public int BassGain { get; set; }
        public int BassLimitFreq { get; set; }
        public bool SpatialEffect { get; set; }

        public HeadphoneSettings() { }

        public HeadphoneSettings(int maxVolume, int volumeBalance, int trebleGain, int trebleLimitFreq,
                                 int bassGain, int bassLimitFreq, bool spatialEffect)
        {
            MaxVolume = maxVolume;
            VolumeBalance = volumeBalance;
            TrebleGain = trebleGain;
            TrebleLimitFreq = trebleLimitFreq;
            BassGain = bassGain;
            BassLimitFreq = bassLimitFreq;
            SpatialEffect = spatialEffect;
        }

        public override string ToString()
        {
            return $"MaxVol: {MaxVolume}, Balance: {VolumeBalance}, " +
                   $"Treble: {TrebleGain}dB @ {TrebleLimitFreq}kHz, " +
                   $"Bass: {BassGain}dB @ {BassLimitFreq * 10}Hz, " +
                   $"Spatial: {SpatialEffect}";
        }
    }
}