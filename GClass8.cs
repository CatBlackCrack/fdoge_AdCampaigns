using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;

public class GClass8
{
	private sealed class Class43 : C0AA4D3D
	{
		private uint FC3FE63C;

		private Stack<int> stack_0 = new Stack<int>();

		private uint FDA9F110;

		public override void C2A7D395(int E429CD2E)
		{
			FC3FE63C = (uint)E429CD2E;
			FDA9F110 = FC3FE63C;
		}

		public int method_0()
		{
			return stack_0.Count;
		}

		public unsafe long method_1()
		{
			long result = *(long*)(void*)Class46.smethod_1(FC3FE63C);
			FC3FE63C += 8u;
			return result;
		}

		public void method_2()
		{
			C2A7D395(stack_0.Pop());
		}

		public unsafe int method_3()
		{
			uint num = *(uint*)(void*)Class46.smethod_1(FC3FE63C);
			FC3FE63C += 4u;
			num ^= FDA9F110;
			num = ~(num + 1) + 1581109811;
			num = ~(((num & 0xFF000000u) >> 24) | ((num & 0xFF0000) >> 8) | ((num & 0xFF00) << 8) | ((num & 0xFF) << 24));
			FDA9F110 ^= num;
			return (int)num;
		}

		public double method_4()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(method_1()), 0);
		}

		public float method_5()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(method_3()), 0);
		}

		public unsafe short method_6()
		{
			ushort num = *(ushort*)(void*)Class46.smethod_1(FC3FE63C);
			FC3FE63C += 2u;
			num = (ushort)(num ^ FDA9F110);
			num = (ushort)(~num - 1);
			num = (ushort)((((uint)num >> 1) | (uint)(num << 15)) - 1);
			FDA9F110 ^= num;
			return (short)num;
		}

		public void method_7()
		{
			stack_0.Clear();
			FDA9F110 = 0u;
			FC3FE63C = 0u;
		}

		public unsafe byte method_8()
		{
			byte b = *(byte*)(void*)Class46.smethod_1(FC3FE63C);
			FC3FE63C++;
			b = (byte)(b ^ FDA9F110);
			b = (byte)(((uint)(b << 1) | ((uint)b >> 7)) - 46);
			b = (byte)(~((uint)(b << 1) | ((uint)b >> 7)) + 189);
			b = (byte)(((uint)(b << 1) | ((uint)b >> 7)) - 1);
			FDA9F110 ^= b;
			return b;
		}

		public void method_9(int int_0)
		{
			stack_0.Push(int_0);
		}

		public unsafe byte method_10()
		{
			byte b = *(byte*)(void*)Class46.smethod_1(FC3FE63C);
			FC3FE63C++;
			b = (byte)(b ^ FDA9F110);
			b = (byte)(-((b ^ 0x98) - 1));
			b = (byte)(((((uint)b >> 1) | (uint)(b << 7)) ^ 0xA3) - 41);
			b = (byte)(0 - ((((uint)b >> 1) | (uint)(b << 7)) - 1));
			FDA9F110 ^= b;
			return b;
		}

		public override int A4991292()
		{
			return (int)FC3FE63C;
		}
	}

	private sealed class Class25 : Class24
	{
		private MethodBase methodBase_0;

		public override object CF390C18()
		{
			return methodBase_0;
		}

		public override IntPtr FC1A08AE()
		{
			return methodBase_0.MethodHandle.GetFunctionPointer();
		}

		public override Class23 F7B8C78E()
		{
			return new Class25(methodBase_0);
		}

		public override Type vmethod_2()
		{
			return typeof(MethodBase);
		}

		public override void vmethod_11(object C00B442E)
		{
			methodBase_0 = (MethodBase)C00B442E;
		}

		public Class25(MethodBase methodBase_1)
		{
			methodBase_0 = methodBase_1;
		}
	}

	private abstract class Class24 : Class23
	{
		public override Class24 AD0A99B1()
		{
			return this;
		}
	}

	private sealed class Class26 : Class24
	{
		private int EF8B43B0;

		public override long EA2A0215()
		{
			return EF8B43B0;
		}

		public static Class23 E528EABD(Class23 class23_0, Class23 CCB6A612)
		{
			int num = 0;
			if (((uint)CCB6A612.vmethod_0() & (true ? 1u : 0u)) != 0)
			{
				uint num2 = class23_0.E318E528();
				uint num3 = CCB6A612.E318E528();
				if (num2 == num3)
				{
					num |= 2;
				}
				else if (num2 < num3)
				{
					num |= 8;
				}
			}
			else
			{
				int num4 = class23_0.vmethod_1();
				int num5 = CCB6A612.vmethod_1();
				if (num4 == num5)
				{
					num |= 2;
				}
				else if (num4 < num5)
				{
					num |= 8;
				}
			}
			return new Class26(num);
		}

		public override byte vmethod_5()
		{
			return (byte)EF8B43B0;
		}

		public static Class23 smethod_1(Class23 class23_0, Class23 class23_1)
		{
			if (((uint)class23_1.vmethod_0() & (true ? 1u : 0u)) != 0)
			{
				uint num = class23_0.E318E528();
				int num2 = class23_1.vmethod_1();
				return new Class26((int)(num >> num2));
			}
			int num3 = class23_0.vmethod_1();
			int num4 = class23_1.vmethod_1();
			return new Class26(num3 >> num4);
		}

		public override char DE8559A6()
		{
			return (char)EF8B43B0;
		}

		public override Class23 F7B8C78E()
		{
			Class26 @class = new Class26(EF8B43B0);
			@class.vmethod_8(vmethod_0());
			return @class;
		}

		public override Type vmethod_2()
		{
			return typeof(int);
		}

		public override bool BEA0701B()
		{
			return EF8B43B0 != 0;
		}

		public override UIntPtr C099D01E()
		{
			return new UIntPtr((uint)EF8B43B0);
		}

		public static Class23 smethod_2(Class23 class23_0, Class23 BF882C2F)
		{
			if (((uint)BF882C2F.vmethod_0() & (true ? 1u : 0u)) != 0)
			{
				uint num = class23_0.E318E528();
				uint num2 = BF882C2F.E318E528();
				return new Class26((int)(num % num2));
			}
			int num3 = class23_0.vmethod_1();
			int num4 = BF882C2F.vmethod_1();
			return new Class26(num3 % num4);
		}

		public override int vmethod_1()
		{
			return EF8B43B0;
		}

		public override void vmethod_11(object B5264A34)
		{
			EF8B43B0 = Convert.ToInt32(B5264A34);
		}

		public static Class23 smethod_3(Class23 class23_0, Class23 class23_1)
		{
			uint num = class23_0.E318E528();
			uint num2 = class23_1.E318E528();
			_ = num + num2;
			Class26 @class = new Class26(0);
			int num3 = 0;
			uint num4 = 2147483648u;
			if (((num ^ (false ? 1u : 0u)) & (num2 ^ (false ? 1u : 0u)) & 0x80000000u) != 0)
			{
				num3 |= 0x40;
			}
			if (((num ^ ((num ^ num2) & (num2 ^ (false ? 1u : 0u)))) & num4) != 0)
			{
				num3 |= 0x20;
			}
			@class.vmethod_8(num3);
			return @class;
		}

		public static Class23 smethod_4(Class23 BD9441B8, Class23 D3B3D201)
		{
			int num = BD9441B8.vmethod_1();
			int num2 = D3B3D201.vmethod_1();
			return new Class26(num << num2);
		}

		public static Class23 smethod_5(Class23 CB8F8B3E, Class23 class23_0)
		{
			uint num = ~CB8F8B3E.E318E528();
			uint num2 = ~class23_0.E318E528();
			_ = num | num2;
			Class26 @class = new Class26(-1);
			@class.vmethod_8(8);
			return @class;
		}

		public override ulong vmethod_6()
		{
			return (uint)EF8B43B0;
		}

		public override uint E318E528()
		{
			return (uint)EF8B43B0;
		}

		public override sbyte vmethod_12()
		{
			return (sbyte)EF8B43B0;
		}

		public override object CF390C18()
		{
			return EF8B43B0;
		}

		public static Class23 smethod_6(Class23 B72C01B8, Class23 class23_0)
		{
			uint num = ~B72C01B8.E318E528();
			uint num2 = ~class23_0.E318E528();
			_ = num & num2;
			Class26 @class = new Class26(0);
			@class.vmethod_8(2);
			return @class;
		}

		public static Class23 smethod_7(Class23 class23_0, Class23 class23_1)
		{
			uint num = class23_0.E318E528();
			uint num2 = class23_1.E318E528();
			ulong num3 = num * num2;
			uint num4 = (uint)num3;
			Class26 @class = new Class26((int)num4);
			int num5 = 0;
			if (((num ^ num4) & (num2 ^ num4) & 0x80000000u) != 0)
			{
				num5 |= 0x40;
			}
			if (((num ^ ((num ^ num2) & (num2 ^ num4))) & 0x80000000u) != 0)
			{
				num5 |= 0x20;
			}
			if (((uint)class23_1.vmethod_0() & (true ? 1u : 0u)) != 0)
			{
				if ((num3 & 0xFFFFFFFFL) != 0L)
				{
					num5 |= 0x20;
				}
			}
			else
			{
				num3 = (ulong)(int)(num * num2);
				if (num3 >> 63 != num4 >> 31)
				{
					num5 |= 0x40;
				}
			}
			@class.vmethod_8(num5);
			return @class;
		}

		public static Class23 A48F0006(Class23 class23_0, Class23 class23_1)
		{
			if (((uint)class23_1.vmethod_0() & (true ? 1u : 0u)) != 0)
			{
				uint num = class23_0.E318E528();
				uint num2 = class23_1.E318E528();
				return new Class26((int)(num / num2));
			}
			int num3 = class23_0.vmethod_1();
			int num4 = class23_1.vmethod_1();
			return new Class26(num3 / num4);
		}

		public override IntPtr FC1A08AE()
		{
			return new IntPtr(EF8B43B0);
		}

		public override ushort vmethod_10()
		{
			return (ushort)EF8B43B0;
		}

		public static Class23 smethod_8(Class23 BA236291)
		{
			ulong num = BA236291.vmethod_6();
			bool flag = (BA236291.vmethod_0() & 1) != 0;
			int num2 = 0;
			if (num <= 2147483647L)
			{
				if (flag)
				{
				}
			}
			else
			{
				num2 |= 0x40;
			}
			BA236291 = new Class26((int)num);
			BA236291.vmethod_8(num2);
			return BA236291;
		}

		public override float C513208F()
		{
			return EF8B43B0;
		}

		public override short vmethod_9()
		{
			return (short)EF8B43B0;
		}

		public override double vmethod_3()
		{
			return EF8B43B0;
		}

		public Class26(int C8A55F08)
		{
			EF8B43B0 = C8A55F08;
		}
	}

	private sealed class Class27 : Class24
	{
		private object object_0;

		public override Type vmethod_2()
		{
			return typeof(ValueType);
		}

		public override Class23 F7B8C78E()
		{
			object obj;
			if (object_0 == null)
			{
				obj = null;
			}
			else
			{
				Type type = object_0.GetType();
				FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				obj = Activator.CreateInstance(type);
				FieldInfo[] array = fields;
				foreach (FieldInfo fieldInfo in array)
				{
					fieldInfo.SetValue(obj, fieldInfo.GetValue(object_0));
				}
			}
			return new Class27(obj);
		}

		public override object CF390C18()
		{
			return object_0;
		}

		public override void vmethod_11(object A7B47C3C)
		{
			if (A7B47C3C != null && !(A7B47C3C is ValueType))
			{
				throw new ArgumentException();
			}
			object_0 = A7B47C3C;
		}

		public Class27(object object_1)
		{
			if (object_1 != null && !(object_1 is ValueType))
			{
				throw new ArgumentException();
			}
			object_0 = object_1;
		}
	}

	private sealed class Class37 : Class23
	{
		private ushort E82AA329;

		public override Class24 AD0A99B1()
		{
			return new Class26(vmethod_1());
		}

		public override Class23 F7B8C78E()
		{
			return new Class37(E82AA329);
		}

		public override void vmethod_11(object C00B442E)
		{
			E82AA329 = Convert.ToUInt16(C00B442E);
		}

		public override byte vmethod_5()
		{
			return (byte)E82AA329;
		}

		public override Type vmethod_2()
		{
			return typeof(ushort);
		}

		public static Class23 smethod_1(Class23 class23_0)
		{
			ulong num = class23_0.vmethod_6();
			bool num2 = (class23_0.vmethod_0() & 1) != 0;
			int num3 = 0;
			if (num2)
			{
				if (num > 65535L)
				{
					num3 |= 0x40;
				}
			}
			else if (num > 18446744071825927625uL)
			{
				num3 |= 0x10400212;
			}
			class23_0 = new Class26((ushort)num);
			class23_0.vmethod_8(num3);
			return class23_0;
		}

		public override object CF390C18()
		{
			return E82AA329;
		}

		public override ushort vmethod_10()
		{
			return E82AA329;
		}

		public override sbyte vmethod_12()
		{
			return (sbyte)E82AA329;
		}

		public override int vmethod_1()
		{
			return E82AA329;
		}

		public override uint E318E528()
		{
			return E82AA329;
		}

		public override short vmethod_9()
		{
			return (short)E82AA329;
		}

		public Class37(ushort ushort_0)
		{
			E82AA329 = ushort_0;
		}
	}

	private enum Enum3
	{
		const_0 = 11,
		DDB52F16 = 4,
		CE98AB0F = 3,
		const_3 = 7,
		const_4 = 10,
		const_5 = 6,
		const_6 = 0,
		const_7 = 1,
		BC8F7E87 = 5,
		const_9 = 32,
		const_10 = 16,
		const_11 = 64,
		const_12 = 15,
		const_13 = 8,
		const_14 = 9,
		const_15 = 2
	}

	private sealed class C0363D38 : C0AA4D3D
	{
		private int B51EB3BB;

		private List<Class23> E18507BC = new List<Class23>();

		public Class23 D19DE917()
		{
			int index = E18507BC.Count - 1;
			return E18507BC[index];
		}

		public override void C2A7D395(int C5265086)
		{
			B51EB3BB = C5265086;
			for (int i = 0; i < B51EB3BB; i++)
			{
				E18507BC.Insert(0, null);
			}
		}

		public Class23 F62DB9AC()
		{
			int index = E18507BC.Count - 1;
			Class23 result = E18507BC[index];
			E18507BC.RemoveAt(index);
			return result;
		}

		public void F928DA32(Class23 C0BAE234)
		{
			E18507BC.Add(C0BAE234.AD0A99B1());
		}

		public Class23 D33B742C(int int_0)
		{
			if (int_0 < 0)
			{
				int_0 += E18507BC.Count - 1;
			}
			return E18507BC[int_0];
		}

		public Class23 method_0(int AD8B6803, Class23 class23_0)
		{
			if (AD8B6803 < 0)
			{
				AD8B6803 += E18507BC.Count - 1;
			}
			return E18507BC[AD8B6803] = class23_0;
		}

		public void D590F00B()
		{
			while (E18507BC.Count > B51EB3BB)
			{
				E18507BC.RemoveAt(B51EB3BB);
			}
		}

		public override int A4991292()
		{
			return E18507BC.Count;
		}
	}

	private sealed class D133C38F
	{
		private int int_0;

		private int A2AF6A24;

		private byte byte_0;

		public int D514F0AD()
		{
			return A2AF6A24;
		}

		public byte method_0()
		{
			return byte_0;
		}

		public int method_1()
		{
			return int_0;
		}

		public D133C38F(byte byte_1, int int_1, int int_2)
		{
			byte_0 = byte_1;
			A2AF6A24 = int_1;
			int_0 = int_2;
		}
	}

	private sealed class Class28 : B53794AC
	{
		private Class23 class23_0;

		private FieldInfo fieldInfo_0;

		public override Type vmethod_2()
		{
			return fieldInfo_0.FieldType;
		}

		public override Class23 F7B8C78E()
		{
			return new Class28(fieldInfo_0, class23_0);
		}

		public override void vmethod_11(object C00B442E)
		{
			class23_0.F1840825(fieldInfo_0, C00B442E);
		}

		public override object CF390C18()
		{
			return class23_0.vmethod_4(fieldInfo_0);
		}

		public Class28(FieldInfo fieldInfo_1, Class23 class23_1)
		{
			fieldInfo_0 = fieldInfo_1;
			class23_0 = class23_1;
		}
	}

	private sealed class Class38 : Class23
	{
		private uint uint_0;

		public override short vmethod_9()
		{
			return (short)uint_0;
		}

		public override int vmethod_1()
		{
			return (int)uint_0;
		}

		public override sbyte vmethod_12()
		{
			return (sbyte)uint_0;
		}

		public override Class23 F7B8C78E()
		{
			return new Class38(uint_0);
		}

		public override ushort vmethod_10()
		{
			return (ushort)uint_0;
		}

		public override Type vmethod_2()
		{
			return typeof(uint);
		}

		public static Class23 AF2F28A0(Class23 class23_0)
		{
			ulong num = class23_0.vmethod_6();
			bool num2 = (class23_0.vmethod_0() & 1) != 0;
			int num3 = 0;
			if (num2)
			{
				if (num > 4294967295L)
				{
					num3 |= 0x40;
				}
			}
			else if (num > 2147483647L)
			{
				num3 |= 0x40;
			}
			class23_0 = new Class26((int)num);
			class23_0.vmethod_8(num3);
			return class23_0;
		}

		public override uint E318E528()
		{
			return uint_0;
		}

		public override Class24 AD0A99B1()
		{
			return new Class26(vmethod_1());
		}

		public override byte vmethod_5()
		{
			return (byte)uint_0;
		}

		public override object CF390C18()
		{
			return uint_0;
		}

		public override void vmethod_11(object F6A24A17)
		{
			uint_0 = Convert.ToUInt32(F6A24A17);
		}

		public Class38(uint C08A1033)
		{
			uint_0 = C08A1033;
		}
	}

	private sealed class Class21 : IDisposable
	{
		private List<GCHandle> list_0 = new List<GCHandle>();

		public void Dispose()
		{
			foreach (GCHandle item in list_0)
			{
				item.Free();
			}
			list_0.Clear();
		}

		public IntPtr method_0(object F02AB1AD)
		{
			GCHandle item = GCHandle.Alloc(F02AB1AD, GCHandleType.Pinned);
			list_0.Add(item);
			return item.AddrOfPinnedObject();
		}
	}

	private sealed class Class22
	{
		private List<D133C38F> F8B8CB1E = new List<D133C38F>();

		private int B50B6C8A;

		private int int_0;

		public int method_0()
		{
			return B50B6C8A;
		}

		public int method_1(Class22 E92602B2)
		{
			if (E92602B2 == null)
			{
				return 1;
			}
			int num = int_0.CompareTo(E92602B2.E1152A09());
			if (num == 0)
			{
				num = E92602B2.method_0().CompareTo(B50B6C8A);
			}
			return num;
		}

		public int E1152A09()
		{
			return int_0;
		}

		public void method_2(byte byte_0, int int_1, int B21A1305)
		{
			F8B8CB1E.Add(new D133C38F(byte_0, int_1, B21A1305));
		}

		public List<D133C38F> F68C40A8()
		{
			return F8B8CB1E;
		}

		public Class22(int int_1, int E5A5ACB5)
		{
			int_0 = int_1;
			B50B6C8A = E5A5ACB5;
		}
	}

	private sealed class ED0084A1 : Class23
	{
		private bool A5807E90;

		public override object CF390C18()
		{
			return A5807E90;
		}

		public override Class24 AD0A99B1()
		{
			return new Class26(vmethod_1());
		}

		public override Type vmethod_2()
		{
			return typeof(bool);
		}

		public override Class23 F7B8C78E()
		{
			return new ED0084A1(A5807E90);
		}

		public override void vmethod_11(object C00B442E)
		{
			A5807E90 = Convert.ToBoolean(C00B442E);
		}

		public override int vmethod_1()
		{
			if (!A5807E90)
			{
				return 0;
			}
			return 1;
		}

		public ED0084A1(bool bool_0)
		{
			A5807E90 = bool_0;
		}
	}

	private sealed class D73CC92E : Class23
	{
		private sbyte sbyte_0;

		public override void vmethod_11(object C00B442E)
		{
			sbyte_0 = Convert.ToSByte(C00B442E);
		}

		public override Class24 AD0A99B1()
		{
			return new Class26(vmethod_1());
		}

		public override short vmethod_9()
		{
			return sbyte_0;
		}

		public override ushort vmethod_10()
		{
			return (ushort)sbyte_0;
		}

		public override object CF390C18()
		{
			return sbyte_0;
		}

		public static Class23 smethod_1(Class23 DEB26AB9)
		{
			ulong num = DEB26AB9.vmethod_6();
			bool flag = (DEB26AB9.vmethod_0() & 1) != 0;
			int num2 = 0;
			if (num > 127L || (!flag && (sbyte)num < sbyte.MinValue))
			{
				num2 |= 0x40;
			}
			DEB26AB9 = new Class26((sbyte)num);
			DEB26AB9.vmethod_8(num2);
			return DEB26AB9;
		}

		public override sbyte vmethod_12()
		{
			return sbyte_0;
		}

		public override Class23 F7B8C78E()
		{
			return new D73CC92E(sbyte_0);
		}

		public override int vmethod_1()
		{
			return sbyte_0;
		}

		public override uint E318E528()
		{
			return (uint)sbyte_0;
		}

		public override byte vmethod_5()
		{
			return (byte)sbyte_0;
		}

		public override Type vmethod_2()
		{
			return typeof(sbyte);
		}

		public D73CC92E(sbyte sbyte_1)
		{
			sbyte_0 = sbyte_1;
		}
	}

	internal delegate void Delegate10();

	private sealed class Class44 : C0AA4D3D
	{
		private Stack<int> B390E9B1 = new Stack<int>();

		private List<Class22> list_0 = new List<Class22>();

		public Class22 method_0()
		{
			return list_0[B390E9B1.Pop()];
		}

		public override int A4991292()
		{
			return 0;
		}

		public override void C2A7D395(int C5265086)
		{
			for (int i = 0; i < list_0.Count; i++)
			{
				if (list_0[i].E1152A09() == C5265086)
				{
					B390E9B1.Push(i);
				}
			}
		}

		public int method_1()
		{
			return B390E9B1.Count;
		}

		public Class22 A91B7B8D()
		{
			return list_0[B390E9B1.Peek()];
		}

		public void DF81B78C(int int_0, int E4AEA48E, byte EE164E2C, int CE9272B5, int D93FB816)
		{
			Class22 @class = null;
			for (int i = 0; i < list_0.Count; i++)
			{
				Class22 class2 = list_0[i];
				if (class2.E1152A09() == int_0 && class2.method_0() == E4AEA48E)
				{
					@class = class2;
					break;
				}
			}
			if (@class == null)
			{
				bool flag = false;
				@class = new Class22(int_0, E4AEA48E);
				for (int j = 0; j < list_0.Count; j++)
				{
					Class22 e92602B = list_0[j];
					if (@class.method_1(e92602B) < 0)
					{
						list_0.Insert(j, @class);
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					list_0.Add(@class);
				}
			}
			@class.method_2(EE164E2C, CE9272B5, D93FB816);
		}
	}

	private sealed class D329701F : B53794AC
	{
		private int E089A799;

		private Array array_0;

		public override Type vmethod_2()
		{
			return array_0.GetType().GetElementType();
		}

		public override object CF390C18()
		{
			return array_0.GetValue(E089A799);
		}

		public override void vmethod_11(object C00B442E)
		{
			switch (Type.GetTypeCode(vmethod_2()))
			{
			case TypeCode.Char:
				C00B442E = Convert.ToChar(C00B442E);
				break;
			case TypeCode.SByte:
				C00B442E = Convert.ToSByte(C00B442E);
				break;
			case TypeCode.Byte:
				C00B442E = Convert.ToByte(C00B442E);
				break;
			case TypeCode.Int16:
				C00B442E = Convert.ToInt16(C00B442E);
				break;
			case TypeCode.UInt16:
				C00B442E = Convert.ToUInt16(C00B442E);
				break;
			case TypeCode.Int32:
				C00B442E = Convert.ToInt32(C00B442E);
				break;
			case TypeCode.UInt32:
				C00B442E = Convert.ToUInt32(C00B442E);
				break;
			case TypeCode.Int64:
				C00B442E = Convert.ToInt64(C00B442E);
				break;
			case TypeCode.UInt64:
				C00B442E = Convert.ToUInt64(C00B442E);
				break;
			}
			array_0.SetValue(C00B442E, E089A799);
		}

		public override Class23 F7B8C78E()
		{
			return new D329701F(array_0, E089A799);
		}

		public D329701F(Array array_1, int int_1)
		{
			array_0 = array_1;
			E089A799 = int_1;
		}
	}

	private abstract class B53794AC : Class24
	{
		public override bool vmethod_7()
		{
			return true;
		}
	}

	private sealed class BC1CC939 : Class23
	{
		private ulong ulong_0;

		public override sbyte vmethod_12()
		{
			return (sbyte)ulong_0;
		}

		public override Class23 F7B8C78E()
		{
			return new BC1CC939(ulong_0);
		}

		public override int vmethod_1()
		{
			return (int)ulong_0;
		}

		public override ulong vmethod_6()
		{
			return ulong_0;
		}

		public override ushort vmethod_10()
		{
			return (ushort)ulong_0;
		}

		public override uint E318E528()
		{
			return (uint)ulong_0;
		}

		public override short vmethod_9()
		{
			return (short)ulong_0;
		}

		public override object CF390C18()
		{
			return ulong_0;
		}

		public override long EA2A0215()
		{
			return (long)ulong_0;
		}

		public override byte vmethod_5()
		{
			return (byte)ulong_0;
		}

		public override Type vmethod_2()
		{
			return typeof(ulong);
		}

		public override void vmethod_11(object C00B442E)
		{
			ulong_0 = Convert.ToUInt64(C00B442E);
		}

		public override Class24 AD0A99B1()
		{
			return new E12B7BBC(EA2A0215());
		}

		public static Class23 E584080A(Class23 class23_0)
		{
			ulong num = class23_0.vmethod_6();
			bool num2 = (class23_0.vmethod_0() & 1) != 0;
			int num3 = 0;
			if (!num2 && num > long.MaxValue)
			{
				num3 |= 0x40;
			}
			class23_0 = new E12B7BBC((long)num);
			class23_0.vmethod_8(num3);
			return class23_0;
		}

		public BC1CC939(ulong ulong_1)
		{
			ulong_0 = ulong_1;
		}
	}

	private sealed class Class39 : Class23
	{
		private Type type_0;

		private object object_0;

		public override void vmethod_11(object C00B442E)
		{
			object_0 = C00B442E;
		}

		public override Class23 F7B8C78E()
		{
			return new Class39(object_0, type_0);
		}

		public unsafe override Class24 AD0A99B1()
		{
			return new E00C7E2C((object_0 == null) ? IntPtr.Zero : new IntPtr(Pointer.Unbox(object_0)));
		}

		public override Type vmethod_2()
		{
			return type_0;
		}

		public override object CF390C18()
		{
			return object_0;
		}

		public Class39(object FDBCF801, Type type_1)
		{
			object_0 = FDBCF801;
			type_0 = type_1;
		}
	}

	private sealed class Class40 : Class23
	{
		private char DE39B585;

		public override uint E318E528()
		{
			return DE39B585;
		}

		public override Class23 F7B8C78E()
		{
			return new Class40(DE39B585);
		}

		public override short vmethod_9()
		{
			return (short)DE39B585;
		}

		public override sbyte vmethod_12()
		{
			return (sbyte)DE39B585;
		}

		public override int vmethod_1()
		{
			return DE39B585;
		}

		public override object CF390C18()
		{
			return DE39B585;
		}

		public override Type vmethod_2()
		{
			return typeof(char);
		}

		public override Class24 AD0A99B1()
		{
			return new Class26(vmethod_1());
		}

		public override byte vmethod_5()
		{
			return (byte)DE39B585;
		}

		public override ushort vmethod_10()
		{
			return DE39B585;
		}

		public override void vmethod_11(object C00B442E)
		{
			DE39B585 = Convert.ToChar(C00B442E);
		}

		public Class40(char char_0)
		{
			DE39B585 = char_0;
		}
	}

	private sealed class E00C7E2C : Class24
	{
		private Class23 class23_0;

		private IntPtr F1805994;

		public static Class23 smethod_1(Class23 class23_1, Class23 FEA11184)
		{
			if (IntPtr.Size != 4)
			{
				return E12B7BBC.smethod_2(class23_1, FEA11184);
			}
			return Class26.A48F0006(class23_1, FEA11184);
		}

		public override sbyte vmethod_12()
		{
			return class23_0.vmethod_12();
		}

		public override bool BEA0701B()
		{
			return F1805994 != IntPtr.Zero;
		}

		public override Type vmethod_2()
		{
			return typeof(IntPtr);
		}

		public static Class23 smethod_2(Class23 FF9F7E93, Class23 class23_1)
		{
			if (IntPtr.Size != 4)
			{
				return E12B7BBC.smethod_4(FF9F7E93, class23_1);
			}
			return Class26.smethod_7(FF9F7E93, class23_1);
		}

		private static Class23 smethod_3(IntPtr B68CDB81)
		{
			if (IntPtr.Size == 4)
			{
				return new Class26(B68CDB81.ToInt32());
			}
			return new E12B7BBC(B68CDB81.ToInt64());
		}

		public override IntPtr FC1A08AE()
		{
			return F1805994;
		}

		public override uint E318E528()
		{
			return class23_0.E318E528();
		}

		public override ushort vmethod_10()
		{
			return class23_0.vmethod_10();
		}

		public override long EA2A0215()
		{
			return class23_0.EA2A0215();
		}

		public override ulong vmethod_6()
		{
			return class23_0.vmethod_6();
		}

		public override int vmethod_1()
		{
			return class23_0.vmethod_1();
		}

		public static Class23 smethod_4(Class23 class23_1)
		{
			if (IntPtr.Size != 4)
			{
				return E12B7BBC.smethod_7(class23_1);
			}
			return Class26.smethod_8(class23_1);
		}

		public static Class23 A0AE0E34(Class23 class23_1, Class23 class23_2)
		{
			if (IntPtr.Size != 4)
			{
				return E12B7BBC.smethod_8(class23_1, class23_2);
			}
			return Class26.smethod_3(class23_1, class23_2);
		}

		public static Class23 C006E40C(Class23 class23_1, Class23 CF9952A9)
		{
			if (IntPtr.Size != 4)
			{
				return E12B7BBC.smethod_1(class23_1, CF9952A9);
			}
			return Class26.E528EABD(class23_1, CF9952A9);
		}

		public override object CF390C18()
		{
			return F1805994;
		}

		public override UIntPtr C099D01E()
		{
			return class23_0.C099D01E();
		}

		public static Class23 F9996DBB(Class23 class23_1, Class23 DB030E0D)
		{
			if (IntPtr.Size != 4)
			{
				return E12B7BBC.smethod_5(class23_1, DB030E0D);
			}
			return Class26.smethod_6(class23_1, DB030E0D);
		}

		public static Class23 smethod_5(Class23 D5101699, Class23 class23_1)
		{
			if (IntPtr.Size != 4)
			{
				return E12B7BBC.smethod_3(D5101699, class23_1);
			}
			return Class26.smethod_2(D5101699, class23_1);
		}

		public static Class23 smethod_6(Class23 D190833B, Class23 class23_1)
		{
			if (IntPtr.Size != 4)
			{
				return E12B7BBC.smethod_6(D190833B, class23_1);
			}
			return Class26.smethod_4(D190833B, class23_1);
		}

		public static Class23 smethod_7(Class23 class23_1, Class23 class23_2)
		{
			if (IntPtr.Size != 4)
			{
				return E12B7BBC.DD8C0E35(class23_1, class23_2);
			}
			return Class26.smethod_1(class23_1, class23_2);
		}

		public override Class23 F7B8C78E()
		{
			return new E00C7E2C(F1805994);
		}

		public override float C513208F()
		{
			return class23_0.C513208F();
		}

		public override void vmethod_11(object C00B442E)
		{
			F1805994 = (IntPtr)C00B442E;
			class23_0 = smethod_3(F1805994);
		}

		public override short vmethod_9()
		{
			return class23_0.vmethod_9();
		}

		public static Class23 DEA45F0B(Class23 class23_1, Class23 class23_2)
		{
			if (IntPtr.Size != 4)
			{
				return E12B7BBC.F2829A8C(class23_1, class23_2);
			}
			return Class26.smethod_5(class23_1, class23_2);
		}

		public override byte vmethod_5()
		{
			return class23_0.vmethod_5();
		}

		public override double vmethod_3()
		{
			return class23_0.vmethod_3();
		}

		public E00C7E2C(IntPtr intptr_0)
		{
			F1805994 = intptr_0;
			class23_0 = smethod_3(F1805994);
		}
	}

	private sealed class Class33 : Class24
	{
		private Class23 class23_0;

		public override int vmethod_1()
		{
			int result = class23_0.vmethod_1();
			Thread.MemoryBarrier();
			return result;
		}

		public override uint E318E528()
		{
			uint result = class23_0.E318E528();
			Thread.MemoryBarrier();
			return result;
		}

		public override ulong vmethod_6()
		{
			ulong result = class23_0.vmethod_6();
			Thread.MemoryBarrier();
			return result;
		}

		public override sbyte vmethod_12()
		{
			sbyte result = class23_0.vmethod_12();
			Thread.MemoryBarrier();
			return result;
		}

		public override bool BEA0701B()
		{
			bool result = class23_0.BEA0701B();
			Thread.MemoryBarrier();
			return result;
		}

		public override object CF390C18()
		{
			object result = class23_0.CF390C18();
			Thread.MemoryBarrier();
			return result;
		}

		public override void vmethod_11(object D488C9B4)
		{
			Thread.MemoryBarrier();
			class23_0.vmethod_11(D488C9B4);
		}

		public override object vmethod_4(FieldInfo D0117407)
		{
			object result = class23_0.vmethod_4(D0117407);
			Thread.MemoryBarrier();
			return result;
		}

		public override void F1840825(FieldInfo fieldInfo_0, object object_0)
		{
			Thread.MemoryBarrier();
			class23_0.F1840825(fieldInfo_0, object_0);
		}

		public override float C513208F()
		{
			float result = class23_0.C513208F();
			Thread.MemoryBarrier();
			return result;
		}

		public override double vmethod_3()
		{
			double result = class23_0.vmethod_3();
			Thread.MemoryBarrier();
			return result;
		}

		public override short vmethod_9()
		{
			short result = class23_0.vmethod_9();
			Thread.MemoryBarrier();
			return result;
		}

		public override Class23 F7B8C78E()
		{
			throw new InvalidOperationException();
		}

		public override Type vmethod_2()
		{
			return class23_0.vmethod_2();
		}

		public override bool vmethod_7()
		{
			return class23_0.vmethod_7();
		}

		public override ushort vmethod_10()
		{
			ushort result = class23_0.vmethod_10();
			Thread.MemoryBarrier();
			return result;
		}

		public override long EA2A0215()
		{
			long result = class23_0.EA2A0215();
			Thread.MemoryBarrier();
			return result;
		}

		public override byte vmethod_5()
		{
			byte result = class23_0.vmethod_5();
			Thread.MemoryBarrier();
			return result;
		}

		public Class33(Class23 class23_1)
		{
			class23_0 = class23_1;
		}
	}

	private sealed class EA188E0F
	{
		private enum Enum4
		{
			const_0 = 11,
			const_1 = 28,
			const_2 = 26,
			const_3 = 24,
			const_4 = 15,
			const_5 = 0,
			const_6 = 23,
			const_7 = 9,
			const_8 = 16,
			CC899C82 = 30,
			const_10 = 29,
			E2A6FA96 = 8,
			const_12 = 65,
			E8903410 = 32,
			B7B27EAE = 12,
			const_15 = 4,
			const_16 = 3,
			const_17 = 22,
			const_18 = 27,
			C98EBB37 = 18,
			const_20 = 14,
			const_21 = 69,
			const_22 = 2,
			const_23 = 25,
			ED2A7080 = 5,
			const_25 = 7,
			const_26 = 17,
			D5967CB4 = 10,
			const_28 = 6,
			const_29 = 1,
			const_30 = 13,
			const_31 = 21,
			const_32 = 31,
			const_33 = 19,
			const_34 = 20
		}

		private int BE0C3A1C;

		private byte[] byte_0;

		public byte method_0()
		{
			return byte_0[BE0C3A1C++];
		}

		public uint method_1()
		{
			byte b = byte_0[BE0C3A1C];
			if ((b & 0x80) == 0)
			{
				BE0C3A1C++;
			}
			else if ((b & 0x40) == 0)
			{
				BE0C3A1C += 2;
			}
			else
			{
				BE0C3A1C += 4;
			}
			return 0u;
		}

		public Type method_2(Module module_0)
		{
			bool flag = false;
			bool flag2 = true;
			while (flag2)
			{
				switch ((Enum4)method_0())
				{
				case Enum4.const_32:
				case Enum4.E8903410:
					method_1();
					break;
				case Enum4.const_8:
					flag = true;
					break;
				default:
					flag2 = false;
					BE0C3A1C--;
					break;
				case Enum4.const_12:
				case Enum4.const_21:
					break;
				}
			}
			Type type;
			switch ((Enum4)method_1())
			{
			case Enum4.const_5:
				type = null;
				break;
			case Enum4.const_29:
				type = typeof(void);
				break;
			case Enum4.const_22:
				type = typeof(bool);
				break;
			case Enum4.const_16:
				type = typeof(char);
				break;
			case Enum4.const_15:
				type = typeof(sbyte);
				break;
			case Enum4.ED2A7080:
				type = typeof(byte);
				break;
			case Enum4.const_28:
				type = typeof(short);
				break;
			case Enum4.const_25:
				type = typeof(ushort);
				break;
			case Enum4.E2A6FA96:
				type = typeof(int);
				break;
			case Enum4.const_7:
				type = typeof(uint);
				break;
			case Enum4.D5967CB4:
				type = typeof(long);
				break;
			case Enum4.const_0:
				type = typeof(ulong);
				break;
			case Enum4.B7B27EAE:
				type = typeof(float);
				break;
			case Enum4.const_30:
				type = typeof(double);
				break;
			case Enum4.const_20:
				type = typeof(string);
				break;
			case Enum4.const_4:
				type = method_2(module_0).MakePointerType();
				break;
			case Enum4.const_26:
			case Enum4.C98EBB37:
			{
				uint num = method_1();
				switch (num & 3)
				{
				}
				type = module_0.ResolveType((int)(0 | (num >> 2)));
				break;
			}
			case Enum4.const_3:
				type = typeof(IntPtr);
				break;
			case Enum4.const_23:
				type = typeof(UIntPtr);
				break;
			default:
				throw new COMException(null, -2146233785);
			case Enum4.const_1:
				type = typeof(object);
				break;
			case Enum4.const_10:
				type = method_2(module_0).MakeArrayType();
				break;
			}
			if (flag)
			{
				type = type.MakeByRefType();
			}
			return type;
		}

		public EA188E0F(byte[] FD9E8502)
		{
			byte_0 = FD9E8502;
		}
	}

	private sealed class Class29 : B53794AC
	{
		private Class23 DDA8800E;

		private Class23 class23_0;

		public override Type vmethod_2()
		{
			return class23_0.vmethod_2();
		}

		public override Class23 F7B8C78E()
		{
			return new Class29(class23_0, DDA8800E);
		}

		public override void vmethod_11(object BC916630)
		{
			class23_0.vmethod_11(BC916630);
			DDA8800E.vmethod_11(class23_0.CF390C18());
		}

		public override object CF390C18()
		{
			return class23_0.CF390C18();
		}

		public Class29(Class23 class23_1, Class23 class23_2)
		{
			class23_0 = class23_1;
			DDA8800E = class23_2;
		}
	}

	private sealed class Class34 : Class24
	{
		private Class23 class23_0;

		private UIntPtr DEAF062E;

		public override Type vmethod_2()
		{
			return typeof(UIntPtr);
		}

		public override object CF390C18()
		{
			return DEAF062E;
		}

		public override short vmethod_9()
		{
			return class23_0.vmethod_9();
		}

		public override Class23 F7B8C78E()
		{
			return new Class34(DEAF062E);
		}

		public override double vmethod_3()
		{
			return class23_0.vmethod_3();
		}

		public override IntPtr FC1A08AE()
		{
			return class23_0.FC1A08AE();
		}

		public override int vmethod_1()
		{
			return class23_0.vmethod_1();
		}

		public static Class23 smethod_1(Class23 AC864388)
		{
			if (IntPtr.Size != 4)
			{
				return BC1CC939.E584080A(AC864388);
			}
			return Class38.AF2F28A0(AC864388);
		}

		public override ushort vmethod_10()
		{
			return class23_0.vmethod_10();
		}

		public override float C513208F()
		{
			return class23_0.C513208F();
		}

		private static Class23 smethod_2(UIntPtr C7B5C8BB)
		{
			if (IntPtr.Size == 4)
			{
				return new Class26((int)C7B5C8BB.ToUInt32());
			}
			return new E12B7BBC((long)C7B5C8BB.ToUInt64());
		}

		public override byte vmethod_5()
		{
			return class23_0.vmethod_5();
		}

		public override sbyte vmethod_12()
		{
			return class23_0.vmethod_12();
		}

		public override ulong vmethod_6()
		{
			return class23_0.vmethod_6();
		}

		public override UIntPtr C099D01E()
		{
			return DEAF062E;
		}

		public override bool BEA0701B()
		{
			return DEAF062E != UIntPtr.Zero;
		}

		public override long EA2A0215()
		{
			return class23_0.EA2A0215();
		}

		public override uint E318E528()
		{
			return class23_0.E318E528();
		}

		public override void vmethod_11(object EAA2C7BF)
		{
			DEAF062E = (UIntPtr)EAA2C7BF;
			class23_0 = smethod_2(DEAF062E);
		}

		public Class34(UIntPtr uintptr_0)
		{
			DEAF062E = uintptr_0;
			class23_0 = smethod_2(DEAF062E);
		}
	}

	private sealed class Class30 : B53794AC
	{
		private object EB9F0306;

		private FieldInfo fieldInfo_0;

		public override Type vmethod_2()
		{
			return typeof(int);
		}

		public override Class23 F7B8C78E()
		{
			return new Class30(fieldInfo_0, EB9F0306);
		}

		public override object CF390C18()
		{
			return ((C0AA4D3D)fieldInfo_0.GetValue(EB9F0306)).A4991292();
		}

		public override void vmethod_11(object A49E292C)
		{
			((C0AA4D3D)fieldInfo_0.GetValue(EB9F0306)).C2A7D395((int)A49E292C);
		}

		public Class30(FieldInfo A79F1737, object DAA1779F)
		{
			fieldInfo_0 = A79F1737;
			EB9F0306 = DAA1779F;
		}
	}

	private sealed class A23ABDAF : Class24
	{
		private Class23 class23_0;

		private Enum enum_0;

		public override ushort vmethod_10()
		{
			return class23_0.vmethod_10();
		}

		public override Class23 F7B8C78E()
		{
			return new A23ABDAF(enum_0);
		}

		public override uint E318E528()
		{
			return class23_0.E318E528();
		}

		public override float C513208F()
		{
			return class23_0.C513208F();
		}

		public override UIntPtr C099D01E()
		{
			return new UIntPtr((IntPtr.Size == 4) ? E318E528() : vmethod_6());
		}

		public override void vmethod_11(object B7B9FC8A)
		{
			if (B7B9FC8A == null)
			{
				throw new ArgumentException();
			}
			enum_0 = (Enum)B7B9FC8A;
			class23_0 = smethod_1(enum_0);
		}

		public override long EA2A0215()
		{
			return class23_0.EA2A0215();
		}

		public override int vmethod_1()
		{
			return class23_0.vmethod_1();
		}

		public override short vmethod_9()
		{
			return class23_0.vmethod_9();
		}

		public override Type vmethod_2()
		{
			return enum_0.GetType();
		}

		public override double vmethod_3()
		{
			return class23_0.vmethod_3();
		}

		public override sbyte vmethod_12()
		{
			return class23_0.vmethod_12();
		}

		public override object CF390C18()
		{
			return enum_0;
		}

		public override IntPtr FC1A08AE()
		{
			return new IntPtr((IntPtr.Size == 4) ? vmethod_1() : EA2A0215());
		}

		public override ulong vmethod_6()
		{
			return class23_0.vmethod_6();
		}

		public override byte vmethod_5()
		{
			return class23_0.vmethod_5();
		}

		private static Class23 smethod_1(Enum enum_1)
		{
			switch (enum_1.GetTypeCode())
			{
			default:
				throw new InvalidOperationException();
			case TypeCode.SByte:
			case TypeCode.Int16:
			case TypeCode.Int32:
				return new Class26(Convert.ToInt32(enum_1));
			case TypeCode.Byte:
			case TypeCode.UInt16:
			case TypeCode.UInt32:
				return new Class26((int)Convert.ToUInt32(enum_1));
			case TypeCode.Int64:
				return new E12B7BBC(Convert.ToInt64(enum_1));
			case TypeCode.UInt64:
				return new E12B7BBC((long)Convert.ToUInt64(enum_1));
			}
		}

		public A23ABDAF(Enum D21A4ABD)
		{
			if (D21A4ABD == null)
			{
				throw new ArgumentException();
			}
			enum_0 = D21A4ABD;
			class23_0 = smethod_1(enum_0);
		}
	}

	private sealed class D9240419 : Class24
	{
		private float B232411F;

		public static Class23 D584A205(Class23 class23_0, Class23 class23_1)
		{
			float num = class23_0.C513208F();
			float num2 = class23_1.C513208F();
			return new D9240419(num / num2);
		}

		public override Type vmethod_2()
		{
			return typeof(float);
		}

		public static Class23 smethod_1(Class23 class23_0)
		{
			return new D9240419(0f - class23_0.C513208F());
		}

		public override IntPtr FC1A08AE()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)B232411F) : ((long)B232411F));
		}

		public override Class23 F7B8C78E()
		{
			return new D9240419(B232411F);
		}

		public override UIntPtr C099D01E()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((uint)B232411F) : ((ulong)B232411F));
		}

		public override short vmethod_9()
		{
			return (short)B232411F;
		}

		public override ulong vmethod_6()
		{
			return (ulong)B232411F;
		}

		public override char DE8559A6()
		{
			return (char)B232411F;
		}

		public override long EA2A0215()
		{
			return (long)B232411F;
		}

		public static Class23 F816DE86(Class23 E70BF638)
		{
			return new D9240419(E70BF638.C513208F());
		}

		public override byte vmethod_5()
		{
			return (byte)B232411F;
		}

		public override object CF390C18()
		{
			return B232411F;
		}

		public override float C513208F()
		{
			return B232411F;
		}

		public override uint E318E528()
		{
			return (uint)B232411F;
		}

		public static Class23 smethod_2(Class23 class23_0, Class23 class23_1)
		{
			float num = class23_0.C513208F();
			float num2 = class23_1.C513208F();
			return new D9240419(num + num2);
		}

		public override int vmethod_1()
		{
			return (int)B232411F;
		}

		public override ushort vmethod_10()
		{
			return (ushort)B232411F;
		}

		public override void vmethod_11(object C00B442E)
		{
			B232411F = Convert.ToSingle(C00B442E);
		}

		public static Class23 smethod_3(Class23 class23_0, Class23 class23_1)
		{
			float num = class23_0.C513208F();
			float num2 = class23_1.C513208F();
			return new D9240419(num % num2);
		}

		public override sbyte vmethod_12()
		{
			return (sbyte)B232411F;
		}

		public override bool BEA0701B()
		{
			return Convert.ToBoolean(B232411F);
		}

		public static Class23 smethod_4(Class23 class23_0)
		{
			ulong num = class23_0.vmethod_6();
			return new D9240419((((uint)class23_0.vmethod_0() & (true ? 1u : 0u)) != 0) ? ((float)num) : ((float)(long)num));
		}

		public override double vmethod_3()
		{
			return B232411F;
		}

		public static Class23 smethod_5(Class23 class23_0, Class23 B58D4B2E)
		{
			float num = class23_0.C513208F();
			float num2 = B58D4B2E.C513208F();
			int num3 = 0;
			if (num == num2)
			{
				num3 |= 2;
			}
			else if (num < num2)
			{
				num3 |= 8;
			}
			return new Class26(num3);
		}

		public static Class23 smethod_6(Class23 class23_0, Class23 class23_1)
		{
			float num = class23_0.C513208F();
			float num2 = class23_1.C513208F();
			return new D9240419(num / num2);
		}

		public D9240419(float float_0)
		{
			B232411F = float_0;
		}
	}

	private sealed class Class31 : B53794AC
	{
		private Type type_0;

		private IntPtr intptr_0;

		public override double vmethod_3()
		{
			return BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0);
		}

		public override long EA2A0215()
		{
			return Marshal.ReadInt64(intptr_0);
		}

		public override short vmethod_9()
		{
			return Marshal.ReadInt16(intptr_0);
		}

		public override IntPtr FC1A08AE()
		{
			return new IntPtr((IntPtr.Size == 4) ? Marshal.ReadInt32(intptr_0) : Marshal.ReadInt64(intptr_0));
		}

		public override int vmethod_1()
		{
			return Marshal.ReadInt32(intptr_0);
		}

		public override ushort vmethod_10()
		{
			return (ushort)Marshal.ReadInt16(intptr_0);
		}

		public override Class23 F7B8C78E()
		{
			return new Class31(intptr_0, type_0);
		}

		public override void vmethod_11(object C00B442E)
		{
			if (C00B442E == null)
			{
				throw new ArgumentException();
			}
			if (type_0.IsValueType)
			{
				Marshal.StructureToPtr(C00B442E, intptr_0, fDeleteOld: false);
				return;
			}
			switch (Type.GetTypeCode(C00B442E.GetType()))
			{
			default:
				throw new ArgumentException();
			case TypeCode.Char:
				Marshal.WriteInt16(intptr_0, Convert.ToChar(C00B442E));
				break;
			case TypeCode.SByte:
				Marshal.WriteByte(intptr_0, (byte)Convert.ToSByte(C00B442E));
				break;
			case TypeCode.Byte:
				Marshal.WriteByte(intptr_0, Convert.ToByte(C00B442E));
				break;
			case TypeCode.Int16:
				Marshal.WriteInt16(intptr_0, Convert.ToInt16(C00B442E));
				break;
			case TypeCode.UInt16:
				Marshal.WriteInt16(intptr_0, (short)Convert.ToUInt16(C00B442E));
				break;
			case TypeCode.Int32:
				Marshal.WriteInt32(intptr_0, Convert.ToInt32(C00B442E));
				break;
			case TypeCode.UInt32:
				Marshal.WriteInt32(intptr_0, (int)Convert.ToUInt32(C00B442E));
				break;
			case TypeCode.Int64:
				Marshal.WriteInt64(intptr_0, Convert.ToInt64(C00B442E));
				break;
			case TypeCode.UInt64:
				Marshal.WriteInt64(intptr_0, (long)Convert.ToUInt64(C00B442E));
				break;
			case TypeCode.Single:
				Marshal.WriteInt32(intptr_0, BitConverter.ToInt32(BitConverter.GetBytes(Convert.ToSingle(C00B442E)), 0));
				break;
			case TypeCode.Double:
				Marshal.WriteInt64(intptr_0, BitConverter.ToInt64(BitConverter.GetBytes(Convert.ToDouble(C00B442E)), 0));
				break;
			}
		}

		public override uint E318E528()
		{
			return (uint)Marshal.ReadInt32(intptr_0);
		}

		public override ulong vmethod_6()
		{
			return (ulong)Marshal.ReadInt64(intptr_0);
		}

		public override UIntPtr C099D01E()
		{
			return new UIntPtr((ulong)((IntPtr.Size == 4) ? ((uint)Marshal.ReadInt32(intptr_0)) : Marshal.ReadInt64(intptr_0)));
		}

		public override byte vmethod_5()
		{
			return Marshal.ReadByte(intptr_0);
		}

		public override object CF390C18()
		{
			if (type_0.IsValueType)
			{
				return Marshal.PtrToStructure(intptr_0, type_0);
			}
			return Type.GetTypeCode(type_0) switch
			{
				TypeCode.Char => (char)Marshal.ReadInt16(intptr_0), 
				TypeCode.SByte => (sbyte)Marshal.ReadByte(intptr_0), 
				TypeCode.Byte => Marshal.ReadByte(intptr_0), 
				TypeCode.Int16 => Marshal.ReadInt16(intptr_0), 
				TypeCode.UInt16 => (ushort)Marshal.ReadInt16(intptr_0), 
				TypeCode.Int32 => Marshal.ReadInt32(intptr_0), 
				TypeCode.UInt32 => (uint)Marshal.ReadInt32(intptr_0), 
				TypeCode.Int64 => Marshal.ReadInt64(intptr_0), 
				TypeCode.UInt64 => (ulong)Marshal.ReadInt64(intptr_0), 
				TypeCode.Single => BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0), 
				TypeCode.Double => BitConverter.ToDouble(BitConverter.GetBytes(Marshal.ReadInt64(intptr_0)), 0), 
				_ => throw new ArgumentException(), 
			};
		}

		public override sbyte vmethod_12()
		{
			return (sbyte)Marshal.ReadByte(intptr_0);
		}

		public override float C513208F()
		{
			return BitConverter.ToSingle(BitConverter.GetBytes(Marshal.ReadInt32(intptr_0)), 0);
		}

		public override char DE8559A6()
		{
			return (char)Marshal.ReadInt16(intptr_0);
		}

		public override Type vmethod_2()
		{
			return typeof(Pointer);
		}

		public Class31(IntPtr intptr_1, Type B0089E2D)
		{
			intptr_0 = intptr_1;
			type_0 = B0089E2D;
		}
	}

	private sealed class Class32 : B53794AC
	{
		private Class23 class23_0;

		public override Class23 F7B8C78E()
		{
			return new Class32(class23_0);
		}

		public override object CF390C18()
		{
			return class23_0.CF390C18();
		}

		public override void F1840825(FieldInfo fieldInfo_0, object object_0)
		{
			class23_0.F1840825(fieldInfo_0, object_0);
		}

		public override void vmethod_11(object C00B442E)
		{
			class23_0.vmethod_11(C00B442E);
		}

		public override Type vmethod_2()
		{
			return class23_0.vmethod_2();
		}

		public override object vmethod_4(FieldInfo D0117407)
		{
			return class23_0.vmethod_4(D0117407);
		}

		public Class32(Class23 class23_1)
		{
			class23_0 = class23_1;
		}
	}

	private sealed class Class35 : Class24
	{
		private double double_0;

		public override void vmethod_11(object C00B442E)
		{
			double_0 = (double)C00B442E;
		}

		public override ushort vmethod_10()
		{
			return (ushort)double_0;
		}

		public override byte vmethod_5()
		{
			return (byte)double_0;
		}

		public override bool BEA0701B()
		{
			return Convert.ToBoolean(double_0);
		}

		public override IntPtr FC1A08AE()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)double_0) : ((long)double_0));
		}

		public override Class23 F7B8C78E()
		{
			return new Class35(double_0);
		}

		public static Class23 smethod_1(Class23 class23_0)
		{
			double num = class23_0.vmethod_3();
			ulong num2 = (ulong)(long)num;
			int num3 = 0;
			if (((uint)class23_0.vmethod_0() & (true ? 1u : 0u)) != 0)
			{
				if (!(num > -1.0) || !(num < 1.8446744073709552E+19))
				{
					num3 |= 0x40;
				}
				if (!((double)num2 < 9.223372036854776E+18))
				{
					num2 = (ulong)((double)(long)num2 - 9.223372036854776E+18) + 9223372036854775808uL;
				}
			}
			else if (!(num > -9.223372036854778E+18) || !(num < 9.223372036854776E+18))
			{
				num3 |= 0x40;
			}
			class23_0 = new E12B7BBC((long)num2);
			class23_0.vmethod_8(num3);
			return class23_0;
		}

		public override int vmethod_1()
		{
			return (int)double_0;
		}

		public override char DE8559A6()
		{
			return (char)double_0;
		}

		public override uint E318E528()
		{
			return (uint)double_0;
		}

		public static Class23 smethod_2(Class23 class23_0, Class23 F184443C)
		{
			double num = class23_0.vmethod_3();
			double num2 = F184443C.vmethod_3();
			return new Class35(num + num2);
		}

		public static Class23 smethod_3(Class23 class23_0)
		{
			return new Class35(class23_0.vmethod_3());
		}

		public static Class23 smethod_4(Class23 B621419C, Class23 class23_0)
		{
			double num = B621419C.vmethod_3();
			double num2 = class23_0.vmethod_3();
			return new Class35(num % num2);
		}

		public override object CF390C18()
		{
			return double_0;
		}

		public override sbyte vmethod_12()
		{
			return (sbyte)double_0;
		}

		public override double vmethod_3()
		{
			return double_0;
		}

		public override Type vmethod_2()
		{
			return typeof(double);
		}

		public static Class23 smethod_5(Class23 class23_0)
		{
			return new Class35(0.0 - class23_0.vmethod_3());
		}

		public override short vmethod_9()
		{
			return (short)double_0;
		}

		public static Class23 smethod_6(Class23 class23_0, Class23 class23_1)
		{
			double num = class23_0.vmethod_3();
			double num2 = class23_1.vmethod_3();
			return new Class35(num / num2);
		}

		public override float C513208F()
		{
			return (float)double_0;
		}

		public override long EA2A0215()
		{
			return (long)double_0;
		}

		public static Class23 smethod_7(Class23 class23_0, Class23 class23_1)
		{
			double num = class23_0.vmethod_3();
			double num2 = class23_1.vmethod_3();
			return new Class35(num * num2);
		}

		public override ulong vmethod_6()
		{
			return (ulong)double_0;
		}

		public static Class23 FEBADD13(Class23 class23_0, Class23 class23_1)
		{
			double num = class23_0.vmethod_3();
			double num2 = class23_1.vmethod_3();
			int num3 = 0;
			if (num == num2)
			{
				num3 |= 2;
			}
			else if (num < num2)
			{
				num3 |= 8;
			}
			return new Class26(num3);
		}

		public static Class23 smethod_8(Class23 class23_0)
		{
			ulong num = class23_0.vmethod_6();
			return new Class35((((uint)class23_0.vmethod_0() & (true ? 1u : 0u)) != 0) ? ((double)num) : ((double)(long)num));
		}

		public override UIntPtr C099D01E()
		{
			return new UIntPtr((IntPtr.Size == 4) ? ((uint)double_0) : ((ulong)double_0));
		}

		public Class35(double B0B49307)
		{
			double_0 = B0B49307;
		}
	}

	private sealed class Class36 : Class24
	{
		private object object_0;

		public override object CF390C18()
		{
			return object_0;
		}

		public static Class23 D288991D(Class23 B4358F06, Class23 E8AB0514)
		{
			object obj = B4358F06.CF390C18();
			object obj2 = E8AB0514.CF390C18();
			int num = 0;
			if (obj == obj2)
			{
				num |= 2;
			}
			else if (obj == null)
			{
				num |= 8;
			}
			return new Class26(num);
		}

		public override Class23 F7B8C78E()
		{
			return new Class36(object_0);
		}

		public override void vmethod_11(object C00B442E)
		{
			object_0 = C00B442E;
		}

		public override Type vmethod_2()
		{
			return typeof(object);
		}

		public Class36(object E3A92508)
		{
			object_0 = E3A92508;
		}
	}

	private sealed class D107D99F
	{
		private Type[] F5B2C3BD;

		private Type type_0;

		private uint CA29D305;

		private Enum3 enum3_0;

		public CallingConvention CallingConvention_0 => (enum3_0 & Enum3.const_12) switch
		{
			Enum3.const_7 => CallingConvention.Cdecl, 
			Enum3.const_15 => CallingConvention.StdCall, 
			Enum3.CE98AB0F => CallingConvention.ThisCall, 
			Enum3.DDB52F16 => CallingConvention.FastCall, 
			_ => CallingConvention.Winapi, 
		};

		public bool Boolean_0
		{
			get
			{
				switch (enum3_0 & Enum3.const_12)
				{
				default:
					return false;
				case Enum3.const_6:
				case Enum3.const_7:
				case Enum3.const_15:
				case Enum3.CE98AB0F:
				case Enum3.DDB52F16:
				case Enum3.BC8F7E87:
				case Enum3.const_14:
				case Enum3.const_0:
					return true;
				}
			}
		}

		public Type Type_0 => type_0;

		public void F7054F23(byte[] byte_0, Module module_0)
		{
			EA188E0F eA188E0F = new EA188E0F(byte_0);
			enum3_0 = (Enum3)eA188E0F.method_0();
			if ((enum3_0 & Enum3.const_10) != 0)
			{
				CA29D305 = eA188E0F.method_1();
			}
			switch (enum3_0 & Enum3.const_12)
			{
			default:
				throw new COMException(null, -2146233799);
			case Enum3.const_5:
				type_0 = eA188E0F.method_2(module_0);
				break;
			case Enum3.const_3:
			case Enum3.const_4:
			{
				uint num2 = eA188E0F.method_1();
				F5B2C3BD = new Type[num2];
				for (int j = 0; j < num2; j++)
				{
					F5B2C3BD[j] = eA188E0F.method_2(module_0);
				}
				break;
			}
			case Enum3.const_6:
			case Enum3.const_7:
			case Enum3.const_15:
			case Enum3.CE98AB0F:
			case Enum3.DDB52F16:
			case Enum3.BC8F7E87:
			case Enum3.const_13:
			case Enum3.const_14:
			case Enum3.const_0:
			{
				uint num = eA188E0F.method_1();
				type_0 = eA188E0F.method_2(module_0);
				F5B2C3BD = new Type[num];
				for (int i = 0; i < num; i++)
				{
					F5B2C3BD[i] = eA188E0F.method_2(module_0);
				}
				break;
			}
			}
		}

		public Type[] method_0()
		{
			return F5B2C3BD;
		}
	}

	private abstract class Class23
	{
		private int int_0;

		public virtual int vmethod_0()
		{
			return int_0;
		}

		public virtual int vmethod_1()
		{
			return Convert.ToInt32(CF390C18());
		}

		public unsafe Class23 method_0(Type FCAED9B9)
		{
			if (FCAED9B9.IsEnum)
			{
				object obj = CF390C18();
				if (obj != null && !(obj is Enum))
				{
					obj = Enum.ToObject(FCAED9B9, obj);
				}
				return new A23ABDAF((Enum)obj);
			}
			switch (Type.GetTypeCode(FCAED9B9))
			{
			default:
				if (FCAED9B9 == typeof(IntPtr))
				{
					return new E00C7E2C(FC1A08AE());
				}
				if (FCAED9B9 == typeof(UIntPtr))
				{
					return new Class34(C099D01E());
				}
				if (FCAED9B9.IsValueType)
				{
					return new Class27(CF390C18());
				}
				if (FCAED9B9.IsPointer)
				{
					return new Class39(Pointer.Box(FC1A08AE().ToPointer(), FCAED9B9), FCAED9B9);
				}
				return new Class36(CF390C18());
			case TypeCode.Boolean:
				return new ED0084A1(BEA0701B());
			case TypeCode.Char:
				return new Class40(DE8559A6());
			case TypeCode.SByte:
				return new D73CC92E(vmethod_12());
			case TypeCode.Byte:
				return new Class41(vmethod_5());
			case TypeCode.Int16:
				return new Class42(vmethod_9());
			case TypeCode.UInt16:
				return new Class37(vmethod_10());
			case TypeCode.Int32:
				return new Class26(vmethod_1());
			case TypeCode.UInt32:
				return new Class38(E318E528());
			case TypeCode.Int64:
				return new E12B7BBC(EA2A0215());
			case TypeCode.UInt64:
				return new BC1CC939(vmethod_6());
			case TypeCode.Single:
				return new D9240419(C513208F());
			case TypeCode.Double:
				return new Class35(vmethod_3());
			}
		}

		public virtual Class24 AD0A99B1()
		{
			throw new InvalidOperationException();
		}

		public virtual Type vmethod_2()
		{
			throw new InvalidOperationException();
		}

		public virtual IntPtr FC1A08AE()
		{
			object obj = CF390C18();
			if (!(obj?.GetType() == typeof(IntPtr)))
			{
				throw new InvalidOperationException();
			}
			return (IntPtr)obj;
		}

		public virtual bool BEA0701B()
		{
			return Convert.ToBoolean(CF390C18());
		}

		public abstract object CF390C18();

		public unsafe static Class23 AF827BBA(object EE0412BF, Type type_0)
		{
			while (!type_0.IsEnum)
			{
				switch (Type.GetTypeCode(type_0))
				{
				case (TypeCode)(-637272042):
				case (TypeCode)(-637272037):
					continue;
				default:
					if (type_0 == typeof(IntPtr))
					{
						return new E00C7E2C((EE0412BF != null) ? ((IntPtr)EE0412BF) : IntPtr.Zero);
					}
					if (type_0 == typeof(UIntPtr))
					{
						return new Class34((EE0412BF != null) ? ((UIntPtr)EE0412BF) : UIntPtr.Zero);
					}
					if (type_0.IsValueType)
					{
						return new Class27(EE0412BF);
					}
					if (type_0.IsPointer)
					{
						return new Class39(Pointer.Box((EE0412BF != null) ? Pointer.Unbox(EE0412BF) : null, type_0), type_0);
					}
					return new Class36(EE0412BF);
				case (TypeCode)(-637272043):
					return new ED0084A1(Convert.ToBoolean(EE0412BF));
				case (TypeCode)(-637272041):
					return new D73CC92E(Convert.ToSByte(EE0412BF));
				case (TypeCode)(-637272040):
					return new Class41(Convert.ToByte(EE0412BF));
				case (TypeCode)(-637272039):
					return new Class42(Convert.ToInt16(EE0412BF));
				case (TypeCode)(-637272036):
					return new Class38(Convert.ToUInt32(EE0412BF));
				case (TypeCode)(-637272035):
					return new E12B7BBC(Convert.ToInt64(EE0412BF));
				case (TypeCode)(-637272038):
				case (TypeCode)(-637272034):
					break;
				case (TypeCode)(-637272033):
					return new D9240419(Convert.ToSingle(EE0412BF));
				case (TypeCode)(-637272032):
					return new Class35(Convert.ToDouble(EE0412BF));
				}
				break;
			}
			if (EE0412BF != null && !(EE0412BF is Enum))
			{
				EE0412BF = Enum.ToObject(type_0, EE0412BF);
			}
			return new A23ABDAF((Enum)EE0412BF);
		}

		public virtual double vmethod_3()
		{
			return Convert.ToDouble(CF390C18());
		}

		public virtual uint E318E528()
		{
			return Convert.ToUInt32(CF390C18());
		}

		public virtual object vmethod_4(FieldInfo D0117407)
		{
			object obj = CF390C18();
			if (obj != null && D0117407.DeclaringType.IsValueType && obj.GetType().IsPrimitive)
			{
				obj = Marshal.PtrToStructure(FC1A08AE(), D0117407.DeclaringType);
			}
			return D0117407.GetValue(obj);
		}

		public virtual char DE8559A6()
		{
			return Convert.ToChar(CF390C18());
		}

		public virtual byte vmethod_5()
		{
			return Convert.ToByte(CF390C18());
		}

		public virtual UIntPtr C099D01E()
		{
			object obj = CF390C18();
			if (!(obj?.GetType() == typeof(UIntPtr)))
			{
				throw new InvalidOperationException();
			}
			return (UIntPtr)obj;
		}

		public virtual float C513208F()
		{
			return Convert.ToSingle(CF390C18());
		}

		public virtual ulong vmethod_6()
		{
			return Convert.ToUInt64(CF390C18());
		}

		public virtual void F1840825(FieldInfo fieldInfo_0, object object_0)
		{
			object obj = CF390C18();
			if (obj != null && fieldInfo_0.DeclaringType.IsValueType && obj.GetType().IsPrimitive)
			{
				obj = Marshal.PtrToStructure(FC1A08AE(), fieldInfo_0.DeclaringType);
			}
			fieldInfo_0.SetValue(obj, object_0);
			if (obj is ValueType)
			{
				vmethod_11(obj);
			}
		}

		public static Class23 D1AB72BE(Class23 class23_0)
		{
			int num = 0;
			if (((uint)class23_0.vmethod_0() & (true ? 1u : 0u)) != 0)
			{
				float f = class23_0.C513208F();
				if (float.IsNaN(f) || float.IsInfinity(f))
				{
					num |= 0x40;
				}
			}
			else
			{
				double d = class23_0.vmethod_3();
				if (double.IsNaN(d) || double.IsInfinity(d))
				{
					num |= 0x40;
				}
			}
			return new Class26(num);
		}

		public virtual bool vmethod_7()
		{
			return false;
		}

		public virtual void vmethod_8(int int_1)
		{
			int_0 = int_1;
		}

		public virtual long EA2A0215()
		{
			return Convert.ToInt64(CF390C18());
		}

		public static Class23 smethod_0(Class23 class23_0, Type ECB3E3A4)
		{
			object obj = class23_0.CF390C18();
			int num = 0;
			if (obj == null)
			{
				num |= 2;
			}
			else
			{
				Type type = obj.GetType();
				if (type == ECB3E3A4 || ECB3E3A4.IsAssignableFrom(type))
				{
					num |= 0x43A626C;
				}
			}
			return new Class26(num);
		}

		public virtual short vmethod_9()
		{
			return Convert.ToInt16(CF390C18());
		}

		public virtual ushort vmethod_10()
		{
			return Convert.ToUInt16(CF390C18());
		}

		public abstract void vmethod_11(object C00B442E);

		public virtual sbyte vmethod_12()
		{
			return Convert.ToSByte(CF390C18());
		}

		public abstract Class23 F7B8C78E();
	}

	private abstract class C0AA4D3D
	{
		public abstract void C2A7D395(int C5265086);

		public abstract int A4991292();
	}

	private sealed class Class41 : Class23
	{
		private byte byte_0;

		public override object CF390C18()
		{
			return byte_0;
		}

		public override uint E318E528()
		{
			return byte_0;
		}

		public override Type vmethod_2()
		{
			return typeof(byte);
		}

		public override Class24 AD0A99B1()
		{
			return new Class26(vmethod_1());
		}

		public override short vmethod_9()
		{
			return byte_0;
		}

		public override void vmethod_11(object C00B442E)
		{
			byte_0 = Convert.ToByte(C00B442E);
		}

		public override int vmethod_1()
		{
			return byte_0;
		}

		public override sbyte vmethod_12()
		{
			return (sbyte)byte_0;
		}

		public override byte vmethod_5()
		{
			return byte_0;
		}

		public static Class23 E83AE184(Class23 B70757A4)
		{
			ulong num = B70757A4.vmethod_6();
			bool num2 = (B70757A4.vmethod_0() & 1) != 0;
			int num3 = 0;
			if (num2)
			{
				if (num > 255L)
				{
					num3 |= 0x40;
				}
			}
			else if (num > 127L)
			{
				num3 |= 0x40;
			}
			B70757A4 = new Class26((byte)num);
			B70757A4.vmethod_8(num3);
			return B70757A4;
		}

		public override Class23 F7B8C78E()
		{
			return new Class41(byte_0);
		}

		public override ushort vmethod_10()
		{
			return byte_0;
		}

		public Class41(byte F435F6A7)
		{
			byte_0 = F435F6A7;
		}
	}

	private sealed class E12B7BBC : Class24
	{
		private long long_0;

		public override uint E318E528()
		{
			return (uint)long_0;
		}

		public override object CF390C18()
		{
			return long_0;
		}

		public override int vmethod_1()
		{
			return (int)long_0;
		}

		public override void vmethod_11(object C00B442E)
		{
			long_0 = Convert.ToInt64(C00B442E);
		}

		public static Class23 smethod_1(Class23 class23_0, Class23 AE91948C)
		{
			int num = 0;
			if (((uint)AE91948C.vmethod_0() & (true ? 1u : 0u)) != 0)
			{
				ulong num2 = class23_0.vmethod_6();
				ulong num3 = AE91948C.vmethod_6();
				if (num2 == num3)
				{
					num |= 2;
				}
				else if (num2 < num3)
				{
					num |= 8;
				}
			}
			else
			{
				long num4 = class23_0.EA2A0215();
				long num5 = AE91948C.EA2A0215();
				if (num4 == num5)
				{
					num |= 2;
				}
				else if (num4 < num5)
				{
					num |= 8;
				}
			}
			return new Class26(num);
		}

		public override IntPtr FC1A08AE()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((int)long_0) : long_0);
		}

		public static Class23 smethod_2(Class23 B51A4395, Class23 class23_0)
		{
			long long_;
			if (((uint)class23_0.vmethod_0() & (true ? 1u : 0u)) != 0)
			{
				ulong num = B51A4395.vmethod_6();
				ulong num2 = class23_0.vmethod_6();
				long_ = (long)(num / num2);
			}
			else
			{
				long num3 = B51A4395.EA2A0215();
				long num4 = class23_0.EA2A0215();
				long_ = num3 / num4;
			}
			return new E12B7BBC(long_);
		}

		public static Class23 smethod_3(Class23 AD8C5494, Class23 class23_0)
		{
			if (((uint)class23_0.vmethod_0() & (true ? 1u : 0u)) != 0)
			{
				ulong num = AD8C5494.vmethod_6();
				ulong num2 = class23_0.vmethod_6();
				return new E12B7BBC((long)(num % num2));
			}
			long num3 = AD8C5494.EA2A0215();
			long num4 = class23_0.EA2A0215();
			return new E12B7BBC(num3 % num4);
		}

		public override UIntPtr C099D01E()
		{
			return new UIntPtr((ulong)((UIntPtr.Size == 4) ? ((uint)long_0) : long_0));
		}

		public static Class23 DD8C0E35(Class23 A3AC1A3A, Class23 class23_0)
		{
			if (((uint)class23_0.vmethod_0() & (true ? 1u : 0u)) != 0)
			{
				ulong num = A3AC1A3A.vmethod_6();
				int num2 = class23_0.vmethod_1();
				return new E12B7BBC((long)(num >> num2));
			}
			long num3 = A3AC1A3A.EA2A0215();
			int num4 = class23_0.vmethod_1();
			return new E12B7BBC(num3 >> num4);
		}

		public override byte vmethod_5()
		{
			return (byte)long_0;
		}

		public static Class23 smethod_4(Class23 class23_0, Class23 class23_1)
		{
			ulong num = class23_0.vmethod_6();
			ulong num2 = class23_1.vmethod_6();
			ulong num3 = num * num2;
			E12B7BBC e12B7BBC = new E12B7BBC((long)num3);
			int num4 = 0;
			if (((num ^ num3) & (num2 ^ num3) & 0x80000000L) != 0L)
			{
				num4 |= 0x40;
			}
			if (((num ^ ((num ^ num2) & (num2 ^ num3))) & 0x80000000L) != 0L)
			{
				num4 |= 0x20;
			}
			if (((uint)class23_1.vmethod_0() & (true ? 1u : 0u)) != 0)
			{
				ulong num5 = num & 0xFFFFFFFFuL;
				ulong num6 = num >> 32;
				ulong num7 = num2 & 0xFFFFFFFFuL;
				ulong num8 = num2 >> 32;
				ulong num9 = num5 * num7;
				num9 = num6 * num7 + (num9 >> 32);
				ulong num10 = num9 & 0xFFFFFFFFL;
				ulong num11 = num9 >> 32;
				num9 = num10 + num5 * num8;
				num9 = num11 + num6 * num8 + (num9 >> 32);
				if (num9 != 0L)
				{
					num4 |= 0x20;
				}
			}
			e12B7BBC.vmethod_8(num4);
			return e12B7BBC;
		}

		public override Class23 F7B8C78E()
		{
			E12B7BBC e12B7BBC = new E12B7BBC(long_0);
			e12B7BBC.vmethod_8(vmethod_0());
			return e12B7BBC;
		}

		public override char DE8559A6()
		{
			return (char)long_0;
		}

		public override float C513208F()
		{
			return long_0;
		}

		public override double vmethod_3()
		{
			return long_0;
		}

		public override Type vmethod_2()
		{
			return typeof(long);
		}

		public override long EA2A0215()
		{
			return long_0;
		}

		public static Class23 F2829A8C(Class23 class23_0, Class23 class23_1)
		{
			ulong num = ~class23_0.vmethod_6();
			ulong num2 = ~class23_1.vmethod_6();
			ulong num3 = num | num2;
			E12B7BBC e12B7BBC = new E12B7BBC((long)num3);
			int num4 = 0;
			if (num3 == 0L)
			{
				num4 |= 2;
			}
			else if (num3 >> 63 != 0L)
			{
				num4 |= 8;
			}
			e12B7BBC.vmethod_8(num4);
			return e12B7BBC;
		}

		public static Class23 smethod_5(Class23 class23_0, Class23 class23_1)
		{
			ulong num = ~class23_0.vmethod_6();
			ulong num2 = ~class23_1.vmethod_6();
			ulong num3 = num & num2;
			E12B7BBC e12B7BBC = new E12B7BBC((long)num3);
			int num4 = 0;
			if (num3 == 0L)
			{
				num4 |= 2;
			}
			else if (num3 >> 63 != 0L)
			{
				num4 |= 8;
			}
			e12B7BBC.vmethod_8(num4);
			return e12B7BBC;
		}

		public override short vmethod_9()
		{
			return (short)long_0;
		}

		public static Class23 smethod_6(Class23 class23_0, Class23 class23_1)
		{
			long num = class23_0.EA2A0215();
			int num2 = class23_1.vmethod_1();
			return new E12B7BBC(num << num2);
		}

		public override bool BEA0701B()
		{
			return (ulong)long_0 > 0uL;
		}

		public override ushort vmethod_10()
		{
			return (ushort)long_0;
		}

		public static Class23 smethod_7(Class23 class23_0)
		{
			return new E12B7BBC((long)class23_0.vmethod_6());
		}

		public static Class23 smethod_8(Class23 class23_0, Class23 class23_1)
		{
			ulong num = class23_0.vmethod_6();
			ulong num2 = class23_1.vmethod_6();
			ulong num3 = num + num2;
			E12B7BBC e12B7BBC = new E12B7BBC((long)num3);
			int num4 = 0;
			if (((num ^ num3) & (num2 ^ num3) & 0x80000000L) != 0L)
			{
				num4 |= 0x40;
			}
			if (((num ^ ((num ^ num2) & (num2 ^ num3))) & 0x80000000L) != 0L)
			{
				num4 |= 0x20;
			}
			e12B7BBC.vmethod_8(num4);
			return e12B7BBC;
		}

		public override sbyte vmethod_12()
		{
			return (sbyte)long_0;
		}

		public override ulong vmethod_6()
		{
			return (ulong)long_0;
		}

		public E12B7BBC(long long_1)
		{
			long_0 = long_1;
		}
	}

	private sealed class Class42 : Class23
	{
		private short short_0;

		public override ushort vmethod_10()
		{
			return (ushort)short_0;
		}

		public override Class24 AD0A99B1()
		{
			return new Class26(vmethod_1());
		}

		public override sbyte vmethod_12()
		{
			return (sbyte)short_0;
		}

		public override void vmethod_11(object C00B442E)
		{
			short_0 = Convert.ToInt16(C00B442E);
		}

		public override int vmethod_1()
		{
			return short_0;
		}

		public override short vmethod_9()
		{
			return short_0;
		}

		public override uint E318E528()
		{
			return (uint)short_0;
		}

		public override Type vmethod_2()
		{
			return typeof(short);
		}

		public override Class23 F7B8C78E()
		{
			return new Class42(short_0);
		}

		public override object CF390C18()
		{
			return short_0;
		}

		public static Class23 D7BBA627(Class23 class23_0)
		{
			ulong num = class23_0.vmethod_6();
			bool flag = (class23_0.vmethod_0() & 1) != 0;
			int num2 = 0;
			if (num > 32767L || (!flag && (short)num < short.MinValue))
			{
				num2 |= 0x40;
			}
			class23_0 = new Class26((short)num);
			class23_0.vmethod_8(num2);
			return class23_0;
		}

		public override byte vmethod_5()
		{
			return (byte)short_0;
		}

		public Class42(short short_1)
		{
			short_0 = short_1;
		}
	}

	private static readonly Module F7355C30 = typeof(GClass8).Module;

	private List<IntPtr> B73FBEAA = new List<IntPtr>();

	private Class44 class44_0 = new Class44();

	private Exception exception_0;

	private D133C38F d133C38F_0;

	private static readonly Dictionary<object, DynamicMethod> E1854BA8 = new Dictionary<object, DynamicMethod>();

	private Class43 class43_0 = new Class43();

	private static readonly Dictionary<uint, object> dictionary_0 = new Dictionary<uint, object>();

	private C0363D38 B32F5EA4 = new C0363D38();

	private readonly Dictionary<uint, Delegate10> dictionary_1 = new Dictionary<uint, Delegate10>();

	private void method_0()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class26.smethod_1(class23_2, class23_));
	}

	private void method_1()
	{
		Class23 dB030E0D = B32F5EA4.F62DB9AC();
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E00C7E2C.F9996DBB(class23_, dB030E0D));
	}

	private void D2A8D3BC()
	{
		B32F5EA4.F928DA32(B32F5EA4.D19DE917().F7B8C78E());
	}

	private void D9B6A48E()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 b621419C = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class35.smethod_4(b621419C, class23_));
	}

	private void method_2()
	{
		Type fCAED9B = D984C52B(class43_0.method_3());
		Class23 @class = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(new Class36(@class.method_0(fCAED9B).CF390C18()));
	}

	private void E1A969B0()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(D9240419.D584A205(class23_2, class23_));
	}

	private void method_3()
	{
		Class23 b58D4B2E = B32F5EA4.F62DB9AC();
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(D9240419.smethod_5(class23_, b58D4B2E));
	}

	private void CF06093E()
	{
		object e3A = method_5(class43_0.method_3());
		B32F5EA4.F928DA32(new Class36(e3A));
	}

	private void method_4()
	{
		Class23 @class = B32F5EA4.F62DB9AC();
		Class23 class2 = B32F5EA4.F62DB9AC();
		@class.vmethod_11(class2.method_0(@class.vmethod_2()).CF390C18());
	}

	private unsafe object method_5(int A6ABE499)
	{
		if (A6ABE499 == 0)
		{
			return null;
		}
		lock (dictionary_0)
		{
			uint key = (uint)A6ABE499 | 0x80000000u;
			if (dictionary_0.TryGetValue(key, out var value))
			{
				return value;
			}
			byte* ptr = (byte*)(void*)Class46.smethod_1((uint)A6ABE499);
			int num = *(int*)ptr ^ 0x268DE139;
			string text;
			if (num == 0)
			{
				text = string.Empty;
			}
			else
			{
				ptr += 4;
				byte[] array = new byte[num];
				for (int i = 0; i < num; i++)
				{
					array[i] = (byte)(ptr[i] ^ ((uint)(646832441 << i) | (646832441u >> 32 - i)));
				}
				text = Encoding.UTF8.GetString(array);
			}
			dictionary_0.Add(key, text);
			return text;
		}
	}

	private void BEAF5CB0()
	{
		int num = class43_0.method_3();
		class43_0.method_9(B32F5EA4.F62DB9AC().vmethod_1());
		List<int> list = new List<int>();
		while (class44_0.method_1() != 0 && num > class44_0.A91B7B8D().method_0())
		{
			List<D133C38F> list2 = class44_0.method_0().F68C40A8();
			for (int i = 0; i < list2.Count; i++)
			{
				D133C38F d133C38F = list2[i];
				if (d133C38F.method_0() == 2)
				{
					list.Add(d133C38F.D514F0AD());
				}
			}
		}
		for (int num2 = list.Count; num2 > 0; num2--)
		{
			class43_0.method_9(list[num2 - 1]);
		}
		exception_0 = null;
		B32F5EA4.D590F00B();
		class43_0.method_2();
	}

	private void method_6()
	{
		B32F5EA4.F62DB9AC();
	}

	private void method_7()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 b51A = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E12B7BBC.smethod_2(b51A, class23_));
	}

	private void CF815DB7()
	{
		Type eCB3E3A = D984C52B(class43_0.method_3());
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class23.smethod_0(class23_, eCB3E3A));
	}

	private void AF1D4D23()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class42.D7BBA627(class23_));
	}

	private void method_8()
	{
		FieldInfo a79F = method_50(class43_0.method_3());
		B32F5EA4.F928DA32(new Class30(a79F, this));
	}

	private void FABFD891()
	{
		Class23 aE91948C = B32F5EA4.F62DB9AC();
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E12B7BBC.smethod_1(class23_, aE91948C));
	}

	private void method_9()
	{
		Class23 f184443C = B32F5EA4.F62DB9AC();
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class35.smethod_2(class23_, f184443C));
	}

	private void method_10()
	{
		throw (B32F5EA4.F62DB9AC().CF390C18() as Exception) ?? throw new ArgumentException();
	}

	private void method_11()
	{
		Class23 bA = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class26.smethod_8(bA));
	}

	private void method_12()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class35.smethod_1(class23_));
	}

	private void method_13()
	{
		if (B32F5EA4.F62DB9AC().vmethod_1() != 0)
		{
			class44_0.method_0();
			B32F5EA4.F928DA32(new Class36(exception_0));
			class43_0.C2A7D395(d133C38F_0.D514F0AD());
			d133C38F_0 = null;
		}
		else
		{
			FAA6B788();
		}
	}

	private void C60D31AC()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E12B7BBC.smethod_8(class23_2, class23_));
	}

	private void method_14()
	{
		Class23 d3B3D = B32F5EA4.F62DB9AC();
		Class23 bD9441B = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class26.smethod_4(bD9441B, d3B3D));
	}

	private void method_15()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 cB8F8B3E = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class26.smethod_5(cB8F8B3E, class23_));
	}

	private void BA9E2021()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(D9240419.smethod_1(class23_));
	}

	private void B603B715()
	{
		Class23 fEA = B32F5EA4.F62DB9AC();
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E00C7E2C.smethod_1(class23_, fEA));
	}

	private void method_16()
	{
		if (exception_0 == null)
		{
			throw new InvalidOperationException();
		}
		throw exception_0;
	}

	private void method_17()
	{
		Class23 bF882C2F = B32F5EA4.F62DB9AC();
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class26.smethod_2(class23_, bF882C2F));
	}

	private void F985E90B()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class35.smethod_6(class23_2, class23_));
	}

	private void method_18()
	{
		Type type = D984C52B(class43_0.method_3());
		object obj = B32F5EA4.F62DB9AC().CF390C18();
		Type type2 = obj.GetType();
		if (type2 != type && !type.IsAssignableFrom(type2))
		{
			throw new InvalidCastException();
		}
		B32F5EA4.F928DA32(Class23.AF827BBA(obj, type));
	}

	private void BBBBEC1A()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E12B7BBC.smethod_6(class23_2, class23_));
	}

	private void method_19()
	{
		Class23 @class = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(new Class26(@class.vmethod_0()));
	}

	private void method_20()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 fF9F7E = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E00C7E2C.smethod_2(fF9F7E, class23_));
	}

	private void method_21()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(BC1CC939.E584080A(class23_));
	}

	private void D432CC36()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(D9240419.smethod_4(class23_));
	}

	private void method_22()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class26.smethod_3(class23_2, class23_));
	}

	private void method_23()
	{
		short aD8B = class43_0.method_6();
		Type type = D984C52B(B32F5EA4.F62DB9AC().vmethod_1());
		Class23 @class = B32F5EA4.F62DB9AC();
		Class23 class2 = B32F5EA4.F62DB9AC();
		object obj = class2.CF390C18();
		if (obj == null && type.IsValueType)
		{
			obj = Activator.CreateInstance(type);
		}
		class2 = Class23.AF827BBA(obj, type);
		if (@class.vmethod_7())
		{
			class2 = new Class29(class2, @class);
		}
		B32F5EA4.method_0(aD8B, class2);
	}

	private void AC3F6433()
	{
		int int_ = class43_0.method_8();
		B32F5EA4.D19DE917().vmethod_8(int_);
	}

	private void method_24()
	{
		Type type_ = D984C52B(class43_0.method_3());
		Class23 @class = B32F5EA4.F62DB9AC();
		if (!(B32F5EA4.F62DB9AC().CF390C18() is Array array))
		{
			throw new ArgumentException();
		}
		B32F5EA4.F928DA32(Class23.AF827BBA(array.GetValue(@class.vmethod_1()), type_));
	}

	private void B01E812E()
	{
		B32F5EA4.F928DA32(new D9240419(class43_0.method_5()));
	}

	private void method_25()
	{
		Class23 @class = B32F5EA4.F62DB9AC();
		if (!(B32F5EA4.F62DB9AC().CF390C18() is Array array_))
		{
			throw new ArgumentException();
		}
		B32F5EA4.F928DA32(new D329701F(array_, @class.vmethod_1()));
	}

	private void method_26()
	{
		short int_ = class43_0.method_6();
		Class23 @class = B32F5EA4.D33B742C(int_);
		if (@class.vmethod_7())
		{
			throw new ArgumentException();
		}
		B32F5EA4.F928DA32(new Class32(@class));
	}

	private void method_27()
	{
		Class23 cF9952A = B32F5EA4.F62DB9AC();
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E00C7E2C.C006E40C(class23_, cF9952A));
	}

	private void method_28()
	{
		Class23 @class = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(@class.method_0(@class.vmethod_2()));
	}

	private void FAA6B788()
	{
		B32F5EA4.D590F00B();
		class43_0.method_7();
		do
		{
			if (class44_0.method_1() != 0)
			{
				List<D133C38F> list = class44_0.A91B7B8D().F68C40A8();
				int num = ((d133C38F_0 != null) ? (list.IndexOf(d133C38F_0) + 1) : 0);
				d133C38F_0 = null;
				for (int i = num; i < list.Count; i++)
				{
					D133C38F d133C38F = list[i];
					switch (d133C38F.method_0())
					{
					case 0:
					{
						Type type = exception_0.GetType();
						Type type2 = D984C52B(d133C38F.method_1());
						if (type == type2 || type.IsSubclassOf(type2))
						{
							class44_0.method_0();
							B32F5EA4.F928DA32(new Class36(exception_0));
							class43_0.C2A7D395(d133C38F.D514F0AD());
							return;
						}
						break;
					}
					case 1:
						d133C38F_0 = d133C38F;
						B32F5EA4.F928DA32(new Class36(exception_0));
						class43_0.C2A7D395(d133C38F.method_1());
						return;
					}
				}
				class44_0.method_0();
				for (int num2 = list.Count; num2 > 0; num2--)
				{
					D133C38F d133C38F2 = list[num2 - 1];
					if (d133C38F2.method_0() == 2 || d133C38F2.method_0() == 4)
					{
						class43_0.method_9(d133C38F2.D514F0AD());
					}
				}
				continue;
			}
			throw exception_0;
		}
		while (class43_0.method_0() == 0);
		class43_0.method_2();
	}

	private void method_29()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class26.A48F0006(class23_2, class23_));
	}

	private void method_30()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class35.smethod_7(class23_2, class23_));
	}

	private void C1A737B1()
	{
		Class23 e8AB = B32F5EA4.F62DB9AC();
		Class23 b4358F = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class36.D288991D(b4358F, e8AB));
	}

	public object method_31(object[] C3281534, int B3898492)
	{
		class43_0.C2A7D395(B3898492);
		B32F5EA4.F928DA32(new Class36(C3281534));
		try
		{
			while (true)
			{
				try
				{
					dictionary_1[class43_0.method_10()]();
					if (class43_0.A4991292() == 0)
					{
						break;
					}
				}
				catch (Exception ex)
				{
					if (d133C38F_0 == null)
					{
						exception_0 = ex;
					}
					FAA6B788();
				}
			}
			return B32F5EA4.F62DB9AC().CF390C18();
		}
		finally
		{
			foreach (IntPtr item in B73FBEAA)
			{
				Marshal.FreeHGlobal(item);
			}
			B73FBEAA.Clear();
		}
	}

	private void method_32()
	{
		Type type = D984C52B(class43_0.method_3());
		DynamicMethod value;
		lock (E1854BA8)
		{
			if (!E1854BA8.TryGetValue(type, out value))
			{
				value = new DynamicMethod("", typeof(int), null, typeof(GClass8).Module, skipVisibility: true);
				ILGenerator iLGenerator = value.GetILGenerator();
				iLGenerator.Emit(OpCodes.Sizeof, type);
				iLGenerator.Emit(OpCodes.Ret);
				E1854BA8.Add(type, value);
			}
		}
		B32F5EA4.F928DA32(new Class26((int)value.Invoke(null, null)));
	}

	private void method_33()
	{
		Class23 e70BF = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(D9240419.F816DE86(e70BF));
	}

	private void DD0A11A7()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class38.AF2F28A0(class23_));
	}

	private void EE265715()
	{
		Type type = D984C52B(class43_0.method_3());
		Class23 @class = B32F5EA4.F62DB9AC();
		Class23 class2 = B32F5EA4.F62DB9AC();
		@class = @class.method_0(type);
		if (class2.vmethod_7())
		{
			if (class2.vmethod_2() != type)
			{
				@class = @class.method_0(class2.vmethod_2());
			}
		}
		else
		{
			class2 = new Class31(class2.FC1A08AE(), type);
		}
		class2.vmethod_11(@class.CF390C18());
	}

	private void FD8E5316()
	{
		Class23 @class = B32F5EA4.F62DB9AC();
		int num = @class.vmethod_1();
		MethodBase methodBase = E6AD6CA1(num);
		int num2 = @class.vmethod_0();
		Type[] array;
		if (methodBase.CallingConvention == CallingConventions.VarArgs)
		{
			D107D99F d107D99F = method_52(num);
			if (!d107D99F.Boolean_0)
			{
				throw new ArgumentException();
			}
			array = d107D99F.method_0();
		}
		else
		{
			ParameterInfo[] parameters = methodBase.GetParameters();
			array = new Type[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				array[i] = parameters[i].ParameterType;
			}
		}
		if (((uint)num2 & 4u) != 0)
		{
			MethodInfo method = D984C52B(B32F5EA4.F62DB9AC().vmethod_1()).GetMethod(methodBase.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod | BindingFlags.GetProperty | BindingFlags.SetProperty, null, array, null);
			if (method != null)
			{
				methodBase = method;
			}
		}
		BindingFlags invokeAttr = BindingFlags.Default;
		MethodInfo methodInfo = methodBase as MethodInfo;
		Dictionary<int, Class23> dictionary = new Dictionary<int, Class23>();
		object[] array2 = new object[array.Length];
		Class21 class2 = new Class21();
		try
		{
			Class23 class3 = null;
			if (((uint)num2 & (true ? 1u : 0u)) != 0)
			{
				class3 = B32F5EA4.F62DB9AC();
			}
			for (int num3 = array2.Length - 1; num3 >= 0; num3--)
			{
				Type type = array[num3];
				@class = B32F5EA4.F62DB9AC();
				if (@class.vmethod_7())
				{
					if (!type.IsByRef)
					{
						array2[num3] = class2.method_0(@class.CF390C18());
						continue;
					}
					dictionary[num3] = @class;
				}
				array2[num3] = @class.method_0(type).CF390C18();
			}
			if (class3 == null && !methodBase.IsStatic)
			{
				class3 = B32F5EA4.F62DB9AC();
			}
			object obj;
			if (class3 == null)
			{
				obj = null;
			}
			else
			{
				obj = class3.CF390C18();
				if (obj != null)
				{
					goto IL_0197;
				}
			}
			obj = null;
			goto IL_0197;
			IL_0197:
			object obj2 = obj;
			bool flag;
			if ((flag = (num2 & 0x10) != 0) && obj2 == null)
			{
				throw new NullReferenceException();
			}
			object eE0412BF = null;
			if (methodBase.CallingConvention == CallingConventions.VarArgs)
			{
				DynamicMethod value;
				lock (E1854BA8)
				{
					if (!E1854BA8.TryGetValue(num, out value))
					{
						int num4 = methodInfo.GetParameters().Length;
						Type[] array3 = new Type[array.Length - num4];
						Array.Copy(array, num4, array3, 0, array.Length - num4);
						value = new DynamicMethod("", (!(methodInfo != null) || !(methodInfo.ReturnType != typeof(void))) ? null : methodInfo.ReturnType, array, typeof(GClass8).Module, skipVisibility: true);
						ILGenerator iLGenerator = value.GetILGenerator();
						for (int j = 0; j < array.Length; j++)
						{
							iLGenerator.Emit(OpCodes.Ldarg, j);
						}
						iLGenerator.EmitCall(OpCodes.Call, methodInfo, array3);
						iLGenerator.Emit(OpCodes.Ret);
						E1854BA8.Add(num, value);
					}
				}
				eE0412BF = value.Invoke(null, invokeAttr, null, array2, null);
			}
			else if (!flag && methodBase.IsVirtual && !methodBase.IsFinal)
			{
				object[] array4 = new object[array.Length + 1];
				array4[0] = obj2;
				for (int k = 0; k < array.Length; k++)
				{
					array4[k + 1] = array2[k];
				}
				DynamicMethod value2;
				lock (E1854BA8)
				{
					if (!E1854BA8.TryGetValue(methodBase, out value2))
					{
						Type[] array5 = new Type[array4.Length];
						array5[0] = methodBase.DeclaringType;
						for (int l = 0; l < array.Length; l++)
						{
							array5[l + 1] = array[l];
						}
						value2 = new DynamicMethod("", (!(methodInfo != null) || !(methodInfo.ReturnType != typeof(void))) ? null : methodInfo.ReturnType, array5, typeof(GClass8).Module, skipVisibility: true);
						ILGenerator iLGenerator2 = value2.GetILGenerator();
						for (int m = 0; m < array5.Length; m++)
						{
							if (m == 0 && methodBase.DeclaringType.IsValueType)
							{
								iLGenerator2.Emit(OpCodes.Ldarga, m);
							}
							else
							{
								iLGenerator2.Emit(OpCodes.Ldarg, m);
							}
						}
						iLGenerator2.Emit(OpCodes.Call, methodInfo);
						iLGenerator2.Emit(OpCodes.Ret);
						E1854BA8.Add(methodBase, value2);
					}
				}
				eE0412BF = value2.Invoke(null, invokeAttr, null, array4, null);
				foreach (KeyValuePair<int, Class23> item in dictionary)
				{
					item.Value.vmethod_11(array4[item.Key + 1]);
				}
				dictionary.Clear();
			}
			else
			{
				if (methodBase.IsConstructor && methodBase.DeclaringType.IsValueType && Nullable.GetUnderlyingType(methodBase.DeclaringType) != null)
				{
					obj2 = ((ConstructorInfo)methodBase).Invoke(invokeAttr, null, array2, null);
				}
				else
				{
					eE0412BF = methodBase.Invoke(obj2, invokeAttr, null, array2, null);
				}
				if (class3 != null && class3.vmethod_7() && methodBase.DeclaringType.IsValueType)
				{
					class3.vmethod_11(obj2);
				}
			}
			foreach (KeyValuePair<int, Class23> item2 in dictionary)
			{
				item2.Value.vmethod_11(array2[item2.Key]);
			}
			if (methodInfo != null && methodInfo.ReturnType != typeof(void))
			{
				B32F5EA4.F928DA32(Class23.AF827BBA(eE0412BF, methodInfo.ReturnType));
			}
		}
		finally
		{
			class2.Dispose();
		}
	}

	private void method_34()
	{
		short int_ = class43_0.method_6();
		Class23 @class = B32F5EA4.D33B742C(int_);
		B32F5EA4.F928DA32(@class.F7B8C78E());
	}

	private void BB315903()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E12B7BBC.smethod_5(class23_2, class23_));
	}

	private void method_35()
	{
		byte eE164E2C = class43_0.method_8();
		int int_ = class43_0.method_3();
		int e4AEA48E = class43_0.method_3();
		int cE9272B = class43_0.method_3();
		int d93FB = class43_0.method_3();
		class44_0.DF81B78C(int_, e4AEA48E, eE164E2C, cE9272B, d93FB);
	}

	private void F6BD9B2F()
	{
		int num = class43_0.method_6();
		Class23 @class = B32F5EA4.F62DB9AC();
		if (num < 0)
		{
			B32F5EA4.method_0(num + B32F5EA4.A4991292(), @class);
			return;
		}
		Class23 class2 = B32F5EA4.D33B742C(num);
		if (class2 == null)
		{
			if (!@class.vmethod_7())
			{
				throw new ArgumentException();
			}
			B32F5EA4.method_0(num, @class);
		}
		else
		{
			class2.vmethod_11(@class.method_0(class2.vmethod_2()).CF390C18());
		}
	}

	private void method_36()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E12B7BBC.smethod_4(class23_2, class23_));
	}

	private void FA389892()
	{
		B32F5EA4.F928DA32(new E12B7BBC(class43_0.method_1()));
	}

	private MethodBase E6AD6CA1(int D5194395)
	{
		MemberInfo memberInfo = method_63(D5194395);
		if (!(memberInfo is MethodBase))
		{
			throw new InvalidOperationException();
		}
		return (MethodBase)memberInfo;
	}

	private void method_37()
	{
		MethodBase methodBase = E6AD6CA1(class43_0.method_3());
		object obj = B32F5EA4.F62DB9AC().CF390C18();
		if (obj != null)
		{
			Type type = obj.GetType();
			Type declaringType = methodBase.DeclaringType;
			ParameterInfo[] parameters = methodBase.GetParameters();
			Type[] array = new Type[parameters.Length];
			int num = 0;
			ParameterInfo[] array2 = parameters;
			foreach (ParameterInfo parameterInfo in array2)
			{
				array[num++] = parameterInfo.ParameterType;
			}
			while (type != null && type != declaringType)
			{
				MethodInfo method = type.GetMethod(methodBase.Name, BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.GetProperty | BindingFlags.SetProperty | BindingFlags.ExactBinding, null, CallingConventions.Any, array, null);
				if (!(method != null) || !(method.GetBaseDefinition() == methodBase))
				{
					type = type.BaseType;
					continue;
				}
				methodBase = method;
				break;
			}
		}
		B32F5EA4.F928DA32(new Class25(methodBase));
	}

	private void method_38()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class35.smethod_5(class23_));
	}

	private void CB30D5AA()
	{
		Type type = D984C52B(class43_0.method_3());
		Class23 @class = B32F5EA4.F62DB9AC();
		if (!@class.vmethod_7())
		{
			@class = new Class31(@class.FC1A08AE(), type);
		}
		B32F5EA4.F928DA32(@class.method_0(type));
	}

	private void method_39()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(new Class33(class23_));
	}

	private void method_40()
	{
		if (exception_0 == null)
		{
			class43_0.method_2();
		}
		else
		{
			FAA6B788();
		}
	}

	private Type D984C52B(int int_0)
	{
		MemberInfo memberInfo = method_63(int_0);
		if (!(memberInfo is Type))
		{
			throw new InvalidOperationException();
		}
		return (Type)memberInfo;
	}

	private void method_41()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E00C7E2C.smethod_7(class23_2, class23_));
	}

	private void method_42()
	{
		B32F5EA4.F928DA32(new Class26(class43_0.method_3()));
	}

	private void method_43()
	{
		Class23 cCB6A = B32F5EA4.F62DB9AC();
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class26.E528EABD(class23_, cCB6A));
	}

	private void method_44()
	{
		IntPtr intPtr = Marshal.AllocHGlobal(B32F5EA4.F62DB9AC().FC1A08AE());
		B73FBEAA.Add(intPtr);
		B32F5EA4.F928DA32(new E00C7E2C(intPtr));
	}

	private void method_45()
	{
		int int_ = class43_0.method_3();
		MemberInfo memberInfo = method_63(int_);
		if (memberInfo is Type)
		{
			B32F5EA4.F928DA32(new Class27(((Type)memberInfo).TypeHandle));
			return;
		}
		if (memberInfo is MethodBase)
		{
			B32F5EA4.F928DA32(new Class27(((MethodBase)memberInfo).MethodHandle));
			return;
		}
		if (!(memberInfo is FieldInfo))
		{
			throw new InvalidOperationException();
		}
		B32F5EA4.F928DA32(new Class27(((FieldInfo)memberInfo).FieldHandle));
	}

	private void method_46()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(D9240419.smethod_3(class23_2, class23_));
	}

	private void A78DAC85()
	{
		Class23 dEB26AB = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(D73CC92E.smethod_1(dEB26AB));
	}

	private void method_47()
	{
		Type type = D984C52B(class43_0.method_3());
		Class23 @class = B32F5EA4.F62DB9AC();
		Class23 class2 = B32F5EA4.F62DB9AC();
		Array obj = (B32F5EA4.F62DB9AC().CF390C18() as Array) ?? throw new ArgumentException();
		@class = @class.method_0(type);
		Type elementType = obj.GetType().GetElementType();
		if (type != elementType)
		{
			@class = @class.method_0(elementType);
		}
		obj.SetValue(@class.CF390C18(), class2.vmethod_1());
	}

	private void method_48()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(D9240419.smethod_2(class23_2, class23_));
	}

	private void D22DAD2B()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E00C7E2C.smethod_4(class23_));
	}

	private void B71A7314()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E12B7BBC.smethod_7(class23_));
	}

	private void D12F6F8E()
	{
		Type elementType = D984C52B(class43_0.method_3());
		B32F5EA4.F928DA32(new Class36(Array.CreateInstance(elementType, B32F5EA4.F62DB9AC().vmethod_1())));
	}

	private void method_49()
	{
		D107D99F d107D99F = method_52(class43_0.method_3());
		if (!d107D99F.Boolean_0)
		{
			throw new ArgumentException();
		}
		BindingFlags invokeAttr = BindingFlags.Default;
		Type[] array = d107D99F.method_0();
		Type[] array2 = new Type[array.Length + 1];
		array.CopyTo(array2, 0);
		array2[array.Length] = typeof(IntPtr);
		object[] array3 = new object[array2.Length];
		Dictionary<int, Class23> dictionary = new Dictionary<int, Class23>();
		Class21 @class = new Class21();
		try
		{
			for (int num = array3.Length - 1; num >= 0; num--)
			{
				Type type = array2[num];
				Class23 class2 = B32F5EA4.F62DB9AC();
				if (class2.vmethod_7())
				{
					if (!type.IsByRef)
					{
						array3[num] = @class.method_0(class2.CF390C18());
						continue;
					}
					dictionary[num] = class2;
				}
				array3[num] = class2.method_0(type).CF390C18();
			}
			DynamicMethod value;
			lock (E1854BA8)
			{
				if (!E1854BA8.TryGetValue(d107D99F, out value))
				{
					value = new DynamicMethod("", (d107D99F.Type_0 != typeof(void)) ? d107D99F.Type_0 : null, array2, typeof(GClass8).Module, skipVisibility: true);
					ILGenerator iLGenerator = value.GetILGenerator();
					for (int i = 0; i < array2.Length; i++)
					{
						iLGenerator.Emit(dictionary.ContainsKey(i) ? OpCodes.Ldarga : OpCodes.Ldarg, i);
					}
					iLGenerator.EmitCalli(OpCodes.Calli, d107D99F.CallingConvention_0, d107D99F.Type_0, array);
					iLGenerator.Emit(OpCodes.Ret);
					E1854BA8.Add(d107D99F, value);
				}
			}
			object eE0412BF = value.Invoke(null, invokeAttr, null, array3, null);
			foreach (KeyValuePair<int, Class23> item in dictionary)
			{
				item.Value.vmethod_11(array3[item.Key]);
			}
			if (d107D99F.Type_0 != typeof(void))
			{
				B32F5EA4.F928DA32(Class23.AF827BBA(eE0412BF, d107D99F.Type_0));
			}
		}
		finally
		{
			@class.Dispose();
		}
	}

	private FieldInfo method_50(int int_0)
	{
		MemberInfo memberInfo = method_63(int_0);
		if (!(memberInfo is FieldInfo))
		{
			throw new InvalidOperationException();
		}
		return (FieldInfo)memberInfo;
	}

	private void method_51()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class35.FEBADD13(class23_2, class23_));
	}

	private D107D99F method_52(int int_0)
	{
		lock (dictionary_0)
		{
			if (dictionary_0.TryGetValue(1073741824u, out var value))
			{
				return (D107D99F)value;
			}
			byte[] byte_ = F7355C30.ResolveSignature(int_0);
			D107D99F d107D99F = new D107D99F();
			d107D99F.F7054F23(byte_, F7355C30);
			dictionary_0.Add(1073741824u, d107D99F);
			return d107D99F;
		}
	}

	private void method_53()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(D9240419.smethod_6(class23_2, class23_));
	}

	private void method_54()
	{
		Class23 aC = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class34.smethod_1(aC));
	}

	private void B32B75B7()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 d190833B = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E00C7E2C.smethod_6(d190833B, class23_));
	}

	private void method_55()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 aD8C = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E12B7BBC.smethod_3(aD8C, class23_));
	}

	private void method_56()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E12B7BBC.F2829A8C(class23_2, class23_));
	}

	private void A5126CA8()
	{
		Class23 b70757A = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class41.E83AE184(b70757A));
	}

	private void A90783B4()
	{
		B32F5EA4.F928DA32(new Class35(class43_0.method_4()));
	}

	private void method_57()
	{
		Type type = D984C52B(class43_0.method_3());
		Class23 @class = B32F5EA4.F62DB9AC();
		object c00B442E = null;
		if (type.IsValueType && Nullable.GetUnderlyingType(type) == null)
		{
			c00B442E = FormatterServices.GetUninitializedObject(type);
		}
		@class.vmethod_11(c00B442E);
	}

	private void C0A172A4()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 b72C01B = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class26.smethod_6(b72C01B, class23_));
	}

	private void D1051C1D()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E00C7E2C.A0AE0E34(class23_2, class23_));
	}

	private void method_58()
	{
		FieldInfo fieldInfo_ = method_50(class43_0.method_3());
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(new Class28(fieldInfo_, class23_));
	}

	private void F18F6F92()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class37.smethod_1(class23_));
	}

	private void EE3600AC()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E00C7E2C.DEA45F0B(class23_2, class23_));
	}

	private void method_59()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class35.smethod_8(class23_));
	}

	private void D4000A3E()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 a3AC1A3A = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E12B7BBC.DD8C0E35(a3AC1A3A, class23_));
	}

	private void method_60()
	{
		if (!(B32F5EA4.F62DB9AC().CF390C18() is Array array))
		{
			throw new ArgumentException();
		}
		B32F5EA4.F928DA32(new Class26(array.Length));
	}

	private void method_61()
	{
		Class23 @class = B32F5EA4.F62DB9AC();
		Class43 class2 = new Class43();
		class2.C2A7D395(@class.vmethod_1());
		int num = @class.vmethod_0();
		ushort num2 = (ushort)class2.method_6();
		Dictionary<int, Class23> dictionary = new Dictionary<int, Class23>();
		object[] array = null;
		if (num2 > 0)
		{
			array = new object[num2];
			for (int num3 = num2 - 1; num3 >= 0; num3--)
			{
				@class = B32F5EA4.F62DB9AC();
				if (@class.vmethod_7())
				{
					dictionary[num3] = @class;
				}
				array[num3] = @class.method_0(D984C52B(class2.method_3())).CF390C18();
			}
		}
		int num4 = class2.method_3();
		if (((uint)num & 0x10u) != 0 && (array == null || array[0] == null))
		{
			throw new NullReferenceException();
		}
		class2.method_3();
		object eE0412BF = new GClass8().method_31(array, class2.A4991292());
		foreach (KeyValuePair<int, Class23> item in dictionary)
		{
			item.Value.vmethod_11(array[item.Key]);
		}
		if (num4 != 0)
		{
			Type type = D984C52B(num4);
			if (type != typeof(void))
			{
				B32F5EA4.F928DA32(Class23.AF827BBA(eE0412BF, type));
			}
		}
	}

	private void DA0184A2()
	{
		MethodBase methodBase = E6AD6CA1(class43_0.method_3());
		ParameterInfo[] parameters = methodBase.GetParameters();
		Dictionary<int, Class23> dictionary = new Dictionary<int, Class23>();
		object[] array = new object[parameters.Length];
		Class21 @class = new Class21();
		try
		{
			for (int num = parameters.Length - 1; num >= 0; num--)
			{
				Type parameterType = parameters[num].ParameterType;
				Class23 class2 = B32F5EA4.F62DB9AC();
				if (class2.vmethod_7())
				{
					if (!parameterType.IsByRef)
					{
						array[num] = @class.method_0(class2.CF390C18());
						continue;
					}
					dictionary[num] = class2;
				}
				array[num] = class2.method_0(parameterType).CF390C18();
			}
			object eE0412BF = ((ConstructorInfo)methodBase).Invoke(array);
			foreach (KeyValuePair<int, Class23> item in dictionary)
			{
				item.Value.vmethod_11(array[item.Key]);
			}
			B32F5EA4.F928DA32(Class23.AF827BBA(eE0412BF, methodBase.DeclaringType));
		}
		finally
		{
			@class.Dispose();
		}
	}

	private void method_62()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 d = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(E00C7E2C.smethod_5(d, class23_));
	}

	private MemberInfo method_63(int int_0)
	{
		lock (dictionary_0)
		{
			if (dictionary_0.TryGetValue((uint)int_0, out var value))
			{
				return (MemberInfo)value;
			}
			MemberInfo memberInfo = F7355C30.ResolveMember(int_0);
			dictionary_0.Add((uint)int_0, memberInfo);
			return memberInfo;
		}
	}

	private void method_64()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class23.D1AB72BE(class23_));
	}

	private void AB841694()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class35.smethod_3(class23_));
	}

	private void method_65()
	{
		Class23 class23_ = B32F5EA4.F62DB9AC();
		Class23 class23_2 = B32F5EA4.F62DB9AC();
		B32F5EA4.F928DA32(Class26.smethod_7(class23_2, class23_));
	}

	public GClass8()
	{
		dictionary_1[0u] = method_28;
		dictionary_1[1u] = D2A8D3BC;
		dictionary_1[2u] = method_57;
		dictionary_1[3u] = method_7;
		dictionary_1[4u] = F6BD9B2F;
		dictionary_1[5u] = AF1D4D23;
		dictionary_1[6u] = method_34;
		dictionary_1[7u] = method_35;
		dictionary_1[8u] = method_46;
		dictionary_1[9u] = method_17;
		dictionary_1[10u] = method_29;
		dictionary_1[11u] = EE265715;
		dictionary_1[12u] = method_11;
		dictionary_1[13u] = method_21;
		dictionary_1[14u] = method_0;
		dictionary_1[15u] = method_1;
		dictionary_1[16u] = EE3600AC;
		dictionary_1[17u] = method_23;
		dictionary_1[18u] = method_61;
		dictionary_1[19u] = method_15;
		dictionary_1[20u] = method_47;
		dictionary_1[21u] = method_4;
		dictionary_1[22u] = method_40;
		dictionary_1[23u] = A78DAC85;
		dictionary_1[24u] = C0A172A4;
		dictionary_1[25u] = FD8E5316;
		dictionary_1[26u] = F985E90B;
		dictionary_1[27u] = method_41;
		dictionary_1[28u] = method_56;
		dictionary_1[29u] = method_42;
		dictionary_1[30u] = method_30;
		dictionary_1[31u] = method_33;
		dictionary_1[32u] = A5126CA8;
		dictionary_1[33u] = BB315903;
		dictionary_1[34u] = BBBBEC1A;
		dictionary_1[35u] = FA389892;
		dictionary_1[36u] = method_17;
		dictionary_1[37u] = method_27;
		dictionary_1[38u] = method_43;
		dictionary_1[39u] = method_38;
		dictionary_1[40u] = method_48;
		dictionary_1[41u] = method_20;
		dictionary_1[42u] = method_59;
		dictionary_1[43u] = B71A7314;
		dictionary_1[44u] = C1A737B1;
		dictionary_1[45u] = method_32;
		dictionary_1[46u] = D12F6F8E;
		dictionary_1[47u] = method_64;
		dictionary_1[48u] = method_54;
		dictionary_1[49u] = B32B75B7;
		dictionary_1[50u] = BA9E2021;
		dictionary_1[51u] = method_9;
		dictionary_1[52u] = method_2;
		dictionary_1[53u] = method_51;
		dictionary_1[54u] = method_53;
		dictionary_1[55u] = method_3;
		dictionary_1[56u] = BEAF5CB0;
		dictionary_1[57u] = method_60;
		dictionary_1[58u] = CF06093E;
		dictionary_1[59u] = method_55;
		dictionary_1[60u] = CB30D5AA;
		dictionary_1[61u] = method_6;
		dictionary_1[62u] = method_26;
		dictionary_1[63u] = method_45;
		dictionary_1[64u] = E1A969B0;
		dictionary_1[65u] = method_12;
		dictionary_1[66u] = CF815DB7;
		dictionary_1[67u] = FABFD891;
		dictionary_1[68u] = AC3F6433;
		dictionary_1[69u] = method_24;
		dictionary_1[70u] = method_19;
		dictionary_1[71u] = method_25;
		dictionary_1[72u] = C60D31AC;
		dictionary_1[73u] = method_39;
		dictionary_1[74u] = method_37;
		dictionary_1[75u] = method_16;
		dictionary_1[76u] = DA0184A2;
		dictionary_1[77u] = DD0A11A7;
		dictionary_1[78u] = method_36;
		dictionary_1[79u] = method_22;
		dictionary_1[80u] = D22DAD2B;
		dictionary_1[81u] = A90783B4;
		dictionary_1[82u] = method_58;
		dictionary_1[83u] = method_13;
		dictionary_1[84u] = AB841694;
		dictionary_1[85u] = method_10;
		dictionary_1[86u] = D1051C1D;
		dictionary_1[87u] = B01E812E;
		dictionary_1[88u] = method_44;
		dictionary_1[89u] = D432CC36;
		dictionary_1[90u] = method_29;
		dictionary_1[91u] = D4000A3E;
		dictionary_1[92u] = F18F6F92;
		dictionary_1[93u] = method_49;
		dictionary_1[94u] = D9B6A48E;
		dictionary_1[95u] = method_18;
		dictionary_1[96u] = method_14;
		dictionary_1[97u] = method_8;
		dictionary_1[98u] = method_65;
		dictionary_1[99u] = D4000A3E;
		dictionary_1[100u] = method_8;
		dictionary_1[101u] = method_54;
		dictionary_1[102u] = BBBBEC1A;
		dictionary_1[103u] = method_42;
		dictionary_1[104u] = method_20;
		dictionary_1[105u] = method_65;
		dictionary_1[106u] = method_29;
		dictionary_1[107u] = method_25;
		dictionary_1[108u] = method_6;
		dictionary_1[109u] = E1A969B0;
		dictionary_1[110u] = method_65;
		dictionary_1[111u] = method_40;
		dictionary_1[112u] = C1A737B1;
		dictionary_1[113u] = method_40;
		dictionary_1[114u] = method_10;
		dictionary_1[115u] = method_7;
		dictionary_1[116u] = BB315903;
		dictionary_1[117u] = method_16;
		dictionary_1[118u] = method_6;
		dictionary_1[119u] = DD0A11A7;
		dictionary_1[120u] = method_8;
		dictionary_1[121u] = FABFD891;
		dictionary_1[122u] = FABFD891;
		dictionary_1[123u] = method_8;
		dictionary_1[124u] = method_29;
		dictionary_1[125u] = F985E90B;
		dictionary_1[126u] = D2A8D3BC;
		dictionary_1[127u] = EE265715;
		dictionary_1[128u] = method_33;
		dictionary_1[129u] = B32B75B7;
		dictionary_1[130u] = B32B75B7;
		dictionary_1[131u] = AB841694;
		dictionary_1[132u] = method_65;
		dictionary_1[133u] = method_34;
		dictionary_1[134u] = method_65;
		dictionary_1[135u] = AF1D4D23;
		dictionary_1[136u] = method_12;
		dictionary_1[137u] = method_20;
		dictionary_1[138u] = method_57;
		dictionary_1[139u] = method_14;
		dictionary_1[140u] = method_49;
		dictionary_1[141u] = method_29;
		dictionary_1[142u] = F985E90B;
		dictionary_1[143u] = method_37;
		dictionary_1[144u] = EE3600AC;
		dictionary_1[145u] = method_53;
		dictionary_1[146u] = method_65;
		dictionary_1[147u] = D1051C1D;
		dictionary_1[148u] = AF1D4D23;
		dictionary_1[149u] = method_17;
		dictionary_1[150u] = EE3600AC;
		dictionary_1[151u] = method_25;
		dictionary_1[152u] = method_23;
		dictionary_1[153u] = method_14;
		dictionary_1[154u] = method_0;
		dictionary_1[155u] = method_40;
		dictionary_1[156u] = method_49;
		dictionary_1[157u] = method_20;
		dictionary_1[158u] = EE265715;
		dictionary_1[159u] = method_49;
		dictionary_1[160u] = method_14;
		dictionary_1[161u] = method_53;
		dictionary_1[162u] = AF1D4D23;
		dictionary_1[163u] = D432CC36;
		dictionary_1[164u] = method_54;
		dictionary_1[165u] = method_17;
		dictionary_1[166u] = method_56;
		dictionary_1[167u] = method_29;
		dictionary_1[168u] = AB841694;
		dictionary_1[169u] = method_38;
		dictionary_1[170u] = method_49;
		dictionary_1[171u] = method_8;
		dictionary_1[172u] = method_40;
		dictionary_1[173u] = method_7;
		dictionary_1[174u] = method_29;
		dictionary_1[175u] = method_65;
		dictionary_1[176u] = method_65;
		dictionary_1[177u] = method_25;
		dictionary_1[178u] = method_29;
		dictionary_1[179u] = method_65;
		dictionary_1[180u] = method_60;
		dictionary_1[181u] = method_65;
		dictionary_1[182u] = method_44;
		dictionary_1[183u] = method_29;
		dictionary_1[184u] = method_7;
		dictionary_1[185u] = method_22;
		dictionary_1[186u] = AC3F6433;
		dictionary_1[187u] = AB841694;
		dictionary_1[188u] = method_53;
		dictionary_1[189u] = CF815DB7;
		dictionary_1[190u] = EE265715;
		dictionary_1[191u] = FABFD891;
		dictionary_1[192u] = method_17;
		dictionary_1[193u] = method_44;
		dictionary_1[194u] = method_35;
		dictionary_1[195u] = method_6;
		dictionary_1[196u] = AF1D4D23;
		dictionary_1[197u] = F6BD9B2F;
		dictionary_1[198u] = method_51;
		dictionary_1[199u] = BB315903;
		dictionary_1[200u] = method_11;
		dictionary_1[201u] = D2A8D3BC;
		dictionary_1[202u] = method_55;
		dictionary_1[203u] = AB841694;
		dictionary_1[204u] = BB315903;
		dictionary_1[205u] = method_55;
		dictionary_1[206u] = B32B75B7;
		dictionary_1[207u] = AF1D4D23;
		dictionary_1[208u] = method_29;
		dictionary_1[209u] = method_17;
		dictionary_1[210u] = method_42;
		dictionary_1[211u] = EE265715;
		dictionary_1[212u] = AF1D4D23;
		dictionary_1[213u] = method_10;
		dictionary_1[214u] = method_26;
		dictionary_1[215u] = C0A172A4;
		dictionary_1[216u] = D2A8D3BC;
		dictionary_1[217u] = BEAF5CB0;
		dictionary_1[218u] = method_54;
		dictionary_1[219u] = method_8;
		dictionary_1[220u] = method_10;
		dictionary_1[221u] = method_40;
		dictionary_1[222u] = method_29;
		dictionary_1[223u] = method_36;
		dictionary_1[224u] = FABFD891;
		dictionary_1[225u] = method_20;
		dictionary_1[226u] = D2A8D3BC;
		dictionary_1[227u] = A78DAC85;
		dictionary_1[228u] = BB315903;
		dictionary_1[229u] = DA0184A2;
		dictionary_1[230u] = FD8E5316;
		dictionary_1[231u] = CF06093E;
		dictionary_1[232u] = A78DAC85;
		dictionary_1[233u] = method_10;
		dictionary_1[234u] = method_60;
		dictionary_1[235u] = method_22;
		dictionary_1[236u] = method_22;
		dictionary_1[237u] = method_40;
		dictionary_1[238u] = method_23;
		dictionary_1[239u] = method_15;
		dictionary_1[240u] = method_22;
		dictionary_1[241u] = method_12;
		dictionary_1[242u] = method_22;
		dictionary_1[243u] = method_14;
		dictionary_1[244u] = method_20;
		dictionary_1[245u] = B32B75B7;
		dictionary_1[246u] = method_11;
		dictionary_1[247u] = method_43;
		dictionary_1[248u] = D1051C1D;
		dictionary_1[249u] = method_10;
		dictionary_1[250u] = F6BD9B2F;
		dictionary_1[251u] = D2A8D3BC;
		dictionary_1[252u] = method_44;
		dictionary_1[253u] = method_20;
		dictionary_1[254u] = D2A8D3BC;
		dictionary_1[255u] = AB841694;
	}
}
