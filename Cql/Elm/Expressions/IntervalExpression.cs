﻿namespace Hl7.Cql.Elm.Expressions
{
    public class IntervalExpression : Expression
    {
        public bool? lowClosed { get; set; }
        public Expression? lowClosedExpression { get; set; }

        public bool? highClosed { get; set; }
        public Expression? highClosedExpression { get; set; }

        public Expression? low { get; set; }
        public Expression? high { get; set; }
    }

}
