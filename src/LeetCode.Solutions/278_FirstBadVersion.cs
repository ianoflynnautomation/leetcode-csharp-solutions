
namespace LeetCode.Solutions;

/* The isBadVersion API is defined in the parent class VersionControl.
bool IsBadVersion(int version); */

/// <summary>
/// 278. First Bad Version
/// https://leetcode.com/problems/first-bad-version/
/// 
/// You are a product manager and currently leading a team to develop a new product. 
/// Unfortunately, the latest version of your product fails the quality check. 
/// Since each version is developed based on the previous version, all the versions after a bad version are also bad.
/// Suppose you have n versions [1, 2, ..., n] and you want to find out the first bad one, 
/// which causes all the following ones to be bad.
/// You are given an API bool isBadVersion(version) which returns whether version is bad. 
/// Implement a function to find the first bad version. You should minimize the number of calls to the API.
/// </summary>

[Companies(Company.Amazon, Company.Adobe, Company.Microsoft)]
[Level(Level.Easy)]
public class _278_FirstBadVersion : VersionControl
{
    public int FirstBadVersion(int n)
    {

        int left = 1;
        int right = n;

        while (left < right)
        {
            int mid = left + (right - left) / 2;
            if (IsBadVersion(mid))
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }
        }
        return left;
    }
}

public class VersionControl
{
    public bool IsBadVersion(int version)
    {
        return version > 3;
    }
}
;