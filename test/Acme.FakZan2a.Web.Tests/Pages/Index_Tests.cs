using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.FakZan2a.Pages
{
    public class Index_Tests : FakZan2aWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
