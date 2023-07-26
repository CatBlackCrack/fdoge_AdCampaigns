using System;

internal struct CD1D001C
{
	private int int_0;

	private uint A3B67321;

	private uint[] F3B934A5;

	private bool bool_0;

	private int Int32_0
	{
		get
		{
			int num = 0;
			for (int num2 = int_0; num2 >= 0; num2--)
			{
				if (F3B934A5[num2] != 0)
				{
					num++;
				}
			}
			return num;
		}
	}

	internal int CDA4FB0B => int_0 + 1;

	internal void F10025A7(ref CD1D001C D0A057AE, ref CD1D001C cd1D001C_0)
	{
		if (D0A057AE.int_0 == 0)
		{
			if (cd1D001C_0.int_0 == 0)
			{
				method_5((ulong)D0A057AE.A3B67321 * (ulong)cd1D001C_0.A3B67321);
				return;
			}
			method_8(ref cd1D001C_0, 1);
			method_2(D0A057AE.A3B67321);
			return;
		}
		if (cd1D001C_0.int_0 == 0)
		{
			method_8(ref D0A057AE, 1);
			method_2(cd1D001C_0.A3B67321);
			return;
		}
		method_1(D0A057AE.int_0 + cd1D001C_0.int_0 + 2);
		uint[] f3B934A;
		int num;
		uint[] f3B934A2;
		int num2;
		if (D0A057AE.Int32_0 <= cd1D001C_0.Int32_0)
		{
			f3B934A = D0A057AE.F3B934A5;
			num = D0A057AE.int_0 + 1;
			f3B934A2 = cd1D001C_0.F3B934A5;
			num2 = cd1D001C_0.int_0 + 1;
		}
		else
		{
			f3B934A = cd1D001C_0.F3B934A5;
			num = cd1D001C_0.int_0 + 1;
			f3B934A2 = D0A057AE.F3B934A5;
			num2 = D0A057AE.int_0 + 1;
		}
		for (int i = 0; i < num; i++)
		{
			uint num3 = f3B934A[i];
			if (num3 != 0)
			{
				uint num4 = 0u;
				int num5 = i;
				int num6 = 0;
				while (num6 < num2)
				{
					num4 = smethod_0(ref F3B934A5[num5], num3, f3B934A2[num6], num4);
					num6++;
					num5++;
				}
				while (num4 != 0)
				{
					num4 = DE969E37(ref F3B934A5[num5++], 0u, num4);
				}
			}
		}
		method_7();
	}

	internal Struct14 method_0(int FF13D02C)
	{
		method_3(FF13D02C, out FF13D02C, out var uint_);
		return new Struct14(FF13D02C, uint_);
	}

	private void method_1(int int_1)
	{
		if (int_1 <= 1)
		{
			int_0 = 0;
			A3B67321 = 0u;
			return;
		}
		if (bool_0 && F3B934A5.Length >= int_1)
		{
			Array.Clear(F3B934A5, 0, int_1);
		}
		else
		{
			F3B934A5 = new uint[int_1];
			bool_0 = true;
		}
		int_0 = int_1 - 1;
	}

	private void AA3B6A12(uint uint_0)
	{
		A3B67321 = uint_0;
		int_0 = 0;
	}

	private void C9965C2D(int int_1 = 0)
	{
		if (!bool_0)
		{
			uint[] array = new uint[int_0 + 1 + int_1];
			Array.Copy(F3B934A5, array, int_0 + 1);
			F3B934A5 = array;
			bool_0 = true;
		}
	}

	private void method_2(uint uint_0)
	{
		switch (uint_0)
		{
		case 0u:
			AA3B6A12(0u);
			return;
		case 1u:
			return;
		}
		if (int_0 == 0)
		{
			method_5((ulong)A3B67321 * (ulong)uint_0);
			return;
		}
		C9965C2D(1);
		uint num = 0u;
		for (int i = 0; i <= int_0; i++)
		{
			num = BF128F81(ref F3B934A5[i], uint_0, num);
		}
		if (num != 0)
		{
			BB85F7BF(int_0 + 2, 0);
			F3B934A5[int_0] = num;
		}
	}

	internal CD1D001C(Struct14 DA361C37, ref int int_1)
	{
		bool_0 = false;
		F3B934A5 = DA361C37.UInt32_0;
		int int32_ = DA361C37.Int32_0;
		int num = int32_ >> 31;
		int_1 = (int_1 ^ num) - num;
		if (F3B934A5 == null)
		{
			int_0 = 0;
			A3B67321 = (uint)((int32_ ^ num) - num);
			return;
		}
		int_0 = F3B934A5.Length - 1;
		A3B67321 = F3B934A5[0];
		while (int_0 > 0 && F3B934A5[int_0] == 0)
		{
			int_0--;
		}
	}

