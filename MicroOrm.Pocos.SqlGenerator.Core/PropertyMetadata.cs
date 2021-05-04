using MicroOrm.Pocos.SqlGenerator.Core.Attributes;
using System.Reflection;

namespace MicroOrm.Pocos.SqlGenerator.Core
{
    /// <summary>
    /// 
    /// </summary>
    public class PropertyMetadata
    {
        public PropertyInfo PropertyInfo { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Alias { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string ColumnName
        {
            get
            {
                return string.IsNullOrEmpty(this.Alias) ? this.PropertyInfo.Name : this.Alias;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get
            {
                return this.PropertyInfo.Name;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyInfo"></param>
        public PropertyMetadata(PropertyInfo propertyInfo)
        {
            this.PropertyInfo = propertyInfo;

            var alias = this.PropertyInfo.GetCustomAttribute<StoredAs>();
            this.Alias = alias != null ? alias.Value : string.Empty;
        }
    }
}
