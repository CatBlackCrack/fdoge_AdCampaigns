using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

internal class Class12
{
	[CompilerGenerated]
	private sealed class Class13
	{
		public Random random_0;

		internal char FE8C33AF(string B409A327)
		{
			return B409A327[random_0.Next(B409A327.Length)];
		}
	}

	[CompilerGenerated]
	private sealed class Class14
	{
		public Random A62E5A01;

		internal char method_0(string string_0)
		{
			return string_0[A62E5A01.Next(string_0.Length)];
		}
	}

	private static Random random_0 = new Random();

	public static string CA27BAB2(int int_0)
	{
		Random random_0 = new Random();
		return new string((from B409A327 in Enumerable.Repeat("123456789", int_0)
			select B409A327[random_0.Next(B409A327.Length)]).ToArray()).ToLower();
	}

	public static string D98AD025(int int_0)
	{
		Random A62E5A = new Random();
		return new string((from string_0 in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", int_0)
			select string_0[A62E5A.Next(string_0.Length)]).ToArray()).ToLower();
	}

	public static string E71F4417(string D6926E91)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(D6926E91);
		return Convert.ToBase64String(bytes);
	}

	public static string smethod_0(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string AAA71EA6(string string_0, string D08592A2, string string_1)
	{
		int num = string_0.IndexOf(D08592A2);
		if (num < 0)
		{
			return string_0;
		}
		return string_0.Substring(0, num) + string_1 + string_0.Substring(num + D08592A2.Length);
	}

	public static void smethod_1<T>(IList<T> B8B3AD0A)
	{
		int num = B8B3AD0A.Count;
		while (num > 1)
		{
			num--;
			int index = random_0.Next(num + 1);
			T value = B8B3AD0A[index];
			B8B3AD0A[index] = B8B3AD0A[num];
			B8B3AD0A[num] = value;
		}
	}
}