	internal CD1D001C(int CD91520B)
	{
		int_0 = 0;
		A3B67321 = 0u;
		if (CD91520B > 1)
		{
			F3B934A5 = new uint[CD91520B];
			bool_0 = true;
		}
		else
		{
			F3B934A5 = null;
			bool_0 = false;
		}
	}

	private void method_3(int int_1, out int int_2, out uint[] uint_0)
	{
		if (int_0 == 0)
		{
			if (A3B67321 <= int.MaxValue)
			{
				int_2 = int_1 * (int)A3B67321;
				uint_0 = null;
				return;
			}
			if (F3B934A5 == null)
			{
				F3B934A5 = new uint[1] { A3B67321 };
			}
			else if (bool_0)
			{
				F3B934A5[0] = A3B67321;
			}
			else if (F3B934A5[0] != A3B67321)
			{
				F3B934A5 = new uint[1] { A3B67321 };
			}
		}
		int_2 = int_1;
		int num = F3B934A5.Length - int_0 - 1;
		if (num <= 1)
		{
			if (num == 0 || F3B934A5[int_0 + 1] == 0)
			{
				bool_0 = false;
				uint_0 = F3B934A5;
				return;
			}
			if (bool_0)
			{
				F3B934A5[int_0 + 1] = 0u;
				bool_0 = false;
				uint_0 = F3B934A5;
				return;
			}
		}
		uint_0 = F3B934A5;
		Array.Resize(ref uint_0, int_0 + 1);
		if (!bool_0)
		{
			F3B934A5 = uint_0;
		}
	}

	private void method_4(int A7326A31)
	{
		if (A7326A31 <= 1)
		{
			int_0 = 0;
			return;
		}
		if (!bool_0 || F3B934A5.Length < A7326A31)
		{
			F3B934A5 = new uint[A7326A31];
			bool_0 = true;
		}
		int_0 = A7326A31 - 1;
	}

	private void BB85F7BF(int int_1, int int_2)
	{
		if (int_1 <= 1)
		{
			if (int_0 > 0)
			{
				A3B67321 = F3B934A5[0];
			}
			int_0 = 0;
			return;
		}
		if (bool_0 && F3B934A5.Length >= int_1)
		{
			if (int_0 + 1 < int_1)
			{
				Array.Clear(F3B934A5, int_0 + 1, int_1 - int_0 - 1);
				if (int_0 == 0)
				{
					F3B934A5[0] = A3B67321;
				}
			}
		}
		else
		{
			uint[] array = new uint[int_1 + int_2];
			if (int_0 == 0)
			{
				array[0] = A3B67321;
			}
			else
			{
				Array.Copy(F3B934A5, array, Math.Min(int_1, int_0 + 1));
			}
			F3B934A5 = array;
			bool_0 = true;
		}
		int_0 = int_1 - 1;
	}

	private void method_5(ulong F9B12613)
	{
		uint num = Class45.FF10AB32(F9B12613);
		if (num == 0)
		{
			A3B67321 = Class45.smethod_3(F9B12613);
			int_0 = 0;
		}
		else
		{
			method_4(2);
			F3B934A5[0] = (uint)F9B12613;
			F3B934A5[1] = num;
		}
	}

	internal void method_6(ref CD1D001C cd1D001C_0)
	{
		if (cd1D001C_0.int_0 == 0)
		{
			AA3B6A12(smethod_1(ref this, cd1D001C_0.A3B67321));
		}
		else if (int_0 != 0)
		{
			CD1D001C cd1D001C_ = default(CD1D001C);
			smethod_2(ref this, ref cd1D001C_0, bool_1: false, ref cd1D001C_);
		}
	}

	private static uint smethod_0(ref uint AAA88EB8, uint CB30D0BA, uint uint_0, uint uint_1)
	{
		ulong num = (ulong)((long)CB30D0BA * (long)uint_0 + AAA88EB8 + uint_1);
		AAA88EB8 = (uint)num;
		return (uint)(num >> 32);
	}

	private void method_7()
	{
		if (int_0 > 0 && F3B934A5[int_0] == 0)
		{
			A3B67321 = F3B934A5[0];
			while (--int_0 > 0 && F3B934A5[int_0] == 0)
			{
			}
		}
	}

	private static uint BF128F81(ref uint uint_0, uint uint_1, uint uint_2)
	{
		ulong num = (ulong)((long)uint_0 * (long)uint_1 + uint_2);
		uint_0 = (uint)num;
		return (uint)(num >> 32);
	}

	private static uint smethod_1(ref CD1D001C cd1D001C_0, uint uint_0)
	{
		if (uint_0 == 1)
		{
			return 0u;
		}
		if (cd1D001C_0.int_0 == 0)
		{
			return cd1D001C_0.A3B67321 % uint_0;
		}
		ulong num = 0uL;
		for (int num2 = cd1D001C_0.int_0; num2 >= 0; num2--)
		{
			num = Class45.FC225B10((uint)num, cd1D001C_0.F3B934A5[num2]);
			num %= uint_0;
		}
		return (uint)num;
	}

