using FluentAssertions;
using NetworkUtility.Ping;


namespace NetworkUtility.Tests.Ping_test
{
    public class NetworkServiceTests
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            var pingService = new NetworkService();

            var result = pingService.SendPing();

            result.Should().Be("Succes: Ping Sent!");
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Contain("Ping", Exactly.Once());
        }
        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2,2,4)]
        public void NetworkService_PingTimeout_ReturnIn(int a ,int b , int c , int expected)
        {
            var pingService = new NetworkService();
            var result = pingService.PingTimeout(a, b);
            
            result.Should().Be(expected);
            result.should().NeGreaterTheOrEqualTo(2);
            result.Should().NotBeInRange(-1000, 0);
        }
    }
}
