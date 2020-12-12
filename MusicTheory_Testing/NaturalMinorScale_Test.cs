/*
    CSC236 8N0 Intro to C#
    Project: Final Project
    File: NaturalMinor_Test.cs
    By: Len Mahaffey
    Last Edited: 12/11/20
    Description: NaturalMinor class testing
*/
using CSC236_LMahaffey_FinalProject;
using Xunit;

namespace NaturalMinorScale_Test
{
    public class ConstructorWithPosition_Test
    {
        [Fact]
        public void A_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            NaturalMinorScale A = new NaturalMinorScale(new Pitch(Pitch.ChromaticScalePosition.A));
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            NaturalMinorScale AsBf = new NaturalMinorScale(new Pitch(Pitch.ChromaticScalePosition.AsBf));
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            NaturalMinorScale B = new NaturalMinorScale(new Pitch(Pitch.ChromaticScalePosition.B));
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            NaturalMinorScale C = new NaturalMinorScale(new Pitch(Pitch.ChromaticScalePosition.C));
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            NaturalMinorScale CsDf = new NaturalMinorScale(new Pitch(Pitch.ChromaticScalePosition.CsDf));
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            NaturalMinorScale D = new NaturalMinorScale(new Pitch(Pitch.ChromaticScalePosition.D));
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            NaturalMinorScale DsEf = new NaturalMinorScale(new Pitch(Pitch.ChromaticScalePosition.DsEf));
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            NaturalMinorScale E = new NaturalMinorScale(new Pitch(Pitch.ChromaticScalePosition.E));
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            NaturalMinorScale F = new NaturalMinorScale(new Pitch(Pitch.ChromaticScalePosition.F));
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            NaturalMinorScale FsGf = new NaturalMinorScale(new Pitch(Pitch.ChromaticScalePosition.FsGf));
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            NaturalMinorScale G = new NaturalMinorScale(new Pitch(Pitch.ChromaticScalePosition.G));
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            NaturalMinorScale GsAf = new NaturalMinorScale(new Pitch(Pitch.ChromaticScalePosition.GsAf));
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class ConstructorWithInt_Test
    {
        [Fact]
        public void NONE_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            NaturalMinorScale NONE = new NaturalMinorScale(0);
            Assert.Equal(expected, NONE.Pitch.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            NaturalMinorScale A = new NaturalMinorScale(1);
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            NaturalMinorScale AsBf = new NaturalMinorScale(2);
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            NaturalMinorScale B = new NaturalMinorScale(3);
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            NaturalMinorScale C = new NaturalMinorScale(4);
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            NaturalMinorScale CsDf = new NaturalMinorScale(5);
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            NaturalMinorScale D = new NaturalMinorScale(6);
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            NaturalMinorScale DsEf = new NaturalMinorScale(7);
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            NaturalMinorScale E = new NaturalMinorScale(8);
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            NaturalMinorScale F = new NaturalMinorScale(9);
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            NaturalMinorScale FsGf = new NaturalMinorScale(10);
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            NaturalMinorScale G = new NaturalMinorScale(11);
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            NaturalMinorScale GsAf = new NaturalMinorScale(12);
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class ConstructorWithString_Test
    {
        [Fact]
        public void NONE_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            NaturalMinorScale NONE = new NaturalMinorScale("NONE");
            Assert.Equal(expected, NONE.Pitch.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            NaturalMinorScale A = new NaturalMinorScale("A");
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            NaturalMinorScale AsBf = new NaturalMinorScale("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            NaturalMinorScale B = new NaturalMinorScale("B");
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            NaturalMinorScale C = new NaturalMinorScale("C");
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            NaturalMinorScale CsDf = new NaturalMinorScale("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            NaturalMinorScale D = new NaturalMinorScale("D");
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            NaturalMinorScale DsEf = new NaturalMinorScale("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            NaturalMinorScale E = new NaturalMinorScale("E");
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            NaturalMinorScale F = new NaturalMinorScale("F");
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            NaturalMinorScale FsGf = new NaturalMinorScale("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            NaturalMinorScale G = new NaturalMinorScale("G");
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            NaturalMinorScale GsAf = new NaturalMinorScale("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class GetPositionAsString_Test
    {
        [Fact]
        public void NONE_getPositionAsString_Test()
        {
            string expected = "NONE";
            NaturalMinorScale NONE = new NaturalMinorScale("NONE");
            Assert.Equal(expected, NONE.Pitch.GetPositionAsString());
        }
        [Fact]
        public void A_getPositionAsString_Test()
        {
            string expected = "A";
            NaturalMinorScale A = new NaturalMinorScale("A");
            Assert.Equal(expected, A.Pitch.GetPositionAsString());
        }
        [Fact]
        public void AsBf_getPositionAsString_Test()
        {
            string expected = "AsBf";
            NaturalMinorScale AsBf = new NaturalMinorScale("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void B_getPositionAsString_Test()
        {
            string expected = "B";
            NaturalMinorScale B = new NaturalMinorScale("B");
            Assert.Equal(expected, B.Pitch.GetPositionAsString());
        }
        [Fact]
        public void C_getPositionAsString_Test()
        {
            string expected = "C";
            NaturalMinorScale C = new NaturalMinorScale("C");
            Assert.Equal(expected, C.Pitch.GetPositionAsString());
        }
        [Fact]
        public void CsDf_getPositionAsString_Test()
        {
            string expected = "CsDf";
            NaturalMinorScale CsDf = new NaturalMinorScale("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void D_getPositionAsString_Test()
        {
            string expected = "D";
            NaturalMinorScale D = new NaturalMinorScale("D");
            Assert.Equal(expected, D.Pitch.GetPositionAsString());
        }
        [Fact]
        public void DsEf_getPositionAsString_Test()
        {
            string expected = "DsEf";
            NaturalMinorScale DsEf = new NaturalMinorScale("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void E_getPositionAsString_Test()
        {
            string expected = "E";
            NaturalMinorScale E = new NaturalMinorScale("E");
            Assert.Equal(expected, E.Pitch.GetPositionAsString());
        }
        [Fact]
        public void F_getPositionAsString_Test()
        {
            string expected = "F";
            NaturalMinorScale F = new NaturalMinorScale("F");
            Assert.Equal(expected, F.Pitch.GetPositionAsString());
        }
        [Fact]
        public void FsGf_getPositionAsString_Test()
        {
            string expected = "FsGf";
            NaturalMinorScale FsGf = new NaturalMinorScale("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void G_getPositionAsString_Test()
        {
            string expected = "G";
            NaturalMinorScale G = new NaturalMinorScale("G");
            Assert.Equal(expected, G.Pitch.GetPositionAsString());
        }
        [Fact]
        public void GsAf_getPositionAsString_Test()
        {
            string expected = "GsAf";
            NaturalMinorScale GsAf = new NaturalMinorScale("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetPositionAsString());
        }
    }
    public class GetName_Test
    {
        [Fact]
        public void NONE_getPositionAsString_Test()
        {
            string expected = "NONE";
            NaturalMinorScale NONE = new NaturalMinorScale("NONE");
            Assert.Equal(expected, NONE.Name);
        }
        [Fact]
        public void A_getPositionAsString_Test()
        {
            string expected = "A";
            NaturalMinorScale A = new NaturalMinorScale("A");
            Assert.Equal(expected, A.Name);
        }
        [Fact]
        public void AsBf_getPositionAsString_Test()
        {
            string expected = "A♯/B♭";
            NaturalMinorScale AsBf = new NaturalMinorScale("AsBf");
            Assert.Equal(expected, AsBf.Name);
        }
        [Fact]
        public void As_getPositionAsString_Test()
        {
            string expected = "A♯";
            NaturalMinorScale AsBf = new NaturalMinorScale("As");
            Assert.Equal(expected, AsBf.Name);
        }
        [Fact]
        public void Bf_getPositionAsString_Test()
        {
            string expected = "B♭";
            NaturalMinorScale AsBf = new NaturalMinorScale("Bf");
            Assert.Equal(expected, AsBf.Name);
        }
        [Fact]
        public void B_getPositionAsString_Test()
        {
            string expected = "B";
            NaturalMinorScale B = new NaturalMinorScale("B");
            Assert.Equal(expected, B.Name);
        }
        [Fact]
        public void C_getPositionAsString_Test()
        {
            string expected = "C";
            NaturalMinorScale C = new NaturalMinorScale("C");
            Assert.Equal(expected, C.Name);
        }
        [Fact]
        public void CsDf_getPositionAsString_Test()
        {
            string expected = "C♯/D♭";
            NaturalMinorScale CsDf = new NaturalMinorScale("CsDf");
            Assert.Equal(expected, CsDf.Name);
        }
        [Fact]
        public void Cs_getPositionAsString_Test()
        {
            string expected = "C♯";
            NaturalMinorScale CsDf = new NaturalMinorScale("Cs");
            Assert.Equal(expected, CsDf.Name);
        }
        [Fact]
        public void Df_getPositionAsString_Test()
        {
            string expected = "D♭";
            NaturalMinorScale CsDf = new NaturalMinorScale("Df");
            Assert.Equal(expected, CsDf.Name);
        }
        [Fact]
        public void D_getPositionAsString_Test()
        {
            string expected = "D";
            NaturalMinorScale D = new NaturalMinorScale("D");
            Assert.Equal(expected, D.Name);
        }
        [Fact]
        public void DsEf_getPositionAsString_Test()
        {
            string expected = "D♯/E♭";
            NaturalMinorScale DsEf = new NaturalMinorScale("DsEf");
            Assert.Equal(expected, DsEf.Name);
        }
        [Fact]
        public void Ds_getPositionAsString_Test()
        {
            string expected = "D♯";
            NaturalMinorScale DsEf = new NaturalMinorScale("Ds");
            Assert.Equal(expected, DsEf.Name);
        }
        [Fact]
        public void Ef_getPositionAsString_Test()
        {
            string expected = "E♭";
            NaturalMinorScale DsEf = new NaturalMinorScale("Ef");
            Assert.Equal(expected, DsEf.Name);
        }
        [Fact]
        public void E_getPositionAsString_Test()
        {
            string expected = "E";
            NaturalMinorScale E = new NaturalMinorScale("E");
            Assert.Equal(expected, E.Name);
        }
        [Fact]
        public void F_getPositionAsString_Test()
        {
            string expected = "F";
            NaturalMinorScale F = new NaturalMinorScale("F");
            Assert.Equal(expected, F.Name);
        }
        [Fact]
        public void FsGf_getPositionAsString_Test()
        {
            string expected = "F♯/G♭";
            NaturalMinorScale FsGf = new NaturalMinorScale("FsGf");
            Assert.Equal(expected, FsGf.Name);
        }
        [Fact]
        public void Fs_GetPositionAsString_Test()
        {
            string expected = "F♯";
            NaturalMinorScale FsGf = new NaturalMinorScale("Fs");
            Assert.Equal(expected, FsGf.Name);
        }
        [Fact]
        public void Gf_getPositionAsString_Test()
        {
            string expected = "G♭";
            NaturalMinorScale FsGf = new NaturalMinorScale("Gf");
            Assert.Equal(expected, FsGf.Name);
        }
        [Fact]
        public void G_getPositionAsString_Test()
        {
            string expected = "G";
            NaturalMinorScale G = new NaturalMinorScale("G");
            Assert.Equal(expected, G.Name);
        }
        [Fact]
        public void GsAf_getPositionAsString_Test()
        {
            string expected = "G♯/A♭";
            NaturalMinorScale GsAf = new NaturalMinorScale("GsAf");
            Assert.Equal(expected, GsAf.Name);
        }
    }
    public class AccendHalfStep_Test
    {
        [Fact]
        public void A_AccendHalfStep_Test()
        {
            string expected = new NaturalMinorScale("AsBf").Name;
            NaturalMinorScale A_Scale = new NaturalMinorScale("A");

            A_Scale.AccendHalfStep();
            Assert.Equal(expected, A_Scale.Name);
        }
        [Fact]
        public void AsBf_AccendHalfStep_Test()
        {
            string expected = new NaturalMinorScale("B").Name;
            NaturalMinorScale AsBf_Scale = new NaturalMinorScale("AsBf");

            AsBf_Scale.AccendHalfStep();
            Assert.Equal(expected, AsBf_Scale.Name);
        }
        [Fact]
        public void B_AccendHalfStep_Test()
        {
            string expected = new NaturalMinorScale("C").Name;
            NaturalMinorScale B_Scale = new NaturalMinorScale("B");

            B_Scale.AccendHalfStep();
            Assert.Equal(expected, B_Scale.Name);
        }
        [Fact]
        public void C_AccendHalfStep_Test()
        {
            string expected = new NaturalMinorScale("CsDf").Name;
            NaturalMinorScale C_Scale = new NaturalMinorScale("C");

            C_Scale.AccendHalfStep();
            Assert.Equal(expected, C_Scale.Name);
        }
        [Fact]
        public void CsDf_AccendHalfStep_Test()
        {
            string expected = new NaturalMinorScale("D").Name;
            NaturalMinorScale CsDf_Scale = new NaturalMinorScale("CsDf");

            CsDf_Scale.AccendHalfStep();
            Assert.Equal(expected, CsDf_Scale.Name);
        }
        [Fact]
        public void D_AccendHalfStep_Test()
        {
            string expected = new NaturalMinorScale("DsEf").Name;
            NaturalMinorScale D_Scale = new NaturalMinorScale("D");

            D_Scale.AccendHalfStep();
            Assert.Equal(expected, D_Scale.Name);
        }
        [Fact]
        public void DsEf_AccendHalfStep_Test()
        {
            string expected = new NaturalMinorScale("E").Name;
            NaturalMinorScale DsEf_Scale = new NaturalMinorScale("DsEf");

            DsEf_Scale.AccendHalfStep();
            Assert.Equal(expected, DsEf_Scale.Name);
        }
        [Fact]
        public void E_AccendHalfStep_Test()
        {
            string expected = new NaturalMinorScale("F").Name;
            NaturalMinorScale E_Scale = new NaturalMinorScale("E");

            E_Scale.AccendHalfStep();
            Assert.Equal(expected, E_Scale.Name);
        }
        [Fact]
        public void F_AccendHalfStep_Test()
        {
            string expected = new NaturalMinorScale("FsGf").Name;
            NaturalMinorScale F_Scale = new NaturalMinorScale("F");

            F_Scale.AccendHalfStep();
            Assert.Equal(expected, F_Scale.Name);
        }
        [Fact]
        public void fSGf_AccendHalfStep_Test()
        {
            string expected = new NaturalMinorScale("G").Name;
            NaturalMinorScale fSGf_Scale = new NaturalMinorScale("FsGf");

            fSGf_Scale.AccendHalfStep();
            Assert.Equal(expected, fSGf_Scale.Name);
        }
        [Fact]
        public void G_AccendHalfStep_Test()
        {
            string expected = new NaturalMinorScale("GsAf").Name;
            NaturalMinorScale G_Scale = new NaturalMinorScale("G");

            G_Scale.AccendHalfStep();
            Assert.Equal(expected, G_Scale.Name);
        }
        [Fact]
        public void GsAf_AccendHalfStep_Test()
        {
            string expected = new NaturalMinorScale("A").Name;
            NaturalMinorScale GsAf_Scale = new NaturalMinorScale("GsAf");

            GsAf_Scale.AccendHalfStep();
            Assert.Equal(expected, GsAf_Scale.Name);
        }
    }
    public class AccendWholeStep_Test
    {
        [Fact]
        public void A_AccendWholeStep_Test()
        {
            string expected = new NaturalMinorScale("B").Name;
            NaturalMinorScale A_Scale = new NaturalMinorScale("A");

            A_Scale.AccendWholeStep();
            Assert.Equal(expected, A_Scale.Name);
        }
        [Fact]
        public void AsBf_AccendWholeStep_Test()
        {
            string expected = new NaturalMinorScale("C").Name;
            NaturalMinorScale AsBf_Scale = new NaturalMinorScale("AsBf");

            AsBf_Scale.AccendWholeStep();
            Assert.Equal(expected, AsBf_Scale.Name);
        }
        [Fact]
        public void B_AccendWholeStep_Test()
        {
            string expected = new NaturalMinorScale("CsDf").Name;
            NaturalMinorScale B_Scale = new NaturalMinorScale("B");

            B_Scale.AccendWholeStep();
            Assert.Equal(expected, B_Scale.Name);
        }
        [Fact]
        public void C_AccendWholeStep_Test()
        {
            string expected = new NaturalMinorScale("D").Name;
            NaturalMinorScale C_Scale = new NaturalMinorScale("C");

            C_Scale.AccendWholeStep();
            Assert.Equal(expected, C_Scale.Name);
        }
        [Fact]
        public void CsDf_AccendWholeStep_Test()
        {
            string expected = new NaturalMinorScale("DsEf").Name;
            NaturalMinorScale CsDf_Scale = new NaturalMinorScale("CsDf");

            CsDf_Scale.AccendWholeStep();
            Assert.Equal(expected, CsDf_Scale.Name);
        }
        [Fact]
        public void D_AccendWholeStep_Test()
        {
            string expected = new NaturalMinorScale("E").Name;
            NaturalMinorScale D_Scale = new NaturalMinorScale("D");

            D_Scale.AccendWholeStep();
            Assert.Equal(expected, D_Scale.Name);
        }
        [Fact]
        public void DsEf_AccendWholeStep_Test()
        {
            string expected = new NaturalMinorScale("F").Name;
            NaturalMinorScale DsEf_Scale = new NaturalMinorScale("DsEf");

            DsEf_Scale.AccendWholeStep();
            Assert.Equal(expected, DsEf_Scale.Name);
        }
        [Fact]
        public void E_AccendWholeStep_Test()
        {
            string expected = new NaturalMinorScale("FsGf").Name;
            NaturalMinorScale E_Scale = new NaturalMinorScale("E");

            E_Scale.AccendWholeStep();
            Assert.Equal(expected, E_Scale.Name);
        }
        [Fact]
        public void F_AccendWholeStep_Test()
        {
            string expected = new NaturalMinorScale("G").Name;
            NaturalMinorScale F_Scale = new NaturalMinorScale("F");

            F_Scale.AccendWholeStep();
            Assert.Equal(expected, F_Scale.Name);
        }
        [Fact]
        public void FsGf_AccendWholeStep_Test()
        {
            string expected = new NaturalMinorScale("GsAf").Name;
            NaturalMinorScale FsGf_Scale = new NaturalMinorScale("FsGf");

            FsGf_Scale.AccendWholeStep();
            Assert.Equal(expected, FsGf_Scale.Name);
        }
        [Fact]
        public void G_AccendWholeStep_Test()
        {
            string expected = new NaturalMinorScale("A").Name;
            NaturalMinorScale G_Scale = new NaturalMinorScale("G");

            G_Scale.AccendWholeStep();
            Assert.Equal(expected, G_Scale.Name);
        }
        [Fact]
        public void GsAf_AccendWholeStep_Test()
        {
            string expected = new NaturalMinorScale("AsBf").Name;
            NaturalMinorScale GsAf_Scale = new NaturalMinorScale("GsAf");

            GsAf_Scale.AccendWholeStep();
            Assert.Equal(expected, GsAf_Scale.Name);
        }
    }
    public class AccendStepAndAHalf_Test
        {
        [Fact]
        public void A_AccendStepAndAHalf_Test()
        {
            string expected = new NaturalMinorScale("C").Name;
            NaturalMinorScale A_Scale = new NaturalMinorScale("A");

            A_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, A_Scale.Name);
        }
        [Fact]
        public void AsBf_AccendStepAndAHalf_Test()
        {
            string expected = new NaturalMinorScale("CsDf").Name;
            NaturalMinorScale AsBf_Scale = new NaturalMinorScale("AsBf");

            AsBf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, AsBf_Scale.Name);
        }
        [Fact]
        public void B_AccendStepAndAHalf_Test()
        {
            string expected = new NaturalMinorScale("D").Name;
            NaturalMinorScale B_Scale = new NaturalMinorScale("B");

            B_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, B_Scale.Name);
        }
        [Fact]
        public void C_AccendStepAndAHalf_Test()
        {
            string expected = new NaturalMinorScale("DsEf").Name;
            NaturalMinorScale C_Scale = new NaturalMinorScale("C");

            C_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, C_Scale.Name);
        }
        [Fact]
        public void CsDf_AccendStepAndAHalf_Test()
        {
            string expected = new NaturalMinorScale("E").Name;
            NaturalMinorScale CsDf_Scale = new NaturalMinorScale("CsDf");

            CsDf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, CsDf_Scale.Name);
        }
        [Fact]
        public void D_AccendStepAndAHalf_Test()
        {
            string expected = new NaturalMinorScale("F").Name;
            NaturalMinorScale D_Scale = new NaturalMinorScale("D");

            D_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, D_Scale.Name);
        }
        [Fact]
        public void DsEf_AccendStepAndAHalf_Test()
        {
            string expected = new NaturalMinorScale("FsGf").Name;
            NaturalMinorScale DsEf_Scale = new NaturalMinorScale("DsEf");

            DsEf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, DsEf_Scale.Name);
        }
        [Fact]
        public void E_AccendStepAndAHalf_Test()
        {
            string expected = new NaturalMinorScale("G").Name;
            NaturalMinorScale E_Scale = new NaturalMinorScale("E");

            E_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, E_Scale.Name);
        }
        [Fact]
        public void F_AccendStepAndAHalf_Test()
        {
            string expected = new NaturalMinorScale("GsAf").Name;
            NaturalMinorScale F_Scale = new NaturalMinorScale("F");

            F_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, F_Scale.Name);
        }
        [Fact]
        public void FsGf_AccendStepAndAHalf_Test()
        {
            string expected = new NaturalMinorScale("A").Name;
            NaturalMinorScale FsGf_Scale = new NaturalMinorScale("FsGf");

            FsGf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, FsGf_Scale.Name);
        }
        [Fact]
        public void G_AccendStepAndAHalf_Test()
        {
            string expected = new NaturalMinorScale("AsBf").Name;
            NaturalMinorScale G_Scale = new NaturalMinorScale("G");

            G_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, G_Scale.Name);
        }
        [Fact]
        public void GsAf_AccendStepAndAHalf_Test()
        {
            string expected = new NaturalMinorScale("B").Name;
            NaturalMinorScale GsAf_Scale = new NaturalMinorScale("GsAf");

            GsAf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, GsAf_Scale.Name);
        }
    }
    public class getUnresolvedScale_Test
    {
        [Fact]
        public void AMajor_getUnresolvedScale_Test()
        {
            string expected = "A B C D E F G";
            NaturalMinorScale scaleToTest = new NaturalMinorScale("A");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());

        }
        [Fact]
        public void AsBfMajor_getUnresolvedScale_Test()

        {
            string expected = "A♯/B♭ C C♯/D♭ D♯/E♭ F F♯/G♭ G♯/A♭";
            NaturalMinorScale scaleToTest = new NaturalMinorScale("AsBf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void BMajor_getUnresolvedScale_Test()

        {
            string expected = "B C♯/D♭ D E F♯/G♭ G A";
            NaturalMinorScale scaleToTest = new NaturalMinorScale("B");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());

        }
        [Fact]
        public void CMajor_getUnresolvedScale_Test()

        {
            string expected = "C D D♯/E♭ F G G♯/A♭ A♯/B♭";
            NaturalMinorScale scaleToTest = new NaturalMinorScale("C");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void CsDfMajor_getUnresolvedScale_Test()

        {
            string expected = "C♯/D♭ D♯/E♭ E F♯/G♭ G♯/A♭ A B";
            NaturalMinorScale scaleToTest = new NaturalMinorScale("CsDf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void DMajor_getUnresolvedScale_Test()

        {
            string expected = "D E F G A A♯/B♭ C";
            NaturalMinorScale scaleToTest = new NaturalMinorScale("D");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void DsEfMajor_getUnresolvedScale_Test()

        {
            string expected = "D♯/E♭ F F♯/G♭ G♯/A♭ A♯/B♭ B C♯/D♭";
            NaturalMinorScale scaleToTest = new NaturalMinorScale("DsEf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void EMajor_getUnresolvedScale_Test()

        {
            string expected = "E F♯/G♭ G A B C D";
            NaturalMinorScale scaleToTest = new NaturalMinorScale("E");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void FMajor_getUnresolvedScale_Test()

        {
            string expected = "F G G♯/A♭ A♯/B♭ C C♯/D♭ D♯/E♭";
            NaturalMinorScale scaleToTest = new NaturalMinorScale("F");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void FsGfMajor_getUnresolvedScale_Test()

        {
            string expected = "F♯/G♭ G♯/A♭ A B C♯/D♭ D E";
            NaturalMinorScale scaleToTest = new NaturalMinorScale("FsGf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void GMajor_getUnresolvedScale_Test()

        {
            string expected = "G A A♯/B♭ C D D♯/E♭ F";
            NaturalMinorScale scaleToTest = new NaturalMinorScale("G");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void GsAfMajor_getUnresolvedScale_Test()

        {
            string expected = "G♯/A♭ A♯/B♭ B C♯/D♭ D♯/E♭ E F♯/G♭";
            NaturalMinorScale scaleToTest = new NaturalMinorScale("GsAf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
    };
}
