﻿using System;
using System.Collections.Generic;

namespace Bittrex.Net.Objects
{
    public abstract class BittrexRegistration
    {
        public int StreamId { get; set; }
    }

    internal class BittrexMarketsAllRegistration: BittrexRegistration
    {
        public Action<List<BittrexMarketSummary>> Callback { get; set; }
    }

    internal class BittrexMarketsRegistration : BittrexRegistration
    {
        public Action<BittrexMarketSummary> Callback { get; set; }
        public string MarketName { get; set; }
    }

    internal class BittrexExchangeStateRegistration : BittrexRegistration
    {
        public Action<Object> Callback { get; set; }
        public string MarketName { get; set; }
    }

    internal class BittrexExchangeDeltasRegistration : BittrexRegistration
    {
        public Action<BittrexOrderBookFill> Callback { get; set; }
        public string MarketName { get; set; }
    }
}
