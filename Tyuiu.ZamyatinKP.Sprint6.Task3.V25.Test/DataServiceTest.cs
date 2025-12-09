using Tyuiu.ZamyatinKP.Sprint6.Task3.V25.Lib;

namespace Tyuiu.ZamyatinKP.Sprint6.Task3.V25.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = new DataService();
            int[,] intsResult = { { 14, 5, -14, 18, 21 }, { -5, -12, -12, 4, 28 }, { 27, -2, -9, 23, 27 }, { -19, -15, 6, 15, 1 }, { 33, 2, 17, 24, 24 } };
            Assert.Equal(result.Calculate(intsResult), result.Calculate(intsResult));
        }
    }
}