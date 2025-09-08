
let numbers: number[] = [10, 20, 30, 40, 50];
console.log("Numbers Array:", numbers);

numbers.push(60);
console.log("After Push:", numbers);

numbers.pop();
console.log("After Pop:", numbers);


numbers.forEach((num, index) => {
    console.log(`Index ${index} -> Value ${num}`);
});


let fruits: string[] = ["Apple", "Banana", "Mango"];
fruits.forEach(fruit => console.log("Fruit:", fruit));


let mixedArray: any[] = [1, "Two", true, 4.5];
console.log("Mixed Array:", mixedArray);
