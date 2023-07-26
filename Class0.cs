using System;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using xNet;

internal class Class0
{
	public static string smethod_0(string string_0)
	{
		try
		{
			string text = smethod_2(string_0);
			HttpRequest httpRequest = new HttpRequest();
			httpRequest.ReadWriteTimeout = 15000;
			httpRequest.UserAgent = Http.ChromeUserAgent();
			string str = "{\"api_key\":\"" + string_0 + "\",\"sign\":\"" + text + "\"}";
			string value = httpRequest.Post("https://tmproxy.com/api/proxy/get-new-proxy", str, "application/x-www-form-urlencoded").ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			string text2 = jObject["data"]["https"].ToString();
			if (text2.Equals(""))
			{
				return B31F1C01(string_0);
			}
			return text2;
		}
		catch
		{
		}
		return "";
	}

	public static string B31F1C01(string string_0)
	{
		try
		{
			HttpRequest httpRequest = new HttpRequest();
			httpRequest.ReadWriteTimeout = 15000;
			httpRequest.UserAgent = Http.ChromeUserAgent();
			string str = "{\"api_key\":\"" + string_0 + "\"}";
			string value = httpRequest.Post("https://tmproxy.com/api/proxy/get-current-proxy", str, "application/x-www-form-urlencoded").ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			string text = jObject["data"]["https"].ToString();
			if (text.Equals(""))
			{
				return jObject["message"].ToString();
			}
			return text;
		}
		catch
		{
		}
		return "";
	}

	public static string smethod_1(string string_0)
	{
		try
		{
			HttpRequest httpRequest = new HttpRequest();
			httpRequest.ReadWriteTimeout = 15000;
			httpRequest.UserAgent = Http.ChromeUserAgent();
			string json = httpRequest.Get("https://dash.minproxy.vn/api/rotating/v1/proxy/get-new-proxy?api_key=" + string_0).ToString();
			JObject jObject = JObject.Parse(json);
			if (jObject["code"] == null || !jObject["code"].ToString().Contains("2"))
			{
				return jObject.ToString();
			}
			return jObject["data"]["http_proxy"].ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_2(string string_0)
	{
		using MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	public static string D58E5586(string A10F0F35)
	{
		try
		{
			HttpRequest httpRequest = new HttpRequest();
			httpRequest.ReadWriteTimeout = 15000;
			httpRequest.UserAgent = Http.ChromeUserAgent();
			string json = httpRequest.Get("http://proxy.tinsoftsv.com/api/changeProxy.php?key=" + A10F0F35).ToString();
			JObject jObject = JObject.Parse(json);
			if (jObject["success"].ToString().Contains("alse"))
			{
				return smethod_3(A10F0F35);
			}
			return jObject["proxy"].ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_3(string string_0)
	{
		try
		{
			HttpRequest httpRequest = new HttpRequest();
			httpRequest.ReadWriteTimeout = 15000;
			httpRequest.UserAgent = Http.ChromeUserAgent();
			string json = httpRequest.Get("http://proxy.tinsoftsv.com/api/getProxy.php?key=" + string_0).ToString();
			JObject jObject = JObject.Parse(json);
			if (jObject["success"].ToString().Contains("alse"))
			{
				return jObject.ToString();
			}
			return jObject["proxy"].ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_4(string string_0)
	{
		try
		{
			HttpRequest httpRequest = new HttpRequest();
			httpRequest.ReadWriteTimeout = 15000;
			httpRequest.UserAgent = Http.ChromeUserAgent();
			string json = httpRequest.Get("http://proxy.shoplike.vn/Api/getNewProxy?access_token=" + string_0).ToString();
			JObject jObject = JObject.Parse(json);
			if (jObject["status"].ToString().Contains("success"))
			{
				return jObject["data"]["proxy"].ToString();
			}
			return smethod_5(string_0);
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static string smethod_5(string string_0)
	{
		try
		{
			HttpRequest httpRequest = new HttpRequest();
			httpRequest.ReadWriteTimeout = 15000;
			httpRequest.UserAgent = Http.ChromeUserAgent();
			string json = httpRequest.Get("http://proxy.shoplike.vn/Api/getCurrentProxy?access_token=" + string_0).ToString();
			JObject jObject = JObject.Parse(json);
			if (jObject["status"].ToString().Contains("success"))
			{
				return jObject["data"]["proxy"].ToString();
			}
			return jObject.ToString();
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static void smethod_6()
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = "C:\\Windows\\System32\\netsh";
			process.StartInfo.Arguments = "interface set interface \"HMA! Pro VPN OpenVPN\" disable";
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.StartInfo.RedirectStandardOutput = true;
			process.Start();
			process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			Thread.Sleep(TimeSpan.FromSeconds(18.0));
			Process process2 = new Process();
			process2.StartInfo.FileName = "C:\\Windows\\System32\\netsh";
			process2.StartInfo.Arguments = "interface set interface \"HMA! Pro VPN OpenVPN\" enable";
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.CreateNoWindow = true;
			process2.StartInfo.RedirectStandardOutput = true;
			process2.Start();
			process2.StandardOutput.ReadToEnd();
			process2.WaitForExit();
			Thread.Sleep(TimeSpan.FromSeconds(20.0));
		}
		catch (Exception)
		{
		}
	}

	public static void smethod_7(string string_0)
	{
		try
		{
		}
		catch
		{
		}
	}
}
