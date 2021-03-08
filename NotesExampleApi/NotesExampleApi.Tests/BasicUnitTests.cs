using NUnit.Framework;
using System.Collections.Generic;
using NotesExampleApi.Models;


namespace NotesExampleApi.Tests
{
    //These are just some basic unit tests. 

    public class BasicUnitTests
    {
        List<NoteModel> _modelsToTest;

        [SetUp]
        public void Setup()
        {
            //For testing ill create a 1000 random models. 
           _modelsToTest = DevelopTestingData.CreateNumberOfRandomNotes(1000);
        }

        [Test]
        public void CreateNewNote()
        {



            Assert.Pass();
        }


        [Test]
        public void EditNote()
        {



            Assert.Pass();
        }

        [Test]
        public void DeleteNote()
        {



            Assert.Pass();
        }
    }
}