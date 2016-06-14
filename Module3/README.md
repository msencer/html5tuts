<h1 id="programming-in-html-5-with-javascript-and-css3">Programming in HTML 5 with Javascript and CSS3</h1>

<p><div class="toc">
<ul>
<li><a href="#programming-in-html-5-with-javascript-and-css3">Programming in HTML 5 with Javascript and CSS3</a><ul>
<li><a href="#module-3">Module 3</a><ul>
<li><a href="#javascript-overview">Javascript Overview</a><ul>
<li><a href="#statements">Statements</a></li>
<li><a href="#values">Values</a><ul>
<li><a href="#variables">Variables</a></li>
</ul>
</li>
<li><a href="#operators">Operators</a><ul>
<li><a href="#arithmetic">Arithmetic</a></li>
<li><a href="#assignment">Assignment</a></li>
<li><a href="#comparison">Comparison</a></li>
<li><a href="#logical">Logical</a></li>
<li><a href="#bitwise">Bitwise</a></li>
</ul>
</li>
<li><a href="#functions">Functions</a></li>
<li><a href="#events">Events</a></li>
<li><a href="#string-and-number-methods">String and Number methods</a></li>
<li><a href="#math-functions">Math functions</a></li>
<li><a href="#dates">Dates</a></li>
<li><a href="#arrays">Arrays</a><ul>
<li><a href="#array-functions">Array functions</a></li>
</ul>
</li>
<li><a href="#conditions">Conditions</a></li>
<li><a href="#switch">Switch</a></li>
<li><a href="#loops">Loops</a><ul>
<li><a href="#for-loop">For Loop</a></li>
<li><a href="#while-loop">While Loop</a></li>
</ul>
</li>
<li><a href="#strict-mode">Strict Mode</a></li>
</ul>
</li>
<li><a href="#dom-manipulation">DOM Manipulation</a><ul>
<li><a href="#dom-methods">DOM Methods</a><ul>
<li><a href="#finding-elements">Finding Elements</a></li>
<li><a href="#modifying-elements">Modifying Elements</a></li>
<li><a href="#adding-or-deleting-elements">Adding or Deleting elements</a></li>
<li><a href="#manipulating-event-handlers">Manipulating event handlers</a></li>
</ul>
</li>
</ul>
</li>
</ul>
</li>
</ul>
</li>
</ul>
</div>
</p>



<h2 id="module-3">Module 3</h2>

<p>In this module, we are going to dive deep into the syntax properties of  <br>
Javascript language. It will be a quick overview. For the next step we’ll look at the functionalities at your disposal to manipulate <strong>DOM</strong> (Document Object Model). Last but not least, we’ll have a quick look on JQuery library.</p>

<hr>



<h3 id="javascript-overview">Javascript Overview</h3>



<h4 id="statements">Statements</h4>

<p>A computer program is a list of instructions to be executed by computer. These instructions are called statements in programming languages context. </p>

<p>In JS each statement is separated with a <strong>semicolon (;)</strong>. Statements are composed of values, operators, expressions, keywords and comments.</p>



<h4 id="values">Values</h4>

<p>There are two different type of values : <em>fixed(literals)</em> and <em>variable(variables)</em>.</p>

<blockquote>
  <p>Literal examples</p>
  
  <ul>
  <li>200.1</li>
  <li>1453</li>
  <li>“BEM” - ‘BEM’</li>
  </ul>
</blockquote>



<h5 id="variables">Variables</h5>

<p>They are containers for storing data. </p>

<blockquote>
  <p>Has to be identified with unique names :</p>
  
  <ul>
  <li>May contain letters, digits, underscores and dollar sign.</li>
  <li>Must begin with a letter.</li>
  <li>Names are case-sensitive.</li>
  <li>Keywords cannot be used as names</li>
  </ul>
</blockquote>



<pre class="prettyprint"><code class=" hljs cs"><span class="hljs-keyword">var</span> x = <span class="hljs-number">5</span>;
<span class="hljs-keyword">var</span> y = <span class="hljs-number">3</span>;
<span class="hljs-keyword">var</span> z = x * y;
alert(z);</code></pre>

