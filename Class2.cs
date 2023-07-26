using System;
using System.Security.Cryptography;
using System.Text;

internal class Class2
{
	public static string D522FDBA(string string_0, string string_1)
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(string_1));
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		byte[] array = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(tripleDESCryptoServiceProvider.CreateDecryptor().TransformFinalBlock(array, 0, array.Length));
	}

	public static string C3BB061A(string string_0, string B83CDCBB)
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(B83CDCBB));
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		byte[] bytes = Encoding.UTF8.GetBytes(string_0);
		return Convert.ToBase64String(tripleDESCryptoServiceProvider.CreateEncryptor().TransformFinalBlock(bytes, 0, bytes.Length));
	}
}
