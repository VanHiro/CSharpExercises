using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    class User
    {
        private string _name;
        private int _age;
        public string Name { get; set; }
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 18)
                {
                    _age = value;
                }
            }
        }

        public User(string _name, int _age)
        {
            this.Name = _name;
            this.Age = _age;
        }

        public void Show()
        {
            Console.WriteLine($"The selected user is: {Name} and the age is {Age}.");
        }
    }
}
