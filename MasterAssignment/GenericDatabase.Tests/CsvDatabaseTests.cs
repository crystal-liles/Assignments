using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace GenericDatabase.Tests
{
    [TestClass]
    public class CsvDatabaseTests
    {
        [TestMethod] public void CsvDatabaseInitializesCorrectly()
        {
            // Assign
            var FilePathTestValue = "TestingWithBogusFileName";
            // Act
            var csvDatabase = new CsvDatabase
            {
                FilePath = FilePathTestValue
            };
            // Assert
            csvDatabase.ShouldBeOfType<CsvDatabase>();
            csvDatabase.FilePath.ShouldBe(FilePathTestValue);
            csvDatabase.Success.ShouldBeFalse();
            csvDatabase.FailureMessage.ShouldBeNull();
            csvDatabase.DatabaseHeader.ShouldBeNull();
            csvDatabase.DatabaseRows.ShouldBeNull(); // not initialized until LoadDatabaseTable method
        }

        [TestMethod]
        public void CsvDatabaseLoadsTableAndParsesProperly()
        {
            // no tests performed today. In a production scenario,
        }
    }
}
