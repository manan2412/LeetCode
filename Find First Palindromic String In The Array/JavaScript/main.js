words = ["abc", "car", "ada", "racecar", "cool"]

for (let word of words) {
    console.log(word)
    let wordLenth = word.length;
    let isPalin = true
    for (let i = 0; i < wordLenth / 2; i++) {
        if (word[i] !== word[wordLenth - i - 1]) {
            isPalin = false;
            break;
        }

    }
    if (isPalin) {


        console.log(word);
        break;
    }
}
console.log("")
