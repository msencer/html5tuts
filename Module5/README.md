<h1 id="programming-in-html-5-with-javascript-and-css3">Programming in HTML 5 with Javascript and CSS3</h1>

<p><div class="toc">
<ul>
<li><a href="#programming-in-html-5-with-javascript-and-css3">Programming in HTML 5 with Javascript and CSS3</a><ul>
<li><a href="#module-5">Module 5</a><ul>
<li><a href="#what-is-ajax">What is AJAX?</a></li>
<li><a href="#pure-js-ajax-call">Pure JS AJAX Call</a><ul>
<li><a href="#get">GET</a></li>
<li><a href="#post">POST</a></li>
</ul>
</li>
<li><a href="#jquery-ajax-call">JQuery AJAX Call</a><ul>
<li><a href="#get-1">GET</a></li>
<li><a href="#post-1">POST</a></li>
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



<h2 id="module-5">Module 5</h2>

<p>In this module, we’ll look at data transfer between client and server using AJAX technology. We may achieve our goal by using pure javascript or using JQuery helper functions. </p>



<h3 id="what-is-ajax">What is AJAX?</h3>

<p><strong>AJAX(Asynchronous Javascript and XML)</strong> is a technique for creating fast and dynamic pages. Normally, in each HttpRequest made from client to server, whole page is loaded AJAX allows web pages to be updated asynchronously by exchanging small amounts of data with the server behind the scenes.</p>



<h3 id="pure-js-ajax-call">Pure JS AJAX Call</h3>

<p>To be able to make an AJAX call using pure JavaScript, we need to use <strong>XMLHttpRequest</strong> object. </p>



<pre class="prettyprint"><code class=" hljs vhdl"><span class="hljs-keyword">variable</span> = <span class="hljs-keyword">new</span> XMLHttpRequest();</code></pre>

<p>For older versions of IE (IE5 &amp; IE6)</p>



<pre class="prettyprint"><code class=" hljs vhdl"><span class="hljs-keyword">variable</span> = <span class="hljs-keyword">new</span> ActiveXObject(<span class="hljs-string">"Microsoft.XMLHTTP"</span>);</code></pre>

<p>Methods of XMLHttpRequest object that can be used are:</p>

<table>
<thead>
<tr>
  <th>Method</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>open(method,url,asyc)</td>
  <td>specifies the type of the request</td>
</tr>
<tr>
  <td>send()</td>
  <td>sends the request (for GET requests)</td>
</tr>
<tr>
  <td>send(string)</td>
  <td>sends the request (for POST requests)</td>
</tr>
</tbody></table>


<p>If you set <strong>async</strong> parameter of open function to true then you must specify an event handler for <strong>onreadystatechange</strong> event. Otherwise, using <strong>responseText</strong> property of the XMLHttpRequest object is enough to retrieve the result of the response.</p>

<p>Other important properties of the XMLHttpRequest are <em>readyState</em> and <em>status</em>. </p>

<table>
<thead>
<tr>
  <th>State</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>0</td>
  <td>uninitialized</td>
</tr>
<tr>
  <td>1</td>
  <td>loading</td>
</tr>
<tr>
  <td>2</td>
  <td>loaded</td>
</tr>
<tr>
  <td>3</td>
  <td>interactive</td>
</tr>
<tr>
  <td>4</td>
  <td>ready</td>
</tr>
</tbody></table>


<table>
<thead>
<tr>
  <th>Status</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>200</td>
  <td>OK</td>
</tr>
<tr>
  <td>201</td>
  <td>Created</td>
</tr>
<tr>
  <td>404</td>
  <td>Not Found</td>
</tr>
<tr>
  <td>500</td>
  <td>Server Error</td>
</tr>
</tbody></table>




<h4 id="get">GET</h4>

<p><strong>async=true</strong></p>



<pre class="prettyprint"><code class=" hljs avrasm">xhttp<span class="hljs-preprocessor">.onreadystatechange</span> = function() {
  if (xhttp<span class="hljs-preprocessor">.readyState</span> == <span class="hljs-number">4</span> &amp;&amp; xhttp<span class="hljs-preprocessor">.status</span> == <span class="hljs-number">200</span>) {
    document<span class="hljs-preprocessor">.getElementById</span>(<span class="hljs-string">"demo"</span>)<span class="hljs-preprocessor">.innerHTML</span> = xhttp<span class="hljs-preprocessor">.responseText</span><span class="hljs-comment">;</span>
  }
}<span class="hljs-comment">;</span>
xhttp<span class="hljs-preprocessor">.open</span>(<span class="hljs-string">"GET"</span>, <span class="hljs-string">"demo.aspx"</span>, true)<span class="hljs-comment">;</span>
xhttp<span class="hljs-preprocessor">.send</span>()<span class="hljs-comment">;</span>
</code></pre>

<p><strong>async=false</strong></p>



