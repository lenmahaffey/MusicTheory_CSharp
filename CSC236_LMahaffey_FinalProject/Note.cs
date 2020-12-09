/*
    CSC236 8N0 Intro to C#
    Project:
    By: Len Mahaffey
    Last Edited
*/

using System;
using CSC236_LMahaffey_FinalProject;

namespace CSC236_LMahaffey_FinalProject
{
	public class Note : MusicObject
	{
		//Constructors
		public Note() : base()
		{
		}
		public Note(Pitch note) : base(note)
		{
		}
		public Note(string note) : base(note)
		{
		}
		public Note(int note) : base(note)
		{
		}
        public override string ToString()
        {
			return Name;
        }
    }
}