
using BankApp;
Card Card1 = new Card("4169584412345678", "9999");
Card Card2 = new Card("4169584487654321", "4444");
Card Card3 = new Card("4169584420408010", "1111");
Card Card4 = new Card("4169584488997766", "2222");
Card Card5 = new Card("4169584466666666", "3333");

User user1 = new User("Rasul", "Aslanov", Card1);
User user2 = new User("Ali", "Aliyev", Card2);
User user3 = new User("Vali", "Valiyev", Card3);
User user4 = new User("Mehemmed", "Mehemmedov", Card4);
User user5 = new User("Ehed", "Ehedov", Card5);

List<User> users = new List<User>();
users.Add(user1);
users.Add(user2);
users.Add(user3);
users.Add(user4);
users.Add(user5);


Bank bank = new Bank("Kapital",users);

while (true)
{
    Console.Clear();
    Console.WriteLine("[0]-for exit\n\nYour Pin:");
  

    string pin = Console.ReadLine();
    if (pin == "0") break;
    User user = bank.CheckByPin(pin);

    if (user != null)
    {
        string txt1 = "Login to account " + user.Name + " Pin:" + user.Creditcard.Pin + " " + DateTime.Now + "\n";
        user.addOperation(txt1); ;
        while (true)
        {
            Console.Clear();
            Console.WriteLine(bank.Bankname+"----Bank");
            Console.WriteLine("Welcome " + user.Name + " " + user.Surname);
            
            Console.WriteLine("[1]-Balance\n[2]-WithDrawal\n[3]-Card to Card\n[4]-Show All Operations\n[0]-Exit");
            string sec = Console.ReadLine();
            if (sec == "1")
            {
                Console.Clear();
                string txt2 = "Show Balance-" + user.Name + " Pin:" + user.Creditcard.Pin + " " + DateTime.Now + "\n";
                user.addOperation(txt2);
                Console.WriteLine("Your Balance :" + user.Creditcard.Balans.ToString());
                Console.WriteLine("Press any key for previous menu:");
                Console.ReadKey();
            }
            if (sec == "2")
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("[10$] - [20$] - [50$] - [100$] - [200$]-[0]-for  previous menu\nyour amount:");
                    string amountStr = Console.ReadLine();
                    if (amountStr == "0") break;
                    int amount = -1;
                    if (int.TryParse(amountStr, out  amount))
                    {

                        Console.WriteLine("Entered amount: " + amount);
                    }
                    else
                    {

                        Console.WriteLine("Invalid amount. Please enter a valid number.");
                        Console.WriteLine("Press any key for continue");
                        Console.ReadKey();
                    }
                    if (amount != -1 && amount!=0)
                    {
                        if(user.Creditcard.Balans>=amount)
                        { user.Creditcard.Balans -= (decimal)amount;
                            string txt3 = "WithDraw Money-" + user.Name + " amount:" + amount + " " + DateTime.Now + "\n";
                            user.addOperation(txt3);
                            Console.WriteLine("Succesfully Withdrawal\n Yout Balance:" + user.Creditcard.Balans);
                            Console.WriteLine("Press any key for continue");
                            Console.ReadKey();
                            break;
                        }
                        else { Console.WriteLine("Not enough funds in your account");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadKey();
                        }
                    }
                }
            }
            if (sec == "3")
            {
                Console.Clear();
                Console.WriteLine("Gonderilen kartin pin'ini daxil edin:");
                string _pin = Console.ReadLine();
                User _user= bank.CheckByPin(_pin);
                if (_user != null)
                {Console.Clear();
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("[10$] - [20$] - [50$] - [100$] - [200$]-[0]-for  previous menu\nyour amount:");
                        string amountStr = Console.ReadLine();
                        if (amountStr == "0") break;
                        int amount = -1;
                        if (int.TryParse(amountStr, out amount))
                        {

                            Console.WriteLine("Entered amount: " + amount);
                        }
                        else
                        {

                            Console.WriteLine("Invalid amount. Please enter a valid number.");
                            Console.WriteLine("Press any key for continue");
                            Console.ReadKey();
                        }
                        if (amount != -1)
                        {
                            if (user.Creditcard.Balans >= amount)
                            {
                                user.Creditcard.Balans -= (decimal)amount;
                                _user.Creditcard.Balans += (decimal)amount;
                                string txt4 = "Send money to-" + _user.Name+" "+_user.Surname + " Amount:" + amount + " " + DateTime.Now + "\n";
                                user.addOperation(txt4);
                                Console.WriteLine("Succesfully \n Your balance:" + user.Creditcard.Balans);
                                Console.WriteLine("Press any key for continue");
                                Console.ReadKey();
                                break;
                            }
                            else { Console.WriteLine("Not enough funds in your account"); }
                        }
                    }
                }
                else { Console.WriteLine("Bu pin'e uygun kart tapilmadi");
                    Console.WriteLine("Press any key for continue");
                    Console.ReadKey();
                }
            }
            if (sec == "0")
            {
                break;
            }
            if(sec=="4")
            {
                Console.Clear();
                user.showOperations();
                Console.WriteLine("Press any key for continue");
                Console.ReadKey();
            }
        }
       
    }
    else
    {
        Console.WriteLine("Login failed. Please check your PIN and try again,Press any key for continue");
        Console.ReadKey();
    }
}





