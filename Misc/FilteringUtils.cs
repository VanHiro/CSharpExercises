using System.Linq;
using System;
using System.Collections;

namespace ExLinq
{
	class FilteringUtils 
	{
		public static string Search(string searchTerm)
		{
			var cities = new string[] {"Arezzo", "Arezzo", "Siena", "Firenze", "Lucca"};

			var query = //OR IEnumerable<string> //su questa posso fare i foreach, e' una funzione che puo' essere messa in pausa, con questa struttura dati (IEnumerabile) i dati si chiamano on demand
				from city in cities
				where city == searchTerm
				select city;
			
			foreach (var city in query)
			{
				Console.WriteLine(city);
			}

			return "Nothing found";
		} 
	}
}