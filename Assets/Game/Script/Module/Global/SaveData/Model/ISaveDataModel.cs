using Agate.MVC.Base;

namespace ExampleGame.Module.SaveData
{
    public interface ISaveDataModel : IBaseModel
    {
        public int Coin { get; }
    }
}
