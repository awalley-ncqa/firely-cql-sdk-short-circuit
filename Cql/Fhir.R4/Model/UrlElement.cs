using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[DebuggerDisplay("{value}")]
	[FhirUri("http://hl7.org/fhir/StructureDefinition/url")]
	public partial class UrlElement : UriElement
	{
	}
}
