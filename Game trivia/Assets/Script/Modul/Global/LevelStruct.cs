using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameTrivia.Modul.Global
{
    public struct LevelStruct
    {
        public string LevelID;
        public string PackID;
        public string Question;
        public string Hint;
        public string[] Choice;
        public int Answer;


        public LevelStruct(string levelID, string packID, string question, string hint,
                                    string[] choice, int answer)
        {
            LevelID = levelID;
            PackID = packID;
            Question = question;
            Hint = hint;
            Choice = choice;
            Answer = answer;
        }
    }

}
