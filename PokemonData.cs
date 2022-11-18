namespace TyrelsHelloWorld;

partial class Program
{

    //impliment IPokemon interface

    #region Pokemon Class
    // create a pokemon class
    class PokemonData : IPokemonData
    {
        public enum Choices : int
        {
            WATER = 1,
            FIRE,
            GRASS
        }
        // create a constructor
        public PokemonData(string name, int health, int attack, int defense, int speed, int type)
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
            Speed = speed;
            Type = (Choices)type;

        }
        // create properties
        public string Name { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public Choices Type { get; set; }
    }
    #endregion
}
