using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AsStrongAsFuck.Runtime;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using static AsStrongAsFuck.Renamer;

namespace AsStrongAsFuck.Protections
{
    public class JunkProtection : IObfuscation
    {
        public void Execute(ModuleDefMD md)
        {
            int classnumber = RuntimeHelper.Random.Next(40, 50);
            int methodcount = RuntimeHelper.Random.Next(15, 20);
            List<uint> junkclasses = new List<uint>();
            for (int i = 0; i < classnumber; i++)
            {
                if (new Random().Next(1, 3) == 1)
                {
                    for (int x = 0; x < methodcount; x++)
                    {
                        TypeDefUser newtype = new TypeDefUser(Renamer.GetEndName(RenameMode.Base64, 3), Renamer.GetEndName(RenameMode.Invalid, 3));
                        md.Types.Add(newtype);
                        TypeDefUser newtype1 = new TypeDefUser(Renamer.GetEndName(RenameMode.Base64, 3), Renamer.GetEndName(RenameMode.Invalid, 3));
                        md.Types.Add(newtype1);
                        MethodDefUser newmethod = new MethodDefUser(Renamer.GetEndName(RenameMode.Base64, 3), new MethodSig(CallingConvention.Default, 0, md.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static);
                        newtype.Methods.Add(newmethod);
                        MethodDefUser newmethod1 = new MethodDefUser(Renamer.GetEndName(RenameMode.Base64, 3), new MethodSig(CallingConvention.Default, 0, md.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static);
                        newtype.Methods.Add(newmethod1);
                        MethodDefUser newmethod2 = new MethodDefUser(Renamer.GetEndName(RenameMode.Base64, 3), new MethodSig(CallingConvention.Default, 0, md.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static);
                        newtype.Methods.Add(newmethod2);
                        newmethod.Body = new CilBody();
                        int localcount = RuntimeHelper.Random.Next(5, 15);
                        for (int j = 0; j < localcount; j++)
                        {
                            Local lcl = new Local(md.CorLibTypes.Int32);
                            newmethod.Body.Variables.Add(lcl);
                            newmethod.Body.Instructions.Add(new Instruction(OpCodes.Ldc_I4, RuntimeHelper.Random.Next()));
                            newmethod.Body.Instructions.Add(new Instruction(OpCodes.Stloc, lcl));
                        }
                        newmethod.Body.Instructions.Add(new Instruction(OpCodes.Ret));
                        junkclasses.Add(newtype.Rid);
                    }
                }
                else if (new Random().Next(1, 3) == 1)
                {
                    for (int x = 0; x < methodcount; x++)
                    {
                        TypeDefUser newtype = new TypeDefUser(Renamer.GetEndName(RenameMode.Logical, 3), Renamer.GetEndName(RenameMode.Invalid, 3));
                        md.Types.Add(newtype);
                        TypeDefUser newtype1 = new TypeDefUser(Renamer.GetEndName(RenameMode.Logical, 3), Renamer.GetEndName(RenameMode.Invalid, 3));
                        md.Types.Add(newtype1);
                        MethodDefUser newmethod = new MethodDefUser(Renamer.GetEndName(RenameMode.Logical, 3), new MethodSig(CallingConvention.Default, 0, md.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static);
                        newtype.Methods.Add(newmethod);
                        MethodDefUser newmethod1 = new MethodDefUser(Renamer.GetEndName(RenameMode.Logical, 3), new MethodSig(CallingConvention.Default, 0, md.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static);
                        newtype.Methods.Add(newmethod1);
                        MethodDefUser newmethod2 = new MethodDefUser(Renamer.GetEndName(RenameMode.Logical, 3), new MethodSig(CallingConvention.Default, 0, md.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static);
                        newtype.Methods.Add(newmethod2);
                        newmethod.Body = new CilBody();
                        int localcount = RuntimeHelper.Random.Next(5, 15);
                        for (int j = 0; j < localcount; j++)
                        {
                            Local lcl = new Local(md.CorLibTypes.Int32);
                            newmethod.Body.Variables.Add(lcl);
                            newmethod.Body.Instructions.Add(new Instruction(OpCodes.Ldc_I4, RuntimeHelper.Random.Next()));
                            newmethod.Body.Instructions.Add(new Instruction(OpCodes.Stloc, lcl));
                        }
                        newmethod.Body.Instructions.Add(new Instruction(OpCodes.Ret));
                        junkclasses.Add(newtype.Rid);
                    }
                }
                else
                {
                    for (int x = 0; x < methodcount; x++)
                    {
                        TypeDefUser newtype = new TypeDefUser(Renamer.GetEndName(RenameMode.Invalid, 3), Renamer.GetEndName(RenameMode.Invalid, 3));
                        md.Types.Add(newtype);
                        TypeDefUser newtype1 = new TypeDefUser(Renamer.GetEndName(RenameMode.Invalid, 3), Renamer.GetEndName(RenameMode.Invalid, 3));
                        md.Types.Add(newtype1);
                        MethodDefUser newmethod = new MethodDefUser(Renamer.GetEndName(RenameMode.Invalid, 3), new MethodSig(CallingConvention.Default, 0, md.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static);
                        newtype.Methods.Add(newmethod);
                        MethodDefUser newmethod1 = new MethodDefUser(Renamer.GetEndName(RenameMode.Invalid, 3), new MethodSig(CallingConvention.Default, 0, md.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static);
                        newtype.Methods.Add(newmethod1);
                        MethodDefUser newmethod2 = new MethodDefUser(Renamer.GetEndName(RenameMode.Invalid, 3), new MethodSig(CallingConvention.Default, 0, md.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static);
                        newtype.Methods.Add(newmethod2);
                        newmethod.Body = new CilBody();
                        int localcount = RuntimeHelper.Random.Next(5, 15);
                        for (int j = 0; j < localcount; j++)
                        {
                            Local lcl = new Local(md.CorLibTypes.Int32);
                            newmethod.Body.Variables.Add(lcl);
                            newmethod.Body.Instructions.Add(new Instruction(OpCodes.Ldc_I4, RuntimeHelper.Random.Next()));
                            newmethod.Body.Instructions.Add(new Instruction(OpCodes.Stloc, lcl));
                        }
                        newmethod.Body.Instructions.Add(new Instruction(OpCodes.Ret));
                        junkclasses.Add(newtype.Rid);
                    }
                }
            }
            Console.WriteLine($"Added {classnumber + 2} junk classes.");

            //foreach (var type in md.Types)
            //{
            //    if (!junkclasses.Contains(type.Rid))
            //    {
            //        int methodcount = RuntimeHelper.Random.Next(10, 30);
            //        for (int x = 0; x < methodcount; x++)
            //        {
            //            MethodDefUser newmethod = new MethodDefUser(Renamer.GetEndName(RenameMode.Base64, 3), new MethodSig(CallingConvention.Default, 0, md.CorLibTypes.Void), MethodAttributes.Public | MethodAttributes.Static);
            //            type.Methods.Add(newmethod);
            //            newmethod.Body = new CilBody();
            //            int localcount = RuntimeHelper.Random.Next(5, 15);
            //            for (int j = 0; j < localcount; j++)
            //            {
            //                Local lcl = new Local(md.CorLibTypes.Int32);
            //                newmethod.Body.Variables.Add(lcl);
            //                newmethod.Body.Instructions.Add(new Instruction(OpCodes.Ldc_I4, RuntimeHelper.Random.Next()));
            //                newmethod.Body.Instructions.Add(new Instruction(OpCodes.Stloc, lcl));
            //            }
            //            newmethod.Body.Instructions.Add(new Instruction(OpCodes.Ret));
            //        }
            //    }
            //}
        }

        public void AddFakeClasses(ModuleDefMD md)
        {
            List<uint> junkclasses = new List<uint>();
            int mthcnt = 1;
            for (int x = 0; x < mthcnt; x++)
            {
                TypeDefUser newtype = new TypeDefUser("KoiVM.Runtime", "VMEntry");
                md.Types.Add(newtype);
                MethodDefUser newmethod = new MethodDefUser("Run", new MethodSig(CallingConvention.Default, 0, md.CorLibTypes.Void), dnlib.DotNet.MethodAttributes.Public | dnlib.DotNet.MethodAttributes.Public | dnlib.DotNet.MethodAttributes.Static);
                newtype.Methods.Add(newmethod);
                MethodDefUser newmethod1 = new MethodDefUser("RunInternal", new MethodSig(CallingConvention.Default, 0, md.CorLibTypes.Void), dnlib.DotNet.MethodAttributes.Public | dnlib.DotNet.MethodAttributes.Static);
                newtype.Methods.Add(newmethod1);
                newmethod.Body = new CilBody();
                newmethod1.Body = new CilBody();
                int localcount = RuntimeHelper.Random.Next(5, 15);
                for (int j = 0; j < localcount; j++)
                {
                    Local lcl = new Local(md.CorLibTypes.Int32);
                    newmethod.Body.Variables.Add(lcl);
                    newmethod.Body.Instructions.Add(new Instruction(OpCodes.Ldc_I4, RuntimeHelper.Random.Next()));
                    newmethod.Body.Instructions.Add(new Instruction(OpCodes.Stloc, lcl));
                    newmethod1.Body.Variables.Add(lcl);
                    newmethod1.Body.Instructions.Add(new Instruction(OpCodes.Ldc_I4, RuntimeHelper.Random.Next()));
                    newmethod1.Body.Instructions.Add(new Instruction(OpCodes.Stloc, lcl));
                }
                newmethod.Body.Instructions.Add(new Instruction(OpCodes.Ret));
                newmethod1.Body.Instructions.Add(new Instruction(OpCodes.Ret));
                junkclasses.Add(newtype.Rid);
            }
            for (int x = 0; x < mthcnt; x++)
            {
                TypeDefUser newtype = new TypeDefUser("", "VM");
                md.Types.Add(newtype);
                MethodDefUser newmethod = new MethodDefUser("VM", new MethodSig(CallingConvention.Default, 0, md.CorLibTypes.Void), dnlib.DotNet.MethodAttributes.Public | dnlib.DotNet.MethodAttributes.Static);
                newtype.Methods.Add(newmethod);
                MethodDefUser newmethod1 = new MethodDefUser("KoiVM", new MethodSig(CallingConvention.Default, 0, md.CorLibTypes.Void), dnlib.DotNet.MethodAttributes.Public | dnlib.DotNet.MethodAttributes.Static);
                newtype.Methods.Add(newmethod1);
                newmethod.Body = new CilBody();
                newmethod1.Body = new CilBody();
                int localcount = RuntimeHelper.Random.Next(5, 15);
                for (int j = 0; j < localcount; j++)
                {
                    Local lcl = new Local(md.CorLibTypes.Int32);
                    newmethod.Body.Variables.Add(lcl);
                    newmethod.Body.Instructions.Add(new Instruction(OpCodes.Ldc_I4, RuntimeHelper.Random.Next()));
                    newmethod.Body.Instructions.Add(new Instruction(OpCodes.Stloc, lcl));
                    newmethod1.Body.Variables.Add(lcl);
                    newmethod1.Body.Instructions.Add(new Instruction(OpCodes.Ldc_I4, RuntimeHelper.Random.Next()));
                    newmethod1.Body.Instructions.Add(new Instruction(OpCodes.Stloc, lcl));
                }
                newmethod.Body.Instructions.Add(new Instruction(OpCodes.Ret));
                newmethod1.Body.Instructions.Add(new Instruction(OpCodes.Ret));
                junkclasses.Add(newtype.Rid);
            }
        }
    }
}
