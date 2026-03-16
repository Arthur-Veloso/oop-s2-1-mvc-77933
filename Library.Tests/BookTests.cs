using Library.domain.Models;
using Xunit;

namespace Library.Tests
{
    public class BookTests
    {
        [Fact]
        public void Book_Should_Be_Available_When_Created()
        {
            var book = new Book
            {
                Title = "Test Book",
                Author = "Author",
                IsAvailable = true
            };

            Assert.True(book.IsAvailable);
        }
    }
}
