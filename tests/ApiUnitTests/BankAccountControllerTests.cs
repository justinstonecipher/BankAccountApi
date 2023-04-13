
using Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging;

namespace ApiUnitTests;

[TestClass]
public class BankAccountControllerTests
{
    [TestMethod]
    public void TestGet_Test()
    {
        // Arrange
        ILogger<BankAccountController> logger = NullLoggerFactory.Instance.CreateLogger<BankAccountController>();
        var bankAccountController = new BankAccountController(logger);

        // Act
        var result = bankAccountController.TestGet() as OkResult;

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(200, result.StatusCode);
    }
}