using System.Collections.Generic;

namespace TradeNowLibrary
{
    public interface IOrderWriterService
    {
        void saveOrder(TraderTicket data);

        dynamic readOrder();

    }
}