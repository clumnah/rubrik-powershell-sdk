using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GraphQL;
using GraphQLParser.AST;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RubrikSecurityCloud;
using System.Management.Automation;
using System.Reflection;
namespace RubrikSecurityCloud
{
    public static class ReflectionUtils
    {
        public static Type? GetType(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return typeof(object);
            }

            if (typeName.StartsWith("List<") && typeName.EndsWith(">"))
            {
                // It's a List<T>
                // remove "List<" at start and ">" at end
                var innerTypeName = typeName.Substring(5, typeName.Length - 6);
                var innerType = GetType(innerTypeName);
                if (innerType == null)
                {
                    return null;
                }

                return typeof(List<>).MakeGenericType(innerType);
            }

            var type = Type.GetType(typeName);
            if (type != null)
            {
                return type;
            }
            // type = Type.GetType("RubrikSecurityCloud.Operations." + typeName + ", RubrikSecurityCloud.Schema");
            // if (type != null)
            //     return type;
            type = Type.GetType("RubrikSecurityCloud.Types." + typeName
                + ", RubrikSecurityCloud.Schema");
            if (type != null)
            {
                return type;
            }

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var a in assemblies)
            {
                type = a.GetType(typeName);
                if (type != null)
                {
                    return type;
                }
            }
            return null;
        }
    }
}