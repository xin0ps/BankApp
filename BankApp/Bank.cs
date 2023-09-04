using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class Bank 
    {
        private string? bankname;

        public string? Bankname
        {
            get { return bankname; }
            set { bankname = value; }
        }

        public List<User> users = new List<User>();

        public Bank()
        {
          
        }

        public Bank(string? bankname, List<User> users)
        {
            Bankname = bankname;
            
            this.users = users;
        }

        public User CheckByPin(string pin)
        {
            foreach (var user in this.users)
            {
                if(user.Creditcard.Pin==pin)return user;
                 
            }
         
            return null ;
        }
        public override string ToString()
        {
            string txt = "";
            foreach (var item in this.users)
            {
                txt = txt + item+"---------------------------------------\n";
            }

            return txt;
        }


    }

    
}
            
          
        
    

