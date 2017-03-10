using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace feladat
{
    public class Burkolo : Mesterember
    {
        private int szakterulet;

        public void OsszesSzabadnap()
        {
            throw new System.NotImplementedException();
        }

        public override void MindenAdat()
        {
            throw new System.NotImplementedException();
        }

        public void MunkatVallal()
        {
            throw new System.NotImplementedException();
        }

        public enum Szakterulet
        {
            Belso,
            Kulso
        }
    }
}