<p>JS has dynamic data types which means same variable can be used as different types.</p>



<pre class="prettyprint"><code class=" hljs javascript"><span class="hljs-keyword">var</span> length = <span class="hljs-number">16</span>;  <span class="hljs-comment">// Number - integer</span>
<span class="hljs-keyword">var</span> money = <span class="hljs-number">200.2</span> <span class="hljs-comment">// Number - float</span>
<span class="hljs-keyword">var</span> speedOfLight = <span class="hljs-number">3e8</span>;<span class="hljs-comment">// Number - scientific</span>
<span class="hljs-keyword">var</span> lastName = <span class="hljs-string">"KARADAYI"</span>; <span class="hljs-comment">// String</span>
<span class="hljs-keyword">var</span> flag = <span class="hljs-literal">true</span>; <span class="hljs-comment">// Boolean</span>
<span class="hljs-keyword">var</span> cars = [<span class="hljs-string">"Mercedes"</span>, <span class="hljs-string">"Toyota"</span>, <span class="hljs-string">"BMW"</span>]; <span class="hljs-comment">// Array</span>
<span class="hljs-keyword">var</span> person = {firstName:<span class="hljs-string">"Mehmet Sencer"</span>,lastName:<span class="hljs-string">"Karadayi"</span>};   <span class="hljs-comment">// Object</span>
<span class="hljs-keyword">var</span> func = <span class="hljs-function"><span class="hljs-keyword">function</span> <span class="hljs-params">()</span>{</span>}; <span class="hljs-comment">// Function</span></code></pre>

<blockquote>
  <p><strong>String special chars</strong></p>
  
  <ul>
  <li><strong>\n</strong> - Newline</li>
  <li><strong>\t</strong> - Tab</li>
  <li><strong>\’</strong> - Single quote</li>
  <li><strong>\”</strong> - Double quote</li>
  <li><strong>\</strong> <strong>\</strong> - Backslash</li>
  <li><strong>\u</strong> - Unicode char e.g \u0040</li>
  </ul>
</blockquote>

<p><em>typeof()</em> function is used to get type of a variable : </p>



<pre class="prettyprint"><code class=" hljs cs"><span class="hljs-keyword">var</span> a = <span class="hljs-keyword">false</span>;
<span class="hljs-keyword">typeof</span>(a); <span class="hljs-comment">// “boolean”</span></code></pre>

<p>In JS, a variable without a value has the value and the type of <strong>undefined</strong>. The keyword <strong>null</strong> can be used to assign the value undefined to a variable.</p>

<blockquote>
  <p>Important Note : </p>
  
  <p>The data type of null is <em>“object” </em></p>
</blockquote>

<p>Therefore;</p>



<pre class="prettyprint"><code class=" hljs javascript"><span class="hljs-keyword">typeof</span> <span class="hljs-literal">undefined</span>             <span class="hljs-comment">// undefined</span>
<span class="hljs-keyword">typeof</span> <span class="hljs-literal">null</span>                  <span class="hljs-comment">// object</span>
<span class="hljs-literal">null</span> === <span class="hljs-literal">undefined</span>           <span class="hljs-comment">// false</span>
<span class="hljs-literal">null</span> == <span class="hljs-literal">undefined</span>            <span class="hljs-comment">// true</span></code></pre>



<h4 id="operators">Operators</h4>



<h5 id="arithmetic">Arithmetic</h5>

<table>
<thead>
<tr>
  <th>Operator</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>+</td>
  <td>Addition</td>
</tr>
<tr>
  <td>-</td>
  <td>Subtraction</td>
</tr>
<tr>
  <td>*</td>
  <td>Multiplication</td>
</tr>
<tr>
  <td>/</td>
  <td>Division</td>
</tr>
<tr>
  <td>%</td>
  <td>Modulus</td>
</tr>
<tr>
  <td>++</td>
  <td>Increment</td>
