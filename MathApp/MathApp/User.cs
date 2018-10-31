using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    /// <summary>
    /// Class for storing user information.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Users name.
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// Users age.
        /// </summary>
        public int age { get; set; }

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        
    }
}
