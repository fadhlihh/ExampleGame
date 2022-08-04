using UnityEngine;
using Agate.MVC.Base;
using ExampleGame.Module.ClickGame;

namespace ExampleGame.Gameplay
{
    public class GameplayView : BaseSceneView
    {
        [SerializeField]
        public ClickGameView ClickGameView;
    }
}
