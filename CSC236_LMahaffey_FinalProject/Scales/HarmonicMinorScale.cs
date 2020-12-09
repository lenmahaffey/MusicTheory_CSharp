using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_LMahaffey_FinalProject
{
	public class HarmonicMinorScale : Scale
	{
		public HarmonicMinorScale(Pitch pitch) : base(pitch, true, pitch.GetPositionAsString())
		{
			base.pattern = HarmonicMinorScale.pattern;
			SetScale();
		}
		public HarmonicMinorScale(int pitchAsInt) : base(pitchAsInt, true)
		{
			base.pattern = HarmonicMinorScale.pattern;
			SetScale();
		}
		public HarmonicMinorScale(string pitchAsString) : base(pitchAsString, true)
		{
			base.pattern = HarmonicMinorScale.pattern;
			SetScale();
		}
		private new static Pitch.Step[] pattern = {	Pitch.Step.Half,
													Pitch.Step.Whole,
													Pitch.Step.Half,
													Pitch.Step.Whole,
													Pitch.Step.Whole,
													Pitch.Step.Half,
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
