/*
    CSC236 8N0 Intro to C#
    Project: Final Project
    File: Note_Test.cs
    By: Len Mahaffey
    Last Edited: 12/11/20
    Description: Note class testing
*/
using Xunit;
using CSC236_LMahaffey_FinalProject;

namespace Note_Test
{
    public class ConstructorWithPosition_Test
    {
        [Fact]
        public void NONE_ConstructorWithPosition_Test ()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            Note NONE = new Note();
            Assert.Equal(expected, NONE.Pitch.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            Note A = new Note(new Pitch(Pitch.ChromaticScalePosition.A));
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            Note AsBf = new Note(new Pitch(Pitch.ChromaticScalePosition.AsBf));
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            Note B = new Note(new Pitch(Pitch.ChromaticScalePosition.B));
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            Note C = new Note(new Pitch(Pitch.ChromaticScalePosition.C));
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            Note CsDf = new Note(new Pitch(Pitch.ChromaticScalePosition.CsDf));
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            Note D = new Note(new Pitch(Pitch.ChromaticScalePosition.D));
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            Note DsEf = new Note(new Pitch(Pitch.ChromaticScalePosition.DsEf));
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            Note E = new Note(new Pitch(Pitch.ChromaticScalePosition.E));
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            Note F = new Note(new Pitch(Pitch.ChromaticScalePosition.F));
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            Note FsGf = new Note(new Pitch(Pitch.ChromaticScalePosition.FsGf));
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            Note G = new Note(new Pitch(Pitch.ChromaticScalePosition.G));
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            Note GsAf = new Note(new Pitch(Pitch.ChromaticScalePosition.GsAf));
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class ConstructorWithInt_Test
    {
        [Fact]
        public void NONE_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            Note NONE = new Note(0);
            Assert.Equal(expected, NONE.Pitch.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            Note A = new Note(1);
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            Note AsBf = new Note(2);
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            Note B = new Note(3);
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            Note C = new Note(4);
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            Note CsDf = new Note(5);
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            Note D = new Note(6);
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            Note DsEf = new Note(7);
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            Note E = new Note(8);
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            Note F = new Note(9);
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            Note FsGf = new Note(10);
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            Note G = new Note(11);
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            Note GsAf = new Note(12);
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class ConstructorWithString_Test
    {
        [Fact]
        public void NONE_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            Note NONE = new Note("NONE");
            Assert.Equal(expected, NONE.Pitch.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            Note A = new Note("A");
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            Note AsBf = new Note("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            Note B = new Note("B");
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            Note C = new Note("C");
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            Note CsDf = new Note("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            Note D = new Note("D");
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            Note DsEf = new Note("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            Note E = new Note("E");
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            Note F = new Note("F");
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            Note FsGf = new Note("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            Note G = new Note("G");
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            Note GsAf = new Note("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class GetPositionAsString_Test
    {
        [Fact]
        public void NONEgetPositionAsString_Test()
        {
            string expected = "NONE";
            Note NONE = new Note("NONE");
            Assert.Equal(expected, NONE.Pitch.GetPositionAsString());
        }
        [Fact]
        public void AgetPositionAsString_Test()
        {
            string expected = "A";
            Note A = new Note("A");
            Assert.Equal(expected, A.Pitch.GetPositionAsString());
        }
        [Fact]
        public void AsBfgetPositionAsString_Test()
        {
            string expected = "AsBf";
            Note AsBf = new Note("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void BgetPositionAsString_Test()
        {
            string expected = "B";
            Note B = new Note("B");
            Assert.Equal(expected, B.Pitch.GetPositionAsString());
        }
        [Fact]
        public void CgetPositionAsString_Test()
        {
            string expected = "C";
            Note C = new Note("C");
            Assert.Equal(expected, C.Pitch.GetPositionAsString());
        }
        [Fact]
        public void CsDfgetPositionAsString_Test()
        {
            string expected = "CsDf";
            Note CsDf = new Note("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void DgetPositionAsString_Test()
        {
            string expected = "D";
            Note D = new Note("D");
            Assert.Equal(expected, D.Pitch.GetPositionAsString());
        }
        [Fact]
        public void DsEfgetPositionAsString_Test()
        {
            string expected = "DsEf";
            Note DsEf = new Note("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void EgetPositionAsString_Test()
        {
            string expected = "E";
            Note E = new Note("E");
            Assert.Equal(expected, E.Pitch.GetPositionAsString());
        }
        [Fact]
        public void FgetPositionAsString_Test()
        {
            string expected = "F";
            Note F = new Note("F");
            Assert.Equal(expected, F.Pitch.GetPositionAsString());
        }
        [Fact]
        public void FsGfgetPositionAsString_Test()
        {
            string expected = "FsGf";
            Note FsGf = new Note("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void GgetPositionAsString_Test()
        {
            string expected = "G";
            Note G = new Note("G");
            Assert.Equal(expected, G.Pitch.GetPositionAsString());
        }
        [Fact]
        public void GsAfgetPositionAsString_Test()
        {
            string expected = "GsAf";
            Note GsAf = new Note("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetPositionAsString());
        }
    }
    public class GetWeight_Test
    {
        [Fact]
        public void NONE_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.NONE;
            Note NONE = new Note("NONE");
            Assert.Equal(expected, NONE.Pitch.GetWeight());
        }
        [Fact]
        public void A_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            Note A = new Note("A");
            Assert.Equal(expected, A.Pitch.GetWeight());
        }
        [Fact]
        public void AsBf_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Half;
            Note AsBf = new Note("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetWeight());
        }
        [Fact]
        public void B_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            Note B = new Note("B");
            Assert.Equal(expected, B.Pitch.GetWeight());
        }
        [Fact]
        public void C_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            Note C = new Note("C");
            Assert.Equal(expected, C.Pitch.GetWeight());
        }
        [Fact]
        public void CsDf_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Half;
            Note CsDf = new Note("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetWeight());
        }
        [Fact]
        public void D_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            Note D = new Note("D");
            Assert.Equal(expected, D.Pitch.GetWeight());
        }
        [Fact]
        public void DsEf_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Half;
            Note DsEf = new Note("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetWeight());
        }
        [Fact]
        public void E_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            Note E = new Note("E");
            Assert.Equal(expected, E.Pitch.GetWeight());
        }
        [Fact]
        public void F_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            Note F = new Note("F");
            Assert.Equal(expected, F.Pitch.GetWeight());
        }
        [Fact]
        public void FsGf_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Half;
            Note FsGf = new Note("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetWeight());
        }
        [Fact]
        public void G_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            Note G = new Note("G");
            Assert.Equal(expected, G.Pitch.GetWeight());
        }
        [Fact]
        public void GsAf_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Half;
            Note GsAf = new Note("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetWeight());
        }
    }
    public class GetWeightAsString_Test
    {
        [Fact]
        public void NONE_GetWeightAsString_Test()
        {
            string expected = "None";
            Note NONE = new Note("NONE");
            Assert.Equal(expected, NONE.Pitch.GetWeightAsString());
        }
        [Fact]
        public void A_GetWeightAsString_Test()
        {
            string expected = "Whole";
            Note A = new Note("A");
            Assert.Equal(expected, A.Pitch.GetWeightAsString());
        }
        [Fact]
        public void AsBf_GetWeightAsString_Test()
        {
            string expected = "Half";
            Note AsBf = new Note("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetWeightAsString());
        }
        [Fact]
        public void B_GetWeightAsString_Test()
        {
            string expected = "Whole";
            Note B = new Note("B");
            Assert.Equal(expected, B.Pitch.GetWeightAsString());
        }
        [Fact]
        public void C_GetWeightAsString_Test()
        {
            string expected = "Whole";
            Note C = new Note("C");
            Assert.Equal(expected, C.Pitch.GetWeightAsString());
        }
        [Fact]
        public void CsDf_GetWeightAsString_Test()
        {
            string expected = "Half";
            Note CsDf = new Note("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetWeightAsString());
        }
        [Fact]
        public void D_GetWeightAsString_Test()
        {
            string expected = "Whole";
            Note D = new Note("D");
            Assert.Equal(expected, D.Pitch.GetWeightAsString());
        }
        [Fact]
        public void DsEf_GetWeightAsString_Test()
        {
            string expected = "Half";
            Note DsEf = new Note("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetWeightAsString());
        }
        [Fact]
        public void E_GetWeightAsString_Test()
        {
            string expected = "Whole";
            Note E = new Note("E");
            Assert.Equal(expected, E.Pitch.GetWeightAsString());
        }
        [Fact]
        public void F_GetWeightAsString_Test()
        {
            string expected = "Whole";
            Note F = new Note("F");
            Assert.Equal(expected, F.Pitch.GetWeightAsString());
        }
        [Fact]
        public void FsGf_GetWeightAsString_Test()
        {
            string expected = "Half";
            Note FsGf = new Note("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetWeightAsString());
        }
        [Fact]
        public void G_GetWeightAsString_Test()
        {
            string expected = "Whole";
            Note G = new Note("G");
            Assert.Equal(expected, G.Pitch.GetWeightAsString());
        }
        [Fact]
        public void GsAf_GetWeightAsString_Test()
        {
            string expected = "Half";
            Note GsAf = new Note("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetWeightAsString());
        }
    }
}
