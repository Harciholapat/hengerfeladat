﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public class TomorHenger : Henger
    {
        private int fajsuly;
        private int suly;

        public TomorHenger(int magassag, int sugar, int szuletesSzamlalo, int fajsuly, int suly) : base(magassag, sugar, szuletesSzamlalo)
        {
            this.fajsuly = fajsuly;
            this.suly = suly;
        }

        public int GetFajsuly
        {
            get => fajsuly;
        }

        public int Suly
        {
            get => suly;
        }

        public void ToString()
        {
            throw new System.NotImplementedException();
        }
    }
}