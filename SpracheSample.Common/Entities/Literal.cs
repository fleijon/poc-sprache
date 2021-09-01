using System;

namespace SpracheSample.Common
{
    public abstract class Literal<TValue> : BaseEntity
    {
        public TValue Value { get; }

        protected Literal(TValue value)
        {
            Value = value;
        }

        public override T GetValue<T>() => (T)Convert.ChangeType(Value, typeof(T));
    }
}