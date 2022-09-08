using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameTrivia.Modul.Pack
{
    [CreateAssetMenu]
    public class PackDataModel : MonoBehaviour
    {
        string PackID;
        string PackName;
        bool IsCompleted;
        bool IsUnlocked;
        int UnlockCost;
    }

}
