using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NotesExampleApi.Models;

namespace NotesExampleApi
{
    public static class DevelopTestingData
    {

        /// <summary>
        /// Very simple class just to add in some example data, there is probabably a better way of doing this 
        /// </summary>
        /// <returns></returns>
        public static List<NoteModel> CreateSomeSampleNotes()
        {
            var nm1 = new NoteModel()
            {
                UserName = "Kirk Montrose",
                Title= "Note Number One",
                Contents = "This is my first note!",
                CreationDate = DateTime.Now
            };

            var nm2 = new NoteModel()
            {
                UserName = "Kirk Montrose",
                Title = "Note Number Two",
                Contents = "This is my second note!",
                CreationDate = DateTime.Now
            };

            var nm3 = new NoteModel()
            {
                UserName = "Kirk Montrose",
                Title = "Note Number Three",
                Contents = "This is my third note!",
                CreationDate = DateTime.Now,
                EditDate = DateTime.Now
            };

            var list = new List<NoteModel>();
            list.Add(nm1);
            list.Add(nm2);
            list.Add(nm3);
            return list;

        }



        /// <summary>
        /// Creates a bunch of notes using random strings. Good for testing adding mass qty of notes. 
        /// </summary>
        /// <returns></returns>
        public static List<NoteModel> CreateNumberOfRandomNotes(int length)
        {
            var list = new List<NoteModel>();
            for (int i = 0; i < length; i++)
            {
                list.Add(new NoteModel()
                {
                    UserName = RandomString(5),
                    Title = RandomString(10),
                    Contents = RandomString(60),
                    CreationDate = DateTime.Now,
                    EditDate = DateTime.Now
                }
                );
            }
            return list;
        }


        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}

