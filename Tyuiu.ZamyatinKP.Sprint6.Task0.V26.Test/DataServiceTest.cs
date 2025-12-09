using Tyuiu.ZamyatinKP.Sprint6.Task0.V26.Lib;

namespace Tyuiu.ZamyatinKP.Sprint6.Task0.V26.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = new DataService();
            Assert.Equal(0.769, result.Calculate(3));
        }
    }
}