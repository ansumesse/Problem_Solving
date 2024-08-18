namespace Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 1, 2 };
            Console.WriteLine(RemoveDuplicates(nums));
        }
        public static int RemoveDuplicates(int[] nums)
        {
            int size = 0;
            int current = int.MinValue;
            foreach (var item in nums)
            {
                if(current != item)
                {
                    size++;
                    nums[size - 1] = item;
                    current = item;
                }
            }
            return size;
        }
    }
}
