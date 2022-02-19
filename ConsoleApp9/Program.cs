using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
	internal class Program
	{

	
		static void Main(string[] args)
		{
			List<Notes> NotesList = new List<Notes>();

			while (true)
			{
				Console.WriteLine("------NOTIZEN APP------");
				Console.WriteLine("1.) Notiz hinzufügen");
				Console.WriteLine("2.) Notizen anzeigen");
				Console.WriteLine("3.) Anwendung beenden");


				switch (Console.ReadLine())
				{
					case "1":
						WriteNotes.WriteNote(NotesList);
						break;

					case "2":
						ShowNotes.ShowNote(NotesList);
						Console.WriteLine("teset");
						break;

					case "3":
						Environment.Exit(0);
						break;
					default:
						break;
				}
			}
			
		}

		

	}
}
