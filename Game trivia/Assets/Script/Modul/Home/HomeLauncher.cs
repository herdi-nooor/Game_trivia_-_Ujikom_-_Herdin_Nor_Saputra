using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameTrivia.Modul.Home
{
    public class HomeLauncher : MonoBehaviour
    {
        public void StartPlay()
        {
            Debug.Log("start");
            SceneManager.LoadSceneAsync("Pack");
        }

    }

}
