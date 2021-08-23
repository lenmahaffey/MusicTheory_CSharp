/*
    CSC236 8N0 Intro to C#
    Project: Final Project
    File: MusicException.cs
    By: Len Mahaffey
    Last Edited: 12/11/20
    Description: Exception class for MusicTheory project.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_LMahaffey_FinalProject
{
    class MusicException : Exception
    {
        public MusicException() : base()
        {
        }
        public string message{ get; set;}
    }
}
