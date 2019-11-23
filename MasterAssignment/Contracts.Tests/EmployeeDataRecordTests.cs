using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shouldly;

namespace Contracts.Tests
{
    [TestClass]
    public class EmployeeDataRecordTests
    {
        [TestMethod]
        public void EmployeeDataRecordTest()
        {
            //Assert.Fail();

            var employeeDataRecord = new EmployeeDataRecord()
            {
                ID = 101,
                FName = "Prof",
                MName = "E",
                LName = "Reynolds",
                Address = "College Park Drive",
                City = "Conroe",
                State = "TX",
                ZipCode = "77304"

            };

            employeeDataRecord.ShouldBeOfType<EmployeeDataRecord>();

            employeeDataRecord.ID.ShouldBe(101);

            employeeDataRecord.LName.ShouldBe("Reynolds");
        }
    }
}
