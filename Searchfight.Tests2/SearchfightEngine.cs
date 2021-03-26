using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Searchfight.Tests2
{
    [TestFixture]
    public class SearchfightEngine
    {
        [Test]
        public async Task Query_Expected_PositiveAsync()
        {
            string[] searchValues = new string[3];
            Principal principal = new Principal();
            var result = await principal.CalculateSearchfight(searchValues);
            Assert.IsNotNull(result);
        }
    }
}
