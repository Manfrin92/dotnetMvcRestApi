namespace Commander.Dtos 
{
    public class CommandReadDto 
    {
        public int Id { get; set; }

        public string HowTo { get; set; }

        public string Line { get; set; }

        // Suposing this should not return to the client
        // public string Platform { get; set; }
    }
}