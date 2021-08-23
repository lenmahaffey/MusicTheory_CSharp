/*
    CSC236 8N0 Intro to C#
    Project: Final Project
    File: Pitch.cs
    By: Len Mahaffey
    Last Edited: 12/11/20
    Description: Pitch class to manage Chromatic Scale enumeration
*/

namespace CSC236_LMahaffey_FinalProject
{
	public class Pitch
	{
		//Enumerations of Chromatic Scale; not sure where else to put them
		public enum ChromaticScalePosition
		{
			NONE = 0,
			A,
			AsBf,
			B,
			C,
			CsDf,
			D,
			DsEf,
			E,
			F,
			FsGf,
			G,
			GsAf
		};
		public enum Weight
		{
			NONE = 0,
			Half,
			Whole
		};
		public enum Step
		{
			NONE = 0,
			Half,
			Whole,
			WholeAndAHalf,
			Double
		}

		//Constructors
		public Pitch()
		{
			position = ChromaticScalePosition.NONE;
			weight = GetWeightForPosition(ChromaticScalePosition.NONE);

		}
		public Pitch(ChromaticScalePosition pos)
		{
			position = pos;
			weight = GetWeightForPosition(pos);
		}
		public Pitch(int pitchAsInt)
		{
			position = GetPositionFromChromaticScale(pitchAsInt);
			weight = GetWeightForPosition(GetPositionFromChromaticScale(pitchAsInt));

		}
		public Pitch(string pitchAsString)
		{
			position = GetPositionFromChromaticScale(pitchAsString);
			weight = GetWeightForPosition(GetPositionFromChromaticScale(pitchAsString));

		}

		//Accessors
		private ChromaticScalePosition position;
		public ChromaticScalePosition GetPosition()
		{
			return position;
		}
		public string GetPositionAsString()
		{
			return GetPositionAsString(position);
		}

		private Weight weight;
		public Weight GetWeight()
		{
			return weight;
		}
		public string GetWeightAsString()
		{
			return GetWeightForPositionAsString(weight);
		}

