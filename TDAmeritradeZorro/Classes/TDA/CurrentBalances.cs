﻿//*****************************************************************************
// File: CurrentBalances.cs
//
// Author: Clyde W. Ford
//
// Date: April 24, 2020
//
// Description: The CurrentBalances class object.
//
// Copright (c) 2020 Clyde W. Ford. All rights reserved.
//
// License: LGPL-3.0 (Non-commercial use only)
//
// DISCLAIMER:
//
// This Zorro plug-in is offered on an AS IS basis with no claims or warranties
// that it is fit or complete for any given purpose. YOU USE THIS PLUG-IN AT
// YOUR OWN RISK.
//
// Since the plug-in may be used as part of a system to trade financial instru-
// ments, the user of this plug-in accepts complete and total responsibility 
// for any damages, monetary or otherwise, that arize from the use of the plug-
// in, and holds harmless the author of the plug-in for any damages, financial
// or otherwise, incurred.
//
// For further information, see the Disclaimer included with this plug-in.
//*****************************************************************************
using System.Runtime.Serialization;

namespace TDAmeritradeZorro.Classes.TDA
{
    //*************************************************************************
    //  Class: CurrentBalances
    //
    /// <summary>
    /// The TD Ameritrade CurrentBalances class. See the TD Ameritrade API
    /// information at https://developer.tdameritrade.com/apis for details on
    /// the properties of this class.
    /// </summary>
    //*************************************************************************
    [DataContract]
    public class CurrentBalances
    {
        [DataMember(Name = "accruedInterest")]
        public double AccruedInterest { get; set; }

        [DataMember(Name = "cashBalance")]
        public double CashBalance { get; set; }

        [DataMember(Name = "cashReceipts")]
        public double CashReceipts { get; set; }

        [DataMember(Name = "longOptionMarketValue")]
        public double LongOptionMarketValue { get; set; }

        [DataMember(Name = "liquidationValue")]
        public double LiquidationValue { get; set; }

        [DataMember(Name = "longMarketValue")]
        public double LongMarketValue { get; set; }

        [DataMember(Name = "moneyMarketFund")]
        public double MoneyMarketFund { get; set; }

        [DataMember(Name = "savings")]
        public double Savings { get; set; }

        [DataMember(Name = "shortMarketValue")]
        public double ShortMarketValue { get; set; }

        [DataMember(Name = "pendingDeposits")]
        public double PendingDeposits { get; set; }

        [DataMember(Name = "availableFunds")]
        public double AvailableFunds { get; set; }

        [DataMember(Name = "availableFundsNonMarginableTrade")]
        public double AvailableFundsNonMarginableTrade { get; set; }

        [DataMember(Name = "buyingPower")]
        public double BuyingPower { get; set; }

        [DataMember(Name = "buyingPowerNonMarginableTrade")]
        public double BuyingPowerNonMarginableTrade { get; set; }

        [DataMember(Name = "dayTradingBuyingPower")]
        public double DayTradingBuyingPower { get; set; }

        [DataMember(Name = "equity")]
        public double Equity { get; set; }

        [DataMember(Name = "equityPercentage")]
        public double EquityPercentage { get; set; }

        [DataMember(Name = "longMarginValue")]
        public double LongMarginValue { get; set; }

        [DataMember(Name = "maintenanceCall")]
        public double MaintenanceCall { get; set; }

        [DataMember(Name = "maintenanceRequirement")]
        public double MaintenanceRequirement { get; set; }

        [DataMember(Name = "marginBalance")]
        public double MarginBalance { get; set; }

        [DataMember(Name = "regTCall")]
        public double RegTCall { get; set; }

        [DataMember(Name = "shortBalance")]
        public double ShortBalance { get; set; }

        [DataMember(Name = "shortMarginValue")]
        public double ShortMarginValue { get; set; }

        [DataMember(Name = "shortOptionMarketValue")]
        public double ShortOptionMarketValue { get; set; }

        [DataMember(Name = "sma")]
        public double SMA { get; set; }

        [DataMember(Name = "bondValue")]
        public double BondValue { get; set; }
    }
}
