public class Solution
{
    static void Main(string[] args)
    {
        int MinSwaps(string s)
        {
            int counter = 0;
            foreach (char c in s)
            {
                if (c == '[')
                {
                    counter++;
                }
                else
                {
                    if (counter > 0)
                    {
                        counter--;
                    }

                }
            }
            return counter / 2 + counter % 2;
        }
        //string s = "][][";
        //string s = "]]][[[";
        //string s = "[]";
        string s = "";

        Console.WriteLine(MinSwaps(s));
    }    
}
