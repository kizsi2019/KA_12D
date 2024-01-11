namespace NetworkUtility.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Network_SendPing_ReturnString()
        {
            var pingService = new NetworkServiceTests();
            var result = pingService.SendPing();
            result.Should().Be("Succes! Ping Sent!");
            result.Should().NotBeNullOrWithSpace();
            result.Should().Contain("Ping", Exactly.Once());
        }
        [Theory]
        [InlineData[1,1,2]]
        [InlineData[2,2,4]]
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
