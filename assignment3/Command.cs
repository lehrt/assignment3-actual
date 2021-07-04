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
        }

        public Command(string commandType, int value)
        {
            CommandType = commandType;
            if (String.IsNullOrEmpty(commandType))
            {
                throw new ArgumentNullException(commandType, "Command type required.");
            }
            this. NewPostion = value;
            }        

        public Command(string commandType, string mode)
        {
            CommandType = commandType;
            if ((mode == "LOW_POWER") || (mode == "NORMAL"))
            {
                NewMode = mode;
            }
            else
            {
                throw new ArgumentOutOfRangeException(mode, "Mode must be either 'LOW_POWER' or 'NORMAL'.");
            }
            this.NewMode = mode;
        }


    }
}