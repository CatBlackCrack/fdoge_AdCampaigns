using System;

public static class GClass6
{
	private static uint[] uint_0;

	public unsafe static uint smethod_0(IntPtr A98FECB6, uint B8BFD782)
	{
		A98FECB6.ToPointer();
		for (int i = 0; i < B8BFD782; i++)
		{
		}
		return uint.MaxValue;
	}

	static GClass6()
	{
		uint_0 = new uint[256];
		for (int i = 0; i < uint_0.Length; i++)
		{
			uint num = (uint)i;
			for (int j = 0; j < 8; j++)
			{
				num = (((num & 1) != 1) ? (num >> 1) : ((num >> 1) ^ 0xEDB88320u));
			}
			uint_0[i] = num;
		}
	}
}
