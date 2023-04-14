namespace CalcolatriceTests
{
    [TestClass]
    public class CalcolatriceTest
    {
        [TestMethod]
        public void CalcolatriceTestAdd()
        {
            //arrange
            int[] addendi = {4, 5, 6};
            int expected = 15;

            //act
            SommaAlgebrica sum = new SommaAlgebrica();
            int res = sum.Add(addendi);

            //assert
            Assert.IsTrue(res == expected);
            //Assert.ThrowsException(ArgumentNullException);
        }
    }
}