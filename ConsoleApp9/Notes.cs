using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
	public class Notes
	{
	
		string Note { get; set; }
		DateTime NoteDate { get; set; }

		public Notes(string note, DateTime noteDate)
		{
			Note = note;
			NoteDate = noteDate;
		}

		public override string ToString()
		{
		
			return $"######\n{Note}\n{NoteDate}";
		}


	}
}
