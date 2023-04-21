namespace CalcolatriceTests
{
    [TestClass]
    public class CalcolatriceTest
    {
        [TestMethod]
        [DataRow(new [] {4,1,3}, 8)]
        [DataRow(new[] { 4, 1, 3 }, 8)]
        [DataRow(new[] { 4, 1, 3 }, 8)]
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