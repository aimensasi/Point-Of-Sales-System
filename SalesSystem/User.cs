using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystem
{
    class User{

        private int id;
        private string name;
        private string email;
        private string password;
        private int role;
        private DateTime created_at;
        private DateTime updated_at;


        public User(string name, string email, string password, int role)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;

            this.created_at = DateTime.Now;
            this.updated_at = DateTime.Now;
        }



        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        

        public string Name
        {
            get { return name; }
        }
        

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        

        public int Role
        {
            get { return role; }
            set { role = value; }
        }
        

        public DateTime Created_at
        {
            get { return created_at; }
            set { created_at = value; }
        }
        

        public DateTime Updated_at
        {
            get { return updated_at; }
            set { updated_at = value; }
        }


    }
}
