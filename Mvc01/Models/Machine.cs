using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc01.Models
{
    public class Machine
    {
        //fields

        private decimal _totalAmount;

        //properties
        public decimal TotalAmount {
            get {
                return _totalAmount;
            }
        }

        public void AcceptsCoin(decimal amount) {
            _totalAmount += amount;
        }
        public void CancelCoin() {
            _totalAmount = 0;
        }


    }
}
