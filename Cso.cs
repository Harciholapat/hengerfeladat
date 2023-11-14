using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class Cso : Henger
    {
        private int falvastagsag;

        public Cso(int magassag, int sugar, int szuletesSzamlalo, int falvastagsag) : base(magassag, sugar, szuletesSzamlalo)
        {
            this.falvastagsag = falvastagsag;
        }

        public int FalVastagsag
        {
            get => falvastagsag;
        }

        public void Terfogat()
        {
            throw new System.NotImplementedException();
        }

        public void ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}