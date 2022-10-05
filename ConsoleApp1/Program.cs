using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Premier
    {
        public string Jmeno;
        public string SilneProhlaseni()
        {
            throw new NotImplementedException();
        }
        public Vlada Vlad;

    }

    class Ministr
    {
        public Ministr Min;
        public string Jmeno;
        public string SlabeProhlaseni()
        {
            return "No já tedy nevím, ale premiér by řekl" + Prem.SilneProhlaseni();
        }
        public Premier Prem;
        private void Demise()
        {
            Prem.Vlad.Ministerstvo.Remove(Min);
        }
    }

    class Vlada
    {
        public Premier Prem;
        public List <Ministr> Ministerstvo;
        public string Zeme;
        bool ZkusAnektovat(string obet)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
