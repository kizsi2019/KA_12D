using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using networkutility.Ping


namespace networkutility.Tests.PingTests
{
    public class networkservicetests
    {
        [Fact]
        public void networkservice_SendPing_ReturnString()
        {
            var pingService = new networkservicetests();
            var result = pingService.SendPing();
            result.Should().Be("Success: Ping sent!");
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Contain("Ping", Exactly.Once());
        }
        [Theory]
        [InlineData[1,1,2]]
        [InlineData[2,2,4]]
        public void networkservice_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            var pingService = new networkservicetests();
            var result = pingService.networkservice_PingTimeout_ReturnInt(a, b);
            result.Should().Be(expected);
            result.Should().NotBeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }
    }
}
