using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Function
{
    class GenerateDLL
    {
        public static void Generate()
        { 
            string assemblyName = "AssemblyModule";
            string modName = "AssemblyModule.dll";
            string typeName = "AssemblyModuleDLL";

            AssemblyName name = new AssemblyName(assemblyName);
            AppDomain domain = System.Threading.Thread.GetDomain();
            AssemblyBuilder builder = domain.DefineDynamicAssembly(name, AssemblyBuilderAccess.RunAndSave);
            ModuleBuilder module = builder.DefineDynamicModule(modName, true);
            TypeBuilder typeBuilder = module.DefineType(typeName, TypeAttributes.Public);
            MethodBuilder compareMethodBuilder = typeBuilder.DefineMethod("Compare", MethodAttributes.Public, typeof(byte), new Type[] { typeof(double), typeof(double) });
            ILGenerator compareILGenerator = compareMethodBuilder.GetILGenerator();
            Label met = compareILGenerator.DefineLabel();
            compareILGenerator.Emit(OpCodes.Ldarg_1);
            compareILGenerator.Emit(OpCodes.Ldarg_2);
            compareILGenerator.Emit(OpCodes.Bge_S, met);
            compareILGenerator.Emit(OpCodes.Ldc_I4_1);
            compareILGenerator.Emit(OpCodes.Ret);
            compareILGenerator.MarkLabel(met);
            compareILGenerator.Emit(OpCodes.Ldc_I4_0);
            compareILGenerator.Emit(OpCodes.Ret);
            MethodBuilder complementMethodBuilder = typeBuilder.DefineMethod("Complement", MethodAttributes.Public, typeof(uint), new Type[] { typeof(uint) });
            ILGenerator complementILGenerator = complementMethodBuilder.GetILGenerator();
            complementILGenerator.Emit(OpCodes.Ldarg_1);
            complementILGenerator.Emit(OpCodes.Not);
            complementILGenerator.Emit(OpCodes.Ret);
            typeBuilder.CreateType();
            builder.Save(assemblyName + ".dll");
        }
    }
}