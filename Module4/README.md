<h1 id="programming-in-html-5-with-javascript-and-css3">Programming in HTML 5 with Javascript and CSS3</h1>

<p><div class="toc">
<ul>
<li><a href="#programming-in-html-5-with-javascript-and-css3">Programming in HTML 5 with Javascript and CSS3</a><ul>
<li><a href="#module-4">Module 4</a><ul>
<li><a href="#html-forms">HTML Forms</a><ul>
<li><a href="#input-element">Input element</a><ul>
<li><a href="#input-element-validation-attributes">Input element validation attributes</a></li>
</ul>
</li>
<li><a href="#form-attributes">Form Attributes</a></li>
<li><a href="#other-new-elements-used-in-forms">Other new elements used in forms</a><ul>
<li><a href="#keygen">keygen</a></li>
<li><a href="#output">output</a></li>
</ul>
</li>
</ul>
</li>
<li><a href="#references">References</a></li>
</ul>
</li>
</ul>
</li>
</ul>
</div>
</p>



<h2 id="module-4">Module 4</h2>

<p>In this module, we are going to collect data from user input components and validate them using javascript and built in HTML5 properties.</p>



<h3 id="html-forms">HTML Forms</h3>

<p>HTML Forms are used to collect user data input. <strong></strong> tag marks the input area.  elements are the fields that user give input. Therefore, first we need to take a look at input tag.</p>



<h4 id="input-element">Input element</h4>

<p>Input elements differ from each other by using an attribute called <strong>type</strong>. There are several types that can be used.</p>



<pre class="prettyprint"><code class=" hljs fsharp">&lt;input <span class="hljs-class"><span class="hljs-keyword">type</span>=</span>”[<span class="hljs-class"><span class="hljs-keyword">type</span>]” /&gt;</span></code></pre>

<table>
<thead>
<tr>
  <th>Input type</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>text</td>
  <td>Normal text area</td>
</tr>
<tr>
  <td>password</td>
  <td>Masked text area for password input</td>
</tr>
<tr>
  <td>radio</td>
  <td>one of many choices</td>
</tr>
<tr>
  <td>checkbox</td>
  <td>many of many choices</td>
</tr>
<tr>
  <td>file</td>
  <td>file upload field</td>
</tr>
<tr>
  <td>submit</td>
  <td>for submitting the form</td>
</tr>
<tr>
  <td>reset</td>
  <td>resetting the form</td>
</tr>
<tr>
  <td>datetime</td>
  <td>datetime selector - <strong>HTML5</strong></td>
</tr>
<tr>
  <td>search</td>
  <td>search input - <strong>HTML5</strong></td>
</tr>
<tr>
  <td>tel</td>
  <td>phone number input - <strong>HTML5</strong></td>
</tr>
<tr>
  <td>color</td>
  <td>color palette selector - <strong>HTML5</strong></td>
</tr>
</tbody></table>




<pre class="prettyprint"><code class=" hljs ocaml">&lt;input name=<span class="hljs-string">"gender"</span> <span class="hljs-class"><span class="hljs-keyword">type</span>=</span><span class="hljs-string">"radio"</span> <span class="hljs-keyword">value</span>=”male”/&gt;Male &lt;input name=<span class="hljs-string">"gender"</span> <span class="hljs-class"><span class="hljs-keyword">type</span>=</span><span class="hljs-string">"radio"</span> <span class="hljs-keyword">value</span>=”female”/&gt;Female&lt;input <span class="hljs-class"><span class="hljs-keyword">type</span>=</span><span class="hljs-string">"radio"</span> name=<span class="hljs-string">"gender"</span> <span class="hljs-keyword">value</span>=<span class="hljs-string">"other"</span>&gt; Other</code></pre>



<h5 id="input-element-validation-attributes">Input element validation attributes</h5>

<table>
<thead>
<tr>
  <th>Attr</th>
  <th>Desc</th>
  <th>Example</th>
</tr>
</thead>
<tbody><tr>
  <td>required</td>
  <td>Cannot be passed blank</td>
  <td></td>
</tr>
<tr>
  <td>pattern</td>
  <td>Enforce regex pattern</td>
  <td>^<a href="http://.+">http://.+</a></td>
</tr>
<tr>
  <td>min</td>
  <td>Min value for number or range type of inputs</td>
  <td></td>
</tr>
<tr>
  <td>max</td>
  <td>Max value for number or range type of inputs</td>
  <td></td>
</tr>
</tbody></table>




<pre class="prettyprint"><code class=" hljs css"><span class="hljs-tag">input</span><span class="hljs-pseudo">:required</span><span class="hljs-pseudo">:invalid</span>, <span class="hljs-tag">input</span><span class="hljs-pseudo">:focus</span><span class="hljs-pseudo">:invalid</span> <span class="hljs-rules">{
  <span class="hljs-rule"><span class="hljs-attribute">-moz-box-shadow</span>:<span class="hljs-value"> none</span></span>;
<span class="hljs-rule">}</span></span>
<span class="hljs-tag">input</span><span class="hljs-pseudo">:required</span><span class="hljs-pseudo">:valid</span> <span class="hljs-rules">{
  <span class="hljs-comment">/* insert your own styles for valid form input */</span>
<span class="hljs-rule">}</span></span></code></pre>

