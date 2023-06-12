﻿using System;
using System.Linq;
using System.Linq.Expressions;
using elm = Hl7.Cql.Elm.Expressions;

namespace Hl7.Cql.Compiler
{
    public partial class ExpressionBuilder
    {
        protected Expression Coalesce(elm.CoalesceExpression ce, ExpressionBuilderContext ctx)
        {
            var operands = ce.operand!
                .Select(op => TranslateExpression(op, ctx))
                .ToArray();
            if (operands.Length == 1 && IsOrImplementsIEnumerableOfT(operands[0].Type))
            {
                var call = Operators.Bind(CqlOperator.Coalesce, ctx.RuntimeContextParameter, operands[0]);
                return call;
            }
            var distinctOperandTypes = operands
                .Select(op => op.Type)
                .Distinct()
                .ToArray();
            if (distinctOperandTypes.Length != 1)
                throw new InvalidOperationException("All operand types should match when using Coalesce");
            var type = operands[0].Type;
            if (type.IsValueType && !IsNullable(type))
                throw new NotSupportedException("Coalesce on value types is not defined.");
            else
            {
                if (operands.Length == 1)
                    return operands[0];
                else
                {

                    var coalesce = Expression.Coalesce(operands[0], operands[1]);
                    for (int i = 2; i < operands.Length; i++)
                    {
                        coalesce = Expression.Coalesce(coalesce, operands[i]);
                    }
                    return coalesce;
                }
            }
        }

        protected Expression IsNull(elm.IsNullExpression isn, ExpressionBuilderContext ctx)
        {
            var operand = TranslateExpression(isn.operand!, ctx);
            if (operand.Type.IsValueType && IsNullable(operand.Type) == false)
                return Expression.Constant(false, typeof(bool?));
            else
            {
                var compare = Expression.Equal(operand, Expression.Constant(null));
                var asNullableBool = Expression.Convert(compare, typeof(bool?));
                return asNullableBool;
            }
        }

        protected Expression? IsFalse(elm.IsFalseExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.IsFalse, e, ctx);


        protected Expression? IsTrue(elm.IsTrueExpression e, ExpressionBuilderContext ctx) =>
            UnaryOperator(CqlOperator.IsTrue, e, ctx);


    }
}