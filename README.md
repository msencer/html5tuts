<h1 id="programming-in-html-5-with-javascript-and-css3">Programming in HTML 5 with Javascript and CSS3</h1>

<p><div class="toc">
<ul>
<li><a href="#programming-in-html-5-with-javascript-and-css3">Programming in HTML 5 with Javascript and CSS3</a><ul>
<li><a href="#module-3">Module 3</a><ul>
<li><a href="#syntax">Syntax</a><ul>
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
<li><a href="#create-a-document"> Create a document</a></li>
<li><a href="#switch-to-another-document"> Switch to another document</a></li>
<li><a href="#rename-a-document"> Rename a document</a></li>
<li><a href="#delete-a-document"> Delete a document</a></li>
<li><a href="#export-a-document"> Export a document</a></li>
</ul>
</li>
</ul>
</li>
<li><a href="#synchronization">Synchronization</a><ul>
<li><ul>
<li><a href="#open-a-document"> Open a document</a></li>
<li><a href="#save-a-document"> Save a document</a></li>
<li><a href="#synchronize-a-document"> Synchronize a document</a></li>
<li><a href="#manage-document-synchronization"> Manage document synchronization</a></li>
</ul>
</li>
</ul>
</li>
<li><a href="#publication">Publication</a><ul>
<li><ul>
<li><a href="#publish-a-document"> Publish a document</a></li>
<li><a href="#update-a-publication"> Update a publication</a></li>
<li><a href="#manage-document-publication"> Manage document publication</a></li>
</ul>
</li>
</ul>
</li>
<li><a href="#markdown-extra">Markdown Extra</a><ul>
<li><a href="#tables">Tables</a></li>
<li><a href="#definition-lists">Definition Lists</a></li>
<li><a href="#fenced-code-blocks">Fenced code blocks</a></li>
<li><a href="#footnotes">Footnotes</a></li>
<li><a href="#smartypants">SmartyPants</a></li>
<li><a href="#table-of-contents">Table of contents</a></li>
<li><a href="#mathjax">MathJax</a></li>
<li><a href="#uml-diagrams">UML diagrams</a></li>
<li><a href="#support-stackedit">Support StackEdit</a></li>
</ul>
</li>
</ul>
</li>
</ul>
</div>
</p>



<h2 id="module-3">Module 3</h2>

<p>In this module, we are going to dive deep into the syntax properties of Javascript language. It will be a quick overview. For the next step we’ll look at the functionalities at your disposal to manipulate <strong>DOM</strong> (Document Object Model). Last but not least, we’ll have a quick look on JQuery library.</p>

<hr>



<h3 id="syntax">Syntax</h3>



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



<h4 id="create-a-document"><i class="icon-file"></i> Create a document</h4>

<p>The document panel is accessible using the <i class="icon-folder-open"></i> button in the navigation bar. You can create a new document by clicking <i class="icon-file"></i> <strong>New document</strong> in the document panel.</p>



<h4 id="switch-to-another-document"><i class="icon-folder-open"></i> Switch to another document</h4>

<p>All your local documents are listed in the document panel. You can switch from one to another by clicking a document in the list or you can toggle documents using <kbd>Ctrl+[</kbd> and <kbd>Ctrl+]</kbd>.</p>



<h4 id="rename-a-document"><i class="icon-pencil"></i> Rename a document</h4>

<p>You can rename the current document by clicking the document title in the navigation bar.</p>



<h4 id="delete-a-document"><i class="icon-trash"></i> Delete a document</h4>

<p>You can delete the current document by clicking <i class="icon-trash"></i> <strong>Delete document</strong> in the document panel.</p>



<h4 id="export-a-document"><i class="icon-hdd"></i> Export a document</h4>

<p>You can save the current document to a file by clicking <i class="icon-hdd"></i> <strong>Export to disk</strong> from the <i class="icon-provider-stackedit"></i> menu panel.</p>

<blockquote>
  <p><strong>Tip:</strong> Check out the <a href="#publish-a-document"><i class="icon-upload"></i> Publish a document</a> section for a description of the different output formats.</p>
</blockquote>

<hr>



<h2 id="synchronization">Synchronization</h2>

