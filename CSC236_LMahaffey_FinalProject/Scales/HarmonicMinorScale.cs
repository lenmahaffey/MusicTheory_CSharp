/*
    CSC236 8N0 Intro to C#
    Project: Final Project
    File: HarmonicMinorScale.cs
    By: Len Mahaffey
    Last Edited: 12/11/20
    Description: Harmonic Minor implementation of Scale.cs  Currently can not resolve names of notes in scale.
*/

namespace CSC236_LMahaffey_FinalProject
{
	public class HarmonicMinorScale : Scale
	{
		public HarmonicMinorScale(Pitch pitch) : base(pitch, true, pitch.GetPositionAsString())
		{
			base.pattern = HarmonicMinorScale.pattern;
			SetScale();
			relative = scale[2];
		}
		public HarmonicMinorScale(int pitchAsInt) : base(pitchAsInt, true)
		{
			base.pattern = HarmonicMinorScale.pattern;
			SetScale();
			relative = scale[2];
		}
		public HarmonicMinorScale(string pitchAsString) : base(pitchAsString, true)
		{
			base.pattern = HarmonicMinorScale.pattern;
			SetScale();
			relative = scale[2];
		}
		private new static Pitch.Step[] pattern = {	Pitch.Step.Half,
													Pitch.Step.Whole,
													Pitch.Step.Half,
													Pitch.Step.Whole,
													Pitch.Step.Whole,
													Pitch.Step.Half,
													Pitch.Step.WholeAndAHalf};
		//Methods
		//Resolve name of each note in scale. Two rules, all sharps or flats and each letter appears once.
		//The first note must have a correct name. AsBf and other dual names can not be resolved.
		//The correct name of each accented note requires more musical research.
		protected override void ResolveScale()
		{
			scale = unresolvedScale;
		}
		public override string ToString()
		{
			return Name;
		}
	}
}
