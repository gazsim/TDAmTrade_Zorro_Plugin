﻿//*****************************************************************************
// File: OHLCBase.cs
//
// Author: Clyde W. Ford
//
// Date: April 24, 2020
//
// Description: The OHLC base class object.
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

namespace TDAmeritradeZorro.Classes.TDA.Assets
{
    //*************************************************************************
    //  Class: OHLCBase
    //
    /// <summary>
    /// The OHLC base class object. See <cref="OHLC">OHLC class object</cref> 
    /// and the TD Ameritrade API information at 
    /// https://developer.tdameritrade.com/apis for details on the properties
    /// and usage of this class.
    /// </summary>
    //*************************************************************************
    [DataContract]
    public class OHLCBase : DivBase
    {
        [DataMember(Name = "openPrice")]
        public double OpenPrice { get; set; }

        [DataMember(Name = "highPrice")]
        public double HighPrice { get; set; }

        [DataMember(Name = "lowPrice")]
        public double LowPrice { get; set; }

        [DataMember(Name = "lastPrice")]
        public double LastPrice { get; set; }

    }
}
