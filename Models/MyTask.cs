using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TasksModule.Models
{
    public class MyTask
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter the task name")]
        public string TaskName { get; set; }
        [Required(ErrorMessage = "Please enter the task description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Please select a date")]
        public DateTime? DueDate { get; set; }
       
        public bool? Assigned { get; set; }

        public MyTask()
        {

        }
    }
}
