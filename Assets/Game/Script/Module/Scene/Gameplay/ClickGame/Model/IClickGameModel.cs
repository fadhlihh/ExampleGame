using Agate.MVC.Base;

namespace ExampleGame.Module.ClickGame
{
    public interface IClickGameModel : IBaseModel
    {
        public int Coin { get; }
    }
}
