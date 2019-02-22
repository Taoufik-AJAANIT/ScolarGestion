using System;
namespace GestionNotes
{
    public class RequestCondition
    {
        private string Param;

        public RequestCondition()
        { 

        }

        public string Equal(Object value)
        {
            return "="+value ;
        }

        public string ForlNnotlN(Object[]  values )
        {

            if(values.Length > 0){
                string result = "(";
                string virg = "";
                for (int i = 0; i < values.Length; i++) {

                    if (i < values.Length -1)
                        virg = ",";
                    else virg = ")";
                    if (values[i] is int){
                        result += values[i];
                    }
                    if (values[i] is string)
                    {
                        result += "'" + values[i] + "'" ;
                    }

                    result += virg;
                }
                return result;
            }

            return null;
        }

        public string GreaterThan(Object value)
        {
            return " > " + value;
        }

        public string GreaterThanOrEqual(Object value)
        {
                return " >= " + value;

        }
        public string IN(Object[] value)
        {
            return " in " + ForlNnotlN(value);
        }

 
        public string LessThan(Object value)
        {
        
                return "< " + value;
 
        }
        public string LessThanOrEqual(Object value)
        {
                return "<= " + value;
        }
        public string LikeCenter(Object value)
        {
            return " like '%" + value+"%'";
        }
        public string LikeFirst(Object value)
        {
            return " like '%" + value + "'"; 
        }
        public string LikeLast(Object value)
        {
            return " like '" + value + "%'";
        }
        public string NotEqual(Object value)
        {
            if (value is int)
                return "!= " + value;
            return "<> '" + value + "'";
        }
        public string NotIN(Object[] value)
        {
            return " not in " + ForlNnotlN( value);
        }

    }
}
