using System;
using System.Reflection;
using System.Reflection.Emit;

namespace Model.AssemblyFunctions
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
            ModuleBuilder module = builder.DefineDynamicModule (modName, true);
            TypeBuilder typeBuilder = module.DefineType(typeName, TypeAttributes.Public);
            MethodBuilder compareMethodBuilder = typeBuilder.DefineMethod( "Compare", MethodAttributes.Public, typeof(bool), new Type[] { typeof(double), typeof(double) } );
            ILGenerator compareILGenerator = compareMethodBuilder.GetILGenerator();
            Label metka = compareILGenerator.DefineLabel();
            compareILGenerator.Emit(OpCodes.Ldarg_1);
            compareILGenerator.Emit(OpCodes.Ldarg_2);
            compareILGenerator.Emit(OpCodes.Bge_S, metka);
            compareILGenerator.Emit(OpCodes.Ldc_I4_1);
            compareILGenerator.Emit(OpCodes.Ret);
            compareILGenerator.MarkLabel(metka);
            compareILGenerator.Emit(OpCodes.Ldc_I4_0);
            compareILGenerator.Emit(OpCodes.Ret);
            MethodBuilder complementMethodBuilder = typeBuilder.DefineMethod("Complement", MethodAttributes.Public, typeof(byte), new Type[] { typeof(byte) });
            ILGenerator complementILGenerator = complementMethodBuilder.GetILGenerator();
            compareILGenerator.Emit(OpCodes.Ldarg_1);
            compareILGenerator.Emit(OpCodes.Neg);
            compareILGenerator.Emit(OpCodes.Ret);
            typeBuilder.CreateType();
            builder.Save(assemblyName+".dll");
        }

        /*double a = 0;
        double b = 0;
        Assembly asm = Assembly.Load(System.IO.File.ReadAllBytes("AssemblyModule.dll"));
        Type t = asm.GetType("AssemblyModuleDLL");
        MethodInfo method = t.GetMethod("AssemblyModule", BindingFlags.Instance | BindingFlags.Public);
        object instance = Activator.CreateInstance(t);
        method.Invoke(instance, new object[] { a, b   });*/


    }

}