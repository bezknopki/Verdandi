using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class MediaModel
    {
        public int MediaId { get; set; }

        public string Title { get; set; }

        public TimeSpan Duration { get; set; }

        public TimeSpan StartFrom { get; set; }
    }
}
