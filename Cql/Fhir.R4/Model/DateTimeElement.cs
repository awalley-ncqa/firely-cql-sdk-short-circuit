using Hl7.Cql.Poco.Fhir;
using Hl7.Cql.Iso8601;
using System.Diagnostics;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [DebuggerDisplay("{value}")]
	[FhirUri("http://hl7.org/fhir/StructureDefinition/dateTime")]
	public partial class DateTimeElement : Element
	{

		public DateTimeIso8601 value { get; set; }
	}
}