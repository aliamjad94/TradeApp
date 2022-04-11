namespace TradeNowLibrary
{
    public interface IOrderWriterService
    {
        void saveOrder(dynamic saved);

        dynamic readOrder();

    }
}