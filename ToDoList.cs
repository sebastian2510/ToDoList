using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    internal class ToDo
    {
        public DateTime Created { get; set; }
        public DateTime? Deadline { get; set; }
        public string Todo { get; set; }
        public string Description { get; set; } 

        public ToDo()
        {
            Created = DateTime.Now; // Set the created date to now
        }
    }
}
