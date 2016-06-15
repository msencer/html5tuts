var Game = function(seed){
	var number = random(seed), // a random number between 1-11
		score = 1000; 

	this.seed = seed;
	this.guess = function(playerGuess)	{
		if(score<=0)
			return {"stat" : false, "score":score};;
		var stat = false;
		var diff = Math.abs(playerGuess - number);
		switch(diff){
			case 0:
				stat = true;
				break;
			case 1:
				score-=20;
				break;
			case 2:
				score-=50;
				break;
			default:
				score-=100;
				break;
		}
		return {"stat" : stat, "score":score};
	};
	this.restart = function(){
		number = random(this.seed);
		score = 1000;
	};
	
	function random(seed){
		return Math.ceil(Math.random() * seed);
	}

	return this;
}