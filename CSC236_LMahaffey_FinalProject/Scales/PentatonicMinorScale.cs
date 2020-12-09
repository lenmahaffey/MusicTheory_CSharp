using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_LMahaffey_FinalProject
{
	public class PentatonicMinorScale : Scale
	{
		public PentatonicMinorScale(Pitch pitch) : base(pitch, true, pitch.GetPositionAsString())
		{
			base.pattern = PentatonicMinorScale.pattern;
			SetScale();
		}
		public PentatonicMinorScale(int pitchAsInt) : base(pitchAsInt, true)
		{
			base.pattern = PentatonicMinorScale.pattern;
			SetScale();
		}
		public PentatonicMinorScale(string pitchAsString) : base(pitchAsString, true)
		{
			base.pattern = PentatonicMinorScale.pattern;
			SetScale();
		}
		private new static Pitch.Step[] pattern = {	Pitch.Step.Whole,
													Pitch.Step.WholeAndAHalf,
													Pitch.Step.Whole,
													Pitch.Step.Whole,
													Pitch.Step.WholeAndAHalf};
		public override string ToString()
		{
			return Name;
		}
		protected override void ResolveScale()
		{
			scale = unresolvedScale;
		}
	}
}
