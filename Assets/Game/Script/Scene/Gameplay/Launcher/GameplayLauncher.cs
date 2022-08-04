using System.Collections;
using Agate.MVC.Base;
using Agate.MVC.Core;
using ExampleGame.Boot;
using ExampleGame.Module.ClickGame;
using ExampleGame.Module.Soundfx;

namespace ExampleGame.Gameplay
{
    public class GameplayLauncher : SceneLauncher<GameplayLauncher, GameplayView>
    {
        private ClickGameController _clickGame;
        public override string SceneName => "Gameplay";

        protected override IConnector[] GetSceneConnectors()
        {
            return new IConnector[]{
                new GameplayConnector()
            };
        }

        protected override IController[] GetSceneDependencies()
        {
            return new IController[]{
                new ClickGameController(),
                new SoundfxController(),
            };
        }

        protected override IEnumerator InitSceneObject()
        {
            _clickGame.SetView(_view.ClickGameView);
            yield return null;
        }

        protected override IEnumerator LaunchScene()
        {
            yield return null;
        }
    }
}