<p>StackEdit can be combined with <i class="icon-provider-gdrive"></i> <strong>Google Drive</strong> and <i class="icon-provider-dropbox"></i> <strong>Dropbox</strong> to have your documents saved in the <em>Cloud</em>. The synchronization mechanism takes care of uploading your modifications or downloading the latest version of your documents.</p>

<blockquote>
  <p><strong>Note:</strong></p>
  
  <ul>
  <li>Full access to <strong>Google Drive</strong> or <strong>Dropbox</strong> is required to be able to import any document in StackEdit. Permission restrictions can be configured in the settings.</li>
  <li>Imported documents are downloaded in your browser and are not transmitted to a server.</li>
  <li>If you experience problems saving your documents on Google Drive, check and optionally disable browser extensions, such as Disconnect.</li>
  </ul>
</blockquote>



<h4 id="open-a-document"><i class="icon-refresh"></i> Open a document</h4>

<p>You can open a document from <i class="icon-provider-gdrive"></i> <strong>Google Drive</strong> or the <i class="icon-provider-dropbox"></i> <strong>Dropbox</strong> by opening the <i class="icon-refresh"></i> <strong>Synchronize</strong> sub-menu and by clicking <strong>Open from…</strong>. Once opened, any modification in your document will be automatically synchronized with the file in your <strong>Google Drive</strong> / <strong>Dropbox</strong> account.</p>



<h4 id="save-a-document"><i class="icon-refresh"></i> Save a document</h4>

<p>You can save any document by opening the <i class="icon-refresh"></i> <strong>Synchronize</strong> sub-menu and by clicking <strong>Save on…</strong>. Even if your document is already synchronized with <strong>Google Drive</strong> or <strong>Dropbox</strong>, you can export it to a another location. StackEdit can synchronize one document with multiple locations and accounts.</p>



<h4 id="synchronize-a-document"><i class="icon-refresh"></i> Synchronize a document</h4>

<p>Once your document is linked to a <i class="icon-provider-gdrive"></i> <strong>Google Drive</strong> or a <i class="icon-provider-dropbox"></i> <strong>Dropbox</strong> file, StackEdit will periodically (every 3 minutes) synchronize it by downloading/uploading any modification. A merge will be performed if necessary and conflicts will be detected.</p>

<p>If you just have modified your document and you want to force the synchronization, click the <i class="icon-refresh"></i> button in the navigation bar.</p>

<blockquote>
  <p><strong>Note:</strong> The <i class="icon-refresh"></i> button is disabled when you have no document to synchronize.</p>
</blockquote>



<h4 id="manage-document-synchronization"><i class="icon-refresh"></i> Manage document synchronization</h4>

<p>Since one document can be synchronized with multiple locations, you can list and manage synchronized locations by clicking <i class="icon-refresh"></i> <strong>Manage synchronization</strong> in the <i class="icon-refresh"></i> <strong>Synchronize</strong> sub-menu. This will let you remove synchronization locations that are associated to your document.</p>

<blockquote>
  <p><strong>Note:</strong> If you delete the file from <strong>Google Drive</strong> or from <strong>Dropbox</strong>, the document will no longer be synchronized with that location.</p>
</blockquote>

<hr>



<h2 id="publication">Publication</h2>

<p>Once you are happy with your document, you can publish it on different websites directly from StackEdit. As for now, StackEdit can publish on <strong>Blogger</strong>, <strong>Dropbox</strong>, <strong>Gist</strong>, <strong>GitHub</strong>, <strong>Google Drive</strong>, <strong>Tumblr</strong>, <strong>WordPress</strong> and on any SSH server.</p>



<h4 id="publish-a-document"><i class="icon-upload"></i> Publish a document</h4>

<p>You can publish your document by opening the <i class="icon-upload"></i> <strong>Publish</strong> sub-menu and by choosing a website. In the dialog box, you can choose the publication format:</p>

<ul>
<li>Markdown, to publish the Markdown text on a website that can interpret it (<strong>GitHub</strong> for instance),</li>
<li>HTML, to publish the document converted into HTML (on a blog for example),</li>
<li>Template, to have a full control of the output.</li>
</ul>

