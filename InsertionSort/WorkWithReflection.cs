using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class WorkWithReflection
    {
        public void ShowAllMethods(Object obj)
        {
            var type = obj.GetType();
            var className = obj.GetType().Name;
            Console.WriteLine("Class name:"+className);
            Console.WriteLine("Methods:");
            MethodInfo[] methodInfoArray = type.GetMethods(BindingFlags.NonPublic |
                BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public);

            for (int i = 0; i < methodInfoArray.Length; i++)
            {
                Console.WriteLine(GetSignature(methodInfoArray[i]));
            }

        }

        public string GetSignature(MethodInfo mi)
        {
            StringBuilder sb = new StringBuilder();

            if (mi.IsPrivate)
                sb.Append("private ");
            if (mi.IsPublic)
                sb.Append("public ");
            if (mi.IsStatic)
                sb.Append("static ");

            sb.Append(mi.ReturnType.Name + " ");
            sb.Append(mi.Name + "(");
            var param = mi.GetParameters().Select(p => String.Format(
                        "{0} {1}", p.ParameterType.Name, p.Name)).ToArray();

            sb.Append(String.Join(", ", param));
            sb.Append(")");

            return sb.ToString();
        }

        public void ShowAllFields(Object obj)
        {
            var type = obj.GetType();
            Console.WriteLine("Fields:");
            FieldInfo[] fieldInfoArray = type.GetFields(BindingFlags.NonPublic | BindingFlags.Static 
                | BindingFlags.Instance | BindingFlags.Public);

            for (int i = 0; i < fieldInfoArray.Length; i++)
            {
                Console.WriteLine(GetFieldBody(fieldInfoArray[i]));
            }

        }

        public string GetFieldBody(FieldInfo fieldInfo)
        {
            StringBuilder sb = new StringBuilder();

            if (fieldInfo.IsPrivate)
                sb.Append("private ");
            if (fieldInfo.IsPublic)
                sb.Append("public ");
            if (fieldInfo.IsStatic)
                sb.Append("static ");

            sb.Append(fieldInfo.FieldType.Name + " ");
            sb.Append(fieldInfo.Name);

            return sb.ToString();
        }
  
    }
}
