using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace ProjectEuler.Problems
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
            string typeName = String.Format("Problem_{0:d3}", problemId);
            return GetProblemTypesOnProject()
                .Where(type => type.Name == typeName)
                .SingleOrDefault();
        }
        private static IEnumerable<Type> GetProblemTypesOnProject()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            return assembly.GetTypes()
                   .Where(type => type.IsClass && type.IsSubclassOf(typeof(Problem)));                   
        }
    }
}
