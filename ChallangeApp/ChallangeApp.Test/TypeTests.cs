using System.Runtime.CompilerServices;

namespace ChallangeApp.Test
{
    public class TypeTests
    { 

         [Test]
        public void TEST()
    {
            // arrange
            string number1 = 1;
            string number2 = 2;
        
            // act

            // assert
            Assert.AreEqual(number1, number2);
    }



    [Test]
        public void TEST2()
        {
            // arrange
            var user1 = GetUser("Boncer");
            var user2 = GetUser("Boncer");
           

            // act
      
            // assert
            Assert.AreNotEqual(user1, user2);
        }

        private User GetUser(string name)
        {
            return new User(name);
        }
    }
}
