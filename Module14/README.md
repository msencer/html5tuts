<h1 id="programming-in-html-5-with-javascript-and-css3">Programming in HTML 5 with Javascript and CSS3</h1>

<p><div class="toc">
<ul>
<li><a href="#programming-in-html-5-with-javascript-and-css3">Programming in HTML 5 with Javascript and CSS3</a><ul>
<li><a href="#module-14">Module 14</a><ul>
<li><a href="#web-workers">Web workers</a></li>
<li><a href="#how-to-use-web-workers">How to use Web Workers?</a></li>
<li><a href="#references">References</a></li>
</ul>
</li>
</ul>
</li>
</ul>
</div>
</p>



<h2 id="module-14">Module 14</h2>

<p>In this module, we’ll look at background working Javascript using Web Workers.</p>



<h3 id="web-workers">Web workers</h3>

<p>JavaScript is a single-threaded environment, meaning multiple scripts cannot run at the same time. Developers mimic ‘concurrency’ by using techniques like setTimeout(),setInterval(), XMLHttpRequest, and event handlers. </p>

<p>The Web Workers specification defines an API for spawning background scripts in your web application. Web Workers allow you to do things like fire up long-running scripts to handle computationally intensive tasks, but without blocking the UI or other scripts to handle user interactions.</p>



<h3 id="how-to-use-web-workers">How to use Web Workers?</h3>

<p>We need to define a web worker object first.</p>



<pre class="prettyprint"><code class=" hljs cs"><span class="hljs-keyword">var</span> worker = <span class="hljs-keyword">new</span> Worker(<span class="hljs-string">'task.js'</span>);</code></pre>

<p>In order to communicate with the worker, we use messaging technique.</p>



<pre class="prettyprint"><code class=" hljs javascript"><span class="hljs-keyword">var</span> worker = <span class="hljs-keyword">new</span> Worker(<span class="hljs-string">'doWork.js'</span>);

worker.addEventListener(<span class="hljs-string">'message'</span>, <span class="hljs-function"><span class="hljs-keyword">function</span><span class="hljs-params">(e)</span> {</span>
  console.log(<span class="hljs-string">'Worker said: '</span>, e.data);
}, <span class="hljs-literal">false</span>);

worker.postMessage(<span class="hljs-string">'Hello World'</span>);</code></pre>



<pre class="prettyprint"><code class=" hljs php"><span class="hljs-keyword">self</span>.addEventListener(<span class="hljs-string">'message'</span>, <span class="hljs-function"><span class="hljs-keyword">function</span><span class="hljs-params">(e)</span> {</span>
  <span class="hljs-keyword">self</span>.postMessage(e.data);
}, <span class="hljs-keyword">false</span>);</code></pre>



<h3 id="references">References</h3>

<p><a href="http://www.html5rocks.com/en/tutorials/workers/basics/">HTML5 Rocks!</a></p>