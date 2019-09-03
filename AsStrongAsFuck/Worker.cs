using AsStrongAsFuck.Runtime;
using dnlib.DotNet;
using dnlib.DotNet.Emit;
using dnlib.DotNet.MD;
using dnlib.DotNet.Writer;
using dnlib.IO;
using dnlib.PE;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static AsStrongAsFuck.Renamer;

namespace AsStrongAsFuck
{
    public class Worker
    {
        private Assembly OwnAssembly => this.GetType().Assembly;
        public Assembly Default_Assembly { get; set; }

        public AssemblyDef Assembly { get; set; }

        public ModuleDefMD Module { get; set; }
        public string Path { get; set; }

        public string Code { get; set; }
        public Worker(string path)
        {
            Path = path.Replace("\"", "");
            LoadAssembly();
            LoadModuleDefMD();
            LoadObfuscations();
            LoadDependencies();
            RuntimeHelper.Importer = new Importer(Module);
        }

        public void Watermark()
        {
            Console.WriteLine("Watermarking...");
            var attrType = new TypeDefUser("", "MoneydevAttribute");
            Module.Types.Add(attrType);
            var attrType2 = new TypeDefUser("", "BabelObfuscatorAttribute", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType2);
            var attrType3 = new TypeDefUser("", "Beds-Protector", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType3);
            var attrType4 = new TypeDefUser("", "ConfusedByAttribute", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType4);
            var attrType5 = new TypeDefUser("", "CryptoObfuscator.ProtectedWithCryptoObfuscatorAttribute", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType5);
            var attrType6 = new TypeDefUser("", "DotfuscatorAttribute", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType6);
            var attrType7 = new TypeDefUser("", "EMyPID_8234_", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType7);
            var attrType8 = new TypeDefUser("", "moneydev", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType8);
            var attrType9 = new TypeDefUser("", "NETGuard", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType9);
            var attrType10 = new TypeDefUser("", "NineRays.Obfuscator.Evaluation", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType10);
            var attrType11 = new TypeDefUser("", "ObfuscatedByGoliath", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType11);
            var attrType12 = new TypeDefUser("", "OiCuntJollyGoodDayYeHavin_____________________________________________________", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType12);
            var attrType13 = new TypeDefUser("", "Reactor", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType13);
            var attrType14 = new TypeDefUser("", "SecureTeam.Attributes.ObfuscatedByAgileDotNetAttribute", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType14);
            var attrType15 = new TypeDefUser("", "SkidfuscatorAttribute", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType15);
            var attrType16 = new TypeDefUser("", "SmartAssembly.Attributes.PoweredByAttribute", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType16);
            var attrType17 = new TypeDefUser("", "VMProtect", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType17);
            var attrType18 = new TypeDefUser("", "VMProtectAttribute", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType18);
            var attrType19 = new TypeDefUser("", "Xenocode.Client.Attributes.AssemblyAttributes.ProcessedByXenocode", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType19);
            var attrType20 = new TypeDefUser("", "YanoAttribute", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType20);
            var attrType21 = new TypeDefUser("", "ZYXDNGuarder", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType21);
            var attrType22 = new TypeDefUser("", "<Module>{5463E459-C078-4545-9554-6B8CC9042999}", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType22);
            var attrType23 = new TypeDefUser("", "ILLicenseModule", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType23);
            var attrType24 = new TypeDefUser("", "de4fuckyou", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType24);
            var attrType25 = new TypeDefUser("", "NetShield", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType25);
            var attrType26 = new TypeDefUser("", "CrytpoObfuscator", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType26);
            var attrType27 = new TypeDefUser("", "CryptoObfuscator", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType27);
            var attrType28 = new TypeDefUser("", ".NETReactorAttribute", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType28);
            var attrType29 = new TypeDefUser("", "MaxtoCodeAttribute", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType29);
            var attrType30 = new TypeDefUser("", "Shitfuscator-PRO", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType30);
            var attrType31 = new TypeDefUser("", "VMEntry", Module.CorLibTypes.GetTypeRef("System", "Attribute"));
            Module.Types.Add(attrType31);
            var ctor = new MethodDefUser(
                ".ctor",
                MethodSig.CreateInstance(Module.CorLibTypes.Void, Module.CorLibTypes.String),
                dnlib.DotNet.MethodImplAttributes.Managed,
                dnlib.DotNet.MethodAttributes.HideBySig | dnlib.DotNet.MethodAttributes.Public | dnlib.DotNet.MethodAttributes.SpecialName | dnlib.DotNet.MethodAttributes.RTSpecialName);
            ctor.Body = new CilBody();
            ctor.Body.MaxStack = 1;
            ctor.Body.Instructions.Add(OpCodes.Ldarg_0.ToInstruction());
            ctor.Body.Instructions.Add(OpCodes.Call.ToInstruction(new MemberRefUser(Module, ".ctor", MethodSig.CreateInstance(Module.CorLibTypes.Void), Module.CorLibTypes.GetTypeRef("System", "Attribute"))));
            ctor.Body.Instructions.Add(OpCodes.Ret.ToInstruction());
            attrType.Methods.Add(ctor);
            var attr = new CustomAttribute(ctor);
            attr.ConstructorArguments.Add(new CAArgument(Module.CorLibTypes.String, Renamer.GetFuckedString(69)));
            Module.CustomAttributes.Add(attr);
        }

