addEventListener("message", function (e) {
    tick(e.data);
});

function tick(seed) {
    var current = seed;
    setInterval(function () {
        current += 1;
        postMessage(current);
    }, 1000);
}