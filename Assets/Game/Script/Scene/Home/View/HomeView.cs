using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Agate.MVC.Base;

namespace ExampleGame.Home
{
    public class HomeView : BaseSceneView
    {
        [SerializeField]
        private Button _playButton;
        public void SetCallbacks(UnityAction onClickPlayButton)
        {
            _playButton.onClick.RemoveAllListeners();
            _playButton.onClick.AddListener(onClickPlayButton);
        }
    }
}
