using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathApp
{
    
    class User
    {
        public string name { get; set; }
        public int age { get; set; }
        public int additionScore { get; set; }
        public int subtractionScore { get; set; }
        public int multiplicationScore { get; set; }
        public int divisionScore { get; set; }

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        
    }
}
