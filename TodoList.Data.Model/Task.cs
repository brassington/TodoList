using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Data.Model
{
    public class Task
    {
        public int TaskId { get; set; }

        public int CategoryId { get; set; }

        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime TaskBegin { get; set; }
        public DateTime TaskEnd { get; set; }

        public virtual List<Category> Categories { get; set; }
    }
}
