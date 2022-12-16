using System;
using System.Collections.Generic;
using System.Text;

namespace Pet
{
    class Pet
    {     
        public string Name { get; set; }
        public string Type { get; set; }

        public int Age { get; set; }
        
        public Pet()
        {
        }

        public Pet(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }
    }
}
