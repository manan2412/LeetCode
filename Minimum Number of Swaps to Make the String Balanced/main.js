/**
 * @param {string} s 
 * @return {number}
 */

var minSwaps = function(s){
    let counter = 0;
    for(let i of s){
        if(i==="["){
            counter++;
        }
        else{
            if(counter>0){
                counter--;
            }
        }
    }
    return Math.floor((counter+1)/2);
}



// s = "][]["
// s = "]]][[["
// s = "[]"
s = ""
console.log(minSwaps(s));