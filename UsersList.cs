using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    //for this exercise I will need Linq, .Find() and System.IO (system mi serve per scrivere nel file)
    class UsersList
    {
        public List<User> Users { get; set; }

        public UsersList()
        {
            Users = new List<User>();
        }

        public void Add(User user)
        {
            Users.Add(user);
        }

        public void List()
        {
            Console.WriteLine("The following users are in the list:");
            foreach (User user in this.Users)
            {
                Console.WriteLine($"- {user.Name}");
            }
            Console.WriteLine("\n");
        }

        public UsersList Filtering(char target)
        {
            UsersList result = new UsersList();
            foreach(User user in this.Users)
            {
                string lower = user.Name.ToLower();
                string upper = user.Name.ToUpper();
                if (lower.Contains(target))
                {
                    result.Add(user);
                } else if (upper.Contains(target))
                {
                    result.Add(user);
                }
            }
            return result;
        }

        public void WriteToFile()
        {
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt"), true))
            {
                foreach(User user in this.Users)
                outputFile.WriteLine($"{user.Name}");
            }
        }

    }
}