</tr>
<tr>
  <td>–</td>
  <td>Decrement</td>
</tr>
</tbody></table>


<blockquote>
  <p><strong>Note :</strong></p>
  
  <p>In string type <strong>+</strong> operator acts as a concatenation operator.</p>
</blockquote>



<pre class="prettyprint"><code class=" hljs cs"><span class="hljs-keyword">var</span> firstName = “Mehmet”, lastName = “KARADAYI”;
<span class="hljs-keyword">var</span> fullName = firstName + “ ” + lastName <span class="hljs-comment">// Mehmet KARADAYI</span>

<span class="hljs-keyword">var</span> s1 = <span class="hljs-number">3</span> + <span class="hljs-number">5</span> + ”Sample”; <span class="hljs-comment">// 8Sample</span>
<span class="hljs-keyword">var</span> s2 = ”Sample” + <span class="hljs-number">3</span> + <span class="hljs-number">5</span>; <span class="hljs-comment">// Sample35</span></code></pre>



<h5 id="assignment">Assignment</h5>

<table>
<thead>
<tr>
  <th>Operator</th>
  <th>Example</th>
  <th>Same as</th>
</tr>
</thead>
<tbody><tr>
  <td>=</td>
  <td>x=y</td>
  <td>x=y</td>
</tr>
<tr>
  <td>+=</td>
  <td>x+=y</td>
  <td>x = x+y</td>
</tr>
<tr>
  <td>-=</td>
  <td>x-=y</td>
  <td>x = x-y</td>
</tr>
<tr>
  <td>*=</td>
  <td>x*=y</td>
  <td>x = x*y</td>
</tr>
<tr>
  <td>/=</td>
  <td>x/=y</td>
  <td>x = x/y</td>
</tr>
<tr>
  <td>%=</td>
  <td>x%=y</td>
  <td>x = x%y</td>
</tr>
</tbody></table>




<h5 id="comparison">Comparison</h5>

<table>
<thead>
<tr>
  <th>Operator</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>==</td>
  <td>equal to</td>
</tr>
<tr>
  <td>===</td>
  <td>equal value and type</td>
</tr>
<tr>
  <td>!=</td>
  <td>not equal to</td>
</tr>
<tr>
  <td>!==</td>
  <td>not equal value or type</td>
</tr>
<tr>
  <td>&gt;</td>
  <td>greater than</td>
</tr>
<tr>
  <td>&lt;</td>
  <td>lesser than</td>
</tr>
<tr>
  <td>&gt;=</td>
  <td>greater than or equal to</td>
</tr>
<tr>
  <td>&lt;=</td>
  <td>lesser than or equal to</td>
</tr>
<tr>
  <td>?</td>
  <td>ternary operator</td>
</tr>
</tbody></table>




<h5 id="logical">Logical</h5>

<table>
<thead>
<tr>
  <th>Operator</th>
  <th>Desc</th>
  <th>Example</th>
</tr>
</thead>
<tbody><tr>
  <td>&amp;&amp;</td>
  <td>and</td>
  <td>x&lt;5 &amp;&amp; y&gt;2</td>
</tr>
<tr>
  <td>||</td>
  <td>or</td>
  <td>y == 5 || y&lt;0</td>
</tr>
<tr>
  <td>!</td>
  <td>not</td>
  <td>!flag</td>
</tr>
</tbody></table>




<h5 id="bitwise">Bitwise</h5>

<table>
<thead>
<tr>
  <th>Operator</th>
  <th>Desc</th>
  <th>Example</th>
  <th>Result</th>
</tr>
</thead>
<tbody><tr>
  <td>&amp;</td>
  <td>and</td>
  <td>x = 5 &amp; 1</td>
  <td>1</td>
</tr>
<tr>
  <td>|</td>
  <td>or</td>
  <td>x = 5 | 1</td>
  <td>5</td>
</tr>
<tr>
  <td>~</td>
  <td>not</td>
  <td>x = ~5</td>
  <td>10</td>
