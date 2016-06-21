$(function () {
	
	$.fn.guessgame = function (seed) {
		var game = new Game(seed);

		var txtGuess = $("<input>").attr("type", "text").attr("placeholder", "Guess a number");
		var lblScore = $("<label>").text(1000);
		var btnRestart = $("<button>").text("Restart");
		var history = $("<ul>");


		txtGuess.change(function () {
			var tahmin = parseInt($(this).val());

			var result = game.guess(tahmin);
			var historyItem = $("<li>");
			if (result.status) {
				if (result.score <= 0)
					historyItem.text("Oyun bitt!").addClass("incorrect");
				else {
					historyItem.text("Doğru tahmin").addClass("correct");
					$(this).attr("disabled", true);
				}
			}
			else {
				historyItem.text("Yanlış tahmin!").addClass("incorrect");
			}

			history.append(historyItem);
			lblScore.text(result.score);
			$(this).val("");
		});

		btnRestart.click(function () {
			game.restart();
			txtGuess.prop("disabled", false);
			history.empty();
			lblScore.text("1000");
		});

		$(this).append(txtGuess);
		$(this).append(lblScore);
		$(this).append(btnRestart);
		$(this).append(history);

		txtGuess.focus();
	}

});