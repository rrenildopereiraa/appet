namespace Lib
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public string Owner { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Name} ({Species}) - Owner: {Owner}";
        }
    }
}