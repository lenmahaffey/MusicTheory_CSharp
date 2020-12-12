/*
    CSC236 8N0 Intro to C#
    Project: Final Project
    File: Pitch_Test.cs
    By: Len Mahaffey
    Last Edited: 12/11/20
    Description: Pitch class testing
*/
using Xunit;
using CSC236_LMahaffey_FinalProject;

namespace Pitch_Test
{
    public class ConstructorWithPosition_Test
    {
        [Fact]
        public void NONE_ConstructorWithPosition_Test ()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            Pitch NONE = new Pitch();
            Assert.Equal(expected, NONE.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            Pitch A = new Pitch(Pitch.ChromaticScalePosition.A);
            Assert.Equal(expected, A.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            Pitch AsBf = new Pitch(Pitch.ChromaticScalePosition.AsBf);
            Assert.Equal(expected, AsBf.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            Pitch B = new Pitch(Pitch.ChromaticScalePosition.B);
            Assert.Equal(expected, B.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            Pitch C = new Pitch(Pitch.ChromaticScalePosition.C);
            Assert.Equal(expected, C.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            Pitch CsDf = new Pitch(Pitch.ChromaticScalePosition.CsDf);
            Assert.Equal(expected, CsDf.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            Pitch D = new Pitch(Pitch.ChromaticScalePosition.D);
            Assert.Equal(expected, D.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            Pitch DsEf = new Pitch(Pitch.ChromaticScalePosition.DsEf);
            Assert.Equal(expected, DsEf.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            Pitch E = new Pitch(Pitch.ChromaticScalePosition.E);
            Assert.Equal(expected, E.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            Pitch F = new Pitch(Pitch.ChromaticScalePosition.F);
            Assert.Equal(expected, F.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            Pitch FsGf = new Pitch(Pitch.ChromaticScalePosition.FsGf);
            Assert.Equal(expected, FsGf.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            Pitch G = new Pitch(Pitch.ChromaticScalePosition.G);
            Assert.Equal(expected, G.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            Pitch GsAf = new Pitch(Pitch.ChromaticScalePosition.GsAf);
            Assert.Equal(expected, GsAf.GetPosition());
        }
    }
    public class ConstructorWithInt_Test
    {
        [Fact]
        public void NONE_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            Pitch NONE = new Pitch(0);
            Assert.Equal(expected, NONE.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            Pitch A = new Pitch(1);
            Assert.Equal(expected, A.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            Pitch AsBf = new Pitch(2);
            Assert.Equal(expected, AsBf.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            Pitch B = new Pitch(3);
            Assert.Equal(expected, B.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            Pitch C = new Pitch(4);
            Assert.Equal(expected, C.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            Pitch CsDf = new Pitch(5);
            Assert.Equal(expected, CsDf.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            Pitch D = new Pitch(6);
            Assert.Equal(expected, D.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            Pitch DsEf = new Pitch(7);
            Assert.Equal(expected, DsEf.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            Pitch E = new Pitch(8);
            Assert.Equal(expected, E.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            Pitch F = new Pitch(9);
            Assert.Equal(expected, F.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            Pitch FsGf = new Pitch(10);
            Assert.Equal(expected, FsGf.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            Pitch G = new Pitch(11);
            Assert.Equal(expected, G.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            Pitch GsAf = new Pitch(12);
            Assert.Equal(expected, GsAf.GetPosition());
        }
    }
    public class ConstructorWithString_Test
    {
        [Fact]
        public void NONE_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            Pitch NONE = new Pitch("NONE");
            Assert.Equal(expected, NONE.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            Pitch A = new Pitch("A");
            Assert.Equal(expected, A.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            Pitch AsBf = new Pitch("AsBf");
            Assert.Equal(expected, AsBf.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            Pitch B = new Pitch("B");
            Assert.Equal(expected, B.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            Pitch C = new Pitch("C");
            Assert.Equal(expected, C.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            Pitch CsDf = new Pitch("CsDf");
            Assert.Equal(expected, CsDf.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            Pitch D = new Pitch("D");
            Assert.Equal(expected, D.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            Pitch DsEf = new Pitch("DsEf");
            Assert.Equal(expected, DsEf.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            Pitch E = new Pitch("E");
            Assert.Equal(expected, E.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            Pitch F = new Pitch("F");
            Assert.Equal(expected, F.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            Pitch FsGf = new Pitch("FsGf");
            Assert.Equal(expected, FsGf.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            Pitch G = new Pitch("G");
            Assert.Equal(expected, G.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            Pitch GsAf = new Pitch("GsAf");
            Assert.Equal(expected, GsAf.GetPosition());
        }
    }
    public class GetPositionAsString_Test
    {
        [Fact]
        public void NONEgetPositionAsString_Test()
        {
            string expected = "NONE";
            Pitch NONE = new Pitch("NONE");
            Assert.Equal(expected, NONE.GetPositionAsString());
        }
        [Fact]
        public void AgetPositionAsString_Test()
        {
            string expected = "A";
            Pitch A = new Pitch("A");
            Assert.Equal(expected, A.GetPositionAsString());
        }
        [Fact]
        public void AsBfgetPositionAsString_Test()
        {
            string expected = "AsBf";
            Pitch AsBf = new Pitch("AsBf");
            Assert.Equal(expected, AsBf.GetPositionAsString());
        }
        [Fact]
        public void BgetPositionAsString_Test()
        {
            string expected = "B";
            Pitch B = new Pitch("B");
            Assert.Equal(expected, B.GetPositionAsString());
        }
        [Fact]
        public void CgetPositionAsString_Test()
        {
            string expected = "C";
            Pitch C = new Pitch("C");
            Assert.Equal(expected, C.GetPositionAsString());
        }
        [Fact]
        public void CsDfgetPositionAsString_Test()
        {
            string expected = "CsDf";
            Pitch CsDf = new Pitch("CsDf");
            Assert.Equal(expected, CsDf.GetPositionAsString());
        }
        [Fact]
        public void DgetPositionAsString_Test()
        {
            string expected = "D";
            Pitch D = new Pitch("D");
            Assert.Equal(expected, D.GetPositionAsString());
        }
        [Fact]
        public void DsEfgetPositionAsString_Test()
        {
            string expected = "DsEf";
            Pitch DsEf = new Pitch("DsEf");
            Assert.Equal(expected, DsEf.GetPositionAsString());
        }
        [Fact]
        public void EgetPositionAsString_Test()
        {
            string expected = "E";
            Pitch E = new Pitch("E");
            Assert.Equal(expected, E.GetPositionAsString());
        }
        [Fact]
        public void FgetPositionAsString_Test()
        {
            string expected = "F";
            Pitch F = new Pitch("F");
            Assert.Equal(expected, F.GetPositionAsString());
        }
        [Fact]
        public void FsGfgetPositionAsString_Test()
        {
            string expected = "FsGf";
            Pitch FsGf = new Pitch("FsGf");
            Assert.Equal(expected, FsGf.GetPositionAsString());
        }
        [Fact]
        public void GgetPositionAsString_Test()
        {
            string expected = "G";
            Pitch G = new Pitch("G");
            Assert.Equal(expected, G.GetPositionAsString());
        }
        [Fact]
        public void GsAfgetPositionAsString_Test()
        {
            string expected = "GsAf";
            Pitch GsAf = new Pitch("GsAf");
            Assert.Equal(expected, GsAf.GetPositionAsString());
        }
    }
    public class GetWeight_Test
    {
        [Fact]
        public void NONE_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.NONE;
            Pitch NONE = new Pitch("NONE");
            Assert.Equal(expected, NONE.GetWeight());
        }
        [Fact]
        public void A_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            Pitch A = new Pitch("A");
            Assert.Equal(expected, A.GetWeight());
        }
        [Fact]
        public void AsBf_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Half;
            Pitch AsBf = new Pitch("AsBf");
            Assert.Equal(expected, AsBf.GetWeight());
        }
        [Fact]
        public void B_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            Pitch B = new Pitch("B");
            Assert.Equal(expected, B.GetWeight());
        }
        [Fact]
        public void C_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            Pitch C = new Pitch("C");
            Assert.Equal(expected, C.GetWeight());
        }
        [Fact]
        public void CsDf_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Half;
            Pitch CsDf = new Pitch("CsDf");
            Assert.Equal(expected, CsDf.GetWeight());
        }
        [Fact]
        public void D_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            Pitch D = new Pitch("D");
            Assert.Equal(expected, D.GetWeight());
        }
        [Fact]
        public void DsEf_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Half;
            Pitch DsEf = new Pitch("DsEf");
            Assert.Equal(expected, DsEf.GetWeight());
        }
        [Fact]
        public void E_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            Pitch E = new Pitch("E");
            Assert.Equal(expected, E.GetWeight());
        }
        [Fact]
        public void F_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            Pitch F = new Pitch("F");
            Assert.Equal(expected, F.GetWeight());
        }
        [Fact]
        public void FsGf_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Half;
            Pitch FsGf = new Pitch("FsGf");
            Assert.Equal(expected, FsGf.GetWeight());
        }
        [Fact]
        public void G_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Whole;
            Pitch G = new Pitch("G");
            Assert.Equal(expected, G.GetWeight());
        }
        [Fact]
        public void GsAf_GetWeight_Test()
        {
            Pitch.Weight expected = Pitch.Weight.Half;
            Pitch GsAf = new Pitch("GsAf");
            Assert.Equal(expected, GsAf.GetWeight());
        }
    }
    public class GetWeightAsString_Test
    {
        [Fact]
        public void NONE_GetWeightAsString_Test()
        {
            string expected = "None";
            Pitch NONE = new Pitch("NONE");
            Assert.Equal(expected, NONE.GetWeightAsString());
        }
        [Fact]
        public void A_GetWeightAsString_Test()
        {
            string expected = "Whole";
            Pitch A = new Pitch("A");
            Assert.Equal(expected, A.GetWeightAsString());
        }
        [Fact]
        public void AsBf_GetWeightAsString_Test()
        {
            string expected = "Half";
            Pitch AsBf = new Pitch("AsBf");
            Assert.Equal(expected, AsBf.GetWeightAsString());
        }
        [Fact]
        public void B_GetWeightAsString_Test()
        {
            string expected = "Whole";
            Pitch B = new Pitch("B");
            Assert.Equal(expected, B.GetWeightAsString());
        }
        [Fact]
        public void C_GetWeightAsString_Test()
        {
            string expected = "Whole";
            Pitch C = new Pitch("C");
            Assert.Equal(expected, C.GetWeightAsString());
        }
        [Fact]
        public void CsDf_GetWeightAsString_Test()
        {
            string expected = "Half";
            Pitch CsDf = new Pitch("CsDf");
            Assert.Equal(expected, CsDf.GetWeightAsString());
        }
        [Fact]
        public void D_GetWeightAsString_Test()
        {
            string expected = "Whole";
            Pitch D = new Pitch("D");
            Assert.Equal(expected, D.GetWeightAsString());
        }
        [Fact]
        public void DsEf_GetWeightAsString_Test()
        {
            string expected = "Half";
            Pitch DsEf = new Pitch("DsEf");
            Assert.Equal(expected, DsEf.GetWeightAsString());
        }
        [Fact]
        public void E_GetWeightAsString_Test()
        {
            string expected = "Whole";
            Pitch E = new Pitch("E");
            Assert.Equal(expected, E.GetWeightAsString());
        }
        [Fact]
        public void F_GetWeightAsString_Test()
        {
            string expected = "Whole";
            Pitch F = new Pitch("F");
            Assert.Equal(expected, F.GetWeightAsString());
        }
        [Fact]
        public void FsGf_GetWeightAsString_Test()
        {
            string expected = "Half";
            Pitch FsGf = new Pitch("FsGf");
            Assert.Equal(expected, FsGf.GetWeightAsString());
        }
        [Fact]
        public void G_GetWeightAsString_Test()
        {
            string expected = "Whole";
            Pitch G = new Pitch("G");
            Assert.Equal(expected, G.GetWeightAsString());
        }
        [Fact]
        public void GsAf_GetWeightAsString_Test()
        {
            string expected = "Half";
            Pitch GsAf = new Pitch("GsAf");
            Assert.Equal(expected, GsAf.GetWeightAsString());
        }
    }
}
