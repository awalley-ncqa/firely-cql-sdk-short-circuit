using Hl7.Cql.Abstractions;
using Hl7.Cql.Compiler;
using Hl7.Cql.Conversion;
using Hl7.Cql.Fhir;
using Hl7.Fhir.Model;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace CoreTests
{
    [TestClass]
    public class ExpressionBuilderTests
    {
        private static readonly TypeResolver TypeResolver = new FhirTypeResolver(Hl7.Fhir.Model.ModelInfo.ModelInspector);
        private static readonly TypeConverter TypeConverter = FhirTypeConverter.Create(Hl7.Fhir.Model.ModelInfo.ModelInspector);

        private ILogger<ExpressionBuilder> CreateLogger() => LoggerFactory
            .Create(logging => logging.AddDebug())
            .CreateLogger<ExpressionBuilder>();

        [TestMethod]
        public void AggregateQueries_1_0_0()
        {
            var binding = new CqlOperatorsBinding(TypeResolver, TypeConverter);
            var typeManager = new TypeManager(TypeResolver);
            var elm = new FileInfo(@"Input\ELM\Test\Aggregates-1.0.0.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var logger = CreateLogger();
            var eb = new ExpressionBuilder(binding, typeManager, elmPackage, logger);
            var expressions = eb.Build();
        }

        [TestMethod]
        public void FHIRTypeConversionTest_1_0_0()
        {
            var binding = new CqlOperatorsBinding(TypeResolver, TypeConverter);
            var typeManager = new TypeManager(TypeResolver);
            var elm = new FileInfo(@"Input\ELM\HL7\FHIRTypeConversionTest.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var logger = CreateLogger();
            var eb = new ExpressionBuilder(binding, typeManager, elmPackage, logger);
            var expressions = eb.Build();
            Assert.IsNotNull(expressions);
        }

        [TestMethod]
        public void QueriesTest_1_0_0()
        {
            var binding = new CqlOperatorsBinding(TypeResolver, TypeConverter);
            var typeManager = new TypeManager(TypeResolver);
            var elm = new FileInfo(@"Input\ELM\Test\QueriesTest-1.0.0.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var logger = CreateLogger();
            var eb = new ExpressionBuilder(binding, typeManager, elmPackage, logger);
            var expressions = eb.Build();
        }

        // https://github.com/FirelyTeam/firely-cql-sdk/issues/129
        [TestMethod]
        public void Medication_Request_Example_Test()
        {
            var binding = new CqlOperatorsBinding(TypeResolver, TypeConverter);
            var typeManager = new TypeManager(TypeResolver);
            var elm = new FileInfo(@"Input\ELM\Test\Medication_Request_Example.json");
            var elmPackage = Hl7.Cql.Elm.Library.LoadFromJson(elm);
            var logger = CreateLogger();
            var eb = new ExpressionBuilder(binding, typeManager, elmPackage, logger);

            var fdt = new FhirDateTime(2023, 12, 11, 9, 41, 30, TimeSpan.FromHours(-5));
            var fdts = fdt.ToString();
            var fs = new FhirDateTime(fdts);
            Assert.AreEqual(fdt, fs);

            var expressions = eb.Build();
            Assert.IsNotNull(expressions);
        }


        [TestMethod]
        public void Get_Property_Uses_TypeResolver()
        {
            var binding = new CqlOperatorsBinding(TypeResolver, TypeConverter);
            var typeManager = new TypeManager(TypeResolver);
            var logger = CreateLogger();
            var lib = new Hl7.Cql.Elm.Library
            {
                identifier = new Hl7.Cql.Elm.VersionedIdentifier()
            };
            var eb = new ExpressionBuilder(binding, typeManager, lib, logger);

            var property = eb.GetProperty(typeof(MeasureReport.PopulationComponent), "id");
            Assert.AreEqual(typeof(Element), property.DeclaringType);
            Assert.AreEqual(nameof(Element.ElementId), property.Name);
        }

    }
}
