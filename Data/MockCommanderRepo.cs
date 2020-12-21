using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    // Hard coded data for testing
    public class MockCommanderRepo : ICommanderRepo
    {
        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle" },
                new Command { id = 0, HowTo = "Cur bread", Line = "Use a knife", Platform = "Board" },
                new Command { id = 0, HowTo = "Make tea", Line = "Teabag", Platform = "Cup" },
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle" };
        }

        void ICommanderRepo.CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        bool ICommanderRepo.SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
