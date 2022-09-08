using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameTrivia.Modul.Global
{
    public class SaveDataController : MonoBehaviour
    {
        public static SaveDataController Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else Destroy(gameObject);
        }

        public void Save()
        {

        }

        public void Load()
        {

        }
    }

}
