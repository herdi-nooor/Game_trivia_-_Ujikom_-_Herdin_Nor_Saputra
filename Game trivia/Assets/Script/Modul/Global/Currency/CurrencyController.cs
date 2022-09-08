using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameTrivia.Modul.Global
{
    public class CurrencyController : MonoBehaviour
    {
        public static CurrencyController Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else Destroy(gameObject);
        }

        public int GetCoin()
        {
            return new int();
        }

        public void AddCoin(int amount)
        {
       
        }

        public bool SpendCoin(int amount)
        {
            return false;
        }
    }

}
