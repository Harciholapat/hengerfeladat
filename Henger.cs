using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Henger
    {
        private int magassag;
        private int sugar;
        private int szuletesSzamlalo;

        public Henger(int magassag, int sugar, int szuletesSzamlalo)
        {
            this.magassag = magassag;
            this.sugar = sugar;
            this.szuletesSzamlalo = szuletesSzamlalo;
        }

        public int GetMagassag
        {
            get => magassag;
        }

        public int GetSugar
        {
            get => sugar;
        }

        public int SzuletesSzamlalo
        {
            get => szuletesSzamlalo;
        }

        public double Terfogat()
        {
            return Math.Pow(sugar, 2) * Math.PI * magassag;
        }

        public void ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}
