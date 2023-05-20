
namespace LeetCode.Solutions
{
    public class _15_3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums) {

        var result = new List<IList<int>>();

        if(nums == null || nums.Length < 3) return result;

        Array.Sort(nums);

        for(int i = 0; i < nums.Length - 2; i ++)
        {
            //Skip duplicates for first element
            if(i > 0 && nums[i] == nums[i - 1]) continue;

            int left = i + 1;
            int right = nums.Length - 1;

            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if(sum == 0){
                    result.Add(new List<int> {nums[i], nums[left], nums[right]});
        
                // Skip duplicates for second element
                while(left < right && nums[left] == nums[left + 1]) left ++;
                // Skip duplicates for third element
                while (left < right && nums[right] == nums[right - 1]) right--;

                left ++;
                right--;
                } else if(sum < 0){left++;}
                else{right--;}
                }
            }

        return result;
    }
        
    }
}