</tr>
<tr>
  <td>^</td>
  <td>xor</td>
  <td>x = 5 ^ 1</td>
  <td>4</td>
</tr>
<tr>
  <td>&gt;&gt;</td>
  <td>right shift</td>
  <td>5 &gt;&gt; 1</td>
  <td>2</td>
</tr>
<tr>
  <td>&lt;&lt;</td>
  <td>left shift</td>
  <td>5 &lt;&lt; 1</td>
  <td>10</td>
</tr>
</tbody></table>




<h4 id="functions">Functions</h4>

<p>Javascript function is a special code block to perform a particular set of actions. It is executed when something calls it.</p>



<pre class="prettyprint"><code class=" hljs r"><span class="hljs-keyword">function</span> *name*(*param1*,*param2*,<span class="hljs-keyword">...</span>){
    *code to be executed*
}</code></pre>

<p>Example : </p>



<pre class="prettyprint"><code class=" hljs matlab"><span class="hljs-function"><span class="hljs-keyword">function</span> <span class="hljs-title">toCelsius</span><span class="hljs-params">(fahrenheit)</span> {</span>
    <span class="hljs-keyword">return</span> (<span class="hljs-number">5</span>/<span class="hljs-number">9</span>) * (fahrenheit-<span class="hljs-number">32</span>);
}
<span class="hljs-transposed_variable">console.</span><span class="hljs-built_in">log</span>(toCelsius(<span class="hljs-number">77</span>));</code></pre>



<h4 id="events">Events</h4>

<p>Basically, they are <strong>things</strong> happened to an HTML object. With the use of JS, we might react to those changes.</p>

<blockquote>
  <p>Some examples of HTML events might be</p>
  
  <ul>
  <li>Web page loaded</li>
  <li>Input has changed</li>
  <li>Button clicked etc</li>
  </ul>
</blockquote>



<pre class="prettyprint"><code class=" hljs xml"><span class="hljs-tag">&lt;<span class="hljs-title">button</span> <span class="hljs-attribute">onclick</span>=<span class="hljs-value">”console.log(“button_clicked()”);”</span> &gt;</span>Click me!<span class="hljs-tag">&lt;/<span class="hljs-title">button</span>&gt;</span></code></pre>

<table>
<thead>
<tr>
  <th>Event</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>onchange</td>
  <td>Html element changed</td>
</tr>
<tr>
  <td>onclick</td>
  <td>Html element clicked</td>
</tr>
<tr>
  <td>onmouseover</td>
  <td>User moves mouse over the element</td>
</tr>
<tr>
  <td>onmouseout</td>
  <td>User moves mouse away from the element</td>
</tr>
<tr>
  <td>onkeydown</td>
  <td>User pushes a keyboard key</td>
</tr>
<tr>
  <td>onload</td>
  <td>Browser finished loading the page</td>
</tr>
</tbody></table>




<h4 id="string-and-number-methods">String and Number methods</h4>



