using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameTrivia.Modul.Global
{
    public class AnalyticController : MonoBehaviour
    {
        public static AnalyticController Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else Destroy(gameObject);
        }

        public void TrackFinishLevel(string levelID)
        {

        }

        public void TrackUnlockPack(string packId)
        {

        }
    }

}
