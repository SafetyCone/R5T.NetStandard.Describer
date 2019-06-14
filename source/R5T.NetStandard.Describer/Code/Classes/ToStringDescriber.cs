using System;


namespace R5T.NetStandard
{
    /// <summary>
    /// A simple <see cref="IDescriber"/> that just calls <see cref="object.ToString"/>.
    /// </summary>
    public class ToStringDescriber : IDescriber
    {
        public string Describe(object obj)
        {
            var output = obj.ToString();
            return output;
        }
    }

    /// <summary>
    /// A simple <see cref="IDescriber"/> that calls <see cref="object.ToString"/>, and implements both <see cref="IDescriber{T}"/> and <see cref="IDescriber"/> by inheriting from <see cref="DescriberBase{T}"/>.
    /// </summary>
    public class ToStringDescriber<T> : DescriberBase<T>
    {
        protected override string Describe_Implementation(T obj)
        {
            var description = obj.ToString();
            return description;
        }
    }
}
