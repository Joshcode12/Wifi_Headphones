namespace Software.Models
{
    internal class TrackInfo(string title, string artists, string album, TimeSpan duration)
    {
        public string Title { get; set; } = title;
        public string Artists { get; set; } = artists;
        public string Album { get; set; } = album;
        public TimeSpan Duration { get; set; } = duration;

        public override string ToString()
        {
            return $"{Title} - {Artists} ({Album}) [{Duration:mm\\:ss}]";
        }
    }
}
