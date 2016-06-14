Programming in HTML 5 with Javascript and CSS3
===================
[TOC]

Module 3
-------------


In this module, we are going to dive deep into the syntax properties of Javascript language. It will be a quick overview. For the next step we'll look at the functionalities at your disposal to manipulate **DOM** (Document Object Model). Last but not least, we'll have a quick look on JQuery library.

----------


###Syntax
####Statements

A computer program is a list of instructions to be executed by computer. These instructions are called statements in programming languages context. 

In JS each statement is separated with a **semicolon (;)**. Statements are composed of values, operators, expressions, keywords and comments.
####Values
There are two different type of values : *fixed(literals)* and *variable(variables)*.

>Literal examples

> - 200.1
> - 	1453
> - 	“BEM” - ‘BEM’

#####Variables
They are containers for storing data. 

>Has to be identified with unique names :

> - May contain letters, digits, underscores and dollar sign.
> - Must begin with a letter.
> - Names are case-sensitive.
> - Keywords cannot be used as names

```
var x = 5;
var y = 3;
var z = x * y;
alert(z);
```
JS has dynamic data types which means same variable can be used as different types.

```
var length = 16;  // Number - integer
var money = 200.2 // Number - float
var speedOfLight = 3e8;// Number - scientific
var lastName = "KARADAYI"; // String
var flag = true; // Boolean
var cars = ["Mercedes", "Toyota", "BMW"]; // Array
var person = {firstName:"Mehmet Sencer",lastName:"Karadayi"};   // Object
var func = function (){}; // Function
```

> **String special chars**

> - **\n** - Newline
> - **\t** - Tab
> - **\’** - Single quote
> - **\”** - Double quote
> - **\\** **\\** - Backslash
> - **\u** - Unicode char e.g \u0040

*typeof()* function is used to get type of a variable : 
```
var a = false;
typeof(a); // “boolean”
```
In JS, a variable without a value has the value and the type of **undefined**. The keyword **null** can be used to assign the value undefined to a variable.

> Important Note : 

> The data type of null is *“object” *

Therefore;
```
typeof undefined             // undefined
typeof null                  // object
null === undefined           // false
null == undefined            // true
```

####Operators
#####Arithmetic
Operator     | Desc
-------- | ---
+  | Addition
-   | Subtraction
*   | Multiplication
/   | Division
% | Modulus
++ | Increment
-- | Decrement

> **Note :**

> In string type **+** operator acts as a concatenation operator.

```
var firstName = “Mehmet”, lastName = “KARADAYI”;
var fullName = firstName + “ ” + lastName // Mehmet KARADAYI

var s1 = 3 + 5 + ”Sample”; // 8Sample
var s2 = ”Sample” + 3 + 5; // Sample35
```

#####Assignment

Operator     | Example | Same as
-------- | ------- | -------
= | x=y | x=y
+= | x+=y | x = x+y
-= | x-=y | x = x-y
*= | x*=y | x = x*y
/= | x/=y | x = x/y
%= | x%=y | x = x%y

#####Comparison
Operator     | Desc
-------- | ---
==  | equal to
===  | equal value and type
!=   | not equal to
!==  | not equal value or type
> | greater than
< | lesser than
\>= | greater than or equal to
<= | lesser than or equal to
? | ternary operator


#####Logical
Operator     | Desc | Example
-------- | --- | ----
&& | and | x<5 && y>2
\|\| | or | y == 5 \|\| y<0
! | not | !flag

#####Bitwise
Operator     | Desc | Example | Result
-------- | --- | ---- | ----
& | and | x = 5 & 1 | 1
\| | or | x = 5 \| 1 | 5
~ | not | x = ~5 | 10
^ | xor | x = 5 ^ 1 | 4
\>> | right shift | 5 >> 1 | 2
<< | left shift | 5 << 1 | 10

####Functions

Javascript function is a special code block to perform a particular set of actions. It is executed when something calls it.

```
function *name*(*param1*,*param2*,...){
	*code to be executed*
}
```
Example : 
```
function toCelsius(fahrenheit) {
    return (5/9) * (fahrenheit-32);
}
console.log(toCelsius(77));
```

####Events

Basically, they are **things** happened to an HTML object. With the use of JS, we might react to those changes.

> Some examples of HTML events might be

> - Web page loaded
> - Input has changed
> - Button clicked etc

```
<button onclick=”console.log(“button_clicked()”);” >Click me!</button>
```
Event | Desc
------| -------
onchange | Html element changed
onclick | Html element clicked
onmouseover | User moves mouse over the element
onmouseout | User moves mouse away from the element
onkeydown | User pushes a keyboard key
onload | Browser finished loading the page


#### String and Number methods

```
var str = “I am learning JS”;
var l = str.length; // l = 16
console.log(str.indexOf(“JS”)); // 14, -1 if not found
console.log(str.search(“JS”)); // 14, -1 if not found
console.log(str.slice(7,13)); // “arning”
console.log(str.substring(7,13)); // “arning”
console.log(str.substr(7, 6); // “arning”
console.log(str.slice(-12,-6)); // “ learn”
console.log(str.replace(/JS/g,"JavaScript")); // I am learning JavaScript
console.log(str.toUpperCase()); // I AM LEARNING JS
console.log(str.concat(“ and ”,”HTML5”)); // I am learning JS and HTML5
console.log(str.split(“ ”)); // [“I”,”am”,”learning”,”JS”]
```


```
var x = 12345.9443;
x.toString(); // “12345.9443”
x.toFixed(2); // “12345.94”
x.toPrecision(2); // 1.2e+4
parseInt("10"); // 10
parseInt("10.33"); // 10
parseInt("10 20 30"); // 10
parseInt("10 years"); // 10
parseInt("years 10"); // NaN 
parseFloat("10.33"); // 10.33
```

####Math functions

The math object allows you to perform mathematical operations on numbers.
 
```
Math.random();       // returns a random number
Math.min(0,-90,100,2); // -90
Math.max(0,-90,100,2); // 100
Math.ceil(4.7); // 5
Math.floor(4.7); // 4
```
