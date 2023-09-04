using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
	internal class User 
	{
		private string? name;

		public string? Name
		{
			get { return name; }
			set { name = value; }
		}
		private string? surname;

		public string? Surname
		{
			get { return surname; }
			set { surname = value; }
		}
        private List<string?> emeliyyatlar = new List<string?>();

        public  List<string?> Emeliyyatlar
		{
			get { return emeliyyatlar; }
			set { emeliyyatlar = value; }
		}


		private Card? CreditCard;
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
			Name = _name;
			Surname = _surname;
			CreditCard = cc;
		}
		public void addOperation(string _operation)
		{
			this.emeliyyatlar.Add(_operation);
		}
		public void showOperations()
		{
			foreach (var item in emeliyyatlar)
			{
				Console.WriteLine(item.ToString());
			}
		}

		public override string ToString() {
			string txt ="Name:"+ this.Name +"  Surname:"+ this.Surname +"\n"+this.CreditCard ;
			return txt;
		
		}
      
    }

}
