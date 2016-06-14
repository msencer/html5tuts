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

#### <i class="icon-file"></i> Create a document

The document panel is accessible using the <i class="icon-folder-open"></i> button in the navigation bar. You can create a new document by clicking <i class="icon-file"></i> **New document** in the document panel.

#### <i class="icon-folder-open"></i> Switch to another document

All your local documents are listed in the document panel. You can switch from one to another by clicking a document in the list or you can toggle documents using <kbd>Ctrl+[</kbd> and <kbd>Ctrl+]</kbd>.

#### <i class="icon-pencil"></i> Rename a document

You can rename the current document by clicking the document title in the navigation bar.

#### <i class="icon-trash"></i> Delete a document

You can delete the current document by clicking <i class="icon-trash"></i> **Delete document** in the document panel.

#### <i class="icon-hdd"></i> Export a document

You can save the current document to a file by clicking <i class="icon-hdd"></i> **Export to disk** from the <i class="icon-provider-stackedit"></i> menu panel.

> **Tip:** Check out the [<i class="icon-upload"></i> Publish a document](#publish-a-document) section for a description of the different output formats.


----------


Synchronization
-------------------

StackEdit can be combined with <i class="icon-provider-gdrive"></i> **Google Drive** and <i class="icon-provider-dropbox"></i> **Dropbox** to have your documents saved in the *Cloud*. The synchronization mechanism takes care of uploading your modifications or downloading the latest version of your documents.

> **Note:**

> - Full access to **Google Drive** or **Dropbox** is required to be able to import any document in StackEdit. Permission restrictions can be configured in the settings.
> - Imported documents are downloaded in your browser and are not transmitted to a server.
> - If you experience problems saving your documents on Google Drive, check and optionally disable browser extensions, such as Disconnect.

#### <i class="icon-refresh"></i> Open a document

You can open a document from <i class="icon-provider-gdrive"></i> **Google Drive** or the <i class="icon-provider-dropbox"></i> **Dropbox** by opening the <i class="icon-refresh"></i> **Synchronize** sub-menu and by clicking **Open from...**. Once opened, any modification in your document will be automatically synchronized with the file in your **Google Drive** / **Dropbox** account.

#### <i class="icon-refresh"></i> Save a document

You can save any document by opening the <i class="icon-refresh"></i> **Synchronize** sub-menu and by clicking **Save on...**. Even if your document is already synchronized with **Google Drive** or **Dropbox**, you can export it to a another location. StackEdit can synchronize one document with multiple locations and accounts.

#### <i class="icon-refresh"></i> Synchronize a document

Once your document is linked to a <i class="icon-provider-gdrive"></i> **Google Drive** or a <i class="icon-provider-dropbox"></i> **Dropbox** file, StackEdit will periodically (every 3 minutes) synchronize it by downloading/uploading any modification. A merge will be performed if necessary and conflicts will be detected.

If you just have modified your document and you want to force the synchronization, click the <i class="icon-refresh"></i> button in the navigation bar.

> **Note:** The <i class="icon-refresh"></i> button is disabled when you have no document to synchronize.

#### <i class="icon-refresh"></i> Manage document synchronization

Since one document can be synchronized with multiple locations, you can list and manage synchronized locations by clicking <i class="icon-refresh"></i> **Manage synchronization** in the <i class="icon-refresh"></i> **Synchronize** sub-menu. This will let you remove synchronization locations that are associated to your document.

> **Note:** If you delete the file from **Google Drive** or from **Dropbox**, the document will no longer be synchronized with that location.

----------


Publication
-------------

Once you are happy with your document, you can publish it on different websites directly from StackEdit. As for now, StackEdit can publish on **Blogger**, **Dropbox**, **Gist**, **GitHub**, **Google Drive**, **Tumblr**, **WordPress** and on any SSH server.

#### <i class="icon-upload"></i> Publish a document

You can publish your document by opening the <i class="icon-upload"></i> **Publish** sub-menu and by choosing a website. In the dialog box, you can choose the publication format:

- Markdown, to publish the Markdown text on a website that can interpret it (**GitHub** for instance),
- HTML, to publish the document converted into HTML (on a blog for example),
- Template, to have a full control of the output.

> **Note:** The default template is a simple webpage wrapping your document in HTML format. You can customize it in the **Advanced** tab of the <i class="icon-cog"></i> **Settings** dialog.

#### <i class="icon-upload"></i> Update a publication

After publishing, StackEdit will keep your document linked to that publication which makes it easy for you to update it. Once you have modified your document and you want to update your publication, click on the <i class="icon-upload"></i> button in the navigation bar.

> **Note:** The <i class="icon-upload"></i> button is disabled when your document has not been published yet.

#### <i class="icon-upload"></i> Manage document publication

Since one document can be published on multiple locations, you can list and manage publish locations by clicking <i class="icon-upload"></i> **Manage publication** in the <i class="icon-provider-stackedit"></i> menu panel. This will let you remove publication locations that are associated to your document.

> **Note:** If the file has been removed from the website or the blog, the document will no longer be published on that location.

----------


Markdown Extra
--------------------

StackEdit supports **Markdown Extra**, which extends **Markdown** syntax with some nice features.

> **Tip:** You can disable any **Markdown Extra** feature in the **Extensions** tab of the <i class="icon-cog"></i> **Settings** dialog.

> **Note:** You can find more information about **Markdown** syntax [here][2] and **Markdown Extra** extension [here][3].


### Tables

**Markdown Extra** has a special syntax for tables:

Item     | Value
-------- | ---
Computer | $1600
Phone    | $12
Pipe     | $1

You can specify column alignment with one or two colons:

| Item     | Value | Qty   |
| :------- | ----: | :---: |
| Computer | $1600 |  5    |
| Phone    | $12   |  12   |
| Pipe     | $1    |  234  |


### Definition Lists

**Markdown Extra** has a special syntax for definition lists too:

Term 1
Term 2
:   Definition A
:   Definition B

Term 3

:   Definition C

:   Definition D

	> part of definition D


### Fenced code blocks

GitHub's fenced code blocks are also supported with **Highlight.js** syntax highlighting:

```
// Foo
var bar = 0;
```

> **Tip:** To use **Prettify** instead of **Highlight.js**, just configure the **Markdown Extra** extension in the <i class="icon-cog"></i> **Settings** dialog.

> **Note:** You can find more information:

> - about **Prettify** syntax highlighting [here][5],
> - about **Highlight.js** syntax highlighting [here][6].


### Footnotes

You can create footnotes like this[^footnote].

  [^footnote]: Here is the *text* of the **footnote**.


### SmartyPants

SmartyPants converts ASCII punctuation characters into "smart" typographic punctuation HTML entities. For example:

|                  | ASCII                        | HTML              |
 ----------------- | ---------------------------- | ------------------
| Single backticks | `'Isn't this fun?'`            | 'Isn't this fun?' |
| Quotes           | `"Isn't this fun?"`            | "Isn't this fun?" |
| Dashes           | `-- is en-dash, --- is em-dash` | -- is en-dash, --- is em-dash |


### Table of contents

You can insert a table of contents using the marker `[TOC]`:




### MathJax

You can render *LaTeX* mathematical expressions using **MathJax**, as on [math.stackexchange.com][1]:

The *Gamma function* satisfying $\Gamma(n) = (n-1)!\quad\forall n\in\mathbb N$ is via the Euler integral

$$
\Gamma(z) = \int_0^\infty t^{z-1}e^{-t}dt\,.
$$

> **Tip:** To make sure mathematical expressions are rendered properly on your website, include **MathJax** into your template:

```
<script type="text/javascript" src="https://cdn.mathjax.org/mathjax/latest/MathJax.js?config=TeX-AMS_HTML"></script>
```

> **Note:** You can find more information about **LaTeX** mathematical expressions [here][4].


### UML diagrams

You can also render sequence diagrams like this:

```sequence
Alice->Bob: Hello Bob, how are you?
Note right of Bob: Bob thinks
Bob-->Alice: I am good thanks!
```

And flow charts like this:

```flow
st=>start: Start
e=>end
op=>operation: My Operation
cond=>condition: Yes or No?

st->op->cond
cond(yes)->e
cond(no)->op
```

> **Note:** You can find more information:

> - about **Sequence diagrams** syntax [here][7],
> - about **Flow charts** syntax [here][8].

### Support StackEdit

[![](https://cdn.monetizejs.com/resources/button-32.png)](https://monetizejs.com/authorize?client_id=ESTHdCYOi18iLhhO&summary=true)

  [^stackedit]: [StackEdit](https://stackedit.io/) is a full-featured, open-source Markdown editor based on PageDown, the Markdown library used by Stack Overflow and the other Stack Exchange sites.


  [1]: http://math.stackexchange.com/
  [2]: http://daringfireball.net/projects/markdown/syntax "Markdown"
  [3]: https://github.com/jmcmanus/pagedown-extra "Pagedown Extra"
  [4]: http://meta.math.stackexchange.com/questions/5020/mathjax-basic-tutorial-and-quick-reference
  [5]: https://code.google.com/p/google-code-prettify/
  [6]: http://highlightjs.org/
  [7]: http://bramp.github.io/js-sequence-diagrams/
  [8]: http://adrai.github.io/flowchart.js/
















































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































 
