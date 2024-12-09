﻿using System;
using System.Collections.Generic;

namespace MTTKDotNetCore.PointOfSale.Database.Models;

public partial class TblSaleInvoiceDetailPos
{
    public int SaleDetailId { get; set; }

    public string VoucherNo { get; set; } = null!;

    public string ProductCode { get; set; } = null!;

    public int Quantity { get; set; }

    public decimal Price { get; set; }
}
