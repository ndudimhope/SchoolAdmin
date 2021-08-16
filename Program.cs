using SchoolAdmin.Ado.Net_Demo.DTO;
using SchoolAdmin.Ado.Net_Demo.SqlDataService;
using System;

namespace SchoolAdmin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the TeacherService class
            TeacherService teacherService = new TeacherService();

            // Define and insert Teacher objects
            TeacherDTO teacher1 = new TeacherDTO() { FirstName = "Mustapha", MiddleName = "", LastName = "Rufai", Subject = "JavaScript" };
            TeacherDTO teacher2 = new TeacherDTO() { FirstName = "Frank", MiddleName = "", LastName = "Legborsi", Subject = "DevOps" };
            TeacherDTO teacher3 = new TeacherDTO() { FirstName = "John", MiddleName = "Tony", LastName = "Ubi", Subject = "Product Design" };
            TeacherDTO teacher4 = new TeacherDTO() { FirstName = "Tonia", MiddleName = "Seyi", LastName = "Adegbite", Subject = "Python" };
            teacherService.Insert(teacher1);
            teacherService.Insert(teacher2);
            teacherService.Insert(teacher3);
            teacherService.Insert(teacher4);
        }
    }
}
