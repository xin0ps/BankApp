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
            try
            {
                Bankname = bankname;
                this.users = users;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating a bank: " + ex.Message);
            }
        }

        public User CheckByPin(string pin)
        {

            try
            {
                if ((Convert.ToInt32(pin) > 999) && (Convert.ToInt32(pin) < 10000))
                {
                    if (int.TryParse(pin, out _))
                    {
                    }
                    else
                    {
                        throw new FormatException("4 reqemli daxil et");
                    }
                }
                else { throw new Exception("4 Reqemli daxil et"); }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Xeta: " + ex.Message + "   \nPress any key for continue...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Xeta: " + ex.Message + "   \nPress any key for continue...");
                Console.ReadKey();

            }
        
            try
            {
                foreach (var user in this.users)
                {
                    if (user.Creditcard != null && user.Creditcard.Pin == pin)
                    {
                        return user;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while checking user pin: " + ex.Message);
            }

            return null;
        }

        public override string ToString()
        {
            try
            {
                string txt = "";
                foreach (var item in this.users)
                {
                    txt = txt + item + "---------------------------------------\n";
                }
                return txt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while generating the bank's user list: " + ex.Message);
                return string.Empty;
            }
        }
    }
}

    

            
          
        
    

