using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command{Id=0, HowTo="Boil an egg", Line="Boil", Platform="Pan"},
                new Command{Id=1, HowTo="Boil an plate", Line="Boil", Platform="Plate"},
                new Command{Id=2, HowTo="Boil an t-shirt", Line="Boil", Platform="Pan"}
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command{Id=0, HowTo="Boil an egg", Line="Boil", Platform="Pan"};
        }
    }
}