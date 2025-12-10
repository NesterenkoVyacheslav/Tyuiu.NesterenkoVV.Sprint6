using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.NesterenkoVV.Sprint6.Task6.V16.Lib
{
    public class DataService : ISprint6Task6V16
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";
            string str = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    str =str + line + " ";

                }
            }
            string[] s = str.Split(' ', '\n', '\t');
            for (int i = 0; i < s.Length; i++)
            {
                foreach (char c in s[i])
                {
                    if (c =='b')
                    {
                        resStr =resStr + " " + s[i];
                    }
                }
            }
            resStr = resStr.Trim();
            return resStr;
        }
    }
}
