using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_LMahaffey_FinalProject
{
	public class MajorScale : Scale
	{
		public MajorScale(Pitch pitch) : base(pitch, true, pitch.GetPositionAsString())
		{
			base.pattern = MajorScale.pattern;
			SetScale();
		}
		public MajorScale(int pitchAsInt) : base(pitchAsInt, true)
		{
			base.pattern = MajorScale.pattern;
			SetScale();
		}
		public MajorScale(string pitchAsString) : base(pitchAsString, true)
		{
			base.pattern = MajorScale.pattern;
			SetScale();
		}
		private new static Pitch.Step[] pattern = {Pitch.Step.Whole,
													Pitch.Step.Whole,
													Pitch.Step.Whole,
													Pitch.Step.Half,
													Pitch.Step.Whole,
													Pitch.Step.Whole,
													Pitch.Step.Whole};
		public override string ToString()
		{
			return Name;
		}
		protected override void ResolveScale()
		{
			for (int i = 0; i < ScalePatternLength; i++)
			{
				Note previousNote;
				Note currentNote;
				string currentNoteNameFrontPosition = "";
				string currentNoteNameBackPosition = "";
				string previousNoteName = "";
				char currentNoteNewName;
				currentNote = new Note(unresolvedScale[i].Pitch.GetPositionAsString());
				currentNote.Name = unresolvedScale[i].Name;

				//If the note length is one or 2 then there is nothing to resolve
				if (currentNote.Name.Length == 1)
				{
					scale[i] = currentNote;
					continue;
				}
				if (currentNote.Name.Length == 2)
				{
					scale[i] = currentNote;
					continue;
				}

				//Get the two possible names of the note
				if (currentNote.Name.Length > 2)
				{
					currentNoteNameFrontPosition = currentNote.Pitch.GetPositionAsString();
					currentNoteNameFrontPosition = currentNoteNameFrontPosition.Remove((currentNoteNameFrontPosition.Length - 2), 2);

					currentNoteNameBackPosition = currentNote.Pitch.GetPositionAsString();
					currentNoteNameBackPosition = currentNoteNameBackPosition.Remove(0, 2);
				}
				// If this is the first iteration then there is no previous note to compare to.
				// The first note will have to be set manually.
				if (i == 0)
				{
					//The first note of the scale is the name of the scale
					currentNote.Name = Name;
					if (currentNote.Name == "As")
					{
						currentNote.Name = "Bf";
					}
					else if (currentNote.Name == "Cs")
					{
						currentNote.Name = "Df";
					}
					else if (currentNote.Name == "Cs")
					{
						currentNote.Name = "Df";
					}
					else if (currentNote.Name == "Ds")
					{
						currentNote.Name = "Ef";
					}
					else if (currentNote.Name == "Fs")
					{
						currentNote.Name = "Fs";
					}
					else if (currentNote.Name == "Gs")
					{
						currentNote.Name = "Af";
					}
					scale[i] = currentNote;
					continue;
				}
				//Get the last resolved note and increment the letter to get the next note
				//Then find the matching letter of the two possible names.
				else if (i >= 1)
				{
					previousNote = scale[i - 1];
					previousNoteName = previousNote.Name;
					if (previousNoteName.Length > 1) { previousNoteName = previousNoteName.Trim(); }

					char previousChar = previousNoteName[0];
					currentNoteNewName = ++previousChar;
					if (currentNoteNewName == 'H')
					{
						currentNoteNewName = 'A';
					}
					if (currentNoteNameFrontPosition[0] == currentNoteNewName)
					{
						currentNote.Name = currentNoteNameFrontPosition;
					}
					else
					{
						currentNote.Name = currentNoteNameBackPosition;
					}
					scale[i] = currentNote;
				}
			}
		}
	}
}
