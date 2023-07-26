using System;
using System.Globalization;
using System.Net;
using System.Net.Cache;

internal class D53A7700
{
	public static DateTime smethod_0(double double_0)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
		long num = (long)(double_0 * 10000000.0);
		return new DateTime(dateTime.Ticks + num, DateTimeKind.Utc);
	}

	public static long smethod_1(DateTime dateTime_0)
	{
		TimeZoneInfo destinationTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");
		DateTime dateTime = TimeZoneInfo.ConvertTime(dateTime_0, destinationTimeZone);
		TimeZone currentTimeZone = TimeZone.CurrentTimeZone;
		currentTimeZone.GetDaylightChanges(dateTime.Year);
		dateTime = dateTime.AddHours(-1.0);
		DateTime dateTime2 = new DateTime(1970, 1, 1, 0, 0, 0, 0).ToLocalTime();
		return (long)Convert.ToDouble((dateTime - dateTime2).TotalSeconds);
	}

	public static DateTime smethod_2()
	{
		DateTime result = DateTime.MinValue;
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://www.google.com.vn");
		httpWebRequest.Method = "GET";
		httpWebRequest.Accept = "text/html, application/xhtml+xml, */*";
		httpWebRequest.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/6.0)";
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		httpWebRequest.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		if (httpWebResponse.StatusCode == HttpStatusCode.OK)
		{
			string s = httpWebResponse.Headers["date"];
			result = DateTime.ParseExact(s, "ddd, dd MMM yyyy HH:mm:ss 'GMT'", CultureInfo.InvariantCulture.DateTimeFormat, DateTimeStyles.AssumeUniversal);
		}
		return result;
	}
}