<pre class="prettyprint"><code class=" hljs rust">var <span class="hljs-keyword">str</span> = “I am learning JS”;
var l = <span class="hljs-keyword">str</span>.length; <span class="hljs-comment">// l = 16</span>
console.<span class="hljs-keyword">log</span>(<span class="hljs-keyword">str</span>.indexOf(“JS”)); <span class="hljs-comment">// 14, -1 if not found</span>
console.<span class="hljs-keyword">log</span>(<span class="hljs-keyword">str</span>.search(“JS”)); <span class="hljs-comment">// 14, -1 if not found</span>
console.<span class="hljs-keyword">log</span>(<span class="hljs-keyword">str</span>.slice(<span class="hljs-number">7</span>,<span class="hljs-number">13</span>)); <span class="hljs-comment">// “arning”</span>
console.<span class="hljs-keyword">log</span>(<span class="hljs-keyword">str</span>.substring(<span class="hljs-number">7</span>,<span class="hljs-number">13</span>)); <span class="hljs-comment">// “arning”</span>
console.<span class="hljs-keyword">log</span>(<span class="hljs-keyword">str</span>.substr(<span class="hljs-number">7</span>, <span class="hljs-number">6</span>); <span class="hljs-comment">// “arning”</span>
console.<span class="hljs-keyword">log</span>(<span class="hljs-keyword">str</span>.slice(-<span class="hljs-number">12</span>,-<span class="hljs-number">6</span>)); <span class="hljs-comment">// “ learn”</span>
console.<span class="hljs-keyword">log</span>(<span class="hljs-keyword">str</span>.replace(/JS/g,<span class="hljs-string">"JavaScript"</span>)); <span class="hljs-comment">// I am learning JavaScript</span>
console.<span class="hljs-keyword">log</span>(<span class="hljs-keyword">str</span>.toUpperCase()); <span class="hljs-comment">// I AM LEARNING JS</span>
console.<span class="hljs-keyword">log</span>(<span class="hljs-keyword">str</span>.concat(“ and ”,”HTML5”)); <span class="hljs-comment">// I am learning JS and HTML5</span>
console.<span class="hljs-keyword">log</span>(<span class="hljs-keyword">str</span>.split(“ ”)); <span class="hljs-comment">// [“I”,”am”,”learning”,”JS”]</span></code></pre>



<pre class="prettyprint"><code class=" hljs javascript"><span class="hljs-keyword">var</span> x = <span class="hljs-number">12345.9443</span>;
x.toString(); <span class="hljs-comment">// “12345.9443”</span>
x.toFixed(<span class="hljs-number">2</span>); <span class="hljs-comment">// “12345.94”</span>
x.toPrecision(<span class="hljs-number">2</span>); <span class="hljs-comment">// 1.2e+4</span>
<span class="hljs-built_in">parseInt</span>(<span class="hljs-string">"10"</span>); <span class="hljs-comment">// 10</span>
<span class="hljs-built_in">parseInt</span>(<span class="hljs-string">"10.33"</span>); <span class="hljs-comment">// 10</span>
<span class="hljs-built_in">parseInt</span>(<span class="hljs-string">"10 20 30"</span>); <span class="hljs-comment">// 10</span>
<span class="hljs-built_in">parseInt</span>(<span class="hljs-string">"10 years"</span>); <span class="hljs-comment">// 10</span>
<span class="hljs-built_in">parseInt</span>(<span class="hljs-string">"years 10"</span>); <span class="hljs-comment">// NaN </span>
<span class="hljs-built_in">parseFloat</span>(<span class="hljs-string">"10.33"</span>); <span class="hljs-comment">// 10.33</span></code></pre>



<h4 id="math-functions">Math functions</h4>

<p>The math object allows you to perform mathematical operations on numbers.</p>



<pre class="prettyprint"><code class=" hljs javascript"><span class="hljs-built_in">Math</span>.random();       <span class="hljs-comment">// returns a random number</span>
<span class="hljs-built_in">Math</span>.min(<span class="hljs-number">0</span>,-<span class="hljs-number">90</span>,<span class="hljs-number">100</span>,<span class="hljs-number">2</span>); <span class="hljs-comment">// -90</span>
<span class="hljs-built_in">Math</span>.max(<span class="hljs-number">0</span>,-<span class="hljs-number">90</span>,<span class="hljs-number">100</span>,<span class="hljs-number">2</span>); <span class="hljs-comment">// 100</span>
<span class="hljs-built_in">Math</span>.ceil(<span class="hljs-number">4.7</span>); <span class="hljs-comment">// 5</span>
<span class="hljs-built_in">Math</span>.floor(<span class="hljs-number">4.7</span>); <span class="hljs-comment">// 4</span></code></pre>



<h4 id="dates">Dates</h4>

<p>Creating date objects : </p>



<pre class="prettyprint"><code class=" hljs vbscript"><span class="hljs-keyword">new</span> <span class="hljs-built_in">Date</span>()
<span class="hljs-keyword">new</span> <span class="hljs-built_in">Date</span>(milliseconds)
<span class="hljs-keyword">new</span> <span class="hljs-built_in">Date</span>(dateString) 
/* 
    var d = <span class="hljs-keyword">new</span> <span class="hljs-built_in">Date</span>(<span class="hljs-string">"October 13, 2014 11:13:00"</span>);
    var d = <span class="hljs-keyword">new</span> <span class="hljs-built_in">Date</span>(“<span class="hljs-number">2014</span>-<span class="hljs-number">10</span>-<span class="hljs-number">13</span>”);
    var d = <span class="hljs-keyword">new</span> <span class="hljs-built_in">Date</span>(“<span class="hljs-number">2014</span>/<span class="hljs-number">10</span>/<span class="hljs-number">13</span>”);
*/
<span class="hljs-keyword">new</span> <span class="hljs-built_in">Date</span>(<span class="hljs-built_in">year</span>, <span class="hljs-built_in">month</span>, <span class="hljs-built_in">day</span>, hours, minutes, seconds, milliseconds)</code></pre>

<p>There are several useful functions for date objects</p>

<table>
<thead>
<tr>
  <th>Method</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>getDate()</td>
  <td>Returns the day (1-31)</td>
</tr>
<tr>
  <td>getDay()</td>
  <td>Returns weekday (0-6)</td>
</tr>
<tr>
  <td>getFullYear()</td>
  <td>Returns year as YYYY</td>
</tr>
<tr>
  <td>getMonth()</td>
  <td>Returns month (0-11)</td>
</tr>
</tbody></table>




<h4 id="arrays">Arrays</h4>

<p>Arrays are used to store multiple values in single variable. In JS, they can store different types of data. For example :</p>



<pre class="prettyprint"><code class=" hljs javascript"><span class="hljs-keyword">var</span> myArray = []
myArray[<span class="hljs-number">0</span>] = <span class="hljs-built_in">Date</span>.now;
myArray[<span class="hljs-number">1</span>] = <span class="hljs-function"><span class="hljs-keyword">function</span><span class="hljs-params">()</span>{</span>};
myArray[<span class="hljs-number">2</span>] = [“x1”,”x2”];</code></pre>

<p>Array objects have some important properties and methods.</p>



<pre class="prettyprint"><code class=" hljs coffeescript"><span class="hljs-reserved">var</span> cars = [“Audi”,”BMW”,”Mazda”]
<span class="hljs-reserved">var</span> x = cars.length;        <span class="hljs-regexp">//</span> The length property returns the number <span class="hljs-keyword">of</span> elements <span class="hljs-keyword">in</span> cars
<span class="hljs-reserved">var</span> y = cars.sort();         <span class="hljs-regexp">//</span> The sort() method sort cars <span class="hljs-keyword">in</span> alphabetical order</code></pre>

<p>In order to add a new element to an array:</p>



<pre class="prettyprint"><code class=" hljs cs">cars.push(“Toyota”); <span class="hljs-comment">// [Audi,BMW,Mazda,Toyota]</span></code></pre>

<p>If we try to use typeof keyword on an array, we’ll see its type is <strong>object</strong>. This is not the result we are looking for, so there is another function to help us.</p>



<pre class="prettyprint"><code class=" hljs ruby"><span class="hljs-constant">Array</span>.isArray(cars);  <span class="hljs-regexp">//</span> returns <span class="hljs-keyword">true</span></code></pre>



<h5 id="array-functions">Array functions</h5>

<table>
<thead>
<tr>
  <th>Method</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>concat()</td>
  <td>joins the arrays given and return a new array</td>
</tr>
<tr>
  <td>every()</td>
  <td>checks if every element pass the test</td>
</tr>
<tr>
  <td>filter()</td>
  <td>creates a new array with the elements that pass the test</td>
</tr>
<tr>
  <td>map()</td>
  <td>creates a new array with output of the function called for each element</td>
</tr>
<tr>
  <td>push()</td>
  <td>adds element</td>
</tr>
<tr>
  <td>pop()</td>
  <td>removes element</td>
</tr>
<tr>
  <td>reduce()</td>
  <td>reduces the values in array to a single value</td>
</tr>
<tr>
  <td>reverse()</td>
  <td>reverses the elements of the array</td>
</tr>
<tr>
  <td>slice()</td>
  <td>slices array into pieces as a new array</td>
</tr>
</tbody></table>




<h4 id="conditions">Conditions</h4>



<pre class="prettyprint"><code class=" hljs applescript"><span class="hljs-keyword">if</span> (condition1) {
    block <span class="hljs-keyword">of</span> code <span class="hljs-keyword">to</span> be executed <span class="hljs-keyword">if</span> condition1 <span class="hljs-keyword">is</span> <span class="hljs-constant">true</span>
} <span class="hljs-keyword">else</span> <span class="hljs-keyword">if</span> (condition2) {
    block <span class="hljs-keyword">of</span> code <span class="hljs-keyword">to</span> be executed <span class="hljs-keyword">if</span> <span class="hljs-keyword">the</span> condition1 <span class="hljs-keyword">is</span> <span class="hljs-constant">false</span> <span class="hljs-keyword">and</span> condition2 <span class="hljs-keyword">is</span> <span class="hljs-constant">true</span>
} <span class="hljs-keyword">else</span> {
    block <span class="hljs-keyword">of</span> code <span class="hljs-keyword">to</span> be executed <span class="hljs-keyword">if</span> <span class="hljs-keyword">the</span> condition1 <span class="hljs-keyword">is</span> <span class="hljs-constant">false</span> <span class="hljs-keyword">and</span> condition2 <span class="hljs-keyword">is</span> <span class="hljs-constant">false</span>
}</code></pre>



<h4 id="switch">Switch</h4>



<pre class="prettyprint"><code class=" hljs mel"><span class="hljs-keyword">switch</span> (new Date().getDay()) {
    <span class="hljs-keyword">case</span> <span class="hljs-number">1</span>:
    <span class="hljs-keyword">case</span> <span class="hljs-number">2</span>:
    <span class="hljs-keyword">case</span> <span class="hljs-number">3</span>:
    <span class="hljs-keyword">default</span>: 
        <span class="hljs-keyword">text</span> = <span class="hljs-string">"Looking forward to the Weekend"</span>;
        <span class="hljs-keyword">break</span>; 
    <span class="hljs-keyword">case</span> <span class="hljs-number">4</span>:
    <span class="hljs-keyword">case</span> <span class="hljs-number">5</span>:
    <span class="hljs-keyword">text</span> = <span class="hljs-string">"Soon it is Weekend"</span>;
        <span class="hljs-keyword">break</span>; 
    <span class="hljs-keyword">case</span> <span class="hljs-number">0</span>:
    <span class="hljs-keyword">case</span> <span class="hljs-number">6</span>:
    <span class="hljs-keyword">text</span> = <span class="hljs-string">"It is Weekend"</span>;
}</code></pre>



<h4 id="loops">Loops</h4>



<h5 id="for-loop">For Loop</h5>



<pre class="prettyprint"><code class=" hljs matlab"><span class="hljs-keyword">for</span> (<span class="hljs-built_in">i</span> = <span class="hljs-number">0</span>; <span class="hljs-built_in">i</span> &lt; <span class="hljs-number">5</span>; <span class="hljs-built_in">i</span>++) <span class="hljs-cell">{
    text += "The number is " + i + "&lt;br&gt;";
}</span></code></pre>



<h5 id="while-loop">While Loop</h5>



<pre class="prettyprint"><code class=" hljs mel"><span class="hljs-keyword">while</span> (i &lt; <span class="hljs-number">10</span>) {
    <span class="hljs-keyword">text</span> += <span class="hljs-string">"The number is "</span> + i;
    i++;
}</code></pre>



<pre class="prettyprint"><code class=" hljs mel"><span class="hljs-keyword">do</span> {
    <span class="hljs-keyword">text</span> += <span class="hljs-string">"The number is "</span> + i;
    i++;
}
<span class="hljs-keyword">while</span> (i &lt; <span class="hljs-number">10</span>);</code></pre>



<h4 id="strict-mode">Strict Mode</h4>

<p>“use strict”;</p>

<blockquote>
  <p>Why Strict Mode?</p>
  
  <ul>
  <li>Strict mode makes it easier to write “secure” JavaScript.</li>
  <li>Strict mode changes previously accepted “bad syntax” into real errors.</li>
  </ul>
</blockquote>

<p>As an example, in normal JavaScript, mistyping a variable name creates a new global variable. In strict mode, this will throw an error, making it impossible to accidentally create a global variable.</p>

<p>In normal JavaScript, a developer will not receive any error feedback assigning values to non-writable properties.</p>

<p>In strict mode, any assignment to a non-writable property, a getter-only property, a non-existing property, a non-existing variable, or a non-existing object, will throw an error.</p>



<h3 id="dom-manipulation">DOM Manipulation</h3>

<p>The DOM is a W3C standard. It defines a standard for accessing documents. HTML DOM is a programming interface for HTML. </p>

<blockquote>
  <p>It defines :</p>
  
  <ul>
  <li>HTML as object</li>
  <li>The properties of all HTML elements</li>
  <li>Methods to access all HTML elements</li>
  <li>Events of all HTML elements</li>
  </ul>
</blockquote>

<p>In other words: <strong>The HTML DOM is a standard for how to get, change, add, or delete HTML elements.</strong></p>



<h4 id="dom-methods">DOM Methods</h4>



<h5 id="finding-elements">Finding Elements</h5>

<table>
<thead>
<tr>
  <th>Method</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>document.getElementById(id)</td>
  <td>returns the specified element by id</td>
</tr>
<tr>
  <td>document.getElementsByTagName(name)</td>
  <td>returns a element list by tag name</td>
</tr>
<tr>
  <td>document.getElementsByClassName(name)</td>
  <td>returns the elements that are a member of the specified class</td>
</tr>
</tbody></table>




<h5 id="modifying-elements">Modifying Elements</h5>

<table>
<thead>
<tr>
  <th>Method</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>element.innerHTML = newHtml</td>
  <td>Changes the inner html of the element</td>
</tr>
<tr>
  <td>element.attribute = value</td>
  <td>Sets the value of the specified attr.</td>
</tr>
<tr>
  <td>element.setAttribute(attr,val)</td>
  <td>Sets the value of the specified attr.</td>
</tr>
<tr>
  <td>element.style.property = val</td>
  <td>Sets the value of a style property</td>
</tr>
</tbody></table>




<h5 id="adding-or-deleting-elements">Adding or Deleting elements</h5>

<table>
<thead>
<tr>
  <th>Method</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>document.createElement(element)</td>
  <td>Creates a new element</td>
</tr>
<tr>
  <td>document.removeChild(element)</td>
  <td>Removes given element from the parent element</td>
</tr>
<tr>
  <td>document.appendChild(element)</td>
  <td>Adds an html element</td>
</tr>
<tr>
  <td>document.replaceChild(element)</td>
  <td>Replaces an html element</td>
</tr>
<tr>
  <td>document.write(text)</td>
  <td>Write into HTML stream</td>
</tr>
</tbody></table>




<h5 id="manipulating-event-handlers">Manipulating event handlers</h5>

<table>
<thead>
<tr>
  <th>Method</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>element.event = function</td>
  <td>Sets a behaviour for an event</td>
</tr>
<tr>
  <td>element.addEventListener(“event”,function)</td>
  <td>Adds a behaviour for an event</td>
</tr>
<tr>
  <td>element.removeEventListener(“event”,function)</td>
  <td>Removes a behaviour from an event</td>
</tr>
</tbody></table>


<p>1</p>

<p>1 <br>
1</p>

<p>1 <br>
1</p>

<p>1 <br>
1</p>

<p>1 <br>
1</p>

<p>1 <br>
1 <br>
1</p>

<p>1 <br>
1 <br>
1</p>

<p>1 <br>
1</p>