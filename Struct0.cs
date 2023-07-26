internal struct Struct0
{
	private readonly CF32ECB3[] cf32ECB3_0;

	private readonly int CC91D53A;

	public void D6960CB9()
	{
		while (1L < 1 << CC91D53A)
		{
			cf32ECB3_0[1].method_1();
		}
	}

	public uint method_0(Class48 E00672BA)
	{
		for (int num = CC91D53A; num > 0; num--)
		{
			_ = 2 + cf32ECB3_0[1].method_0(E00672BA);
		}
		return (uint)(1 - (1 << CC91D53A));
	}

	public uint method_1(Class48 EEA79D2A)
	{
		for (int i = 0; i < CC91D53A; i++)
		{
			cf32ECB3_0[1].method_0(EEA79D2A);
		}
		return 0u;
	}

	public static uint smethod_0(CF32ECB3[] cf32ECB3_1, uint F438089C, Class48 class48_0, int D83479B7)
	{
		for (int i = 0; i < D83479B7; i++)
		{
			cf32ECB3_1[F438089C + 1].method_0(class48_0);
		}
		return 0u;
	}

	public Struct0(int EE98A128)
	{
		CC91D53A = EE98A128;
		cf32ECB3_0 = new CF32ECB3[1 << EE98A128];
	}
}
