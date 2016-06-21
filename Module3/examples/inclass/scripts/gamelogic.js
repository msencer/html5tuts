"use strict";
var Game = function (seed) {
    var score = 1000,
        randomSayi = random(seed);

    this.guess = function (userGuess) {
        var guess =userGuess;
        var diff = Math.abs(guess - randomSayi);
        var feedback = {};

        switch (diff) {
            case 0:
                feedback.status = true;      
                break;
            case 1:
                score -= 20;
                feedback.status = false;
                break;
            case 2:
                score -= 50;
                feedback.status = false;
                break;
            default:
                score -= 100;
                feedback.status = false;
                break;
        }
        if (score <= 0) {
            feedback.status = true;
        }

        feedback.score = score;

        return feedback;
    }

    this.restart = function () {
        score = 1000;
        randomSayi = random(seed);
    };

    function random(seed) {
        return Math.ceil(Math.random() * seed);
    };

    return this;
};