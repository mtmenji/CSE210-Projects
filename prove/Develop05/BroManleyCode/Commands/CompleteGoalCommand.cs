using System;
using System.Text;
using System.Collections.Generic;

namespace GoalSetter
{
    public class CompleteGoalCommand : Command
    {
        private Repository _repository;
        private Terminal _terminal;

        public CompleteGoalCommand(Repository repository, Terminal terminal)
        {
            _repository = repository;
            _terminal = terminal;
        }

        public override void Execute()
        {
            try 
            {
                if (_repository.GetAll().Count == 0)
                {
                    _terminal.WriteLine("There are no goals to display.");
                    return;
                }

                _terminal.WriteLine();

                _terminal.WriteLine("Select a goal to complete:");
                int _counter = 1;
                foreach(Goal goal in _repository.GetAll())
                {
                    _terminal.Write($"{_counter}. ");
                    _terminal.WriteLine(goal.GetName());
                    _counter += 1;
                }

                int userChoice = _terminal.ReadInt("GS> ");
                List<Goal> listOfGoals = _repository.GetAll();
                listOfGoals[userChoice-1].MarkComplete();
                listOfGoals[userChoice-1].AddPoints(listOfGoals[userChoice-1].GetPoints());

                _terminal.WriteLine("Your goal has been completed!\n");
            }
            catch (Exception e)
            {
                _terminal.WriteLine($"Couldn't complete the goal. {e.Message}");
            }
        }

        public override string GetName()
        {
            return "c";
        }

        public override string GetHelp()
        {
            return "c\tCompletes the goal of your choice.\n";
        }
    }
}