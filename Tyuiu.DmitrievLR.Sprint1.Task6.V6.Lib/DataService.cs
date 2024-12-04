using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DmitrievLR.Sprint1.Task6.V6.Lib
{
    public class DataService : ISprint1Task6V6
    {
        public string DeleteFirstLetter(string value)
        {

            var modifiedWords = value.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                                      .Select(word => word.Length > 0 ? word.Substring(1) : word);

            return string.Join(" ", modifiedWords);
        }
    }
}
