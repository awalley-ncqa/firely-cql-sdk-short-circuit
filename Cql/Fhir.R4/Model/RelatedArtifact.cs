using Hl7.Cql.Poco.Fhir;
using System.Diagnostics.CodeAnalysis;

namespace Hl7.Cql.Poco.Fhir.R4.Model
{
    [FhirUri("http://hl7.org/fhir/StructureDefinition/RelatedArtifact")]
	public partial class RelatedArtifact : Element
	{

		[NotNull]
		[ValueSetBinding("RelatedArtifactType", "http://hl7.org/fhir/ValueSet/related-artifact-type%7C4.0.1", true)]
		public CodeElement type { get; set; }

		public StringElement label { get; set; }

		public StringElement display { get; set; }

		public MarkdownElement citation { get; set; }

		public UrlElement url { get; set; }

		public Attachment document { get; set; }

		public CanonicalElement resource { get; set; }
	}
}