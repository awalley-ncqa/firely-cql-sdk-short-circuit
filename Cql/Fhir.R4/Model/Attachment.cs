using Ncqa.Fhir;
using Ncqa.Fhir.Serialization;
using Ncqa.Iso8601;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;

namespace Ncqa.Fhir.R4.Model
{
	[FhirUri("http://hl7.org/fhir/StructureDefinition/Attachment")]
	public partial class Attachment : Element
	{

		[ValueSetBinding("MimeType", "http://hl7.org/fhir/ValueSet/mimetypes%7C4.0.1", true)]
		public CodeElement contentType { get; set; }

		[ValueSetBinding("Language", "http://hl7.org/fhir/ValueSet/languages", false)]
		public CodeElement language { get; set; }

		public Base64BinaryElement data { get; set; }

		public UrlElement url { get; set; }

		public UnsignedIntElement size { get; set; }

		public Base64BinaryElement hash { get; set; }

		public StringElement title { get; set; }

		public DateTimeElement creation { get; set; }
	}
}
