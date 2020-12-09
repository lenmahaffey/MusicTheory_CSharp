using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_LMahaffey_FinalProject
{
	public class PentatonicMajorScale : Scale
	{
		public PentatonicMajorScale(Pitch pitch) : base(pitch, true, pitch.GetPositionAsString())
		{
			base.pattern = PentatonicMajorScale.pattern;
			SetScale();
		}
		public PentatonicMajorScale(int pitchAsInt) : base(pitchAsInt, true)
		{
			base.pattern = PentatonicMajorScale.pattern;
			SetScale();
		}
		public PentatonicMajorScale(string pitchAsString) : base(pitchAsString, true)
		{
			base.pattern = PentatonicMajorScale.pattern;
			SetScale();
		}
		private new static Pitch.Step[] pattern = {	Pitch.Step.WholeAndAHalf,
													Pitch.Step.Whole,
													Pitch.Step.Whole,
													Pitch.Step.WholeAndAHalf,
													Pitch.Step.Whole};
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
