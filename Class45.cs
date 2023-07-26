using System;

internal static class Class45
{
	internal static int F71B5E10(uint uint_0)
	{
		if (uint_0 == 0)
		{
			return 32;
		}
		int num = 0;
		if ((uint_0 & 0xFFFF0000u) == 0)
		{
			num += 16;
			uint_0 <<= 16;
		}
		if ((uint_0 & 0xFF000000u) == 0)
		{
			num += 8;
			uint_0 <<= 8;
		}
		if ((uint_0 & 0xF0000000u) == 0)
		{
			num += 4;
			uint_0 <<= 4;
		}
		if ((uint_0 & 0xC0000000u) == 0)
		{
			num += 2;
			uint_0 <<= 2;
		}
		if ((uint_0 & 0x80000000u) == 0)
		{
			num++;
		}
		return num;
	}

	internal static ulong FC225B10(uint uint_0, uint uint_1)
	{
		return ((ulong)uint_0 << 32) | uint_1;
	}

	internal static uint FF10AB32(ulong B5B5D116)
	{
		return (uint)(B5B5D116 >> 32);
	}

	internal static int EFBB9637(int int_0, int int_1)
	{
		return (int)smethod_1((uint)int_0, (uint)int_1);
	}

	internal static void smethod_0<T>(ref T E7085318, ref T E73EAEBD)
	{
		T val = E7085318;
		E7085318 = E73EAEBD;
		E73EAEBD = val;
	}

	private static uint smethod_1(uint E0A9479B, uint uint_0)
	{
		return ((E0A9479B << 7) | (E0A9479B >> 25)) ^ uint_0;
	}

	private static uint[] smethod_2(uint[] F3B2FE91, int int_0)
	{
		if (F3B2FE91.Length == int_0)
		{
			return F3B2FE91;
		}
		uint[] array = new uint[int_0];
		int num = Math.Min(F3B2FE91.Length, int_0);
		for (int i = 0; i < num; i++)
		{
			array[i] = F3B2FE91[i];
		}
		return array;
	}

	internal static uint smethod_3(ulong CB18D797)
	{
		return (uint)CB18D797;
	}

	internal static void smethod_4(uint[] uint_0)
	{
		for (int i = 0; i < uint_0.Length; i++)
		{
			uint_0[i] = 0u;
		}
		uint_0 = smethod_2(uint_0, uint_0.Length + 1);
		uint_0[uint_0.Length - 1] = 1u;
	}
}
