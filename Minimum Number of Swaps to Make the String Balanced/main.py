
# s = "][]["
# s = "]]][[["
# s = "[]"
s = ""




def minSwaps(s: str) -> int:

    counter = 0
    for i in s:
        if (i == "["):
            counter += 1
        else:
            if counter > 0:
                counter-= 1
    return (counter + 1)//2
    
print(minSwaps(s))