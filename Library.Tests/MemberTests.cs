using Library.domain.Models;
using Xunit;

namespace Library.Tests
{
    public class MemberTests
    {
        [Fact]
        public void Member_Should_Have_Name()
        {
            var member = new Member
            {
                FullName = "John Smith",
                Email = "john@email.com"
            };

            Assert.Equal("John Smith", member.FullName);
        }
    }
}