<pre class="prettyprint"><code class=" hljs avrasm">xhttp<span class="hljs-preprocessor">.open</span>(<span class="hljs-string">"GET"</span>, <span class="hljs-string">"demo.aspx"</span>, false)<span class="hljs-comment">;</span>
xhttp<span class="hljs-preprocessor">.send</span>()<span class="hljs-comment">;</span>
document<span class="hljs-preprocessor">.getElementById</span>(<span class="hljs-string">"demo"</span>)<span class="hljs-preprocessor">.innerHTML</span> = xhttp<span class="hljs-preprocessor">.responseText</span><span class="hljs-comment">;</span></code></pre>



<h4 id="post">POST</h4>

<p>In POST request we assume that you are sending data within the packet. So we need to specify the type of the data that we are sending.</p>



<pre class="prettyprint"><code class=" hljs avrasm">xhttp<span class="hljs-preprocessor">.open</span>(<span class="hljs-string">"POST"</span>, <span class="hljs-string">"demo.aspx"</span>, true)<span class="hljs-comment">;</span>
xhttp<span class="hljs-preprocessor">.setRequestHeader</span>(<span class="hljs-string">"Content-type"</span>, <span class="hljs-string">"application/x-www-form-urlencoded"</span>)<span class="hljs-comment">;</span>
xhttp<span class="hljs-preprocessor">.send</span>(<span class="hljs-string">"fname=Henry&amp;lname=Ford"</span>)<span class="hljs-comment">;</span></code></pre>



<h3 id="jquery-ajax-call">JQuery AJAX Call</h3>

<p>JQuery eases our job very much. As they promised in their motto we write less and do more!!</p>

<p>There are 3 functions that we may use to make AJAX calls. Namely</p>

<table>
<thead>
<tr>
  <th>Method</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>$.ajax()</td>
  <td>Performs an asynchronous HTTP (Ajax) request.</td>
</tr>
<tr>
  <td>$.get()</td>
  <td>Load data from the server using a HTTP GET request.</td>
</tr>
<tr>
  <td>$.post()</td>
  <td>Load data from the server using a HTTP POST request.</td>
</tr>
</tbody></table>


<p>In core both <strong>get()</strong> and <strong>post()</strong> uses <strong>ajax()</strong>.</p>

<p><strong>ajax()</strong> has a parameter called <strong>options</strong>. Options is a JSON object and its properties may be</p>

<table>
<thead>
<tr>
  <th>Property</th>
  <th>Desc</th>
</tr>
</thead>
<tbody><tr>
  <td>contentType</td>
  <td>The content type used when sending data to the server.</td>
</tr>
<tr>
  <td>data</td>
  <td>Specifies data to be sent to the server</td>
</tr>
<tr>
  <td>error(xhr,status,error)</td>
  <td>A function to run if the request fails.</td>
</tr>
<tr>
  <td>success(result,status,xhr)</td>
  <td>A function to be run when the request succeeds</td>
</tr>
<tr>
  <td>type</td>
  <td>Specifies the type of request. (GET or POST)</td>
</tr>
<tr>
  <td>url</td>
  <td>Specifies the URL to send the request to. Default is the current page</td>
</tr>
</tbody></table>




<h4 id="get-1">GET</h4>

<p>get() is a shortcut for </p>



<pre class="prettyprint"><code class=" hljs css">$<span class="hljs-class">.ajax</span>(<span class="hljs-rules">{
 <span class="hljs-rule"><span class="hljs-attribute">url</span>:<span class="hljs-value"> url,
 data: data,
 success: success,
 dataType: dataType
</span></span></span>});
</code></pre>



<h4 id="post-1">POST</h4>

<p>post() is a shortcut for</p>



<pre class="prettyprint"><code class=" hljs haskell">$.ajax({
 <span class="hljs-typedef"><span class="hljs-keyword">type</span>: "<span class="hljs-type">POST</span>",</span>
 url: url,
 <span class="hljs-typedef"><span class="hljs-keyword">data</span>: <span class="hljs-keyword">data</span>,</span>
 success: success,
 dataType: dataType
});</code></pre>

<p>An AJAX form submission example.</p>



<pre class="prettyprint"><code class=" hljs php"><span class="hljs-keyword">var</span> <span class="hljs-variable">$form</span> = $(e.target);
            $.ajax({
                url: <span class="hljs-variable">$form</span>.attr(<span class="hljs-string">'action'</span>),
                type: <span class="hljs-string">'POST'</span>,
                data: <span class="hljs-variable">$form</span>.serialize(),
                success: <span class="hljs-function"><span class="hljs-keyword">function</span><span class="hljs-params">(result)</span> {</span>

                }
            });
</code></pre>



<h3 id="references">References</h3>

<p><a href="http://www.w3schools.com/ajax/ajax_intro.asp">W3C Standards and Tutorials</a> <br>
<a href="http://code.tutsplus.com/articles/how-to-make-ajax-requests-with-raw-javascript--net-4855">AJAX example with pure JS</a></p>

<p>1</p>