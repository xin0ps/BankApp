using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    internal class User
    {
        private string? name;
        private string? surname;
        private List<string?> emeliyyatlar = new List<string?>();
        private Card? CreditCard;

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }

        public string? Surname
        {
            get { return surname; }
            set { surname = value; }
        }

        public List<string?> Emeliyyatlar
        {
            get { return emeliyyatlar; }
            set { emeliyyatlar = value; }
        }

        public Card? Creditcard
        {
            get { return CreditCard; }
            set { CreditCard = value; }
        }

        public User()
        {

        }

        public User(string _name, string _surname, Card cc)
        {
            try
            {
                Name = _name;
                Surname = _surname;
                CreditCard = cc;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while creating a user: " + ex.Message);
            }
        }

        public void ChangePin(string? pin)
        {
            try
            {
                if ((Convert.ToInt32(pin) > 999) && (Convert.ToInt32(pin) < 10000))
                {
                    if (int.TryParse(pin, out _))
                    {
                        this.CreditCard.Pin = pin;
                        
                        this.addOperation("Pin changed -New Pin:"  +pin +  " " + DateTime.Now + "\n");
                        Console.WriteLine("PIN changed\nPress any key for continue...");
                        Console.ReadKey();
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
                Console.WriteLine("Xeta: " + ex.Message+"   \nPress any key for continue...");
                Console.ReadKey();

            }
        }

        public void addOperation(string _operation)
        {
            try
            {
                this.emeliyyatlar.Add(_operation);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while adding an operation: " + ex.Message);
            }
        }

        public void showOperations()
        {
            try
            {
                foreach (var item in emeliyyatlar)
                {
                    Console.WriteLine(item?.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while displaying operations: " + ex.Message);
            }
        }

        public override string ToString()
        {
            try
            {
                string txt = "Name:" + this.Name + "  Surname:" + this.Surname + "\n" + this.CreditCard;
                return txt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while converting the User object to a string: " + ex.Message);
                return string.Empty;
            }
        }
    }
}
