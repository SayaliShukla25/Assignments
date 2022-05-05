using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Oops
{
    class Voter
    {
        long adharcard;
        string votername;
        string votecasted;

        public void SetAdharCard(long card)
        {
            adharcard = card;
        }
        public long GetAdharCard()
        {
            return adharcard;
        }

        public void SetVoterName(string name)
        {
            votername = name;

        }
        public string GetVoterName()
        {
            return votername;
        }

        public void SetVoteCasted(string vote)
        {
            votecasted = vote;

        }
        public string GetVoteCasted()
        {
            return votecasted;
        }

        static void Main(string[] args)
        {
            Voter v1 = new Voter();
            v1.SetAdharCard(255556);
            v1.SetVoterName("Sayali");
            v1.SetVoteCasted("Congress");



        }

    }
}
