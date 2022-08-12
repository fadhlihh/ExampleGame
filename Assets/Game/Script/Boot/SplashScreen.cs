using UnityEngine;
using UnityEngine.EventSystems;
using Agate.MVC.Base;
using Agate.MVC.Core;

namespace ExampleGame.Boot
{
    public class SplashScreen : BaseSplash<SplashScreen>
    {
        protected override ILoad GetLoader()
        {
            return SceneLoader.Instance;
        }

        protected override IMain GetMain()
        {
            return GameMain.Instance;
        }

        protected override void StartSplash()
        {
            base.StartSplash();
            CreateEventSystem();
        }

        private void CreateEventSystem()
        {
            GameObject obj = new GameObject("Event System");
            obj.AddComponent<EventSystem>();
            obj.AddComponent<StandaloneInputModule>();
            GameObject.DontDestroyOnLoad(obj);
        }
    }
}
