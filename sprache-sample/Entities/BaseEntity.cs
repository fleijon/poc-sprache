using System;

namespace SpracheSample.Common
{
    public abstract class BaseEntity
    {
        public virtual BaseEntity this[string name] => throw new InvalidOperationException($"{GetType().Name} doesn't support this operation.");

        public virtual BaseEntity this[int index] =>
            throw new InvalidOperationException($"{GetType().Name} doesn't support this operation.");

        public virtual T GetValue<T>() =>
            throw new InvalidOperationException($"{GetType().Name} doesn't support this operation.");

        public static BaseEntity Parse(string elisaFormat) =>
            throw new NotImplementedException("Not implemented yet!");
    }
}