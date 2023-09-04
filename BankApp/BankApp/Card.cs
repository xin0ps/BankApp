using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
	

    internal class Card
    {

		int rand4 = Random.Shared.Next(1000, 10000);
		int rand3 = Random.Shared.Next(100, 1000);
		int randbalans = Random.Shared.Next(0, 5000);
        private string? pan=null;//16

		public string Pan
		{
			get { return pan; }
			set { pan = value; }
		}

		private string? pin=null;//4

		public string Pin
		{
			get { return pin; }
			set { pin = value; }
		}

		private string? cvc=null;//3

		public string Cvc
		{
			get { return cvc; }
			set { cvc = value; }
		}
		private decimal balans;

		public decimal Balans
		{
			get { return balans; }
			set { balans = value; }
		}

		DateTime Expire;

		public Card()
		{
			
			Cvc=rand3.ToString();
			Balans=randbalans;
            Expire = DateTime.Now.AddYears(4);
        }

		public Card(string _pan, string _pin):this()
		{
			this.Pan = _pan;
		    this.Pin = _pin;
			
		}

		public override string ToString()
		{
			string txt = "Pan:" + this.Pan + "\n" + "Pin:" + this.Pin + "\n" + "Cvc:" + this.Cvc + "\n"+"Expire Date:"+this.Expire.ToString("MM/yy")+"\n";
            return txt;
        }
    }
}
