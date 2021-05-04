using System;

namespace MicroOrm.Pocos.SqlGenerator.Core.Attributes
{
    /// <summary>
    /// 
    /// </summary>
    public class Scheme : Attribute
    {
        /// <summary>
        /// 
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value"></param>
        public Scheme(string value)
        {
            this.Value = value;
        }
    }
}
