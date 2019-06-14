using System;


namespace R5T.NetStandard
{
    /// <summary>
    /// Allows encapsulating a function for describing objects.
    /// </summary>
    public class FunctionalDescriber : IDescriber
    {
        public Func<object, string> DescriberFunction { get; set; }


        public FunctionalDescriber()
        {
        }

        public FunctionalDescriber(Func<object, string> describerFunction)
        {
            this.DescriberFunction = describerFunction;
        }

        public string Describe(object obj)
        {
            var output = this.DescriberFunction(obj);
            return output;
        }
    }


    /// <summary>
    /// Allows encapsulating a function for describing objects of type <typeparamref name="T"/>.
    /// </summary>
    public class FunctionalDescriber<T> : IDescriber<T>
    {
        public Func<T, string> DescriberFunction { get; set; }


        public FunctionalDescriber()
        {
        }

        public FunctionalDescriber(Func<T, string> describerFunction)
        {
            this.DescriberFunction = describerFunction;
        }

        public string Describe(T obj)
        {
            var output = this.DescriberFunction(obj);
            return output;
        }
    }
}
