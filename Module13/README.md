<h1 id="programming-in-html-5-with-javascript-and-css3">Programming in HTML 5 with Javascript and CSS3</h1>

<p><div class="toc">
<ul>
<li><a href="#programming-in-html-5-with-javascript-and-css3">Programming in HTML 5 with Javascript and CSS3</a><ul>
<li><a href="#module-13">Module 13</a><ul>
<li><a href="#why-to-use-ws">Why to use WS?</a></li>
<li><a href="#how-to-use-ws">How to use WS?</a></li>
<li><a href="#references">References</a></li>
</ul>
</li>
</ul>
</li>
</ul>
</div>
</p>



<h2 id="module-13">Module 13</h2>

<p>In this module, we’ll look at data transfer between client and server using WebSocket protocol. </p>



<h3 id="why-to-use-ws">Why to use WS?</h3>

<p>Even with the introduction of AJAX all HTTP communication between client and server was steered by the client. Then long polling technique came along. “With long polling, the client opens an HTTP connection to the server which keeps it open until sending response.”</p>

<p>Although long polling seems to work, these all techniques carry the overhead of HTTP, which is pretty bad for low latency applications</p>

<p>In summary, by using <strong>WS</strong> we establish a persistent connection between the client and the server and both parties can start sending data at any time.</p>



<h3 id="how-to-use-ws">How to use WS?</h3>

<p>To be able to establish a WebSocket connection we need a <strong>WebSocket</strong> object. </p>



<pre class="prettyprint"><code class=" hljs cs"><span class="hljs-keyword">var</span> connection = <span class="hljs-keyword">new</span> WebSocket(<span class="hljs-string">'ws://html5rocks.websocket.org/echo'</span>)</code></pre>

<p>Events of WebSocket object that can be used are:</p>

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




<pre class="prettyprint"><code class=" hljs lua">connection.onopen = <span class="hljs-function"><span class="hljs-keyword">function</span> <span class="hljs-params">()</span></span> {
  connection.send(<span class="hljs-string">'Ping'</span>); // Send the message <span class="hljs-string">'Ping'</span> to the server
};

connection.onerror = <span class="hljs-function"><span class="hljs-keyword">function</span> <span class="hljs-params">(error)</span></span> {
  console.log(<span class="hljs-string">'WebSocket Error '</span> + <span class="hljs-built_in">error</span>);
};

connection.onmessage = <span class="hljs-function"><span class="hljs-keyword">function</span> <span class="hljs-params">(e)</span></span> {
  console.log(<span class="hljs-string">'Server: '</span> + e.data);
};
</code></pre>



<pre class="prettyprint"><code class=" hljs perl">connection.<span class="hljs-keyword">send</span>(<span class="hljs-string">'your message'</span>);</code></pre>



<h3 id="references">References</h3>

<p><a href="http://www.html5rocks.com/en/tutorials/websockets/basics/">HTML5 Rocks!</a> <br>
<a href="https://tools.ietf.org/html/rfc6455">IEFT Standard</a></p>