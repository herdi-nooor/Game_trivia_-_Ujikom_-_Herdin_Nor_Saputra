using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace GameTrivia.Modul.Pack
{
    public class PackDataView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _packNameLebel;
        [SerializeField] private TextMeshProUGUI _unlockCostLabel;
        [SerializeField] private Button _selectButton;
        [SerializeField] private Button _unlockButton;
        [SerializeField] private Image completeImage;
    }

}
