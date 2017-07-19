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
            int childId = 322;
            List<int> listId = _santa.CheckSantasList(childId);

            Assert.IsType<List<int>>(listId);
        }
    }
}