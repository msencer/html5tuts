using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Module5.BusinessLogic
{
    public class GuessResult
    {
        public bool Status { get; set; }
        public int Score { get; set; }
    }
    public class GameLogic
    {
        public int Seed { private get; set; }
        private int RandomNumber {  get;  set; }
        private int Score { get; set; }
        public GameLogic(int seed)
        {
            Seed = seed;
            Restart();
        }

        public GuessResult Guess(int guess)
        {
            var result = new GuessResult();
            var diff = Math.Abs(RandomNumber - guess);

            switch (diff)
            {
                case 0:
                    result.Status = true;
                    break;
                case 1:
                    result.Status = false;
                    Score -= 20;
                    break;
                case 2:
                    result.Status = false;
                    Score -= 50;
                    break;
                default:
                    result.Status = false;
                    Score -= 100;
                    break;
            }

            if(Score<=0)
                result.Status = true;

            result.Score = Score;

            return result;
        }

        public void Restart()
        {
            Score = 1000;
            RandomNumber = new Random().Next(1, Seed);
        }
    }
}