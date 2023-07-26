using System;
using System.Runtime.CompilerServices;

[Serializable]
internal struct Struct14
{
	private readonly int int_0;

	private readonly uint[] uint_0;

	private static readonly Struct14 struct14_0 = new Struct14(-1, new uint[1] { 2147483648u });

	private static readonly Struct14 struct14_1 = new Struct14(1);

	private static readonly Struct14 struct14_2 = new Struct14(0);

	private static readonly Struct14 EA1AB18C = new Struct14(-1);

	internal int Int32_0 => int_0;

	private int Int32_1 => (int_0 >> 31) - (-int_0 >> 31);

	private bool BB8DC802
	{
		get
		{
			if (uint_0 != null)
			{
				return (uint_0[0] & 1) == 0;
			}
			return (int_0 & 1) == 0;
		}
	}

	internal uint[] UInt32_0 => uint_0;

	private static Struct14 Struct14_0 => struct14_1;

	[SpecialName]
	public static bool B1B56ABC(Struct14 struct14_3, Struct14 struct14_4)
	{
		return struct14_3.method_0(struct14_4) <= 0;
	}

	[SpecialName]
	public static bool F290E991(Struct14 struct14_3, Struct14 struct14_4)
	{
		return !struct14_3.Equals(struct14_4);
	}