<blockquote>
  <p><strong>Note:</strong> The default template is a simple webpage wrapping your document in HTML format. You can customize it in the <strong>Advanced</strong> tab of the <i class="icon-cog"></i> <strong>Settings</strong> dialog.</p>
</blockquote>



<h4 id="update-a-publication"><i class="icon-upload"></i> Update a publication</h4>

<p>After publishing, StackEdit will keep your document linked to that publication which makes it easy for you to update it. Once you have modified your document and you want to update your publication, click on the <i class="icon-upload"></i> button in the navigation bar.</p>

<blockquote>
  <p><strong>Note:</strong> The <i class="icon-upload"></i> button is disabled when your document has not been published yet.</p>
</blockquote>



<h4 id="manage-document-publication"><i class="icon-upload"></i> Manage document publication</h4>

<p>Since one document can be published on multiple locations, you can list and manage publish locations by clicking <i class="icon-upload"></i> <strong>Manage publication</strong> in the <i class="icon-provider-stackedit"></i> menu panel. This will let you remove publication locations that are associated to your document.</p>

<blockquote>
  <p><strong>Note:</strong> If the file has been removed from the website or the blog, the document will no longer be published on that location.</p>
</blockquote>

<hr>



<h2 id="markdown-extra">Markdown Extra</h2>

<p>StackEdit supports <strong>Markdown Extra</strong>, which extends <strong>Markdown</strong> syntax with some nice features.</p>

<blockquote>
  <p><strong>Tip:</strong> You can disable any <strong>Markdown Extra</strong> feature in the <strong>Extensions</strong> tab of the <i class="icon-cog"></i> <strong>Settings</strong> dialog.</p>
  
  <p><strong>Note:</strong> You can find more information about <strong>Markdown</strong> syntax <a href="http://daringfireball.net/projects/markdown/syntax" title="Markdown">here</a> and <strong>Markdown Extra</strong> extension <a href="https://github.com/jmcmanus/pagedown-extra" title="Pagedown Extra">here</a>.</p>
</blockquote>



<h3 id="tables">Tables</h3>

<p><strong>Markdown Extra</strong> has a special syntax for tables:</p>

<table>
<thead>
<tr>
  <th>Item</th>
  <th>Value</th>
</tr>
</thead>
<tbody><tr>
  <td>Computer</td>
  <td>$1600</td>
</tr>
<tr>
  <td>Phone</td>
  <td>$12</td>
</tr>
<tr>
  <td>Pipe</td>
  <td>$1</td>
</tr>
</tbody></table>


<p>You can specify column alignment with one or two colons:</p>

<table>
<thead>
<tr>
  <th align="left">Item</th>
  <th align="right">Value</th>
  <th align="center">Qty</th>
</tr>
</thead>
<tbody><tr>
  <td align="left">Computer</td>
  <td align="right">$1600</td>
  <td align="center">5</td>
</tr>
<tr>
  <td align="left">Phone</td>
  <td align="right">$12</td>
  <td align="center">12</td>
</tr>
<tr>
  <td align="left">Pipe</td>
  <td align="right">$1</td>
  <td align="center">234</td>
</tr>
</tbody></table>




<h3 id="definition-lists">Definition Lists</h3>

<p><strong>Markdown Extra</strong> has a special syntax for definition lists too:</p>

<dl>
<dt>Term 1</dt>
<dt>Term 2</dt>
<dd>Definition A</dd>

<dd>Definition B</dd>

<dt>Term 3</dt>
<dd>
<p>Definition C</p>
</dd>

<dd>
<p>Definition D</p>

<blockquote>
  <p>part of definition D</p>
</blockquote>
</dd>
</dl>



<h3 id="fenced-code-blocks">Fenced code blocks</h3>

<p>GitHub’s fenced code blocks are also supported with <strong>Highlight.js</strong> syntax highlighting:</p>



<pre class="prettyprint"><code class=" hljs cs"><span class="hljs-comment">// Foo</span>
<span class="hljs-keyword">var</span> bar = <span class="hljs-number">0</span>;</code></pre>

