/*
    CSC236 8N0 Intro to C#
    Project: Final Project
    File: MusicObject.cs
    By: Len Mahaffey
    Last Edited: 12/11/20
    Description: Base class for MusicTheory objects.
*/

namespace CSC236_LMahaffey_FinalProject
{
    public class MusicObject
    {
		//Constructors
		public MusicObject()
		{
			pitch = new Pitch(0);
			name = "NONE";
		}
		public MusicObject(Pitch pitch)
		{
			this.pitch = pitch;
			name = Pitch.GetPositionAsString(pitch.GetPosition());
		}
		public MusicObject(Pitch pitch, string n)
		{
			this.pitch = pitch;
			name = n;
		}
		public MusicObject(string pitchAsString)
		{
			pitch = new Pitch(pitchAsString);
			name = pitchAsString;
		}
		public MusicObject(int pitchAsInt)
		{
			pitch = new Pitch(pitchAsInt);
			name = Pitch.GetPositionAsString(Pitch.GetPositionFromChromaticScale(pitchAsInt));
		}

		//Properties
		private Pitch pitch;
		public Pitch Pitch
		{
            get
            {
				return pitch;
            }
			set
			{
				pitch = value;
				name = value.GetPositionAsString();
			}
		}
		private string name;
		//Replace 's' and 'f' with Unicode symbols in new string in getter and keep name property the same
		public string Name
		{
			get
            {
				string s = name;
				if (s.Contains("s"))
				{
					s = s.Replace("s", "♯");
				}
                if (s.Contains("f"))
                {
                    s = s.Replace("f", "♭");
                }
                if (s.Length == 4 && s != "NONE")
                {
                    s = s.Insert(2, "/");
                }
                return s;
            }
            set
            {
				name = value;
            }
		}

		//Class Methods
		public void AccendHalfStep()
		{
			int index = (int)Pitch.GetPosition();
			int haveSteped = 0;
			Pitch currentNote = Pitch;
			do
			{
				index++;
				if (index > 12)
					index = 1;
				currentNote = new Pitch(index);
				haveSteped++;
			} while (haveSteped != 1);
			Pitch = currentNote;
		}
		public void AccendWholeStep()
		{
			int index = (int)Pitch.GetPosition();
			int haveSteped = 0;
			Pitch currentNote = Pitch;
			do
			{
				index++;
				if (index > 12)
					index = 1;
				currentNote = new Pitch(index);
				haveSteped++;
			} while (haveSteped != 2);

			Pitch = currentNote;
		}
		public void AccendStepAndAHalf()
		{
			int index = (int)Pitch.GetPosition();
			int haveSteped = 0;
			Pitch currentNote = Pitch;
			do
			{
				index++;
				if (index > 12)
					index = 1;
				currentNote = new Pitch(index);
				haveSteped++;

			} while (haveSteped != 3);
			Pitch = currentNote;
		}
	}
}
