// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

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
  /// Record of medication being taken by a patient
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("MedicationStatement","http://hl7.org/fhir/StructureDefinition/MedicationStatement", IsResource=true)]
  public partial class MedicationStatement : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "MedicationStatement"; } }

    /// <summary>
    /// Medication Status Codes
    /// (url: http://hl7.org/fhir/ValueSet/medication-statement-status)
    /// (system: http://hl7.org/fhir/CodeSystem/medication-statement-status)
    /// </summary>
    [FhirEnumeration("MedicationStatusCodes", "http://hl7.org/fhir/ValueSet/medication-statement-status", "http://hl7.org/fhir/CodeSystem/medication-statement-status")]
    public enum MedicationStatusCodes
    {
      /// <summary>
      /// The medication is still being taken.
      /// (system: http://hl7.org/fhir/CodeSystem/medication-statement-status)
      /// </summary>
      [EnumLiteral("active"), Description("Active")]
      Active,
      /// <summary>
      /// The medication is no longer being taken.
      /// (system: http://hl7.org/fhir/CodeSystem/medication-statement-status)
      /// </summary>
      [EnumLiteral("completed"), Description("Completed")]
      Completed,
      /// <summary>
      /// Some of the actions that are implied by the medication statement may have occurred.  For example, the patient may have taken some of the medication.  Clinical decision support systems should take this status into account.
      /// (system: http://hl7.org/fhir/CodeSystem/medication-statement-status)
      /// </summary>
      [EnumLiteral("entered-in-error"), Description("Entered in Error")]
      EnteredInError,
      /// <summary>
      /// The medication may be taken at some time in the future.
      /// (system: http://hl7.org/fhir/CodeSystem/medication-statement-status)
      /// </summary>
      [EnumLiteral("intended"), Description("Intended")]
      Intended,
      /// <summary>
      /// Actions implied by the statement have been permanently halted, before all of them occurred. This should not be used if the statement was entered in error.
      /// (system: http://hl7.org/fhir/CodeSystem/medication-statement-status)
      /// </summary>
      [EnumLiteral("stopped"), Description("Stopped")]
      Stopped,
      /// <summary>
      /// Actions implied by the statement have been temporarily halted, but are expected to continue later. May also be called 'suspended'.
      /// (system: http://hl7.org/fhir/CodeSystem/medication-statement-status)
      /// </summary>
      [EnumLiteral("on-hold"), Description("On Hold")]
      OnHold,
      /// <summary>
      /// The state of the medication use is not currently known.
      /// (system: http://hl7.org/fhir/CodeSystem/medication-statement-status)
      /// </summary>
      [EnumLiteral("unknown"), Description("Unknown")]
      Unknown,
      /// <summary>
      /// The medication was not consumed by the patient
      /// (system: http://hl7.org/fhir/CodeSystem/medication-statement-status)
      /// </summary>
      [EnumLiteral("not-taken"), Description("Not Taken")]
      NotTaken,
    }

    /// <summary>
    /// External identifier
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
    /// Fulfils plan, proposal or order
    /// </summary>
    [FhirElement("basedOn", InSummary=true, Order=100)]
    [CLSCompliant(false)]
    [References("MedicationRequest","CarePlan","ServiceRequest")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> BasedOn
    {
      get { if(_BasedOn==null) _BasedOn = new List<Hl7.Fhir.Model.ResourceReference>(); return _BasedOn; }
      set { _BasedOn = value; OnPropertyChanged("BasedOn"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _BasedOn;

    /// <summary>
    /// Part of referenced event
    /// </summary>
    [FhirElement("partOf", InSummary=true, Order=110)]
    [CLSCompliant(false)]
    [References("MedicationAdministration","MedicationDispense","MedicationStatement","Procedure","Observation")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> PartOf
    {
      get { if(_PartOf==null) _PartOf = new List<Hl7.Fhir.Model.ResourceReference>(); return _PartOf; }
      set { _PartOf = value; OnPropertyChanged("PartOf"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _PartOf;

    /// <summary>
    /// active | completed | entered-in-error | intended | stopped | on-hold | unknown | not-taken
    /// </summary>
    [FhirElement("status", InSummary=true, IsModifier=true, Order=120, FiveWs="FiveWs.status")]
    [DeclaredType(Type = typeof(Code))]
    [Binding("MedicationStatementStatus")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.MedicationStatement.MedicationStatusCodes> StatusElement
    {
      get { return _StatusElement; }
      set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
    }

    private Code<Hl7.Fhir.Model.MedicationStatement.MedicationStatusCodes> _StatusElement;

    /// <summary>
    /// active | completed | entered-in-error | intended | stopped | on-hold | unknown | not-taken
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.MedicationStatement.MedicationStatusCodes? Status
    {
      get { return StatusElement != null ? StatusElement.Value : null; }
      set
      {
        if (value == null)
          StatusElement = null;
        else
          StatusElement = new Code<Hl7.Fhir.Model.MedicationStatement.MedicationStatusCodes>(value);
        OnPropertyChanged("Status");
      }
    }

    /// <summary>
    /// Reason for current status
    /// </summary>
    [FhirElement("statusReason", Order=130)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> StatusReason
    {
      get { if(_StatusReason==null) _StatusReason = new List<Hl7.Fhir.Model.CodeableConcept>(); return _StatusReason; }
      set { _StatusReason = value; OnPropertyChanged("StatusReason"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _StatusReason;

    /// <summary>
    /// Type of medication usage
    /// </summary>
    [FhirElement("category", InSummary=true, Order=140, FiveWs="FiveWs.class")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Category
    {
      get { return _Category; }
      set { _Category = value; OnPropertyChanged("Category"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Category;

    /// <summary>
    /// What medication was taken
    /// </summary>
    [FhirElement("medication", InSummary=true, Order=150, Choice=ChoiceType.DatatypeChoice, FiveWs="FiveWs.what[x]")]
    [CLSCompliant(false)]
    [References("Medication")]
    [AllowedTypes(typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.ResourceReference))]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.DataType Medication
    {
      get { return _Medication; }
      set { _Medication = value; OnPropertyChanged("Medication"); }
    }

    private Hl7.Fhir.Model.DataType _Medication;

    /// <summary>
    /// Who is/was taking  the medication
    /// </summary>
    [FhirElement("subject", InSummary=true, Order=160, FiveWs="FiveWs.subject")]
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
    /// Encounter / Episode associated with MedicationStatement
    /// </summary>
    [FhirElement("context", InSummary=true, Order=170)]
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
    /// The date/time or interval when the medication is/was/will be taken
    /// </summary>
    [FhirElement("effective", InSummary=true, Order=180, Choice=ChoiceType.DatatypeChoice, FiveWs="FiveWs.done[x]")]
    [CLSCompliant(false)]
    [AllowedTypes(typeof(Hl7.Fhir.Model.FhirDateTime),typeof(Hl7.Fhir.Model.Period))]
    [DataMember]
    public Hl7.Fhir.Model.DataType Effective
    {
      get { return _Effective; }
      set { _Effective = value; OnPropertyChanged("Effective"); }
    }

    private Hl7.Fhir.Model.DataType _Effective;

    /// <summary>
    /// When the statement was asserted?
    /// </summary>
    [FhirElement("dateAsserted", InSummary=true, Order=190, FiveWs="FiveWs.recorded")]
    [DataMember]
    public Hl7.Fhir.Model.FhirDateTime DateAssertedElement
    {
      get { return _DateAssertedElement; }
      set { _DateAssertedElement = value; OnPropertyChanged("DateAssertedElement"); }
    }

    private Hl7.Fhir.Model.FhirDateTime _DateAssertedElement;

    /// <summary>
    /// When the statement was asserted?
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string DateAsserted
    {
      get { return DateAssertedElement != null ? DateAssertedElement.Value : null; }
      set
      {
        if (value == null)
          DateAssertedElement = null;
        else
          DateAssertedElement = new Hl7.Fhir.Model.FhirDateTime(value);
        OnPropertyChanged("DateAsserted");
      }
    }

    /// <summary>
    /// Person or organization that provided the information about the taking of this medication
    /// </summary>
    [FhirElement("informationSource", Order=200, FiveWs="FiveWs.source")]
    [CLSCompliant(false)]
    [References("Patient","Practitioner","PractitionerRole","RelatedPerson","Organization")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference InformationSource
    {
      get { return _InformationSource; }
      set { _InformationSource = value; OnPropertyChanged("InformationSource"); }
    }

    private Hl7.Fhir.Model.ResourceReference _InformationSource;

    /// <summary>
    /// Additional supporting information
    /// </summary>
    [FhirElement("derivedFrom", Order=210)]
    [CLSCompliant(false)]
    [References("Resource")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> DerivedFrom
    {
      get { if(_DerivedFrom==null) _DerivedFrom = new List<Hl7.Fhir.Model.ResourceReference>(); return _DerivedFrom; }
      set { _DerivedFrom = value; OnPropertyChanged("DerivedFrom"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _DerivedFrom;

    /// <summary>
    /// Reason for why the medication is being/was taken
    /// </summary>
    [FhirElement("reasonCode", Order=220, FiveWs="FiveWs.why[x]")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> ReasonCode
    {
      get { if(_ReasonCode==null) _ReasonCode = new List<Hl7.Fhir.Model.CodeableConcept>(); return _ReasonCode; }
      set { _ReasonCode = value; OnPropertyChanged("ReasonCode"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _ReasonCode;

    /// <summary>
    /// Condition or observation that supports why the medication is being/was taken
    /// </summary>
    [FhirElement("reasonReference", Order=230, FiveWs="FiveWs.why[x]")]
    [CLSCompliant(false)]
    [References("Condition","Observation","DiagnosticReport")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> ReasonReference
    {
      get { if(_ReasonReference==null) _ReasonReference = new List<Hl7.Fhir.Model.ResourceReference>(); return _ReasonReference; }
      set { _ReasonReference = value; OnPropertyChanged("ReasonReference"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _ReasonReference;

    /// <summary>
    /// Further information about the statement
    /// </summary>
    [FhirElement("note", Order=240)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Annotation> Note
    {
      get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
      set { _Note = value; OnPropertyChanged("Note"); }
    }

    private List<Hl7.Fhir.Model.Annotation> _Note;

    /// <summary>
    /// Details of how medication is/was taken or should be taken
    /// </summary>
    [FhirElement("dosage", Order=250)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Dosage> Dosage
    {
      get { if(_Dosage==null) _Dosage = new List<Hl7.Fhir.Model.Dosage>(); return _Dosage; }
      set { _Dosage = value; OnPropertyChanged("Dosage"); }
    }

    private List<Hl7.Fhir.Model.Dosage> _Dosage;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as MedicationStatement;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(BasedOn != null) dest.BasedOn = new List<Hl7.Fhir.Model.ResourceReference>(BasedOn.DeepCopy());
      if(PartOf != null) dest.PartOf = new List<Hl7.Fhir.Model.ResourceReference>(PartOf.DeepCopy());
      if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.MedicationStatement.MedicationStatusCodes>)StatusElement.DeepCopy();
      if(StatusReason != null) dest.StatusReason = new List<Hl7.Fhir.Model.CodeableConcept>(StatusReason.DeepCopy());
      if(Category != null) dest.Category = (Hl7.Fhir.Model.CodeableConcept)Category.DeepCopy();
      if(Medication != null) dest.Medication = (Hl7.Fhir.Model.DataType)Medication.DeepCopy();
      if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
      if(Context != null) dest.Context = (Hl7.Fhir.Model.ResourceReference)Context.DeepCopy();
      if(Effective != null) dest.Effective = (Hl7.Fhir.Model.DataType)Effective.DeepCopy();
      if(DateAssertedElement != null) dest.DateAssertedElement = (Hl7.Fhir.Model.FhirDateTime)DateAssertedElement.DeepCopy();
      if(InformationSource != null) dest.InformationSource = (Hl7.Fhir.Model.ResourceReference)InformationSource.DeepCopy();
      if(DerivedFrom != null) dest.DerivedFrom = new List<Hl7.Fhir.Model.ResourceReference>(DerivedFrom.DeepCopy());
      if(ReasonCode != null) dest.ReasonCode = new List<Hl7.Fhir.Model.CodeableConcept>(ReasonCode.DeepCopy());
      if(ReasonReference != null) dest.ReasonReference = new List<Hl7.Fhir.Model.ResourceReference>(ReasonReference.DeepCopy());
      if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
      if(Dosage != null) dest.Dosage = new List<Hl7.Fhir.Model.Dosage>(Dosage.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new MedicationStatement());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as MedicationStatement;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.Matches(PartOf, otherT.PartOf)) return false;
      if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.Matches(StatusReason, otherT.StatusReason)) return false;
      if( !DeepComparable.Matches(Category, otherT.Category)) return false;
      if( !DeepComparable.Matches(Medication, otherT.Medication)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(Context, otherT.Context)) return false;
      if( !DeepComparable.Matches(Effective, otherT.Effective)) return false;
      if( !DeepComparable.Matches(DateAssertedElement, otherT.DateAssertedElement)) return false;
      if( !DeepComparable.Matches(InformationSource, otherT.InformationSource)) return false;
      if( !DeepComparable.Matches(DerivedFrom, otherT.DerivedFrom)) return false;
      if( !DeepComparable.Matches(ReasonCode, otherT.ReasonCode)) return false;
      if( !DeepComparable.Matches(ReasonReference, otherT.ReasonReference)) return false;
      if( !DeepComparable.Matches(Note, otherT.Note)) return false;
      if( !DeepComparable.Matches(Dosage, otherT.Dosage)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as MedicationStatement;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(BasedOn, otherT.BasedOn)) return false;
      if( !DeepComparable.IsExactly(PartOf, otherT.PartOf)) return false;
      if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
      if( !DeepComparable.IsExactly(StatusReason, otherT.StatusReason)) return false;
      if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
      if( !DeepComparable.IsExactly(Medication, otherT.Medication)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(Context, otherT.Context)) return false;
      if( !DeepComparable.IsExactly(Effective, otherT.Effective)) return false;
      if( !DeepComparable.IsExactly(DateAssertedElement, otherT.DateAssertedElement)) return false;
      if( !DeepComparable.IsExactly(InformationSource, otherT.InformationSource)) return false;
      if( !DeepComparable.IsExactly(DerivedFrom, otherT.DerivedFrom)) return false;
      if( !DeepComparable.IsExactly(ReasonCode, otherT.ReasonCode)) return false;
      if( !DeepComparable.IsExactly(ReasonReference, otherT.ReasonReference)) return false;
      if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
      if( !DeepComparable.IsExactly(Dosage, otherT.Dosage)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        foreach (var elem in BasedOn) { if (elem != null) yield return elem; }
        foreach (var elem in PartOf) { if (elem != null) yield return elem; }
        if (StatusElement != null) yield return StatusElement;
        foreach (var elem in StatusReason) { if (elem != null) yield return elem; }
        if (Category != null) yield return Category;
        if (Medication != null) yield return Medication;
        if (Subject != null) yield return Subject;
        if (Context != null) yield return Context;
        if (Effective != null) yield return Effective;
        if (DateAssertedElement != null) yield return DateAssertedElement;
        if (InformationSource != null) yield return InformationSource;
        foreach (var elem in DerivedFrom) { if (elem != null) yield return elem; }
        foreach (var elem in ReasonCode) { if (elem != null) yield return elem; }
        foreach (var elem in ReasonReference) { if (elem != null) yield return elem; }
        foreach (var elem in Note) { if (elem != null) yield return elem; }
        foreach (var elem in Dosage) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        foreach (var elem in BasedOn) { if (elem != null) yield return new ElementValue("basedOn", elem); }
        foreach (var elem in PartOf) { if (elem != null) yield return new ElementValue("partOf", elem); }
        if (StatusElement != null) yield return new ElementValue("status", StatusElement);
        foreach (var elem in StatusReason) { if (elem != null) yield return new ElementValue("statusReason", elem); }
        if (Category != null) yield return new ElementValue("category", Category);
        if (Medication != null) yield return new ElementValue("medication", Medication);
        if (Subject != null) yield return new ElementValue("subject", Subject);
        if (Context != null) yield return new ElementValue("context", Context);
        if (Effective != null) yield return new ElementValue("effective", Effective);
        if (DateAssertedElement != null) yield return new ElementValue("dateAsserted", DateAssertedElement);
        if (InformationSource != null) yield return new ElementValue("informationSource", InformationSource);
        foreach (var elem in DerivedFrom) { if (elem != null) yield return new ElementValue("derivedFrom", elem); }
        foreach (var elem in ReasonCode) { if (elem != null) yield return new ElementValue("reasonCode", elem); }
        foreach (var elem in ReasonReference) { if (elem != null) yield return new ElementValue("reasonReference", elem); }
        foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
        foreach (var elem in Dosage) { if (elem != null) yield return new ElementValue("dosage", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "basedOn":
          value = BasedOn;
          return BasedOn?.Any() == true;
        case "partOf":
          value = PartOf;
          return PartOf?.Any() == true;
        case "status":
          value = StatusElement;
          return StatusElement is not null;
        case "statusReason":
          value = StatusReason;
          return StatusReason?.Any() == true;
        case "category":
          value = Category;
          return Category is not null;
        case "medication":
          value = Medication;
          return Medication is not null;
        case "subject":
          value = Subject;
          return Subject is not null;
        case "context":
          value = Context;
          return Context is not null;
        case "effective":
          value = Effective;
          return Effective is not null;
        case "dateAsserted":
          value = DateAssertedElement;
          return DateAssertedElement is not null;
        case "informationSource":
          value = InformationSource;
          return InformationSource is not null;
        case "derivedFrom":
          value = DerivedFrom;
          return DerivedFrom?.Any() == true;
        case "reasonCode":
          value = ReasonCode;
          return ReasonCode?.Any() == true;
        case "reasonReference":
          value = ReasonReference;
          return ReasonReference?.Any() == true;
        case "note":
          value = Note;
          return Note?.Any() == true;
        case "dosage":
          value = Dosage;
          return Dosage?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (BasedOn?.Any() == true) yield return new KeyValuePair<string,object>("basedOn",BasedOn);
      if (PartOf?.Any() == true) yield return new KeyValuePair<string,object>("partOf",PartOf);
      if (StatusElement is not null) yield return new KeyValuePair<string,object>("status",StatusElement);
      if (StatusReason?.Any() == true) yield return new KeyValuePair<string,object>("statusReason",StatusReason);
      if (Category is not null) yield return new KeyValuePair<string,object>("category",Category);
      if (Medication is not null) yield return new KeyValuePair<string,object>("medication",Medication);
      if (Subject is not null) yield return new KeyValuePair<string,object>("subject",Subject);
      if (Context is not null) yield return new KeyValuePair<string,object>("context",Context);
      if (Effective is not null) yield return new KeyValuePair<string,object>("effective",Effective);
      if (DateAssertedElement is not null) yield return new KeyValuePair<string,object>("dateAsserted",DateAssertedElement);
      if (InformationSource is not null) yield return new KeyValuePair<string,object>("informationSource",InformationSource);
      if (DerivedFrom?.Any() == true) yield return new KeyValuePair<string,object>("derivedFrom",DerivedFrom);
      if (ReasonCode?.Any() == true) yield return new KeyValuePair<string,object>("reasonCode",ReasonCode);
      if (ReasonReference?.Any() == true) yield return new KeyValuePair<string,object>("reasonReference",ReasonReference);
      if (Note?.Any() == true) yield return new KeyValuePair<string,object>("note",Note);
      if (Dosage?.Any() == true) yield return new KeyValuePair<string,object>("dosage",Dosage);
    }

  }

}

// end of file
