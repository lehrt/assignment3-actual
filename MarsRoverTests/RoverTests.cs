using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class RoverTests
    {
/*        [TestInitialize]
        public void RoverNew()
        {
        }
        */

        [TestMethod] //8
        public void ConstructorSetsDefaultPosition()
        {      
            Rover newRover = new Rover(4);
            Assert.AreEqual(newRover.Position, 4);
        }

        [TestMethod] //9
        public void ConstructorSetsDefaultMode()
        {         
            Rover newRover = new Rover(4);
            Assert.AreEqual(newRover.Mode, "NORMAL");
        }
        [TestMethod] //10
        public void ConstructorSetsDefaultGeneratorWatts()
        {

            Rover newRover = new Rover(4);
            Assert.AreEqual(newRover.GeneratorWatts, 110);
        }
        [TestMethod] //11, fails bc I haven't made method yet
        public void RespondsCorrectlyToModeChangeCommand()
        {
            Rover newRover = new Rover(4);
            Command[] commands = { new Command("MODE_CHANGE", "LOW_POWER") };
            Message newMessage = new Message("Test message with one command", commands);
            newRover.RecieveMessage(newMessage);
            Assert.AreEqual(newRover.Mode, "LOW_POWER");
        }
        [TestMethod] //12
        public void DoesNotMoveInLowPower()
        {
            Rover newRover = new Rover(4);
            Command[] commands = { (new Command("MODE_CHANGE", "LOW_POWER")), (new Command("MOVE", 12000)) };
            Message newMessage = new Message("Test message with one command", commands);

            try
            {
                newRover.RecieveMessage(newMessage);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("Rover can't move while in LOW_POWER mode", ex.Message);
            }
        }
        [TestMethod] //13
        public void PositionChangesFromMoveCommand()
        {
            Rover newRover = new Rover(4);
            Command[] commands = { (new Command("MOVE", 12000)) };
            Message newMessage = new Message("Test message with one command", commands);
            newRover.RecieveMessage(newMessage);
            Assert.AreEqual(newRover.Position, 12000);
        }

        
    }
}