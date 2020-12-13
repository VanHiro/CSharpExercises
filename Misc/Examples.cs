using System;
using System.Diagnostics;
using System.Linq;
using System.Collections.Generic;
// LINQ
// SELECT col1, col2 FROM table_name;
// 
// Search article.description == param

/*
 from 
 where 
 select
*/

namespace Examples
{
	class Examples {
		// static, method that can be called without the NEW
		public static IEnumerable<string> Filterting()
		{
			var cities = new List<string> { "Arezzo", "Arezzo", "Siena", "Firenze", "Lucca" };
			var queryCities =
				from city in cities
				where city.Length <= 5
				let cityToUpperCase = city.ToUpper()
				select cityToUpperCase;
			return queryCities;

			/*
				var cities = new List<string> { "Arezzo", "Arezzo", "Siena", "Firenze", "Lucca" };
				var queryCities =
					from city in cities
					where city.Length <= 5 
					let cityToUpperCase = city.ToUpper()
					select cityToUpperCase;
				return queryCities;
				//THE QUERY ENDs
			*/

			/*
				var cities = new string[] { "Rome", "Milan", "Florence" };
				// THE QUERY BEGINS
				var query =
					from city in cities
					where city == "Rome"
					let cityToUpperCase = city.ToUpper()
					select cityToUpperCase;
				// THE QUERY ENDS
				return query.Filtering();

			 */
			/*
			
			// e' solo un array
			var numbers = new int[] { 3, 56, 78 };

			// LINQ

			// e' un'interfaccia che rappresenta tutte le collezioni che sono scorribili (ciclabili) dove viene solo definito il metodo
			IEnumerable<int> query =
				//OR var query = 
			// ogni num all'interno di numeri
				from number in numbers
				where number == 45
				select number;

			*/
		}
	}
}