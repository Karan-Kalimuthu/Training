using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Training.Models
{
    public class TaskDTO
    {
        public int ID { get; set; }
        public string Task_Name { get; set; }
        public Nullable<bool> Task_Status { get; set; }
        public Nullable<System.DateTime> Task_Date { get; set; }
    }

    public class TaskProgram
    {
        public List<TaskDTO> GetTask()
        {
            using (TrainingEntities db = new TrainingEntities())
            {
                List<TaskDTO> data = null;
                data = db.Tasks.Select(d => new TaskDTO
                {
                    ID=d.ID,
                    Task_Name=d.Task_Name,
                    Task_Date=d.Task_Date,
                    Task_Status=d.Task_Status
                }).ToList();
                return data.ToList();
            }
        }
    }
}