using UnityEngine;
using Agate.MVC.Base;
using ExampleGame.Message;

namespace ExampleGame.Module.Soundfx
{
    public class SoundfxController : BaseController<SoundfxController>
    {
        public void OnUpdateCoin()
        {
            Debug.Log("Play Sound fx");
        }
    }
}
