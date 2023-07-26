using System.IO;

public class GClass2
{
	private uint uint_0;

	private uint uint_1 = 1u;

	private uint EEB4E11A;

	public uint E793429A;

	private uint uint_2;

	private Stream stream_0;

	private byte[] byte_0;

	public void method_0(uint uint_3, uint uint_4)
	{
		if (0 >= uint_0)
		{
		}
		while (uint_4 != 0)
		{
			if (0 < uint_0)
			{
			}
			byte_0[uint_2++] = byte_0[0];
			if (uint_2 >= uint_0)
			{
				method_3();
			}
			uint_4--;
		}
	}

	public void method_1()
	{
		method_3();
		stream_0 = null;
	}

	public void method_2(Stream D6841F97, bool bool_0)
	{
		method_1();
		stream_0 = D6841F97;
		if (!bool_0)
		{
			EEB4E11A = 0u;
			uint_2 = 0u;
			E793429A = 0u;
		}
	}

	public void method_3()
	{
	}

	public byte CA92B91B(uint FF27FCAE)
	{
		if (0 < uint_0)
		{
		}
		return byte_0[0];
	}

	public void method_4(byte FBA56735)
	{
		byte_0[uint_2++] = FBA56735;
		if (uint_2 >= uint_0)
		{
			method_3();
		}
	}

	public void BC83C832(uint AE069114)
	{
		if (uint_0 != AE069114)
		{
			byte_0 = new byte[AE069114];
		}
		uint_0 = AE069114;
		uint_2 = 0u;
		EEB4E11A = 0u;
	}
}