        public void ExecuteObfuscations(string param)
        {
            Code = param;
            var shit = param.ToCharArray().ToList();
            Stopwatch watch = new Stopwatch();
            watch.Start();
            foreach (var v in shit)
            {
                int i = int.Parse(v.ToString()) - 1;
                Logger.LogMessage("Executing ", Obfuscations[i], ConsoleColor.Magenta);
                Type type = OwnAssembly.GetTypes().First(x => x.Name == Obfuscations[i]);
                var instance = Activator.CreateInstance(type);
                MethodInfo info = type.GetMethod("Execute");
                try
                {
                    info.Invoke(instance, new object[] { Module });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            watch.Stop();
            Console.WriteLine("Time taken: " + watch.Elapsed.ToString());
        }

        public void LoadAssembly()
        {
            Console.Write("Loading assembly...");
            Default_Assembly = System.Reflection.Assembly.UnsafeLoadFrom(Path);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Loaded: ");
            Console.WriteLine(Default_Assembly.FullName);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void LoadModuleDefMD()
        {
            Console.Write("Loading ModuleDefMD...");
            Module = ModuleDefMD.Load(Path);
            Assembly = Module.Assembly;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(" Loaded: ");
            Console.WriteLine(Module.FullName);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void LoadDependencies()
        {
            Console.WriteLine("Resolving dependencies...");
            var asmResolver = new AssemblyResolver();
            ModuleContext modCtx = new ModuleContext(asmResolver);
            
            asmResolver.DefaultModuleContext = modCtx;

            asmResolver.EnableTypeDefCache = true;

            asmResolver.DefaultModuleContext = new ModuleContext(asmResolver);
            asmResolver.PostSearchPaths.Insert(0, Path);
            if (IsCosturaPresent(Module))
            {
                foreach (var asm in ExtractCosturaEmbeddedAssemblies(GetEmbeddedCosturaAssemblies(Module), Module))
                    asmResolver.AddToCache(asm);
            }

            foreach (var dependency in Module.GetAssemblyRefs())
            {
                AssemblyDef assembly = asmResolver.ResolveThrow(dependency, Module);
                Console.WriteLine("Resolved " + dependency.Name);
            }
            Module.Context = modCtx;
        }

        public bool IsCosturaPresent(ModuleDef module) =>
            module.Types.FirstOrDefault(t => t.Name == "AssemblyLoader" && t.Namespace == "Costura") != null;

        public string[] GetEmbeddedCosturaAssemblies(ModuleDef module)
        {
            var list = new List<string>();

            var ctor = module.Types.Single(t => t.Name == "AssemblyLoader" && t.Namespace == "Costura").FindStaticConstructor();
            var instructions = ctor.Body.Instructions;
            for (var i = 1; i < instructions.Count; i++)
            {
                var curr = instructions[i];
                if (curr.OpCode != OpCodes.Ldstr || instructions[i - 1].OpCode != OpCodes.Ldstr)
                    continue;

                var resName = ((string)curr.Operand).ToLowerInvariant();
                if (resName.EndsWith(".pdb") || resName.EndsWith(".pdb.compressed"))
                {
                    i++;
                    continue;
                }

                list.Add((string)curr.Operand);
            }

            return list.ToArray();
        }

        public List<AssemblyDef> ExtractCosturaEmbeddedAssemblies(string[] assemblies, ModuleDef module)
        {
            var list = new List<AssemblyDef>();

            foreach (var assembly in assemblies)
            {
                var resource = module.Resources.FindEmbeddedResource(assembly.ToLowerInvariant());
                if (resource == null)
                    throw new Exception("Couldn't find Costura embedded assembly: " + assembly);

                if (resource.Name.EndsWith(".compressed"))
                {
                    list.Add(DecompressCosturaAssembly(resource.GetResourceStream()));
                    continue;
                }

                list.Add(AssemblyDef.Load(resource.GetResourceStream()));
            }

            return list;
        }

        public AssemblyDef DecompressCosturaAssembly(Stream resource)
        {
            using (var def = new DeflateStream(resource, CompressionMode.Decompress))
            {
                var ms = new MemoryStream();
                def.CopyTo(ms);
                ms.Position = 0;
                return AssemblyDef.Load(ms);
            }
        }

        public void Save()
        {
            Watermark();
            Logger.LogMessage("Saving as ", Path + "obfuscated.exe", ConsoleColor.Yellow);
            ModuleWriterOptions opts = new ModuleWriterOptions(Module);
            opts.Logger = DummyLogger.NoThrowInstance;

            //Testing
            opts.PEHeadersOptions.NumberOfRvaAndSizes = 13;
            opts.MetaDataOptions.TablesHeapOptions.ExtraData = 0x12345678;
            int classnumber = RuntimeHelper.Random.Next(75, 100);
            for (int i = 0; i < classnumber; i++)
            {
                opts.MetaDataOptions.OtherHeaps.Add(new MyHeap(Renamer.GetRandomName()));
            }

            int ii = 7;
            Type typex = OwnAssembly.GetTypes().First(x => x.Name == Obfuscations[ii]);
            var instance = Activator.CreateInstance(typex);
            MethodInfo infod = typex.GetMethod("AddFakeClasses");
            try
            {
                infod.Invoke(instance, new object[] { Module });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Assembly.Write(Path + "obfuscated.exe", opts);
            Console.WriteLine("Saved.");
        }

        public void LoadObfuscations()
        {
            Obfuscations = new List<string>();
            var ass = this.GetType().Assembly;
            var types = ass.GetTypes();
            foreach (Type type in Enumerable.Where<Type>(types, (Type t) => t != null))
            {
                if (type.GetInterface("IObfuscation") != null)
                {
                    Obfuscations.Add(type.Name);
                }
            }
        }

        public List<string> Obfuscations { get; set; }
    }

    // A simple heap (must implement the IHeap interface). It just writes 10 bytes to the file.
    class MyHeap : IHeap
    {
        string name;
        FileOffset offset;
        RVA rva;

        // This is the data. I chose 10 bytes, but any non-zero value can be used
        byte[] heapData = new byte[10];

        public MyHeap(string name) => this.name = name;

        // The rest of the code is just for implementing the required interface

        public string Name => name;
        public bool IsEmpty => false;

        public void SetReadOnly()
        {
        }

        public FileOffset FileOffset => offset;
        public RVA RVA => rva;

        public void SetOffset(FileOffset offset, RVA rva)
        {
            this.offset = offset;
            this.rva = rva;
        }

        public uint GetFileLength() => (uint)heapData.Length;
        public uint GetVirtualSize() => GetFileLength();
        public void WriteTo(BinaryWriter writer) => writer.Write(heapData);
    }
}
