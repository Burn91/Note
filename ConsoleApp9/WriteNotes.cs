using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
	public static class WriteNotes
	{

		public static void WriteNote(List<Notes> notesList)
		{

			Console.Clear();
			Console.WriteLine("Bitte Notiz eingeben.");
			string noteInput = Console.ReadLine();
			notesList.Add(new Notes(noteInput,DateTime.Now));
			Console.Clear();

		}

	}
}
