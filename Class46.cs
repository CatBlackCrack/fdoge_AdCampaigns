using System;
using System.Reflection;
using System.Runtime.InteropServices;

internal static class Class46
{
	private static readonly B683E31B.B8ADFEB7[] BE371FAF;

	public static readonly long D1375527;

	public static long smethod_0()
	{
		return D1375527;
	}

	public static IntPtr smethod_1(uint DA0BE60D)
	{
		uint num;
		if (BE371FAF != null)
		{
			num = 0u;
			for (int i = 0; i < BE371FAF.Length; i++)
			{
				B683E31B.B8ADFEB7 b8ADFEB = BE371FAF[i];
				if (DA0BE60D >= b8ADFEB.uint_1)
				{
					if (DA0BE60D >= b8ADFEB.uint_1 && DA0BE60D < b8ADFEB.uint_1 + b8ADFEB.uint_0)
					{
						num = b8ADFEB.C3BD483B + DA0BE60D - b8ADFEB.uint_1;
						break;
					}
					continue;
				}
				if (i == 0)
				{
					num = DA0BE60D;
				}
				break;
			}
			if (num == 0)
			{
				throw new BadImageFormatException();
			}
		}
		else
		{
			num = DA0BE60D;
		}
		return new IntPtr(D1375527 + num);
	}

	unsafe static Class46()
	{
		Module module = typeof(B683E31B).Module;
		D1375527 = Marshal.GetHINSTANCE(module).ToInt64();
		if (D1375527 == -1L)
		{
			throw new PlatformNotSupportedException();
		}
		if (module.Assembly.Location.Length != 0)
		{
			return;
		}
		B683E31B.Struct3* ptr = (B683E31B.Struct3*)D1375527;
		if (ptr->A3AA920E == 23117)
		{
			uint dC36C = ptr->DC36C709;
			B683E31B.C6AD0E86* ptr2 = (B683E31B.C6AD0E86*)(D1375527 + dC36C);
			if (ptr2->uint_0 == 17744)
			{
				dC36C += (uint)(Marshal.SizeOf(typeof(B683E31B.C6AD0E86)) + ptr2->struct5_0.ushort_2);
				BE371FAF = new B683E31B.B8ADFEB7[ptr2->struct5_0.ushort_1];
				B683E31B.B8ADFEB7* ptr3 = (B683E31B.B8ADFEB7*)(D1375527 + dC36C);
				for (int i = 0; i < BE371FAF.Length; i++)
				{
					BE371FAF[i] = ptr3[i];
				}
			}
		}
		if (BE371FAF == null)
		{
			throw new BadImageFormatException();
		}
	}
}
