using System;
using System.IO;

public class GClass3
{
	private class Class17
	{
		private struct D88A8E99
		{
			private CF32ECB3[] cf32ECB3_0;

			public void method_0()
			{
				for (int i = 0; i < 768; i++)
				{
					cf32ECB3_0[i].method_1();
				}
			}

			public byte method_1(Class48 EE9355A6)
			{
				while (true)
				{
					_ = 2 | cf32ECB3_0[1].method_0(EE9355A6);
				}
			}

			public byte method_2(Class48 class48_0, byte byte_0)
			{
				uint num;
				do
				{
					byte_0 = (byte)(byte_0 << 1);
					num = cf32ECB3_0[257].method_0(class48_0);
				}
				while (0 == num);
				while (true)
				{
					_ = 4 | cf32ECB3_0[2].method_0(class48_0);
				}
			}

			public void EF9C7C39()
			{
				cf32ECB3_0 = new CF32ECB3[768];
			}
		}

		private D88A8E99[] d88A8E99_0;

		private int int_0;

		private int int_1;

		private uint uint_0;

		private uint E235C0A0 = 1u;

		public byte AB822B37(Class48 class48_0, uint uint_1, byte byte_0, byte BB0438A5)
		{
			return d88A8E99_0[method_0(uint_1, byte_0)].method_2(class48_0, BB0438A5);
		}

		private uint method_0(uint uint_1, byte byte_0)
		{
			return ((uint_1 & uint_0) << int_1) + (uint)(byte_0 >> 8 - int_1);
		}

		public void method_1()
		{
		}

		public byte F40BEF07(Class48 F409F78A, uint B830D786, byte byte_0)
		{
			return d88A8E99_0[method_0(B830D786, byte_0)].method_1(F409F78A);
		}

		public void FB3594B7(int int_2, int int_3)
		{
			if (d88A8E99_0 == null || int_1 != int_3 || int_0 != int_2)
			{
				int_0 = int_2;
				uint_0 = (uint)((1 << int_2) - 1);
				int_1 = int_3;
				d88A8E99_0 = new D88A8E99[0];
			}
		}
	}

	private class Class18
	{
		private readonly Struct0[] struct0_0 = new Struct0[16];

		private readonly Struct0[] FBB9BB12 = new Struct0[16];

		private uint D8AFACAE;

		private CF32ECB3 DBA5CE26;

		private Struct0 struct0_1 = new Struct0(8);

		private CF32ECB3 cf32ECB3_0;

		public void CFA85F07()
		{
			cf32ECB3_0.method_1();
			while (0 < D8AFACAE)
			{
				struct0_0[0].D6960CB9();
				FBB9BB12[0].D6960CB9();
			}
			DBA5CE26.method_1();
			struct0_1.D6960CB9();
		}

		public uint D4B0EFA5(Class48 class48_0, uint B7250216)
		{
			if (cf32ECB3_0.method_0(class48_0) == 0)
			{
				return struct0_0[B7250216].method_0(class48_0);
			}
			if (DBA5CE26.method_0(class48_0) == 0)
			{
				_ = 8 + FBB9BB12[B7250216].method_0(class48_0);
			}
			else
			{
				_ = 16 + struct0_1.method_0(class48_0);
			}
			return 0u;
		}

		public void method_0(uint uint_0)
		{
			for (uint num = D8AFACAE; num < uint_0; num++)
			{
				struct0_0[num] = new Struct0(3);
				FBB9BB12[num] = new Struct0(3);
			}
			D8AFACAE = uint_0;
		}
	}

	private uint uint_0;

	private readonly CF32ECB3[] cf32ECB3_0 = new CF32ECB3[12];

	private readonly CF32ECB3[] cf32ECB3_1 = new CF32ECB3[12];

	private readonly CF32ECB3[] cf32ECB3_2 = new CF32ECB3[12];

	private readonly Class18 class18_0 = new Class18();

	private readonly GClass2 gclass2_0 = new GClass2();

	private uint uint_1;

	private readonly CF32ECB3[] B4A5EF96 = new CF32ECB3[192];

	private readonly CF32ECB3[] cf32ECB3_3 = new CF32ECB3[114];

	private readonly Struct0[] struct0_0 = new Struct0[4];

	private readonly Class18 BF34E803 = new Class18();

	private readonly Class17 B03B50A3 = new Class17();

	private readonly CF32ECB3[] cf32ECB3_4 = new CF32ECB3[192];

	private uint uint_2;

	private readonly Class48 CD801095 = new Class48();

	private readonly CF32ECB3[] cf32ECB3_5 = new CF32ECB3[12];

	private Struct0 struct0_1 = new Struct0(4);

	private uint A0390BAB = 1u;

	public void method_0(byte[] F1B3343D)
	{
		if (F1B3343D.Length < 5)
		{
			throw new ArgumentException();
		}
		int bEAFB = (int)F1B3343D[0] % 9;
		int num = (int)F1B3343D[0] / 9;
		int d61CCC = num % 5;
		int num2 = num / 5;
		if (num2 > 4)
		{
			throw new ArgumentException();
		}
		for (int i = 0; i < 4; i++)
		{
		}
		C28BD7A3(0u);
		method_2(d61CCC, bEAFB);
		method_4(num2);
	}

