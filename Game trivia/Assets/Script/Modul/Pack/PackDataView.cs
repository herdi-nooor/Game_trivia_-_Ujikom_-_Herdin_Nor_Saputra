using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace GameTrivia.Modul.Pack
{
    public class PackDataView : PackView
    {
        private TextMeshProUGUI _packNameLabel;
        private TextMeshProUGUI _unlockCostLabel;
        private Button _selectButton;
        private Button _unlockButton;
        private Image completeImage;
        private PackView view;


        public void LoadButtonList(PackDataModel[] data)
        {
            GameObject buttonPack = Resources.Load<GameObject>(@"Prefabs/Button pack");
            for (int i = 0; i < data.Length; i++)
            {
                GameObject obj = Instantiate(buttonPack, view.buttonWrap.transform);
                Instantiate(_packNameLabel, obj.transform);
                if (data[i].IsUnlocked) obj.transform.GetChild(i).gameObject.SetActive(false);
                else obj.transform.GetChild(i).gameObject.SetActive(false);
            }
        }
    }

}
