﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CustomerAccount
    {
        public int CustomerAccountID { get; set; }
        public string CustomerAccountNumber { get; set; }
        public string CustomerAccountCurrency { get; set;}
        public double CustomerAccountBalance { get; set; }
        public string BankBranch { get; set; }
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }

    }
}
