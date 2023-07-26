using System;
using System.Collections.Generic;
using System.Reflection;

public class GClass5
{
	private readonly Dictionary<string, uint> dictionary_0;

	private BA87F503 ba87F503_0;

	private void method_0(ref byte[] F192E39C, uint uint_0)
	{
		for (int i = 0; i < F192E39C.Length; i++)
		{
			F192E39C[i] = (byte)(F192E39C[i] ^ (A310323D.smethod_0(uint_0, i) + i));
		}
	}

	private Assembly method_1(object object_0, ResolveEventArgs A10DEFB1)
	{
		return (Assembly)new GClass8().method_31(new object[3] { this, object_0, A10DEFB1 }, 29256);
	}

	public GClass5()
	{
		new GClass8().method_31(new object[1] { this }, 25179);
	}
}
