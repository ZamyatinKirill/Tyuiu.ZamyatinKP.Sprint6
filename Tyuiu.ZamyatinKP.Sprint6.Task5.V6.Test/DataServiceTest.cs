using Tyuiu.ZamyatinKP.Sprint6.Task5.V6.Lib;

namespace Tyuiu.ZamyatinKP.Sprint6.Task5.V6.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void Test1()
        {
            var result = new DataService();
            Assert.True(new FileInfo($@"{Path.GetTempPath()}\OutPutFileTask3.bin").Exists);
        }
    }
}