using System;
using System.Collections.Generic;

namespace MuOnline.Database.Entities.Entites
{
    public partial class CashShopInventory
    {
        public int BaseItemCode { get; set; }
        public int? MainItemCode { get; set; }
        public string? AccountId { get; set; }
        public int? InventoryType { get; set; }
        public int? PackageMainIndex { get; set; }
        public int? ProductBaseIndex { get; set; }
        public int? ProductMainIndex { get; set; }
        public double? CoinValue { get; set; }
        public int? ProductType { get; set; }
        public string? GiftName { get; set; }
        public string? GiftText { get; set; }
    }
}
