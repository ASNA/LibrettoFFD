using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortCollection
{
    public class Worker
    {
        public List<rpUtilities.Field> SortKeyFields(rpUtilities.FieldCollection fields) 
        {

            List<rpUtilities.Field> keyFields = new List<rpUtilities.Field>();
            //List<rpUtilities.Field> keyFieldsSorted = new List<rpUtilities.Field>;

            foreach (rpUtilities.Field field in fields) {
                if (field.IsKey) {
                    keyFields.Add(field);
                }
            }

            List<rpUtilities.Field> result = keyFields.OrderBy(o => o.KeyPosition).ToList();

            return result;
        }
    }
}
