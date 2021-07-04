using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace albelli.datacontract
{
    public class RequestOrder : IRequestOrder
    {
        /// <summary>
        /// Gets or sets the Order details.
        /// </summary>
        public List<OrderDetails> OrderDetails
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the customer ID.
        /// </summary>
        public int CustomerId
        {
            get;
            set;
        }
    }
}
