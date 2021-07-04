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
    public class CommandTests
    {

        [TestMethod]
        public void ArgumentNullExceptionThrownIfCommandTypeIsNullOrEmpty()
        {
            try
            {
                new Command("");
            }
            catch (ArgumentNullException ex)
            {
                Assert.AreEqual("Command type required.", ex.Message);
            }
        }
        [TestMethod]
        public void ConstructorSetsCommandType()
        {
            Command newCommand = new Command("MOVE", 0);
            Assert.AreEqual(newCommand.CommandType, "MOVE");
        }

        [TestMethod]
        public void ConstructorSetsInitialNewPositionValue()
        {
            Command newCommand = new Command("MOVE", 20);
            Assert.AreEqual(newCommand.NewPostion, 20);
        }

        [TestMethod]
        public void ConstructorSetsInitialNodeValue()
        {
            Command newCommand = new Command("MODE_CHANGE", "LOW_POWER");
            Assert.AreEqual(newCommand.NewMode, "LOW_POWER");
        }
        [TestMethod]
        public void ArgumentOutOfRangeExceptionThrownIfModeIsWrong()
        {
            try
            {
                new Command("MODE_CHANGE", "low_power");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Assert.AreEqual("Mode must be either 'LOW_POWER' or 'NORMAL'.", ex.Message);
            }
        }


    }
}