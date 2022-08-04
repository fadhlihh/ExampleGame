namespace ExampleGame.Message
{
    public class UpdateCoinMessage
    {
        public int Coin { get; private set; }

        public UpdateCoinMessage(int coin)
        {
            Coin = coin;
        }
    }
}
