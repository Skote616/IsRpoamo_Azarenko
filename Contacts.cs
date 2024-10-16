using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsRpoamo_Azarenko
{
    internal class Contacts
    {
        public List <string> users = new List<string>();
        public string name
        {
            get; set;
        }
        public string surname
        {
            get; set;
        }
        public string email
        {
            get; set;
        }
        public string login
        {
            get; set;
        }
        public string password
        {
            get; set;
        }


        public void Prisv()
        {
            string full=name+" "+surname+" "+login+" "+password+" "+email;
            users.Add(full);
        }
    }
}
