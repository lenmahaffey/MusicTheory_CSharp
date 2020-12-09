using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_LMahaffey_FinalProject
{
	public class Pitch
	{
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


		static public ChromaticScalePosition GetPositionFromChromaticScale(string pitch)
		{
			if (pitch == "NONE")
				return ChromaticScalePosition.NONE;
			else if (pitch == "A")
				return ChromaticScalePosition.A;
			else if (pitch == "AsBf" || pitch == "As" || pitch == "Bf")
				return ChromaticScalePosition.AsBf;
			else if (pitch == "B")
				return ChromaticScalePosition.B;
			else if (pitch == "C")
				return ChromaticScalePosition.C;
			else if (pitch == "CsDf" || pitch == "Cs" || pitch == "Df")
				return ChromaticScalePosition.CsDf;
			else if (pitch == "D")
				return ChromaticScalePosition.D;
			else if (pitch == "DsEf" || pitch == "Ds" || pitch == "Ef")
				return ChromaticScalePosition.DsEf;
			else if (pitch == "E")
				return ChromaticScalePosition.E;
			else if (pitch == "F")
				return ChromaticScalePosition.F;
			else if (pitch == "FsGf" || pitch == "Fs" || pitch == "Gf")
				return ChromaticScalePosition.FsGf;
			else if (pitch == "G")
				return ChromaticScalePosition.G;
			else if (pitch == "GsAf" || pitch == "Gs" || pitch == "Af")
				return ChromaticScalePosition.GsAf;
			else
				//**TODO** implement exception handler
				return ChromaticScalePosition.NONE;
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
					//**TODO** implement exception handler
					return ChromaticScalePosition.NONE;
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
					//**TODO** implement exception handler
					return "NONE";
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
					//**TODO** implement exception handler?
					return Weight.NONE;
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
					//**TODO** implement exception handler?
					return "None";
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
					//**TODO** implement exception handler
					return "NONE";
			}
		}
        public override string ToString()
        {
			return this.GetPositionAsString();
        }
    }
}