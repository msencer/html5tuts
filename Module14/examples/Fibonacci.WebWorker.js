
var results = [];

function messageHandler(message) {
    if (message.data > 0) {
        generateFibonacciSeries(message.data);
    }
}

function generateFibonacciSeries(n) {
    for (var i = 0; i < n; i++) {
        results.push(calculateNextFibo(i));
    }
    postMessage(results);
}

function calculateNextFibo(i) {
    if (i == 0)
        return 0;
    if (i == 1) {
        return 1;
    }
    else {
        return calculateNextFibo(i - 1) + calculateNextFibo(i - 2);
    }
}


addEventListener("message", messageHandler);