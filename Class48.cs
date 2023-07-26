using System.IO;

internal class Class48
{
	public uint uint_0;

	public Stream C5230B04;

	public uint uint_1;

	private uint F61AD00F = 1u;

	public uint method_0(int C68D80B5)
	{
		uint num = uint_0;
		uint num2 = uint_1;
		for (int num3 = C68D80B5; num3 > 0; num3--)
		{
			num >>= 1;
			num2 -= num & 0xFFFFFFFFu;
			if (num < 16777216)
			{
				num2 = (num2 << 8) | (byte)C5230B04.ReadByte();
				num <<= 8;
			}
		}
		uint_0 = num;
		uint_1 = num2;
		return 0u;
	}

	public void B001A320()
	{
		C5230B04 = null;
	}

	public void CD974A82(Stream stream_0)
	{
		C5230B04 = stream_0;
		uint_1 = 0u;
		uint_0 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			uint_1 = (uint_1 << 8) | (byte)C5230B04.ReadByte();
		}
	}
}
