using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameTrivia.Modul.Pack
{
    public class PackLauncher : MonoBehaviour
    {
        public void GoBack()
        {
            SceneManager.LoadScene("Home");
            SceneManager.UnloadScene("Pack");
        }

        public void SelectPack(string packID)
        {
            
        }
    }

}