<blockquote>
  <p><strong>Tip:</strong> To use <strong>Prettify</strong> instead of <strong>Highlight.js</strong>, just configure the <strong>Markdown Extra</strong> extension in the <i class="icon-cog"></i> <strong>Settings</strong> dialog.</p>
  
  <p><strong>Note:</strong> You can find more information:</p>
  
  <ul>
  <li>about <strong>Prettify</strong> syntax highlighting <a href="https://code.google.com/p/google-code-prettify/">here</a>,</li>
  <li>about <strong>Highlight.js</strong> syntax highlighting <a href="http://highlightjs.org/">here</a>.</li>
  </ul>
</blockquote>



<h3 id="footnotes">Footnotes</h3>

<p>You can create footnotes like this<a href="#fn:footnote" id="fnref:footnote" title="See footnote" class="footnote">1</a>.</p>



<h3 id="smartypants">SmartyPants</h3>

<p>SmartyPants converts ASCII punctuation characters into “smart” typographic punctuation HTML entities. For example:</p>

<table>
<thead>
<tr>
  <th></th>
  <th>ASCII</th>
  <th>HTML</th>
</tr>
</thead>
<tbody><tr>
  <td>Single backticks</td>
  <td><code>'Isn't this fun?'</code></td>
  <td>‘Isn’t this fun?’</td>
</tr>
<tr>
  <td>Quotes</td>
  <td><code>"Isn't this fun?"</code></td>
  <td>“Isn’t this fun?”</td>
</tr>
<tr>
  <td>Dashes</td>
  <td><code>-- is en-dash, --- is em-dash</code></td>
  <td>– is en-dash, — is em-dash</td>
</tr>
</tbody></table>




<h3 id="table-of-contents">Table of contents</h3>

<p>You can insert a table of contents using the marker <code>[TOC]</code>:</p>



<h3 id="mathjax">MathJax</h3>

<p>You can render <em>LaTeX</em> mathematical expressions using <strong>MathJax</strong>, as on <a href="http://math.stackexchange.com/">math.stackexchange.com</a>:</p>

<p>The <em>Gamma function</em> satisfying <script type="math/tex" id="MathJax-Element-1">\Gamma(n) = (n-1)!\quad\forall n\in\mathbb N</script> is via the Euler integral</p>



<p><script type="math/tex; mode=display" id="MathJax-Element-2">
\Gamma(z) = \int_0^\infty t^{z-1}e^{-t}dt\,.
</script></p>

<blockquote>
  <p><strong>Tip:</strong> To make sure mathematical expressions are rendered properly on your website, include <strong>MathJax</strong> into your template:</p>
</blockquote>



<pre class="prettyprint"><code class=" hljs xml"><span class="hljs-tag">&lt;<span class="hljs-title">script</span> <span class="hljs-attribute">type</span>=<span class="hljs-value">"text/javascript"</span> <span class="hljs-attribute">src</span>=<span class="hljs-value">"https://cdn.mathjax.org/mathjax/latest/MathJax.js?config=TeX-AMS_HTML"</span>&gt;</span><span class="javascript"></span><span class="hljs-tag">&lt;/<span class="hljs-title">script</span>&gt;</span></code></pre>

<blockquote>
  <p><strong>Note:</strong> You can find more information about <strong>LaTeX</strong> mathematical expressions <a href="http://meta.math.stackexchange.com/questions/5020/mathjax-basic-tutorial-and-quick-reference">here</a>.</p>
</blockquote>



<h3 id="uml-diagrams">UML diagrams</h3>

<p>You can also render sequence diagrams like this:</p>