		//Static methods to manage Chromatic Scale enums (get strings, get enum from a string, etc)
		static public ChromaticScalePosition GetPositionFromChromaticScale(string pitch)
		{
			if (pitch == "NONE")
				return ChromaticScalePosition.NONE;
			else if (pitch == "A")
				return ChromaticScalePosition.A;
			else if (pitch == "AsBf" || pitch == "As" || pitch == "Bf" || pitch == "A♯" || pitch == "B♭" || pitch == "A♯/B♭")
				return ChromaticScalePosition.AsBf;
			else if (pitch == "B")
				return ChromaticScalePosition.B;
			else if (pitch == "C")
				return ChromaticScalePosition.C;
			else if (pitch == "CsDf" || pitch == "Cs" || pitch == "Df" || pitch == "C♯" || pitch == "D♭" || pitch == "C♯/D♭")
				return ChromaticScalePosition.CsDf;
			else if (pitch == "D")
				return ChromaticScalePosition.D;
			else if (pitch == "DsEf" || pitch == "Ds" || pitch == "Ef" || pitch == "D♯" || pitch == "E♭" || pitch == "D♯/E♭")
				return ChromaticScalePosition.DsEf;
			else if (pitch == "E")
				return ChromaticScalePosition.E;
			else if (pitch == "F")
				return ChromaticScalePosition.F;
			else if (pitch == "FsGf" || pitch == "Fs" || pitch == "Gf" || pitch == "F♯" || pitch == "G♭" || pitch == "F♯/G♭")
				return ChromaticScalePosition.FsGf;
			else if (pitch == "G")
				return ChromaticScalePosition.G;
			else if (pitch == "GsAf" || pitch == "Gs" || pitch == "Af" || pitch == "G♯" || pitch == "A♭" || pitch == "G♯/A♭")
				return ChromaticScalePosition.GsAf;
			else
            {
                MusicException e = new MusicException();
				e.message = "Unknown position: " + pitch;
				throw e;
            }
        }
		static public ChromaticScalePosition GetPositionFromChromaticScale(int noteAsInt)
		{
			switch (noteAsInt)
			{
				case 0:
					return ChromaticScalePosition.NONE;
				case 1:
					return ChromaticScalePosition.A;
				case 2:
					return ChromaticScalePosition.AsBf;
				case 3:
					return ChromaticScalePosition.B;
				case 4:
					return ChromaticScalePosition.C;
				case 5:
					return ChromaticScalePosition.CsDf;
				case 6:
					return ChromaticScalePosition.D;
				case 7:
					return ChromaticScalePosition.DsEf;
				case 8:
					return ChromaticScalePosition.E;
				case 9:
					return ChromaticScalePosition.F;
				case 10:
					return ChromaticScalePosition.FsGf;
				case 11:
					return ChromaticScalePosition.G;
				case 12:
					return ChromaticScalePosition.GsAf;
				default:
					MusicException e = new MusicException();
					e.message = "Int out of range! Use a whole number 0-11";
					throw e;
			}
		}
		static public string GetPositionAsString(ChromaticScalePosition position)
		{
			switch (position)
			{
				case ChromaticScalePosition.NONE:
					return "NONE";
				case ChromaticScalePosition.A:
					return "A";
				case ChromaticScalePosition.AsBf:
					return "AsBf";
				case ChromaticScalePosition.B:
					return "B";
				case ChromaticScalePosition.C:
					return "C";
				case ChromaticScalePosition.CsDf:
					return "CsDf";
				case ChromaticScalePosition.D:
					return "D";
				case ChromaticScalePosition.DsEf:
					return "DsEf";
				case ChromaticScalePosition.E:
					return "E";
				case ChromaticScalePosition.F:
					return "F";
				case ChromaticScalePosition.FsGf:
					return "FsGf";
				case ChromaticScalePosition.G:
					return "G";
				case ChromaticScalePosition.GsAf:
					return "GsAf";
				default:
					//This should never happen
					MusicException e = new MusicException();
					e.message = "Unknown position: " + position;
					throw e;
			}
		}
		static public Weight GetWeightForPosition(ChromaticScalePosition position)
		{
			switch (position)
			{
				case ChromaticScalePosition.NONE:
					return Weight.NONE;
				case ChromaticScalePosition.A:
					return Weight.Whole;
				case ChromaticScalePosition.AsBf:
					return Weight.Half;
				case ChromaticScalePosition.B:
					return Weight.Whole;
				case ChromaticScalePosition.C:
					return Weight.Whole;
				case ChromaticScalePosition.CsDf:
					return Weight.Half;
				case ChromaticScalePosition.D:
					return Weight.Whole;
				case ChromaticScalePosition.DsEf:
					return Weight.Half;
				case ChromaticScalePosition.E:
					return Weight.Whole;
				case ChromaticScalePosition.F:
					return Weight.Whole;
				case ChromaticScalePosition.FsGf:
					return Weight.Half;
				case ChromaticScalePosition.G:
					return Weight.Whole;
				case ChromaticScalePosition.GsAf:
					return Weight.Half;
				default:
					MusicException e = new MusicException();
					e.message = "Unknown position: " + position;
					throw e;
			}
		}
		static public string GetWeightForPositionAsString(Weight weight)
		{
			switch (weight)
			{
				case Weight.NONE:
					return "None";
				case Weight.Half:
					return "Half";
				case Weight.Whole:
					return "Whole";
				default:
					MusicException e = new MusicException();
					e.message = "Unknown weight: " + weight;
					throw e;
			}
		}
		static public string GetStepAsString(Step step)
		{
			switch (step)
			{
				case Step.NONE:
					return "NONE";
				case Step.Half:
					return "Half";
				case Step.Whole:
					return "Whole";
				case Step.WholeAndAHalf:
					return "Whole and a Half";
				case Step.Double:
					return "Double";
				default:
					MusicException e = new MusicException();
					e.message = "Unknown step: " + step;
					throw e;
			}
		}
        public override string ToString()
        {
			return this.GetPositionAsString();
        }
    }
}