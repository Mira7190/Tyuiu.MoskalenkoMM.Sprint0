using Tyuiu.MoskalenkoMM.Sprint0.Task2.V0.Lib;
namespace Tyuiu.MoskalenkoMM.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataserviceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Игорь";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Игорь", res);
        }
    }
}
