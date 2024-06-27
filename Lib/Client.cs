namespace Lib
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        //TODO: grab the animals from the Class Animals

        public override string ToString()
        {
            return $"{Id}: {Name} ({Address}) - {Phone}";
        }
    }
}