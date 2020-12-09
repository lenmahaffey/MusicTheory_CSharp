using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSC236_LMahaffey_FinalProject;

namespace CSC236_LMahaffey_FinalProject
{
    public class MusicObject
    {
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
		public string Name
		{
			get
            {
				string s = name;
				if (name.Contains("s"))
				{
					s = name.Replace("s", "♯");
				}
				if (name.Contains("f"))
				{
					s = name.Replace("f", "♭");
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
