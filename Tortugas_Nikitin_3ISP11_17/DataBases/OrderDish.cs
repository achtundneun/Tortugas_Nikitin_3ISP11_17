//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tortugas_Nikitin_3ISP11_17.DataBases
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDish
    {
        public int ID { get; set; }
        public int OrderID { get; set; }
        public int DishID { get; set; }
        public int Amount { get; set; }
    
        public virtual DIsh DIsh { get; set; }
        public virtual Order Order { get; set; }
    }
}