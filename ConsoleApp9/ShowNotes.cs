using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
	public static class ShowNotes
	{
		public static void ShowNote(List<Notes> noteList)
		{
			Console.Clear();
			foreach (var item in noteList)
			{
				Console.WriteLine(item.ToString());
			}
		}
	}
}
