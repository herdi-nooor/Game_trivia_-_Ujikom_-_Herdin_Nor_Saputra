using GameTrivia.Modul.Global;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameTrivia.Modul.Level {
    public class LevelDataController : MonoBehaviour
    {
        private LevelDataModel _model;
        public void LoadLevelList()
        {
            string levelid = "LevelA1";

            LevelStruct level = DatabaseController.Instance.GetLevelData(levelid);
            
        }

        public LevelDataModel[] GetLevelList()
        {
            return null;
        }

        public void InitLevelList(LevelDataModel[] levels)
        {
            
        }

        private void Awake()
        {
            LoadLevelList();
        }
    }
    
}