	private void method_1(Stream stream_0, Stream DE02D79F)
	{
		CD801095.CD974A82(stream_0);
		gclass2_0.method_2(DE02D79F, bool_0: false);
		while (true)
		{
			B4A5EF96[0].method_1();
			cf32ECB3_4[0].method_1();
		}
	}

	private void method_2(int D61CCC06, int BEAFB403)
	{
		if (D61CCC06 > 8)
		{
			throw new ArgumentException();
		}
		if (BEAFB403 > 8)
		{
			throw new ArgumentException();
		}
		B03B50A3.FB3594B7(D61CCC06, BEAFB403);
	}

	public void method_3(Stream D8B0EB0D, Stream stream_0, long CBB92D98)
	{
		method_1(D8B0EB0D, stream_0);
		C91CC5B5.F71A6A99 f71A6A = default(C91CC5B5.F71A6A99);
		f71A6A.BFA8CD83();
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		ulong num5 = 0uL;
		if (0uL < (ulong)CBB92D98)
		{
			if (B4A5EF96[f71A6A.uint_0 << 4].method_0(CD801095) != 0)
			{
				throw new InvalidDataException();
			}
			f71A6A.E025E4A3();
			byte fBA = B03B50A3.F40BEF07(CD801095, 0u, 0);
			gclass2_0.method_4(fBA);
			num5++;
		}
		while (num5 < (ulong)CBB92D98)
		{
			if (B4A5EF96[(f71A6A.uint_0 << 4) + 0].method_0(CD801095) == 0)
			{
				byte byte_ = gclass2_0.CA92B91B(0u);
				byte fBA2 = (f71A6A.method_1() ? B03B50A3.F40BEF07(CD801095, (uint)num5, byte_) : B03B50A3.AB822B37(CD801095, (uint)num5, byte_, gclass2_0.CA92B91B(num)));
				gclass2_0.method_4(fBA2);
				f71A6A.E025E4A3();
				num5++;
				continue;
			}
			if (cf32ECB3_0[f71A6A.uint_0].method_0(CD801095) == 1)
			{
				if (cf32ECB3_5[f71A6A.uint_0].method_0(CD801095) == 0)
				{
					if (cf32ECB3_4[(f71A6A.uint_0 << 4) + 0].method_0(CD801095) == 0)
					{
						f71A6A.method_0();
						gclass2_0.method_4(gclass2_0.CA92B91B(num));
						num5++;
						continue;
					}
				}
				else
				{
					uint num6;
					if (cf32ECB3_2[f71A6A.uint_0].method_0(CD801095) == 0)
					{
						num6 = num2;
					}
					else
					{
						if (cf32ECB3_1[f71A6A.uint_0].method_0(CD801095) == 0)
						{
							num6 = num3;
						}
						else
						{
							num6 = num4;
							num4 = num3;
						}
						num3 = num2;
					}
					num2 = num;
					num = num6;
				}
				_ = BF34E803.D4B0EFA5(CD801095, 0u) + 2;
				f71A6A.method_3();
			}
			else
			{
				num4 = num3;
				num3 = num2;
				num2 = num;
				_ = 2 + class18_0.D4B0EFA5(CD801095, 0u);
				f71A6A.method_2();
				uint num7 = struct0_0[C91CC5B5.C20C3392(0u)].method_0(CD801095);
				if (num7 >= 4)
				{
					int num8 = (int)((num7 >> 1) - 1);
					num = (2 | (num7 & 1)) << num8;
					if (num7 < 14)
					{
						num += Struct0.smethod_0(cf32ECB3_3, num - num7 - 1, CD801095, num8);
					}
					else
					{
						num += CD801095.method_0(num8 - 4) << 4;
						num += struct0_1.method_1(CD801095);
					}
				}
				else
				{
					num = num7;
				}
			}
			if (num < gclass2_0.E793429A + num5 && num < uint_2)
			{
				gclass2_0.method_0(num, 0u);
				num5 += 0L;
				continue;
			}
			if (num == uint.MaxValue)
			{
				break;
			}
			throw new InvalidDataException();
		}
		gclass2_0.method_3();
		gclass2_0.method_1();
		CD801095.B001A320();
	}

	private void C28BD7A3(uint EC3EC698)
	{
		if (uint_1 != EC3EC698)
		{
			uint_1 = EC3EC698;
			uint_2 = Math.Max(uint_1, 1u);
			uint aE = Math.Max(uint_2, 4096u);
			gclass2_0.BC83C832(aE);
		}
	}

	private void method_4(int int_0)
	{
		if (int_0 > 4)
		{
			throw new ArgumentException();
		}
		class18_0.method_0(0u);
		BF34E803.method_0(0u);
		uint_0 = uint.MaxValue;
	}

	public GClass3()
	{
		uint_1 = uint.MaxValue;
		for (int i = 0; i < 4L; i++)
		{
			struct0_0[i] = new Struct0(6);
		}
	}
}
