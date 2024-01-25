using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkUtility.Ping;
using Xunit;
using FluentAssertions;

namespace NetworkUtility.tests.pingtests
{
    public class NetworkServiceTests
    {
        [Fact]
        public void NetworkServices_SendPing_ReturnString()
        {
            var pingService = new NetworkService();

            var result = pingService.SendPing();

            result.Should().Be("Success: Ping Sent");
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Contain("Ping", Exactly.Once());
        }
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]

        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected) 
        {
            var pingService = new NetworkService();

            var result = pingService.PingTimeout(a, b);

            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }
    }
}
