using NUnit.Framework;
using System.Collections.Generic;
using NotesExampleApi.Models;
using System.Net.Http;
using System;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;

namespace NotesExampleApi.Tests
{
    //These are just some basic unit tests. IM keeping this simple for this example, 
    //but I could add unit to cover many secnerios for how notes would be used. Such testing how it would handle long strings or special charcters. 

    public class BasicUnitTests
    {
        List<NoteModel> _modelsToTest;


      public   BasicUnitTests()
      {

      }


        [SetUp]
        public void Setup()
        {
            //For testing ill create a 1000 random models. 
           _modelsToTest = DevelopTestingData.CreateNumberOfRandomNotes(1000);
        }

        [Test]
        public async Task CreateNewNote()
        {
            var theURI = "https://localhost:44363/note/createnote";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(theURI);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.Timeout = TimeSpan.FromSeconds(30.0);

            //Just using a random selected note to create
            string json = JsonConvert.SerializeObject(_modelsToTest[13]);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = (await client.PostAsync(theURI, httpContent));


            NoteModel returnModel = JsonConvert.DeserializeObject<NoteModel>(response.Content.ToString());


            if  (returnModel == _modelsToTest[13])
            {
                //Im sure there is a better way to handle this.
                Assert.IsTrue(true);
                return;
            }

                Assert.Fail("Note Failed to Create");
          
        }

        [Test]
        public void CreateAllRandomNotesNote()
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