<blockquote>
  <p>Some patterns for validation</p>
  
  <ul>
  <li>IPv4 - \d{1,3}.\d{1,3}.\d{1,3}.\d{1,3}</li>
  <li>Date - \d{1,2}/\d{1,2}/\d{4}</li>
  <li>Price - \d+(.\d{2})?</li>
  </ul>
</blockquote>



<h4 id="form-attributes">Form Attributes</h4>

<table>
<thead>
<tr>
  <th>Attr</th>
  <th>Desc</th>
  <th>Example</th>
</tr>
</thead>
<tbody><tr>
  <td>action</td>
  <td>action to be performed when form is submitted</td>
  <td></td>
</tr>
<tr>
  <td>method</td>
  <td>specifies HTML method (POST or GET - default)</td>
  <td></td>
</tr>
<tr>
  <td>autocomplete</td>
  <td>enables or disables autocomplete</td>
  <td>on/off</td>
</tr>
<tr>
  <td>novalidate</td>
  <td>disables validation</td>
  <td></td>
</tr>
<tr>
  <td>accept-charset</td>
  <td>charset of the data transferred with the form</td>
  <td>UTF-8</td>
</tr>
<tr>
  <td>enctype</td>
  <td>specifies encoding of the data</td>
  <td>application/x-www-form-urlencoded</td>
</tr>
</tbody></table>




<h4 id="other-new-elements-used-in-forms">Other new elements used in forms</h4>



<h5 id="keygen">keygen</h5>

<p>Keygen element provides a secure way to authenticate user. </p>

<blockquote>
  <p><strong>No Microsoft Edge support</strong></p>
</blockquote>



<pre class="prettyprint"><code class=" hljs xml"><span class="hljs-tag">&lt;<span class="hljs-title">form</span> <span class="hljs-attribute">action</span>=<span class="hljs-value">"action_page.php"</span>&gt;</span>
  Username: <span class="hljs-tag">&lt;<span class="hljs-title">input</span> <span class="hljs-attribute">type</span>=<span class="hljs-value">"text"</span> <span class="hljs-attribute">name</span>=<span class="hljs-value">"user"</span>&gt;</span>
  Encryption: <span class="hljs-tag">&lt;<span class="hljs-title">keygen</span> <span class="hljs-attribute">name</span>=<span class="hljs-value">"security"</span>&gt;</span>
  <span class="hljs-tag">&lt;<span class="hljs-title">input</span> <span class="hljs-attribute">type</span>=<span class="hljs-value">"submit"</span>&gt;</span>
<span class="hljs-tag">&lt;/<span class="hljs-title">form</span>&gt;</span></code></pre>



<h5 id="output">output</h5>

<blockquote>
  <p><strong>No Microsoft Edge support</strong></p>
</blockquote>



<pre class="prettyprint"><code class=" hljs xml"><span class="hljs-tag">&lt;<span class="hljs-title">form</span> <span class="hljs-attribute">oninput</span>=<span class="hljs-value">"x.value=parseInt(a.value)+parseInt(b.value)"</span>&gt;</span>
  0
  <span class="hljs-tag">&lt;<span class="hljs-title">input</span> <span class="hljs-attribute">type</span>=<span class="hljs-value">"range"</span>  <span class="hljs-attribute">id</span>=<span class="hljs-value">"a"</span> <span class="hljs-attribute">name</span>=<span class="hljs-value">"a"</span> <span class="hljs-attribute">value</span>=<span class="hljs-value">"50"</span>&gt;</span>
  100 +
  <span class="hljs-tag">&lt;<span class="hljs-title">input</span> <span class="hljs-attribute">type</span>=<span class="hljs-value">"number"</span> <span class="hljs-attribute">id</span>=<span class="hljs-value">"b"</span> <span class="hljs-attribute">name</span>=<span class="hljs-value">"b"</span> <span class="hljs-attribute">value</span>=<span class="hljs-value">"50"</span>&gt;</span>
  =
  <span class="hljs-tag">&lt;<span class="hljs-title">output</span> <span class="hljs-attribute">name</span>=<span class="hljs-value">"x"</span> <span class="hljs-attribute">for</span>=<span class="hljs-value">"a b"</span>&gt;</span><span class="hljs-tag">&lt;/<span class="hljs-title">output</span>&gt;</span>
  <span class="hljs-tag">&lt;<span class="hljs-title">br</span>&gt;</span><span class="hljs-tag">&lt;<span class="hljs-title">br</span>&gt;</span>
  <span class="hljs-tag">&lt;<span class="hljs-title">input</span> <span class="hljs-attribute">type</span>=<span class="hljs-value">"submit"</span>&gt;</span>
<span class="hljs-tag">&lt;/<span class="hljs-title">form</span>&gt;</span></code></pre>



<h3 id="references">References</h3>

<p><a href="http://www.w3schools.com/">W3C Standards and Tutorials</a> <br>
<a href="http://www.the-art-of-web.com/html/html5-form-validation/">Validations with HTML5 attributes</a> <br>
<a href="http://www.the-art-of-web.com/javascript/validate/">Validations using JavaScript</a></p>