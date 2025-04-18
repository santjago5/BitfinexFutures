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
        public string Amount { get; set; }            // Размер позиции
        public string BasePrice { get; set; }         // Базовая цена входа
        public string MarginFunding { get; set; }     // Используемое финансирование
        public string MarginFundingType { get; set; }     // Тип финансирования (0 - дневное, 1 - срочное)
        public string ProfitLoss { get; set; }       // Прибыль/убыток
        public string ProfitLossPercentage { get; set; } // Прибыль/убыток в процентах
        public string LiquidationPrice { get; set; } // Цена ликвидации
        public string Leverage { get; set; }         // Кредитное плечо
        public string Flags { get; set; }                // Флаги позиции
        public string PositionId { get; set; }           // Идентификатор позиции
        public string MtsCreate { get; set; }           // Время создания позиции
        public string MtsUpdate { get; set; }           // Время последнего обновления позиции
        public string Type { get; set; }                  // Тип позиции (0 - маржинальная, 1 - деривативная)
        public string Collateral { get; set; }        // Залог
        public string CollateralMin { get; set; }    // Минимальный залог
        public Dictionary<string, object> Meta { get; set; } // Дополнительные данные
    }
}
