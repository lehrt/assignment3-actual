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
    public class MessageTests
    {
       Command[] commands = { new Command("foo", 0), new Command("bar", 20) };



    
        
    [TestMethod]
    public void ArgumentNullExceptionThrownIfNameNotPassedToConstructor()
    {
        Command newCommand = new Command("MOVE", 0);
        Command[] commandArr = { newCommand };
            try
        {
            new Message("", commandArr);
        }
        catch (ArgumentNullException ex)
        {
            Assert.AreEqual("Name required.", ex.Message);
        }
    }
    [TestMethod]
    public void ConstructorSetsName()
        {
            Message mess = new Message("title", commands);
            Assert.AreEqual(mess.Name, "title");
        }

    [TestMethod]
    public void ConstructorSetsCommandsField()
        {
            Message mess = new Message("best title ever", commands);
            Assert.AreEqual(mess.Commands, commands);
        }
/*
        public void ConstructorSetsInitialNewPositionValue()
        {
            Command newCommand = new Command("MOVE", 20);
            Assert.AreEqual(newCommand.NewPostion, 20);
        }*/
    }
}