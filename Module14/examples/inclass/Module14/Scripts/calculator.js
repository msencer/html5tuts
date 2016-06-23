addEventListener("message", function (e) {
    switch (e.data.islem) {
        case "+":
            postMessage(e.data.sayi1 + e.data.sayi2);
            break;
        case "-":
            postMessage(e.data.sayi1 - e.data.sayi2);
            break;
        case "*":
            postMessage(e.data.sayi1 * e.data.sayi2);
            break;
        case "/":
            postMessage(parseInt(e.data.sayi1 / e.data.sayi2));
            break;
        default:
            break;
    }
});