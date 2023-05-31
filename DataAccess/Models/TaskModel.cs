namespace DAL.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public TimeSpan ExpectedCompletionTime { get; set; }

        public TimeSpan FactCompletionTime { get; set; }

        public DateTime CreatedDate { get; }

        public DateTime DateStart { get; set; }

        public int MediaId { get; set; }

        public MediaModel Media { get; set; }

        public bool OpenVideoOnTaskStart { get; set; }
    }
}