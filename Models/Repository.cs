using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TasksModule.Models
{
    public static class Repository
    {
        private static List<MyTask> myTasks = new List<MyTask>();

        public static IEnumerable<MyTask> MyTasks
        {
            get
            {
                return myTasks;
            }
        }

        public static void AddTasks(MyTask myTask)
        {
            myTasks.Add(myTask);
        }
    }
}
