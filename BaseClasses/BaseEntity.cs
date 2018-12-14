using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BaseClasses;

namespace BaseClasses
{
    public class BaseEntity
    {
		public List<string> UpdateFields<TEntity>(TEntity entity) where TEntity : BaseEntity
		{
			var properties = this.GetType().GetProperties();
			var changedFields = new List<string>();
			foreach (var property in properties.Where(e => e.IsDefined(typeof(UpdatableField), false)))
			{
				var value = property.GetValue(this);
				var sourceValue = property.GetValue(entity);
				if (value != sourceValue)
				{
					property.SetValue(this, sourceValue);
					changedFields.Add(property.Name);
				}
			}

			return changedFields;
		}

		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }

        public DateTime CreatedOnUtc { get; set; }

        public void GetDate()
        {
            CreatedOnUtc = DateTime.UtcNow;

        }


    }
}
