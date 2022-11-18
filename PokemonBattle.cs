namespace TyrelsHelloWorld;

partial class Program
{

    //create a pokemon battle class
    class PokemonBattle 
    {
        // create a constructor
        public PokemonBattle(PokemonData pokemon1, PokemonData pokemon2, string pokemonImage)
        {
            Pokemon1 = pokemon1;
            Pokemon2 = pokemon2;
            this.pokemonImage = pokemonImage;
        }
        // create properties
        public PokemonData Pokemon1 { get; set; }
        public PokemonData Pokemon2 { get; set; }

        public string pokemonImage;
        // create a method that will run the battle
        public void RunBattle()
        {
                // create a variable to hold the pokemon that attacks first
                PokemonData firstAttacker;
                PokemonData secondAttacker;
            // create a loop that will run until one pokemon faints
            while (Pokemon1.Health > 0 && Pokemon2.Health > 0)
            {
                System.Console.WriteLine(pokemonImage);
                // check to see which pokemon has the higher speed
                if (Pokemon1.Speed > Pokemon2.Speed)
                {
                    firstAttacker = Pokemon1;
                    secondAttacker = Pokemon2;
                }
                else
                {
                    firstAttacker = Pokemon2;
                    secondAttacker = Pokemon1;
                }
                // have the first attacker attack the second attacker
                Console.WriteLine($"{firstAttacker.Name} attacks {secondAttacker.Name}");
                // calculate the damage
                int damage = firstAttacker.Attack - secondAttacker.Defense;

                //if pokemone has type advantage double the damage
                if (firstAttacker.Type == secondAttacker.Type)
                {
                }
                else if ((int)firstAttacker.Type == 1 && (int)secondAttacker.Type == 2 || (int)firstAttacker.Type == 2 && (int)secondAttacker.Type == 3 || (int)firstAttacker.Type == 3 && (int)secondAttacker.Type == 1)
                {
                    damage *= 2;
                }
                else
                {
                    damage = Math.Max(damage / 2, 1);
                }
                //todo add critical attacks
                Random rnd = new Random();
                //todo adjust crit chance
                int rndNumber = rnd.Next(1, 6);
                if (rndNumber > 1)
                {
                    damage *= 2;
                    System.Console.WriteLine("Critical Hit!");
                }
                // check to see if the damage is greater than 0
                if (damage > 0)
                {
                    // subtract the damage from the second attackers health
                    secondAttacker.Health -= damage;
                    // display the damage done
                    Console.WriteLine($"{secondAttacker.Name} took {damage} damage");
                }
                else
                {
                    // display that the attack was ineffective
                    Console.WriteLine($"{secondAttacker.Name} took no damage");
                }
                // check to see if the second attacker has fainted
                if (secondAttacker.Health > 0)
                {
                    // have the second attacker attack the first attacker
                    Console.WriteLine($"{secondAttacker.Name} attacks {firstAttacker.Name}");
                    // calculate the damage
                    damage = secondAttacker.Attack - firstAttacker.Defense;
                    //if pokemone has type advantage double the damage
                    if (secondAttacker.Type == firstAttacker.Type)
                    {
                    }
                    else if ((int)secondAttacker.Type == 1 && (int)firstAttacker.Type == 2 || (int)secondAttacker.Type == 2 && (int)firstAttacker.Type == 3 || (int)secondAttacker.Type == 3 && (int)firstAttacker.Type == 1)
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage = Math.Max(damage / 2, 1);
                    }
                    //todo add critical attacks
                    //todo adjust crit chance
                    rndNumber = rnd.Next(1, 6);
                    if (rndNumber > 1)
                    {
                        damage *= 2;
                        System.Console.WriteLine("Critical Hit!");
                    }

                    // check to see if the damage is greater than 0
                    if (damage > 0)
                    {
                        // subtract the damage from the first attackers health
                        firstAttacker.Health -= damage;
                        // display the damage done
                        Console.WriteLine($"{firstAttacker.Name} took {damage} damage");
                    }
                }
                     System.Console.WriteLine($"\nPress enter to continue battle.\n" +
                      $"{firstAttacker.Name}'s current health is {firstAttacker.Health}.\n" +
                      $"{secondAttacker.Name}'s current health is {secondAttacker.Health}.");
                     Console.ReadLine();

            }
            if(Pokemon1.Health <= 0)
            {
                System.Console.WriteLine(Pokemon1.Name + " Has Fainted");
            }
            else
            {
                System.Console.WriteLine(Pokemon2.Name + " Has Fainted");
            }
        }
    }
}
