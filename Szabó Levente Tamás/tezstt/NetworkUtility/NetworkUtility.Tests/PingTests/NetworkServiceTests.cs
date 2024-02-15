using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkUtility.Ping;
using Xunit;
using FluentAssertions;
using FluentAssertions.Extensions;

namespace NetworkUtility.Tests.PingTests
{
    private readonly NetworkServiceTests _pingservice;
    public NetworkServiceTests()
    {
        _pingservice = new NetworkServiceTests();
    }
    public class NetworkServiceTests
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            // Arrange
            var pingService = new NetworkService();

            // Act
            var result = pingService.SendPing();

            // Assert
            result.Should().Be("Success: Ping sent");
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Contain("Ping", Exactly.Once());
        }
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            // Arrange
            var pingService = new NetworkService();

            // Act
            var result = pingService.PingTimeout(a, b);

            // Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }
        [Fact]
        public void NetworkService_LastPingDate_ReturnDate()
        {
            var result = pingservice.LastPingDate();
            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));
        }
    }
}