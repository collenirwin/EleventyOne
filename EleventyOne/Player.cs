using System;

namespace EleventyOne {

    /// <summary>
    /// A human Eleventy One player
    /// </summary>
    public class Player {

        public string name { get; protected set; }

        public int points { get; private set; }
        public int roundPoints { get; private set; }
        public int rolls { get; private set; }

        public Player(string name) {
            this.name = name;

            points = 0;
            roundPoints = 0;
            rolls = 0;
        }

        /// <summary>
        /// Roll the dice, and calculate the new score based on the number rolled
        /// </summary>
        /// <returns>what the player rolled</returns>
        public int roll() {

            // roll the dice
            int diceRoll = Game.dice.Next(1, 7);

            rolls++;

            // calculate new score
            if (diceRoll != 1) { // rolled anything other than 1
                roundPoints += diceRoll; // add to this round's points
            } else { // rolled a 1 -- bad luck
                roundPoints = 1; // round points become 1
                finishRound(); // round is over
            }

            return diceRoll;
        }

        /// <summary>
        /// End this player's turn
        /// </summary>
        public void finishRound() {
            points += roundPoints;
            roundPoints = 0;
            rolls = 0;
        }

        /// <summary>
        /// Has this player won the match?
        /// </summary>
        public bool hasWon() {
            return points >= 111;
        }
    }
}
