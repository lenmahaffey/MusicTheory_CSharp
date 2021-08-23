/*
    CSC236 8N0 Intro to C#
    Project: Final Project
    File: Major_Test.cs
    By: Len Mahaffey
    Last Edited: 12/11/20
    Description: MajorScale class testing
*/
using CSC236_LMahaffey_FinalProject;
using Xunit;

namespace MajorScale_Test
{
    public class ConstructorWithPosition_Test
    {
        [Fact]
        public void A_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            MajorScale A = new MajorScale(new Pitch(Pitch.ChromaticScalePosition.A));
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            MajorScale AsBf = new MajorScale(new Pitch(Pitch.ChromaticScalePosition.AsBf));
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            MajorScale B = new MajorScale(new Pitch(Pitch.ChromaticScalePosition.B));
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            MajorScale C = new MajorScale(new Pitch(Pitch.ChromaticScalePosition.C));
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            MajorScale CsDf = new MajorScale(new Pitch(Pitch.ChromaticScalePosition.CsDf));
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            MajorScale D = new MajorScale(new Pitch(Pitch.ChromaticScalePosition.D));
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            MajorScale DsEf = new MajorScale(new Pitch(Pitch.ChromaticScalePosition.DsEf));
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            MajorScale E = new MajorScale(new Pitch(Pitch.ChromaticScalePosition.E));
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            MajorScale F = new MajorScale(new Pitch(Pitch.ChromaticScalePosition.F));
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            MajorScale FsGf = new MajorScale(new Pitch(Pitch.ChromaticScalePosition.FsGf));
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            MajorScale G = new MajorScale(new Pitch(Pitch.ChromaticScalePosition.G));
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithPosition_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            MajorScale GsAf = new MajorScale(new Pitch(Pitch.ChromaticScalePosition.GsAf));
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class ConstructorWithInt_Test
    {
        [Fact]
        public void NONE_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            MajorScale NONE = new MajorScale(0);
            Assert.Equal(expected, NONE.Pitch.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            MajorScale A = new MajorScale(1);
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            MajorScale AsBf = new MajorScale(2);
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            MajorScale B = new MajorScale(3);
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            MajorScale C = new MajorScale(4);
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            MajorScale CsDf = new MajorScale(5);
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            MajorScale D = new MajorScale(6);
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            MajorScale DsEf = new MajorScale(7);
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            MajorScale E = new MajorScale(8);
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            MajorScale F = new MajorScale(9);
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            MajorScale FsGf = new MajorScale(10);
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            MajorScale G = new MajorScale(11);
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithInt_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            MajorScale GsAf = new MajorScale(12);
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class ConstructorWithString_Test
    {
        [Fact]
        public void NONE_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.NONE;
            MajorScale NONE = new MajorScale("NONE");
            Assert.Equal(expected, NONE.Pitch.GetPosition());
        }
        [Fact]
        public void A_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.A;
            MajorScale A = new MajorScale("A");
            Assert.Equal(expected, A.Pitch.GetPosition());
        }
        [Fact]
        public void AsBf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.AsBf;
            MajorScale AsBf = new MajorScale("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetPosition());
        }
        [Fact]
        public void B_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.B;
            MajorScale B = new MajorScale("B");
            Assert.Equal(expected, B.Pitch.GetPosition());
        }
        [Fact]
        public void C_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.C;
            MajorScale C = new MajorScale("C");
            Assert.Equal(expected, C.Pitch.GetPosition());
        }
        [Fact]
        public void CsDf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.CsDf;
            MajorScale CsDf = new MajorScale("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetPosition());
        }
        [Fact]
        public void D_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.D;
            MajorScale D = new MajorScale("D");
            Assert.Equal(expected, D.Pitch.GetPosition());
        }
        [Fact]
        public void DsEf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.DsEf;
            MajorScale DsEf = new MajorScale("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetPosition());
        }
        [Fact]
        public void E_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.E;
            MajorScale E = new MajorScale("E");
            Assert.Equal(expected, E.Pitch.GetPosition());
        }
        [Fact]
        public void F_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.F;
            MajorScale F = new MajorScale("F");
            Assert.Equal(expected, F.Pitch.GetPosition());
        }
        [Fact]
        public void FsGf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.FsGf;
            MajorScale FsGf = new MajorScale("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetPosition());
        }
        [Fact]
        public void G_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.G;
            MajorScale G = new MajorScale("G");
            Assert.Equal(expected, G.Pitch.GetPosition());
        }
        [Fact]
        public void GsAf_ConstructorWithString_Test()
        {
            Pitch.ChromaticScalePosition expected = Pitch.ChromaticScalePosition.GsAf;
            MajorScale GsAf = new MajorScale("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetPosition());
        }
    }
    public class GetPositionAsString_Test
    {
        [Fact]
        public void NONE_getPositionAsString_Test()
        {
            string expected = "NONE";
            MajorScale NONE = new MajorScale("NONE");
            Assert.Equal(expected, NONE.Pitch.GetPositionAsString());
        }
        [Fact]
        public void A_getPositionAsString_Test()
        {
            string expected = "A";
            MajorScale A = new MajorScale("A");
            Assert.Equal(expected, A.Pitch.GetPositionAsString());
        }
        [Fact]
        public void AsBf_getPositionAsString_Test()
        {
            string expected = "AsBf";
            MajorScale AsBf = new MajorScale("AsBf");
            Assert.Equal(expected, AsBf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void B_getPositionAsString_Test()
        {
            string expected = "B";
            MajorScale B = new MajorScale("B");
            Assert.Equal(expected, B.Pitch.GetPositionAsString());
        }
        [Fact]
        public void C_getPositionAsString_Test()
        {
            string expected = "C";
            MajorScale C = new MajorScale("C");
            Assert.Equal(expected, C.Pitch.GetPositionAsString());
        }
        [Fact]
        public void CsDf_getPositionAsString_Test()
        {
            string expected = "CsDf";
            MajorScale CsDf = new MajorScale("CsDf");
            Assert.Equal(expected, CsDf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void D_getPositionAsString_Test()
        {
            string expected = "D";
            MajorScale D = new MajorScale("D");
            Assert.Equal(expected, D.Pitch.GetPositionAsString());
        }
        [Fact]
        public void DsEf_getPositionAsString_Test()
        {
            string expected = "DsEf";
            MajorScale DsEf = new MajorScale("DsEf");
            Assert.Equal(expected, DsEf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void E_getPositionAsString_Test()
        {
            string expected = "E";
            MajorScale E = new MajorScale("E");
            Assert.Equal(expected, E.Pitch.GetPositionAsString());
        }
        [Fact]
        public void F_getPositionAsString_Test()
        {
            string expected = "F";
            MajorScale F = new MajorScale("F");
            Assert.Equal(expected, F.Pitch.GetPositionAsString());
        }
        [Fact]
        public void FsGf_getPositionAsString_Test()
        {
            string expected = "FsGf";
            MajorScale FsGf = new MajorScale("FsGf");
            Assert.Equal(expected, FsGf.Pitch.GetPositionAsString());
        }
        [Fact]
        public void G_getPositionAsString_Test()
        {
            string expected = "G";
            MajorScale G = new MajorScale("G");
            Assert.Equal(expected, G.Pitch.GetPositionAsString());
        }
        [Fact]
        public void GsAf_getPositionAsString_Test()
        {
            string expected = "GsAf";
            MajorScale GsAf = new MajorScale("GsAf");
            Assert.Equal(expected, GsAf.Pitch.GetPositionAsString());
        }
    }
    public class GetName_Test
    {
        [Fact]
        public void NONE_getPositionAsString_Test()
        {
            string expected = "NONE";
            MajorScale NONE = new MajorScale("NONE");
            Assert.Equal(expected, NONE.Name);
        }
        [Fact]
        public void A_getPositionAsString_Test()
        {
            string expected = "A";
            MajorScale A = new MajorScale("A");
            Assert.Equal(expected, A.Name);
        }
        [Fact]
        public void AsBf_getPositionAsString_Test()
        {
            string expected = "A♯/B♭";
            MajorScale AsBf = new MajorScale("AsBf");
            Assert.Equal(expected, AsBf.Name);
        }
        [Fact]
        public void As_getPositionAsString_Test()
        {
            string expected = "A♯";
            MajorScale AsBf = new MajorScale("As");
            Assert.Equal(expected, AsBf.Name);
        }
        [Fact]
        public void Bf_getPositionAsString_Test()
        {
            string expected = "B♭";
            MajorScale AsBf = new MajorScale("Bf");
            Assert.Equal(expected, AsBf.Name);
        }
        [Fact]
        public void B_getPositionAsString_Test()
        {
            string expected = "B";
            MajorScale B = new MajorScale("B");
            Assert.Equal(expected, B.Name);
        }
        [Fact]
        public void C_getPositionAsString_Test()
        {
            string expected = "C";
            MajorScale C = new MajorScale("C");
            Assert.Equal(expected, C.Name);
        }
        [Fact]
        public void CsDf_getPositionAsString_Test()
        {
            string expected = "C♯/D♭";
            MajorScale CsDf = new MajorScale("CsDf");
            Assert.Equal(expected, CsDf.Name);
        }
        [Fact]
        public void Cs_getPositionAsString_Test()
        {
            string expected = "C♯";
            MajorScale CsDf = new MajorScale("Cs");
            Assert.Equal(expected, CsDf.Name);
        }
        [Fact]
        public void Df_getPositionAsString_Test()
        {
            string expected = "D♭";
            MajorScale CsDf = new MajorScale("Df");
            Assert.Equal(expected, CsDf.Name);
        }
        [Fact]
        public void D_getPositionAsString_Test()
        {
            string expected = "D";
            MajorScale D = new MajorScale("D");
            Assert.Equal(expected, D.Name);
        }
        [Fact]
        public void DsEf_getPositionAsString_Test()
        {
            string expected = "D♯/E♭";
            MajorScale DsEf = new MajorScale("DsEf");
            Assert.Equal(expected, DsEf.Name);
        }
        [Fact]
        public void Ds_getPositionAsString_Test()
        {
            string expected = "D♯";
            MajorScale DsEf = new MajorScale("Ds");
            Assert.Equal(expected, DsEf.Name);
        }
        [Fact]
        public void Ef_getPositionAsString_Test()
        {
            string expected = "E♭";
            MajorScale DsEf = new MajorScale("Ef");
            Assert.Equal(expected, DsEf.Name);
        }
        [Fact]
        public void E_getPositionAsString_Test()
        {
            string expected = "E";
            MajorScale E = new MajorScale("E");
            Assert.Equal(expected, E.Name);
        }
        [Fact]
        public void F_getPositionAsString_Test()
        {
            string expected = "F";
            MajorScale F = new MajorScale("F");
            Assert.Equal(expected, F.Name);
        }
        [Fact]
        public void FsGf_getPositionAsString_Test()
        {
            string expected = "F♯/G♭";
            MajorScale FsGf = new MajorScale("FsGf");
            Assert.Equal(expected, FsGf.Name);
        }
        [Fact]
        public void Fs_GetPositionAsString_Test()
        {
            string expected = "F♯";
            MajorScale FsGf = new MajorScale("Fs");
            Assert.Equal(expected, FsGf.Name);
        }
        [Fact]
        public void Gf_getPositionAsString_Test()
        {
            string expected = "G♭";
            MajorScale FsGf = new MajorScale("Gf");
            Assert.Equal(expected, FsGf.Name);
        }
        [Fact]
        public void G_getPositionAsString_Test()
        {
            string expected = "G";
            MajorScale G = new MajorScale("G");
            Assert.Equal(expected, G.Name);
        }
        [Fact]
        public void GsAf_getPositionAsString_Test()
        {
            string expected = "G♯/A♭";
            MajorScale GsAf = new MajorScale("GsAf");
            Assert.Equal(expected, GsAf.Name);
        }
    }
    public class AccendHalfStep_Test
    {
        [Fact]
        public void A_AccendHalfStep_Test()
        {
            string expected = new MajorScale("AsBf").Name;
            MajorScale A_Scale = new MajorScale("A");

            A_Scale.AccendHalfStep();
            Assert.Equal(expected, A_Scale.Name);
        }
        [Fact]
        public void AsBf_AccendHalfStep_Test()
        {
            string expected = new MajorScale("B").Name;
            MajorScale AsBf_Scale = new MajorScale("AsBf");

            AsBf_Scale.AccendHalfStep();
            Assert.Equal(expected, AsBf_Scale.Name);
        }
        [Fact]
        public void B_AccendHalfStep_Test()
        {
            string expected = new MajorScale("C").Name;
            MajorScale B_Scale = new MajorScale("B");

            B_Scale.AccendHalfStep();
            Assert.Equal(expected, B_Scale.Name);
        }
        [Fact]
        public void C_AccendHalfStep_Test()
        {
            string expected = new MajorScale("CsDf").Name;
            MajorScale C_Scale = new MajorScale("C");

            C_Scale.AccendHalfStep();
            Assert.Equal(expected, C_Scale.Name);
        }
        [Fact]
        public void CsDf_AccendHalfStep_Test()
        {
            string expected = new MajorScale("D").Name;
            MajorScale CsDf_Scale = new MajorScale("CsDf");

            CsDf_Scale.AccendHalfStep();
            Assert.Equal(expected, CsDf_Scale.Name);
        }
        [Fact]
        public void D_AccendHalfStep_Test()
        {
            string expected = new MajorScale("DsEf").Name;
            MajorScale D_Scale = new MajorScale("D");

            D_Scale.AccendHalfStep();
            Assert.Equal(expected, D_Scale.Name);
        }
        [Fact]
        public void DsEf_AccendHalfStep_Test()
        {
            string expected = new MajorScale("E").Name;
            MajorScale DsEf_Scale = new MajorScale("DsEf");

            DsEf_Scale.AccendHalfStep();
            Assert.Equal(expected, DsEf_Scale.Name);
        }
        [Fact]
        public void E_AccendHalfStep_Test()
        {
            string expected = new MajorScale("F").Name;
            MajorScale E_Scale = new MajorScale("E");

            E_Scale.AccendHalfStep();
            Assert.Equal(expected, E_Scale.Name);
        }
        [Fact]
        public void F_AccendHalfStep_Test()
        {
            string expected = new MajorScale("FsGf").Name;
            MajorScale F_Scale = new MajorScale("F");

            F_Scale.AccendHalfStep();
            Assert.Equal(expected, F_Scale.Name);
        }
        [Fact]
        public void fSGf_AccendHalfStep_Test()
        {
            string expected = new MajorScale("G").Name;
            MajorScale fSGf_Scale = new MajorScale("FsGf");

            fSGf_Scale.AccendHalfStep();
            Assert.Equal(expected, fSGf_Scale.Name);
        }
        [Fact]
        public void G_AccendHalfStep_Test()
        {
            string expected = new MajorScale("GsAf").Name;
            MajorScale G_Scale = new MajorScale("G");

            G_Scale.AccendHalfStep();
            Assert.Equal(expected, G_Scale.Name);
        }
        [Fact]
        public void GsAf_AccendHalfStep_Test()
        {
            string expected = new MajorScale("A").Name;
            MajorScale GsAf_Scale = new MajorScale("GsAf");

            GsAf_Scale.AccendHalfStep();
            Assert.Equal(expected, GsAf_Scale.Name);
        }
    }
    public class AccendWholeStep_Test
    {
        [Fact]
        public void A_AccendWholeStep_Test()
        {
            string expected = new MajorScale("B").Name;
            MajorScale A_Scale = new MajorScale("A");

            A_Scale.AccendWholeStep();
            Assert.Equal(expected, A_Scale.Name);
        }
        [Fact]
        public void AsBf_AccendWholeStep_Test()
        {
            string expected = new MajorScale("C").Name;
            MajorScale AsBf_Scale = new MajorScale("AsBf");

            AsBf_Scale.AccendWholeStep();
            Assert.Equal(expected, AsBf_Scale.Name);
        }
        [Fact]
        public void B_AccendWholeStep_Test()
        {
            string expected = new MajorScale("CsDf").Name;
            MajorScale B_Scale = new MajorScale("B");

            B_Scale.AccendWholeStep();
            Assert.Equal(expected, B_Scale.Name);
        }
        [Fact]
        public void C_AccendWholeStep_Test()
        {
            string expected = new MajorScale("D").Name;
            MajorScale C_Scale = new MajorScale("C");

            C_Scale.AccendWholeStep();
            Assert.Equal(expected, C_Scale.Name);
        }
        [Fact]
        public void CsDf_AccendWholeStep_Test()
        {
            string expected = new MajorScale("DsEf").Name;
            MajorScale CsDf_Scale = new MajorScale("CsDf");

            CsDf_Scale.AccendWholeStep();
            Assert.Equal(expected, CsDf_Scale.Name);
        }
        [Fact]
        public void D_AccendWholeStep_Test()
        {
            string expected = new MajorScale("E").Name;
            MajorScale D_Scale = new MajorScale("D");

            D_Scale.AccendWholeStep();
            Assert.Equal(expected, D_Scale.Name);
        }
        [Fact]
        public void DsEf_AccendWholeStep_Test()
        {
            string expected = new MajorScale("F").Name;
            MajorScale DsEf_Scale = new MajorScale("DsEf");

            DsEf_Scale.AccendWholeStep();
            Assert.Equal(expected, DsEf_Scale.Name);
        }
        [Fact]
        public void E_AccendWholeStep_Test()
        {
            string expected = new MajorScale("FsGf").Name;
            MajorScale E_Scale = new MajorScale("E");

            E_Scale.AccendWholeStep();
            Assert.Equal(expected, E_Scale.Name);
        }
        [Fact]
        public void F_AccendWholeStep_Test()
        {
            string expected = new MajorScale("G").Name;
            MajorScale F_Scale = new MajorScale("F");

            F_Scale.AccendWholeStep();
            Assert.Equal(expected, F_Scale.Name);
        }
        [Fact]
        public void FsGf_AccendWholeStep_Test()
        {
            string expected = new MajorScale("GsAf").Name;
            MajorScale FsGf_Scale = new MajorScale("FsGf");

            FsGf_Scale.AccendWholeStep();
            Assert.Equal(expected, FsGf_Scale.Name);
        }
        [Fact]
        public void G_AccendWholeStep_Test()
        {
            string expected = new MajorScale("A").Name;
            MajorScale G_Scale = new MajorScale("G");

            G_Scale.AccendWholeStep();
            Assert.Equal(expected, G_Scale.Name);
        }
        [Fact]
        public void GsAf_AccendWholeStep_Test()
        {
            string expected = new MajorScale("AsBf").Name;
            MajorScale GsAf_Scale = new MajorScale("GsAf");

            GsAf_Scale.AccendWholeStep();
            Assert.Equal(expected, GsAf_Scale.Name);
        }
    }
    public class AccendStepAndAHalf_Test
        {
        [Fact]
        public void A_AccendStepAndAHalf_Test()
        {
            string expected = new MajorScale("C").Name;
            MajorScale A_Scale = new MajorScale("A");

            A_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, A_Scale.Name);
        }
        [Fact]
        public void AsBf_AccendStepAndAHalf_Test()
        {
            string expected = new MajorScale("CsDf").Name;
            MajorScale AsBf_Scale = new MajorScale("AsBf");

            AsBf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, AsBf_Scale.Name);
        }
        [Fact]
        public void B_AccendStepAndAHalf_Test()
        {
            string expected = new MajorScale("D").Name;
            MajorScale B_Scale = new MajorScale("B");

            B_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, B_Scale.Name);
        }
        [Fact]
        public void C_AccendStepAndAHalf_Test()
        {
            string expected = new MajorScale("DsEf").Name;
            MajorScale C_Scale = new MajorScale("C");

            C_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, C_Scale.Name);
        }
        [Fact]
        public void CsDf_AccendStepAndAHalf_Test()
        {
            string expected = new MajorScale("E").Name;
            MajorScale CsDf_Scale = new MajorScale("CsDf");

            CsDf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, CsDf_Scale.Name);
        }
        [Fact]
        public void D_AccendStepAndAHalf_Test()
        {
            string expected = new MajorScale("F").Name;
            MajorScale D_Scale = new MajorScale("D");

            D_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, D_Scale.Name);
        }
        [Fact]
        public void DsEf_AccendStepAndAHalf_Test()
        {
            string expected = new MajorScale("FsGf").Name;
            MajorScale DsEf_Scale = new MajorScale("DsEf");

            DsEf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, DsEf_Scale.Name);
        }
        [Fact]
        public void E_AccendStepAndAHalf_Test()
        {
            string expected = new MajorScale("G").Name;
            MajorScale E_Scale = new MajorScale("E");

            E_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, E_Scale.Name);
        }
        [Fact]
        public void F_AccendStepAndAHalf_Test()
        {
            string expected = new MajorScale("GsAf").Name;
            MajorScale F_Scale = new MajorScale("F");

            F_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, F_Scale.Name);
        }
        [Fact]
        public void FsGf_AccendStepAndAHalf_Test()
        {
            string expected = new MajorScale("A").Name;
            MajorScale FsGf_Scale = new MajorScale("FsGf");

            FsGf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, FsGf_Scale.Name);
        }
        [Fact]
        public void G_AccendStepAndAHalf_Test()
        {
            string expected = new MajorScale("AsBf").Name;
            MajorScale G_Scale = new MajorScale("G");

            G_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, G_Scale.Name);
        }
        [Fact]
        public void GsAf_AccendStepAndAHalf_Test()
        {
            string expected = new MajorScale("B").Name;
            MajorScale GsAf_Scale = new MajorScale("GsAf");

            GsAf_Scale.AccendStepAndAHalf();
            Assert.Equal(expected, GsAf_Scale.Name);
        }
    }
    public class getUnresolvedScale_Test
    {
        [Fact]
        public void AMajor_getUnresolvedScale_Test()
        {
            string expected = "A B C♯/D♭ D E F♯/G♭ G♯/A♭";
            MajorScale scaleToTest = new MajorScale("A");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());

        }
        [Fact]
        public void AsBfMajor_getUnresolvedScale_Test()

        {
            string expected = "A♯/B♭ C D D♯/E♭ F G A";
            MajorScale scaleToTest = new MajorScale("AsBf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void BMajor_getUnresolvedScale_Test()

        {
            string expected = "B C♯/D♭ D♯/E♭ E F♯/G♭ G♯/A♭ A♯/B♭";
            MajorScale scaleToTest = new MajorScale("B");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());

        }
        [Fact]
        public void CMajor_getUnresolvedScale_Test()

        {
            string expected = "C D E F G A B";
            MajorScale scaleToTest = new MajorScale("C");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void CsDfMajor_getUnresolvedScale_Test()

        {
            string expected = "C♯/D♭ D♯/E♭ F F♯/G♭ G♯/A♭ A♯/B♭ C";
            MajorScale scaleToTest = new MajorScale("CsDf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void DMajor_getUnresolvedScale_Test()

        {
            string expected = "D E F♯/G♭ G A B C♯/D♭";
            MajorScale scaleToTest = new MajorScale("D");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void DsEfMajor_getUnresolvedScale_Test()

        {
            string expected = "D♯/E♭ F G G♯/A♭ A♯/B♭ C D";
            MajorScale scaleToTest = new MajorScale("DsEf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void EMajor_getUnresolvedScale_Test()

        {
            string expected = "E F♯/G♭ G♯/A♭ A B C♯/D♭ D♯/E♭";
            MajorScale scaleToTest = new MajorScale("E");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void FMajor_getUnresolvedScale_Test()

        {
            string expected = "F G A A♯/B♭ C D E";
            MajorScale scaleToTest = new MajorScale("F");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void FsGfMajor_getUnresolvedScale_Test()

        {
            string expected = "F♯/G♭ G♯/A♭ A♯/B♭ B C♯/D♭ D♯/E♭ F";
            MajorScale scaleToTest = new MajorScale("FsGf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void GMajor_getUnresolvedScale_Test()

        {
            string expected = "G A B C D E F♯/G♭";
            MajorScale scaleToTest = new MajorScale("G");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
        [Fact]
        public void GsAfMajor_getUnresolvedScale_Test()

        {
            string expected = "G♯/A♭ A♯/B♭ C C♯/D♭ D♯/E♭ F G";
            MajorScale scaleToTest = new MajorScale("GsAf");
            Assert.Equal(expected, scaleToTest.getUnresolvedScaleAsString());
        }
    };
    public class GetScale_Test
    {
        [Fact]
        public void A_Major_GetScale_Test()
        {
            string expected = "A B C♯ D E F♯ G♯";
            MajorScale scaleToTest = new MajorScale("A");
            Assert.Equal(expected, scaleToTest.GetScaleAsString());

        }
        [Fact]
        public void AsBf_Major_GetScale_Test()

        {
            string expected = "B♭ C D E♭ F G A";
            MajorScale scaleToTest = new MajorScale("Bf");
            Assert.Equal(expected, scaleToTest.GetScaleAsString());
        }
        [Fact]
        public void B_Major_GetScale_Test()

        {
            string expected = "B C♯ D♯ E F♯ G♯ A♯";
            MajorScale scaleToTest = new MajorScale("B");
            Assert.Equal(expected, scaleToTest.GetScaleAsString());

        }
        [Fact]
        public void C_Major_GetScale_Test()

        {
            string expected = "C D E F G A B";
            MajorScale scaleToTest = new MajorScale("C");
            Assert.Equal(expected, scaleToTest.GetScaleAsString());
        }
        [Fact]
        public void CsDf_Major_GetScale_Test()

        {
            string expected = "D♭ E♭ F G♭ A♭ B♭ C";
            MajorScale scaleToTest = new MajorScale("Df");
            Assert.Equal(expected, scaleToTest.GetScaleAsString());
        }
        [Fact]
        public void D_Major_GetScale_Test()

        {
            string expected = "D E F♯ G A B C♯";
            MajorScale scaleToTest = new MajorScale("D");
            Assert.Equal(expected, scaleToTest.GetScaleAsString());
        }
        [Fact]
        public void DsEf_Major_GetScale_Test()

        {
            string expected = "E♭ F G A♭ B♭ C D";
            MajorScale scaleToTest = new MajorScale("Ef");
            Assert.Equal(expected, scaleToTest.GetScaleAsString());
        }
        [Fact]
        public void E_Major_GetScale_Test()

        {
            string expected = "E F♯ G♯ A B C♯ D♯";
            MajorScale scaleToTest = new MajorScale("E");
            Assert.Equal(expected, scaleToTest.GetScaleAsString());
        }
        [Fact]
        public void F_Major_GetScale_Test()

        {
            string expected = "F G A B♭ C D E";
            MajorScale scaleToTest = new MajorScale("F");
            Assert.Equal(expected, scaleToTest.GetScaleAsString());
        }
        [Fact]
        public void FsGf_Major_GetScale_Test()

        {
            string expected = "F♯ G♯ A♯ B C♯ D♯ F";
            MajorScale scaleToTest = new MajorScale("Fs");
            Assert.Equal(expected, scaleToTest.GetScaleAsString());
        }
        [Fact]
        public void G_Major_GetScale_Test()

        {
            string expected = "G A B C D E F♯";
            MajorScale scaleToTest = new MajorScale("G");
            Assert.Equal(expected, scaleToTest.GetScaleAsString());
        }
        [Fact]
        public void GsAf_Major_GetScale_Test()

        {
            string expected = "A♭ B♭ C D♭ E♭ F G";
            MajorScale scaleToTest = new MajorScale("Af");
            Assert.Equal(expected, scaleToTest.GetScaleAsString());
        }
    };
}
