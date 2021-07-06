using System;
namespace MarsRover
{
    public class Command
    {
        public string CommandType { get; set; }
        public int NewPostion { get; set; }
        public string NewMode { get; set; }


        public Command() { }

        public Command(string commandType)
        {
            CommandType = commandType;
            if (String.IsNullOrEmpty(commandType))
            {
                throw new ArgumentNullException(commandType, "Command type required.");
            }
            else if ((commandType != "MOVE") || (commandType!= "MODE_CHANGE"))
            {
                Console.WriteLine("ERROR: Command type must be either MOVE or MODE_CHANGE");
            }
        }

        public Command(string commandType, int value)
        {
            CommandType = commandType;
            if (String.IsNullOrEmpty(commandType))
            {
                throw new ArgumentNullException(commandType, "Command type required.");
            }
            this.NewPostion = value;
        }        

        public Command(string commandType, string mode)
        {
            this.CommandType = commandType;
            if ((mode == "LOW_POWER") || (mode == "NORMAL"))
            {
                NewMode = mode;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Mode must be either 'LOW_POWER' or 'NORMAL'.");
            }
           // this.NewMode = mode;
        }


    }
}