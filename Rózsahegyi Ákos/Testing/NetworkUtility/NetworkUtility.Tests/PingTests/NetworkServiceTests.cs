using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkUtility.Ping;
using FluentAssertions;

namespace NetworkUtility.Tests.PingTests
{
    public class NetworkServiceTests
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            // Arrange
            var pingService = new NetworkServiceTests();

            // Act
            var result = pingService.SendPing();

            // Assert
            result.Should().Be("Success: Ping sent");
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Contain("Ping", Exactly.Once());
        }
        [Theory]
        [InlineData[1,1,2]]
        [InlineData[2,2,4]]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            // Arrange
            var pingService = new NetworkServiceTests();

            // Act
            var result = pingService.NetworkService_PingTimeout_ReturnInt(a, b);

            // Assert
            result.Should().Be(expected);
            result.Should().NotBeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }
    }
}
