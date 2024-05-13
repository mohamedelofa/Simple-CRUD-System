using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_System
{
    internal class User 
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public User(string name, string telephone, string email)
        {
            Name = name;
            Telephone = telephone;
            Email = email;
        }
        
        public override string ToString()
        {
            return $"Name : {Name}  ,  Telephone : {Telephone}  ,  Email : {Email}";
        }
    }
}
