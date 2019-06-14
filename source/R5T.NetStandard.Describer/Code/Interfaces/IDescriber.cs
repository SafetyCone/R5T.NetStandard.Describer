using System;
using System.Collections.Generic;
using System.Text;

namespace R5T.NetStandard
{
    /// <summary>
    /// Describes an object.
    /// </summary>
    /// <remarks>
    /// The <see cref="IDescriber"/> interface differs from the string-serializer interface in that description is uni-directional, object to string only, while serialization implies bi-directional object to string and string to object.
    /// Description also implies lossy serialization, while serialization implies that all object information is captured.
    /// </remarks>
    public interface IDescriber
    {
        /// <summary>
        /// Describes an object.
        /// </summary>
        /// <remarks>
        /// This is lossy (not all object information is captured), uni-directional serialization (object to string).
        /// </remarks>
        string Describe(object obj);
    }

    /// <summary>
    /// Describes an object of type <typeparamref name="T"/>.
    /// </summary>
    public interface IDescriber<T>
    {
        /// <summary>
        /// Describes an object of type <typeparamref name="T"/>.
        /// </summary>
        /// <remarks>
        /// This is lossy (not all object information is captured), uni-directional serialization (object to string).
        /// </remarks>
        string Describe(T obj);
    }
}
