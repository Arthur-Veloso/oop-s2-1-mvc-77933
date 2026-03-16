using Library.domain.Models;
using Xunit;

namespace Library.Tests
{
    public class LoanTests
    {
        [Fact]
        public void Loan_Should_Set_LoanDate()
        {
            var loan = new Loan
            {
                BookId = 1,
                MemberId = 1,
                DueDate = DateTime.Now.AddDays(7)
            };

            loan.LoanDate = DateTime.Now;

            Assert.True(loan.LoanDate <= DateTime.Now);
        }

        [Fact]
        public void Loan_Should_Start_With_No_ReturnedDate()
        {
            var loan = new Loan
            {
                BookId = 1,
                MemberId = 1,
                DueDate = DateTime.Now.AddDays(7)
            };

            Assert.Null(loan.ReturnedDate);
        }

        [Fact]
        public void Returning_Loan_Should_Set_ReturnedDate()
        {
            var loan = new Loan
            {
                BookId = 1,
                MemberId = 1,
                LoanDate = DateTime.Now
            };

            loan.ReturnedDate = DateTime.Now;

            Assert.NotNull(loan.ReturnedDate);
        }
    }
}
