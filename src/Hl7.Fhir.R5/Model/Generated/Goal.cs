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
  /// Describes the intended objective(s) for a patient, group or organization
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("Goal","http://hl7.org/fhir/StructureDefinition/Goal", IsResource=true)]
  public partial class Goal : Hl7.Fhir.Model.DomainResource
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "Goal"; } }

    /// <summary>
    /// Codes that reflect the current state of a goal and whether the goal is still being targeted.
    /// (url: http://hl7.org/fhir/ValueSet/goal-status)
    /// (system: http://hl7.org/fhir/goal-status)
    /// </summary>
    [FhirEnumeration("GoalLifecycleStatus", "http://hl7.org/fhir/ValueSet/goal-status")]
    public enum GoalLifecycleStatus
    {
      /// <summary>
      /// A goal is proposed for this patient.
      /// (system: http://hl7.org/fhir/goal-status)
      /// </summary>
      [EnumLiteral("proposed", "http://hl7.org/fhir/goal-status"), Description("Proposed")]
      Proposed,
      /// <summary>
      /// A goal is planned for this patient.
      /// (system: http://hl7.org/fhir/goal-status)
      /// </summary>
      [EnumLiteral("planned", "http://hl7.org/fhir/goal-status"), Description("Planned")]
      Planned,
      /// <summary>
      /// A proposed goal was accepted or acknowledged.
      /// (system: http://hl7.org/fhir/goal-status)
      /// </summary>
      [EnumLiteral("accepted", "http://hl7.org/fhir/goal-status"), Description("Accepted")]
      Accepted,
      /// <summary>
      /// The goal is being sought actively.
      /// (system: http://hl7.org/fhir/goal-status)
      /// </summary>
      [EnumLiteral("active", "http://hl7.org/fhir/goal-status"), Description("Active")]
      Active,
      /// <summary>
      /// The goal remains a long term objective but is no longer being actively pursued for a temporary period of time.
      /// (system: http://hl7.org/fhir/goal-status)
      /// </summary>
      [EnumLiteral("on-hold", "http://hl7.org/fhir/goal-status"), Description("On Hold")]
      OnHold,
      /// <summary>
      /// The goal is no longer being sought.
      /// (system: http://hl7.org/fhir/goal-status)
      /// </summary>
      [EnumLiteral("completed", "http://hl7.org/fhir/goal-status"), Description("Completed")]
      Completed,
      /// <summary>
      /// The goal has been abandoned.
      /// (system: http://hl7.org/fhir/goal-status)
      /// </summary>
      [EnumLiteral("cancelled", "http://hl7.org/fhir/goal-status"), Description("Cancelled")]
      Cancelled,
      /// <summary>
      /// The goal was entered in error and voided.
      /// (system: http://hl7.org/fhir/goal-status)
      /// </summary>
      [EnumLiteral("entered-in-error", "http://hl7.org/fhir/goal-status"), Description("Entered in Error")]
      EnteredInError,
      /// <summary>
      /// A proposed goal was rejected.
      /// (system: http://hl7.org/fhir/goal-status)
      /// </summary>
      [EnumLiteral("rejected", "http://hl7.org/fhir/goal-status"), Description("Rejected")]
      Rejected,
    }

    /// <summary>
    /// Target outcome for the goal
    /// </summary>
    [Serializable]
    [DataContract]
    [FhirType("Goal#Target", IsNestedType=true)]
    public partial class TargetComponent : Hl7.Fhir.Model.BackboneElement
    {
      /// <summary>
      /// FHIR Type Name
      /// </summary>
      public override string TypeName { get { return "Goal#Target"; } }

      /// <summary>
      /// The parameter whose value is being tracked
      /// </summary>
      [FhirElement("measure", InSummary=true, Order=40)]
      [DataMember]
      public Hl7.Fhir.Model.CodeableConcept Measure
      {
        get { return _Measure; }
        set { _Measure = value; OnPropertyChanged("Measure"); }
      }

      private Hl7.Fhir.Model.CodeableConcept _Measure;

      /// <summary>
      /// The target value to be achieved
      /// </summary>
      [FhirElement("detail", InSummary=true, Order=50, Choice=ChoiceType.DatatypeChoice)]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.Quantity),typeof(Hl7.Fhir.Model.Range),typeof(Hl7.Fhir.Model.CodeableConcept),typeof(Hl7.Fhir.Model.FhirString),typeof(Hl7.Fhir.Model.FhirBoolean),typeof(Hl7.Fhir.Model.Integer),typeof(Hl7.Fhir.Model.Ratio))]
      [DataMember]
      public Hl7.Fhir.Model.DataType Detail
      {
        get { return _Detail; }
        set { _Detail = value; OnPropertyChanged("Detail"); }
      }

      private Hl7.Fhir.Model.DataType _Detail;

      /// <summary>
      /// Reach goal on or before
      /// </summary>
      [FhirElement("due", InSummary=true, Order=60, Choice=ChoiceType.DatatypeChoice, FiveWs="FiveWs.done[x]")]
      [CLSCompliant(false)]
      [AllowedTypes(typeof(Hl7.Fhir.Model.Date),typeof(Hl7.Fhir.Model.Duration))]
      [DataMember]
      public Hl7.Fhir.Model.DataType Due
      {
        get { return _Due; }
        set { _Due = value; OnPropertyChanged("Due"); }
      }

      private Hl7.Fhir.Model.DataType _Due;

      public override IDeepCopyable CopyTo(IDeepCopyable other)
      {
        var dest = other as TargetComponent;

        if (dest == null)
        {
          throw new ArgumentException("Can only copy to an object of the same type", "other");
        }

        base.CopyTo(dest);
        if(Measure != null) dest.Measure = (Hl7.Fhir.Model.CodeableConcept)Measure.DeepCopy();
        if(Detail != null) dest.Detail = (Hl7.Fhir.Model.DataType)Detail.DeepCopy();
        if(Due != null) dest.Due = (Hl7.Fhir.Model.DataType)Due.DeepCopy();
        return dest;
      }

      public override IDeepCopyable DeepCopy()
      {
        return CopyTo(new TargetComponent());
      }

      ///<inheritdoc />
      public override bool Matches(IDeepComparable other)
      {
        var otherT = other as TargetComponent;
        if(otherT == null) return false;

        if(!base.Matches(otherT)) return false;
        if( !DeepComparable.Matches(Measure, otherT.Measure)) return false;
        if( !DeepComparable.Matches(Detail, otherT.Detail)) return false;
        if( !DeepComparable.Matches(Due, otherT.Due)) return false;

        return true;
      }

      public override bool IsExactly(IDeepComparable other)
      {
        var otherT = other as TargetComponent;
        if(otherT == null) return false;

        if(!base.IsExactly(otherT)) return false;
        if( !DeepComparable.IsExactly(Measure, otherT.Measure)) return false;
        if( !DeepComparable.IsExactly(Detail, otherT.Detail)) return false;
        if( !DeepComparable.IsExactly(Due, otherT.Due)) return false;

        return true;
      }

      [IgnoreDataMember]
      public override IEnumerable<Base> Children
      {
        get
        {
          foreach (var item in base.Children) yield return item;
          if (Measure != null) yield return Measure;
          if (Detail != null) yield return Detail;
          if (Due != null) yield return Due;
        }
      }

      [IgnoreDataMember]
      public override IEnumerable<ElementValue> NamedChildren
      {
        get
        {
          foreach (var item in base.NamedChildren) yield return item;
          if (Measure != null) yield return new ElementValue("measure", Measure);
          if (Detail != null) yield return new ElementValue("detail", Detail);
          if (Due != null) yield return new ElementValue("due", Due);
        }
      }

      protected override bool TryGetValue(string key, out object value)
      {
        switch (key)
        {
          case "measure":
            value = Measure;
            return Measure is not null;
          case "detail":
            value = Detail;
            return Detail is not null;
          case "due":
            value = Due;
            return Due is not null;
          default:
            return base.TryGetValue(key, out value);
        }

      }

      protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
      {
        foreach (var kvp in base.GetElementPairs()) yield return kvp;
        if (Measure is not null) yield return new KeyValuePair<string,object>("measure",Measure);
        if (Detail is not null) yield return new KeyValuePair<string,object>("detail",Detail);
        if (Due is not null) yield return new KeyValuePair<string,object>("due",Due);
      }

    }

    /// <summary>
    /// External Ids for this goal
    /// </summary>
    [FhirElement("identifier", Order=90, FiveWs="FiveWs.identifier")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Identifier> Identifier
    {
      get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
      set { _Identifier = value; OnPropertyChanged("Identifier"); }
    }

    private List<Hl7.Fhir.Model.Identifier> _Identifier;

    /// <summary>
    /// proposed | planned | accepted | active | on-hold | completed | cancelled | entered-in-error | rejected
    /// </summary>
    [FhirElement("lifecycleStatus", InSummary=true, IsModifier=true, Order=100, FiveWs="FiveWs.status")]
    [DeclaredType(Type = typeof(Code))]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Code<Hl7.Fhir.Model.Goal.GoalLifecycleStatus> LifecycleStatusElement
    {
      get { return _LifecycleStatusElement; }
      set { _LifecycleStatusElement = value; OnPropertyChanged("LifecycleStatusElement"); }
    }

    private Code<Hl7.Fhir.Model.Goal.GoalLifecycleStatus> _LifecycleStatusElement;

    /// <summary>
    /// proposed | planned | accepted | active | on-hold | completed | cancelled | entered-in-error | rejected
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public Hl7.Fhir.Model.Goal.GoalLifecycleStatus? LifecycleStatus
    {
      get { return LifecycleStatusElement != null ? LifecycleStatusElement.Value : null; }
      set
      {
        if (value == null)
          LifecycleStatusElement = null;
        else
          LifecycleStatusElement = new Code<Hl7.Fhir.Model.Goal.GoalLifecycleStatus>(value);
        OnPropertyChanged("LifecycleStatus");
      }
    }

    /// <summary>
    /// in-progress | improving | worsening | no-change | achieved | sustaining | not-achieved | no-progress | not-attainable
    /// </summary>
    [FhirElement("achievementStatus", InSummary=true, Order=110)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept AchievementStatus
    {
      get { return _AchievementStatus; }
      set { _AchievementStatus = value; OnPropertyChanged("AchievementStatus"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _AchievementStatus;

    /// <summary>
    /// E.g. Treatment, dietary, behavioral, etc
    /// </summary>
    [FhirElement("category", InSummary=true, Order=120, FiveWs="FiveWs.class")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableConcept> Category
    {
      get { if(_Category==null) _Category = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Category; }
      set { _Category = value; OnPropertyChanged("Category"); }
    }

    private List<Hl7.Fhir.Model.CodeableConcept> _Category;

    /// <summary>
    /// After meeting the goal, ongoing activity is needed to sustain the goal objective
    /// </summary>
    [FhirElement("continuous", Order=130)]
    [DataMember]
    public Hl7.Fhir.Model.FhirBoolean ContinuousElement
    {
      get { return _ContinuousElement; }
      set { _ContinuousElement = value; OnPropertyChanged("ContinuousElement"); }
    }

    private Hl7.Fhir.Model.FhirBoolean _ContinuousElement;

    /// <summary>
    /// After meeting the goal, ongoing activity is needed to sustain the goal objective
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public bool? Continuous
    {
      get { return ContinuousElement != null ? ContinuousElement.Value : null; }
      set
      {
        if (value == null)
          ContinuousElement = null;
        else
          ContinuousElement = new Hl7.Fhir.Model.FhirBoolean(value);
        OnPropertyChanged("Continuous");
      }
    }

    /// <summary>
    /// high-priority | medium-priority | low-priority
    /// </summary>
    [FhirElement("priority", InSummary=true, Order=140, FiveWs="FiveWs.grade")]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Priority
    {
      get { return _Priority; }
      set { _Priority = value; OnPropertyChanged("Priority"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Priority;

    /// <summary>
    /// Code or text describing goal
    /// </summary>
    [FhirElement("description", InSummary=true, Order=150, FiveWs="FiveWs.what[x]")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.CodeableConcept Description
    {
      get { return _Description; }
      set { _Description = value; OnPropertyChanged("Description"); }
    }

    private Hl7.Fhir.Model.CodeableConcept _Description;

    /// <summary>
    /// Who this goal is intended for
    /// </summary>
    [FhirElement("subject", InSummary=true, Order=160, FiveWs="FiveWs.subject[x]")]
    [CLSCompliant(false)]
    [References("Patient","Group","Organization")]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Subject
    {
      get { return _Subject; }
      set { _Subject = value; OnPropertyChanged("Subject"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Subject;

    /// <summary>
    /// When goal pursuit begins
    /// </summary>
    [FhirElement("start", InSummary=true, Order=170, Choice=ChoiceType.DatatypeChoice, FiveWs="FiveWs.planned")]
    [CLSCompliant(false)]
    [AllowedTypes(typeof(Hl7.Fhir.Model.Date),typeof(Hl7.Fhir.Model.CodeableConcept))]
    [DataMember]
    public Hl7.Fhir.Model.DataType Start
    {
      get { return _Start; }
      set { _Start = value; OnPropertyChanged("Start"); }
    }

    private Hl7.Fhir.Model.DataType _Start;

    /// <summary>
    /// Target outcome for the goal
    /// </summary>
    [FhirElement("target", Order=180)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Goal.TargetComponent> Target
    {
      get { if(_Target==null) _Target = new List<Hl7.Fhir.Model.Goal.TargetComponent>(); return _Target; }
      set { _Target = value; OnPropertyChanged("Target"); }
    }

    private List<Hl7.Fhir.Model.Goal.TargetComponent> _Target;

    /// <summary>
    /// When goal status took effect
    /// </summary>
    [FhirElement("statusDate", InSummary=true, Order=190, FiveWs="FiveWs.recorded")]
    [DataMember]
    public Hl7.Fhir.Model.Date StatusDateElement
    {
      get { return _StatusDateElement; }
      set { _StatusDateElement = value; OnPropertyChanged("StatusDateElement"); }
    }

    private Hl7.Fhir.Model.Date _StatusDateElement;

    /// <summary>
    /// When goal status took effect
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string StatusDate
    {
      get { return StatusDateElement != null ? StatusDateElement.Value : null; }
      set
      {
        if (value == null)
          StatusDateElement = null;
        else
          StatusDateElement = new Hl7.Fhir.Model.Date(value);
        OnPropertyChanged("StatusDate");
      }
    }

    /// <summary>
    /// Reason for current status
    /// </summary>
    [FhirElement("statusReason", Order=200)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString StatusReasonElement
    {
      get { return _StatusReasonElement; }
      set { _StatusReasonElement = value; OnPropertyChanged("StatusReasonElement"); }
    }

    private Hl7.Fhir.Model.FhirString _StatusReasonElement;

    /// <summary>
    /// Reason for current status
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string StatusReason
    {
      get { return StatusReasonElement != null ? StatusReasonElement.Value : null; }
      set
      {
        if (value == null)
          StatusReasonElement = null;
        else
          StatusReasonElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("StatusReason");
      }
    }

    /// <summary>
    /// Who's responsible for creating Goal?
    /// </summary>
    [FhirElement("source", InSummary=true, Order=210, FiveWs="FiveWs.source")]
    [CLSCompliant(false)]
    [References("Patient","Practitioner","PractitionerRole","RelatedPerson","CareTeam")]
    [DataMember]
    public Hl7.Fhir.Model.ResourceReference Source
    {
      get { return _Source; }
      set { _Source = value; OnPropertyChanged("Source"); }
    }

    private Hl7.Fhir.Model.ResourceReference _Source;

    /// <summary>
    /// Issues addressed by this goal
    /// </summary>
    [FhirElement("addresses", Order=220, FiveWs="FiveWs.why[x]")]
    [CLSCompliant(false)]
    [References("Condition","Observation","MedicationStatement","MedicationRequest","NutritionOrder","ServiceRequest","RiskAssessment","Procedure")]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.ResourceReference> Addresses
    {
      get { if(_Addresses==null) _Addresses = new List<Hl7.Fhir.Model.ResourceReference>(); return _Addresses; }
      set { _Addresses = value; OnPropertyChanged("Addresses"); }
    }

    private List<Hl7.Fhir.Model.ResourceReference> _Addresses;

    /// <summary>
    /// Comments about the goal
    /// </summary>
    [FhirElement("note", Order=230)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.Annotation> Note
    {
      get { if(_Note==null) _Note = new List<Hl7.Fhir.Model.Annotation>(); return _Note; }
      set { _Note = value; OnPropertyChanged("Note"); }
    }

    private List<Hl7.Fhir.Model.Annotation> _Note;

    /// <summary>
    /// What result was achieved regarding the goal?
    /// </summary>
    [FhirElement("outcome", Order=240)]
    [Cardinality(Min=0,Max=-1)]
    [DataMember]
    public List<Hl7.Fhir.Model.CodeableReference> Outcome
    {
      get { if(_Outcome==null) _Outcome = new List<Hl7.Fhir.Model.CodeableReference>(); return _Outcome; }
      set { _Outcome = value; OnPropertyChanged("Outcome"); }
    }

    private List<Hl7.Fhir.Model.CodeableReference> _Outcome;

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as Goal;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
      if(LifecycleStatusElement != null) dest.LifecycleStatusElement = (Code<Hl7.Fhir.Model.Goal.GoalLifecycleStatus>)LifecycleStatusElement.DeepCopy();
      if(AchievementStatus != null) dest.AchievementStatus = (Hl7.Fhir.Model.CodeableConcept)AchievementStatus.DeepCopy();
      if(Category != null) dest.Category = new List<Hl7.Fhir.Model.CodeableConcept>(Category.DeepCopy());
      if(ContinuousElement != null) dest.ContinuousElement = (Hl7.Fhir.Model.FhirBoolean)ContinuousElement.DeepCopy();
      if(Priority != null) dest.Priority = (Hl7.Fhir.Model.CodeableConcept)Priority.DeepCopy();
      if(Description != null) dest.Description = (Hl7.Fhir.Model.CodeableConcept)Description.DeepCopy();
      if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
      if(Start != null) dest.Start = (Hl7.Fhir.Model.DataType)Start.DeepCopy();
      if(Target != null) dest.Target = new List<Hl7.Fhir.Model.Goal.TargetComponent>(Target.DeepCopy());
      if(StatusDateElement != null) dest.StatusDateElement = (Hl7.Fhir.Model.Date)StatusDateElement.DeepCopy();
      if(StatusReasonElement != null) dest.StatusReasonElement = (Hl7.Fhir.Model.FhirString)StatusReasonElement.DeepCopy();
      if(Source != null) dest.Source = (Hl7.Fhir.Model.ResourceReference)Source.DeepCopy();
      if(Addresses != null) dest.Addresses = new List<Hl7.Fhir.Model.ResourceReference>(Addresses.DeepCopy());
      if(Note != null) dest.Note = new List<Hl7.Fhir.Model.Annotation>(Note.DeepCopy());
      if(Outcome != null) dest.Outcome = new List<Hl7.Fhir.Model.CodeableReference>(Outcome.DeepCopy());
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new Goal());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as Goal;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.Matches(LifecycleStatusElement, otherT.LifecycleStatusElement)) return false;
      if( !DeepComparable.Matches(AchievementStatus, otherT.AchievementStatus)) return false;
      if( !DeepComparable.Matches(Category, otherT.Category)) return false;
      if( !DeepComparable.Matches(ContinuousElement, otherT.ContinuousElement)) return false;
      if( !DeepComparable.Matches(Priority, otherT.Priority)) return false;
      if( !DeepComparable.Matches(Description, otherT.Description)) return false;
      if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
      if( !DeepComparable.Matches(Start, otherT.Start)) return false;
      if( !DeepComparable.Matches(Target, otherT.Target)) return false;
      if( !DeepComparable.Matches(StatusDateElement, otherT.StatusDateElement)) return false;
      if( !DeepComparable.Matches(StatusReasonElement, otherT.StatusReasonElement)) return false;
      if( !DeepComparable.Matches(Source, otherT.Source)) return false;
      if( !DeepComparable.Matches(Addresses, otherT.Addresses)) return false;
      if( !DeepComparable.Matches(Note, otherT.Note)) return false;
      if( !DeepComparable.Matches(Outcome, otherT.Outcome)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as Goal;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
      if( !DeepComparable.IsExactly(LifecycleStatusElement, otherT.LifecycleStatusElement)) return false;
      if( !DeepComparable.IsExactly(AchievementStatus, otherT.AchievementStatus)) return false;
      if( !DeepComparable.IsExactly(Category, otherT.Category)) return false;
      if( !DeepComparable.IsExactly(ContinuousElement, otherT.ContinuousElement)) return false;
      if( !DeepComparable.IsExactly(Priority, otherT.Priority)) return false;
      if( !DeepComparable.IsExactly(Description, otherT.Description)) return false;
      if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
      if( !DeepComparable.IsExactly(Start, otherT.Start)) return false;
      if( !DeepComparable.IsExactly(Target, otherT.Target)) return false;
      if( !DeepComparable.IsExactly(StatusDateElement, otherT.StatusDateElement)) return false;
      if( !DeepComparable.IsExactly(StatusReasonElement, otherT.StatusReasonElement)) return false;
      if( !DeepComparable.IsExactly(Source, otherT.Source)) return false;
      if( !DeepComparable.IsExactly(Addresses, otherT.Addresses)) return false;
      if( !DeepComparable.IsExactly(Note, otherT.Note)) return false;
      if( !DeepComparable.IsExactly(Outcome, otherT.Outcome)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return elem; }
        if (LifecycleStatusElement != null) yield return LifecycleStatusElement;
        if (AchievementStatus != null) yield return AchievementStatus;
        foreach (var elem in Category) { if (elem != null) yield return elem; }
        if (ContinuousElement != null) yield return ContinuousElement;
        if (Priority != null) yield return Priority;
        if (Description != null) yield return Description;
        if (Subject != null) yield return Subject;
        if (Start != null) yield return Start;
        foreach (var elem in Target) { if (elem != null) yield return elem; }
        if (StatusDateElement != null) yield return StatusDateElement;
        if (StatusReasonElement != null) yield return StatusReasonElement;
        if (Source != null) yield return Source;
        foreach (var elem in Addresses) { if (elem != null) yield return elem; }
        foreach (var elem in Note) { if (elem != null) yield return elem; }
        foreach (var elem in Outcome) { if (elem != null) yield return elem; }
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", elem); }
        if (LifecycleStatusElement != null) yield return new ElementValue("lifecycleStatus", LifecycleStatusElement);
        if (AchievementStatus != null) yield return new ElementValue("achievementStatus", AchievementStatus);
        foreach (var elem in Category) { if (elem != null) yield return new ElementValue("category", elem); }
        if (ContinuousElement != null) yield return new ElementValue("continuous", ContinuousElement);
        if (Priority != null) yield return new ElementValue("priority", Priority);
        if (Description != null) yield return new ElementValue("description", Description);
        if (Subject != null) yield return new ElementValue("subject", Subject);
        if (Start != null) yield return new ElementValue("start", Start);
        foreach (var elem in Target) { if (elem != null) yield return new ElementValue("target", elem); }
        if (StatusDateElement != null) yield return new ElementValue("statusDate", StatusDateElement);
        if (StatusReasonElement != null) yield return new ElementValue("statusReason", StatusReasonElement);
        if (Source != null) yield return new ElementValue("source", Source);
        foreach (var elem in Addresses) { if (elem != null) yield return new ElementValue("addresses", elem); }
        foreach (var elem in Note) { if (elem != null) yield return new ElementValue("note", elem); }
        foreach (var elem in Outcome) { if (elem != null) yield return new ElementValue("outcome", elem); }
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "identifier":
          value = Identifier;
          return Identifier?.Any() == true;
        case "lifecycleStatus":
          value = LifecycleStatusElement;
          return LifecycleStatusElement is not null;
        case "achievementStatus":
          value = AchievementStatus;
          return AchievementStatus is not null;
        case "category":
          value = Category;
          return Category?.Any() == true;
        case "continuous":
          value = ContinuousElement;
          return ContinuousElement is not null;
        case "priority":
          value = Priority;
          return Priority is not null;
        case "description":
          value = Description;
          return Description is not null;
        case "subject":
          value = Subject;
          return Subject is not null;
        case "start":
          value = Start;
          return Start is not null;
        case "target":
          value = Target;
          return Target?.Any() == true;
        case "statusDate":
          value = StatusDateElement;
          return StatusDateElement is not null;
        case "statusReason":
          value = StatusReasonElement;
          return StatusReasonElement is not null;
        case "source":
          value = Source;
          return Source is not null;
        case "addresses":
          value = Addresses;
          return Addresses?.Any() == true;
        case "note":
          value = Note;
          return Note?.Any() == true;
        case "outcome":
          value = Outcome;
          return Outcome?.Any() == true;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Identifier?.Any() == true) yield return new KeyValuePair<string,object>("identifier",Identifier);
      if (LifecycleStatusElement is not null) yield return new KeyValuePair<string,object>("lifecycleStatus",LifecycleStatusElement);
      if (AchievementStatus is not null) yield return new KeyValuePair<string,object>("achievementStatus",AchievementStatus);
      if (Category?.Any() == true) yield return new KeyValuePair<string,object>("category",Category);
      if (ContinuousElement is not null) yield return new KeyValuePair<string,object>("continuous",ContinuousElement);
      if (Priority is not null) yield return new KeyValuePair<string,object>("priority",Priority);
      if (Description is not null) yield return new KeyValuePair<string,object>("description",Description);
      if (Subject is not null) yield return new KeyValuePair<string,object>("subject",Subject);
      if (Start is not null) yield return new KeyValuePair<string,object>("start",Start);
      if (Target?.Any() == true) yield return new KeyValuePair<string,object>("target",Target);
      if (StatusDateElement is not null) yield return new KeyValuePair<string,object>("statusDate",StatusDateElement);
      if (StatusReasonElement is not null) yield return new KeyValuePair<string,object>("statusReason",StatusReasonElement);
      if (Source is not null) yield return new KeyValuePair<string,object>("source",Source);
      if (Addresses?.Any() == true) yield return new KeyValuePair<string,object>("addresses",Addresses);
      if (Note?.Any() == true) yield return new KeyValuePair<string,object>("note",Note);
      if (Outcome?.Any() == true) yield return new KeyValuePair<string,object>("outcome",Outcome);
    }

  }

}

// end of file
