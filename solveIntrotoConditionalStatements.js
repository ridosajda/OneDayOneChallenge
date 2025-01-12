'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', function(inputStdin) {
    inputString += inputStdin;
});

process.stdin.on('end', function() {
    inputString = inputString.split('\n');

    main();
});

function readLine() {
    return inputString[currentLine++];
}

function solve(n) {
    if (n % 2 === 1) {
        console.log("Weird");
    } else if (n >= 2 && n <= 5) {
        console.log("Not Weird");
    } else if (n >= 6 && n <= 20) {
        console.log("Weird");
    } else if (n > 20) {
        console.log("Not Weird");
    }
}

function main() {
    const n = parseInt(readLine().trim(), 10);
    solve(n);
}
