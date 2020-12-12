/*
    CSC236 8N0 Intro to C#
    Project: Final Project
    File: HarmonicMinorScale_Test.cs
    By: Len Mahaffey
    Last Edited: 12/11/20
    Description: HarmonicMinorScale class testing
*/
using CSC236_LMahaffey_FinalProject;
using Xunit;

namespace HarmonicMinorScale_Test
{
    public class ConstructorWithPosition_Test
    {
        [Fact]
        public void A_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            HarmonicMinorScale A = new HarmonicMinorScale(new Pitch(Pitch.ChromaticScalePosition.A));
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            HarmonicMinorScale AsBf = new HarmonicMinorScale(new Pitch(Pitch.ChromaticScalePosition.AsBf));
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            HarmonicMinorScale B = new HarmonicMinorScale(new Pitch(Pitch.ChromaticScalePosition.B));
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            HarmonicMinorScale C = new HarmonicMinorScale(new Pitch(Pitch.ChromaticScalePosition.C));
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            HarmonicMinorScale CsDf = new HarmonicMinorScale(new Pitch(Pitch.ChromaticScalePosition.CsDf));
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            HarmonicMinorScale D = new HarmonicMinorScale(new Pitch(Pitch.ChromaticScalePosition.D));
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            HarmonicMinorScale DsEf = new HarmonicMinorScale(new Pitch(Pitch.ChromaticScalePosition.DsEf));
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            HarmonicMinorScale E = new HarmonicMinorScale(new Pitch(Pitch.ChromaticScalePosition.E));
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            HarmonicMinorScale F = new HarmonicMinorScale(new Pitch(Pitch.ChromaticScalePosition.F));
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            HarmonicMinorScale FsGf = new HarmonicMinorScale(new Pitch(Pitch.ChromaticScalePosition.FsGf));
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            HarmonicMinorScale G = new HarmonicMinorScale(new Pitch(Pitch.ChromaticScalePosition.G));
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            HarmonicMinorScale GsAf = new HarmonicMinorScale(new Pitch(Pitch.ChromaticScalePosition.GsAf));
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class ConstructorWithInt_Test
    {
        [Fact]
        public void NONE_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            HarmonicMinorScale NONE = new HarmonicMinorScale(0);
            Assert.Equal(expected, NONE.Pitch.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            HarmonicMinorScale A = new HarmonicMinorScale(1);
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            HarmonicMinorScale AsBf = new HarmonicMinorScale(2);
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            HarmonicMinorScale B = new HarmonicMinorScale(3);
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            HarmonicMinorScale C = new HarmonicMinorScale(4);
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            HarmonicMinorScale CsDf = new HarmonicMinorScale(5);
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            HarmonicMinorScale D = new HarmonicMinorScale(6);
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            HarmonicMinorScale DsEf = new HarmonicMinorScale(7);
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            HarmonicMinorScale E = new HarmonicMinorScale(8);
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            HarmonicMinorScale F = new HarmonicMinorScale(9);
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            HarmonicMinorScale FsGf = new HarmonicMinorScale(10);
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            HarmonicMinorScale G = new HarmonicMinorScale(11);
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            HarmonicMinorScale GsAf = new HarmonicMinorScale(12);
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class ConstructorWithString_Test
    {
        [Fact]
        public void NONE_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            HarmonicMinorScale NONE = new HarmonicMinorScale("NONE");
            Assert.Equal(expected, NONE.Pitch.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            HarmonicMinorScale A = new HarmonicMinorScale("A");
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            HarmonicMinorScale AsBf = new HarmonicMinorScale("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            HarmonicMinorScale B = new HarmonicMinorScale("B");
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            HarmonicMinorScale C = new HarmonicMinorScale("C");
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            HarmonicMinorScale CsDf = new HarmonicMinorScale("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            HarmonicMinorScale D = new HarmonicMinorScale("D");
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            HarmonicMinorScale DsEf = new HarmonicMinorScale("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            HarmonicMinorScale E = new HarmonicMinorScale("E");
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            HarmonicMinorScale F = new HarmonicMinorScale("F");
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            HarmonicMinorScale FsGf = new HarmonicMinorScale("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            HarmonicMinorScale G = new HarmonicMinorScale("G");
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            HarmonicMinorScale GsAf = new HarmonicMinorScale("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class GetPositionAsString_Test
    {
        [Fact]
        public void NONE_getPositionAsString_Test()
        {
            string expected = "NONE";
            HarmonicMinorScale NONE = new HarmonicMinorScale("NONE");
            Assert.Equal(expected, NONE.Pitch.GetPositionAsString());
        }
        [Fact]
        public void A_getPositionAsString_Test()
        {
            string expected = "A";
            HarmonicMinorScale A = new HarmonicMinorScale("A");
            Assert.Equal(expected, A.Pitch.GetPositionAsString());
        }
        [Fact]
        public void AsBf_getPositionAsString_Test()
        {
            string expected = "AsBf";
            HarmonicMinorScale AsBf = new HarmonicMinorScale("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void B_getPositionAsString_Test()
        {
            string expected = "B";
            HarmonicMinorScale B = new HarmonicMinorScale("B");
            Assert.Equal(expected, B.Pitch.GetPositionAsString());
        }
        [Fact]
        public void C_getPositionAsString_Test()
        {
            string expected = "C";
            HarmonicMinorScale C = new HarmonicMinorScale("C");
            Assert.Equal(expected, C.Pitch.GetPositionAsString());
        }
        [Fact]
        public void CsDf_getPositionAsString_Test()
        {
            string expected = "CsDf";
            HarmonicMinorScale CsDf = new HarmonicMinorScale("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void D_getPositionAsString_Test()
        {
            string expected = "D";
            HarmonicMinorScale D = new HarmonicMinorScale("D");
            Assert.Equal(expected, D.Pitch.GetPositionAsString());
        }
        [Fact]
        public void DsEf_getPositionAsString_Test()
        {
            string expected = "DsEf";
            HarmonicMinorScale DsEf = new HarmonicMinorScale("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void E_getPositionAsString_Test()
        {
            string expected = "E";
            HarmonicMinorScale E = new HarmonicMinorScale("E");
            Assert.Equal(expected, E.Pitch.GetPositionAsString());
        }
        [Fact]
        public void F_getPositionAsString_Test()
        {
            string expected = "F";
            HarmonicMinorScale F = new HarmonicMinorScale("F");
            Assert.Equal(expected, F.Pitch.GetPositionAsString());
        }
        [Fact]
        public void FsGf_getPositionAsString_Test()
        {
            string expected = "FsGf";
            HarmonicMinorScale FsGf = new HarmonicMinorScale("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void G_getPositionAsString_Test()
        {
            string expected = "G";
            HarmonicMinorScale G = new HarmonicMinorScale("G");
            Assert.Equal(expected, G.Pitch.GetPositionAsString());
        }
        [Fact]
        public void GsAf_getPositionAsString_Test()
        {
            string expected = "GsAf";
            HarmonicMinorScale GsAf = new HarmonicMinorScale("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetPositionAsString());
        }
    }
    public class GetName_Test
    {
        [Fact]
        public void NONE_getPositionAsString_Test()
        {
            string expected = "NONE";
            HarmonicMinorScale NONE = new HarmonicMinorScale("NONE");
            Assert.Equal(expected, NONE.Name);
        }
        [Fact]
        public void A_getPositionAsString_Test()
        {
            string expected = "A";
            HarmonicMinorScale A = new HarmonicMinorScale("A");
            Assert.Equal(expected, A.Name);
        }
        [Fact]
        public void AsBf_getPositionAsString_Test()
        {
            string expected = "A♯/B♭";
            HarmonicMinorScale AsBf = new HarmonicMinorScale("AsBf");
            Assert.Equal(expected, AsBf.Name);
        }
        [Fact]
        public void As_getPositionAsString_Test()
        {
            string expected = "A♯";
            HarmonicMinorScale AsBf = new HarmonicMinorScale("As");
            Assert.Equal(expected, AsBf.Name);
        }
        [Fact]
        public void Bf_getPositionAsString_Test()
        {
            string expected = "B♭";
            HarmonicMinorScale AsBf = new HarmonicMinorScale("Bf");
            Assert.Equal(expected, AsBf.Name);
        }
        [Fact]
        public void B_getPositionAsString_Test()
        {
            string expected = "B";
            HarmonicMinorScale B = new HarmonicMinorScale("B");
            Assert.Equal(expected, B.Name);
        }
        [Fact]
        public void C_getPositionAsString_Test()
        {
            string expected = "C";
            HarmonicMinorScale C = new HarmonicMinorScale("C");
            Assert.Equal(expected, C.Name);
        }
        [Fact]
        public void CsDf_getPositionAsString_Test()
        {
            string expected = "C♯/D♭";
            HarmonicMinorScale CsDf = new HarmonicMinorScale("CsDf");
            Assert.Equal(expected, CsDf.Name);
        }
        [Fact]
        public void Cs_getPositionAsString_Test()
        {
            string expected = "C♯";
            HarmonicMinorScale CsDf = new HarmonicMinorScale("Cs");
            Assert.Equal(expected, CsDf.Name);
        }
        [Fact]
        public void Df_getPositionAsString_Test()
        {
            string expected = "D♭";
            HarmonicMinorScale CsDf = new HarmonicMinorScale("Df");
            Assert.Equal(expected, CsDf.Name);
        }
        [Fact]
        public void D_getPositionAsString_Test()
        {
            string expected = "D";
            HarmonicMinorScale D = new HarmonicMinorScale("D");
            Assert.Equal(expected, D.Name);
        }
        [Fact]
        public void DsEf_getPositionAsString_Test()
        {
            string expected = "D♯/E♭";
            HarmonicMinorScale DsEf = new HarmonicMinorScale("DsEf");
            Assert.Equal(expected, DsEf.Name);
        }
        [Fact]
        public void Ds_getPositionAsString_Test()
        {
            string expected = "D♯";
            HarmonicMinorScale DsEf = new HarmonicMinorScale("Ds");
            Assert.Equal(expected, DsEf.Name);
        }
        [Fact]
        public void Ef_getPositionAsString_Test()
        {
            string expected = "E♭";
            HarmonicMinorScale DsEf = new HarmonicMinorScale("Ef");
            Assert.Equal(expected, DsEf.Name);
        }
        [Fact]
        public void E_getPositionAsString_Test()
        {
            string expected = "E";
            HarmonicMinorScale E = new HarmonicMinorScale("E");
            Assert.Equal(expected, E.Name);
        }
        [Fact]
        public void F_getPositionAsString_Test()
        {
            string expected = "F";
            HarmonicMinorScale F = new HarmonicMinorScale("F");
            Assert.Equal(expected, F.Name);
        }
        [Fact]
        public void FsGf_getPositionAsString_Test()
        {
            string expected = "F♯/G♭";
            HarmonicMinorScale FsGf = new HarmonicMinorScale("FsGf");
            Assert.Equal(expected, FsGf.Name);
        }
        [Fact]
        public void Fs_GetPositionAsString_Test()
        {
            string expected = "F♯";
            HarmonicMinorScale FsGf = new HarmonicMinorScale("Fs");
            Assert.Equal(expected, FsGf.Name);
        }
        [Fact]
        public void Gf_getPositionAsString_Test()
        {
            string expected = "G♭";
            HarmonicMinorScale FsGf = new HarmonicMinorScale("Gf");
            Assert.Equal(expected, FsGf.Name);
        }
        [Fact]
        public void G_getPositionAsString_Test()
        {
            string expected = "G";
            HarmonicMinorScale G = new HarmonicMinorScale("G");
            Assert.Equal(expected, G.Name);
        }
        [Fact]
        public void GsAf_getPositionAsString_Test()
        {
            string expected = "G♯/A♭";
            HarmonicMinorScale GsAf = new HarmonicMinorScale("GsAf");
            Assert.Equal(expected, GsAf.Name);
        }
    }
    public class AccendHalfStep_Test
    {
        [Fact]
        public void A_AccendHalfStep_Test()
        {
            string expected = new HarmonicMinorScale("AsBf").Name;
            HarmonicMinorScale A_Scale = new HarmonicMinorScale("A");

            A_Scale.AccendHalfStep();
            Assert.Equal(expected, A_Scale.Name);
        }
        [Fact]
        public void AsBf_AccendHalfStep_Test()
        {
            string expected = new HarmonicMinorScale("B").Name;
            HarmonicMinorScale AsBf_Scale = new HarmonicMinorScale("AsBf");

            AsBf_Scale.AccendHalfStep();
            Assert.Equal(expected, AsBf_Scale.Name);
        }
        [Fact]
        public void B_AccendHalfStep_Test()
        {
            string expected = new HarmonicMinorScale("C").Name;
            HarmonicMinorScale B_Scale = new HarmonicMinorScale("B");

            B_Scale.AccendHalfStep();
            Assert.Equal(expected, B_Scale.Name);
        }
        [Fact]
        public void C_AccendHalfStep_Test()
        {
            string expected = new HarmonicMinorScale("CsDf").Name;
            HarmonicMinorScale C_Scale = new HarmonicMinorScale("C");

            C_Scale.AccendHalfStep();
            Assert.Equal(expected, C_Scale.Name);
        }
        [Fact]
        public void CsDf_AccendHalfStep_Test()
        {
            string expected = new HarmonicMinorScale("D").Name;
            HarmonicMinorScale CsDf_Scale = new HarmonicMinorScale("CsDf");

            CsDf_Scale.AccendHalfStep();
            Assert.Equal(expected, CsDf_Scale.Name);
        }
        [Fact]
        public void D_AccendHalfStep_Test()
        {
            string expected = new HarmonicMinorScale("DsEf").Name;
            HarmonicMinorScale D_Scale = new HarmonicMinorScale("D");

            D_Scale.AccendHalfStep();
            Assert.Equal(expected, D_Scale.Name);
        }
        [Fact]
        public void DsEf_AccendHalfStep_Test()
        {
            string expected = new HarmonicMinorScale("E").Name;
            HarmonicMinorScale DsEf_Scale = new HarmonicMinorScale("DsEf");

            DsEf_Scale.AccendHalfStep();
            Assert.Equal(expected, DsEf_Scale.Name);
        }
        [Fact]
        public void E_AccendHalfStep_Test()
        {
            string expected = new HarmonicMinorScale("F").Name;
            HarmonicMinorScale E_Scale = new HarmonicMinorScale("E");

            E_Scale.AccendHalfStep();
            Assert.Equal(expected, E_Scale.Name);
        }
        [Fact]
        public void F_AccendHalfStep_Test()
        {
            string expected = new HarmonicMinorScale("FsGf").Name;
            HarmonicMinorScale F_Scale = new HarmonicMinorScale("F");

            F_Scale.AccendHalfStep();
            Assert.Equal(expected, F_Scale.Name);
        }
        [Fact]
        public void fSGf_AccendHalfStep_Test()
        {
            string expected = new HarmonicMinorScale("G").Name;
            HarmonicMinorScale fSGf_Scale = new HarmonicMinorScale("FsGf");

            fSGf_Scale.AccendHalfStep();
            Assert.Equal(expected, fSGf_Scale.Name);
        }
        [Fact]
        public void G_AccendHalfStep_Test()
        {
            string expected = new HarmonicMinorScale("GsAf").Name;
            HarmonicMinorScale G_Scale = new HarmonicMinorScale("G");

            G_Scale.AccendHalfStep();
            Assert.Equal(expected, G_Scale.Name);
        }
        [Fact]
        public void GsAf_AccendHalfStep_Test()
        {
            string expected = new HarmonicMinorScale("A").Name;
            HarmonicMinorScale GsAf_Scale = new HarmonicMinorScale("GsAf");

            GsAf_Scale.AccendHalfStep();
            Assert.Equal(expected, GsAf_Scale.Name);
        }
    }
    public class AccendWholeStep_Test
    {
        [Fact]
        public void A_AccendWholeStep_Test()
        {
            string expected = new HarmonicMinorScale("B").Name;
            HarmonicMinorScale A_Scale = new HarmonicMinorScale("A");

            A_Scale.AccendWholeStep();
            Assert.Equal(expected, A_Scale.Name);
        }
        [Fact]
        public void AsBf_AccendWholeStep_Test()
        {
            string expected = new HarmonicMinorScale("C").Name;
            HarmonicMinorScale AsBf_Scale = new HarmonicMinorScale("AsBf");

            AsBf_Scale.AccendWholeStep();
            Assert.Equal(expected, AsBf_Scale.Name);
        }
        [Fact]
        public void B_AccendWholeStep_Test()
        {
            string expected = new HarmonicMinorScale("CsDf").Name;
            HarmonicMinorScale B_Scale = new HarmonicMinorScale("B");

            B_Scale.AccendWholeStep();
            Assert.Equal(expected, B_Scale.Name);
        }
        [Fact]
        public void C_AccendWholeStep_Test()
        {
            string expected = new HarmonicMinorScale("D").Name;
            HarmonicMinorScale C_Scale = new HarmonicMinorScale("C");

            C_Scale.AccendWholeStep();
            Assert.Equal(expected, C_Scale.Name);
        }
        [Fact]
        public void CsDf_AccendWholeStep_Test()
        {
            string expected = new HarmonicMinorScale("DsEf").Name;
            HarmonicMinorScale CsDf_Scale = new HarmonicMinorScale("CsDf");

            CsDf_Scale.AccendWholeStep();
            Assert.Equal(expected, CsDf_Scale.Name);
        }
        [Fact]
        public void D_AccendWholeStep_Test()
        {
            string expected = new HarmonicMinorScale("E").Name;
            HarmonicMinorScale D_Scale = new HarmonicMinorScale("D");

            D_Scale.AccendWholeStep();
            Assert.Equal(expected, D_Scale.Name);
        }
        [Fact]
        public void DsEf_AccendWholeStep_Test()
        {
            string expected = new HarmonicMinorScale("F").Name;
            HarmonicMinorScale DsEf_Scale = new HarmonicMinorScale("DsEf");

            DsEf_Scale.AccendWholeStep();
            Assert.Equal(expected, DsEf_Scale.Name);
        }
        [Fact]
        public void E_AccendWholeStep_Test()
        {
            string expected = new HarmonicMinorScale("FsGf").Name;
            HarmonicMinorScale E_Scale = new HarmonicMinorScale("E");

            E_Scale.AccendWholeStep();
            Assert.Equal(expected, E_Scale.Name);
        }
        [Fact]
        public void F_AccendWholeStep_Test()
        {
            string expected = new HarmonicMinorScale("G").Name;
            HarmonicMinorScale F_Scale = new HarmonicMinorScale("F");

            F_Scale.AccendWholeStep();
            Assert.Equal(expected, F_Scale.Name);
        }
        [Fact]
        public void FsGf_AccendWholeStep_Test()
        {
            string expected = new HarmonicMinorScale("GsAf").Name;
            HarmonicMinorScale FsGf_Scale = new HarmonicMinorScale("FsGf");

            FsGf_Scale.AccendWholeStep();
            Assert.Equal(expected, FsGf_Scale.Name);
        }
        [Fact]
        public void G_AccendWholeStep_Test()
        {
            string expected = new HarmonicMinorScale("A").Name;
            HarmonicMinorScale G_Scale = new HarmonicMinorScale("G");

            G_Scale.AccendWholeStep();
            Assert.Equal(expected, G_Scale.Name);
        }
        [Fact]
        public void GsAf_AccendWholeStep_Test()
        {
            string expected = new HarmonicMinorScale("AsBf").Name;
            HarmonicMinorScale GsAf_Scale = new HarmonicMinorScale("GsAf");

            GsAf_Scale.AccendWholeStep();
            Assert.Equal(expected, GsAf_Scale.Name);
        }
    }
    public class AccendStepAndAHalf_Test
        {
        [Fact]
        public void A_AccendStepAndAHalf_Test()
        {
            string expected = new HarmonicMinorScale("C").Name;
            HarmonicMinorScale A_Scale = new HarmonicMinorScale("A");

            A_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, A_Scale.Name);
        }
        [Fact]
        public void AsBf_AccendStepAndAHalf_Test()
        {
            string expected = new HarmonicMinorScale("CsDf").Name;
            HarmonicMinorScale AsBf_Scale = new HarmonicMinorScale("AsBf");

            AsBf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, AsBf_Scale.Name);
        }
        [Fact]
        public void B_AccendStepAndAHalf_Test()
        {
            string expected = new HarmonicMinorScale("D").Name;
            HarmonicMinorScale B_Scale = new HarmonicMinorScale("B");

            B_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, B_Scale.Name);
        }
        [Fact]
        public void C_AccendStepAndAHalf_Test()
        {
            string expected = new HarmonicMinorScale("DsEf").Name;
            HarmonicMinorScale C_Scale = new HarmonicMinorScale("C");

            C_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, C_Scale.Name);
        }
        [Fact]
        public void CsDf_AccendStepAndAHalf_Test()
        {
            string expected = new HarmonicMinorScale("E").Name;
            HarmonicMinorScale CsDf_Scale = new HarmonicMinorScale("CsDf");

            CsDf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, CsDf_Scale.Name);
        }
        [Fact]
        public void D_AccendStepAndAHalf_Test()
        {
            string expected = new HarmonicMinorScale("F").Name;
            HarmonicMinorScale D_Scale = new HarmonicMinorScale("D");

            D_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, D_Scale.Name);
        }
        [Fact]
        public void DsEf_AccendStepAndAHalf_Test()
        {
            string expected = new HarmonicMinorScale("FsGf").Name;
            HarmonicMinorScale DsEf_Scale = new HarmonicMinorScale("DsEf");

            DsEf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, DsEf_Scale.Name);
        }
        [Fact]
        public void E_AccendStepAndAHalf_Test()
        {
            string expected = new HarmonicMinorScale("G").Name;
            HarmonicMinorScale E_Scale = new HarmonicMinorScale("E");

            E_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, E_Scale.Name);
        }
        [Fact]
        public void F_AccendStepAndAHalf_Test()
        {
            string expected = new HarmonicMinorScale("GsAf").Name;
            HarmonicMinorScale F_Scale = new HarmonicMinorScale("F");

            F_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, F_Scale.Name);
        }
        [Fact]
        public void FsGf_AccendStepAndAHalf_Test()
        {
            string expected = new HarmonicMinorScale("A").Name;
            HarmonicMinorScale FsGf_Scale = new HarmonicMinorScale("FsGf");

            FsGf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, FsGf_Scale.Name);
        }
        [Fact]
        public void G_AccendStepAndAHalf_Test()
        {
            string expected = new HarmonicMinorScale("AsBf").Name;
            HarmonicMinorScale G_Scale = new HarmonicMinorScale("G");

            G_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, G_Scale.Name);
        }
        [Fact]
        public void GsAf_AccendStepAndAHalf_Test()
        {
            string expected = new HarmonicMinorScale("B").Name;
            HarmonicMinorScale GsAf_Scale = new HarmonicMinorScale("GsAf");

            GsAf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, GsAf_Scale.Name);
        }
    }
    public class getUnresolvedScale_Test
    {
        [Fact]
        public void AMajor_getUnresolvedScale_Test()
        {
            string expected = "A B C D E F G♯/A♭";
            HarmonicMinorScale scaleToTest = new HarmonicMinorScale("A");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());

        }
        [Fact]
        public void AsBfMajor_getUnresolvedScale_Test()

        {
            string expected = "A♯/B♭ C C♯/D♭ D♯/E♭ F F♯/G♭ A";
            HarmonicMinorScale scaleToTest = new HarmonicMinorScale("AsBf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void BMajor_getUnresolvedScale_Test()

        {
            string expected = "B C♯/D♭ D E F♯/G♭ G A♯/B♭";
            HarmonicMinorScale scaleToTest = new HarmonicMinorScale("B");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());

        }
        [Fact]
        public void CMajor_getUnresolvedScale_Test()

        {
            string expected = "C D D♯/E♭ F G G♯/A♭ B";
            HarmonicMinorScale scaleToTest = new HarmonicMinorScale("C");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void CsDfMajor_getUnresolvedScale_Test()

        {
            string expected = "C♯/D♭ D♯/E♭ E F♯/G♭ G♯/A♭ A C";
            HarmonicMinorScale scaleToTest = new HarmonicMinorScale("CsDf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void DMajor_getUnresolvedScale_Test()

        {
            string expected = "D E F G A A♯/B♭ C♯/D♭";
            HarmonicMinorScale scaleToTest = new HarmonicMinorScale("D");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void DsEfMajor_getUnresolvedScale_Test()

        {
            string expected = "D♯/E♭ F F♯/G♭ G♯/A♭ A♯/B♭ B D";
            HarmonicMinorScale scaleToTest = new HarmonicMinorScale("DsEf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void EMajor_getUnresolvedScale_Test()

        {
            string expected = "E F♯/G♭ G A B C D♯/E♭";
            HarmonicMinorScale scaleToTest = new HarmonicMinorScale("E");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void FMajor_getUnresolvedScale_Test()

        {
            string expected = "F G G♯/A♭ A♯/B♭ C C♯/D♭ E";
            HarmonicMinorScale scaleToTest = new HarmonicMinorScale("F");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void FsGfMajor_getUnresolvedScale_Test()

        {
            string expected = "F♯/G♭ G♯/A♭ A B C♯/D♭ D F";
            HarmonicMinorScale scaleToTest = new HarmonicMinorScale("FsGf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void GMajor_getUnresolvedScale_Test()

        {
            string expected = "G A A♯/B♭ C D D♯/E♭ F♯/G♭";
            HarmonicMinorScale scaleToTest = new HarmonicMinorScale("G");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void GsAfMajor_getUnresolvedScale_Test()

        {
            string expected = "G♯/A♭ A♯/B♭ B C♯/D♭ D♯/E♭ E G";
            HarmonicMinorScale scaleToTest = new HarmonicMinorScale("GsAf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
    };
}
