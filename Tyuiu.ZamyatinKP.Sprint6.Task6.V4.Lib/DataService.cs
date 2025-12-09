using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZamyatinKP.Sprint6.Task6.V4.Lib
{
    public class DataService : ISprint6Task6V4
    {
        public string CollectTextFromFile(string path)
        {
            string text = File.ReadAllText(path);
            var wordsWithN = text
            .Split(new char[] { ' ', '\n', '\r', '\t', ',', '.', '!', '?', ';', ':', '-', '(', ')', '[', ']', '{', '}' },
                   StringSplitOptions.RemoveEmptyEntries)
            .Where(word => word.Contains('n', StringComparison.OrdinalIgnoreCase));

            return string.Join(" ", wordsWithN);
        }
    }
}
