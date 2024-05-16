public class TwoSums
{
    public static void Main()
    {
        int[] inputnums = { 3,2, 1, 4 };
        int[] answer = TwoSum(inputnums, 6);

        for(int i = 0;  i < answer.Length; i++)
        {
            Console.WriteLine(answer[i]);
        }

       
        Console.ReadLine();
    }
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> valueIndexDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            

            if (valueIndexDict.ContainsKey(complement))
            {
                int[] answerArray = { valueIndexDict.GetValueOrDefault(complement), i };
                return answerArray;
            }

            valueIndexDict.Add(nums[i], i);


        }
        return null;
    }
}