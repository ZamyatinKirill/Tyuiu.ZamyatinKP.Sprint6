using Tyuiu.ZamyatinKP.Sprint6.Task3.V25.Lib;

namespace Tyuiu.ZamyatinKP.Sprint6.Task3.V25.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = new DataService();
            int[,] intsResult = { { -14, 17, -19, 3, 2 }, { -4, -14, -19, -9, -1 }, { 1, 0, 13, 14, 8 }, { 13, 7, 8, -3, -15 }, { 2, -20, 12, -14, 4 } };
            Assert.Equal(result.Calculate(intsResult), result.Calculate(intsResult));
        }
    }
}