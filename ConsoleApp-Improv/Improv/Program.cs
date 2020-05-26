using System;

namespace Improv
{
    class Program
    {
        static void Main(string[] args)
        {
            var ch = new string[9];
            var loc = new string[4];
            var act = new string[4];

            act = new string[] {
                    ("attacks the monsters"),
                    ("attemts to heal an ally"),
                    ("starts a fight"),
                    ("defends an ally/NPC"),
                    ("drinks a pint of ale")
                };
            
                
            loc = new string[] {
                    ("in the manor of an important public figure"),
                    ("in a bar"),
                    ("in a temple"),
                    ("in a dungeon"),
                    ("on a boat")
                };
            

            ch = new string[] {
                    ("Ramero Domine human barbarian"),
                    ("Amber Fireforge the dwarven cleric"),
                    ("Eberk Frostbeard the dwarven fighter"),
                    ("Fai Wan the human monk"),
                    ("Balasar Delmirev the dragonborn paladin"),
                    ("Varis Galanodel the elven ranger"),
                    ("Roscoe Tealeaf the halfling rogue"),
                    ("Enna Amastacia the elven sorcerer"),
                    ("Lerissa Hope the tiefling warlock"),
                    ("Eldon Ningel the gnome wizard")
                };
                
                int chRNG = RNG(ch.Length);
                int chRNG2 = RNG(ch.Length);

                while (chRNG == chRNG2) {
                    chRNG2 = RNG(ch.Length);
                }

                int locRNG = RNG(loc.Length);
                int actRNG = RNG(act.Length);
                
                Console.WriteLine(ch[chRNG] + " " + act[actRNG] + " " + loc[locRNG] + " with " + ch[chRNG2]);
        }

        public static int RNG(int max)
        {
            Random rng = new Random();
            return rng.Next(0, max);
        }
    }
}
