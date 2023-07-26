using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal static class Class20
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint AE116C35(IntPtr intptr_0, Enum1 BD1205A3, IntPtr F3238607, uint uint_0, out uint B00B5A10);

	public struct C3AC4414
	{
		public uint uint_0;

		public uint D003C19A;
	}

	public enum F215C81C : uint
	{
		const_0 = 2u,
		B206DD27 = 4u,
		const_2 = 8u,
		const_3 = 1u
	}

	public struct Struct7
	{
		public uint uint_0;

		public uint uint_1;

		public uint DC1C8113;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public IntPtr D0B27D9B;

		public IntPtr F884C505;

		public IntPtr intptr_0;

		public IntPtr ABB7CCAE;

		public byte C88E4CA3;
	}

	public enum E83B2487 : uint
	{
		const_0 = 0x8000u
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate0(IntPtr intptr_0, IntPtr E4A9A234);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate1(IntPtr intptr_0, ref IntPtr E8863C09, ref UIntPtr uintptr_0, Enum2 enum2_0, out Enum2 C5830E83);

	public struct F20A9686
	{
		public Struct9 E6059403;

		public uint uint_0;

		public uint uint_1;

		public byte byte_0;

		public char char_0;
	}

	public struct Struct8
	{
		public uint B5268308;

		public uint uint_0;

		public byte EB9A160A;

		public byte DCA95997;

		public byte byte_0;

		public byte byte_1;

		public uint AD22E5BB;

		public uint C107C6B3;

		public uint uint_1;

		public uint E5B5BEB9;
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate2(IntPtr intptr_0, out C8BB1A85 c8BB1A85_0, IntPtr D905FF80, uint uint_0, uint DF069D2D);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate3(out IntPtr intptr_0, uint uint_0, ref Struct13 struct13_0, ref Struct9 A62F1907, Enum2 enum2_0, uint uint_1, IntPtr DA12D587);

	public struct Struct9
	{
		public uint uint_0;

		public uint uint_1;
	}

	public struct Struct10
	{
		public byte byte_0;

		public byte byte_1;
	}

	public enum DD0EFA2F : uint
	{
		const_0 = 8192u,
		B583B711 = 4096u
	}

	public struct E6206E39
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public IntPtr intptr_4;

		public IntPtr intptr_5;
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint B61E3CB3(uint uint_0, uint uint_1, uint B1B65785, IntPtr[] intptr_0, uint uint_2, out D72A2B9B d72A2B9B_0);

	public enum Enum0
	{
		const_0 = 17
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate4(out IntPtr intptr_0, uint B913161C, ref Struct13 struct13_0, out C8BB1A85 D51876B4, uint uint_0, uint uint_1);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate5(IntPtr intptr_0, Enum0 enum0_0, IntPtr intptr_1, uint uint_0);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate6(IntPtr EF2D3F88, ref IntPtr A8909F26, IntPtr A18537AF, ref UIntPtr B105D7AB, DD0EFA2F dd0EFA2F_0, Enum2 B4BCAD2D);

	public struct Struct11
	{
		public uint uint_0;

		public uint B90FD7AA;

		public uint CB9BCA8B;

		public uint uint_1;
	}

	public enum Enum1
	{
		const_0 = 30,
		B88738B4 = 0,
		E6013495 = 7
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate7(E19B5E1A e19B5E1A_0, IntPtr intptr_0, uint F3B76814, out uint uint_0);

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate8(IntPtr DF025436);

	public enum D72A2B9B
	{
		const_0 = 3,
		const_1 = 8,
		const_2 = 1,
		C32A3334 = 5,
		const_4 = 4,
		const_5 = 6,
		D02B2512 = 2,
		const_7 = 0,
		B401148D = 7
	}

	public struct Struct12
	{
		public readonly ushort FDB70F9E;

		public readonly ushort ushort_0;

		private readonly IntPtr AE8BC21C;

		public void method_0()
		{
			object[] array = new object[1] { this };
			try
			{
				new GClass8().method_31(array, 2686851);
			}
			finally
			{
				this = (Struct12)array[0];
			}
		} 
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint D0BF4925(IntPtr intptr_0, ref IntPtr intptr_1, ref UIntPtr F8302C1D, E83B2487 e83B2487_0);

	public enum Enum2 : uint
	{
		const_0 = 8u,
		CD85D819 = 2u,
		EB3C6C3C = 64u,
		const_3 = 1u,
		const_4 = 16u,
		E823A2A6 = 256u,
		const_6 = 4u,
		const_7 = 32u
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint Delegate9(IntPtr intptr_0, IntPtr intptr_1, out IntPtr intptr_2, UIntPtr uintptr_0, UIntPtr C4A9E20A, Struct9 A6193782, ref UIntPtr uintptr_1, uint A3847607, uint F09BBA32, Enum2 A20DD6AA);

	public struct C8953A21
	{
		public uint uint_0;

		public uint uint_1;

		public byte byte_0;
	}

	public enum E19B5E1A
	{
		A9A69701 = 76,
		E7220D81 = 35,
		const_2 = 0
	}

	public struct C8BB1A85
	{
		public uint uint_0;

		public IntPtr CE3F2D27;
	}

	public struct Struct13
	{
		public readonly uint uint_0;

		public readonly IntPtr intptr_0;

		public readonly IntPtr BD377D99;

		public readonly uint uint_1;

		public readonly IntPtr intptr_1;

		public readonly IntPtr FD8C4A8E;

		public void method_0()
		{
			object[] array = new object[1] { this };
			try
			{
				new GClass8().method_31(array, 2687306);
			}
			finally
			{
				this = (Struct13)array[0];
			}
		} 
	}

	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate uint C797DDB4(IntPtr C939BA15, IntPtr intptr_0, IntPtr D0AAF593, IntPtr intptr_1, out C8BB1A85 c8BB1A85_0, uint uint_0, IntPtr BB37AE83, uint F5101E1D, IntPtr intptr_2, uint uint_1);

	private static Delegate1 delegate1_0;

	private static Delegate5 AA3EA208;

	private static C797DDB4 c797DDB4_0;

	private static B61E3CB3 b61E3CB3_0;

	private static Delegate0 delegate0_0;

	private static IntPtr A48E053A;

	public static readonly IntPtr intptr_0;

	private static Delegate4 DD327FBA;

	private static D0BF4925 E78D2AB3;

	private static Delegate6 delegate6_0;

	private static Delegate9 delegate9_0;

	private static Delegate3 delegate3_0;

	private static Delegate7 delegate7_0;

	private static AE116C35 ae116C35_0;

	public static readonly IntPtr intptr_1;

	private static Delegate8 A2A67DB8;

	private static Delegate2 DC2F1982;

	public static readonly IntPtr F6889720; 
	public static byte[] smethod_1(uint C13E9C30, uint uint_0)
	{
		return (byte[])new GClass8().method_31(new object[2] { C13E9C30, uint_0 }, 5009610);
	}

	public static bool D73B58A2()
	{
		return (bool)new GClass8().method_31(null, 4994654);
	}

	public static void B2187F27(string A0190D91, string string_0, GEnum0 E6ADEC39, GEnum1 C0163D37)
	{
		new GClass8().method_31(new object[4] { A0190D91, string_0, E6ADEC39, C0163D37 }, 5001455);
	} 
	public static bool smethod_2(IntPtr intptr_2)
	{
		return (bool)new GClass8().method_31(new object[1] { intptr_2 }, 4999769);
	}

	public static byte[] smethod_3(uint uint_0)
	{
		return (byte[])new GClass8().method_31(new object[1] { uint_0 }, 5006592);
	}

	internal static IntPtr smethod_4(IntPtr intptr_2, object object_0)
	{
		return (IntPtr)new GClass8().method_31(new object[2] { intptr_2, object_0 }, 2683144);
	}

	public static bool smethod_5(IntPtr intptr_2)
	{
		return (bool)new GClass8().method_31(new object[1] { intptr_2 }, 5004512);
	}

	public static IntPtr smethod_6(IntPtr intptr_2, UIntPtr uintptr_0, DD0EFA2F dd0EFA2F_0, Enum2 enum2_0)
	{
		return (IntPtr)new GClass8().method_31(new object[4] { intptr_2, uintptr_0, dd0EFA2F_0, enum2_0 }, 2684734);
	}
	 
	internal static IntPtr smethod_8(uint B20E8F26)
	{
		return (IntPtr)new GClass8().method_31(new object[1] { B20E8F26 }, 4995726);
	}

	public static bool smethod_9()
	{
		return (bool)new GClass8().method_31(null, 4979702);
	}

	public static uint ED324485(IntPtr intptr_2, Enum0 F4049F21, IntPtr intptr_3, uint uint_0)
	{
		return (uint)new GClass8().method_31(new object[4] { intptr_2, F4049F21, intptr_3, uint_0 }, 4984175);
	}

	public static bool E32C1E38()
	{
		return (bool)new GClass8().method_31(null, 3857040);
	}

	public static byte[] E28C051F(string string_0)
	{
		return (byte[])new GClass8().method_31(new object[1] { string_0 }, 2680544);
	} 

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr GetModuleHandle(string AD151924);

	public static IntPtr smethod_11(IntPtr intptr_2, IntPtr intptr_3, Enum2 FD9DED17, uint uint_0, uint uint_1, string F023773F)
	{
		return (IntPtr)new GClass8().method_31(new object[6] { intptr_2, intptr_3, FD9DED17, uint_0, uint_1, F023773F }, 4981413);
	}

	public static byte[] smethod_12(string E629B6BF)
	{
		return (byte[])new GClass8().method_31(new object[1] { E629B6BF }, 2688509);
	}

	public static IntPtr F92E0521(string FCAF8423, uint DF0F151C, uint uint_0)
	{
		return (IntPtr)new GClass8().method_31(new object[3] { FCAF8423, DF0F151C, uint_0 }, 4996211);
	}

	public static bool A382BEAA(IntPtr intptr_2, UIntPtr EC35B1A6, E83B2487 e83B2487_0)
	{
		return (bool)new GClass8().method_31(new object[3] { intptr_2, EC35B1A6, e83B2487_0 }, 4981784);
	}

	static Class20()
	{
		new GClass8().method_31(null, 4984763);
	}
}
