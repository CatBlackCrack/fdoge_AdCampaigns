using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

[CompilerGenerated]
internal static class AE896094
{
	private static object object_0 = new object();

	private static Dictionary<string, bool> dictionary_0 = new Dictionary<string, bool>();

	private static Dictionary<string, string> dictionary_1 = new Dictionary<string, string>();

	private static Dictionary<string, string> dictionary_2 = new Dictionary<string, string>();

	private static int int_0;

	private static string smethod_0(CultureInfo cultureInfo_0)
	{
		if (cultureInfo_0 == null)
		{
			return "";
		}
		return cultureInfo_0.Name;
	}

	private static Assembly FA192C3C(AssemblyName assemblyName_0)
	{
		AppDomain currentDomain = AppDomain.CurrentDomain;
		Assembly[] assemblies = currentDomain.GetAssemblies();
		Assembly[] array = assemblies;
		int num = 0;
		Assembly assembly;
		while (true)
		{
			if (num < array.Length)
			{
				assembly = array[num];
				AssemblyName name = assembly.GetName();
				if (string.Equals(name.Name, assemblyName_0.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(smethod_0(name.CultureInfo), smethod_0(assemblyName_0.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return assembly;
	}

	private static void smethod_1(Stream D79E7001, Stream CB07DEA4)
	{
		byte[] array = new byte[81920];
		int count;
		while ((count = D79E7001.Read(array, 0, array.Length)) != 0)
		{
			CB07DEA4.Write(array, 0, count);
		}
	}

	private static Stream smethod_2(string B9A1D6AC)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (B9A1D6AC.EndsWith(".compressed"))
		{
			using (Stream stream = executingAssembly.GetManifestResourceStream(B9A1D6AC))
			{
				using DeflateStream d79E = new DeflateStream(stream, CompressionMode.Decompress);
				MemoryStream memoryStream = new MemoryStream();
				smethod_1(d79E, memoryStream);
				memoryStream.Position = 0L;
				return memoryStream;
			}
		}
		return executingAssembly.GetManifestResourceStream(B9A1D6AC);
	}

	private static Stream smethod_3(Dictionary<string, string> dictionary_3, string string_0)
	{
		if (dictionary_3.TryGetValue(string_0, out var value))
		{
			return smethod_2(value);
		}
		return null;
	}

	private static byte[] smethod_4(Stream F83CE6A0)
	{
		byte[] array = new byte[F83CE6A0.Length];
		F83CE6A0.Read(array, 0, array.Length);
		return array;
	}

	private static Assembly F197FAB1(Dictionary<string, string> E612C083, Dictionary<string, string> dictionary_3, AssemblyName assemblyName_0)
	{
		string text = assemblyName_0.Name.ToLowerInvariant();
		if (assemblyName_0.CultureInfo != null && !string.IsNullOrEmpty(assemblyName_0.CultureInfo.Name))
		{
			text = assemblyName_0.CultureInfo.Name + "." + text;
		}
		byte[] rawAssembly;
		using (Stream stream = smethod_3(E612C083, text))
		{
			if (stream == null)
			{
				return null;
			}
			rawAssembly = smethod_4(stream);
		}
		using (Stream stream2 = smethod_3(dictionary_3, text))
		{
			if (stream2 != null)
			{
				byte[] rawSymbolStore = smethod_4(stream2);
				return Assembly.Load(rawAssembly, rawSymbolStore);
			}
		}
		return Assembly.Load(rawAssembly);
	}

	public static Assembly smethod_5(object object_1, ResolveEventArgs resolveEventArgs_0)
	{
		lock (object_0)
		{
			if (dictionary_0.ContainsKey(resolveEventArgs_0.Name))
			{
				return null;
			}
		}
		AssemblyName assemblyName = new AssemblyName(resolveEventArgs_0.Name);
		Assembly assembly = FA192C3C(assemblyName);
		if ((object)assembly != null)
		{
			return assembly;
		}
		assembly = F197FAB1(dictionary_1, dictionary_2, assemblyName);
		if ((object)assembly == null)
		{
			lock (object_0)
			{
				dictionary_0[resolveEventArgs_0.Name] = true;
			}
			if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
			{
				assembly = Assembly.Load(assemblyName);
			}
		}
		return assembly;
	}

	static AE896094()
	{
		dictionary_1.Add("costura", "costura.costura.dll.compressed");
		dictionary_2.Add("costura", "costura.costura.pdb.compressed");
		dictionary_1.Add("deviceid", "costura.deviceid.dll.compressed");
		dictionary_1.Add("microsoft.win32.primitives", "costura.microsoft.win32.primitives.dll.compressed");
		dictionary_1.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
		dictionary_1.Add("otp.net", "costura.otp.net.dll.compressed");
		dictionary_2.Add("otp.net", "costura.otp.net.pdb.compressed");
		dictionary_1.Add("system.appcontext", "costura.system.appcontext.dll.compressed");
		dictionary_1.Add("system.console", "costura.system.console.dll.compressed");
		dictionary_1.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
		dictionary_1.Add("system.globalization.calendars", "costura.system.globalization.calendars.dll.compressed");
		dictionary_1.Add("system.io.compression", "costura.system.io.compression.dll.compressed");
		dictionary_1.Add("system.io.compression.zipfile", "costura.system.io.compression.zipfile.dll.compressed");
		dictionary_1.Add("system.io.filesystem", "costura.system.io.filesystem.dll.compressed");
		dictionary_1.Add("system.io.filesystem.primitives", "costura.system.io.filesystem.primitives.dll.compressed");
		dictionary_1.Add("system.net.http", "costura.system.net.http.dll.compressed");
		dictionary_1.Add("system.net.sockets", "costura.system.net.sockets.dll.compressed");
		dictionary_1.Add("system.runtime.interopservices.runtimeinformation", "costura.system.runtime.interopservices.runtimeinformation.dll.compressed");
		dictionary_1.Add("system.security.cryptography.algorithms", "costura.system.security.cryptography.algorithms.dll.compressed");
		dictionary_1.Add("system.security.cryptography.encoding", "costura.system.security.cryptography.encoding.dll.compressed");
		dictionary_1.Add("system.security.cryptography.primitives", "costura.system.security.cryptography.primitives.dll.compressed");
		dictionary_1.Add("system.security.cryptography.x509certificates", "costura.system.security.cryptography.x509certificates.dll.compressed");
		dictionary_1.Add("system.xml.readerwriter", "costura.system.xml.readerwriter.dll.compressed");
		dictionary_1.Add("xnet", "costura.xnet.dll.compressed");
		dictionary_2.Add("xnet", "costura.xnet.pdb.compressed");
	}

	public static void E5A2B9AB()
	{
		if (Interlocked.Exchange(ref int_0, 1) == 1)
		{
			return;
		}
		AppDomain currentDomain = AppDomain.CurrentDomain;
		currentDomain.AssemblyResolve += delegate(object object_1, ResolveEventArgs resolveEventArgs_0)
		{
			lock (object_0)
			{
				if (dictionary_0.ContainsKey(resolveEventArgs_0.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(resolveEventArgs_0.Name);
			Assembly assembly = FA192C3C(assemblyName);
			if ((object)assembly != null)
			{
				return assembly;
			}
			assembly = F197FAB1(dictionary_1, dictionary_2, assemblyName);
			if ((object)assembly == null)
			{
				lock (object_0)
				{
					dictionary_0[resolveEventArgs_0.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != 0)
				{
					assembly = Assembly.Load(assemblyName);
				}
			}
			return assembly;
		};
	}
}
