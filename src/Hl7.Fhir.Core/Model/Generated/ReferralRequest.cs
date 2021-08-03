// <auto-generated/>
// Contents of: hl7.fhir.r3.core version: 3.0.2

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
  /// A request for referral or transfer of care
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("ReferralRequest","http://hl7.org/fhir/StructureDefinition/ReferralRequest", IsResource=true)]
  public partial class ReferralRequest : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "ReferralRequest"; } }

    /// <summary>
    /// Who/what is requesting service
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("ReferralRequest#Requester", IsNestedType=true)]
    public partial class RequesterComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "ReferralRequest#Requester"; } }

      /// <summary>
      /// Individual making the request
      /// </summary>
      [FhirElement("agent", InSummary=true, Order=40)]
      [CLSCompliant(false)]
      [References("Practitioner","Organization","Patient","RelatedPerson","Device")]
      [Cardinality(Min=1,Max=1)]
      [DataMember]
      public Hl7.Fhir.Model.ResourceReference Agent
      {
        get { return _Agent; }
        set { _Agent = value; OnPropertyChanged("Agent"); }
      }

      private Hl7.Fhir.Model.ResourceReference _Agent;

      /// <summary>
      /// Organization agent is acting for
      /// </summary>
      [FhirElement("onBehalfOf", InSummary=true, Order=50)]
      [CLSCompliant(false)]
      [References("Organization")]
      [DataMember]
      public Hl7.Fhir.Model.ResourceReference OnBehalfOf
      {
        get { return _OnBehalfOf; }
        set { _OnBehalfOf = value; OnPropertyChanged("OnBehalfOf"); }
      }

      private Hl7.Fhir.Model.ResourceReference _OnBehalfOf;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as RequesterComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Agent != null) dest.Agent = (Hl7.Fhir.Model.ResourceReference)Agent.DeepCopy();
        if(OnBehalfOf != null) dest.OnBehalfOf = (Hl7.Fhir.Model.ResourceReference)OnBehalfOf.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new RequesterComponent());
      }

      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as RequesterComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Agent, otherT.Agent)) return false;
        if( !DeepComparable.Matches(OnBehalfOf, otherT.OnBehalfOf)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as RequesterComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Agent, otherT.Agent)) return false;
        if( !DeepComparable.IsExactly(OnBehalfOf, otherT.OnBehalfOf)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Agent != null) yield return Agent;
          if (OnBehalfOf != null) yield return OnBehalfOf;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Agent != null) yield return new ElementValue("agent", Agent);
          if (OnBehalfOf != null) yield return new ElementValue("onBehalfOf", OnBehalfOf);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "agent":
            value = Agent;
            return Agent is not null;
          case "onBehalfOf":
            value = OnBehalfOf;
            return OnBehalfOf is not null;
          default:
            return base.TryGetValue(key, out value);
        };

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Agent is not null) yield return new KeyValuePair<string,object>("agent",Agent);
        if (OnBehalfOf is not null) yield return new KeyValuePair<string,object>("onBehalfOf",OnBehalfOf);
      }

    }

    /// <summary>
    /// Business identifier
    /// </summary>
    [FhirElement("identifier", InSummary=true, Order=90)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// Instantiates protocol or definition
    /// </summary>
    [FhirElement("definition", InSummary=true, Order=100)]
    [CLSCompliant(false)]
    [References("ActivityDefinition","PlanDefinition")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Definition
    {
      get { if(_Definition==null) _Definition = new List<Hl7.Fhir.Model.ResourceReference>(); return _Definition; }
      set { _Definition = value; OnPropertyChanged("Definition"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Definition;

    /// <summary>
    /// Request fulfilled by this request
    /// </summary>
    [FhirElement("basedOn", InSummary=true, Order=110)]
    [CLSCompliant(false)]
    [References("ReferralRequest","CarePlan","ProcedureRequest")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> BasedOn
    {
      get { if(_BasedOn==null) _BasedOn = new List<Hl7.Fhir.Model.ResourceReference>(); return _BasedOn; }
      set { _BasedOn = value; OnPropertyChanged("BasedOn"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _BasedOn;

    /// <summary>
    /// Request(s) replaced by this request
    /// </summary>
    [FhirElement("replaces", InSummary=true, Order=120)]
    [CLSCompliant(false)]
    [References("ReferralRequest")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Replaces
    {
      get { if(_Replaces==null) _Replaces = new List<Hl7.Fhir.Model.ResourceReference>(); return _Replaces; }
      set { _Replaces = value; OnPropertyChanged("Replaces"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Replaces;

    /// <summary>
    /// Composite request this is part of
    /// </summary>
    [FhirElement("groupIdentifier", InSummary=true, Order=130)]
    [DataMember]
    public Hl7.Fhir.Model.Identifier GroupIdentifier
    {
      get { return _GroupIdentifier; }
      set { _GroupIdentifier = value; OnPropertyChanged("GroupIdentifier"); }
    }

    private Hl7.Fhir.Model.Identifier _GroupIdentifier;

    /// <summary>
    /// draft | active | suspended | cancelled | completed | entered-in-error | unknown
    /// </summary>
    [FhirElement("status", InSummary=true, Order=140)]
    [DeclaredType(Type = typeof(Code))]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.RequestStatus> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.RequestStatus> _StatusElement;

    /// <summary>
    /// draft | active | suspended | cancelled | completed | entered-in-error | unknown
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.RequestStatus? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.RequestStatus>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// proposal | plan | order
    /// </summary>
    [FhirElement("intent", InSummary=true, Order=150)]
    [DeclaredType(Type = typeof(Code))]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.RequestIntent> IntentElement
    {
      get { return _IntentElement; }
      set { _IntentElement = value; OnPropertyChanged("IntentElement"); }
    }

    private Code<Hl7.Fhir.Model.RequestIntent> _IntentElement;

    /// <summary>
    /// proposal | plan | order
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.RequestIntent? Intent
    {
      get { return IntentElement != null ? IntentElement.Value : null; }
      set
      {
        if (value == null)
          IntentElement = null;
        else
          IntentElement = new Code<Hl7.Fhir.Model.RequestIntent>(value);
        OnPropertyChanged("Intent");
      }
    }

    /// <summary>
    /// Referral/Transition of care request type
    /// </summary>
    [FhirElement("type", InSummary=true, Order=160)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Type
    {
      get { return _Type; }
      set { _Type = value; OnPropertyChanged("Type"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Type;

    /// <summary>
    /// Urgency of referral / transfer of care request
    /// </summary>
    [FhirElement("priority", InSummary=true, Order=170)]
    [DeclaredType(Type = typeof(Code))]
    [DataMember]
    public Code<Hl7.Fhir.Model.RequestPriority> PriorityElement
    {
      get { return _PriorityElement; }
      set { _PriorityElement = value; OnPropertyChanged("PriorityElement"); }
    }

    private Code<Hl7.Fhir.Model.RequestPriority> _PriorityElement;

    /// <summary>
    /// Urgency of referral / transfer of care request
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.RequestPriority? Priority
    {
      get { return PriorityElement != null ? PriorityElement.Value : null; }
      set
      {
        if (value == null)
          PriorityElement = null;
        else
          PriorityElement = new Code<Hl7.Fhir.Model.RequestPriority>(value);
        OnPropertyChanged("Priority");
      }
    }

    /// <summary>
    /// Actions requested as part of the referral
    /// </summary>
    [FhirElement("serviceRequested", InSummary=true, Order=180)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> ServiceRequested
    {
      get { if(_ServiceRequested==null) _ServiceRequested = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ServiceRequested; }
      set { _ServiceRequested = value; OnPropertyChanged("ServiceRequested"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _ServiceRequested;

    /// <summary>
    /// Patient referred to care or transfer
    /// </summary>
    [FhirElement("subject", InSummary=true, Order=190)]
    [CLSCompliant(false)]
    [References("Patient","Group")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Subject
    {
      get { return _Subject; }
      set { _Subject = value; OnPropertyChanged("Subject"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Subject;

    /// <summary>
    /// Originating encounter
    /// </summary>
    [FhirElement("context", InSummary=true, Order=200)]
    [CLSCompliant(false)]
    [References("Encounter","EpisodeOfCare")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Context
    {
      get { return _Context; }
      set { _Context = value; OnPropertyChanged("Context"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Context;

    /// <summary>
    /// When the service(s) requested in the referral should occur
    /// </summary>
    [FhirElement("occurrence", InSummary=true, Order=210, Choice=ChoiceType.DatatypeChoice)]
    [CLSCompliant(false)]
    [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Hl7.Fhir.Model.Period))]
    [DataMember]
    public Hl7.Fhir.Model.DataType Occurrence
    {
      get { return _Occurrence; }
      set { _Occurrence = value; OnPropertyChanged("Occurrence"); }
    }

    private Hl7.Fhir.Model.DataType _Occurrence;

    /// <summary>
    /// Date of creation/activation
    /// </summary>
    [FhirElement("authoredOn", InSummary=true, Order=220)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime AuthoredOnElement
    {
      get { return _AuthoredOnElement; }
      set { _AuthoredOnElement = value; OnPropertyChanged("AuthoredOnElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _AuthoredOnElement;

    /// <summary>
    /// Date of creation/activation
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string AuthoredOn
    {
      get { return AuthoredOnElement != null ? AuthoredOnElement.Value : null; }
      set
      {
        if (value == null)
          AuthoredOnElement = null;
        else
          AuthoredOnElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("AuthoredOn");
      }
    }

    /// <summary>
    /// Who/what is requesting service
    /// </summary>
    [FhirElement("requester", InSummary=true, Order=230)]
    [DataMember]
    public Hl7.Fhir.Model.ReferralRequest.RequesterComponent Requester
    {
      get { return _Requester; }
      set { _Requester = value; OnPropertyChanged("Requester"); }
    }

    private Hl7.Fhir.Model.ReferralRequest.RequesterComponent _Requester;

    /// <summary>
    /// The clinical specialty (discipline) that the referral is requested for
    /// </summary>
    [FhirElement("specialty", Order=240)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Specialty
    {
      get { return _Specialty; }
      set { _Specialty = value; OnPropertyChanged("Specialty"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Specialty;

    /// <summary>
    /// Receiver of referral / transfer of care request
    /// </summary>
    [FhirElement("recipient", InSummary=true, Order=250)]
    [CLSCompliant(false)]
    [References("Practitioner","Organization","HealthcareService")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Recipient
    {
      get { if(_Recipient==null) _Recipient = new List<Hl7.Fhir.Model.ResourceReference>(); return _Recipient; }
      set { _Recipient = value; OnPropertyChanged("Recipient"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Recipient;

    /// <summary>
    /// Reason for referral / transfer of care request
    /// </summary>
    [FhirElement("reasonCode", InSummary=true, Order=260)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> ReasonCode
    {
      get { if(_ReasonCode==null) _ReasonCode = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ReasonCode; }
      set { _ReasonCode = value; OnPropertyChanged("ReasonCode"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _ReasonCode;

    /// <summary>
    /// Why is service needed?
    /// </summary>
    [FhirElement("reasonReference", InSummary=true, Order=270)]
    [CLSCompliant(false)]
    [References("Condition","Observation")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> ReasonReference
    {
      get { if(_ReasonReference==null) _ReasonReference = new List<Hl7.Fhir.Model.ResourceReference>(); return _ReasonReference; }
      set { _ReasonReference = value; OnPropertyChanged("ReasonReference"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _ReasonReference;

    /// <summary>
    /// A textual description of the referral
    /// </summary>
    [FhirElement("description", Order=280)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString DescriptionElement
    {
      get { return _DescriptionElement; }
      set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
    }

    private Hl7.Fhir.Model.FhirString _DescriptionElement;

    /// <summary>
    /// A textual description of the referral
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Description
    {
      get { return DescriptionElement != null ? DescriptionElement.Value : null; }
      set
      {
        if (value == null)
          DescriptionElement = null;
        else
          DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Description");
      }
    }

    /// <summary>
    /// Additonal information to support referral or transfer of care request
    /// </summary>
    [FhirElement("supportingInfo", Order=290)]
    [CLSCompliant(false)]
    [References("Resource")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> SupportingInfo
    {
      get { if(_SupportingInfo==null) _SupportingInfo = new List<Hl7.Fhir.Model.ResourceReference>(); return _SupportingInfo; }
      set { _SupportingInfo = value; OnPropertyChanged("SupportingInfo"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _SupportingInfo;

    /// <summary>
    /// Comments made about referral request
    /// </summary>
    [FhirElement("note", Order=300)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Annotation> Note
    {
      get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
      set { _Note = value; OnPropertyChanged("Note"); }
    }

    private List<Hl7.Fhir.Model.Annotation> _Note;

    /// <summary>
    /// Key events in history of request
    /// </summary>
    [FhirElement("relevantHistory", Order=310)]
    [CLSCompliant(false)]
    [References("Provenance")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> RelevantHistory
    {
      get { if(_RelevantHistory==null) _RelevantHistory = new List<Hl7.Fhir.Model.ResourceReference>(); return _RelevantHistory; }
      set { _RelevantHistory = value; OnPropertyChanged("RelevantHistory"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _RelevantHistory;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as ReferralRequest;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(Definition != null) dest.Definition = new List<Hl7.Fhir.Model.ResourceReference>(Definition.DeepCopy());
      if(BasedOn != null) dest.BasedOn = new List<Hl7.Fhir.Model.ResourceReference>(BasedOn.DeepCopy());
      if(Replaces != null) dest.Replaces = new List<Hl7.Fhir.Model.ResourceReference>(Replaces.DeepCopy());
      if(GroupIdentifier != null) dest.GroupIdentifier = (Hl7.Fhir.Model.Identifier)GroupIdentifier.DeepCopy();
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.RequestStatus>)StatusElement.DeepCopy();
      if(IntentElement != null) dest.IntentElement = (Code<Hl7.Fhir.Model.RequestIntent>)IntentElement.DeepCopy();
      if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
      if(PriorityElement != null) dest.PriorityElement = (Code<Hl7.Fhir.Model.RequestPriority>)PriorityElement.DeepCopy();
      if(ServiceRequested != null) dest.ServiceRequested = new List<Hl7.Fhir.Model.CodeableConcept>(ServiceRequested.DeepCopy());
      if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
      if(Context != null) dest.Context = (Hl7.Fhir.Model.ResourceReference)Context.DeepCopy();
      if(Occurrence != null) dest.Occurrence = (Hl7.Fhir.Model.DataType)Occurrence.DeepCopy();
      if(AuthoredOnElement != null) dest.AuthoredOnElement = (Hl7.Fhir.Model.FhirDateTime)AuthoredOnElement.DeepCopy();
      if(Requester != null) dest.Requester = (Hl7.Fhir.Model.ReferralRequest.RequesterComponent)Requester.DeepCopy();
      if(Specialty != null) dest.Specialty = (Hl7.Fhir.Model.CodeableConcept)Specialty.DeepCopy();
      if(Recipient != null) dest.Recipient = new List<Hl7.Fhir.Model.ResourceReference>(Recipient.DeepCopy());
      if(ReasonCode != null) dest.ReasonCode = new List<Hl7.Fhir.Model.CodeableConcept>(ReasonCode.DeepCopy());
      if(ReasonReference != null) dest.ReasonReference = new List<Hl7.Fhir.Model.ResourceReference>(ReasonReference.DeepCopy());
      if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
      if(SupportingInfo != null) dest.SupportingInfo = new List<Hl7.Fhir.Model.ResourceReference>(SupportingInfo.DeepCopy());
      if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
      if(RelevantHistory != null) dest.RelevantHistory = new List<Hl7.Fhir.Model.ResourceReference>(RelevantHistory.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new ReferralRequest());
    }

    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as ReferralRequest;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(Definition, otherT.Definition)) return false;
      if( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.Matches(Replaces, otherT.Replaces)) return false;
      if( !DeepComparable.Matches(GroupIdentifier, otherT.GroupIdentifier)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(IntentElement, otherT.IntentElement)) return false;
      if( !DeepComparable.Matches(Type, otherT.Type)) return false;
      if( !DeepComparable.Matches(PriorityElement, otherT.PriorityElement)) return false;
      if( !DeepComparable.Matches(ServiceRequested, otherT.ServiceRequested)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(Context, otherT.Context)) return false;
      if( !DeepComparable.Matches(Occurrence, otherT.Occurrence)) return false;
      if( !DeepComparable.Matches(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
      if( !DeepComparable.Matches(Requester, otherT.Requester)) return false;
      if( !DeepComparable.Matches(Specialty, otherT.Specialty)) return false;
      if( !DeepComparable.Matches(Recipient, otherT.Recipient)) return false;
      if( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
      if( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
      if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.Matches(SupportingInfo, otherT.SupportingInfo)) return false;
      if( !DeepComparable.Matches(Note, otherT.Note)) return false;
      if( !DeepComparable.Matches(RelevantHistory, otherT.RelevantHistory)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as ReferralRequest;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(Definition, otherT.Definition)) return false;
      if( !DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.IsExactly(Replaces, otherT.Replaces)) return false;
      if( !DeepComparable.IsExactly(GroupIdentifier, otherT.GroupIdentifier)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(IntentElement, otherT.IntentElement)) return false;
      if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
      if( !DeepComparable.IsExactly(PriorityElement, otherT.PriorityElement)) return false;
      if( !DeepComparable.IsExactly(ServiceRequested, otherT.ServiceRequested)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(Context, otherT.Context)) return false;
      if( !DeepComparable.IsExactly(Occurrence, otherT.Occurrence)) return false;
      if( !DeepComparable.IsExactly(AuthoredOnElement, otherT.AuthoredOnElement)) return false;
      if( !DeepComparable.IsExactly(Requester, otherT.Requester)) return false;
      if( !DeepComparable.IsExactly(Specialty, otherT.Specialty)) return false;
      if( !DeepComparable.IsExactly(Recipient, otherT.Recipient)) return false;
      if( !DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
      if( !DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
      if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
      if( !DeepComparable.IsExactly(SupportingInfo, otherT.SupportingInfo)) return false;
      if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
      if( !DeepComparable.IsExactly(RelevantHistory, otherT.RelevantHistory)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        foreach (var elem in Definition) { if (elem != null) yield return elem; }
        foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
        foreach (var elem in Replaces) { if (elem != null) yield return elem; }
        if (GroupIdentifier != null) yield return GroupIdentifier;
        if (StatusElement != null) yield return StatusElement;
        if (IntentElement != null) yield return IntentElement;
        if (Type != null) yield return Type;
        if (PriorityElement != null) yield return PriorityElement;
        foreach (var elem in ServiceRequested) { if (elem != null) yield return elem; }
        if (Subject != null) yield return Subject;
        if (Context != null) yield return Context;
        if (Occurrence != null) yield return Occurrence;
        if (AuthoredOnElement != null) yield return AuthoredOnElement;
        if (Requester != null) yield return Requester;
        if (Specialty != null) yield return Specialty;
        foreach (var elem in Recipient) { if (elem != null) yield return elem; }
        foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
        foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
        if (DescriptionElement != null) yield return DescriptionElement;
        foreach (var elem in SupportingInfo) { if (elem != null) yield return elem; }
        foreach (var elem in Note) { if (elem != null) yield return elem; }
        foreach (var elem in RelevantHistory) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        foreach (var elem in Definition) { if (elem != null) yield return new ElementValue("definition", elem); }
        foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
        foreach (var elem in Replaces) { if (elem != null) yield return new ElementValue("replaces", elem); }
        if (GroupIdentifier != null) yield return new ElementValue("groupIdentifier", GroupIdentifier);
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        if (IntentElement != null) yield return new ElementValue("intent", IntentElement);
        if (Type != null) yield return new ElementValue("type", Type);
        if (PriorityElement != null) yield return new ElementValue("priority", PriorityElement);
        foreach (var elem in ServiceRequested) { if (elem != null) yield return new ElementValue("serviceRequested", elem); }
        if (Subject != null) yield return new ElementValue("subject", Subject);
        if (Context != null) yield return new ElementValue("context", Context);
        if (Occurrence != null) yield return new ElementValue("occurrence", Occurrence);
        if (AuthoredOnElement != null) yield return new ElementValue("authoredOn", AuthoredOnElement);
        if (Requester != null) yield return new ElementValue("requester", Requester);
        if (Specialty != null) yield return new ElementValue("specialty", Specialty);
        foreach (var elem in Recipient) { if (elem != null) yield return new ElementValue("recipient", elem); }
        foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
        foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
        if (DescriptionElement != null) yield return new ElementValue("description", DescriptionElement);
        foreach (var elem in SupportingInfo) { if (elem != null) yield return new ElementValue("supportingInfo", elem); }
        foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
        foreach (var elem in RelevantHistory) { if (elem != null) yield return new ElementValue("relevantHistory", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "definition":
          value = Definition;
          return Definition?.Any() == true;
        case "basedOn":
          value = BasedOn;
          return BasedOn?.Any() == true;
        case "replaces":
          value = Replaces;
          return Replaces?.Any() == true;
        case "groupIdentifier":
          value = GroupIdentifier;
          return GroupIdentifier is not null;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "intent":
          value = IntentElement;
          return IntentElement is not null;
        case "type":
          value = Type;
          return Type is not null;
        case "priority":
          value = PriorityElement;
          return PriorityElement is not null;
        case "serviceRequested":
          value = ServiceRequested;
          return ServiceRequested?.Any() == true;
        case "subject":
          value = Subject;
          return Subject is not null;
        case "context":
          value = Context;
          return Context is not null;
        case "occurrence":
          value = Occurrence;
          return Occurrence is not null;
        case "authoredOn":
          value = AuthoredOnElement;
          return AuthoredOnElement is not null;
        case "requester":
          value = Requester;
          return Requester is not null;
        case "specialty":
          value = Specialty;
          return Specialty is not null;
        case "recipient":
          value = Recipient;
          return Recipient?.Any() == true;
        case "reasonCode":
          value = ReasonCode;
          return ReasonCode?.Any() == true;
        case "reasonReference":
          value = ReasonReference;
          return ReasonReference?.Any() == true;
        case "description":
          value = DescriptionElement;
          return DescriptionElement is not null;
        case "supportingInfo":
          value = SupportingInfo;
          return SupportingInfo?.Any() == true;
        case "note":
          value = Note;
          return Note?.Any() == true;
        case "relevantHistory":
          value = RelevantHistory;
          return RelevantHistory?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      };

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (Definition?.Any() == true) yield return new KeyValuePair<string,object>("definition",Definition);
      if (BasedOn?.Any() == true) yield return new KeyValuePair<string,object>("basedOn",BasedOn);
      if (Replaces?.Any() == true) yield return new KeyValuePair<string,object>("replaces",Replaces);
      if (GroupIdentifier is not null) yield return new KeyValuePair<string,object>("groupIdentifier",GroupIdentifier);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (IntentElement is not null) yield return new KeyValuePair<string,object>("intent",IntentElement);
      if (Type is not null) yield return new KeyValuePair<string,object>("type",Type);
      if (PriorityElement is not null) yield return new KeyValuePair<string,object>("priority",PriorityElement);
      if (ServiceRequested?.Any() == true) yield return new KeyValuePair<string,object>("serviceRequested",ServiceRequested);
      if (Subject is not null) yield return new KeyValuePair<string,object>("subject",Subject);
      if (Context is not null) yield return new KeyValuePair<string,object>("context",Context);
      if (Occurrence is not null) yield return new KeyValuePair<string,object>("occurrence",Occurrence);
      if (AuthoredOnElement is not null) yield return new KeyValuePair<string,object>("authoredOn",AuthoredOnElement);
      if (Requester is not null) yield return new KeyValuePair<string,object>("requester",Requester);
      if (Specialty is not null) yield return new KeyValuePair<string,object>("specialty",Specialty);
      if (Recipient?.Any() == true) yield return new KeyValuePair<string,object>("recipient",Recipient);
      if (ReasonCode?.Any() == true) yield return new KeyValuePair<string,object>("reasonCode",ReasonCode);
      if (ReasonReference?.Any() == true) yield return new KeyValuePair<string,object>("reasonReference",ReasonReference);
      if (DescriptionElement is not null) yield return new KeyValuePair<string,object>("description",DescriptionElement);
      if (SupportingInfo?.Any() == true) yield return new KeyValuePair<string,object>("supportingInfo",SupportingInfo);
      if (Note?.Any() == true) yield return new KeyValuePair<string,object>("note",Note);
      if (RelevantHistory?.Any() == true) yield return new KeyValuePair<string,object>("relevantHistory",RelevantHistory);
    }

  }

}

// end of file