<div class="sequence-diagram"><svg height="265" version="1.1" width="375.0390625" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" style="overflow: hidden; position: relative; left: -0.5px; top: -0.28125px;"><desc style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);">Created with Raphaël 2.1.2</desc><defs style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"><path stroke-linecap="round" d="M5,0 0,2.5 5,5z" id="raphael-marker-block" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></path><marker id="raphael-marker-endblock55-obj21" markerHeight="5" markerWidth="5" orient="auto" refX="2.5" refY="2.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"><use xmlns:xlink="http://www.w3.org/1999/xlink" xlink:href="#raphael-marker-block" transform="rotate(180 2.5 2.5) scale(1,1)" stroke-width="1.0000" fill="#000" stroke="none" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></use></marker><marker id="raphael-marker-endblock55-obj27" markerHeight="5" markerWidth="5" orient="auto" refX="2.5" refY="2.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"><use xmlns:xlink="http://www.w3.org/1999/xlink" xlink:href="#raphael-marker-block" transform="rotate(180 2.5 2.5) scale(1,1)" stroke-width="1.0000" fill="#000" stroke="none" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></use></marker></defs><rect x="10" y="20" width="49.546875" height="39" rx="0" ry="0" fill="none" stroke="#000000" stroke-width="2" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></rect><rect x="19.984375" y="30" width="29.546875" height="19" rx="0" ry="0" fill="#ffffff" stroke="none" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></rect><text x="34.7734375" y="39.5" text-anchor="middle" font-family="Andale Mono, monospace" font-size="16px" stroke="none" fill="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); text-anchor: middle; font-family: 'Andale Mono', monospace; font-size: 16px;"><tspan dy="5.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);">Alice</tspan></text><rect x="10" y="206" width="49.546875" height="39" rx="0" ry="0" fill="none" stroke="#000000" stroke-width="2" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></rect><rect x="19.984375" y="216" width="29.546875" height="19" rx="0" ry="0" fill="#ffffff" stroke="none" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></rect><text x="34.7734375" y="225.5" text-anchor="middle" font-family="Andale Mono, monospace" font-size="16px" stroke="none" fill="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); text-anchor: middle; font-family: 'Andale Mono', monospace; font-size: 16px;"><tspan dy="5.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);">Alice</tspan></text><path fill="none" stroke="#000000" d="M34.7734375,59L34.7734375,206" stroke-width="2" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></path><rect x="182.7890625" y="20" width="45.1875" height="39" rx="0" ry="0" fill="none" stroke="#000000" stroke-width="2" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></rect><rect x="192.78125" y="30" width="25.1875" height="19" rx="0" ry="0" fill="#ffffff" stroke="none" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></rect><text x="205.3828125" y="39.5" text-anchor="middle" font-family="Andale Mono, monospace" font-size="16px" stroke="none" fill="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); text-anchor: middle; font-family: 'Andale Mono', monospace; font-size: 16px;"><tspan dy="5.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);">Bob</tspan></text><rect x="182.7890625" y="206" width="45.1875" height="39" rx="0" ry="0" fill="none" stroke="#000000" stroke-width="2" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></rect><rect x="192.78125" y="216" width="25.1875" height="19" rx="0" ry="0" fill="#ffffff" stroke="none" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></rect><text x="205.3828125" y="225.5" text-anchor="middle" font-family="Andale Mono, monospace" font-size="16px" stroke="none" fill="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); text-anchor: middle; font-family: 'Andale Mono', monospace; font-size: 16px;"><tspan dy="5.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);">Bob</tspan></text><path fill="none" stroke="#000000" d="M205.3828125,59L205.3828125,206" stroke-width="2" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></path><rect x="44.765625" y="74.5" width="150.609375" height="19" rx="0" ry="0" fill="#ffffff" stroke="none" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></rect><text x="120.078125" y="84" text-anchor="middle" font-family="Andale Mono, monospace" font-size="16px" stroke="none" fill="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); text-anchor: middle; font-family: 'Andale Mono', monospace; font-size: 16px;"><tspan dy="5.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);">Hello Bob, how are you?</tspan></text><path fill="none" stroke="#000000" d="M34.7734375,98C34.7734375,98,172.2631664564833,98,200.39216862092007,98" stroke-width="2" marker-end="url(#raphael-marker-endblock55-obj21)" stroke-dasharray="0" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></path><rect x="225.3828125" y="118" width="77.0625" height="29" rx="0" ry="0" fill="none" stroke="#000000" stroke-width="2" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></rect><rect x="230.375" y="123" width="67.0625" height="19" rx="0" ry="0" fill="#ffffff" stroke="none" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></rect><text x="263.9140625" y="132.5" text-anchor="middle" font-family="Andale Mono, monospace" font-size="16px" stroke="none" fill="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); text-anchor: middle; font-family: 'Andale Mono', monospace; font-size: 16px;"><tspan dy="5.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);">Bob thinks</tspan></text><rect x="63.984375" y="162.5" width="112.15625" height="19" rx="0" ry="0" fill="#ffffff" stroke="none" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></rect><text x="120.078125" y="172" text-anchor="middle" font-family="Andale Mono, monospace" font-size="16px" stroke="none" fill="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); text-anchor: middle; font-family: 'Andale Mono', monospace; font-size: 16px;"><tspan dy="5.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);">I am good thanks!</tspan></text><path fill="none" stroke="#000000" d="M205.3828125,186C205.3828125,186,67.8930835435167,186,39.764081379079926,186" stroke-width="2" marker-end="url(#raphael-marker-endblock55-obj27)" stroke-dasharray="6,2" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></path></svg></div>

