namespace Lib
{
    public class Observatory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int TelescopesCount { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Name} ({Location}) - Telescopes: {TelescopesCount}";
        }
    }
}