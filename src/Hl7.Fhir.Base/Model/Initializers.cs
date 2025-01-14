﻿/*
  Copyright (c) 2011-2012, HL7, Inc
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

#nullable enable

using Hl7.Fhir.Introspection;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Hl7.Fhir.Model
{
    [DebuggerDisplay(@"\{{DebuggerDisplay(null),nq}}")] // http://blogs.msdn.com/b/jaredpar/archive/2011/03/18/debuggerdisplay-attribute-best-practices.aspx
    public partial class CodeableConcept
    {
        internal string DebuggerDisplay(string prefix)
        {
            if (!string.IsNullOrEmpty(Text))
                return string.Format("{0}Text=\"{1}\"", prefix, Text);
            var sb = new StringBuilder();
            if (_Coding != null)
            {
                foreach (var item in _Coding)
                {
                    sb.Append("  ");
                    sb.Append(item.DebuggerDisplay);
                }
            }
            return sb.ToString();
        }

        public CodeableConcept()
        {
        }

        public CodeableConcept(string system, string code, string? text = null)
        {
            if (!string.IsNullOrEmpty(system) || !string.IsNullOrEmpty(code))
            {
                this.Coding = new List<Coding>() {
                    new Coding(system,code) };
            }
            this.Text = text;
        }
        public CodeableConcept(string system, string code, string display, string text)
        {
            if (!string.IsNullOrEmpty(system) || !string.IsNullOrEmpty(code) || !string.IsNullOrEmpty(display))
            {
                this.Coding = new List<Coding>() {
                    new Coding(system,code, display) };
            }
            this.Text = text;
        }

        public CodeableConcept Add(string system, string code, string? display = null)
        {
            Coding.Add(new Coding(system, code, display));

            return this;
        }
    }

    public partial class Identifier
    {
        public Identifier()
        {
        }

        public Identifier(string system, string value)
        {
            this.System = system;
            this.Value = value;
        }
    }

    [System.Diagnostics.DebuggerDisplay(@"\{{DebuggerDisplay,nq}}")] // http://blogs.msdn.com/b/jaredpar/archive/2011/03/18/debuggerdisplay-attribute-best-practices.aspx
    public partial class Period
    {
        public Period()
        {
        }

        public Period(FhirDateTime start, FhirDateTime end)
        {
            StartElement = start;
            EndElement = end;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [NotMapped]
        internal string DebuggerDisplay
        {
            get
            {
                var sb = new StringBuilder();
                if (!string.IsNullOrEmpty(this.Start))
                    sb.AppendFormat(" Start=\"{0}\"", Start);
                if (!string.IsNullOrEmpty(this.End))
                    sb.AppendFormat(" End=\"{0}\"", End);

                return sb.ToString();
            }
        }
    }

    public partial class ContactPoint
    {
        public ContactPoint()
        {
        }

        public ContactPoint(ContactPointSystem? system, ContactPointUse? use, string value)
        {
            this.System = system;
            this.Use = use;
            this.Value = value;
        }
    }

    public partial class Quantity
    {
        public Quantity()
        {
        }

        public Quantity(decimal value, string unit, string system = "http://unitsofmeasure.org")
        {
            Value = value;
            Unit = unit;
            Code = unit;
            System = system;
        }
    }

}

#nullable restore