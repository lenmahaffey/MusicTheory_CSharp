using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_LMahaffey_FinalProject
{
	public class NatualMinorScale : Scale
	{
		public NatualMinorScale(Pitch pitch) : base(pitch, true, pitch.GetPositionAsString())
		{
			base.pattern = NatualMinorScale.pattern;
			SetScale();
		}
		public NatualMinorScale(int pitchAsInt) : base(pitchAsInt, true)
		{
			base.pattern = NatualMinorScale.pattern;
			SetScale();
		}
		public NatualMinorScale(string pitchAsString) : base(pitchAsString, true)
		{
			base.pattern = NatualMinorScale.pattern;
			SetScale();
		}
		private new static Pitch.Step[] pattern = {	Pitch.Step.Whole,
													Pitch.Step.Whole,
													Pitch.Step.Half,
													Pitch.Step.Whole,
													Pitch.Step.Whole,
													Pitch.Step.Half,
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
