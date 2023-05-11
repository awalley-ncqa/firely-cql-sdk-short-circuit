using Hl7.Cql.Poco.Fhir;
using System.Collections.Generic;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/EnrollmentResponse")]
	public partial class EnrollmentResponse : DomainResource
	{

		public ICollection<Identifier> identifier { get; set; }

		[ValueSetBinding("EnrollmentResponseStatus", "http://hl7.org/fhir/ValueSet/fm-status%7C4.0.1", true)]
		public CodeElement status { get; set; }

		public Reference request { get; set; }

		[ValueSetBinding("RemittanceOutcome", "http://hl7.org/fhir/ValueSet/remittance-outcome%7C4.0.1", true)]
		public CodeElement outcome { get; set; }

		public StringElement disposition { get; set; }

		public DateTimeElement created { get; set; }

		public Reference organization { get; set; }

		public Reference requestProvider { get; set; }
	}
}
