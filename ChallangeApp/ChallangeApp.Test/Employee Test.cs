
namespace ChallangeApp.Test
{
    public class Tests
    {
        [Test]
        public void CheckAddScoreSumOperation()
        {
            // arrange
            var Employee = new Employee("Zenek", "Len", 32);
            // 
            Employee.AddGrands(9); //10
            Employee.AddGrands(5); //5
            Employee.AddGrands(2); //1
            Employee.AddGrands(1); //0
            Employee.AddGrands(9); //10
            Employee.AddGrands(2); //1
            Employee.AddGrands(1); //0
            Employee.AddGrands(10); //11

            // act
            var result = Employee.Result;

            // assert
            Assert.AreEqual(38, result);
        }
    }
}