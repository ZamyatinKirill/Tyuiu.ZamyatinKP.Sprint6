using Tyuiu.ZamyatinKP.Sprint6.Task4.V23.Lib;

namespace Tyuiu.ZamyatinKP.Sprint6.Task4.V23.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = new DataService();
            Assert.Equal([13.81, 11.87, 9.87, 7.74, 5.36, 2.5, 0.0, 0.79, -1.75, -3.78, -5.71], result.GetMassFunction(-5, 5));
        }
    }
}