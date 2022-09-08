using GameTrivia.Modul.Global;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace GameTrivia.Modul.Pack
{
    public class PackDataController : MonoBehaviour
    {
        private PackDataView _view;

         public void LoadPackList()
        {
            PackDataModel[] datas = GetPackList();
            _view.LoadButtonList(datas);
            
        }

        public PackDataModel[] GetPackList()
        {
            string[] packs = DatabaseController.Instance.GetPackList();
            PackDataModel[] data = new PackDataModel[packs.Length];
            for (int i = 0; i < packs.Length; i++)
            {
                PackDataModel packdata = new PackDataModel($"pack{i}" , packs[i], false, false, 100);
                data[i] = packdata;
            }

            return data;
        }

        public void InitPackList(PackDataModel[] packs)
        {

        }

        private void Start()
        {
            LoadPackList();
        }


    }

}
