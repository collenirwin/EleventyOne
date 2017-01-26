using System.Collections.Generic;

namespace EleventyOne {

    public enum Difficulty {
        idiot,
        coward,
        cautious,
        medium,
        aggressive
    }

    /// <summary>
    /// An artificial Eleventy One player
    /// </summary>
    public class AIPlayer : Player {

        #region names

        private static List<string> _names = new List<string>() {
            "Charmain",
            "Cecil",
            "Hobert",
            "Loralee",
            "Erinn",
            "Travis",
            "Anneliese",
            "Lenny",
            "Tova",
            "Jerome",
            "Sirena",
            "Doris",
            "Mckenzie",
            "Lajuana",
            "Giuseppina",
            "Florentina",
            "Filiberto",
            "Beula",
            "May",
            "Louella",
            "Cathy",
            "Hellen",
            "Alyssa",
            "Damion",
            "Vernetta",
            "Josiah",
            "Junko",
            "Shawanna",
            "Elida",
            "Bobette",
            "Keely",
            "Bryant",
            "Remona",
            "Sharika",
            "Ollie",
            "Basil",
            "Samatha",
            "Lucienne",
            "Kristofer",
            "Alda",
            "Genie",
            "Kathrine",
            "Jammie",
            "Benedict",
            "Dana",
            "Sophie",
            "Dell",
            "Carma",
            "Georgie",
            "Armando",
            "Larry"
        };

        private static List<string> _namesInUse = new List<string>();

        /// <summary>
        /// Clears the list of AI names in use
        /// </summary>
        public static void clearNames() {
            _namesInUse.Clear();
        }

        #endregion

        public Difficulty difficulty { get; private set; }

        private AIPlayer(Difficulty difficulty) : base("") {

            this.difficulty = difficulty;

            // generate a unique name
            while (true) {
                string name = "[bot] " + _names[Game.dice.Next(_names.Count)];

                if (!_namesInUse.Contains(name)) {
                    this.name = name;
                    break;
                }
            }
        }

        /// <summary>
        /// Calculates whether the AI should roll again based on its difficulty
        /// </summary>
        public bool rollAgain() {

            bool willRoll = false;

            if (difficulty == Difficulty.idiot) {
                willRoll = true; // always rolls

            } else if (difficulty == Difficulty.coward) {
                if (rolls < 1) { // rolls once / round
                    willRoll = true;
                }

            } else if (difficulty == Difficulty.cautious) {
                if (Game.dice.NextDouble() <= 0.33) { // 33% chance to roll
                    willRoll = true;
                }

            } else if (difficulty == Difficulty.medium) {
                if (Game.dice.NextDouble() <= 0.5) { // 50% chance to roll
                    willRoll = true;
                }

            } else { // aggressive
                if (Game.dice.NextDouble() <= 0.66) { // 66% chance to roll
                    willRoll = true;
                }
            }

            return willRoll;
        }
    }
}
