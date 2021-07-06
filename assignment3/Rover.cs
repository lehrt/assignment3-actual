using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover;
public class Rover
{
    public string Mode { get; set; }
    public int Position { get; set; }
    public int GeneratorWatts { get; set; }

    public Rover(int position)
    {
        this.Position = position;
        this.Mode = "NORMAL";
        this.GeneratorWatts = 110;  
    }

    public override string ToString()
    {
        return "Position: " + Position + " - Mode: " + Mode + " - GeneratorWatts: " + GeneratorWatts;
    }

    public void RecieveMessage(Message message)
    {
        Command[] reachableCommandsArr = message.Commands;

        try
        {
            foreach (Command comm in reachableCommandsArr)
            {
                if (comm.CommandType == "MODE_CHANGE")
                {
                    this.Mode = comm.NewMode;
                }
                else
                {
                    this.Position = comm.NewPostion; 
                }
            }
        }
        catch
        {
            if ((this.Mode == "LOW_POWER") && (this.Position >= 0))
            {
                throw new ArgumentOutOfRangeException("Rover can't move while in LOW_POWER mode");
            }
        }
    }
}
