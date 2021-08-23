/*
    CSC236 8N0 Intro to C#
    Project: Final Project
    File: MusicObject_Test.cs
    By: Len Mahaffey
    Last Edited: 12/11/20
    Description: MusicObject class testing
*/
using Xunit;
using CSC236_LMahaffey_FinalProject;

namespace MusicObject_Test
{
    public class ConstructorWithPosition_Test
    {
        [Fact]
        public void NONE_ConstructorWithPosition_Test ()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            MusicObject NONE = new MusicObject();
            Assert.Equal(expected, NONE.Pitch.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            MusicObject A = new MusicObject(new Pitch(Pitch.ChromaticScalePosition.A));
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            MusicObject AsBf = new MusicObject(new Pitch(Pitch.ChromaticScalePosition.AsBf));
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            MusicObject B = new MusicObject(new Pitch(Pitch.ChromaticScalePosition.B));
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            MusicObject C = new MusicObject(new Pitch(Pitch.ChromaticScalePosition.C));
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            MusicObject CsDf = new MusicObject(new Pitch(Pitch.ChromaticScalePosition.CsDf));
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            MusicObject D = new MusicObject(new Pitch(Pitch.ChromaticScalePosition.D));
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            MusicObject DsEf = new MusicObject(new Pitch(Pitch.ChromaticScalePosition.DsEf));
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            MusicObject E = new MusicObject(new Pitch(Pitch.ChromaticScalePosition.E));
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            MusicObject F = new MusicObject(new Pitch(Pitch.ChromaticScalePosition.F));
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            MusicObject FsGf = new MusicObject(new Pitch(Pitch.ChromaticScalePosition.FsGf));
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            MusicObject G = new MusicObject(new Pitch(Pitch.ChromaticScalePosition.G));
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            MusicObject GsAf = new MusicObject(new Pitch(Pitch.ChromaticScalePosition.GsAf));
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class ConstructorWithInt_Test
    {
        [Fact]
        public void NONE_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            MusicObject NONE = new MusicObject(0);
            Assert.Equal(expected, NONE.Pitch.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            MusicObject A = new MusicObject(1);
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            MusicObject AsBf = new MusicObject(2);
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            MusicObject B = new MusicObject(3);
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            MusicObject C = new MusicObject(4);
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            MusicObject CsDf = new MusicObject(5);
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            MusicObject D = new MusicObject(6);
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            MusicObject DsEf = new MusicObject(7);
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            MusicObject E = new MusicObject(8);
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            MusicObject F = new MusicObject(9);
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            MusicObject FsGf = new MusicObject(10);
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            MusicObject G = new MusicObject(11);
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            MusicObject GsAf = new MusicObject(12);
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class ConstructorWithString_Test
    {
        [Fact]
        public void NONE_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            MusicObject NONE = new MusicObject("NONE");
            Assert.Equal(expected, NONE.Pitch.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            MusicObject A = new MusicObject("A");
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            MusicObject AsBf = new MusicObject("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            MusicObject B = new MusicObject("B");
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            MusicObject C = new MusicObject("C");
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            MusicObject CsDf = new MusicObject("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            MusicObject D = new MusicObject("D");
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            MusicObject DsEf = new MusicObject("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            MusicObject E = new MusicObject("E");
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            MusicObject F = new MusicObject("F");
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            MusicObject FsGf = new MusicObject("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            MusicObject G = new MusicObject("G");
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            MusicObject GsAf = new MusicObject("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class GetPositionAsString_Test
    {
        [Fact]
        public void NONEgetPositionAsString_Test()
        {
            string expected = "NONE";
            MusicObject NONE = new MusicObject("NONE");
            Assert.Equal(expected, NONE.Pitch.GetPositionAsString());
        }
        [Fact]
        public void AgetPositionAsString_Test()
        {
            string expected = "A";
            MusicObject A = new MusicObject("A");
            Assert.Equal(expected, A.Pitch.GetPositionAsString());
        }
        [Fact]
        public void AsBfgetPositionAsString_Test()
        {
            string expected = "AsBf";
            MusicObject AsBf = new MusicObject("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void BgetPositionAsString_Test()
        {
            string expected = "B";
            MusicObject B = new MusicObject("B");
            Assert.Equal(expected, B.Pitch.GetPositionAsString());
        }
        [Fact]
        public void CgetPositionAsString_Test()
        {
            string expected = "C";
            MusicObject C = new MusicObject("C");
            Assert.Equal(expected, C.Pitch.GetPositionAsString());
        }
        [Fact]
        public void CsDfgetPositionAsString_Test()
        {
            string expected = "CsDf";
            MusicObject CsDf = new MusicObject("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void DgetPositionAsString_Test()
        {
            string expected = "D";
            MusicObject D = new MusicObject("D");
            Assert.Equal(expected, D.Pitch.GetPositionAsString());
        }
        [Fact]
        public void DsEfgetPositionAsString_Test()
        {
            string expected = "DsEf";
            MusicObject DsEf = new MusicObject("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void EgetPositionAsString_Test()
        {
            string expected = "E";
            MusicObject E = new MusicObject("E");
            Assert.Equal(expected, E.Pitch.GetPositionAsString());
        }
        [Fact]
        public void FgetPositionAsString_Test()
        {
            string expected = "F";
            MusicObject F = new MusicObject("F");
            Assert.Equal(expected, F.Pitch.GetPositionAsString());
        }
        [Fact]
        public void FsGfgetPositionAsString_Test()
        {
            string expected = "FsGf";
            MusicObject FsGf = new MusicObject("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void GgetPositionAsString_Test()
        {
            string expected = "G";
            MusicObject G = new MusicObject("G");
            Assert.Equal(expected, G.Pitch.GetPositionAsString());
        }
        [Fact]
        public void GsAfgetPositionAsString_Test()
        {
            string expected = "GsAf";
            MusicObject GsAf = new MusicObject("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetPositionAsString());
        }
    }
    public class GetWeight_Test
    {
        [Fact]
        public void NONE_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.NONE;
            MusicObject NONE = new MusicObject("NONE");
            Assert.Equal(expected, NONE.Pitch.GetWeight());
        }
        [Fact]
        public void A_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            MusicObject A = new MusicObject("A");
            Assert.Equal(expected, A.Pitch.GetWeight());
        }
        [Fact]
        public void AsBf_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Half;
            MusicObject AsBf = new MusicObject("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetWeight());
        }
        [Fact]
        public void B_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            MusicObject B = new MusicObject("B");
            Assert.Equal(expected, B.Pitch.GetWeight());
        }
        [Fact]
        public void C_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            MusicObject C = new MusicObject("C");
            Assert.Equal(expected, C.Pitch.GetWeight());
        }
        [Fact]
        public void CsDf_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Half;
            MusicObject CsDf = new MusicObject("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetWeight());
        }
        [Fact]
        public void D_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            MusicObject D = new MusicObject("D");
            Assert.Equal(expected, D.Pitch.GetWeight());
        }
        [Fact]
        public void DsEf_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Half;
            MusicObject DsEf = new MusicObject("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetWeight());
        }
        [Fact]
        public void E_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            MusicObject E = new MusicObject("E");
            Assert.Equal(expected, E.Pitch.GetWeight());
        }
        [Fact]
        public void F_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            MusicObject F = new MusicObject("F");
            Assert.Equal(expected, F.Pitch.GetWeight());
        }
        [Fact]
        public void FsGf_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Half;
            MusicObject FsGf = new MusicObject("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetWeight());
        }
        [Fact]
        public void G_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            MusicObject G = new MusicObject("G");
            Assert.Equal(expected, G.Pitch.GetWeight());
        }
        [Fact]
        public void GsAf_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Half;
            MusicObject GsAf = new MusicObject("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetWeight());
        }
    }
    public class GetWeightAsString_Test
    {
        [Fact]
        public void NONE_GetWeightAsString_Test()
        {
            string expected = "None";
            MusicObject NONE = new MusicObject("NONE");
            Assert.Equal(expected, NONE.Pitch.GetWeightAsString());
        }
        [Fact]
        public void A_GetWeightAsString_Test()
        {
            string expected = "Whole";
            MusicObject A = new MusicObject("A");
            Assert.Equal(expected, A.Pitch.GetWeightAsString());
        }
        [Fact]
        public void AsBf_GetWeightAsString_Test()
        {
            string expected = "Half";
            MusicObject AsBf = new MusicObject("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetWeightAsString());
        }
        [Fact]
        public void B_GetWeightAsString_Test()
        {
            string expected = "Whole";
            MusicObject B = new MusicObject("B");
            Assert.Equal(expected, B.Pitch.GetWeightAsString());
        }
        [Fact]
        public void C_GetWeightAsString_Test()
        {
            string expected = "Whole";
            MusicObject C = new MusicObject("C");
            Assert.Equal(expected, C.Pitch.GetWeightAsString());
        }
        [Fact]
        public void CsDf_GetWeightAsString_Test()
        {
            string expected = "Half";
            MusicObject CsDf = new MusicObject("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetWeightAsString());
        }
        [Fact]
        public void D_GetWeightAsString_Test()
        {
            string expected = "Whole";
            MusicObject D = new MusicObject("D");
            Assert.Equal(expected, D.Pitch.GetWeightAsString());
        }
        [Fact]
        public void DsEf_GetWeightAsString_Test()
        {
            string expected = "Half";
            MusicObject DsEf = new MusicObject("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetWeightAsString());
        }
        [Fact]
        public void E_GetWeightAsString_Test()
        {
            string expected = "Whole";
            MusicObject E = new MusicObject("E");
            Assert.Equal(expected, E.Pitch.GetWeightAsString());
        }
        [Fact]
        public void F_GetWeightAsString_Test()
        {
            string expected = "Whole";
            MusicObject F = new MusicObject("F");
            Assert.Equal(expected, F.Pitch.GetWeightAsString());
        }
        [Fact]
        public void FsGf_GetWeightAsString_Test()
        {
            string expected = "Half";
            MusicObject FsGf = new MusicObject("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetWeightAsString());
        }
        [Fact]
        public void G_GetWeightAsString_Test()
        {
            string expected = "Whole";
            MusicObject G = new MusicObject("G");
            Assert.Equal(expected, G.Pitch.GetWeightAsString());
        }
        [Fact]
        public void GsAf_GetWeightAsString_Test()
        {
            string expected = "Half";
            MusicObject GsAf = new MusicObject("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetWeightAsString());
        }
    }
    public class GetName_Test
    {
        [Fact]
        public void NONEgetPositionAsString_Test()
        {
            string expected = "NONE";
            MusicObject NONE = new MusicObject("NONE");
            Assert.Equal(expected, NONE.Name);
        }
        [Fact]
        public void AgetPositionAsString_Test()
        {
            string expected = "A";
            MusicObject A = new MusicObject("A");
            Assert.Equal(expected, A.Name);
        }
        [Fact]
        public void AsBfgetPositionAsString_Test()
        {
            string expected = "A♯/B♭";
            MusicObject AsBf = new MusicObject("AsBf");
            Assert.Equal(expected, AsBf.Name);
        }
        [Fact]
        public void AsgetPositionAsString_Test()
        {
            string expected = "A♯";
            MusicObject AsBf = new MusicObject("As");
            Assert.Equal(expected, AsBf.Name);
        }
        [Fact]
        public void BfgetPositionAsString_Test()
        {
            string expected = "B♭";
            MusicObject AsBf = new MusicObject("Bf");
            Assert.Equal(expected, AsBf.Name);
        }
        [Fact]
        public void BgetPositionAsString_Test()
        {
            string expected = "B";
            MusicObject B = new MusicObject("B");
            Assert.Equal(expected, B.Name);
        }
        [Fact]
        public void CgetPositionAsString_Test()
        {
            string expected = "C";
            MusicObject C = new MusicObject("C");
            Assert.Equal(expected, C.Name);
        }
        [Fact]
        public void CsDfgetPositionAsString_Test()
        {
            string expected = "C♯/D♭";
            MusicObject CsDf = new MusicObject("CsDf");
            Assert.Equal(expected, CsDf.Name);
        }
        [Fact]
        public void CsgetPositionAsString_Test()
        {
            string expected = "C♯";
            MusicObject CsDf = new MusicObject("Cs");
            Assert.Equal(expected, CsDf.Name);
        }
        [Fact]
        public void DfgetPositionAsString_Test()
        {
            string expected = "D♭";
            MusicObject CsDf = new MusicObject("Df");
            Assert.Equal(expected, CsDf.Name);
        }
        [Fact]
        public void DgetPositionAsString_Test()
        {
            string expected = "D";
            MusicObject D = new MusicObject("D");
            Assert.Equal(expected, D.Name);
        }
        [Fact]
        public void DsEfgetPositionAsString_Test()
        {
            string expected = "D♯/E♭";
            MusicObject DsEf = new MusicObject("DsEf");
            Assert.Equal(expected, DsEf.Name);
        }
        [Fact]
        public void DsgetPositionAsString_Test()
        {
            string expected = "D♯";
            MusicObject DsEf = new MusicObject("Ds");
            Assert.Equal(expected, DsEf.Name);
        }
        [Fact]
        public void EfgetPositionAsString_Test()
        {
            string expected = "E♭";
            MusicObject DsEf = new MusicObject("Ef");
            Assert.Equal(expected, DsEf.Name);
        }
        [Fact]
        public void EgetPositionAsString_Test()
        {
            string expected = "E";
            MusicObject E = new MusicObject("E");
            Assert.Equal(expected, E.Name);
        }
        [Fact]
        public void FgetPositionAsString_Test()
        {
            string expected = "F";
            MusicObject F = new MusicObject("F");
            Assert.Equal(expected, F.Name);
        }
        [Fact]
        public void FsGfgetPositionAsString_Test()
        {
            string expected = "F♯/G♭";
            MusicObject FsGf = new MusicObject("FsGf");
            Assert.Equal(expected, FsGf.Name);
        }
        [Fact]
        public void FsgetPositionAsString_Test()
        {
            string expected = "F♯";
            MusicObject FsGf = new MusicObject("Fs");
            Assert.Equal(expected, FsGf.Name);
        }
        [Fact]
        public void GfgetPositionAsString_Test()
        {
            string expected = "G♭";
            MusicObject FsGf = new MusicObject("Gf");
            Assert.Equal(expected, FsGf.Name);
        }
        [Fact]
        public void GgetPositionAsString_Test()
        {
            string expected = "G";
            MusicObject G = new MusicObject("G");
            Assert.Equal(expected, G.Name);
        }
        [Fact]
        public void GsAfgetPositionAsString_Test()
        {
            string expected = "G♯/A♭";
            MusicObject GsAf = new MusicObject("GsAf");
            Assert.Equal(expected, GsAf.Name);
        }
    }
    public class AccendHalfStep_Test
    {
        [Fact]
        public void A_AccendHalfStep_Test()
        {
            string expected = new MusicObject("AsBf").Name;
            MusicObject A_Object = new MusicObject("A");

            A_Object.AccendHalfStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void AsBf_AccendHalfStep_Test()
        {
            string expected = new MusicObject("B").Name;
            MusicObject A_Object = new MusicObject("AsBf");

            A_Object.AccendHalfStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void B_AccendHalfStep_Test()
        {
            string expected = new MusicObject("C").Name;
            MusicObject A_Object = new MusicObject("B");

            A_Object.AccendHalfStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void C_AccendHalfStep_Test()
        {
            string expected = new MusicObject("CsDf").Name;
            MusicObject A_Object = new MusicObject("C");

            A_Object.AccendHalfStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void CsDf_AccendHalfStep_Test()
        {
            string expected = new MusicObject("D").Name;
            MusicObject A_Object = new MusicObject("CsDf");

            A_Object.AccendHalfStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void D_AccendHalfStep_Test()
        {
            string expected = new MusicObject("DsEf").Name;
            MusicObject A_Object = new MusicObject("D");

            A_Object.AccendHalfStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void DsEf_AccendHalfStep_Test()
        {
            string expected = new MusicObject("E").Name;
            MusicObject A_Object = new MusicObject("DsEf");

            A_Object.AccendHalfStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void E_AccendHalfStep_Test()
        {
            string expected = new MusicObject("F").Name;
            MusicObject A_Object = new MusicObject("E");

            A_Object.AccendHalfStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void F_AccendHalfStep_Test()
        {
            string expected = new MusicObject("FsGf").Name;
            MusicObject A_Object = new MusicObject("F");

            A_Object.AccendHalfStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void FsGf_AccendHalfStep_Test()
        {
            string expected = new MusicObject("G").Name;
            MusicObject A_Object = new MusicObject("FsGf");

            A_Object.AccendHalfStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void G_AccendHalfStep_Test()
        {
            string expected = new MusicObject("GsAf").Name;
            MusicObject A_Object = new MusicObject("G");

            A_Object.AccendHalfStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void GsAf_AccendHalfStep_Test()
        {
            string expected = new MusicObject("A").Name;
            MusicObject A_Object = new MusicObject("GsAf");

            A_Object.AccendHalfStep();
            Assert.Equal(expected, A_Object.Name);
        }
    }
    public class AccendWholeStep_Test
    {
        [Fact]
        public void A_AccendWholeStep_Test()
        {
            string expected = new MusicObject("B").Name;
            MusicObject A_Object = new MusicObject("A");

            A_Object.AccendWholeStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void AsBf_AccendWholeStep_Test()
        {
            string expected = new MusicObject("C").Name;
            MusicObject A_Object = new MusicObject("AsBf");

            A_Object.AccendWholeStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void B_AccendWholeStep_Test()
        {
            string expected = new MusicObject("CsDf").Name;
            MusicObject A_Object = new MusicObject("B");

            A_Object.AccendWholeStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void C_AccendWholeStep_Test()
        {
            string expected = new MusicObject("D").Name;
            MusicObject A_Object = new MusicObject("C");

            A_Object.AccendWholeStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void CsDf_AccendWholeStep_Test()
        {
            string expected = new MusicObject("DsEf").Name;
            MusicObject A_Object = new MusicObject("CsDf");

            A_Object.AccendWholeStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void D_AccendWholeStep_Test()
        {
            string expected = new MusicObject("E").Name;
            MusicObject A_Object = new MusicObject("D");

            A_Object.AccendWholeStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void DsEf_AccendWholeStep_Test()
        {
            string expected = new MusicObject("F").Name;
            MusicObject A_Object = new MusicObject("DsEf");

            A_Object.AccendWholeStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void E_AccendWholeStep_Test()
        {
            string expected = new MusicObject("FsGf").Name;
            MusicObject A_Object = new MusicObject("E");

            A_Object.AccendWholeStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void F_AccendWholeStep_Test()
        {
            string expected = new MusicObject("G").Name;
            MusicObject A_Object = new MusicObject("F");

            A_Object.AccendWholeStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void FsGf_AccendWholeStep_Test()
        {
            string expected = new MusicObject("GsAf").Name;
            MusicObject A_Object = new MusicObject("FsGf");

            A_Object.AccendWholeStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void G_AccendWholeStep_Test()
        {
            string expected = new MusicObject("A").Name;
            MusicObject A_Object = new MusicObject("G");

            A_Object.AccendWholeStep();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void GsAf_AccendWholeStep_Test()
        {
            string expected = new MusicObject("AsBf").Name;
            MusicObject A_Object = new MusicObject("GsAf");

            A_Object.AccendWholeStep();
            Assert.Equal(expected, A_Object.Name);
        }
    }
    public class AccendStepAndAHalf_Test
        {
        [Fact]
        public void A_AccendStepAndAHalf_Test()
        {
            string expected = new MusicObject("C").Name;
            MusicObject A_Object = new MusicObject("A");

            A_Object.AccendStepAndAHalf();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void AsBf_AccendStepAndAHalf_Test()
        {
            string expected = new MusicObject("CsDf").Name;
            MusicObject A_Object = new MusicObject("AsBf");

            A_Object.AccendStepAndAHalf();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void B_AccendStepAndAHalf_Test()
        {
            string expected = new MusicObject("D").Name;
            MusicObject A_Object = new MusicObject("B");

            A_Object.AccendStepAndAHalf();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void C_AccendStepAndAHalf_Test()
        {
            string expected = new MusicObject("DsEf").Name;
            MusicObject A_Object = new MusicObject("C");

            A_Object.AccendStepAndAHalf();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void CsDf_AccendStepAndAHalf_Test()
        {
            string expected = new MusicObject("E").Name;
            MusicObject A_Object = new MusicObject("CsDf");

            A_Object.AccendStepAndAHalf();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void D_AccendStepAndAHalf_Test()
        {
            string expected = new MusicObject("F").Name;
            MusicObject A_Object = new MusicObject("D");

            A_Object.AccendStepAndAHalf();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void DsEf_AccendStepAndAHalf_Test()
        {
            string expected = new MusicObject("FsGf").Name;
            MusicObject A_Object = new MusicObject("DsEf");

            A_Object.AccendStepAndAHalf();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void E_AccendStepAndAHalf_Test()
        {
            string expected = new MusicObject("G").Name;
            MusicObject A_Object = new MusicObject("E");

            A_Object.AccendStepAndAHalf();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void F_AccendStepAndAHalf_Test()
        {
            string expected = new MusicObject("GsAf").Name;
            MusicObject A_Object = new MusicObject("F");

            A_Object.AccendStepAndAHalf();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void FsGf_AccendStepAndAHalf_Test()
        {
            string expected = new MusicObject("A").Name;
            MusicObject A_Object = new MusicObject("FsGf");

            A_Object.AccendStepAndAHalf();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void G_AccendStepAndAHalf_Test()
        {
            string expected = new MusicObject("AsBf").Name;
            MusicObject A_Object = new MusicObject("G");

            A_Object.AccendStepAndAHalf();
            Assert.Equal(expected, A_Object.Name);
        }
        [Fact]
        public void GsAf_AccendStepAndAHalf_Test()
        {
            string expected = new MusicObject("B").Name;
            MusicObject A_Object = new MusicObject("GsAf");

            A_Object.AccendStepAndAHalf();
            Assert.Equal(expected, A_Object.Name);
        }
    }
}
