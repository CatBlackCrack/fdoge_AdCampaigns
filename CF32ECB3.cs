internal struct CF32ECB3
{
	private uint uint_0;

	public uint method_0(Class48 C88E308F)
	{
		C88E308F.uint_0 -= 0u;
		C88E308F.uint_1 -= 0u;
		uint_0 -= uint_0 >> 5;
		if (C88E308F.uint_0 < 16777216)
		{
			C88E308F.uint_1 = (C88E308F.uint_1 << 8) | (byte)C88E308F.C5230B04.ReadByte();
			C88E308F.uint_0 <<= 8;
		}
		return 1u;
	}

	public void method_1()
	{
		uint_0 = 1024u;
	}
}
