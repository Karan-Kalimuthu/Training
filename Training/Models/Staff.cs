using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Training.Models
{
    public class StaffDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public string Address { get; set; }
        public string Cource { get; set; }
    }

    public class StaffProgram
    {
        public List<StaffDTO> GetStaff()
        {
            using (TrainingEntities db = new TrainingEntities())
            {
                List<StaffDTO> data = null;
                data = db.Staffs.Select(d => new StaffDTO
                {
                    ID = d.ID,
                    Name = d.Name,
                    Age = d.Age,
                    Address = d.Address,
                    Cource = d.Cource 
                }).ToList();

                return data.ToList();
            }
        }

        //public string InsertData(string Name, int Age, string Address, string Cource)
        //{
        //    try
        //    {
        //        using (TrainingEntities db = new TrainingEntities())
        //        {
        //            if (!db.Staffs.Any(x=> x.Name == Name && x.Age == Age && x.Address == Address))
        //            {
        //                Staff data = new Staff();
        //                data.Name = Name;
        //                data.Age = Age;
        //                data.Address = Address;
        //                data.Cource = Cource;
        //                db.Staffs.Add(data);
        //                db.SaveChanges();
        //                return "Data Added Successfully!";
        //            }
        //            else
        //            {
        //                return "This Staff Already Exsits!";
        //            }
                    
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;
        //    }
        //}
    }

   
}
