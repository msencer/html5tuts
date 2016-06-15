$(function(){
	'use strict';
	var game = Game(10);
	$.fn.guessgame = function (options) {
		var $window = $(window);
		var txtGuess = $("<input type='text'>").attr("placeholder","Guess a number");
		var lblScore = $("<label>");
		var btnRestart = $("<button>").html("Restart");
		var history = $("<ul>").attr("id","actions");
		$(this).append(
			$("<div>").addClass("row")
				.append($("<div>").addClass("col-md-4").append(txtGuess))
				.append($("<div>").addClass("col-md-2").append(lblScore))
				.append($("<div>").addClass("col-md-2").append(btnRestart)));
		$(this).append(
			$("<div>").addClass("row")
				.append($("<div>").addClass("col-md-12").append(history)));
		
		txtGuess.change(function(){
			var num = txtGuess.val();
			var res = game.guess(num);
			var historyItem = $("<li>");
			if(res.stat){
				historyItem.html("Congratulations!").addClass("correct");
				txtGuess.prop( "disabled", true );
			}
			else{
				historyItem.html("Wrong! Your current score : " + res.score).addClass("wrong");
			}

			lblScore.html(res.score);
			txtGuess.val("");
			history.append(historyItem);
		});	
		btnRestart.click(function(){
			game.restart();
			txtGuess.prop( "disabled", false );
			history.empty();
			lblScore.html("");
			txtGuess.val("");
		});
	};
});
