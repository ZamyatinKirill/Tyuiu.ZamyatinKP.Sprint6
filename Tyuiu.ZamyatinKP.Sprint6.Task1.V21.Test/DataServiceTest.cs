using Tyuiu.ZamyatinKP.Sprint6.Task1.V21.Lib;

namespace Tyuiu.ZamyatinKP.Sprint6.Task1.V21.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = new DataService();
            Assert.Equal([20.36, 15.42, 10.99, 7.43, 4.33, 1.0, 0.0, -8.87, -13.03, -16.53, -19.6], result.GetMassFunction(-5, 5));
        }
    }
}