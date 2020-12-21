/*using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
	class Person
	{
		protected string FirstName = "Gino";
		protected string LastName = "Neri";
		private int _Age = 24;

		public Person(string FirstName, string LastName, string Age)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			try
			{
				var foo = int.Parse(Age);
				this._Age = foo;
			}
			catch(FormatException err)
			{
				var logLine = $"{DateTime.Now} - {err.Message} - {err.StackTrace}\n";
				File.AppendAllText("personLog.log", logLine);
				Console.WriteLine("You must provide a valid age, not its literal form");
			}
		}
		public void Save(string path)
		{
			string personInfo = $"{FirstName}, {LastName}, {_Age}\n";
			File.AppendAllText(path, personInfo);
		}	
		public void Breath()
		{
			Console.WriteLine("I am breathing");
		}
		public void Fly()
		{
			Console.WriteLine("I am flying");
		}
	}
}
*/


