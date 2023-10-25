// DataClass class
using System;
using System.Collections.Generic;
using System.Linq;

namespace LibraryTrainingSystems
{
    public class DataClass
    {
        private static readonly DataClass _instance = new DataClass();
        //Creating the dictionaries
        Dictionary<string, string> LibraryCatergories = new();
        Dictionary<string, string> userLibraryCatergories = new();

        private DataClass()
        {
            ////Creating the Library Catergories dictionary with the call numbers as the PK and the descriptions
            LibraryCatergories.Add("000", "Info on subjects, providing an understanding of the world.");
            LibraryCatergories.Add("100", "Study of questions concerning existence, knowledge, values, reason, mind.");
            LibraryCatergories.Add("200", "Beliefs and values involving worship.");
            LibraryCatergories.Add("300", "Study of various aspects of human society, including history and geography.");
            LibraryCatergories.Add("400", "Communication using sounds, gestures, or written symbols.");
            LibraryCatergories.Add("500", "Study of the world and the phenomena within it, aiming to understand it.");
            LibraryCatergories.Add("600", "Practical scientific innovations to improve efficiency of human life");
            LibraryCatergories.Add("700", "Forms of creative expression for leisure activities and enjoyment.");
            LibraryCatergories.Add("800", "Written works of art, including poetry, that reflect human experiences.");
            LibraryCatergories.Add("900", "Study of past events and societies and the earth's environments.");


        }

        public static DataClass getObject()
        {
            return _instance;
        }

        //Randomizer to randomise the Call Numbers and descriptions when they are generated in the panels
        public Dictionary<string, string> LibraryTraining()
        {
            Random rnd = new Random();
            LibraryCatergories = LibraryCatergories.OrderBy(c => rnd.Next()).ToDictionary(codes => codes.Key, codes => codes.Value);
            return LibraryCatergories;
        }

        //Code to check if the user got the match the match the coloumns right
        public int UserMatches(Dictionary<string, string> userinput)
        {
            int Count = 0;
            foreach (KeyValuePair<string, string> codes in LibraryCatergories)
            {
                if (userinput.TryGetValue(codes.Key, out string matches))
                {
                    if (codes.Value.Equals(matches))
                    {
                        Count++;
                    }
                }
            }
            return Count;
        }
    }
}
