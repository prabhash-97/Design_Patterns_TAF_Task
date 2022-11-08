using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_example
{
    internal class Admin : HomePge
    {
        public void GoToPage()
        {
            Console.WriteLine("Go to the Home Page");
        }
        public void Signup()
        {
            Console.WriteLine("Sign up as a admin");
        }
        public void IsSignupSuccessful()
        {
            Console.WriteLine("Form Submitted Successfully...");
        }
        public void IsTitleExists()
        {
            Console.WriteLine("Title is Exists");
        }
        public void Title()
        {
            Console.WriteLine("You're in Admin View Site");
        }
        
    }
}
