using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albelli.datacontract
{
    public interface IRequestOrder
    {
        /// <summary>
        /// Gets or sets the Order details.
        /// </summary>
        List<OrderDetails> OrderDetails { get; set; }

        /// <summary>
        /// Gets or sets the Customer ID.
        /// </summary>
        int CustomerId { get; set; }

    }
}
