using System.Runtime.InteropServices;

public static class BC1DAFB6
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	internal delegate void CC8A7C1D();

	public static object[] object_0;

	internal static bool smethod_0(byte[] DB878D9D)
	{
		int num = 0;
		while (true)
		{
			if (num < DB878D9D.Length)
			{
				if (num + 3 >= DB878D9D.Length || DB878D9D[num] != 81 || DB878D9D[num + 1] != 69 || DB878D9D[num + 2] != 77 || DB878D9D[num + 3] != 85)
				{
					if (num + 8 >= DB878D9D.Length || DB878D9D[num] != 77 || DB878D9D[num + 1] != 105 || DB878D9D[num + 2] != 99 || DB878D9D[num + 3] != 114 || DB878D9D[num + 4] != 111 || DB878D9D[num + 5] != 115 || DB878D9D[num + 6] != 111 || DB878D9D[num + 7] != 102 || DB878D9D[num + 8] != 116)
					{
						if (num + 6 >= DB878D9D.Length || DB878D9D[num] != 105 || DB878D9D[num + 1] != 110 || DB878D9D[num + 2] != 110 || DB878D9D[num + 3] != 111 || DB878D9D[num + 4] != 116 || DB878D9D[num + 5] != 101 || DB878D9D[num + 6] != 107)
						{
							if (num + 9 >= DB878D9D.Length || DB878D9D[num] != 86 || DB878D9D[num + 1] != 105 || DB878D9D[num + 2] != 114 || DB878D9D[num + 3] != 116 || DB878D9D[num + 4] != 117 || DB878D9D[num + 5] != 97 || DB878D9D[num + 6] != 108 || DB878D9D[num + 7] != 66 || DB878D9D[num + 8] != 111 || DB878D9D[num + 9] != 120)
							{
								if (num + 5 >= DB878D9D.Length || DB878D9D[num] != 86 || DB878D9D[num + 1] != 77 || DB878D9D[num + 2] != 119 || DB878D9D[num + 3] != 97 || DB878D9D[num + 4] != 114 || DB878D9D[num + 5] != 101)
								{
									if (num + 8 < DB878D9D.Length && DB878D9D[num] == 80 && DB878D9D[num + 1] == 97 && DB878D9D[num + 2] == 114 && DB878D9D[num + 3] == 97 && DB878D9D[num + 4] == 108 && DB878D9D[num + 5] == 108 && DB878D9D[num + 6] == 101 && DB878D9D[num + 7] == 108 && DB878D9D[num + 8] == 115)
									{
										break;
									}
									num++;
									continue;
								}
								return true;
							}
							return true;
						}
						return true;
					}
					return true;
				}
				return true;
			}
			return false;
		}
		return true;
	}
}
