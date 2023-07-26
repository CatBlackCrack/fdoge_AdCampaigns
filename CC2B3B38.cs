using System;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OtpNet;
using xNet;

public static class CC2B3B38
{
	public static bool A906E4BF(xNet.HttpRequest httpRequest_0, int CF06F13B)
	{
		try
		{
			httpRequest_0.Proxy = Socks5ProxyClient.Parse($"127.0.0.1:{CF06F13B}");
			httpRequest_0.Get("https://m.facebook.com/").ToString();
			return true;
		}
		catch
		{
		}
		httpRequest_0.Proxy = null;
		return false;
	}

	public static bool smethod_0(xNet.HttpRequest httpRequest_0, string string_0)
	{
		try
		{
			httpRequest_0.Proxy = Socks5ProxyClient.Parse(string_0);
			httpRequest_0.Get("https://m.facebook.com/").ToString();
			return true;
		}
		catch
		{
		}
		httpRequest_0.Proxy = null;
		return false;
	}

	public static bool smethod_1(xNet.HttpRequest httpRequest_0, string string_0)
	{
		try
		{
			httpRequest_0.Proxy = HttpProxyClient.Parse(string_0);
			httpRequest_0.Get("https://m.facebook.com/").ToString();
			return true;
		}
		catch
		{
		}
		httpRequest_0.Proxy = null;
		return false;
	}

	public static bool smethod_2(xNet.HttpRequest httpRequest_0)
	{
		try
		{
			httpRequest_0.Get("https://m.facebook.com/").ToString();
			return true;
		}
		catch
		{
		}
		return false;
	}

	public static string smethod_3(xNet.HttpRequest httpRequest_0, int D9BBB7AB)
	{
		try
		{
			httpRequest_0.Proxy = Socks5ProxyClient.Parse($"127.0.0.1:{D9BBB7AB}");
			string text = httpRequest_0.Get("http://ipv4.icanhazip.com/").ToString();
			text.Replace(" ", "");
			return text;
		}
		catch
		{
		}
		return Class19.CD2AA435();
	}

	public static string E7B9CB11(xNet.HttpRequest EFBE7034, string string_0)
	{
		try
		{
			EFBE7034.Proxy = Socks5ProxyClient.Parse($"{string_0}");
			string text = EFBE7034.Get("http://ipv4.icanhazip.com/").ToString();
			text.Replace(" ", "");
			return text;
		}
		catch
		{
		}
		return Class19.CD2AA435();
	}

	public static string smethod_4(xNet.HttpRequest httpRequest_0, string string_0)
	{
		try
		{
			httpRequest_0.Proxy = HttpProxyClient.Parse($"{string_0}");
			string text = httpRequest_0.Get("http://ipv4.icanhazip.com/").ToString();
			text.Replace(" ", "");
			return text;
		}
		catch
		{
		}
		return Class19.CD2AA435();
	}

	public static string smethod_5(xNet.HttpRequest httpRequest_0)
	{
		try
		{
			string text = httpRequest_0.Get("http://ipv4.icanhazip.com/").ToString();
			text.Replace(" ", "");
			return text;
		}
		catch
		{
		}
		return Class19.CD2AA435();
	}

