/*
    CSC236 8N0 Intro to C#
    Project: Final Project
    File: Note.cs
    By: Len Mahaffey
    Last Edited: 12/11/20
    Description: Note class. Will be useful for managing multiple Chromatic Scales (repeating pattern) in a single scale.
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