using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_LMahaffey_FinalProject
{
	class ChordPatterns
	{
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
