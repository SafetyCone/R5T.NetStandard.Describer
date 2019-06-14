using System;


namespace R5T.NetStandard
{
    public static class Describer
    {
        /// <summary>
        /// The default <see cref="IDescriber"/> (the <see cref="ToStringDescriber"/>).
        /// </summary>
        public static readonly IDescriber Default = new ToStringDescriber();
    }
}
