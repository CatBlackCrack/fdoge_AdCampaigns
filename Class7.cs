using System;
using System.IO;
using System.Text;

internal class Class7
{
	private static object object_0 = new object();

	public static string smethod_0(string string_0)
	{
		lock (object_0)
		{
			if (!File.Exists(string_0))
			{
				return "";
			}
			return File.ReadAllText(string_0).Trim();
		}
	}

	public static void smethod_1(string string_0, string DE2FFB1C)
	{
		lock (object_0)
		{
			using FileStream stream = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.Read);
			using StreamWriter streamWriter = new StreamWriter(stream, Encoding.UTF8);
			streamWriter.Write(DE2FFB1C + Environment.NewLine);
		}
	}

	public static void smethod_2(string B530F2BF, string string_0)
	{
		lock (object_0)
		{
			using FileStream stream = new FileStream(B530F2BF, FileMode.Create, FileAccess.Write, FileShare.Read);
			using StreamWriter streamWriter = new StreamWriter(stream, Encoding.UTF8);
			streamWriter.Write(string_0);
		}
	}
}
