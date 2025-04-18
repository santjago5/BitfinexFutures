using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsEngine.Market.Servers.Bitfinex.BitfinexFutures.Json
{
    public class BitfinexFuturesPosition
    {
        public string Symbol { get; set; }             // Символ (например, "tETHUST")
        public string Status { get; set; }             // Статус позиции ("ACTIVE", "CLOSED")
        public decimal Amount { get; set; }            // Размер позиции
        public decimal BasePrice { get; set; }         // Базовая цена входа
        public decimal MarginFunding { get; set; }     // Используемое финансирование
        public int MarginFundingType { get; set; }     // Тип финансирования (0 - дневное, 1 - срочное)
        public decimal? ProfitLoss { get; set; }       // Прибыль/убыток
        public decimal? ProfitLossPercentage { get; set; } // Прибыль/убыток в процентах
        public decimal? LiquidationPrice { get; set; } // Цена ликвидации
        public decimal? Leverage { get; set; }         // Кредитное плечо
        public int? Flags { get; set; }                // Флаги позиции
        public long PositionId { get; set; }           // Идентификатор позиции
        public long? MtsCreate { get; set; }           // Время создания позиции
        public long? MtsUpdate { get; set; }           // Время последнего обновления позиции
        public int Type { get; set; }                  // Тип позиции (0 - маржинальная, 1 - деривативная)
        public decimal Collateral { get; set; }        // Залог
        public decimal? CollateralMin { get; set; }    // Минимальный залог
        public Dictionary<string, object> Meta { get; set; } // Дополнительные данные
    }
}
