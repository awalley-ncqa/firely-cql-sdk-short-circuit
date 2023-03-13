﻿using Ncqa.Cql.Runtime.Comparers;
using Ncqa.Fhir.R4.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ncqa.Cql.Runtime.FhirR4.Comparers
{
    public class IdentifierCqlComparer : CqlComparerBase<Identifier>
    {
        public FhirCqlComparers Comparers { get; }
        public IComparer<string> SystemComparer { get; }

        public IdentifierCqlComparer(FhirCqlComparers comparers, 
            IComparer<string>? systemComparer = null)
        {
            Comparers = comparers;
            SystemComparer = systemComparer ?? StringComparer.OrdinalIgnoreCase;
        }

        public override int? Compare(Identifier x, Identifier y, string? precision)
        {
            if (x == null || y == null)
                return null;
            var system = SystemComparer.Compare(x.system?.value ?? "", y.system?.value ?? "");
            if (system == 0)
                return Comparers.Compare(x.value, y.value, precision);
            else return system;
        }


        public override bool? Equals(Identifier x, Identifier y, string? precision) =>
            x == null || y == null
            ? null
            : Compare(x, y, precision) == 0;

        public override bool Equivalent(Identifier x, Identifier y, string? precision) =>
            Compare(x, y, precision) == 0
            ? true
            : false;

        public override int GetHashCode(Identifier? x)
        {
            if (x == null || x.value == null)
                return typeof(StringElement).GetHashCode();
            else return $"{x.value}{x.system}".GetHashCode();
        }
        public override int GetHashCode(object x) => GetHashCode(x as Identifier);
    }
}
