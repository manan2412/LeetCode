/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */

var twoSum = function(nums, target) {
    const numLength = nums.length
    let indexValueDict = {}
    for (let i = 0; i < numLength; i++){
        let complement = target - nums[i]
        if(complement in indexValueDict)
            return [i, indexValueDict[complement]]
        indexValueDict[nums[i]] = i
    }      
};

console.log(twoSum(nums = [3,5,9,7], target = 16))