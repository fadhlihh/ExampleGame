using UnityEngine;
using Agate.MVC.Base;
using System.Collections;

namespace ExampleGame.Module.SaveData
{
    public class SaveDataController : DataController<SaveDataController, SaveDataModel, ISaveDataModel>
    {
        public override IEnumerator Initialize()
        {
            yield return base.Initialize();
            LoadData();
        }

        public void OnUpdateCoin(int coin)
        {
            _model.SetCoinData(coin);
            SaveData();
        }

        private void SaveData()
        {
            PlayerPrefs.SetInt("Coin", _model.Coin);
            PlayerPrefs.Save();
        }

        private void LoadData()
        {
            int coin = PlayerPrefs.GetInt("Coin");
            _model.SetCoinData(coin);
        }
    }
}
