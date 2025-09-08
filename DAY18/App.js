// Import lodash package
const _ = require("lodash");

// Example array
let numbers = [1, 2, 3, 4, 5];

// Use lodash to reverse the array
let reversed = _.reverse([...numbers]);
console.log("Original Array:", numbers);
console.log("Reversed Array using lodash:", reversed);

// Simple Node.js functionality
const fs = require("fs");

// Create a file
fs.writeFileSync("sample.txt", "Hello Node.js & NPM!");
console.log("sample.txt file created successfully!");

// Read the file
let data = fs.readFileSync("sample.txt", "utf-8");
console.log("File Content:", data);
