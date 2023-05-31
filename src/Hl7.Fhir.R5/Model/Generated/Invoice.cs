// <auto-generated/>
// Contents of: hl7.fhir.r5.core version: 5.0.0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Serialization;
using Hl7.Fhir.Specification;
using Hl7.Fhir.Utility;
using Hl7.Fhir.Validation;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model
{
  /// <summary>
  /// Invoice containing ChargeItems from an Account
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("Invoice","http://hl7.org/fhir/StructureDefinition/Invoice", IsResource=true)]
  public partial class Invoice : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "Invoice"; } }

    /// <summary>
    /// Codes identifying the lifecycle stage of an Invoice.
    /// (url: http://hl7.org/fhir/ValueSet/invoice-status)
    /// (system: http://hl7.org/fhir/invoice-status)
    /// </summary>
    [FhirEnumeration("InvoiceStatus", "http://hl7.org/fhir/ValueSet/invoice-status")]
    public enum InvoiceStatus
    {
      /// <summary>
      /// the invoice has been prepared but not yet finalized.
      /// (system: http://hl7.org/fhir/invoice-status)
      /// </summary>
      [EnumLiteral("draft", "http://hl7.org/fhir/invoice-status"), Description("draft")]
      Draft,
      /// <summary>
      /// the invoice has been finalized and sent to the recipient.
      /// (system: http://hl7.org/fhir/invoice-status)
      /// </summary>
      [EnumLiteral("issued", "http://hl7.org/fhir/invoice-status"), Description("issued")]
      Issued,
      /// <summary>
      /// the invoice has been balaced / completely paid.
      /// (system: http://hl7.org/fhir/invoice-status)
      /// </summary>
      [EnumLiteral("balanced", "http://hl7.org/fhir/invoice-status"), Description("balanced")]
      Balanced,
      /// <summary>
      /// the invoice was cancelled.
      /// (system: http://hl7.org/fhir/invoice-status)
      /// </summary>
      [EnumLiteral("cancelled", "http://hl7.org/fhir/invoice-status"), Description("cancelled")]
      Cancelled,
      /// <summary>
      /// the invoice was determined as entered in error before it was issued.
      /// (system: http://hl7.org/fhir/invoice-status)
      /// </summary>
      [EnumLiteral("entered-in-error", "http://hl7.org/fhir/invoice-status"), Description("entered in error")]
      EnteredInError,
    }

    /// <summary>
    /// Participant in creation of this Invoice
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("Invoice#Participant", IsNestedType=true)]
    public partial class ParticipantComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Invoice#Participant"; } }

      /// <summary>
      /// Type of involvement in creation of this Invoice
      /// </summary>
      [FhirElement("role", Order=40)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Role
      {
        get { return _Role; }
        set { _Role = value; OnPropertyChanged("Role"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Role;

      /// <summary>
      /// Individual who was involved
      /// </summary>
      [FhirElement("actor", Order=50, FiveWs="FiveWs.actor")]
      [CLSCompliant(false)]
      [References("Practitioner","Organization","Patient","PractitionerRole","Device","RelatedPerson")]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.ResourceReference Actor
      {
        get { return _Actor; }
        set { _Actor = value; OnPropertyChanged("Actor"); }
      }

      private Hl7.Fhir.Model.ResourceReference _Actor;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as ParticipantComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Role != null) dest.Role = (Hl7.Fhir.Model.CodeableConcept)Role.DeepCopy();
        if(Actor != null) dest.Actor = (Hl7.Fhir.Model.ResourceReference)Actor.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new ParticipantComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as ParticipantComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Role, otherT.Role)) return false;
        if( !DeepComparable.Matches(Actor, otherT.Actor)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as ParticipantComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Role, otherT.Role)) return false;
        if( !DeepComparable.IsExactly(Actor, otherT.Actor)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Role != null) yield return Role;
          if (Actor != null) yield return Actor;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Role != null) yield return new ElementValue("role", Role);
          if (Actor != null) yield return new ElementValue("actor", Actor);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "role":
            value = Role;
            return Role is not null;
          case "actor":
            value = Actor;
            return Actor is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Role is not null) yield return new KeyValuePair<string,object>("role",Role);
        if (Actor is not null) yield return new KeyValuePair<string,object>("actor",Actor);
      }

    }

    /// <summary>
    /// Line items of this Invoice
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("Invoice#LineItem", IsNestedType=true)]
    public partial class LineItemComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Invoice#LineItem"; } }

      /// <summary>
      /// Sequence number of line item
      /// </summary>
      [FhirElement("sequence", Order=40)]
      [DataMember]
      public Hl7.Fhir.Model.PositiveInt SequenceElement
      {
        get { return _SequenceElement; }
        set { _SequenceElement = value; OnPropertyChanged("SequenceElement"); }
      }

      private Hl7.Fhir.Model.PositiveInt _SequenceElement;

      /// <summary>
      /// Sequence number of line item
      /// </summary>
      /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
      [IgnoreDataMember]
      public int? Sequence
      {
        get { return SequenceElement != null ? SequenceElement.Value : null; }
        set
        {
          if (value == null)
            SequenceElement = null;
          else
            SequenceElement = new Hl7.Fhir.Model.PositiveInt(value);
          OnPropertyChanged("Sequence");
        }
      }

      /// <summary>
      /// Service data or period
      /// </summary>
      [FhirElement("serviced", Order=50, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.Date),typeof(Hl7.Fhir.Model.Period))]
      [DataMember]
      public Hl7.Fhir.Model.DataType Serviced
      {
        get { return _Serviced; }
        set { _Serviced = value; OnPropertyChanged("Serviced"); }
      }

      private Hl7.Fhir.Model.DataType _Serviced;

      /// <summary>
      /// Reference to ChargeItem containing details of this line item or an inline billing code
      /// </summary>
      [FhirElement("chargeItem", Order=60, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [References("ChargeItem")]
      [AllowedTypes(typeof(Hl7.Fhir.Model.ResourceReference),typeof(Hl7.Fhir.Model.CodeableConcept))]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.DataType ChargeItem
      {
        get { return _ChargeItem; }
        set { _ChargeItem = value; OnPropertyChanged("ChargeItem"); }
      }

      private Hl7.Fhir.Model.DataType _ChargeItem;

      /// <summary>
      /// Components of total line item price
      /// </summary>
      [FhirElement("priceComponent", Order=70)]
      [Cardinality(Min=0,Max=-1)]
      [DataMember]
      public List<Hl7.Fhir.Model.MonetaryComponent> PriceComponent
      {
        get { if(_PriceComponent==null) _PriceComponent = new List<Hl7.Fhir.Model.MonetaryComponent>(); return _PriceComponent; }
        set { _PriceComponent = value; OnPropertyChanged("PriceComponent"); }
      }

      private List<Hl7.Fhir.Model.MonetaryComponent> _PriceComponent;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as LineItemComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(SequenceElement != null) dest.SequenceElement = (Hl7.Fhir.Model.PositiveInt)SequenceElement.DeepCopy();
        if(Serviced != null) dest.Serviced = (Hl7.Fhir.Model.DataType)Serviced.DeepCopy();
        if(ChargeItem != null) dest.ChargeItem = (Hl7.Fhir.Model.DataType)ChargeItem.DeepCopy();
        if(PriceComponent != null) dest.PriceComponent = new List<Hl7.Fhir.Model.MonetaryComponent>(PriceComponent.DeepCopy());
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new LineItemComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as LineItemComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(SequenceElement, otherT.SequenceElement)) return false;
        if( !DeepComparable.Matches(Serviced, otherT.Serviced)) return false;
        if( !DeepComparable.Matches(ChargeItem, otherT.ChargeItem)) return false;
        if( !DeepComparable.Matches(PriceComponent, otherT.PriceComponent)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as LineItemComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(SequenceElement, otherT.SequenceElement)) return false;
        if( !DeepComparable.IsExactly(Serviced, otherT.Serviced)) return false;
        if( !DeepComparable.IsExactly(ChargeItem, otherT.ChargeItem)) return false;
        if( !DeepComparable.IsExactly(PriceComponent, otherT.PriceComponent)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (SequenceElement != null) yield return SequenceElement;
          if (Serviced != null) yield return Serviced;
          if (ChargeItem != null) yield return ChargeItem;
          foreach (var elem in PriceComponent) { if (elem != null) yield return elem; }
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (SequenceElement != null) yield return new ElementValue("sequence", SequenceElement);
          if (Serviced != null) yield return new ElementValue("serviced", Serviced);
          if (ChargeItem != null) yield return new ElementValue("chargeItem", ChargeItem);
          foreach (var elem in PriceComponent) { if (elem != null) yield return new ElementValue("priceComponent", elem); }
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "sequence":
            value = SequenceElement;
            return SequenceElement is not null;
          case "serviced":
            value = Serviced;
            return Serviced is not null;
          case "chargeItem":
            value = ChargeItem;
            return ChargeItem is not null;
          case "priceComponent":
            value = PriceComponent;
            return PriceComponent?.Any() == true;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (SequenceElement is not null) yield return new KeyValuePair<string,object>("sequence",SequenceElement);
        if (Serviced is not null) yield return new KeyValuePair<string,object>("serviced",Serviced);
        if (ChargeItem is not null) yield return new KeyValuePair<string,object>("chargeItem",ChargeItem);
        if (PriceComponent?.Any() == true) yield return new KeyValuePair<string,object>("priceComponent",PriceComponent);
      }

    }

    /// <summary>
    /// Business Identifier for item
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90, FiveWs="FiveWs.identifier")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// draft | issued | balanced | cancelled | entered-in-error
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=100, FiveWs="FiveWs.status")]
    [DeclaredType(Type = typeof(Code))]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.Invoice.InvoiceStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.Invoice.InvoiceStatus> _StatusElement;

    /// <summary>
    /// draft | issued | balanced | cancelled | entered-in-error
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.Invoice.InvoiceStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.Invoice.InvoiceStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Reason for cancellation of this Invoice
    /// </summary>
    [FhirElement("cancelledReason", Order=110)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString CancelledReasonElement
    {
      get { return _CancelledReasonElement; }
      set { _CancelledReasonElement = value; OnPropertyChanged("CancelledReasonElement"); }
    }

    private Hl7.Fhir.Model.FhirString _CancelledReasonElement;

    /// <summary>
    /// Reason for cancellation of this Invoice
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string CancelledReason
    {
      get { return CancelledReasonElement != null ? CancelledReasonElement.Value : null; }
      set
      {
        if (value == null)
          CancelledReasonElement = null;
        else
          CancelledReasonElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("CancelledReason");
      }
    }

    /// <summary>
    /// Type of Invoice
    /// </summary>
    [FhirElement("type", InSummary=true, Order=120, FiveWs="FiveWs.what[x]")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Type
    {
      get { return _Type; }
      set { _Type = value; OnPropertyChanged("Type"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Type;

    /// <summary>
    /// Recipient(s) of goods and services
    /// </summary>
    [FhirElement("subject", InSummary=true, Order=130, FiveWs="FiveWs.subject[x]")]
    [CLSCompliant(false)]
    [References("Patient","Group")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Subject
    {
      get { return _Subject; }
      set { _Subject = value; OnPropertyChanged("Subject"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Subject;

    /// <summary>
    /// Recipient of this invoice
    /// </summary>
    [FhirElement("recipient", InSummary=true, Order=140)]
    [CLSCompliant(false)]
    [References("Organization","Patient","RelatedPerson")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Recipient
    {
      get { return _Recipient; }
      set { _Recipient = value; OnPropertyChanged("Recipient"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Recipient;

    /// <summary>
    /// DEPRICATED
    /// </summary>
    [FhirElement("date", Order=150)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime DateElement
    {
      get { return _DateElement; }
      set { _DateElement = value; OnPropertyChanged("DateElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _DateElement;

    /// <summary>
    /// DEPRICATED
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Date
    {
      get { return DateElement != null ? DateElement.Value : null; }
      set
      {
        if (value == null)
          DateElement = null;
        else
          DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("Date");
      }
    }

    /// <summary>
    /// When posted
    /// </summary>
    [FhirElement("creation", InSummary=true, Order=160)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime CreationElement
    {
      get { return _CreationElement; }
      set { _CreationElement = value; OnPropertyChanged("CreationElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _CreationElement;

    /// <summary>
    /// When posted
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Creation
    {
      get { return CreationElement != null ? CreationElement.Value : null; }
      set
      {
        if (value == null)
          CreationElement = null;
        else
          CreationElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("Creation");
      }
    }

    /// <summary>
    /// Billing date or period
    /// </summary>
    [FhirElement("period", InSummary=true, Order=170, Choice=ChoiceType.DatatypeChoice)]
    [CLSCompliant(false)]
    [AllowedTypes(typeof(Hl7.Fhir.Model.Date),typeof(Hl7.Fhir.Model.Period))]
    [DataMember]
    public Hl7.Fhir.Model.DataType Period
    {
      get { return _Period; }
      set { _Period = value; OnPropertyChanged("Period"); }
    }

    private Hl7.Fhir.Model.DataType _Period;

    /// <summary>
    /// Participant in creation of this Invoice
    /// </summary>
    [FhirElement("participant", Order=180)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Invoice.ParticipantComponent> Participant
    {
      get { if(_Participant==null) _Participant = new List<Hl7.Fhir.Model.Invoice.ParticipantComponent>(); return _Participant; }
      set { _Participant = value; OnPropertyChanged("Participant"); }
    }

    private List<Hl7.Fhir.Model.Invoice.ParticipantComponent> _Participant;

    /// <summary>
    /// Issuing Organization of Invoice
    /// </summary>
    [FhirElement("issuer", Order=190)]
    [CLSCompliant(false)]
    [References("Organization")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Issuer
    {
      get { return _Issuer; }
      set { _Issuer = value; OnPropertyChanged("Issuer"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Issuer;

    /// <summary>
    /// Account that is being balanced
    /// </summary>
    [FhirElement("account", Order=200)]
    [CLSCompliant(false)]
    [References("Account")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Account
    {
      get { return _Account; }
      set { _Account = value; OnPropertyChanged("Account"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Account;

    /// <summary>
    /// Line items of this Invoice
    /// </summary>
    [FhirElement("lineItem", Order=210)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Invoice.LineItemComponent> LineItem
    {
      get { if(_LineItem==null) _LineItem = new List<Hl7.Fhir.Model.Invoice.LineItemComponent>(); return _LineItem; }
      set { _LineItem = value; OnPropertyChanged("LineItem"); }
    }

    private List<Hl7.Fhir.Model.Invoice.LineItemComponent> _LineItem;

    /// <summary>
    /// Components of Invoice total
    /// </summary>
    [FhirElement("totalPriceComponent", Order=220)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.MonetaryComponent> TotalPriceComponent
    {
      get { if(_TotalPriceComponent==null) _TotalPriceComponent = new List<Hl7.Fhir.Model.MonetaryComponent>(); return _TotalPriceComponent; }
      set { _TotalPriceComponent = value; OnPropertyChanged("TotalPriceComponent"); }
    }

    private List<Hl7.Fhir.Model.MonetaryComponent> _TotalPriceComponent;

    /// <summary>
    /// Net total of this Invoice
    /// </summary>
    [FhirElement("totalNet", InSummary=true, Order=230)]
    [DataMember]
    public Hl7.Fhir.Model.Money TotalNet
    {
      get { return _TotalNet; }
      set { _TotalNet = value; OnPropertyChanged("TotalNet"); }
    }

    private Hl7.Fhir.Model.Money _TotalNet;

    /// <summary>
    /// Gross total of this Invoice
    /// </summary>
    [FhirElement("totalGross", InSummary=true, Order=240)]
    [DataMember]
    public Hl7.Fhir.Model.Money TotalGross
    {
      get { return _TotalGross; }
      set { _TotalGross = value; OnPropertyChanged("TotalGross"); }
    }

    private Hl7.Fhir.Model.Money _TotalGross;

    /// <summary>
    /// Payment details
    /// </summary>
    [FhirElement("paymentTerms", Order=250)]
    [DataMember]
    public Hl7.Fhir.Model.Markdown PaymentTermsElement
    {
      get { return _PaymentTermsElement; }
      set { _PaymentTermsElement = value; OnPropertyChanged("PaymentTermsElement"); }
    }

    private Hl7.Fhir.Model.Markdown _PaymentTermsElement;

    /// <summary>
    /// Payment details
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string PaymentTerms
    {
      get { return PaymentTermsElement != null ? PaymentTermsElement.Value : null; }
      set
      {
        if (value == null)
          PaymentTermsElement = null;
        else
          PaymentTermsElement = new Hl7.Fhir.Model.Markdown(value);
        OnPropertyChanged("PaymentTerms");
      }
    }

    /// <summary>
    /// Comments made about the invoice
    /// </summary>
    [FhirElement("note", Order=260)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Annotation> Note
    {
      get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
      set { _Note = value; OnPropertyChanged("Note"); }
    }

    private List<Hl7.Fhir.Model.Annotation> _Note;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as Invoice;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.Invoice.InvoiceStatus>)StatusElement.DeepCopy();
      if(CancelledReasonElement != null) dest.CancelledReasonElement = (Hl7.Fhir.Model.FhirString)CancelledReasonElement.DeepCopy();
      if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
      if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
      if(Recipient != null) dest.Recipient = (Hl7.Fhir.Model.ResourceReference)Recipient.DeepCopy();
      if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
      if(CreationElement != null) dest.CreationElement = (Hl7.Fhir.Model.FhirDateTime)CreationElement.DeepCopy();
      if(Period != null) dest.Period = (Hl7.Fhir.Model.DataType)Period.DeepCopy();
      if(Participant != null) dest.Participant = new List<Hl7.Fhir.Model.Invoice.ParticipantComponent>(Participant.DeepCopy());
      if(Issuer != null) dest.Issuer = (Hl7.Fhir.Model.ResourceReference)Issuer.DeepCopy();
      if(Account != null) dest.Account = (Hl7.Fhir.Model.ResourceReference)Account.DeepCopy();
      if(LineItem != null) dest.LineItem = new List<Hl7.Fhir.Model.Invoice.LineItemComponent>(LineItem.DeepCopy());
      if(TotalPriceComponent != null) dest.TotalPriceComponent = new List<Hl7.Fhir.Model.MonetaryComponent>(TotalPriceComponent.DeepCopy());
      if(TotalNet != null) dest.TotalNet = (Hl7.Fhir.Model.Money)TotalNet.DeepCopy();
      if(TotalGross != null) dest.TotalGross = (Hl7.Fhir.Model.Money)TotalGross.DeepCopy();
      if(PaymentTermsElement != null) dest.PaymentTermsElement = (Hl7.Fhir.Model.Markdown)PaymentTermsElement.DeepCopy();
      if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new Invoice());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as Invoice;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(CancelledReasonElement, otherT.CancelledReasonElement)) return false;
      if( !DeepComparable.Matches(Type, otherT.Type)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(Recipient, otherT.Recipient)) return false;
      if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
      if( !DeepComparable.Matches(CreationElement, otherT.CreationElement)) return false;
      if( !DeepComparable.Matches(Period, otherT.Period)) return false;
      if( !DeepComparable.Matches(Participant, otherT.Participant)) return false;
      if( !DeepComparable.Matches(Issuer, otherT.Issuer)) return false;
      if( !DeepComparable.Matches(Account, otherT.Account)) return false;
      if( !DeepComparable.Matches(LineItem, otherT.LineItem)) return false;
      if( !DeepComparable.Matches(TotalPriceComponent, otherT.TotalPriceComponent)) return false;
      if( !DeepComparable.Matches(TotalNet, otherT.TotalNet)) return false;
      if( !DeepComparable.Matches(TotalGross, otherT.TotalGross)) return false;
      if( !DeepComparable.Matches(PaymentTermsElement, otherT.PaymentTermsElement)) return false;
      if( !DeepComparable.Matches(Note, otherT.Note)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as Invoice;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(CancelledReasonElement, otherT.CancelledReasonElement)) return false;
      if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;
      if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
      if( !DeepComparable.IsExactly(CreationElement, otherT.CreationElement)) return false;
      if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
      if( !DeepComparable.IsExactly(Participant, otherT.Participant)) return false;
      if( !DeepComparable.IsExactly(Issuer, otherT.Issuer)) return false;
      if( !DeepComparable.IsExactly(Account, otherT.Account)) return false;
      if( !DeepComparable.IsExactly(LineItem, otherT.LineItem)) return false;
      if( !DeepComparable.IsExactly(TotalPriceComponent, otherT.TotalPriceComponent)) return false;
      if( !DeepComparable.IsExactly(TotalNet, otherT.TotalNet)) return false;
      if( !DeepComparable.IsExactly(TotalGross, otherT.TotalGross)) return false;
      if( !DeepComparable.IsExactly(PaymentTermsElement, otherT.PaymentTermsElement)) return false;
      if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (StatusElement != null) yield return StatusElement;
        if (CancelledReasonElement != null) yield return CancelledReasonElement;
        if (Type != null) yield return Type;
        if (Subject != null) yield return Subject;
        if (Recipient != null) yield return Recipient;
        if (DateElement != null) yield return DateElement;
        if (CreationElement != null) yield return CreationElement;
        if (Period != null) yield return Period;
        foreach (var elem in Participant) { if (elem != null) yield return elem; }
        if (Issuer != null) yield return Issuer;
        if (Account != null) yield return Account;
        foreach (var elem in LineItem) { if (elem != null) yield return elem; }
        foreach (var elem in TotalPriceComponent) { if (elem != null) yield return elem; }
        if (TotalNet != null) yield return TotalNet;
        if (TotalGross != null) yield return TotalGross;
        if (PaymentTermsElement != null) yield return PaymentTermsElement;
        foreach (var elem in Note) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (CancelledReasonElement != null) yield return new ElementValue("cancelledReason", CancelledReasonElement);
        if (Type != null) yield return new ElementValue("type", Type);
        if (Subject != null) yield return new ElementValue("subject", Subject);
        if (Recipient != null) yield return new ElementValue("recipient", Recipient);
        if (DateElement != null) yield return new ElementValue("date", DateElement);
        if (CreationElement != null) yield return new ElementValue("creation", CreationElement);
        if (Period != null) yield return new ElementValue("period", Period);
        foreach (var elem in Participant) { if (elem != null) yield return new ElementValue("participant", elem); }
        if (Issuer != null) yield return new ElementValue("issuer", Issuer);
        if (Account != null) yield return new ElementValue("account", Account);
        foreach (var elem in LineItem) { if (elem != null) yield return new ElementValue("lineItem", elem); }
        foreach (var elem in TotalPriceComponent) { if (elem != null) yield return new ElementValue("totalPriceComponent", elem); }
        if (TotalNet != null) yield return new ElementValue("totalNet", TotalNet);
        if (TotalGross != null) yield return new ElementValue("totalGross", TotalGross);
        if (PaymentTermsElement != null) yield return new ElementValue("paymentTerms", PaymentTermsElement);
        foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "cancelledReason":
          value = CancelledReasonElement;
          return CancelledReasonElement is not null;
        case "type":
          value = Type;
          return Type is not null;
        case "subject":
          value = Subject;
          return Subject is not null;
        case "recipient":
          value = Recipient;
          return Recipient is not null;
        case "date":
          value = DateElement;
          return DateElement is not null;
        case "creation":
          value = CreationElement;
          return CreationElement is not null;
        case "period":
          value = Period;
          return Period is not null;
        case "participant":
          value = Participant;
          return Participant?.Any() == true;
        case "issuer":
          value = Issuer;
          return Issuer is not null;
        case "account":
          value = Account;
          return Account is not null;
        case "lineItem":
          value = LineItem;
          return LineItem?.Any() == true;
        case "totalPriceComponent":
          value = TotalPriceComponent;
          return TotalPriceComponent?.Any() == true;
        case "totalNet":
          value = TotalNet;
          return TotalNet is not null;
        case "totalGross":
          value = TotalGross;
          return TotalGross is not null;
        case "paymentTerms":
          value = PaymentTermsElement;
          return PaymentTermsElement is not null;
        case "note":
          value = Note;
          return Note?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (CancelledReasonElement is not null) yield return new KeyValuePair<string,object>("cancelledReason",CancelledReasonElement);
      if (Type is not null) yield return new KeyValuePair<string,object>("type",Type);
      if (Subject is not null) yield return new KeyValuePair<string,object>("subject",Subject);
      if (Recipient is not null) yield return new KeyValuePair<string,object>("recipient",Recipient);
      if (DateElement is not null) yield return new KeyValuePair<string,object>("date",DateElement);
      if (CreationElement is not null) yield return new KeyValuePair<string,object>("creation",CreationElement);
      if (Period is not null) yield return new KeyValuePair<string,object>("period",Period);
      if (Participant?.Any() == true) yield return new KeyValuePair<string,object>("participant",Participant);
      if (Issuer is not null) yield return new KeyValuePair<string,object>("issuer",Issuer);
      if (Account is not null) yield return new KeyValuePair<string,object>("account",Account);
      if (LineItem?.Any() == true) yield return new KeyValuePair<string,object>("lineItem",LineItem);
      if (TotalPriceComponent?.Any() == true) yield return new KeyValuePair<string,object>("totalPriceComponent",TotalPriceComponent);
      if (TotalNet is not null) yield return new KeyValuePair<string,object>("totalNet",TotalNet);
      if (TotalGross is not null) yield return new KeyValuePair<string,object>("totalGross",TotalGross);
      if (PaymentTermsElement is not null) yield return new KeyValuePair<string,object>("paymentTerms",PaymentTermsElement);
      if (Note?.Any() == true) yield return new KeyValuePair<string,object>("note",Note);
    }

  }

}

// end of file
