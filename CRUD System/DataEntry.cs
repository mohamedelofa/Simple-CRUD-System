using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_System
{
    internal static class DataEntry
    {
        private static List<User> list;
        static DataEntry ()
        {
            list = new List<User> ();
        }
        public static void add ()
        {
            User newuser = getData();
            list.Add (newuser);
        }

        private static User getData()
        {
            string name;
            string telephone;
            string email;
            do
            {
                Console.Write("Enter User Name : ");
                name = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(name));
            do
            {
                Console.Write("Enter User Telephone : ");
                telephone = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(telephone));
            do
            {
                Console.Write("Enter User Email : ");
                email = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(email));
            User newuser = new User(name,telephone, email);
            return newuser;
        }

        public static bool isExist(string telephone ,ref User oldUser)
        {
            if(string.IsNullOrWhiteSpace(telephone) || list.Count == 0) return false;
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].Telephone == telephone)
                {
                    oldUser = list[i];
                    return true;
                }
                    
            }
            return false;
        }

        public static void updateUser(User oldUser)
        {
            User newUser = getData();
            oldUser.Name = newUser.Name;
            oldUser.Telephone = newUser.Telephone;
            oldUser.Email = newUser.Email;
        }

        public static void deleteUser(User oldUser)
        {
            list.Remove(oldUser);
        }

        public static void printUsers()
        {
            if(list.Count == 0)
            {
                Console.WriteLine("============================== There are no users to print ======================================");
            }
            else
            {
                Console.WriteLine("============================ All Users ================================");
                int cnt = 1;
                foreach (User user in list)
                {
                    Console.WriteLine($"user no {cnt} ==>  {user} ");
                    if (cnt != list.Count())
                        Console.WriteLine("==========================");
                    cnt++;
                }
                Console.WriteLine("============================ Users Are Printed ====================================");
            }
        }
    }
}

