namespace TyrelsHelloWorld;

partial class Program
{
    interface IPokemonData
    {
        string Name { get; set; }
        int Health { get; set; }
        int Attack { get; set; }
        int Defense { get; set; }
        int Speed { get; set; }
        PokemonData.Choices Type { get; set; }
    }
}
