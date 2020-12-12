/*
    CSC236 8N0 Intro to C#
    Project: Final Project
    File: Scale.cs
    By: Len Mahaffey
    Last Edited: 12/11/20
    Description: Abstract class for scale implementation. Base class builds will "NONE" steps for pattern.
				 Derived classes must provide scale pattern and method to resolve note names.
*/

namespace CSC236_LMahaffey_FinalProject
{
	public abstract class Scale : MusicObject
	{
		//Constructors
		public Scale() : base()
		{
            pattern = new Pitch.Step[7];
			scale = new Note[7];
			unresolvedScale = new Note[7];
			IsMajor = true;
			ScalePatternLength = 7;
			chordPatterns = new ChordPatterns();
		}
        public Scale(Pitch note, bool isMajor) : base(note)
        {
			IsMajor = isMajor;
            pattern = new Pitch.Step[7];
			scale = new Note[7];
            unresolvedScale = new Note[7];
            ScalePatternLength = 7;
        }
		public Scale(Pitch note, bool isMajor, string name) : base(note, name)
		{
			IsMajor = isMajor;
			pattern = new Pitch.Step[7];
			scale = new Note[7];
			unresolvedScale = new Note[7];
			ScalePatternLength = 7;
			chordPatterns = new ChordPatterns();
		}
		public Scale(int note, bool isMajor) : base(note)
        {
            pattern = new Pitch.Step[7];
            scale = new Note[7];
			unresolvedScale = new Note[7];
        	IsMajor = isMajor;
            ScalePatternLength = 7;
        }
        public Scale(string note, bool isMajor) : base(note)
        {
            pattern = new Pitch.Step[7];
		    scale = new Note[7];
		    unresolvedScale = new Note[7];
        	IsMajor = isMajor;
        	ScalePatternLength = 7;
			chordPatterns = new ChordPatterns();
		}

		//Properties
		private ChordPatterns chordPatterns;
		public bool IsMajor { get; set; }
		public int ScalePatternLength { get; set; }
		public Note relative { get; protected set; }
		protected Pitch.Step[] pattern { get; set; }
		protected Note[] scale { get; set; }
		protected Note[] unresolvedScale { get; set; }
		//No private backing field for each chord. Getter uses private field of scale to calculate and return new array
		public Note[] I
        {
            get
            {
				Note[]arr = new Note[chordPatterns.I_Chord.length];
				for(int position = 0; position < chordPatterns.I_Chord.pattern.Length; position++)
                {
					Note next = new Note(scale[chordPatterns.I_Chord.pattern[position]].Name);
					arr[position] = next;
                }
				return arr;
            }
        }
		public Note[] II
		{
			get
			{
				Note[] arr = new Note[chordPatterns.II_Chord.length];
				for (int position = 0; position < chordPatterns.II_Chord.pattern.Length; position++)
				{
					Note next = new Note(scale[chordPatterns.II_Chord.pattern[position]].Name);
					arr[position] = next;
				}
				return arr;
			}
		}
		public Note[] III
		{
			get
			{
				Note[] arr = new Note[chordPatterns.III_Chord.length];
				for (int position = 0; position < chordPatterns.III_Chord.pattern.Length; position++)
				{
					Note next = new Note(scale[chordPatterns.III_Chord.pattern[position]].Name);
					arr[position] = next;
				}
				return arr;
			}
		}
		public Note[] IV
		{
			get
			{
				Note[] arr = new Note[chordPatterns.VI_Chord.length];
				for (int position = 0; position < chordPatterns.VI_Chord.pattern.Length; position++)
				{
					Note next = new Note(scale[chordPatterns.VI_Chord.pattern[position]].Name);
					arr[position] = next;
				}
				return arr;
			}
		}
		public Note[] V
		{
			get
			{
				Note[] arr = new Note[chordPatterns.V_Chord.length];
				for (int position = 0; position < chordPatterns.V_Chord.pattern.Length; position++)
				{
					Note next = new Note(scale[chordPatterns.V_Chord.pattern[position]].Name);
					arr[position] = next;
				}
				return arr;
			}
		}
		public Note[] VI
		{
			get
			{
				Note[] arr = new Note[chordPatterns.VI_Chord.length];
				for (int position = 0; position < chordPatterns.VI_Chord.pattern.Length; position++)
				{
					Note next = new Note(scale[chordPatterns.VI_Chord.pattern[position]].Name);
					arr[position] = next;
				}
				return arr;
			}
		}
		public Note[] VII
		{
			get
			{
				Note[] arr = new Note[chordPatterns.VII_Chord.length];
				for (int position = 0; position < chordPatterns.VII_Chord.pattern.Length; position++)
				{
					Note next = new Note(scale[chordPatterns.VII_Chord.pattern[position]].Name);
					arr[position] = next;
				}
				return arr;
			}
		}

		//Methods
		public string GetScaleAsString()
		{
			string s = "";
			for(int i =0; i< scale.Length; i++)
			{
				if (scale[i] != null && scale[i].Name != "NONE")
				{
					s += scale[i].Name;
					s += " ";
				}
			}
			s = s.Trim();
			return s;
		}
		public string GetChordAsString(Note[] chord)
		{
			string s = "";
			foreach (Note note in chord)
			{
				s += note.Name;
				s += " ";
			}
			s = s.Trim();
			return s;
		}

		public string getUnresolvedScaleAsString()
		{
			string s = "";
			foreach (Note note in unresolvedScale)
			{
				if (note.Name != "NONE") {
					s += note.Name;
					s += " ";
				}
			}
			s = s.Trim();
			return s;
		}
		//Method to calculate scale based off pattern and Chromatic Scale
        protected void SetScale()
        {
			{
				unresolvedScale[0] = new Note(this.Pitch);
				Note nextNote = new Note(unresolvedScale[0].Pitch);
				for (int i = 1; i < unresolvedScale.Length; i++)
				{
					if (pattern.Length == i)
					{
						break;
					}
					nextNote = new Note (unresolvedScale[i - 1].Pitch);
					if (pattern[i] == Pitch.Step.NONE)
						continue;

					else if (pattern[i] == Pitch.Step.Whole)
					{
						nextNote.AccendWholeStep();
						unresolvedScale[i] = nextNote;
					}

					else if (pattern[i] == Pitch.Step.Half)
					{
						nextNote.AccendHalfStep();
						unresolvedScale[i] = nextNote;
					}

					else if (pattern[i] == Pitch.Step.WholeAndAHalf)
					{
						nextNote.AccendStepAndAHalf();
						unresolvedScale[i] = nextNote;
					}
				}
				ResolveScale();
			}
		}
		//Each scale to be implemented must provide a method to name each note.
		protected abstract void ResolveScale();
	}
}
