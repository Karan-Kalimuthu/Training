using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Training.Models
{
    public class ClassDTO
    {
        public int ID { get; set; }
        public string Class_Name { get; set; }
        public Nullable<System.DateTime> Class_Data { get; set; }
        public Nullable<bool> Status { get; set; }
    }

    public class ClassProgram
    {
        public List<ClassDTO> GetClasses()
        {
            using (TrainingEntities db = new TrainingEntities())
            {
                List<ClassDTO> data = null;
                data = db.Classes.Select(d => new ClassDTO
                {
                    ID=d.ID,
                    Class_Name=d.Class_Name,
                    Class_Data=d.Class_Data,
                    Status=d.Status
                }).ToList();
                return data.ToList();
            }
        }
    }
}