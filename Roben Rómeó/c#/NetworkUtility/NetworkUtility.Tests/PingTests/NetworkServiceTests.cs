using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkUtility.T;


namespace NetworkUtility.Tests.PingTests
{
    internal class NetworkServiceTests
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            var pingService = new NetworkServiceTests();
            var result = pingService.SendPing();
            result.Should().Be("Success: Ping sent!");
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Contain("Ping", Exactly.Once());
        }
        [Theory]
        [InlineData[1,1,2]]
        [InlineData[2,2,4]]
        public void NetworkService_ReceivePing_ReturnInt(int a, int b, int expected)
        {
            var pingService = new NetworkServiceTests();
            var result = pingService.NetworkService_SendPing_ReturnInt(a, b);
            result.Should().Be(expected);
            result.Should().NotBeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }
    }
}
