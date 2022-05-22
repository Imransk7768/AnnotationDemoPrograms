using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationDemo
{
    public class AnnotationTest
    {
        public static void Display()
        {
            Console.WriteLine("Employee Class Validation");
            Employee objemployee = new Employee();

            Console.Write("Enter Name : ");
            objemployee.Name = Console.ReadLine();
            Console.Write("Enter Age : ");
            objemployee.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Mobile : ");
            objemployee.MobileNumber = Convert.ToInt64(Console.ReadLine());
            Console.Write("Enter Email : ");
            objemployee.Email = Console.ReadLine();

            ValidationContext context = new ValidationContext(objemployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objemployee, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult totalresult in results)
                {
                    Console.WriteLine("Member Name : {0}", totalresult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Message : : {0}{1}", totalresult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("Name : " + objemployee.Name + "\nAge : " + objemployee.Age + "\nMobile : " + objemployee.MobileNumber + "\nEmail : " + objemployee.Email);
            }
            Console.WriteLine("Press Any Key To Exit.");
        }
    }
}