	internal Struct14(byte[] D7146313)
	{
		if (D7146313 == null)
		{
			throw new ArgumentNullException("value");
		}
		int num = D7146313.Length;
		bool flag = num > 0 && (D7146313[num - 1] & 0x80) == 128;
		while (num > 0 && D7146313[num - 1] == 0)
		{
			num--;
		}
		if (num == 0)
		{
			int_0 = 0;
			uint_0 = null;
			return;
		}
		if (num <= 4)
		{
			if (flag)
			{
				int_0 = -1;
			}
			else
			{
				int_0 = 0;
			}
			for (int num2 = num - 1; num2 >= 0; num2--)
			{
				int_0 <<= 8;
				int_0 |= D7146313[num2];
			}
			uint_0 = null;
			if (int_0 < 0 && !flag)
			{
				uint_0 = new uint[1];
				uint_0[0] = (uint)int_0;
				int_0 = 1;
			}
			if (int_0 == int.MinValue)
			{
				this = struct14_0;
			}
			return;
		}
		int num3 = num % 4;
		int num4 = num / 4 + ((num3 != 0) ? 1 : 0);
		bool flag2 = true;
		uint[] array = new uint[num4];
		int num5 = 3;
		int i;
		for (i = 0; i < num4 - ((num3 != 0) ? 1 : 0); i++)
		{
			for (int j = 0; j < 4; j++)
			{
				if (D7146313[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= D7146313[num5];
				num5--;
			}
			num5 += 8;
		}
		if (num3 != 0)
		{
			if (flag)
			{
				array[num4 - 1] = uint.MaxValue;
			}
			for (num5 = num - 1; num5 >= num - num3; num5--)
			{
				if (D7146313[num5] != 0)
				{
					flag2 = false;
				}
				array[i] <<= 8;
				array[i] |= D7146313[num5];
			}
		}
		if (flag2)
		{
			this = struct14_2;
		}
		else if (flag)
		{
			Class45.smethod_4(array);
			int num6 = array.Length;
			while (num6 > 0 && array[num6 - 1] == 0)
			{
				num6--;
			}
			if (num6 == 1 && (int)array[0] > 0)
			{
				if (array[0] == 1)
				{
					this = EA1AB18C;
					return;
				}
				if (array[0] == 2147483648u)
				{
					this = struct14_0;
					return;
				}
				int_0 = -1 * (int)array[0];
				uint_0 = null;
			}
			else if (num6 != array.Length)
			{
				int_0 = -1;
				uint_0 = new uint[num6];
				Array.Copy(array, uint_0, num6);
			}
			else
			{
				int_0 = -1;
				uint_0 = array;
			}
		}
		else
		{
			int_0 = 1;
			uint_0 = array;
		}
	}

	public override bool Equals(object obj)
	{
		if (!(obj is Struct14))
		{
			return false;
		}
		return Equals((Struct14)obj);
	}

	internal static Struct14 F5BB97AA(Struct14 struct14_3, Struct14 struct14_4, Struct14 DC1C779F)
	{
		if (struct14_4.Int32_1 < 0)
		{
			throw new ArgumentOutOfRangeException("exponent", "ArgumentOutOfRange must be non negative");
		}
		int int_ = 1;
		int int_2 = 1;
		int int_3 = 1;
		bool bB8DC = struct14_4.BB8DC802;
		CD1D001C cd1D001C_ = new CD1D001C(Struct14_0, ref int_);
		CD1D001C EF86079A = new CD1D001C(struct14_3, ref int_2);
		CD1D001C cd1D001C_2 = new CD1D001C(DC1C779F, ref int_3);
		CD1D001C ED3AEA9E = new CD1D001C(EF86079A.CDA4FB0B);
		cd1D001C_.method_6(ref cd1D001C_2);
		if (struct14_4.uint_0 == null)
		{
			E413E323((uint)struct14_4.int_0, ref cd1D001C_, ref EF86079A, ref cd1D001C_2, ref ED3AEA9E);
		}
		else
		{
			int num = smethod_7(struct14_4.uint_0);
			for (int i = 0; i < num - 1; i++)
			{
				smethod_0(struct14_4.uint_0[i], ref cd1D001C_, ref EF86079A, ref cd1D001C_2, ref ED3AEA9E);
			}
			E413E323(struct14_4.uint_0[num - 1], ref cd1D001C_, ref EF86079A, ref cd1D001C_2, ref ED3AEA9E);
		}
		return cd1D001C_.method_0((struct14_3.int_0 > 0) ? 1 : (bB8DC ? 1 : (-1)));
	}

	private int method_0(Struct14 B3A667BC)
	{
		if ((int_0 ^ B3A667BC.int_0) < 0)
		{
			if (int_0 >= 0)
			{
				return 1;
			}
			return -1;
		}
		if (uint_0 == null)
		{
			if (B3A667BC.uint_0 == null)
			{
				if (int_0 >= B3A667BC.int_0)
				{
					if (int_0 <= B3A667BC.int_0)
					{
						return 0;
					}
					return 1;
				}
				return -1;
			}
			return -B3A667BC.int_0;
		}
		int num;
		int num2;
		if (B3A667BC.uint_0 != null && (num = smethod_7(uint_0)) <= (num2 = smethod_7(B3A667BC.uint_0)))
		{
			if (num < num2)
			{
				return -int_0;
			}
			int num3 = smethod_4(uint_0, B3A667BC.uint_0, num);
			if (num3 == 0)
			{
				return 0;
			}
			if (uint_0[num3 - 1] >= B3A667BC.uint_0[num3 - 1])
			{
				return int_0;
			}
			return -int_0;
		}
		return int_0;
	}

	private static void B4AE5812(ref CD1D001C C387B9B9, ref CD1D001C E513C918, ref CD1D001C cd1D001C_0, ref CD1D001C BBAC55AC)
	{
		Class45.smethod_0(ref C387B9B9, ref BBAC55AC);
		C387B9B9.F10025A7(ref BBAC55AC, ref E513C918);
		C387B9B9.method_6(ref cd1D001C_0);
	}

	private static void E413E323(uint uint_1, ref CD1D001C cd1D001C_0, ref CD1D001C EF86079A, ref CD1D001C cd1D001C_1, ref CD1D001C ED3AEA9E)
	{
		while (uint_1 != 0)
		{
			if ((uint_1 & 1) == 1)
			{
				B4AE5812(ref cd1D001C_0, ref EF86079A, ref cd1D001C_1, ref ED3AEA9E);
			}
			if (uint_1 != 1)
			{
				smethod_5(ref EF86079A, ref cd1D001C_1, ref ED3AEA9E);
				uint_1 >>= 1;
				continue;
			}
			break;
		}
	}

	private static void smethod_0(uint uint_1, ref CD1D001C C7831527, ref CD1D001C cd1D001C_0, ref CD1D001C cd1D001C_1, ref CD1D001C cd1D001C_2)
	{
		for (int i = 0; i < 32; i++)
		{
			if ((uint_1 & 1) == 1)
			{
				B4AE5812(ref C7831527, ref cd1D001C_0, ref cd1D001C_1, ref cd1D001C_2);
			}
			smethod_5(ref cd1D001C_0, ref cd1D001C_1, ref cd1D001C_2);
			uint_1 >>= 1;
		}
	}

	internal Struct14(int int_1, uint[] uint_1)
	{
		int_0 = int_1;
		uint_0 = uint_1;
	}

	[SpecialName]
	public static bool smethod_1(Struct14 A289A51E, Struct14 struct14_3)
	{
		return A289A51E.Equals(struct14_3);
	}

	[SpecialName]
	public static bool smethod_2(Struct14 struct14_3, Struct14 D5BBA484)
	{
		return struct14_3.method_0(D5BBA484) < 0;
	}

	public override int GetHashCode()
	{
		if (uint_0 == null)
		{
			return int_0;
		}
		int result = int_0;
		int num = smethod_7(uint_0);
		while (--num >= 0)
		{
			result = Class45.EFBB9637(result, (int)uint_0[num]);
		}
		return result;
	}

	[SpecialName]
	public static bool smethod_3(Struct14 FF81071C, Struct14 struct14_3)
	{
		return FF81071C.method_0(struct14_3) >= 0;
	}

	private static int smethod_4(uint[] uint_1, uint[] uint_2, int B3ACF9AF)
	{
		int num = B3ACF9AF;
		do
		{
			if (--num < 0)
			{
				return 0;
			}
		}
		while (uint_1[num] == uint_2[num]);
		return num + 1;
	}

	private static void smethod_5(ref CD1D001C cd1D001C_0, ref CD1D001C cd1D001C_1, ref CD1D001C cd1D001C_2)
	{
		Class45.smethod_0(ref cd1D001C_0, ref cd1D001C_2);
		cd1D001C_0.F10025A7(ref cd1D001C_2, ref cd1D001C_2);
		cd1D001C_0.method_6(ref cd1D001C_1);
	}

	[SpecialName]
	public static bool smethod_6(Struct14 struct14_3, Struct14 struct14_4)
	{
		return struct14_3.method_0(struct14_4) > 0;
	}

	private Struct14(int E7951DB0)
	{
		if (E7951DB0 == int.MinValue)
		{
			this = struct14_0;
			return;
		}
		int_0 = E7951DB0;
		uint_0 = null;
	}

	internal byte[] method_1()
	{
		if (uint_0 == null && int_0 == 0)
		{
			return new byte[1];
		}
		uint[] array;
		byte b;
		if (uint_0 == null)
		{
			array = new uint[1] { (uint)int_0 };
			b = (byte)((int_0 < 0) ? 255u : 0u);
		}
		else if (int_0 == -1)
		{
			array = (uint[])uint_0.Clone();
			Class45.smethod_4(array);
			b = byte.MaxValue;
		}
		else
		{
			array = uint_0;
			b = 0;
		}
		byte[] array2 = new byte[checked(4 * array.Length)];
		int num = 0;
		uint[] array3 = array;
		for (int i = 0; i < array3.Length; i++)
		{
			uint num2 = array3[i];
			for (int j = 0; j < 4; j++)
			{
				array2[num++] = (byte)(num2 & 0xFFu);
				num2 >>= 8;
			}
		}
		if ((array2[array2.Length - 1] & 0x80) == (b & 0x80))
		{
			return array2;
		}
		byte[] array4 = new byte[array2.Length + 1];
		Array.Copy(array2, array4, array2.Length);
		array4[array4.Length - 1] = b;
		return array4;
	}

	private static int smethod_7(uint[] DE944F19)
	{
		int num = DE944F19.Length;
		if (DE944F19[num - 1] != 0)
		{
			return num;
		}
		return num - 1;
	}

	private void method_2()
	{
		if (uint_0 != null)
		{
			smethod_7(uint_0);
		}
	}
}
