using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Training.Models
{
    public class StudentDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public string Address { get; set; }
        public string Cource { get; set; }
    }

    public class StudentProgram
    {
        public List<StudentDTO> GetStudent()
        {
            using (TrainingEntities db =new TrainingEntities())
            {

                List<StudentDTO> data = null;

                data = db.Students.Select(d => new StudentDTO
                {
                    ID=d.ID,
                    Age =d.Age,
                    Cource=d.Cource,
                    Address=d.Address,
                    DOB =d.DOB,
                    Name=d.Name
                }).ToList();

                return data.ToList();
            }
        }

        //public string Insertdata(int Age,string Name,DateTime DOB,string Address,string Course)
        //{

        //    try
        //    {
        //        using (TrainingEntities db =new TrainingEntities())
        //        {
        //            if (!db.Students.Any(x=>x.DOB == DOB && x.Name == Name))
        //            {
        //                Student data = new Student();
        //                data.Address = Address;
        //                data.Age = Age;
        //                data.DOB = DOB;
        //                data.Name = Name;
        //                data.Cource = Course;
        //                db.Students.Add(data);
        //                db.SaveChanges();
        //                return "Inserted Successfuly!";
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