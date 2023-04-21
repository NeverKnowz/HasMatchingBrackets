let testCases = ["<>", "><", "<<>", "\"\"", "<abc...xyz>"]
testCases.forEach(test => {
    result = hasMatchingBrackets(test)
    console.log(`${test}:${result}`)
});

function hasMatchingBrackets(input) {
    let brackets = [];

    //Javascript is annoying about turning strings into char arrays.
    let chars = Object.assign([], input)

    chars.forEach(c => {

        if (c === '<') {
            brackets.push(c);
        } else if (c === '>') {
            if (brackets.length === 0 || brackets[brackets.length - 1] !== '<') {
                return false;
            }

            brackets.pop();
        }
    });

    return brackets.length === 0;
}