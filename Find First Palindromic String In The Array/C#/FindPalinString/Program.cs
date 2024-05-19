public class Solution
{
    public static void Main(string[] args)
    {
       
        //  words = ["notapalindrome","racecar"]
        // words = ["abc","car","ada","racecar","cool"]
        // words = ["def","ghi"]
         
        
        string[] words = {"bc", "car", "ada", "racecar", "cool"};
        foreach (string word in words)
        {
            bool isPalin = true;
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    isPalin = false;
                    break;
                }


            }
            if (isPalin)
            {
                Console.WriteLine(word);
                /*Environment.Exit(0);*/
            }
            
        } Console.WriteLine("");

    }
}
