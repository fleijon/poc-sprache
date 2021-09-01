using System.Collections.Generic;
using System.Linq;

namespace SpracheSample.Common
{
    public class ElisaArray : BaseEntity
    {
        public IReadOnlyList<BaseEntity> Children { get; }

        public ElisaArray(IReadOnlyList<BaseEntity> children)
        {
            Children = children;
        }

        public override BaseEntity this[int index] => Children.ElementAtOrDefault(index);
    }
}