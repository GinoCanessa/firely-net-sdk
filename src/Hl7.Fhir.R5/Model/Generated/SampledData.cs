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
  /// A series of measurements taken by a device
  /// </summary>
  [Serializable]
  [DataContract]
  [FhirType("SampledData","http://hl7.org/fhir/StructureDefinition/SampledData")]
  public partial class SampledData : Hl7.Fhir.Model.DataType
  {
    /// <summary>
    /// FHIR Type Name
    /// </summary>
    public override string TypeName { get { return "SampledData"; } }

    /// <summary>
    /// Zero value and units
    /// </summary>
    [FhirElement("origin", InSummary=true, Order=30)]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.Quantity Origin
    {
      get { return _Origin; }
      set { _Origin = value; OnPropertyChanged("Origin"); }
    }

    private Hl7.Fhir.Model.Quantity _Origin;

    /// <summary>
    /// Number of intervalUnits between samples
    /// </summary>
    [FhirElement("interval", InSummary=true, Order=40)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDecimal IntervalElement
    {
      get { return _IntervalElement; }
      set { _IntervalElement = value; OnPropertyChanged("IntervalElement"); }
    }

    private Hl7.Fhir.Model.FhirDecimal _IntervalElement;

    /// <summary>
    /// Number of intervalUnits between samples
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public decimal? Interval
    {
      get { return IntervalElement != null ? IntervalElement.Value : null; }
      set
      {
        if (value == null)
          IntervalElement = null;
        else
          IntervalElement = new Hl7.Fhir.Model.FhirDecimal(value);
        OnPropertyChanged("Interval");
      }
    }

    /// <summary>
    /// The measurement unit of the interval between samples
    /// </summary>
    [FhirElement("intervalUnit", InSummary=true, Order=50)]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.Code IntervalUnitElement
    {
      get { return _IntervalUnitElement; }
      set { _IntervalUnitElement = value; OnPropertyChanged("IntervalUnitElement"); }
    }

    private Hl7.Fhir.Model.Code _IntervalUnitElement;

    /// <summary>
    /// The measurement unit of the interval between samples
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string IntervalUnit
    {
      get { return IntervalUnitElement != null ? IntervalUnitElement.Value : null; }
      set
      {
        if (value == null)
          IntervalUnitElement = null;
        else
          IntervalUnitElement = new Hl7.Fhir.Model.Code(value);
        OnPropertyChanged("IntervalUnit");
      }
    }

    /// <summary>
    /// Multiply data by this before adding to origin
    /// </summary>
    [FhirElement("factor", InSummary=true, Order=60)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDecimal FactorElement
    {
      get { return _FactorElement; }
      set { _FactorElement = value; OnPropertyChanged("FactorElement"); }
    }

    private Hl7.Fhir.Model.FhirDecimal _FactorElement;

    /// <summary>
    /// Multiply data by this before adding to origin
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public decimal? Factor
    {
      get { return FactorElement != null ? FactorElement.Value : null; }
      set
      {
        if (value == null)
          FactorElement = null;
        else
          FactorElement = new Hl7.Fhir.Model.FhirDecimal(value);
        OnPropertyChanged("Factor");
      }
    }

    /// <summary>
    /// Lower limit of detection
    /// </summary>
    [FhirElement("lowerLimit", InSummary=true, Order=70)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDecimal LowerLimitElement
    {
      get { return _LowerLimitElement; }
      set { _LowerLimitElement = value; OnPropertyChanged("LowerLimitElement"); }
    }

    private Hl7.Fhir.Model.FhirDecimal _LowerLimitElement;

    /// <summary>
    /// Lower limit of detection
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public decimal? LowerLimit
    {
      get { return LowerLimitElement != null ? LowerLimitElement.Value : null; }
      set
      {
        if (value == null)
          LowerLimitElement = null;
        else
          LowerLimitElement = new Hl7.Fhir.Model.FhirDecimal(value);
        OnPropertyChanged("LowerLimit");
      }
    }

    /// <summary>
    /// Upper limit of detection
    /// </summary>
    [FhirElement("upperLimit", InSummary=true, Order=80)]
    [DataMember]
    public Hl7.Fhir.Model.FhirDecimal UpperLimitElement
    {
      get { return _UpperLimitElement; }
      set { _UpperLimitElement = value; OnPropertyChanged("UpperLimitElement"); }
    }

    private Hl7.Fhir.Model.FhirDecimal _UpperLimitElement;

    /// <summary>
    /// Upper limit of detection
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public decimal? UpperLimit
    {
      get { return UpperLimitElement != null ? UpperLimitElement.Value : null; }
      set
      {
        if (value == null)
          UpperLimitElement = null;
        else
          UpperLimitElement = new Hl7.Fhir.Model.FhirDecimal(value);
        OnPropertyChanged("UpperLimit");
      }
    }

    /// <summary>
    /// Number of sample points at each time point
    /// </summary>
    [FhirElement("dimensions", InSummary=true, Order=90)]
    [Cardinality(Min=1,Max=1)]
    [DataMember]
    public Hl7.Fhir.Model.PositiveInt DimensionsElement
    {
      get { return _DimensionsElement; }
      set { _DimensionsElement = value; OnPropertyChanged("DimensionsElement"); }
    }

    private Hl7.Fhir.Model.PositiveInt _DimensionsElement;

    /// <summary>
    /// Number of sample points at each time point
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public int? Dimensions
    {
      get { return DimensionsElement != null ? DimensionsElement.Value : null; }
      set
      {
        if (value == null)
          DimensionsElement = null;
        else
          DimensionsElement = new Hl7.Fhir.Model.PositiveInt(value);
        OnPropertyChanged("Dimensions");
      }
    }

    /// <summary>
    /// Defines the codes used in the data
    /// </summary>
    [FhirElement("codeMap", Order=100)]
    [DataMember]
    public Hl7.Fhir.Model.Canonical CodeMapElement
    {
      get { return _CodeMapElement; }
      set { _CodeMapElement = value; OnPropertyChanged("CodeMapElement"); }
    }

    private Hl7.Fhir.Model.Canonical _CodeMapElement;

    /// <summary>
    /// Defines the codes used in the data
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string CodeMap
    {
      get { return CodeMapElement != null ? CodeMapElement.Value : null; }
      set
      {
        if (value == null)
          CodeMapElement = null;
        else
          CodeMapElement = new Hl7.Fhir.Model.Canonical(value);
        OnPropertyChanged("CodeMap");
      }
    }

    /// <summary>
    /// Offsets, typically in time, at which data values were taken
    /// </summary>
    [FhirElement("offsets", Order=110)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString OffsetsElement
    {
      get { return _OffsetsElement; }
      set { _OffsetsElement = value; OnPropertyChanged("OffsetsElement"); }
    }

    private Hl7.Fhir.Model.FhirString _OffsetsElement;

    /// <summary>
    /// Offsets, typically in time, at which data values were taken
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Offsets
    {
      get { return OffsetsElement != null ? OffsetsElement.Value : null; }
      set
      {
        if (value == null)
          OffsetsElement = null;
        else
          OffsetsElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Offsets");
      }
    }

    /// <summary>
    /// Decimal values with spaces, or "E" | "U" | "L", or another code
    /// </summary>
    [FhirElement("data", Order=120)]
    [DataMember]
    public Hl7.Fhir.Model.FhirString DataElement
    {
      get { return _DataElement; }
      set { _DataElement = value; OnPropertyChanged("DataElement"); }
    }

    private Hl7.Fhir.Model.FhirString _DataElement;

    /// <summary>
    /// Decimal values with spaces, or "E" | "U" | "L", or another code
    /// </summary>
    /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
    [IgnoreDataMember]
    public string Data
    {
      get { return DataElement != null ? DataElement.Value : null; }
      set
      {
        if (value == null)
          DataElement = null;
        else
          DataElement = new Hl7.Fhir.Model.FhirString(value);
        OnPropertyChanged("Data");
      }
    }

    public override IDeepCopyable CopyTo(IDeepCopyable other)
    {
      var dest = other as SampledData;

      if (dest == null)
      {
        throw new ArgumentException("Can only copy to an object of the same type", "other");
      }

      base.CopyTo(dest);
      if(Origin != null) dest.Origin = (Hl7.Fhir.Model.Quantity)Origin.DeepCopy();
      if(IntervalElement != null) dest.IntervalElement = (Hl7.Fhir.Model.FhirDecimal)IntervalElement.DeepCopy();
      if(IntervalUnitElement != null) dest.IntervalUnitElement = (Hl7.Fhir.Model.Code)IntervalUnitElement.DeepCopy();
      if(FactorElement != null) dest.FactorElement = (Hl7.Fhir.Model.FhirDecimal)FactorElement.DeepCopy();
      if(LowerLimitElement != null) dest.LowerLimitElement = (Hl7.Fhir.Model.FhirDecimal)LowerLimitElement.DeepCopy();
      if(UpperLimitElement != null) dest.UpperLimitElement = (Hl7.Fhir.Model.FhirDecimal)UpperLimitElement.DeepCopy();
      if(DimensionsElement != null) dest.DimensionsElement = (Hl7.Fhir.Model.PositiveInt)DimensionsElement.DeepCopy();
      if(CodeMapElement != null) dest.CodeMapElement = (Hl7.Fhir.Model.Canonical)CodeMapElement.DeepCopy();
      if(OffsetsElement != null) dest.OffsetsElement = (Hl7.Fhir.Model.FhirString)OffsetsElement.DeepCopy();
      if(DataElement != null) dest.DataElement = (Hl7.Fhir.Model.FhirString)DataElement.DeepCopy();
      return dest;
    }

    public override IDeepCopyable DeepCopy()
    {
      return CopyTo(new SampledData());
    }

    ///<inheritdoc />
    public override bool Matches(IDeepComparable other)
    {
      var otherT = other as SampledData;
      if(otherT == null) return false;

      if(!base.Matches(otherT)) return false;
      if( !DeepComparable.Matches(Origin, otherT.Origin)) return false;
      if( !DeepComparable.Matches(IntervalElement, otherT.IntervalElement)) return false;
      if( !DeepComparable.Matches(IntervalUnitElement, otherT.IntervalUnitElement)) return false;
      if( !DeepComparable.Matches(FactorElement, otherT.FactorElement)) return false;
      if( !DeepComparable.Matches(LowerLimitElement, otherT.LowerLimitElement)) return false;
      if( !DeepComparable.Matches(UpperLimitElement, otherT.UpperLimitElement)) return false;
      if( !DeepComparable.Matches(DimensionsElement, otherT.DimensionsElement)) return false;
      if( !DeepComparable.Matches(CodeMapElement, otherT.CodeMapElement)) return false;
      if( !DeepComparable.Matches(OffsetsElement, otherT.OffsetsElement)) return false;
      if( !DeepComparable.Matches(DataElement, otherT.DataElement)) return false;

      return true;
    }

    public override bool IsExactly(IDeepComparable other)
    {
      var otherT = other as SampledData;
      if(otherT == null) return false;

      if(!base.IsExactly(otherT)) return false;
      if( !DeepComparable.IsExactly(Origin, otherT.Origin)) return false;
      if( !DeepComparable.IsExactly(IntervalElement, otherT.IntervalElement)) return false;
      if( !DeepComparable.IsExactly(IntervalUnitElement, otherT.IntervalUnitElement)) return false;
      if( !DeepComparable.IsExactly(FactorElement, otherT.FactorElement)) return false;
      if( !DeepComparable.IsExactly(LowerLimitElement, otherT.LowerLimitElement)) return false;
      if( !DeepComparable.IsExactly(UpperLimitElement, otherT.UpperLimitElement)) return false;
      if( !DeepComparable.IsExactly(DimensionsElement, otherT.DimensionsElement)) return false;
      if( !DeepComparable.IsExactly(CodeMapElement, otherT.CodeMapElement)) return false;
      if( !DeepComparable.IsExactly(OffsetsElement, otherT.OffsetsElement)) return false;
      if( !DeepComparable.IsExactly(DataElement, otherT.DataElement)) return false;

      return true;
    }

    [IgnoreDataMember]
    public override IEnumerable<Base> Children
    {
      get
      {
        foreach (var item in base.Children) yield return item;
        if (Origin != null) yield return Origin;
        if (IntervalElement != null) yield return IntervalElement;
        if (IntervalUnitElement != null) yield return IntervalUnitElement;
        if (FactorElement != null) yield return FactorElement;
        if (LowerLimitElement != null) yield return LowerLimitElement;
        if (UpperLimitElement != null) yield return UpperLimitElement;
        if (DimensionsElement != null) yield return DimensionsElement;
        if (CodeMapElement != null) yield return CodeMapElement;
        if (OffsetsElement != null) yield return OffsetsElement;
        if (DataElement != null) yield return DataElement;
      }
    }

    [IgnoreDataMember]
    public override IEnumerable<ElementValue> NamedChildren
    {
      get
      {
        foreach (var item in base.NamedChildren) yield return item;
        if (Origin != null) yield return new ElementValue("origin", Origin);
        if (IntervalElement != null) yield return new ElementValue("interval", IntervalElement);
        if (IntervalUnitElement != null) yield return new ElementValue("intervalUnit", IntervalUnitElement);
        if (FactorElement != null) yield return new ElementValue("factor", FactorElement);
        if (LowerLimitElement != null) yield return new ElementValue("lowerLimit", LowerLimitElement);
        if (UpperLimitElement != null) yield return new ElementValue("upperLimit", UpperLimitElement);
        if (DimensionsElement != null) yield return new ElementValue("dimensions", DimensionsElement);
        if (CodeMapElement != null) yield return new ElementValue("codeMap", CodeMapElement);
        if (OffsetsElement != null) yield return new ElementValue("offsets", OffsetsElement);
        if (DataElement != null) yield return new ElementValue("data", DataElement);
      }
    }

    protected override bool TryGetValue(string key, out object value)
    {
      switch (key)
      {
        case "origin":
          value = Origin;
          return Origin is not null;
        case "interval":
          value = IntervalElement;
          return IntervalElement is not null;
        case "intervalUnit":
          value = IntervalUnitElement;
          return IntervalUnitElement is not null;
        case "factor":
          value = FactorElement;
          return FactorElement is not null;
        case "lowerLimit":
          value = LowerLimitElement;
          return LowerLimitElement is not null;
        case "upperLimit":
          value = UpperLimitElement;
          return UpperLimitElement is not null;
        case "dimensions":
          value = DimensionsElement;
          return DimensionsElement is not null;
        case "codeMap":
          value = CodeMapElement;
          return CodeMapElement is not null;
        case "offsets":
          value = OffsetsElement;
          return OffsetsElement is not null;
        case "data":
          value = DataElement;
          return DataElement is not null;
        default:
          return base.TryGetValue(key, out value);
      }

    }

    protected override IEnumerable<KeyValuePair<string, object>> GetElementPairs()
    {
      foreach (var kvp in base.GetElementPairs()) yield return kvp;
      if (Origin is not null) yield return new KeyValuePair<string,object>("origin",Origin);
      if (IntervalElement is not null) yield return new KeyValuePair<string,object>("interval",IntervalElement);
      if (IntervalUnitElement is not null) yield return new KeyValuePair<string,object>("intervalUnit",IntervalUnitElement);
      if (FactorElement is not null) yield return new KeyValuePair<string,object>("factor",FactorElement);
      if (LowerLimitElement is not null) yield return new KeyValuePair<string,object>("lowerLimit",LowerLimitElement);
      if (UpperLimitElement is not null) yield return new KeyValuePair<string,object>("upperLimit",UpperLimitElement);
      if (DimensionsElement is not null) yield return new KeyValuePair<string,object>("dimensions",DimensionsElement);
      if (CodeMapElement is not null) yield return new KeyValuePair<string,object>("codeMap",CodeMapElement);
      if (OffsetsElement is not null) yield return new KeyValuePair<string,object>("offsets",OffsetsElement);
      if (DataElement is not null) yield return new KeyValuePair<string,object>("data",DataElement);
    }

  }

}

// end of file
