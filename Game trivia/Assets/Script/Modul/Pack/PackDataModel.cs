using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameTrivia.Modul.Pack
{
    [CreateAssetMenu]
    public class PackDataModel : MonoBehaviour
    {
        public string PackID { get; set; }
        public string PackName { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsUnlocked { get; set; }
        public int UnlockCost { get; set; }

        public PackDataModel(string packaID, string packName, bool isCompleted,
                                                    bool isUnlocked, int unlockCost)
        {
            PackID = packaID;
            PackName = packName;
            IsCompleted = isCompleted;
            IsUnlocked = isUnlocked;
            UnlockCost = unlockCost;
        }

    }

}