<p>And flow charts like this:</p>



<div class="flow-chart"><svg height="401.958984375" version="1.1" width="171.3671875" xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" style="overflow: hidden; position: relative; top: -0.875px;"><desc style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);">Created with Raphaël 2.1.2</desc><defs style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"><marker id="raphael-marker-endblock33-obj36" markerHeight="3" markerWidth="3" orient="auto" refX="1.5" refY="1.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"><use xmlns:xlink="http://www.w3.org/1999/xlink" xlink:href="#raphael-marker-block" transform="rotate(180 1.5 1.5) scale(0.6,0.6)" stroke-width="1.6667" fill="black" stroke="none" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></use></marker><marker id="raphael-marker-endblock33-obj37" markerHeight="3" markerWidth="3" orient="auto" refX="1.5" refY="1.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"><use xmlns:xlink="http://www.w3.org/1999/xlink" xlink:href="#raphael-marker-block" transform="rotate(180 1.5 1.5) scale(0.6,0.6)" stroke-width="1.6667" fill="black" stroke="none" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></use></marker><marker id="raphael-marker-endblock33-obj38" markerHeight="3" markerWidth="3" orient="auto" refX="1.5" refY="1.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"><use xmlns:xlink="http://www.w3.org/1999/xlink" xlink:href="#raphael-marker-block" transform="rotate(180 1.5 1.5) scale(0.6,0.6)" stroke-width="1.6667" fill="black" stroke="none" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></use></marker><marker id="raphael-marker-endblock33-obj40" markerHeight="3" markerWidth="3" orient="auto" refX="1.5" refY="1.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"><use xmlns:xlink="http://www.w3.org/1999/xlink" xlink:href="#raphael-marker-block" transform="rotate(180 1.5 1.5) scale(0.6,0.6)" stroke-width="1.6667" fill="black" stroke="none" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></use></marker></defs><rect x="0" y="0" width="50.6875" height="39" rx="20" ry="20" fill="#ffffff" stroke="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);" stroke-width="2" class="flowchart" id="st" transform="matrix(1,0,0,1,48.8398,19.5918)"></rect><text x="10" y="19.5" text-anchor="start" font-family="sans-serif" font-size="14px" stroke="none" fill="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); text-anchor: start; font-family: sans-serif; font-size: 14px; font-weight: normal;" id="stt" class="flowchartt" font-weight="normal" transform="matrix(1,0,0,1,48.8398,19.5918)"><tspan dy="5.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);">Start</tspan></text><rect x="0" y="0" width="104.109375" height="39" rx="0" ry="0" fill="#ffffff" stroke="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);" stroke-width="2" class="flowchart" id="op" transform="matrix(1,0,0,1,22.1289,128.1836)"></rect><text x="10" y="19.5" text-anchor="start" font-family="sans-serif" font-size="14px" stroke="none" fill="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); text-anchor: start; font-family: sans-serif; font-size: 14px; font-weight: normal;" id="opt" class="flowchartt" font-weight="normal" transform="matrix(1,0,0,1,22.1289,128.1836)"><tspan dy="5.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);">My Operation</tspan></text><path fill="#ffffff" stroke="#000000" d="M35.091796875,17.5458984375L0,35.091796875L70.18359375,70.18359375L140.3671875,35.091796875L70.18359375,0L0,35.091796875" stroke-width="2" font-family="sans-serif" font-weight="normal" id="cond" class="flowchart" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: sans-serif; font-weight: normal;" transform="matrix(1,0,0,1,4,221.1836)"></path><text x="40.091796875" y="35.091796875" text-anchor="start" font-family="sans-serif" font-size="14px" stroke="none" fill="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); text-anchor: start; font-family: sans-serif; font-size: 14px; font-weight: normal;" id="condt" class="flowchartt" font-weight="normal" transform="matrix(1,0,0,1,4,221.1836)"><tspan dy="5.513671875" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);">Yes or No?</tspan><tspan dy="18" x="40.091796875" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);"></tspan></text><rect x="0" y="0" width="44.359375" height="39" rx="20" ry="20" fill="#ffffff" stroke="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);" stroke-width="2" class="flowchart" id="e" transform="matrix(1,0,0,1,52.0039,360.959)"></rect><text x="10" y="19.5" text-anchor="start" font-family="sans-serif" font-size="14px" stroke="none" fill="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); text-anchor: start; font-family: sans-serif; font-size: 14px; font-weight: normal;" id="et" class="flowchartt" font-weight="normal" transform="matrix(1,0,0,1,52.0039,360.959)"><tspan dy="5.5" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);">End</tspan></text><path fill="none" stroke="#000000" d="M74.18359375,58.591796875C74.18359375,58.591796875,74.18359375,111.87301635742188,74.18359375,125.19332122802734" stroke-width="2" marker-end="url(#raphael-marker-endblock33-obj36)" font-family="sans-serif" font-weight="normal" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: sans-serif; font-weight: normal;"></path><path fill="none" stroke="#000000" d="M74.18359375,167.18359375C74.18359375,167.18359375,74.18359375,206.83769369125366,74.18359375,218.18403283460066" stroke-width="2" marker-end="url(#raphael-marker-endblock33-obj37)" font-family="sans-serif" font-weight="normal" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: sans-serif; font-weight: normal;"></path><path fill="none" stroke="#000000" d="M74.18359375,291.3671875C74.18359375,291.3671875,74.18359375,344.6484069824219,74.18359375,357.96871185302734" stroke-width="2" marker-end="url(#raphael-marker-endblock33-obj38)" font-family="sans-serif" font-weight="normal" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: sans-serif; font-weight: normal;"></path><text x="79.18359375" y="301.3671875" text-anchor="start" font-family="sans-serif" font-size="14px" stroke="none" fill="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); text-anchor: start; font-family: sans-serif; font-size: 14px; font-weight: normal;" font-weight="normal"><tspan dy="5.5078125" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);">yes</tspan></text><path fill="none" stroke="#000000" d="M144.3671875,256.275390625C144.3671875,256.275390625,169.3671875,256.275390625,169.3671875,256.275390625C169.3671875,256.275390625,169.3671875,103.18359375,169.3671875,103.18359375C169.3671875,103.18359375,74.18359375,103.18359375,74.18359375,103.18359375C74.18359375,103.18359375,74.18359375,118.55703830718994,74.18359375,125.19284152425826" stroke-width="2" marker-end="url(#raphael-marker-endblock33-obj40)" font-family="sans-serif" font-weight="normal" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); font-family: sans-serif; font-weight: normal;"></path><text x="149.3671875" y="246.275390625" text-anchor="start" font-family="sans-serif" font-size="14px" stroke="none" fill="#000000" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0); text-anchor: start; font-family: sans-serif; font-size: 14px; font-weight: normal;" font-weight="normal"><tspan dy="5.509765625" style="-webkit-tap-highlight-color: rgba(0, 0, 0, 0);">no</tspan></text></svg></div>

<blockquote>
  <p><strong>Note:</strong> You can find more information:</p>
  
  <ul>
  <li>about <strong>Sequence diagrams</strong> syntax <a href="http://bramp.github.io/js-sequence-diagrams/">here</a>,</li>
  <li>about <strong>Flow charts</strong> syntax <a href="http://adrai.github.io/flowchart.js/">here</a>.</li>
  </ul>
</blockquote>



<h3 id="support-stackedit">Support StackEdit</h3>

<p><a href="https://monetizejs.com/authorize?client_id=ESTHdCYOi18iLhhO&amp;summary=true"><img src="https://cdn.monetizejs.com/resources/button-32.png" alt="" title=""></a></p><div class="footnotes"><hr><ol><li id="fn:footnote">Here is the <em>text</em> of the <strong>footnote</strong>. <a href="#fnref:footnote" title="Return to article" class="reversefootnote">↩</a></li></ol></div>