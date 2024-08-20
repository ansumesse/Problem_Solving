namespace Rotate_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2 };
            Rotate3(nums, 3);
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }
        }
        // time limited exceeded
        public void Rotate(int[] nums, int k)
        {
            for (int i = 0; i < k; i++)
            {
                int temp = nums[nums.Length - 1];
                for (int j = nums.Length - 2; j >= 0; j--)
                {
                    nums[j + 1] = nums[j];
                }
                nums[0] = temp;
            }

        }
        // time limited exceeded
        public static void Rotate2(int[] nums, int k)
        {
            LinkedList<int> numbers = new LinkedList<int>(nums);
            for (int i = 0; i < k; i++)
            {
                numbers.AddFirst(numbers.ElementAt(nums.Length - 1));
                numbers.RemoveLast();
                
            }
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = numbers.ElementAt(i);
            }
        }
        public static void Rotate3(int[] nums, int k)
        {
            if (k > nums.Length)
                k = 1;
            int[] numbersk = new int[k];
            var numk = nums.Skip(nums.Length - k);
            var numAfterk = nums.Take(nums.Length - k);
            var arr = numk.Concat(numAfterk).ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = arr[i];
            }


        }
    }
}
