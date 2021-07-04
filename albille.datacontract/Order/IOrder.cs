using System;
using System.Collections.Generic;

namespace albelli.datacontract
{
    public interface IOrder:IRequestOrder
    {
        /// <summary>
        /// Gets or sets the order id.
        /// </summary>
        int OrderId { get; set; }

        /// <summary>
        /// Gets or sets the created date time.
        /// </summary>
        DateTime CreatedDateTime { get; set; }

        /// <summary>
        /// Gets the minimum required width for bin.
        /// </summary>
        decimal RequiredBinWidth { get; set; }

    }
}