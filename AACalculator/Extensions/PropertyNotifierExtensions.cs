using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AACalculator.Interfaces;

namespace AACalculator.Extensions
{
    public static class PropertyNotifierExtensions
    {
        public static void RaisePropertyChanged<T>(this IPropertyChangeNotifier instance, Expression<Func<T>> expression)
        {
            var memberExpression = expression.Body as MemberExpression;
            if (memberExpression == null) throw new ArgumentException("expression must be a property expression");
            VerifyPropertyExists(instance, memberExpression.Member.Name);
            instance.RaisePropertyChanged(memberExpression.Member.Name);
        }

        [Conditional("DEBUG")]
        private static void VerifyPropertyExists(IPropertyChangeNotifier instance, string propertyName)
        {
            PropertyInfo currentProperty = instance.GetType().GetProperty(propertyName);
            string message = string.Format("Property Name \"{0}\" does not exist in {1}", propertyName, instance.GetType());
            Debug.Assert(currentProperty != null, message);
        }

    }
}
