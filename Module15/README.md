<h1 id="programming-in-html-5-with-javascript-and-css3">Programming in HTML 5 with Javascript and CSS3</h1>

<p><div class="toc">
<ul>
<li><a href="#programming-in-html-5-with-javascript-and-css3">Programming in HTML 5 with Javascript and CSS3</a><ul>
<li><a href="#module-15">Module 15</a><ul>
<li><a href="#what-are-sses">What are SSEs?</a></li>
<li><a href="#sses-vs-ws">SSEs vs WS?</a></li>
<li><a href="#how-to-use-sses">How to use SSEs?</a></li>
<li><a href="#event-stream-format">Event Stream Format</a></li>
<li><a href="#references">References</a></li>
</ul>
</li>
</ul>
</li>
</ul>
</div>
</p>

<h2 id="module-15">Module 15</h2>

<p>In this module, we’ll look at data transfer between server and client using Server-Sent Events.</p>



<h3 id="what-are-sses">What are SSEs?</h3>

<p>Using SSEs, a server can push data to your app whenever it wants, without the need to make an initial request. In other words, updates can be streamed from server to client as they happen. SSEs open a single unidirectional channel between server and client.</p>

<p>“The main difference between Server-Sent Events and long-polling is that SSEs are handled directly by the browser and the user simply has to listen for messages.”</p>



<h3 id="sses-vs-ws">SSEs vs WS?</h3>

<p>SSE has been kept in the shadow of WS. WS provide richer communication option than SSEs. WSs have two way communication channel while SSEs have one way (server - client)</p>



<h3 id="how-to-use-sses">How to use SSEs?</h3>



<pre class="prettyprint"><code class=" hljs fsharp"><span class="hljs-keyword">if</span> (!!window.EventSource) {
  var source = <span class="hljs-keyword">new</span> EventSource(url');
} <span class="hljs-keyword">else</span> {
    <span class="hljs-comment">// AJAX polling!</span>
}</code></pre>

<p>Events of SSE object that can be used are:</p>

<table>
<thead>
<tr>
  <th>Event</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>onopen()</td>
  <td>event is triggered when the connection is established</td>
</tr>
<tr>
  <td>onerror(error)</td>
  <td>event is triggered when an exception is raised</td>
</tr>
<tr>
  <td>onmessage(e)</td>
  <td>event is triggered when a message is received</td>
</tr>
</tbody></table>




<pre class="prettyprint"><code class=" hljs javascript">source.addEventListener(<span class="hljs-string">'message'</span>, <span class="hljs-function"><span class="hljs-keyword">function</span><span class="hljs-params">(e)</span> {</span>
  console.log(e.data);
}, <span class="hljs-literal">false</span>);

source.addEventListener(<span class="hljs-string">'open'</span>, <span class="hljs-function"><span class="hljs-keyword">function</span><span class="hljs-params">(e)</span> {</span>
  <span class="hljs-comment">// Connection was opened.</span>
}, <span class="hljs-literal">false</span>);

source.addEventListener(<span class="hljs-string">'error'</span>, <span class="hljs-function"><span class="hljs-keyword">function</span><span class="hljs-params">(e)</span> {</span>
  <span class="hljs-keyword">if</span> (e.readyState == EventSource.CLOSED) {
    <span class="hljs-comment">// Connection was closed.</span>
  }
}, <span class="hljs-literal">false</span>);

</code></pre>



<h3 id="event-stream-format">Event Stream Format</h3>

<p>Sending an event stream from the source is a matter of constructing a plaintext response, served with a text/event-stream Content-Type, that follows the SSE format.</p>



<pre class="prettyprint"><code class=" hljs http"><span class="hljs-attribute">data</span>: <span class="hljs-string">{\n</span>
<span class="hljs-attribute">data</span>: <span class="hljs-string">"msg": "hello world",\n</span>
<span class="hljs-attribute">data</span>: <span class="hljs-string">"id": 12345\n</span>
<span class="hljs-attribute">data</span>: <span class="hljs-string">}\n\n</span></code></pre>



<pre class="prettyprint"><code class=" hljs lasso">source<span class="hljs-built_in">.</span>addEventListener(<span class="hljs-string">'message'</span>, function(e) {
  <span class="hljs-built_in">var</span> <span class="hljs-built_in">data</span> <span class="hljs-subst">=</span> JSON<span class="hljs-built_in">.</span>parse(e<span class="hljs-built_in">.</span><span class="hljs-built_in">data</span>);
  console<span class="hljs-built_in">.</span><span class="hljs-keyword">log</span>(<span class="hljs-built_in">data</span><span class="hljs-built_in">.</span>id, <span class="hljs-built_in">data</span><span class="hljs-built_in">.</span>msg);
}, <span class="hljs-literal">false</span>);</code></pre>

<p>We can specify event names.</p>



<pre class="prettyprint"><code class=" hljs avrasm"><span class="hljs-label">event:</span> update\n
<span class="hljs-label">data:</span> {<span class="hljs-string">"username"</span>: <span class="hljs-string">"John123"</span>, <span class="hljs-string">"emotion"</span>: <span class="hljs-string">"happy"</span>}\n\n</code></pre>



<pre class="prettyprint"><code class=" hljs lasso">source<span class="hljs-built_in">.</span>addEventListener(<span class="hljs-string">'update'</span>, function(e) {
  <span class="hljs-built_in">var</span> <span class="hljs-built_in">data</span> <span class="hljs-subst">=</span> JSON<span class="hljs-built_in">.</span>parse(e<span class="hljs-built_in">.</span><span class="hljs-built_in">data</span>);
  console<span class="hljs-built_in">.</span><span class="hljs-keyword">log</span>(<span class="hljs-built_in">data</span><span class="hljs-built_in">.</span>username <span class="hljs-subst">+</span> <span class="hljs-string">' is now '</span> <span class="hljs-subst">+</span> <span class="hljs-built_in">data</span><span class="hljs-built_in">.</span>emotion);
}, <span class="hljs-literal">false</span>);</code></pre>



<h3 id="references">References</h3>

<p><a href="http://www.html5rocks.com/en/tutorials/eventsource/basics/">HTML5 Rocks!</a></p>

<p><a href="http://blogs.microsoft.co.il/gilf/2012/04/10/using-html5-server-sent-events-with-json-and-aspnet-mvc/">MVC Example</a></p>