using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Models
{
    public class TaskModel
    {
        public int TaskId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public TimeSpan ExpectedCompletionTime { get; set; }

        public DateTime CreatedDate { get; }

        public DateTime DateStart { get; set; }

        public string VideoPath { get; set; }

        public MediaModel Media { get; set; }
    }
}