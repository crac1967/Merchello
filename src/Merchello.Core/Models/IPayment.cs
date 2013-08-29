﻿using System;
using System.Runtime.Serialization;
using Merchello.Core.Models.EntityBase;

namespace Merchello.Core.Models
{
    /// <summary>
    /// Defines a Merchello Payment 
    /// </summary>
    public interface IPayment : IIdEntity
    {
            
            /// <summary>
            /// The invoiceId for the Payment
            /// </summary>
            [DataMember]
            int InvoiceId { get; }
            
            
            /// <summary>
            /// The customerKey for the Payment
            /// </summary>
            [DataMember]
            Guid CustomerKey { get; }
            
            /// <summary>
            /// The memberId for the Payment
            /// </summary>
            [DataMember]
            int? MemberId { get; set;}
            
            /// <summary>
            /// The alias for the payment gateway
            /// </summary>
            [DataMember]
            string GatewayAlias { get; set;}
            
            /// <summary>
            /// The paymentTypeFieldKey for the payment
            /// </summary>
            [DataMember]
            Guid PaymentTypeFieldKey { get; set;}
            
            /// <summary>
            /// The name of the payment method for the payment
            /// </summary>
            [DataMember]
            string PaymentMethodName { get; set;}
            
            /// <summary>
            /// The reference number for the payment
            /// </summary>
            [DataMember]
            string ReferenceNumber { get; set;}
            
            /// <summary>
            /// The amount for the payment
            /// </summary>
            [DataMember]
            decimal Amount { get; set;}
            
            /// <summary>
            /// True/false indicating whether or not this payment has be exported to another system
            /// </summary>
            [DataMember]
            bool Exported { get; set;}
    }
}


