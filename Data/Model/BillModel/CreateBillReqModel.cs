﻿using Data.Model.ProductBillModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Model.BillModel
{
    public class CreateBillReqModel :CreateProductBillReqModel
    {
        public string VoucherId { get; set; }

    }
}
