namespace Lib
{
    public class Vet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialization { get; set; }
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Name} ({Specialization}) - {Phone}";
        }
    }
}