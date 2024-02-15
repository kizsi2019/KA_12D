using FluentAssertions.Extensions;
using FluentAssertions;
using NetworkUtility.Ping;
using System.Net.NetworkInformation;
using FakeItEasy;
using NetworkUtility.Tests.DNS;

namespace NetworkUtility.Tests.PingTests
{
    public class NetworkServiceTests
    {

        private readonly NetworkService _pingService;
        private readonly IDNS _dNs;

        public NetworkServiceTests()
        {
            // Dependencies
            _dNs = A.Fake<IDNS>();

            // SUT
            _pingService = new NetworkService(_dNs); 
        }
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            // Arrange - variables, classe, mocks
            A.CallTo(() => _dNs.sendDNS()).Returns(true); 


            // Act
            var result = _pingService.SendPing();

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
            var _pingService = new NetworkService(_dNs);

            // Act
            var result = _pingService.PingTimeout(a, b);

            // Assert
            result.Should().Be(expected);
            result.Should().BeGreaterThanOrEqualTo(2);
        }
        [Fact]
        public void NetworkService_LastPingDate_ReturnDate()
        {
            // Arrange

            // Act
            var result = _pingService.LastPingDate();
            // Assert
            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));
        }
        [Fact]
        public void NetworkService_GetPingOptions_ReturnsObject()
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
        public void NetworkService_MostRecentPings_ReturnsObject()
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
            result.Should().BeOfType<PingOptions[]> ();
            result.Should().ContainEquivalentOf(expected);
            result.Should().Contain(x => x.DontFragment == true); 
        }
    }
}