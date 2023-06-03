namespace DAL.Entities
{
    public class MediaEntity
    {
        public int MediaId { get; set; }

        public string Title { get; set; }

        public TimeSpan Duration { get; set; }

        public TimeSpan StartFrom { get; set; }

        public string MediaPath { get; set; }

        public override string ToString() => Title;
    }
}
