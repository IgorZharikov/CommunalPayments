//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CommunalPayments
{
    using System;
    using System.Collections.Generic;
    
    public partial class MeasurementDevices
    {
        public int Id { get; set; }
        public int ReceiptId { get; set; }
        public int DeviceTypeId { get; set; }
        public double InitialValue { get; set; }
        public double FinalValue { get; set; }
    
        public virtual MeasurementDeviceTypes MeasurementDeviceTypes { get; set; }
        public virtual Receipts Receipts { get; set; }
    }
}
