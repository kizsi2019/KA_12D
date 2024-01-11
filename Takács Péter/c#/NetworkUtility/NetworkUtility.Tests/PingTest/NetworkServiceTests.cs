using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using NetworkUtility.Ping;

namespace NetworkUtility.Tests.PingTest
{
    public class NetworkServiceTests
    {
        [Fact]
        public void NetworkService_SendPing_ReturnString()
        {
            //Arrange
            var pingService = new NetworkService();
            //ACT
            var result = pingService.SendPing();
            //Assert
            result.Should().Be("Succes: Ping sent!");
            result.Should().BeGreaterThanOrEqualTo(2);  
            result.Should().NotBeInRange(-1000, 0);
        }
    }
}
