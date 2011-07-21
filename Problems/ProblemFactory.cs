using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ProjectEuler
{
    public static class ProblemFactory
    {
        public static Problem GetProblem(int problemId)
        {
            Type type = GetProblemType(problemId);

            return type == null ? null : (Problem)Activator.CreateInstance(type);
        }

        private static Type GetProblemType(int problemId)
        {
            string typeName = String.Format("Problem{0}", problemId);
            var types = from type in GetProblemTypesOnProject()
                       where type.Name == typeName
                       select type;

            return types.SingleOrDefault();
        }
        private static IEnumerable<Type> GetProblemTypesOnProject()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return from type in assembly.GetTypes()
                   where type.IsClass && type.IsSubclassOf(typeof(Problem))
                   select type;
        }
    }
}
