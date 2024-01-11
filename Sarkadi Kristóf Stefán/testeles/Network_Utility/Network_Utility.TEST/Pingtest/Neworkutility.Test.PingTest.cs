using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertion;
using NetworkUtiliy.Ping;


namespace Network_Utility.TEST.Pingtest
{
    public class NetworkServiceTest
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange
            var pingService = new Network_Service();

            //Act
            var result = pingService.SendPing();

            //Asset
            result.Should().Be("Succes: Ping send!");
            result.Should().NotBeNullOrWhiteSpace();
            result.Should().Contain("Ping", Exactly.Once());
        }
        [Theory]
        [IntLineData(1; 1; 2)]
        [IntLineData(2; 2; 4)]
        public void NetworkService_PingTimeout_ReturnInt(int a, int b, int expected)
        {
            //Arrange
            var pingService = new NetworkServiceTest();

            //Act
            var result = pingService.PingTimeout(a, b, expected);

            //Assert
            result.Should().Be(expected);
            result.Should().NotBeNullOrWhiteSpace(2);
            result.Should().NotBeInRange(-1000, 0) ; 
        }
    }
}