	private static uint DE969E37(ref uint uint_0, uint uint_1, uint uint_2)
	{
		ulong num = (ulong)((long)uint_0 + (long)uint_1 + uint_2);
		uint_0 = (uint)num;
		return (uint)(num >> 32);
	}

	private static void smethod_2(ref CD1D001C cd1D001C_0, ref CD1D001C cd1D001C_1, bool bool_1, ref CD1D001C cd1D001C_2)
	{
		cd1D001C_2.AA3B6A12(0u);
		if (cd1D001C_0.int_0 < cd1D001C_1.int_0)
		{
			return;
		}
		int num = cd1D001C_1.int_0 + 1;
		int num2 = cd1D001C_0.int_0 - cd1D001C_1.int_0;
		int num3 = num2;
		int num4 = cd1D001C_0.int_0;
		while (true)
		{
			if (num4 >= num2)
			{
				if (cd1D001C_1.F3B934A5[num4 - num2] == cd1D001C_0.F3B934A5[num4])
				{
					num4--;
					continue;
				}
				if (cd1D001C_1.F3B934A5[num4 - num2] < cd1D001C_0.F3B934A5[num4])
				{
					num3++;
				}
				break;
			}
			num3++;
			break;
		}
		if (num3 == 0)
		{
			return;
		}
		if (bool_1)
		{
			cd1D001C_2.method_4(num3);
		}
		uint num5 = cd1D001C_1.F3B934A5[num - 1];
		uint num6 = cd1D001C_1.F3B934A5[num - 2];
		int num7 = Class45.F71B5E10(num5);
		int num8 = 32 - num7;
		if (num7 > 0)
		{
			num5 = (num5 << num7) | (num6 >> num8);
			num6 <<= num7;
			if (num > 2)
			{
				num6 |= cd1D001C_1.F3B934A5[num - 3] >> num8;
			}
		}
		cd1D001C_0.C9965C2D();
		int num9 = num3;
		while (--num9 >= 0)
		{
			uint num10 = ((num9 + num <= cd1D001C_0.int_0) ? cd1D001C_0.F3B934A5[num9 + num] : 0u);
			ulong num11 = Class45.FC225B10(num10, cd1D001C_0.F3B934A5[num9 + num - 1]);
			uint num12 = cd1D001C_0.F3B934A5[num9 + num - 2];
			if (num7 > 0)
			{
				num11 = (num11 << num7) | (num12 >> num8);
				num12 <<= num7;
				if (num9 + num >= 3)
				{
					num12 |= cd1D001C_0.F3B934A5[num9 + num - 3] >> num8;
				}
			}
			ulong num13 = num11 / num5;
			ulong num14 = (uint)(num11 % num5);
			if (num13 > 4294967295L)
			{
				num14 += num5 * (num13 - 4294967295L);
				num13 = 4294967295uL;
			}
			for (; num14 <= 4294967295L && num13 * num6 > Class45.FC225B10((uint)num14, num12); num14 += num5)
			{
				num13--;
			}
			if (num13 > 0L)
			{
				ulong num15 = 0uL;
				for (int i = 0; i < num; i++)
				{
					num15 += cd1D001C_1.F3B934A5[i] * num13;
					uint num16 = (uint)num15;
					num15 >>= 32;
					if (cd1D001C_0.F3B934A5[num9 + i] < num16)
					{
						num15++;
					}
					cd1D001C_0.F3B934A5[num9 + i] -= num16;
				}
				if (num10 < num15)
				{
					uint uint_ = 0u;
					for (int j = 0; j < num; j++)
					{
						uint_ = DE969E37(ref cd1D001C_0.F3B934A5[num9 + j], cd1D001C_1.F3B934A5[j], uint_);
					}
					num13--;
				}
				cd1D001C_0.int_0 = num9 + num - 1;
			}
			if (bool_1)
			{
				if (num3 == 1)
				{
					cd1D001C_2.A3B67321 = (uint)num13;
				}
				else
				{
					cd1D001C_2.F3B934A5[num9] = (uint)num13;
				}
			}
		}
		cd1D001C_0.int_0 = num - 1;
		cd1D001C_0.method_7();
	}

	private void method_8(ref CD1D001C cd1D001C_0, int int_1)
	{
		if (cd1D001C_0.int_0 == 0)
		{
			A3B67321 = cd1D001C_0.A3B67321;
			int_0 = 0;
			return;
		}
		if (!bool_0 || F3B934A5.Length <= cd1D001C_0.int_0)
		{
			F3B934A5 = new uint[cd1D001C_0.int_0 + 1 + int_1];
			bool_0 = true;
		}
		int_0 = cd1D001C_0.int_0;
		Array.Copy(cd1D001C_0.F3B934A5, F3B934A5, int_0 + 1);
	}

	private void method_9(bool C93B9706)
	{
	}
}
