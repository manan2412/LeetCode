words = ["bc", "car", "ada", "racecar", "cool"]

# for word in words:
#     isPalin = True
#     i = 0
#     wordLenth = word.__len__()
#     # print(word)
#     # print(wordLenth)
#     while i < wordLenth//2:
#         if (word[i] != word[wordLenth-i-1]):
#             isPalin = False
#             break

#         i += 1
#     if (isPalin):
#         print(word)
#         break

for word in words: 
    if word == word[::-1]:
        print(word)
        break

    print("")