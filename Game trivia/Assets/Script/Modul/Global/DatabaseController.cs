using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace GameTrivia.Modul.Global
{
    public class DatabaseController : MonoBehaviour
    {
        public static DatabaseController Instance;

        [SerializeField] private List<LevelStruct> _levelStruc;
        
        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else Destroy(gameObject);
            Dataa();
        }



        public string[] GetPackList()
        {
            /*string path = Application.persistentDataPath + "/Data";
            for (int i = 0; i < 4; i++)
            {
                //packlist[i] = Resources.Load<GameObject>(@"/Data/").name;
                //packlist = JsonUtility.FromJson<List<string>>(path);
            }
            */
            string[] packList = { "PackA", "PackB" , "packC", "packD"};
            return packList;
        }

        public string[] GetLevelList(string packID)
        {
            string[] LevelList = { "level A-1", "level A-2", "level A-3" };
            return null;
        }

        public LevelStruct GetLevelData(string levelID)
        {
            LevelStruct getLevel = levels.FirstOrDefault(p => p.LevelID == levelID);
            return getLevel;
        }


        ///
        ///  datadumy
        ///
        public List<LevelStruct> levels = new List<LevelStruct>();
        public enum packname { PackA, PackB, PackC, PackD, }
        public string[] question =
        {
            "warna dari mawar ?",
            "warna dari langit ?",
            "warna dari daun ?",
            "waena dari matahari",
            "warna dari laut ?"
        };
        public string[] hint =
        {
            "Mawar",
            "Langit",
            "Daun",
            "Matahari",
            "Laut"

        };
        
        
        private void Dataa()
        {
            string LevelID;
            string PackID;
            string Question;
            string Hint;
            string[] Choice;
            int Answer;

            for (int i = 0; i < 5; i++)
            {
                LevelID = $"LevelA{i.ToString()}";
                Enum.TryParse($"{i}", out packname value);
                PackID = $"{value}";
                Question = question[i];
                Hint = hint[i];
                Choice = hint;
                Answer = i;
                LevelStruct level = new LevelStruct(LevelID, PackID, Question,
                                                    Hint, Choice, Answer);
                levels.Add(level);
            }
        }

    }
}
