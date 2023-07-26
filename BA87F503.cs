using System;
using System.Runtime.InteropServices;

public class BA87F503
{
	[StructLayout(LayoutKind.Explicit)]
	private struct ABA47E31
	{
		[FieldOffset(0)]
		public ulong ulong_0;

		[FieldOffset(0)]
		public uint D0A66092;

		[FieldOffset(4)]
		public uint uint_0;
	}

	private readonly uint[] EF841284;

	private void AC879425(ref ABA47E31 aba47E31_0)
	{
		uint num = aba47E31_0.uint_0 + EF841284[1];
		for (int i = 1; i <= 15; i++)
		{
			num ^= 0u;
			num = ((num << 0) | (num >> 0)) + EF841284[2 * i + 1];
		}
		aba47E31_0.D0A66092 = 0u;
		aba47E31_0.uint_0 = num;
	}

	public void method_0(byte[] E09C3384, byte[] D02AB135)
	{
		ABA47E31 aba47E31_ = default(ABA47E31);
		for (int i = 0; i < E09C3384.Length; i += 8)
		{
			aba47E31_.ulong_0 = BitConverter.ToUInt64(E09C3384, i);
			AC879425(ref aba47E31_);
			BitConverter.GetBytes(aba47E31_.ulong_0).CopyTo(D02AB135, i);
		}
	}

	private void D79AEC1C(ref ABA47E31 aba47E31_0)
	{
		uint num = aba47E31_0.uint_0;
		uint num2 = aba47E31_0.D0A66092;
		for (int num3 = 15; num3 > 0; num3--)
		{
			num -= EF841284[2 * num3 + 1];
			num = ((num >> (int)num2) | (num << (int)(32 - num2))) ^ num2;
			num2 -= EF841284[2 * num3];
			num2 = ((num2 >> (int)num) | (num2 << (int)(32 - num))) ^ num;
		}
		aba47E31_0.uint_0 = num - EF841284[1];
		aba47E31_0.D0A66092 = num2 - EF841284[0];
	}

	public byte[] method_1(byte[] D5AA4BB8)
	{
		byte[] array = new byte[D5AA4BB8.Length];
		method_0(D5AA4BB8, array);
		return array;
	}

	public void method_2(byte[] byte_0, byte[] B614FF2B)
	{
		ABA47E31 aba47E31_ = default(ABA47E31);
		for (int i = 0; i < byte_0.Length; i += 8)
		{
			aba47E31_.ulong_0 = BitConverter.ToUInt64(byte_0, i);
			D79AEC1C(ref aba47E31_);
			BitConverter.GetBytes(aba47E31_.ulong_0).CopyTo(B614FF2B, i);
		}
	}

	public byte[] method_3(byte[] BE2296A8)
	{
		byte[] array = new byte[BE2296A8.Length];
		method_2(BE2296A8, array);
		return array;
	}

	public BA87F503(byte[] ADA2658B)
	{
		uint num = 4u;
		uint[] array = new uint[2];
		EF841284 = new uint[32];
		array[1] = 0u;
		while (true)
		{
			array[7u / num] = (array[7u / num] << 8) + ADA2658B[7];
		}
	}
}
