using System;


namespace R5T.NetStandard
{
    /// <summary>
    /// Describes a type using the <see cref="Type.FullName"/> property.
    /// </summary>
    public class FullNameTypeDescriber : IDescriber<Type>
    {
        #region Static

        public static readonly FullNameTypeDescriber Instance = new FullNameTypeDescriber();

        #endregion



        public string Describe(Type type)
        {
            var description = type.FullName;
            return description;
        }
    }
}
