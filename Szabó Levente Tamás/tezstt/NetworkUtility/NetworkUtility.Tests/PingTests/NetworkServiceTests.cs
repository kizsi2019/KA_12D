using System;
using System.Net.NetworkInformation;
using FluentAssertions;
using FluentAssertions.Extensions;
using NetworkUtility.Ping;
using Xunit;
using FakeItEasy;
using System.Net;
using NetworkUtility.DNS;

namespace NetworkUtility.Tests.PingTests
{
    public class NetworkServiceTests
    {
        private readonly NetworkService _pingService;
        private readonly IDNS _dns;

        public NetworkServiceTests()
        {
            _dns = A.Fake<IDNS>();
            _pingService = new NetworkService(_dns);
        }

        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            // Arrange
            var pingService = new NetworkService(_dns);

            // Act
            var result = pingService.SendPing();

            // Assert
            result.Should().Be("Success: Ping sent");
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Contain("Ping", Exactly.Once());
        }

        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            // Arrange
            var pingService = new NetworkService(_dns);

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
            var result = _pingService.LastPingDate();
            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));
        }

        [Fact]
        public void NetworkService_MostRecentPings_ReturnObject()
        {
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };
            var result = _pingService.MostRecentPings();
            result.Should().BeOfType<PingOptions[]>();
            result.Should().ContainEquivalentOf(expected);
            result.Should().Contain(x => x.DontFragment == true);
        }
    }
}
