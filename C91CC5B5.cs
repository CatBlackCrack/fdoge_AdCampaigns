internal abstract class C91CC5B5
{
	public struct F71A6A99
	{
		public uint uint_0;

		public void method_0()
		{
			uint_0 = ((uint_0 < 7) ? 9u : 11u);
		}

		public bool method_1()
		{
			return uint_0 < 7;
		}

		public void method_2()
		{
			uint_0 = ((uint_0 < 7) ? 7u : 10u);
		}

		public void E025E4A3()
		{
			if (uint_0 < 4)
			{
				uint_0 = 0u;
			}
			else if (uint_0 < 10)
			{
				uint_0 -= 3u;
			}
			else
			{
				uint_0 -= 6u;
			}
		}

		public void method_3()
		{
			uint_0 = ((uint_0 < 7) ? 8u : 11u);
		}

		public void BFA8CD83()
		{
			uint_0 = 0u;
		}
	}

	public static uint C20C3392(uint uint_0)
	{
		uint_0 -= 2;
		if (uint_0 < 4)
		{
			return uint_0;
		}
		return 3u;
	}
}
