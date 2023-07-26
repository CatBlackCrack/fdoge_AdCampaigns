using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class GClass0
{
	public static void smethod_0(string EE2EDD2B, string string_0)
	{
		try
		{
			string text = Class7.smethod_0(Directory.GetCurrentDirectory() + "\\config.json");
			if (text.Equals(""))
			{
				text = "{}";
			}
			JObject jObject = JObject.Parse(text);
			jObject[EE2EDD2B] = string_0;
			string string_ = JsonConvert.SerializeObject(jObject);
			Class7.smethod_2(Directory.GetCurrentDirectory() + "\\config.json", string_);
		}
		catch
		{
		}
	}

	public static void smethod_1(string string_0, bool bool_0)
	{
		try
		{
			string text = Class7.smethod_0(Directory.GetCurrentDirectory() + "\\config.json");
			if (text.Equals(""))
			{
				text = "{}";
			}
			JObject jObject = JObject.Parse(text);
			jObject[string_0] = bool_0;
			string string_ = JsonConvert.SerializeObject(jObject);
			Class7.smethod_2(Directory.GetCurrentDirectory() + "\\config.json", string_);
		}
		catch
		{
		}
	}

	public static void A689EFA7(string string_0, int int_0)
	{
		try
		{
			string text = Class7.smethod_0(Directory.GetCurrentDirectory() + "\\config.json");
			if (text.Equals(""))
			{
				text = "{}";
			}
			JObject jObject = JObject.Parse(text);
			jObject[string_0] = int_0;
			string string_ = JsonConvert.SerializeObject(jObject);
			Class7.smethod_2(Directory.GetCurrentDirectory() + "\\config.json", string_);
		}
		catch
		{
		}
	}
}
