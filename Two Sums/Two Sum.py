def twoSum(nums: list[int], target: int) -> list[int]:
    indexValueDict = {}
    for i in range(len(nums)):
        if((target - nums[i]) in indexValueDict):
            return [i, indexValueDict[target - nums[i]]]
        indexValueDict[nums[i]] = i
        
print(twoSum(nums=[2,5,6,7], target=13))
        
        
        
        
 