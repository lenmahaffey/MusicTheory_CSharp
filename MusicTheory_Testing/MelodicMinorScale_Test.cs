/*
    CSC236 8N0 Intro to C#
    Project: Final Project
    File: MelodicMinorScale_Test.cs
    By: Len Mahaffey
    Last Edited: 12/11/20
    Description: MelodicMinor class testing
*/
using CSC236_LMahaffey_FinalProject;
using Xunit;

namespace MelodicMinorScale_Test
{
    public class ConstructorWithPosition_Test
    {
        [Fact]
        public void A_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            MelodicMinorScale A = new MelodicMinorScale(new Pitch(Pitch.ChromaticScalePosition.A));
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            MelodicMinorScale AsBf = new MelodicMinorScale(new Pitch(Pitch.ChromaticScalePosition.AsBf));
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            MelodicMinorScale B = new MelodicMinorScale(new Pitch(Pitch.ChromaticScalePosition.B));
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            MelodicMinorScale C = new MelodicMinorScale(new Pitch(Pitch.ChromaticScalePosition.C));
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            MelodicMinorScale CsDf = new MelodicMinorScale(new Pitch(Pitch.ChromaticScalePosition.CsDf));
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            MelodicMinorScale D = new MelodicMinorScale(new Pitch(Pitch.ChromaticScalePosition.D));
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            MelodicMinorScale DsEf = new MelodicMinorScale(new Pitch(Pitch.ChromaticScalePosition.DsEf));
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            MelodicMinorScale E = new MelodicMinorScale(new Pitch(Pitch.ChromaticScalePosition.E));
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            MelodicMinorScale F = new MelodicMinorScale(new Pitch(Pitch.ChromaticScalePosition.F));
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            MelodicMinorScale FsGf = new MelodicMinorScale(new Pitch(Pitch.ChromaticScalePosition.FsGf));
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            MelodicMinorScale G = new MelodicMinorScale(new Pitch(Pitch.ChromaticScalePosition.G));
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            MelodicMinorScale GsAf = new MelodicMinorScale(new Pitch(Pitch.ChromaticScalePosition.GsAf));
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class ConstructorWithInt_Test
    {
        [Fact]
        public void NONE_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            MelodicMinorScale NONE = new MelodicMinorScale(0);
            Assert.Equal(expected, NONE.Pitch.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            MelodicMinorScale A = new MelodicMinorScale(1);
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            MelodicMinorScale AsBf = new MelodicMinorScale(2);
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            MelodicMinorScale B = new MelodicMinorScale(3);
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            MelodicMinorScale C = new MelodicMinorScale(4);
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            MelodicMinorScale CsDf = new MelodicMinorScale(5);
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            MelodicMinorScale D = new MelodicMinorScale(6);
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            MelodicMinorScale DsEf = new MelodicMinorScale(7);
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            MelodicMinorScale E = new MelodicMinorScale(8);
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            MelodicMinorScale F = new MelodicMinorScale(9);
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            MelodicMinorScale FsGf = new MelodicMinorScale(10);
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            MelodicMinorScale G = new MelodicMinorScale(11);
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            MelodicMinorScale GsAf = new MelodicMinorScale(12);
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class ConstructorWithString_Test
    {
        [Fact]
        public void NONE_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            MelodicMinorScale NONE = new MelodicMinorScale("NONE");
            Assert.Equal(expected, NONE.Pitch.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            MelodicMinorScale A = new MelodicMinorScale("A");
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            MelodicMinorScale AsBf = new MelodicMinorScale("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            MelodicMinorScale B = new MelodicMinorScale("B");
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            MelodicMinorScale C = new MelodicMinorScale("C");
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            MelodicMinorScale CsDf = new MelodicMinorScale("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            MelodicMinorScale D = new MelodicMinorScale("D");
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            MelodicMinorScale DsEf = new MelodicMinorScale("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            MelodicMinorScale E = new MelodicMinorScale("E");
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            MelodicMinorScale F = new MelodicMinorScale("F");
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            MelodicMinorScale FsGf = new MelodicMinorScale("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            MelodicMinorScale G = new MelodicMinorScale("G");
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            MelodicMinorScale GsAf = new MelodicMinorScale("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class GetPositionAsString_Test
    {
        [Fact]
        public void NONE_getPositionAsString_Test()
        {
            string expected = "NONE";
            MelodicMinorScale NONE = new MelodicMinorScale("NONE");
            Assert.Equal(expected, NONE.Pitch.GetPositionAsString());
        }
        [Fact]
        public void A_getPositionAsString_Test()
        {
            string expected = "A";
            MelodicMinorScale A = new MelodicMinorScale("A");
            Assert.Equal(expected, A.Pitch.GetPositionAsString());
        }
        [Fact]
        public void AsBf_getPositionAsString_Test()
        {
            string expected = "AsBf";
            MelodicMinorScale AsBf = new MelodicMinorScale("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void B_getPositionAsString_Test()
        {
            string expected = "B";
            MelodicMinorScale B = new MelodicMinorScale("B");
            Assert.Equal(expected, B.Pitch.GetPositionAsString());
        }
        [Fact]
        public void C_getPositionAsString_Test()
        {
            string expected = "C";
            MelodicMinorScale C = new MelodicMinorScale("C");
            Assert.Equal(expected, C.Pitch.GetPositionAsString());
        }
        [Fact]
        public void CsDf_getPositionAsString_Test()
        {
            string expected = "CsDf";
            MelodicMinorScale CsDf = new MelodicMinorScale("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void D_getPositionAsString_Test()
        {
            string expected = "D";
            MelodicMinorScale D = new MelodicMinorScale("D");
            Assert.Equal(expected, D.Pitch.GetPositionAsString());
        }
        [Fact]
        public void DsEf_getPositionAsString_Test()
        {
            string expected = "DsEf";
            MelodicMinorScale DsEf = new MelodicMinorScale("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void E_getPositionAsString_Test()
        {
            string expected = "E";
            MelodicMinorScale E = new MelodicMinorScale("E");
            Assert.Equal(expected, E.Pitch.GetPositionAsString());
        }
        [Fact]
        public void F_getPositionAsString_Test()
        {
            string expected = "F";
            MelodicMinorScale F = new MelodicMinorScale("F");
            Assert.Equal(expected, F.Pitch.GetPositionAsString());
        }
        [Fact]
        public void FsGf_getPositionAsString_Test()
        {
            string expected = "FsGf";
            MelodicMinorScale FsGf = new MelodicMinorScale("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void G_getPositionAsString_Test()
        {
            string expected = "G";
            MelodicMinorScale G = new MelodicMinorScale("G");
            Assert.Equal(expected, G.Pitch.GetPositionAsString());
        }
        [Fact]
        public void GsAf_getPositionAsString_Test()
        {
            string expected = "GsAf";
            MelodicMinorScale GsAf = new MelodicMinorScale("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetPositionAsString());
        }
    }
    public class GetName_Test
    {
        [Fact]
        public void NONE_getPositionAsString_Test()
        {
            string expected = "NONE";
            MelodicMinorScale NONE = new MelodicMinorScale("NONE");
            Assert.Equal(expected, NONE.Name);
        }
        [Fact]
        public void A_getPositionAsString_Test()
        {
            string expected = "A";
            MelodicMinorScale A = new MelodicMinorScale("A");
            Assert.Equal(expected, A.Name);
        }
        [Fact]
        public void AsBf_getPositionAsString_Test()
        {
            string expected = "A♯/B♭";
            MelodicMinorScale AsBf = new MelodicMinorScale("AsBf");
            Assert.Equal(expected, AsBf.Name);
        }
        [Fact]
        public void As_getPositionAsString_Test()
        {
            string expected = "A♯";
            MelodicMinorScale AsBf = new MelodicMinorScale("As");
            Assert.Equal(expected, AsBf.Name);
        }
        [Fact]
        public void Bf_getPositionAsString_Test()
        {
            string expected = "B♭";
            MelodicMinorScale AsBf = new MelodicMinorScale("Bf");
            Assert.Equal(expected, AsBf.Name);
        }
        [Fact]
        public void B_getPositionAsString_Test()
        {
            string expected = "B";
            MelodicMinorScale B = new MelodicMinorScale("B");
            Assert.Equal(expected, B.Name);
        }
        [Fact]
        public void C_getPositionAsString_Test()
        {
            string expected = "C";
            MelodicMinorScale C = new MelodicMinorScale("C");
            Assert.Equal(expected, C.Name);
        }
        [Fact]
        public void CsDf_getPositionAsString_Test()
        {
            string expected = "C♯/D♭";
            MelodicMinorScale CsDf = new MelodicMinorScale("CsDf");
            Assert.Equal(expected, CsDf.Name);
        }
        [Fact]
        public void Cs_getPositionAsString_Test()
        {
            string expected = "C♯";
            MelodicMinorScale CsDf = new MelodicMinorScale("Cs");
            Assert.Equal(expected, CsDf.Name);
        }
        [Fact]
        public void Df_getPositionAsString_Test()
        {
            string expected = "D♭";
            MelodicMinorScale CsDf = new MelodicMinorScale("Df");
            Assert.Equal(expected, CsDf.Name);
        }
        [Fact]
        public void D_getPositionAsString_Test()
        {
            string expected = "D";
            MelodicMinorScale D = new MelodicMinorScale("D");
            Assert.Equal(expected, D.Name);
        }
        [Fact]
        public void DsEf_getPositionAsString_Test()
        {
            string expected = "D♯/E♭";
            MelodicMinorScale DsEf = new MelodicMinorScale("DsEf");
            Assert.Equal(expected, DsEf.Name);
        }
        [Fact]
        public void Ds_getPositionAsString_Test()
        {
            string expected = "D♯";
            MelodicMinorScale DsEf = new MelodicMinorScale("Ds");
            Assert.Equal(expected, DsEf.Name);
        }
        [Fact]
        public void Ef_getPositionAsString_Test()
        {
            string expected = "E♭";
            MelodicMinorScale DsEf = new MelodicMinorScale("Ef");
            Assert.Equal(expected, DsEf.Name);
        }
        [Fact]
        public void E_getPositionAsString_Test()
        {
            string expected = "E";
            MelodicMinorScale E = new MelodicMinorScale("E");
            Assert.Equal(expected, E.Name);
        }
        [Fact]
        public void F_getPositionAsString_Test()
        {
            string expected = "F";
            MelodicMinorScale F = new MelodicMinorScale("F");
            Assert.Equal(expected, F.Name);
        }
        [Fact]
        public void FsGf_getPositionAsString_Test()
        {
            string expected = "F♯/G♭";
            MelodicMinorScale FsGf = new MelodicMinorScale("FsGf");
            Assert.Equal(expected, FsGf.Name);
        }
        [Fact]
        public void Fs_GetPositionAsString_Test()
        {
            string expected = "F♯";
            MelodicMinorScale FsGf = new MelodicMinorScale("Fs");
            Assert.Equal(expected, FsGf.Name);
        }
        [Fact]
        public void Gf_getPositionAsString_Test()
        {
            string expected = "G♭";
            MelodicMinorScale FsGf = new MelodicMinorScale("Gf");
            Assert.Equal(expected, FsGf.Name);
        }
        [Fact]
        public void G_getPositionAsString_Test()
        {
            string expected = "G";
            MelodicMinorScale G = new MelodicMinorScale("G");
            Assert.Equal(expected, G.Name);
        }
        [Fact]
        public void GsAf_getPositionAsString_Test()
        {
            string expected = "G♯/A♭";
            MelodicMinorScale GsAf = new MelodicMinorScale("GsAf");
            Assert.Equal(expected, GsAf.Name);
        }
    }
    public class AccendHalfStep_Test
    {
        [Fact]
        public void A_AccendHalfStep_Test()
        {
            string expected = new MelodicMinorScale("AsBf").Name;
            MelodicMinorScale A_Scale = new MelodicMinorScale("A");

            A_Scale.AccendHalfStep();
            Assert.Equal(expected, A_Scale.Name);
        }
        [Fact]
        public void AsBf_AccendHalfStep_Test()
        {
            string expected = new MelodicMinorScale("B").Name;
            MelodicMinorScale AsBf_Scale = new MelodicMinorScale("AsBf");

            AsBf_Scale.AccendHalfStep();
            Assert.Equal(expected, AsBf_Scale.Name);
        }
        [Fact]
        public void B_AccendHalfStep_Test()
        {
            string expected = new MelodicMinorScale("C").Name;
            MelodicMinorScale B_Scale = new MelodicMinorScale("B");

            B_Scale.AccendHalfStep();
            Assert.Equal(expected, B_Scale.Name);
        }
        [Fact]
        public void C_AccendHalfStep_Test()
        {
            string expected = new MelodicMinorScale("CsDf").Name;
            MelodicMinorScale C_Scale = new MelodicMinorScale("C");

            C_Scale.AccendHalfStep();
            Assert.Equal(expected, C_Scale.Name);
        }
        [Fact]
        public void CsDf_AccendHalfStep_Test()
        {
            string expected = new MelodicMinorScale("D").Name;
            MelodicMinorScale CsDf_Scale = new MelodicMinorScale("CsDf");

            CsDf_Scale.AccendHalfStep();
            Assert.Equal(expected, CsDf_Scale.Name);
        }
        [Fact]
        public void D_AccendHalfStep_Test()
        {
            string expected = new MelodicMinorScale("DsEf").Name;
            MelodicMinorScale D_Scale = new MelodicMinorScale("D");

            D_Scale.AccendHalfStep();
            Assert.Equal(expected, D_Scale.Name);
        }
        [Fact]
        public void DsEf_AccendHalfStep_Test()
        {
            string expected = new MelodicMinorScale("E").Name;
            MelodicMinorScale DsEf_Scale = new MelodicMinorScale("DsEf");

            DsEf_Scale.AccendHalfStep();
            Assert.Equal(expected, DsEf_Scale.Name);
        }
        [Fact]
        public void E_AccendHalfStep_Test()
        {
            string expected = new MelodicMinorScale("F").Name;
            MelodicMinorScale E_Scale = new MelodicMinorScale("E");

            E_Scale.AccendHalfStep();
            Assert.Equal(expected, E_Scale.Name);
        }
        [Fact]
        public void F_AccendHalfStep_Test()
        {
            string expected = new MelodicMinorScale("FsGf").Name;
            MelodicMinorScale F_Scale = new MelodicMinorScale("F");

            F_Scale.AccendHalfStep();
            Assert.Equal(expected, F_Scale.Name);
        }
        [Fact]
        public void fSGf_AccendHalfStep_Test()
        {
            string expected = new MelodicMinorScale("G").Name;
            MelodicMinorScale fSGf_Scale = new MelodicMinorScale("FsGf");

            fSGf_Scale.AccendHalfStep();
            Assert.Equal(expected, fSGf_Scale.Name);
        }
        [Fact]
        public void G_AccendHalfStep_Test()
        {
            string expected = new MelodicMinorScale("GsAf").Name;
            MelodicMinorScale G_Scale = new MelodicMinorScale("G");

            G_Scale.AccendHalfStep();
            Assert.Equal(expected, G_Scale.Name);
        }
        [Fact]
        public void GsAf_AccendHalfStep_Test()
        {
            string expected = new MelodicMinorScale("A").Name;
            MelodicMinorScale GsAf_Scale = new MelodicMinorScale("GsAf");

            GsAf_Scale.AccendHalfStep();
            Assert.Equal(expected, GsAf_Scale.Name);
        }
    }
    public class AccendWholeStep_Test
    {
        [Fact]
        public void A_AccendWholeStep_Test()
        {
            string expected = new MelodicMinorScale("B").Name;
            MelodicMinorScale A_Scale = new MelodicMinorScale("A");

            A_Scale.AccendWholeStep();
            Assert.Equal(expected, A_Scale.Name);
        }
        [Fact]
        public void AsBf_AccendWholeStep_Test()
        {
            string expected = new MelodicMinorScale("C").Name;
            MelodicMinorScale AsBf_Scale = new MelodicMinorScale("AsBf");

            AsBf_Scale.AccendWholeStep();
            Assert.Equal(expected, AsBf_Scale.Name);
        }
        [Fact]
        public void B_AccendWholeStep_Test()
        {
            string expected = new MelodicMinorScale("CsDf").Name;
            MelodicMinorScale B_Scale = new MelodicMinorScale("B");

            B_Scale.AccendWholeStep();
            Assert.Equal(expected, B_Scale.Name);
        }
        [Fact]
        public void C_AccendWholeStep_Test()
        {
            string expected = new MelodicMinorScale("D").Name;
            MelodicMinorScale C_Scale = new MelodicMinorScale("C");

            C_Scale.AccendWholeStep();
            Assert.Equal(expected, C_Scale.Name);
        }
        [Fact]
        public void CsDf_AccendWholeStep_Test()
        {
            string expected = new MelodicMinorScale("DsEf").Name;
            MelodicMinorScale CsDf_Scale = new MelodicMinorScale("CsDf");

            CsDf_Scale.AccendWholeStep();
            Assert.Equal(expected, CsDf_Scale.Name);
        }
        [Fact]
        public void D_AccendWholeStep_Test()
        {
            string expected = new MelodicMinorScale("E").Name;
            MelodicMinorScale D_Scale = new MelodicMinorScale("D");

            D_Scale.AccendWholeStep();
            Assert.Equal(expected, D_Scale.Name);
        }
        [Fact]
        public void DsEf_AccendWholeStep_Test()
        {
            string expected = new MelodicMinorScale("F").Name;
            MelodicMinorScale DsEf_Scale = new MelodicMinorScale("DsEf");

            DsEf_Scale.AccendWholeStep();
            Assert.Equal(expected, DsEf_Scale.Name);
        }
        [Fact]
        public void E_AccendWholeStep_Test()
        {
            string expected = new MelodicMinorScale("FsGf").Name;
            MelodicMinorScale E_Scale = new MelodicMinorScale("E");

            E_Scale.AccendWholeStep();
            Assert.Equal(expected, E_Scale.Name);
        }
        [Fact]
        public void F_AccendWholeStep_Test()
        {
            string expected = new MelodicMinorScale("G").Name;
            MelodicMinorScale F_Scale = new MelodicMinorScale("F");

            F_Scale.AccendWholeStep();
            Assert.Equal(expected, F_Scale.Name);
        }
        [Fact]
        public void FsGf_AccendWholeStep_Test()
        {
            string expected = new MelodicMinorScale("GsAf").Name;
            MelodicMinorScale FsGf_Scale = new MelodicMinorScale("FsGf");

            FsGf_Scale.AccendWholeStep();
            Assert.Equal(expected, FsGf_Scale.Name);
        }
        [Fact]
        public void G_AccendWholeStep_Test()
        {
            string expected = new MelodicMinorScale("A").Name;
            MelodicMinorScale G_Scale = new MelodicMinorScale("G");

            G_Scale.AccendWholeStep();
            Assert.Equal(expected, G_Scale.Name);
        }
        [Fact]
        public void GsAf_AccendWholeStep_Test()
        {
            string expected = new MelodicMinorScale("AsBf").Name;
            MelodicMinorScale GsAf_Scale = new MelodicMinorScale("GsAf");

            GsAf_Scale.AccendWholeStep();
            Assert.Equal(expected, GsAf_Scale.Name);
        }
    }
    public class AccendStepAndAHalf_Test
        {
        [Fact]
        public void A_AccendStepAndAHalf_Test()
        {
            string expected = new MelodicMinorScale("C").Name;
            MelodicMinorScale A_Scale = new MelodicMinorScale("A");

            A_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, A_Scale.Name);
        }
        [Fact]
        public void AsBf_AccendStepAndAHalf_Test()
        {
            string expected = new MelodicMinorScale("CsDf").Name;
            MelodicMinorScale AsBf_Scale = new MelodicMinorScale("AsBf");

            AsBf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, AsBf_Scale.Name);
        }
        [Fact]
        public void B_AccendStepAndAHalf_Test()
        {
            string expected = new MelodicMinorScale("D").Name;
            MelodicMinorScale B_Scale = new MelodicMinorScale("B");

            B_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, B_Scale.Name);
        }
        [Fact]
        public void C_AccendStepAndAHalf_Test()
        {
            string expected = new MelodicMinorScale("DsEf").Name;
            MelodicMinorScale C_Scale = new MelodicMinorScale("C");

            C_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, C_Scale.Name);
        }
        [Fact]
        public void CsDf_AccendStepAndAHalf_Test()
        {
            string expected = new MelodicMinorScale("E").Name;
            MelodicMinorScale CsDf_Scale = new MelodicMinorScale("CsDf");

            CsDf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, CsDf_Scale.Name);
        }
        [Fact]
        public void D_AccendStepAndAHalf_Test()
        {
            string expected = new MelodicMinorScale("F").Name;
            MelodicMinorScale D_Scale = new MelodicMinorScale("D");

            D_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, D_Scale.Name);
        }
        [Fact]
        public void DsEf_AccendStepAndAHalf_Test()
        {
            string expected = new MelodicMinorScale("FsGf").Name;
            MelodicMinorScale DsEf_Scale = new MelodicMinorScale("DsEf");

            DsEf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, DsEf_Scale.Name);
        }
        [Fact]
        public void E_AccendStepAndAHalf_Test()
        {
            string expected = new MelodicMinorScale("G").Name;
            MelodicMinorScale E_Scale = new MelodicMinorScale("E");

            E_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, E_Scale.Name);
        }
        [Fact]
        public void F_AccendStepAndAHalf_Test()
        {
            string expected = new MelodicMinorScale("GsAf").Name;
            MelodicMinorScale F_Scale = new MelodicMinorScale("F");

            F_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, F_Scale.Name);
        }
        [Fact]
        public void FsGf_AccendStepAndAHalf_Test()
        {
            string expected = new MelodicMinorScale("A").Name;
            MelodicMinorScale FsGf_Scale = new MelodicMinorScale("FsGf");

            FsGf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, FsGf_Scale.Name);
        }
        [Fact]
        public void G_AccendStepAndAHalf_Test()
        {
            string expected = new MelodicMinorScale("AsBf").Name;
            MelodicMinorScale G_Scale = new MelodicMinorScale("G");

            G_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, G_Scale.Name);
        }
        [Fact]
        public void GsAf_AccendStepAndAHalf_Test()
        {
            string expected = new MelodicMinorScale("B").Name;
            MelodicMinorScale GsAf_Scale = new MelodicMinorScale("GsAf");

            GsAf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, GsAf_Scale.Name);
        }
    }
    public class getUnresolvedScale_Test
    {
        [Fact]
        public void A_getUnresolvedScale_Test()
        {
            string expected = "A B C D E F♯/G♭ G♯/A♭";
            MelodicMinorScale scaleToTest = new MelodicMinorScale("A");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());

        }
        [Fact]
        public void AsBf_getUnresolvedScale_Test()

        {
            string expected = "A♯/B♭ C C♯/D♭ D♯/E♭ F G A";
            MelodicMinorScale scaleToTest = new MelodicMinorScale("AsBf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void B_getUnresolvedScale_Test()

        {
            string expected = "B C♯/D♭ D E F♯/G♭ G♯/A♭ A♯/B♭";
            MelodicMinorScale scaleToTest = new MelodicMinorScale("B");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());

        }
        [Fact]
        public void C_getUnresolvedScale_Test()

        {
            string expected = "C D D♯/E♭ F G A B";
            MelodicMinorScale scaleToTest = new MelodicMinorScale("C");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void CsDf_getUnresolvedScale_Test()

        {
            string expected = "C♯/D♭ D♯/E♭ E F♯/G♭ G♯/A♭ A♯/B♭ C";
            MelodicMinorScale scaleToTest = new MelodicMinorScale("CsDf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void D_getUnresolvedScale_Test()

        {
            string expected = "D E F G A B C♯/D♭";
            MelodicMinorScale scaleToTest = new MelodicMinorScale("D");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void DsEf_getUnresolvedScale_Test()

        {
            string expected = "D♯/E♭ F F♯/G♭ G♯/A♭ A♯/B♭ C D";
            MelodicMinorScale scaleToTest = new MelodicMinorScale("DsEf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void E_getUnresolvedScale_Test()

        {
            string expected = "E F♯/G♭ G A B C♯/D♭ D♯/E♭";
            MelodicMinorScale scaleToTest = new MelodicMinorScale("E");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void F_getUnresolvedScale_Test()

        {
            string expected = "F G G♯/A♭ A♯/B♭ C D E";
            MelodicMinorScale scaleToTest = new MelodicMinorScale("F");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void FsGf_getUnresolvedScale_Test()

        {
            string expected = "F♯/G♭ G♯/A♭ A B C♯/D♭ D♯/E♭ F";
            MelodicMinorScale scaleToTest = new MelodicMinorScale("FsGf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void G_getUnresolvedScale_Test()

        {
            string expected = "G A A♯/B♭ C D E F♯/G♭";
            MelodicMinorScale scaleToTest = new MelodicMinorScale("G");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void GsAf_getUnresolvedScale_Test()

        {
            string expected = "G♯/A♭ A♯/B♭ B C♯/D♭ D♯/E♭ F G";
            MelodicMinorScale scaleToTest = new MelodicMinorScale("GsAf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
    };
}
