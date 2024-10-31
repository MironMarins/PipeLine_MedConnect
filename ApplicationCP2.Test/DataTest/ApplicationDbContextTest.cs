using Microsoft.EntityFrameworkCore;
using ApplicationCP2.Models;
using Xunit; // Assuming you're using xUnit

namespace ApplicationCP2.Data.Tests
{
    public class ApplicationDbContextTests
    {
        [Fact]
        public void Can_Create_DbContext()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;


            // Act
            var context = new ApplicationDbContext(options);

            // Assert
            Assert.NotNull(context);
        }

        [Fact]
        public void Has_Expected_DbSets()
        {
            // Arrange
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase(databaseName: "TestDatabase")
                .Options;


            // Act
            var context = new ApplicationDbContext(options);

            // Assert
            Assert.NotNull(context.Cliente);
            Assert.NotNull(context.Produto);
            Assert.NotNull(context.Loja);
        }
    }
}