using System;
using System.Collections.Generic;
using System.Text;

namespace BatiThi3
{
    class Account : IAccount
    {
        public int Accountid { get; set; }
        public string Fistname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public float Balance { get;}
        public void Payinfo(int Amount)
        {
            throw new NotImplementedException();
        }

        public string Showinfo()
        {
            return $"{Accountid}\t\t{Fistname}\t\t{Lastname}\t\t{Gender}\t\t{Balance}";
        }
    }
}
