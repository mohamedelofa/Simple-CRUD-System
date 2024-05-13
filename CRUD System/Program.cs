using System.ComponentModel;
using System.Xml.Serialization;

namespace CRUD_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Start();
            } while (exitOrNot());
            
        }

        static void Start()
        {
                int choice;
                Console.WriteLine("1.ADD User");
                Console.WriteLine("2.Update User");
                Console.WriteLine("3.Delete User");
                Console.WriteLine("4.Print Users");
                Console.WriteLine("======================================================");
                Console.Write("Enter Your Choice : ");
                while (!(int.TryParse(Console.ReadLine(), out  choice)) || choice > 4 || choice < 1) 
                {
                    Console.WriteLine("Wrong Choice");
                    Console.Write("Enter Your Choice : ");
                }
               switch(choice)
               {
               case 1:
                    addUser();
                    break;
               case 2:
                    UpdateUser();
                    break;
               case 3:
                    deleteUser();
                    break;
               case 4:
                    printUsers();
                    break;
               }
        }
        static void addUser()
        {
            Console.WriteLine("================================= Enter User Information ==================================");
            DataEntry.add();
            Console.WriteLine("================================= Added User Done =========================================");
        }

        static void printUsers()
        {
            DataEntry.printUsers();
        }
        static bool exitOrNot()
        {
            string choiceExitOrNot;
            do
            {
                Console.Write("Choose y to continue or n to exit : ");
                 choiceExitOrNot = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(choiceExitOrNot));
            if (choiceExitOrNot == "y")
                Console.WriteLine("======================================================");
            return choiceExitOrNot == "y";
        }
        static void UpdateUser()
        {
            string telephone;
            do
            {
                Console.Write("Enter User Telephone : ");
                telephone = Console.ReadLine();
            }while(string.IsNullOrWhiteSpace(telephone));
            User oldUser = default;
            if(DataEntry.isExist(telephone , ref oldUser))
            {
                Console.WriteLine("============================ Update User Information ====================================");
                DataEntry.updateUser(oldUser);
                Console.WriteLine("=========================== User Updated =================================");
            }
            else
            {
                Console.WriteLine("============================== This user is not exist =====================================");
            }
        }

        static void deleteUser()
        {
            string telephone;
            do
            {
                Console.Write("Enter User Telephone : ");
                telephone = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(telephone));
            User oldUser = default;
            if(DataEntry.isExist(telephone , ref oldUser))
            {
                DataEntry.deleteUser(oldUser);
                Console.WriteLine("================================== User Is Deleted ===========================================");
            }
            else
            {
                Console.WriteLine("============================== This user is not exist =====================================");
            }
        }
    }
}