	public static string smethod_6(xNet.HttpRequest B70BB83D, string string_0, string string_1, string EFA43CB3, out string BA31500A)
	{
		BA31500A = "";
		try
		{
			B70BB83D.Cookies.Clear();
			string empty = string.Empty;
			string empty2 = string.Empty;
			string empty3 = string.Empty;
			empty3 = smethod_7(B70BB83D);
			if (!(empty3 != string.Empty))
			{
				return "";
			}
			string[] array = empty3.Split('|');
			string text = array[1];
			if (text == string.Empty)
			{
				array[1] = "21312";
			}
			empty = B70BB83D.Post(Class1.String_3, "lsd=" + array[0] + "&jazoest=" + array[1] + "&m_ts=" + array[2] + "&li=" + array[3] + "&try_number=0&unrecognized_tries=0&email=" + string_0 + "&pass=" + string_1 + "&login=Log+In", "application/x-www-form-urlencoded").ToString();
			empty = Regex.Unescape(empty);
			string empty4 = string.Empty;
			string empty5 = string.Empty;
			empty4 = Regex.Match(empty, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
			empty5 = Regex.Match(empty, "name=\"nh\" value=\"(.*?)\"").Groups[1].Value;
			empty2 = Regex.Match(empty, "name=\"jazoest\" value=\"(\\d+)\"").Groups[1].Value;
			if (empty4.Length <= 5 || empty5.Length <= 10)
			{
				return "";
			}
			string str = empty4;
			str = HttpUtility.UrlEncode(str);
			string text2 = (BA31500A = smethod_8(EFA43CB3));
			empty = B70BB83D.Post(Class1.String_2, "fb_dtsg=" + str + "&jazoest=2980&checkpoint_data=&approvals_code=" + text2 + "&codes_submitted=0&submit[Submit Code]=Submit Code&nh=" + empty5, "application/x-www-form-urlencoded").ToString();
			str = Regex.Match(empty, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
			if (!(str != string.Empty))
			{
				return "";
			}
			str = HttpUtility.UrlEncode(str);
			B70BB83D.KeepAlive = true;
			B70BB83D.AddHeader("sec-ch-ua-mobile", "?0");
			B70BB83D.AddHeader("Upgrade-Insecure-Requests", "1");
			B70BB83D.AddHeader("Origin", "https://mbasic.facebook.com");
			B70BB83D.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
			B70BB83D.AddHeader("Sec-Fetch-Site", "same-origin");
			B70BB83D.AddHeader("Sec-Fetch-Mode", "navigate");
			B70BB83D.AddHeader("Sec-Fetch-User", "?1");
			B70BB83D.AddHeader("Sec-Fetch-Dest", "document");
			B70BB83D.Referer = Class1.D22BF503;
			empty = B70BB83D.Post(Class1.D22BF503, "fb_dtsg=" + str + "&jazoest=" + empty2 + "&checkpoint_data=&name_action_selected=save_device&submit%5BContinue%5D=Continue&nh=" + empty5 + "&fb_dtsg=" + str + "&jazoest=" + empty2, "application/x-www-form-urlencoded").ToString();
			string value = Regex.Match(B70BB83D.Cookies.ToString(), "xs=(.*[^\\s])").Groups[1].Value;
			if (!B70BB83D.Address.ToString().Contains("home.php") && value.Length <= 15)
			{
				empty = B70BB83D.Post(Class1.String_2, "fb_dtsg=" + str + "&jazoest=" + empty2 + "&checkpoint_data=&submit%5BContinue%5D=Continue&nh=" + empty5 + "&fb_dtsg=" + str + "&jazoest=21141", "application/x-www-form-urlencoded").ToString();
				empty = B70BB83D.Post(Class1.String_2, "fb_dtsg=" + str + "&jazoest=" + empty2 + "&checkpoint_data=&submit%5BThis+was+me%5D=This+Was+Me&nh=" + empty5 + "&fb_dtsg=" + str + "&jazoest=21141", "application/x-www-form-urlencoded").ToString();
				empty = B70BB83D.Post(Class1.String_2, "fb_dtsg=" + str + "&jazoest=" + empty2 + "&checkpoint_data=&name_action_selected=save_device&submit%5BContinue%5D=Continue&nh=" + empty5 + "&fb_dtsg=" + str + "&jazoest=21141", "application/x-www-form-urlencoded").ToString();
				empty4 = Regex.Match(empty, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
				if (empty4.Length > 20)
				{
					return empty4;
				}
				empty = B70BB83D.Get(Class1.String_1).ToString();
				empty4 = Regex.Match(Regex.Unescape(empty), "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
				if (empty4.Length > 20)
				{
					return empty4;
				}
			}
			else
			{
				empty4 = Regex.Match(empty, "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
				if (empty4.Length > 20)
				{
					return empty4;
				}
				empty = B70BB83D.Get(Class1.String_1).ToString();
				empty4 = Regex.Match(Regex.Unescape(empty), "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
				if (empty4.Length > 20)
				{
					return empty4;
				}
			}
			return "";
		}
		catch (Exception)
		{
		}
		return "";
	}

	private static string smethod_7(xNet.HttpRequest A724F131)
	{
		try
		{
			string empty = string.Empty;
			string empty2 = string.Empty;
			string empty3 = string.Empty;
			string empty4 = string.Empty;
			string text = string.Empty;
			A724F131.Cookies = new CookieDictionary();
			for (int i = 0; i < 5; i++)
			{
				try
				{
					empty = A724F131.Get("https://m.facebook.com/").ToString();
					empty = A724F131.Post("https://mbasic.facebook.com/basic-lite/cookie/consent/?next_uri=https%3A%2F%2Fmbasic.facebook.com%2F&sid=McsWeBQePHbfcA2OEO4o&basic_lite_source_surface=COOKIE_CONSENT_PAGE", "jazoest=2948&lsd=" + text + "&accept_consent=1", "application/x-www-form-urlencoded").ToString();
					empty = A724F131.Get("https://m.facebook.com/").ToString();
					empty2 = Regex.Match(empty, "name=\"m_ts\" value=\"(\\d+)\"").Groups[1].Value;
					empty3 = Regex.Match(empty, "name=\"li\" value=\"(.*?)\"").Groups[1].Value;
					text = Regex.Match(empty, "name=\"lsd\" value=\"(.*?)\"").Groups[1].Value;
					if (!text.Equals("") && !empty2.Equals(""))
					{
						return text + "|" + empty4 + "|" + empty2 + "|" + empty3;
					}
				}
				catch
				{
				}
			}
			return "";
		}
		catch
		{
		}
		return "";
	}

	public static string smethod_8(string string_0)
	{
		try
		{
			xNet.HttpRequest httpRequest = new xNet.HttpRequest();
			httpRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/100.0.4896.127 Safari/537.36";
			httpRequest.AddHeader("authority", "2fa.live");
			httpRequest.AddHeader("accept", "*/*");
			httpRequest.AddHeader("accept-language", "vi-VN,vi;q=0.9,en-US;q=0.8,en;q=0.7,fr-FR;q=0.6,fr;q=0.5");
			httpRequest.AddHeader("if-none-match", "W/\"12-sDbemCZWrapEJG5FAzh8BfNbxns\"");
			httpRequest.AddHeader("referer", "https://2fa.live/");
			httpRequest.AddHeader("sec-ch-ua", "\" Not A;Brand\";v=\"99\", \"Chromium\";v=\"100\", \"Google Chrome\";v=\"100\"");
			httpRequest.AddHeader("sec-ch-ua-mobile", "?0");
			httpRequest.AddHeader("sec-ch-ua-platform", "\"Windows\"");
			httpRequest.AddHeader("sec-fetch-dest", "empty");
			httpRequest.AddHeader("sec-fetch-mode", "cors");
			httpRequest.AddHeader("sec-fetch-site", "same-origin");
			httpRequest.AddHeader("x-requested-with", "XMLHttpRequest");
			string text = Regex.Replace(string_0, "\\s+", "");
			string value = httpRequest.Get("https://2fa.live/tok/" + text).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			string text2 = jObject["token"].ToString();
			if (text2.Length == 6)
			{
				return text2;
			}
		}
		catch
		{
		}
		try
		{
			string text3 = "";
			int num = 0;
			Totp totp;
			do
			{
				Thread.Sleep(500);
				totp = new Totp(Base32Encoding.ToBytes(Regex.Replace(string_0, "\\s+", "")));
				text3 = totp.ComputeTotp();
				num++;
			}
			while (num < 60 && (text3.Length != 6 || totp.RemainingSeconds() <= 5));
			return text3;
		}
		catch
		{
		}
		return "";
	}
}
