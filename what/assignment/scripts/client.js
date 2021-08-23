// write a function that takes an array and returns the sum of all positive numbers in the array

let array=[1,2,3,4,5,6,7,8,9];

function onlyOdds(array) {
    let result = [ ];
    for (let num of array) {
        if (num % 2 === 1) {
            result.push(num);
        }
    }
    return result;
}