//console.log("Hello World!");
//alert("Hello Word");
//console.error("This is an error");

//Variables in JS
//Var, let, const
//Data Types, we have primitive data types, which means they are directly assigned to memory.
//we have: String, Numbers, Boolean, null, undefined, symbol
//String => const name = "John";
//numbers => const age = 30;
//numbers => const rating = 4.5;
//boolean => const isCool = true;
//null => const x = null;
//undefined => const y = undefined; or let z;
//To test the type of the variable 
//console.log(typeof name);

//concatenation
//console.log("My name is "+ name + " and i am " + age);
//Template String
//const hello = `My name is ${name} and i am ${age}`;
//console.log(hello)
//methods in string
//const s = "Hello World";
//console.log(s.length);
//console.log(s.toUpperCase());
//console.log(s.toLowerCase());
//console.log(s.substring(0, 5));
//console.log(s.split);


//Arrays

//const fruits = ["apples, oranges, pears"];
//fruits[3] = "grapes";

//To push to an array add to the back.
//fruits.push("mangos");
//To add to the front.
//fruits.unshift("strawberries");
//To remove from an array.
//fruits.pop();
//To know if an array is present.
//console.log(Array.isArray(fruits));
//To know the index of an array
//console.log(fruits.indexOf("pears"))
//console.log(fruits);


//Object Literals, they are basically key value pears
// const person ={
//     firstName: "John",
//     lastName: "Doe",
//     age: "30",
//     hobbies: ["music", "movies", "sport"],
//     address:  {
//         street: "50 main street",
//         city: "Boston",
//         state:"MA"
//     }
// }

// console.log(person.address.street);
// console.log(person.firstName , person.lastName);
//object array
//console.log(person.hobbies[1]);

//add to an object.
// person.email = "john@gmail.com";
// console.log(person);
//arrays of object
// const todos = [
//     {
//         id:1,
//         text: "Take out the Trash",
//         isCompleted: true
//     },
//     {
//         id:2,
//         text: "Meeting with the boss",
//         isCompleted: true
//     },
//     {
//         id:3,
//         text: "Dentist appointment",
//         isCompleted: false
//     }
// ];
// console.log(todos);
// console.log(todos[1].text);

//Json: it is a data format and its used in fullstark development, when deeling with API's like sending data to a server.

//How to send Data to a server
// const todoJSON = JSON.stringify(todos);
// console.log(todoJSON);


//For loop
// for(let i = 0; i < 10; i++){
//     console.log(i);
// }
// console.log("********************************")
// for(let i = 0; i <= 10; i++){
//     console.log("Number " + i);
// }

// for(let i = 0; i < todos.length; i++){
//     console.log(todos[i].text);
// }

//foreach
// for(let todo of todos){
//     todo.text;
// }

//while loop
//  let i = 0;
//  while(i < 10){
//      console.log(`While loop number: ${i}`)
//      i++
// }

//forEach
// todos.forEach(function(todo){
//     console.log(todo.text);
// });

//map
// const todoText = todos.map(function(todo){
//     return todo.text;
// });

//console.log(todoText);

//filter
// const todoCompleted = todos.filter(function(todo){
//     return todo.isCompleted === true;
// }).map(function(todo){
//     return todo.text;
// })

// console.log(todoCompleted);



//if and else
// const x = 10;
//  if(x == 10){
//      console.log("x is 10");
//  }else{
//      console.log("x is not 10");
//  }
//And && means if all conditions are meant, Or || means if one of the conditions are meant.

//const color = x > 10 ? "red" : "blue";
//console.log(color);

// switch(color){ 
//     case "red":
//         console.log("color is red");
//         break;
//     case "blue":
//         console.log("color is blue");
//         break;    
//     default:
//         console.log("color not found");
//         break;    
// }

// function addNums(num1, num2){
//     return num1 + num2;
// }

// console.log(addNums(5, 4));
// you can pass somthing inside the default values i.e: num1=1 asnd num2=1 in other to prevent NaN but note, the value in the function will overide it.

//Arrow Function
// const addNums = (num1, num2) => {
//     return num1 + num2;
// }

// console.log(addNums(5, 4));

//Constructor function

// function person(firstName, secondName, dob){
//     this.firstName = firstName;
//     this.secondName = secondName;
//     this.dob = new Date(dob);
    //You can also put a function in a constructor
    // this.getBirthYear = function(){
    //     return this.dob.getFullYear();
    // }
    // this.getFullName = function(){
    //     return `${this.firstName} ${this.secondName}`;
    // }
//}
//Add prototype
// person.prototype.getBirthYear = function(){
//     return this.dob.getFullYear();
// }

// person.prototype.getFullName = function(){
//     return `${this.firstName} ${this.secondName}`
// }


//Class 
// class person{
//     constructor(firstName, secondName, dob){
//         this.firstName = firstName;
//         this.secondName = secondName;
//         this.dob = new Date(dob);
//     }

//     getBirthYear(){
//         return this.dob.getFullYear();
//     }
//     getFullName(){
//         return `${this.firstName} ${this.secondName}`;
//     }
// }


// Instantiate object
// const person1 = new person("John", "Doe", "3-12-1990");
// const person2 = new person("Mary", "Scammer", "4-9-1994");

//console.log(person1.dob.getFullYear());
// console.log(person1.getBirthYear());
// console.log(person1.getFullName());

//DOM: a dom is basically and document object model
//we have several types of selectors in JS, we have: Single Element and Multiple Element
//Single Element
//Array single element
// const items = document.querySelectorAll(".item");
// items.forEach((item) => console.log(item));

// const ul = document.querySelector(".items");

//ul.remove();
//ul.lastElementChild.remove();
// ul.firstElementChild.textContent = "Hello";
// ul.children[1].innerHTML = "Brad";
// ul.lastElementChild.innerHTML = "Mary"

//const btn = document.querySelector(".btn");
// btn.style.background = "red"

// btn.addEventListener("click", (e) =>{
//     e.preventDefault();
//     console.log("click");
// });

// Put DOM elements into variables
const myForm = document.querySelector('#my-form');
const nameInput = document.querySelector('#name');
const emailInput = document.querySelector('#email');
const msg = document.querySelector('.msg');
const userList = document.querySelector('#users');

// Listen for form submit
myForm.addEventListener('submit', onSubmit);

function onSubmit(e) {
  e.preventDefault();
  
  if(nameInput.value === '' || emailInput.value === '') {
    // alert('Please enter all fields');
    msg.classList.add('error');
    msg.innerHTML = 'Please enter all fields';

    // Remove error after 3 seconds
    setTimeout(() => msg.remove(), 3000);
  } else {
    // Create new list item with user
    const li = document.createElement('li');

    // Add text node with input values
    li.appendChild(document.createTextNode(`${nameInput.value}: ${emailInput.value}`));

    // Add HTML
    // li.innerHTML = `<strong>${nameInput.value}</strong>e: ${emailInput.value}`;

    // Append to ul
    userList.appendChild(li);

    // Clear fields
    nameInput.value = '';
    emailInput.value = '';
  }
}