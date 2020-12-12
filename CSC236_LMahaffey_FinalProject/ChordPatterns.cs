/*
    CSC236 8N0 Intro to C#
    Project: Final Project
    File: ChordPatterns.cs
    By: Len Mahaffey
    Last Edited: 12/11/20
    Description: Data structure to store chord patterns. Chords are derived from individual notes in a scale, in this case the 1st, 3rd and 4th notes.
				 Each note of a scale can be used to form chords 1-7 (notated in Roman numerals). The chords formed at the end of a scale
				 will use notes from the next iteration of the Chromatic Scale. Values for chord notes are hard coded until a clever solution is derived.
*/

namespace CSC236_LMahaffey_FinalProject
{
	class ChordPatterns
	{
		//Constructors
		public ChordPatterns()
		{
			_I_Chord.pattern = new int[] { 0, 2, 4 };
			_I_Chord.length = _I_Chord.pattern.Length;
			_II_Chord.pattern = new int[] { 1, 3, 5 };
			_II_Chord.length = _I_Chord.pattern.Length;
			_III_Chord.pattern = new int[] { 2, 4, 6 };
			_III_Chord.length = _I_Chord.pattern.Length;
			_IV_Chord.pattern = new int[] { 3, 5, (7 - 7) };
			_IV_Chord.length = _I_Chord.pattern.Length;
			_V_Chord.pattern = new int[] { 4, 6, (8 - 7) };
			_V_Chord.length = _I_Chord.pattern.Length;
			_VI_Chord.pattern = new int[] { 5, 7 - 7, (9 - 7) };
			_VI_Chord.length = _I_Chord.pattern.Length;
			_VII_Chord.pattern = new int[] { 6, (8 - 7), (10 - 7) };
			_VII_Chord.length = _I_Chord.pattern.Length;
		}
		public struct ChordPattern
		{
			public int[] pattern;
			public int length;
		}

		private ChordPattern _I_Chord;
		public ChordPattern I_Chord
		{
            get
            {
				return _I_Chord;
            }
			set
            {
				_I_Chord = value;
            }
		}

		private ChordPattern _II_Chord;
		public ChordPattern II_Chord
		{
			get
			{
				return _II_Chord;
			}
			set
			{
				_II_Chord = value;
			}
		}

		private ChordPattern _III_Chord;
		public ChordPattern III_Chord
		{
			get
			{
				return _III_Chord;
			}
			set
			{
				_III_Chord = value;
			}
		}

		private ChordPattern _IV_Chord;
		public ChordPattern IV_Chord
		{
			get
			{
				return _IV_Chord;
			}
			set
			{
				_IV_Chord = value;
			}
		}

		private ChordPattern _V_Chord;
		public ChordPattern V_Chord
		{
			get
			{
				return _V_Chord;
			}
			set
			{
				_V_Chord = value;
			}
		}

		private ChordPattern _VI_Chord;
		public ChordPattern VI_Chord
		{
			get
			{
				return _VI_Chord;
			}
			set
			{
				_VI_Chord = value;
			}
		}

		private ChordPattern _VII_Chord;
		public ChordPattern VII_Chord
		{
			get
			{
				return _VII_Chord;
			}
			set
			{
				_VII_Chord = value;
			}
		}
	}
}
