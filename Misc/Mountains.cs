using System.Linq;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpExercises
{
	class Mountains
	{
		//Exercise solved using LINQ
		public static IEnumerable<string> ParseNames(string mountainsStr)
		{
			var mountains = new List<string>(mountainsStr.Split(';'));
			var query =
				from peaksList in mountains
				let parsedName = peaksList.Trim().Split(',')[0]
				select parsedName;
			
			foreach (var parsedName in query)
			{
				Console.WriteLine(parsedName);
			}

			return query;


			/* Alternate Solution
			// first separate string where the semicolon is 
			string[] split = mountainsStr.Split(';');

			// remove the leading and trailling spaces
			var trimmed = split.Select(m => m.Trim());

			//select from the list the string "Monte Nome"
			var result = trimmed.Select(m => m.Split(',')[0]);

			return mountainsStr.Split(';').Select(m => m.Trim().Split(',')[0]);
			*/
		}
	}
}