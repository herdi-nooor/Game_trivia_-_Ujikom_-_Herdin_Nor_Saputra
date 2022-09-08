using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameTrivia.Modul.Level
{
    public class LevelLauncher : MonoBehaviour
    {
        public void GoBack()
        {

        }

        public void SelectLevel(string LevelID)
        {
            SceneManager.LoadScene(3);
        }
    }

}
