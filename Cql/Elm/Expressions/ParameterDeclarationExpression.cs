﻿namespace Hl7.Cql.Elm.Expressions
{
    public class ParameterDeclarationExpression: Expression
    {
        public Annotation[]? annotation { get; set; }

        public string? name { get; set; }

        public TypeSpecifierExpression? parameterTypeSpecifier { get; set; }

        public Expression? @default { get; set; }
    }
}