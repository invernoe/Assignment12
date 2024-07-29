using System.Collections;

namespace Assignment12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6 };
            MyReverse(list);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("======================");
            #endregion

            #region Question 2
            List<int> list2 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> list3 = OnlyEven(list2);
            foreach (var i in list3)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region Question 3
            FixedSizeList<int> fixedSizeList = new FixedSizeList<int>(4);
            fixedSizeList.Add(1);
            fixedSizeList.Add(2);
            fixedSizeList.Add(3);
            fixedSizeList.Add(4);
            //fixedSizeList.Add(5); // exception

            fixedSizeList.Get(3);
            //fixedSizeList.Get(4); // exception
            Console.WriteLine("======================");
            #endregion

            #region Question 4
            int res = NonRepeatingFirstCharIndex("Mahmoud Khaled");
            Console.WriteLine(res);
            #endregion
        }

        static void MyReverse(ArrayList list)
        {
            for (int i = 0; i < list.Count / 2; i++)
            {
                Object? temp = list[i];
                list[i] = list[list.Count - i - 1];
                list[list.Count - i - 1] = temp;
            }
        }

        static List<int> OnlyEven(List<int> list)
        {
            List<int> result = new List<int>();

            foreach (int i in list)
            {
                if (i % 2 == 0)
                    result.Add(i);
            }

            return result;
        }

        static int NonRepeatingFirstCharIndex(String s)
        {
            s = s.ToLower();
            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (dict.ContainsKey(c))
                {
                    dict[c]++;
                }
                else
                {
                    dict[c] = 1;
                }
            }

            // Find the first non-repeated character (Dictionaries maintain insertion order)
            for (int i = 0; i < s.Length; i++)
            {
                if (dict[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
