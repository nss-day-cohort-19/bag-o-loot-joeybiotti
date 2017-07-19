using System;
using System.Collections.Generic;
using Xunit;

namespace BagOLoot.Tests
{
    public class SantaClausShould
    {
        SantaClaus _santa = new SantaClaus();
        public SantaClausShould()
        {
            _santa = new SantaClaus();
        }
       
        [Fact]//santa checks his list, returns list of childIds
        public void SantaChecksHisListTwice()
        {
            int childId = 5532;
            List<int> listId = _santa.CheckSantasList(childId);

            Assert.IsType<List<int>>(listId);
        }

        [Fact]
        public bool ToyDeliveryStatus()
        {
            return true; 
        }

        [Fact]
        public void YuletideReport()
        {
            int childId = 2314;
            int toyId = 985;
            List<int> report = _santa.RunYuletideReport(childId, toyId);
        }
    }
}