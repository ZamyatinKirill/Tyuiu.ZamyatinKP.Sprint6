using Tyuiu.ZamyatinKP.Sprint6.Task1.V21.Lib;

namespace Tyuiu.ZamyatinKP.Sprint6.Task1.V21.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = new DataService();
            Assert.Equal([59.49, 38.47, -2.81, -19.67, -8.42, 0.57, -6.30, -20.14, -3.51, 38.13, 59.60], result.GetMassFunction(-5, 5));
        }
    }
}