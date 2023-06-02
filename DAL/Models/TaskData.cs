namespace DAL.Models
{
    public class TaskData
    {
        public TaskData()
        {
            CreatedDate = DateTime.Now;
        }

        public int TaskDataId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public TaskStatus Status { get; set; }

        public TimeSpan ExpectedCompletionTime { get; set; }

        public TimeSpan FactCompletionTime { get; set; }

        public DateTime CreatedDate { get; }

        public DateTime DateStart { get; set; }

        public int MediaId { get; set; }

        public Media Media { get; set; }

        public bool OpenVideoOnTaskStart { get; set; }

        public override string ToString() => Name;
    }
}