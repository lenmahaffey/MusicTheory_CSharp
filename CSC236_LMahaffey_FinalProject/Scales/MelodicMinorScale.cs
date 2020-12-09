using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_LMahaffey_FinalProject
{
	public class MelodicMinorScale : Scale
	{
		public MelodicMinorScale(Pitch pitch) : base(pitch, true, pitch.GetPositionAsString())
		{
			base.pattern = MelodicMinorScale.pattern;
			SetScale();
		}
		public MelodicMinorScale(int pitchAsInt) : base(pitchAsInt, true)
		{
			base.pattern = MelodicMinorScale.pattern;
			SetScale();
		}
		public MelodicMinorScale(string pitchAsString) : base(pitchAsString, true)
		{
			base.pattern = MelodicMinorScale.pattern;
			SetScale();
		}
		private new static Pitch.Step[] pattern = { Pitch.Step.Half,
													Pitch.Step.Whole,
													Pitch.Step.Half,
													Pitch.Step.Whole,
													Pitch.Step.Whole,
													Pitch.Step.Whole,
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
