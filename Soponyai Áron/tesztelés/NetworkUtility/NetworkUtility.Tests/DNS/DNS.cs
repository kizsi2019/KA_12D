using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkUtility.Ping;
using Xunit;
using FluentAssertions;
using FluentAssertions.Extensions;

namespace DNS
{
    public interface IDNS
    {
        bool SendDns();
    }
}
