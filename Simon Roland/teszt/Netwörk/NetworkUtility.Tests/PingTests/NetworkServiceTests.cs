using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkUtility.Ping;
using Xunit;
using FluentAssertions;
using FluentAssertions.Extensions;
using System.Net.NetworkInformation;
using Xunit.Sdk;
using NetworkUtility.DNS;

namespace NetworkUtility.Tests.PingTests
{
    public class NetworkServiceTests
    {
        private readonly NetworkService _pingService;
        private readonly IDNS _dNS;
        public NetworkServiceTests()
        {
            // Dependencies
            _dNS = A.Fake<IDNS>();
            
            // SUT 
            _pingService = new NetworkService(_dNS);
        }


        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            // Arrange
            A.CallTo(() => _dNS.SendDNS()).Returns(true);

            // Act
            var result = _pingService.SendPing();

            // Assert
            result.Should().Be("Success: Ping sent");
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Contain("Ping", Exactly.Once());
        }

        [Fact]
        public void NetworkService_LastPingDate_ReturnString()
        {
            // Arrange


            // Act
            var result = _pingService.LastPingDate();

            // Assert
            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));
        }
        [Fact]
        public void NetworkService_GetPingOptions_ReturnString()
        {
            // Arrange
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            // Act
            var result = _pingService.GetPingOptions();

            // Assert
            result.Should().BeOfType<PingOptions>();
            result.Should().BeEquivalentTo(expected);
            result.Ttl.Should().Be(1);
        }
        [Fact]
        public void NetworkService_MostRecentPings_ReturnObject()
        {
            // Arrange
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            // Act
            var result = _pingService.MostRecentPings();

            // Assert
            result.Should().BeOfType <PingOptions[]>();
            result.Should().ContainEquivalentOf(expected);
            result.Should().Contain(x=>x.DontFragment == true);
        }
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            // Arrange
            var pingService = new NetworkService(_dNS);

            // Act
            var result = pingService.PingTimeout(a, b);

            // Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }
    }
}
