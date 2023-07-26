using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OtpNet;
using xNet;

internal class Class3
{
	public static string smethod_0(string string_0, string FA1AC129)
	{
		try
		{
			if (FA1AC129.EndsWith(".00"))
			{
				FA1AC129 = FA1AC129.Substring(0, FA1AC129.Length - 3);
			}
			FA1AC129 = FA1AC129.Replace(",", "").Replace(".", "");
			string text = string.Empty;
			switch (string_0)
			{
			default:
				if (!(string_0 == "BRL"))
				{
					text = FA1AC129 + ".00";
					break;
				}
				goto case "USD";
			case "USD":
			case "CAD":
			case "CHF":
			case "EUR":
			case "KYD":
			case "CNY":
			case "GBP":
			case "JOD":
			case "OMR":
			case "BHD":
			case "KWD":
			case "AUD":
			case "AZN":
			case "UYU":
			case "HKD":
			{
				for (int i = 0; i < FA1AC129.Length; i++)
				{
					text = ((i == FA1AC129.Length - 3) ? (text + FA1AC129[i] + ".") : (text + FA1AC129[i]));
				}
				break;
			}
			}
			return text;
		}
		catch
		{
		}
		return "";
	}

	public static List<Class11> smethod_1(HttpRequest D484662B, string string_0)
	{
		List<Class11> list = new List<Class11>();
		try
		{
			string value = D484662B.Get("https://graph.facebook.com/v14.0/me/adaccounts?fields=is_prepay_account,all_payment_methods{pm_credit_card{display_string,exp_month,exp_year,is_verified},payment_method_direct_debits{address,can_verify,display_string,is_awaiting,is_pending,status},payment_method_paypal{email_address},payment_method_tokens{current_balance,original_balance,time_expire,type}},created_time,adtrust_dsl,adspaymentcycle,account_status,id,currency,amount_spent,balance,min_billing_threshold,business,name,timezone_name,light_campaigns&summary=total_count&limit=50&access_token=" + string_0).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			int num = jObject["data"].ToArray().Length;
			for (int i = 0; i < num; i++)
			{
				try
				{
					Class11 @class = new Class11();
					@class.String_1 = jObject["data"][i]["id"].ToString();
					@class.String_2 = jObject["data"][i]["adtrust_dsl"].ToString();
					if (@class.String_2.Equals("-1"))
					{
						@class.String_2 = "Nolimit";
					}
					@class.C9321781 = jObject["data"][i]["name"].ToString();
					@class.String_3 = jObject["data"][i]["currency"].ToString();
					@class.String_10 = "";
					List<string> list2 = new List<string>();
					try
					{
						for (int j = 0; j < jObject["data"][i]["all_payment_methods"]["payment_method_direct_debits"]["data"].ToArray().Length; j++)
						{
							list2.Add(jObject["data"][i]["all_payment_methods"]["payment_method_direct_debits"]["data"][j]["display_string"].ToString());
						}
					}
					catch
					{
					}
					try
					{
						for (int k = 0; k < jObject["data"][i]["all_payment_methods"]["pm_credit_card"]["data"].ToArray().Length; k++)
						{
							string text = jObject["data"][i]["all_payment_methods"]["pm_credit_card"]["data"][k]["is_verified"].ToString();
							list2.Add(string.Concat(str2: (!(text == "True")) ? "Need_Verify" : "Verified", str0: jObject["data"][i]["all_payment_methods"]["pm_credit_card"]["data"][k]["display_string"].ToString(), str1: "->"));
						}
					}
					catch
					{
					}
					try
					{
						for (int l = 0; l < jObject["data"][i]["all_payment_methods"]["payment_method_paypal"]["data"].ToArray().Length; l++)
						{
							list2.Add("Paypal:" + jObject["data"][i]["all_payment_methods"]["payment_method_paypal"]["data"][l]["email_address"].ToString());
						}
					}
					catch
					{
					}
					@class.String_10 = string.Join("| ", list2);
					@class.String_4 = jObject["data"][i]["amount_spent"].ToString();
					@class.String_4 = smethod_0(@class.String_3, @class.String_4);
					@class.AD910B99 = "";
					try
					{
						@class.AD910B99 = jObject["data"][i]["balance"].ToString();
					}
					catch
					{
					}
					@class.String_12 = "";
					try
					{
						if (jObject["data"][i]["is_prepay_account"].ToString() == "True")
						{
							@class.String_12 = "TKTT";
						}
						else if (jObject["data"][i]["is_prepay_account"].ToString() == "False")
						{
							@class.String_12 = "TKTS";
						}
					}
					catch
					{
					}
					@class.String_5 = "";
					try
					{
						@class.String_5 = jObject["data"][i]["min_billing_threshold"]["amount"].ToString();
					}
					catch
					{
					}
					try
					{
						@class.String_5 = jObject["data"][i]["adspaymentcycle"]["data"][0]["threshold_amount"].ToString();
					}
					catch
					{
					}
					@class.String_5 = smethod_0(@class.String_3, @class.String_5);
					try
					{
						@class.String_7 = jObject["data"][i]["timezone_name"].ToString();
					}
					catch
					{
					}
					try
					{
						if (jObject["data"][i].ToString().Contains("light_campaigns"))
						{
							@class.String_6 = "Yes";
						}
						else
						{
							@class.String_6 = "No";
						}
					}
					catch
					{
					}
					@class.String_0 = "";
					if (jObject["data"][i]["account_status"].ToString().Equals("1"))
					{
						@class.String_0 = "Live";
					}
					else if (jObject["data"][i]["account_status"].ToString().Equals("2"))
					{
						@class.String_0 = "Die";
					}
					else if (jObject["data"][i]["account_status"].ToString().Equals("3"))
					{
						@class.String_0 = "Need_Pay";
					}
					else if (jObject["data"][i]["account_status"].ToString().Equals("100"))
					{
						@class.String_0 = "Pending_Closed";
					}
					else if (jObject["data"][i]["account_status"].ToString().Equals("101"))
					{
						@class.String_0 = "Closed";
					}
					else
					{
						@class.String_0 = "Undefined";
					}
					@class.String_8 = "Personal";
					string text2 = "";
					try
					{
						text2 = jObject["data"][i]["business"]["id"].ToString();
						if (!text2.Equals(""))
						{
							@class.String_8 = "Bussiness[" + text2 + "]";
						}
					}
					catch
					{
					}
					try
					{
						@class.A717C383 = jObject["data"][i]["created_time"].ToString();
					}
					catch
					{
					}
					list.Add(@class);
				}
				catch
				{
				}
			}
			if (num > 0 && jObject["paging"]["next"] != null)
			{
				string string_ = jObject["paging"]["next"].ToString();
				list = AC9FE1AB(D484662B, list, string_);
			}
		}
		catch
		{
		}
		return list;
	}

	internal static List<B3810F27> smethod_2(HttpRequest httpRequest_0, string AB2EAAA0)
	{
		List<B3810F27> list = new List<B3810F27>();
		try
		{
			string value = httpRequest_0.Get("https://graph.facebook.com/v14.0/me/businesses?fields=name,id,verification_status,business_users.summary(1),is_disabled_for_integrity_reasons,sharing_eligibility_status,created_time,permitted_roles,owned_pages.summary(1),client_ad_accounts.summary(1),owned_ad_accounts.summary(1)&access_token=" + AB2EAAA0).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			for (int i = 0; i < jObject["data"].ToArray().Length; i++)
			{
				try
				{
					B3810F27 b3810F = new B3810F27();
					b3810F.String_1 = jObject["data"][i]["id"].ToString();
					b3810F.String_0 = jObject["data"][i]["name"].ToString();
					b3810F.EA2AD615 = "";
					try
					{
						if (jObject["data"][i]["is_disabled_for_integrity_reasons"].ToString().Contains("rue"))
						{
							b3810F.EA2AD615 = "DIE";
						}
						if (jObject["data"][i]["is_disabled_for_integrity_reasons"].ToString().Contains("alse"))
						{
							b3810F.EA2AD615 = "live";
						}
					}
					catch
					{
					}
					b3810F.String_4 = "";
					try
					{
						if (jObject["data"][i]["sharing_eligibility_status"].ToString().Equals("enabled"))
						{
							b3810F.String_4 = "BM350";
						}
						if (jObject["data"][i]["sharing_eligibility_status"].ToString().Equals("disabled_due_to_trust_tier"))
						{
							b3810F.String_4 = "BM50";
						}
					}
					catch
					{
					}
					b3810F.B182F912 = "";
					try
					{
						b3810F.B182F912 = jObject["data"][i]["verification_status"].ToString();
					}
					catch
					{
					}
					b3810F.String_3 = "";
					try
					{
						b3810F.String_3 = jObject["data"][i]["created_time"].ToString();
					}
					catch
					{
					}
					b3810F.String_2 = "";
					try
					{
						b3810F.String_2 = jObject["data"][i]["permitted_roles"].ToString().Replace("\r\n", "").Replace("\n", "")
							.Replace("\r", "");
					}
					catch
					{
					}
					b3810F.String_5 = "";
					try
					{
						b3810F.String_5 = jObject["data"][i]["business_users"]["summary"]["total_count"].ToString();
					}
					catch
					{
					}
					b3810F.String_7 = "";
					try
					{
						b3810F.String_7 = jObject["data"][i]["owned_pages"]["summary"]["total_count"].ToString();
					}
					catch
					{
					}
					b3810F.String_6 = "";
					try
					{
						string text = jObject["data"][i]["owned_ad_accounts"]["summary"]["total_count"].ToString();
						string text2 = jObject["data"][i]["client_ad_accounts"]["summary"]["total_count"].ToString();
						b3810F.String_6 = text + " owned ads - " + text2 + " client ads";
					}
					catch
					{
					}
					b3810F.A1871E97 = "---";
					b3810F.F336300F = "---";
					list.Add(b3810F);
				}
				catch
				{
				}
			}
			if (jObject["paging"]["next"] != null)
			{
				list = smethod_3(httpRequest_0, list, jObject["paging"]["next"].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<B3810F27> smethod_3(HttpRequest httpRequest_0, List<B3810F27> list_0, string string_0)
	{
		try
		{
			string value = httpRequest_0.Get(string_0).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			_ = jObject["data"].ToArray().Length;
			for (int i = 0; i < jObject["data"].ToArray().Length; i++)
			{
				try
				{
					B3810F27 b3810F = new B3810F27();
					b3810F.String_1 = jObject["data"][i]["id"].ToString();
					b3810F.String_0 = jObject["data"][i]["name"].ToString();
					b3810F.EA2AD615 = "";
					try
					{
						if (jObject["data"][i]["allow_page_management_in_www"].ToString().Contains("rue"))
						{
							b3810F.EA2AD615 = "DIE";
						}
						if (jObject["data"][i]["allow_page_management_in_www"].ToString().Contains("alse"))
						{
							b3810F.EA2AD615 = "live";
						}
					}
					catch
					{
					}
					b3810F.String_4 = "";
					try
					{
						if (jObject["data"][i]["sharing_eligibility_status"].ToString().Equals("enabled"))
						{
							b3810F.String_4 = "BM350";
						}
						if (jObject["data"][i]["sharing_eligibility_status"].ToString().Equals("disabled_due_to_trust_tier"))
						{
							b3810F.String_4 = "BM50";
						}
					}
					catch
					{
					}
					b3810F.B182F912 = "";
					try
					{
						b3810F.B182F912 = jObject["data"][i]["verification_status"].ToString();
					}
					catch
					{
					}
					b3810F.String_3 = "";
					try
					{
						b3810F.String_3 = jObject["data"][i]["created_time"].ToString();
					}
					catch
					{
					}
					b3810F.String_2 = "";
					try
					{
						b3810F.String_2 = jObject["data"][i]["permitted_roles"].ToString().Replace("\r\n", "").Replace("\n", "")
							.Replace("\r", "");
					}
					catch
					{
					}
					b3810F.String_5 = "";
					try
					{
						b3810F.String_5 = jObject["data"][i]["business_users"]["summary"]["total_count"].ToString();
					}
					catch
					{
					}
					b3810F.String_7 = "";
					try
					{
						b3810F.String_7 = jObject["data"][i]["owned_pages"]["summary"]["total_count"].ToString();
					}
					catch
					{
					}
					b3810F.String_6 = "";
					try
					{
						string text = jObject["data"][i]["owned_ad_accounts"]["summary"]["total_count"].ToString();
						string text2 = jObject["data"][i]["client_ad_accounts"]["summary"]["total_count"].ToString();
						b3810F.String_6 = text + " owned ads - " + text2 + " client ads";
					}
					catch
					{
					}
					b3810F.A1871E97 = "---";
					b3810F.F336300F = "---";
					list_0.Add(b3810F);
				}
				catch
				{
				}
			}
			if (jObject["paging"]["next"] != null)
			{
				list_0 = smethod_3(httpRequest_0, list_0, jObject["paging"]["next"].ToString());
			}
		}
		catch
		{
		}
		return list_0;
	}

	internal static B3810F27 A503AC3C(HttpRequest httpRequest_0, string string_0, string string_1)
	{
		B3810F27 b3810F = new B3810F27();
		b3810F.String_1 = string_1;
		try
		{
			string value = httpRequest_0.Get("https://graph.facebook.com/v14.0/" + string_1 + "?fields=owned_pages.summary(1),name,id,verification_status,business_users.summary(1),is_disabled_for_integrity_reasons,sharing_eligibility_status,created_time,client_ad_accounts.summary(1),owned_ad_accounts.summary(1)&limit=50&access_token=" + string_0).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			try
			{
				b3810F.String_1 = jObject["id"].ToString();
				b3810F.String_0 = jObject["name"].ToString();
				b3810F.EA2AD615 = "";
				try
				{
					if (jObject["is_disabled_for_integrity_reasons"].ToString().Contains("rue"))
					{
						b3810F.EA2AD615 = "DIE";
					}
					if (jObject["is_disabled_for_integrity_reasons"].ToString().Contains("alse"))
					{
						b3810F.EA2AD615 = "live";
					}
				}
				catch
				{
				}
				b3810F.String_4 = "";
				try
				{
					if (jObject["sharing_eligibility_status"].ToString().Equals("enabled"))
					{
						b3810F.String_4 = "BM350";
					}
					if (jObject["sharing_eligibility_status"].ToString().Equals("disabled_due_to_trust_tier"))
					{
						b3810F.String_4 = "BM50";
					}
				}
				catch
				{
				}
				b3810F.B182F912 = "";
				try
				{
					b3810F.B182F912 = jObject["verification_status"].ToString();
				}
				catch
				{
				}
				b3810F.String_3 = "";
				try
				{
					b3810F.String_3 = jObject["created_time"].ToString();
				}
				catch
				{
				}
				b3810F.String_7 = "";
				try
				{
					b3810F.String_7 = jObject["owned_pages"]["summary"]["total_count"].ToString();
				}
				catch
				{
				}
				b3810F.String_2 = "---";
				b3810F.String_5 = "";
				try
				{
					b3810F.String_5 = jObject["business_users"]["summary"]["total_count"].ToString();
				}
				catch
				{
				}
				b3810F.String_6 = "";
				try
				{
					string text = jObject["owned_ad_accounts"]["summary"]["total_count"].ToString();
					string text2 = jObject["client_ad_accounts"]["summary"]["total_count"].ToString();
					b3810F.String_6 = text + " owned ads - " + text2 + " client ads";
				}
				catch
				{
				}
				b3810F.A1871E97 = "---";
				b3810F.F336300F = "---";
			}
			catch
			{
			}
		}
		catch
		{
		}
		return b3810F;
	}

	public static List<Class11> AC9FE1AB(HttpRequest E5A3702E, List<Class11> D50EED1D, string string_0)
	{
		try
		{
			string value = E5A3702E.Get(string_0).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			int num = jObject["data"].ToArray().Length;
			for (int i = 0; i < num; i++)
			{
				try
				{
					Class11 @class = new Class11();
					@class.String_1 = jObject["data"][i]["id"].ToString();
					@class.String_2 = jObject["data"][i]["adtrust_dsl"].ToString();
					if (@class.String_2.Equals("-1"))
					{
						@class.String_2 = "Nolimit";
					}
					@class.C9321781 = jObject["data"][i]["name"].ToString();
					@class.String_3 = jObject["data"][i]["currency"].ToString();
					@class.String_10 = "";
					List<string> list = new List<string>();
					try
					{
						for (int j = 0; j < jObject["data"][i]["all_payment_methods"]["payment_method_direct_debits"]["data"].ToArray().Length; j++)
						{
							list.Add(jObject["data"][i]["all_payment_methods"]["payment_method_direct_debits"]["data"][j]["display_string"].ToString());
						}
					}
					catch
					{
					}
					try
					{
						for (int k = 0; k < jObject["data"][i]["all_payment_methods"]["pm_credit_card"]["data"].ToArray().Length; k++)
						{
							string text = jObject["data"][i]["all_payment_methods"]["pm_credit_card"]["data"][k]["is_verified"].ToString();
							list.Add(string.Concat(str2: (!(text == "True")) ? "Need_Verify" : "Verified", str0: jObject["data"][i]["all_payment_methods"]["pm_credit_card"]["data"][k]["display_string"].ToString(), str1: "->"));
						}
					}
					catch
					{
					}
					try
					{
						for (int l = 0; l < jObject["data"][i]["all_payment_methods"]["payment_method_paypal"]["data"].ToArray().Length; l++)
						{
							list.Add("Paypal:" + jObject["data"][i]["all_payment_methods"]["payment_method_paypal"]["data"][l]["email_address"].ToString());
						}
					}
					catch
					{
					}
					@class.String_10 = string.Join("| ", list);
					@class.String_4 = jObject["data"][i]["amount_spent"].ToString();
					@class.String_4 = smethod_0(@class.String_3, @class.String_4);
					try
					{
						@class.AD910B99 = jObject["data"][i]["balance"].ToString();
					}
					catch
					{
					}
					@class.String_5 = "";
					try
					{
						@class.String_5 = jObject["data"][i]["min_billing_threshold"]["amount"].ToString();
					}
					catch
					{
					}
					try
					{
						@class.String_5 = jObject["data"][i]["adspaymentcycle"]["data"][0]["threshold_amount"].ToString();
					}
					catch
					{
					}
					@class.String_5 = smethod_0(@class.String_3, @class.String_5);
					try
					{
						@class.String_7 = jObject["data"][i]["timezone_name"].ToString();
					}
					catch
					{
					}
					try
					{
						if (jObject["data"][i].ToString().Contains("light_campaigns"))
						{
							@class.String_6 = "Yes";
						}
						else
						{
							@class.String_6 = "No";
						}
					}
					catch
					{
					}
					@class.String_0 = "";
					if (jObject["data"][i]["account_status"].ToString().Equals("1"))
					{
						@class.String_0 = "Live";
					}
					else if (jObject["data"][i]["account_status"].ToString().Equals("2"))
					{
						@class.String_0 = "Die";
					}
					else if (jObject["data"][i]["account_status"].ToString().Equals("3"))
					{
						@class.String_0 = "Need_Pay";
					}
					else if (jObject["data"][i]["account_status"].ToString().Equals("101"))
					{
						@class.String_0 = "Closed";
					}
					else
					{
						@class.String_0 = "Undefined";
					}
					@class.String_8 = "Personal";
					try
					{
						string text2 = "";
						text2 = jObject["data"][i]["business"]["id"].ToString();
						if (!text2.Equals(""))
						{
							@class.String_8 = "Bussiness[" + text2 + "]";
						}
					}
					catch
					{
					}
					try
					{
						@class.A717C383 = jObject["data"][i]["created_time"].ToString();
					}
					catch
					{
					}
					D50EED1D.Add(@class);
				}
				catch
				{
				}
			}
			if (num > 0 && jObject["paging"]["next"] != null)
			{
				string_0 = jObject["paging"]["next"].ToString();
				D50EED1D = AC9FE1AB(E5A3702E, D50EED1D, string_0);
			}
		}
		catch
		{
		}
		return D50EED1D;
	}

	public static List<Class11> smethod_4(HttpRequest A22CC3AC, string AA1CC1A2, string string_0)
	{
		List<Class11> list = new List<Class11>();
		try
		{
			string value = A22CC3AC.Get("https://graph.facebook.com/v14.0/" + AA1CC1A2 + "/owned_ad_accounts?_reqName=object:business/owned_ad_accounts&_reqSrc=BusinessConnectedOwnedAdAccountsStore.brands&date_format=U&fields=[\"all_payment_methods{pm_credit_card{display_string,exp_month,exp_year,is_verified},payment_method_direct_debits{address,can_verify,display_string,is_awaiting,is_pending,status},payment_method_paypal{email_address}\",\"adtrust_dsl\",\"created_time\",\"adspaymentcycle\",\"account_status\",\"id\",\"currency\",\"amount_spent\",\"balance\",\"min_billing_threshold\",\"business\",\"name\",\"timezone_name\",\"light_campaigns\"]&filtering=[{\"field\":\"account_status\",\"operator\":\"NOT_EQUAL\",\"value\":\"6\"}]&limit=500&locale=en_US&method=get&pretty=0&sort=name_ascending&suppress_http_code=1&xref=f3f27221e1cc4&access_token=" + string_0).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			int num = jObject["data"].ToArray().Length;
			for (int i = 0; i < num; i++)
			{
				Class11 @class = new Class11();
				@class.String_1 = jObject["data"][i]["id"].ToString();
				@class.String_2 = jObject["data"][i]["adtrust_dsl"].ToString();
				if (@class.String_2.Equals("-1"))
				{
					@class.String_2 = "Nolimit";
				}
				@class.C9321781 = jObject["data"][i]["name"].ToString();
				@class.String_3 = jObject["data"][i]["currency"].ToString();
				@class.String_10 = "";
				List<string> list2 = new List<string>();
				try
				{
					for (int j = 0; j < jObject["data"][i]["all_payment_methods"]["payment_method_direct_debits"]["data"].ToArray().Length; j++)
					{
						list2.Add(jObject["data"][i]["all_payment_methods"]["payment_method_direct_debits"]["data"][j]["display_string"].ToString());
					}
				}
				catch
				{
				}
				try
				{
					for (int k = 0; k < jObject["data"][i]["all_payment_methods"]["pm_credit_card"]["data"].ToArray().Length; k++)
					{
						string text = jObject["data"][i]["all_payment_methods"]["pm_credit_card"]["data"][k]["is_verified"].ToString();
						list2.Add(string.Concat(str2: (!(text == "True")) ? "Need_Verify" : "Verified", str0: jObject["data"][i]["all_payment_methods"]["pm_credit_card"]["data"][k]["display_string"].ToString(), str1: "->"));
					}
				}
				catch
				{
				}
				try
				{
					for (int l = 0; l < jObject["data"][i]["all_payment_methods"]["payment_method_paypal"]["data"].ToArray().Length; l++)
					{
						list2.Add("Paypal:" + jObject["data"][i]["all_payment_methods"]["payment_method_paypal"]["data"][l]["email_address"].ToString());
					}
				}
				catch
				{
				}
				@class.String_10 = string.Join("| ", list2);
				@class.String_4 = jObject["data"][i]["amount_spent"].ToString();
				@class.String_4 = smethod_0(@class.String_3, @class.String_4);
				try
				{
					@class.AD910B99 = jObject["data"][i]["balance"].ToString();
				}
				catch
				{
				}
				@class.String_5 = "";
				try
				{
					@class.String_5 = jObject["data"][i]["min_billing_threshold"]["amount"].ToString();
				}
				catch
				{
				}
				try
				{
					@class.String_5 = jObject["data"][i]["adspaymentcycle"]["data"][0]["threshold_amount"].ToString();
				}
				catch
				{
				}
				@class.String_5 = smethod_0(@class.String_3, @class.String_5);
				try
				{
					@class.String_7 = jObject["data"][i]["timezone_name"].ToString();
				}
				catch
				{
				}
				try
				{
					if (jObject["data"][i].ToString().Contains("light_campaigns"))
					{
						@class.String_6 = "Yes";
					}
					else
					{
						@class.String_6 = "No";
					}
				}
				catch
				{
				}
				@class.String_0 = "";
				if (jObject["data"][i]["account_status"].ToString().Equals("1"))
				{
					@class.String_0 = "Live";
				}
				else if (jObject["data"][i]["account_status"].ToString().Equals("2"))
				{
					@class.String_0 = "Die";
				}
				else if (jObject["data"][i]["account_status"].ToString().Equals("3"))
				{
					@class.String_0 = "Need_Pay";
				}
				else if (jObject["data"][i]["account_status"].ToString().Equals("101"))
				{
					@class.String_0 = "Closed";
				}
				else
				{
					@class.String_0 = "Undefined";
				}
				try
				{
					@class.A717C383 = D53A7700.smethod_0(long.Parse(jObject["data"][i]["created_time"].ToString())).ToString();
				}
				catch
				{
				}
				@class.String_8 = "Bussiness[" + AA1CC1A2 + "]";
				list.Add(@class);
			}
			if (num > 0 && jObject["paging"]["next"] != null)
			{
				string string_ = jObject["paging"]["next"].ToString();
				list = smethod_5(A22CC3AC, list, string_, AA1CC1A2);
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<Class11> smethod_5(HttpRequest CD159233, List<Class11> A3BF2A1D, string string_0, string string_1)
	{
		try
		{
			string value = CD159233.Get(string_0).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			int num = jObject["data"].ToArray().Length;
			for (int i = 0; i < num; i++)
			{
				try
				{
					Class11 @class = new Class11();
					@class.String_1 = jObject["data"][i]["id"].ToString();
					@class.String_2 = jObject["data"][i]["adtrust_dsl"].ToString();
					if (@class.String_2.Equals("-1"))
					{
						@class.String_2 = "Nolimit";
					}
					@class.C9321781 = jObject["data"][i]["name"].ToString();
					@class.String_3 = jObject["data"][i]["currency"].ToString();
					@class.String_10 = "";
					@class.String_4 = jObject["data"][i]["amount_spent"].ToString();
					@class.String_4 = smethod_0(@class.String_3, @class.String_4);
					try
					{
						@class.AD910B99 = jObject["data"][i]["balance"].ToString();
					}
					catch
					{
					}
					@class.String_5 = "";
					try
					{
						@class.String_5 = jObject["data"][i]["min_billing_threshold"]["amount"].ToString();
					}
					catch
					{
					}
					try
					{
						@class.String_5 = jObject["data"][i]["adspaymentcycle"]["data"][0]["threshold_amount"].ToString();
					}
					catch
					{
					}
					@class.String_5 = smethod_0(@class.String_3, @class.String_5);
					try
					{
						@class.String_7 = jObject["data"][i]["timezone_name"].ToString();
					}
					catch
					{
					}
					try
					{
						if (jObject["data"][i].ToString().Contains("light_campaigns"))
						{
							@class.String_6 = "Yes";
						}
						else
						{
							@class.String_6 = "No";
						}
					}
					catch
					{
					}
					@class.String_0 = "";
					if (jObject["data"][i]["account_status"].ToString().Equals("1"))
					{
						@class.String_0 = "Live";
					}
					else if (jObject["data"][i]["account_status"].ToString().Equals("2"))
					{
						@class.String_0 = "Die";
					}
					else if (jObject["data"][i]["account_status"].ToString().Equals("101"))
					{
						@class.String_0 = "Closed";
					}
					else
					{
						@class.String_0 = "Undefined";
					}
					try
					{
						@class.A717C383 = D53A7700.smethod_0(long.Parse(jObject["data"][i]["created_time"].ToString())).ToString();
					}
					catch
					{
					}
					@class.String_8 = "Bussiness";
					@class.String_8 = "Bussiness[" + string_1 + "]";
					A3BF2A1D.Add(@class);
				}
				catch
				{
				}
			}
			if (num > 0 && jObject["paging"]["next"] != null)
			{
				string_0 = jObject["paging"]["next"].ToString();
				A3BF2A1D = smethod_5(CD159233, A3BF2A1D, string_0, string_1);
			}
		}
		catch
		{
		}
		return A3BF2A1D;
	}

	internal static Class11 smethod_6(HttpRequest F9B724A2, string string_0, string C63EEB2E)
	{
		Class11 @class = new Class11();
		@class.String_1 = string_0;
		try
		{
			string value = F9B724A2.Get("https://graph.facebook.com/v14.0/" + string_0 + "?fields=is_prepay_account,all_payment_methods{pm_credit_card{display_string,is_verified},payment_method_direct_debits{display_string},payment_method_paypal{email_address}},business_country_code,created_time,adtrust_dsl,adspaymentcycle,account_status,id,currency,amount_spent,balance,min_billing_threshold,business,name,timezone_name,light_campaigns&summary=total_count&limit=200&access_token=" + C63EEB2E).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			@class.String_1 = jObject["id"].ToString();
			@class.String_2 = jObject["adtrust_dsl"].ToString();
			if (@class.String_2.Equals("-1"))
			{
				@class.String_2 = "Nolimit";
			}
			@class.C9321781 = jObject["name"].ToString();
			@class.String_3 = jObject["currency"].ToString();
			@class.String_12 = "";
			try
			{
				if (jObject["is_prepay_account"].ToString() == "True")
				{
					@class.String_12 = "TKTT";
				}
				else if (jObject["is_prepay_account"].ToString() == "False")
				{
					@class.String_12 = "TKTS";
				}
			}
			catch
			{
			}
			@class.String_11 = "";
			try
			{
				@class.String_11 = jObject["business_country_code"].ToString();
			}
			catch
			{
			}
			@class.String_10 = "";
			List<string> list = new List<string>();
			try
			{
				for (int i = 0; i < jObject["all_payment_methods"]["payment_method_direct_debits"]["data"].ToArray().Length; i++)
				{
					list.Add(jObject["all_payment_methods"]["payment_method_direct_debits"]["data"][i]["display_string"].ToString());
				}
			}
			catch
			{
			}
			try
			{
				for (int j = 0; j < jObject["all_payment_methods"]["pm_credit_card"]["data"].ToArray().Length; j++)
				{
					string text = jObject["all_payment_methods"]["pm_credit_card"]["data"][j]["is_verified"].ToString();
					list.Add(string.Concat(str2: (!(text == "True")) ? "Need_Verify" : "Verified", str0: jObject["all_payment_methods"]["pm_credit_card"]["data"][j]["display_string"].ToString(), str1: "->"));
				}
			}
			catch
			{
			}
			try
			{
				for (int k = 0; k < jObject["all_payment_methods"]["payment_method_paypal"]["data"].ToArray().Length; k++)
				{
					list.Add("Paypal:" + jObject["all_payment_methods"]["payment_method_paypal"]["data"][k]["email_address"].ToString());
				}
			}
			catch
			{
			}
			@class.String_10 = string.Join("| ", list);
			@class.String_4 = jObject["amount_spent"].ToString();
			@class.String_4 = smethod_0(@class.String_3, @class.String_4);
			@class.AD910B99 = "";
			try
			{
				@class.AD910B99 = jObject["balance"].ToString();
			}
			catch
			{
			}
			@class.String_5 = "";
			try
			{
				@class.String_5 = jObject["min_billing_threshold"]["amount"].ToString();
			}
			catch
			{
			}
			try
			{
				@class.String_5 = jObject["adspaymentcycle"]["data"][0]["threshold_amount"].ToString();
			}
			catch
			{
			}
			@class.String_5 = smethod_0(@class.String_3, @class.String_5);
			try
			{
				@class.String_7 = jObject["timezone_name"].ToString();
			}
			catch
			{
			}
			try
			{
				@class.A717C383 = jObject["created_time"].ToString();
			}
			catch
			{
			}
			try
			{
				if (jObject.ToString().Contains("light_campaigns"))
				{
					@class.String_6 = "Yes";
				}
				else
				{
					@class.String_6 = "No";
				}
			}
			catch
			{
			}
			@class.String_0 = "";
			if (jObject["account_status"].ToString().Equals("1"))
			{
				@class.String_0 = "Live";
			}
			else if (jObject["account_status"].ToString().Equals("2"))
			{
				@class.String_0 = "Die";
			}
			else if (jObject["account_status"].ToString().Equals("3"))
			{
				@class.String_0 = "Need_Pay";
			}
			else if (jObject["account_status"].ToString().Equals("101"))
			{
				@class.String_0 = "Closed";
			}
			else if (jObject["account_status"].ToString().Equals("100"))
			{
				@class.String_0 = "Pending_Closed";
			}
			else
			{
				@class.String_0 = "Undefined";
			}
			@class.String_8 = "Personal";
			string text2 = "";
			try
			{
				text2 = jObject["business"]["id"].ToString();
				if (!text2.Equals(""))
				{
					@class.String_8 = "Bussiness[" + text2 + "]";
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
		return @class;
	}

	public static string smethod_7(HttpRequest BF2C1534, string D08354BE)
	{
		string text = "";
		try
		{
			BF2C1534.AddHeader("viewport-width", "1229");
			BF2C1534.AddHeader("sec-ch-ua-mobile", "?0");
			BF2C1534.AddHeader("Upgrade-Insecure-Requests", "1");
			BF2C1534.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
			BF2C1534.AddHeader("Sec-Fetch-Site", "none");
			BF2C1534.AddHeader("Sec-Fetch-Mode", "navigate");
			BF2C1534.AddHeader("Sec-Fetch-User", "?1");
			BF2C1534.AddHeader("Sec-Fetch-Dest", "document");
			BF2C1534.Referer = "https://www.facebook.com/";
			string str = BF2C1534.Get(D08354BE).ToString();
			try
			{
				text = Regex.Match(Regex.Unescape(str), "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
				if (text.Length > 20)
				{
					return text;
				}
			}
			catch
			{
			}
			try
			{
				text = Regex.Match(Regex.Unescape(str), "\"token\":\"(.*?)\"").Groups[1].Value;
				if (text.Length > 20)
				{
					return text;
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
		return text;
	}

	public static bool smethod_8(HttpRequest httpRequest_0, string CA9A5EA5, string string_0, string string_1)
	{
		try
		{
			string text = httpRequest_0.Post("https://graph.facebook.com/v14.0/act_" + CA9A5EA5.Replace("act_", "") + "?access_token=" + string_1 + "&__cppo=1", "name=" + string_0 + "&pretty=0&suppress_http_code=1&transport=cors", "application/x-www-form-urlencoded").ToString();
			if (text.Contains("success") && text.Contains("true"))
			{
				return true;
			}
			return false;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_9(HttpRequest httpRequest_0, string E18B4218, string string_0, string CA001D23, string string_1)
	{
		try
		{
			string text = httpRequest_0.Get("https://graph.facebook.com/v14.0/" + E18B4218 + "/users?uid=" + string_0 + "&role=" + string_1 + "&method=post&access_token=" + CA001D23).ToString();
			if (text.Contains("success") && text.Contains("true"))
			{
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool smethod_10(HttpRequest httpRequest_0, string string_0, string string_1, string string_2)
	{
		try
		{
			string str = "_reqName=object%3Abrand%2Fowned_ad_accounts&_reqSrc=AdAccountActions.brands&access_type=OWNER&adaccount_id=act_" + string_1.Replace("act_", "") + "&locale=en_US&method=post&pretty=0&suppress_http_code=1&xref=f1a8bc7e73b6aa4";
			string text = httpRequest_0.Post("https://graph.facebook.com/v14.0/" + string_0 + "/owned_ad_accounts?access_token=" + string_2, str, "application/x-www-form-urlencoded").ToString();
			if (text.Contains("PENDING"))
			{
				return true;
			}
			if (text.Contains("success"))
			{
				return true;
			}
			if (text.Contains("CONFIRMED"))
			{
				return true;
			}
			if (text.Contains("error"))
			{
				return false;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool smethod_11(HttpRequest D117D538, string string_0, string F58E8214, string FC2F49AB)
	{
		try
		{
			string str = "_reqName=object%3Abrand%2Fclient_ad_accounts&_reqSrc=AdAccountActions.brands&access_type=AGENCY&adaccount_id=act_" + F58E8214.Replace("act_", "") + "&locale=en_US&method=post&permitted_roles=%5B%5D&permitted_tasks=%5B%22ADVERTISE%22%2C%22ANALYZE%22%2C%22DRAFT%22%2C%22MANAGE%22%5D&pretty=0&suppress_http_code=1&xref=f15342f7e53d064";
			string text = D117D538.Post("https://graph.facebook.com/v14.0/" + string_0 + "/client_ad_accounts?access_token=" + FC2F49AB, str, "application/x-www-form-urlencoded").ToString();
			if (text.Contains("You are trying to assign a duplicated asset"))
			{
				return true;
			}
			if (text.Contains("error"))
			{
				return false;
			}
			if (text.Contains("CONFIRMED"))
			{
				return true;
			}
			if (text.Contains("success"))
			{
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool B3A6D807(HttpRequest A6B4B098, string CB2322AE, string B8BFD130, string FD922F10, string string_0)
	{
		string userAgent = A6B4B098.UserAgent;
		try
		{
			A6B4B098.AddHeader("sec-fetch-dest", "empty");
			A6B4B098.AddHeader("sec-fetch-mode", "cors");
			A6B4B098.AddHeader("sec-fetch-site", "same-origin");
			A6B4B098.Referer = "https://www.facebook.com/ads/manager/account_settings/information/?act=" + B8BFD130 + "&pid=p1&page=account_settings&tab=account_information";
			string str = "jazoest=21995&fb_dtsg=" + string_0 + "&__user=" + FD922F10 + "&__a=1&__dyn=7xeUmBz8aolJ28S2q5C78DxGuml4WqxuUgBwCwgEpyAieGqFEkxqqaScwNxK4V9HgC37GiidBz9ouGfyUeK4qxa6US2SfUCrpoS488o8ogzAayU4a5HyoyazoO4oK7EmDgaoaEix6dxa7FEhwywCxq22qdwJxKaCwTxqWBBKfxJedUcd5ypUK2dum4E8EKUV2UC4F8K1IxN1ap3bwEylhUeEjx63K2y11xny-cyobo4a5UlBU4-7UO7o9bBDxWbwAzU8EeAUy4bxS11DxSbg94bxR2V8W2e2i3mbxOfwXxq1iyXxJxK48G2q4kUy26U8U-Uqxe1dx-q4VEhwwwnEfp8bU-dwKwHxa2-m3Cbxu3ydCgqw-z8c8-5aDBwEBwKG3qcybxm58kx24oKqbDyoOEbVEHyU8Uiwc-u1HwhrwiU8Uow&__csr=&__req=y&__hs=19098.BP%3Aads_campaign_manager_pkg.2.0.0.0.&dpr=1&__ccg=EXCELLENT&__rev=1005366273&__s=37rd7y%3Ae6jfce%3Amyrqi1&__hsi=7087309889648283706-0&__comet_req=0&lsd=pBRk6LHMhTHIu61aD9jeZ1&__spin_r=1005366273&__spin_b=trunk&__spin_t=1650142923";
			string text = A6B4B098.Post("https://www.facebook.com/ads/manage/settings/remove_user/?user_id=" + CB2322AE + "&act=" + B8BFD130.Replace("act_", "") + "&is_new_account_settings=1", str, "application/x-www-form-urlencoded").ToString();
			A6B4B098.UserAgent = userAgent;
			if (text.StartsWith("for (;;);{\"__ar\":1,\"payload\":{}"))
			{
				return true;
			}
			if (text.Contains("error"))
			{
				return false;
			}
		}
		catch (Exception)
		{
		}
		A6B4B098.UserAgent = userAgent;
		return false;
	}

	public static bool smethod_12(HttpRequest httpRequest_0, string string_0, string string_1, string D0155E8E)
	{
		try
		{
			httpRequest_0.Referer = "https://www.facebook.com/ads/manager/account_settings/notification_preferences/?act=" + string_0.Replace("act_", "") + "&pid=p1&page=account_settings&tab=account_notifications";
			string text = httpRequest_0.Post("https://www.facebook.com/ads/manager/post_all_adaccount_notifications/?ad_account_id=" + string_0.Replace("act_", "") + "&is_adaccount_notifications_enabled=false", "__user=" + D0155E8E + "&__a=1&__dyn=7xeUmBz8aolJ28S2q3m9U8EJ4Wqxu6E9E4a6oF1eFGxK5FEG48corxebJ2ocWAAzpoixWE-bwWxeEixKdwJz-4dxe484e486C6EC8yEScx611wOwGwOxa7FEhwywCxq22q3K6UGq3u5HGmm2ZedUcd5yojwznBwRyXxK9xai1UxO4VAcK2y5oeEjz98eUvy8465udz8C2S12xu7o6-cwgHBDxWbwQwywWjy8gK7o46u2B0AgK7k48W2e2i3mbxOfwkE5WUrorx2awCx5e8wxK2efxW4U4S7VEjCx6220D98bU-dwKwHxa1oxqbxu3ydCgqw-z8c8-5azotyFobGwSz8y1kx6bCyVUCcG2-qaUK0gq&__csr=&__req=u&__hs=18910.BP%3Aads_campaign_manager_pkg.2.0.0.0.&dpr=1.5&__ccg=GOOD&__rev=1004529645&__s=1yignp%3Aogi7ha%3A08cn8c&__hsi=7017453134614421750-0&__comet_req=0&fb_dtsg=" + string_1 + "&jazoest=22137&lsd=ZXq-1MXAHTYBPUsei1q8Yu&__spin_r=1004529645&__spin_b=trunk&__spin_t=1633878130", "application/x-www-form-urlencoded").ToString();
			if (text.Contains("payload\":null") && !text.StartsWith("for (;;);{\"__ar\":1,\"error\""))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_13(HttpRequest httpRequest_0, string string_0, string BA8C39A3, string string_1)
	{
		try
		{
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_14(HttpRequest E09D76AD, string F4AA1C25, string string_0, string string_1)
	{
		try
		{
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_15(HttpRequest EF90EA9E, string A9BFF287, string string_0, string string_1, string C5344199, string string_2, string C31DC6AC, string string_3, string string_4, string string_5, string string_6, string string_7, string CFA54309)
	{
		try
		{
			if (string_3.Equals("US") || 0 == 0)
			{
				EF90EA9E.AddHeader("origin", "https://www.facebook.com");
				EF90EA9E.AddHeader("referer", "https://www.facebook.com/");
				EF90EA9E.AddHeader("sec-ch-ua-mobile", "?0");
				EF90EA9E.AddHeader("sec-ch-ua-platform", "\"Windows\"");
				EF90EA9E.AddHeader("sec-fetch-dest", "empty");
				EF90EA9E.AddHeader("sec-fetch-mode", "cors");
				EF90EA9E.AddHeader("sec-fetch-site", "same-site");
				EF90EA9E.AddHeader("x-fb-friendly-name", "useBillingAddCreditCardMutation");
				string str = "av=" + string_7 + "&payment_dev_cycle=prod&__usid=6-Trdgmhgcnjxos%3APrdgo1csm3m81%3A0-Ardgl8ny864nh-RV%3D6%3AF%3D&__user=" + string_7 + "&__a=1&__dyn=7xeUmBz8fXgydwCwRyu2abBWqxK49o9E4a2imeGqErxSaScwNxK4UKewSAAzpoixWE-bwjElxKdwJz-9yEjx226264824yoyaxG4oaEugaoaEix6221qwCwuE9FEdUmCBBwLghUcd5xS2dum4E8EKUryonwu8sgiCggwExm3G4UhwXwEwl-dz8dU5G5o24xS2iUS7E421uK6o8o47BxSbg942B12ewzwAwgoszUeUmwkEK7S6UgyE9Ehjy88rwzzXxG4U4S2q4UowwwnEfp8fUS2W2K4EbVo4m1uCgqw8O58Gm0BUO1tx64EKu9zawSyES2e0UFU6K15K1bwzxy&__req=1r&__hs=19157.BP%3Aads_campaign_manager_pkg.2.0.0.0.&dpr=1&__ccg=EXCELLENT&__rev=1005679448&__s=3c4lzu%3Az19wbn%3Aq7xira&__hsi=7109027325917137157-0&__comet_req=0&fb_dtsg=" + CFA54309 + "&jazoest=25533&lsd=y_UXx905vl2qfKjcvKkMLU&__spin_r=1005679448&__spin_b=trunk&__spin_t=1655199408&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=useBillingAddCreditCardMutation&variables=%7B%22input%22%3A%7B%22billing_address%22%3A%7B%22country_code%22%3A%22" + string_3 + "%22%7D%2C%22billing_logging_data%22%3A%7B%22logging_counter%22%3A13%2C%22logging_id%22%3A%223437546495%22%7D%2C%22cardholder_name%22%3A%22" + string_6 + "%22%2C%22credit_card_first_6%22%3A%7B%22sensitive_string_value%22%3A%22" + string_1.Substring(0, 6) + "%22%7D%2C%22credit_card_last_4%22%3A%7B%22sensitive_string_value%22%3A%22" + string_1.Substring(string_1.Length - 4) + "%22%7D%2C%22credit_card_number%22%3A%7B%22sensitive_string_value%22%3A%22" + string_1 + "%22%7D%2C%22csc%22%3A%7B%22sensitive_string_value%22%3A%22" + C5344199 + "%22%7D%2C%22expiry_month%22%3A%22" + string_2 + "%22%2C%22expiry_year%22%3A%22" + C31DC6AC + "%22%2C%22payment_account_id%22%3A%22" + string_0.Replace("act_", "") + "%22%2C%22payment_type%22%3A%22MOR_ADS_INVOICE%22%2C%22unified_payments_api%22%3Atrue%2C%22actor_id%22%3A%22" + string_7 + "%22%2C%22client_mutation_id%22%3A%225%22%7D%7D&server_timestamps=true&doc_id=4126726757375265";
				string text = EF90EA9E.Post("https://secure.facebook.com/ajax/payment/token_proxy.php?tpe=%2Fapi%2Fgraphql%2F", str, "application/x-www-form-urlencoded").ToString();
				if (text.Contains("card_association"))
				{
					return true;
				}
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool FC12FBA1(HttpRequest httpRequest_0, string string_0, string D32B4D2A)
	{
		try
		{
			string input = httpRequest_0.Get("https://graph.facebook.com/v9.0/act_" + D32B4D2A.Replace("act_", "") + "?fields=account_status&access_token=" + string_0).ToString();
			string value = Regex.Match(input, "\"account_status\": (\\d+),").Groups[1].Value;
			if (value == "1")
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool B2077BB9(HttpRequest httpRequest_0, string string_0, string D411F1AA)
	{
		try
		{
			string text = httpRequest_0.Get("https://graph.facebook.com/v7.0/graphql?access_token=" + D411F1AA + "&variables={\"input\":{\"client_mutation_id\":\"6\",\"billable_account_payment_legacy_account_id\":\"" + string_0.Replace("act_", "") + "\",\"entry_point\":\"BILLING_2_0\"}}&doc_id=" + "3514448948659909" + "&method=post").ToString();
			if (text.Replace(" ", "").Contains("\"success\":true"))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool CD0C4904(HttpRequest B70CF435, string string_0, string C303FCBF, string string_1, string string_2, string DCAE223D)
	{
		try
		{
			string str = "__user=" + DCAE223D + "&__a=1&__dyn=7xeUmBz8aolJ28S2q3mbwyyVuCEb9o9E4a2i5aCwRCwqojyUV0OGiidBxa7GzU4q5EbES2SfUg-2i13x21FxG9y8Gdz8hwgo5S3a4EuCx62a2q5E9UeUryE5mWBBwQzocJ3UdRDwRyUvyonwu8sxe5bwEwk89oeUa8fGxnzoO9ws82Bz84aVpUuyUd88EeAUpK7o46u2B0Agak48W18wRwEwiUmwnHxJxK48G2q4kUy26U8U-UqAzE4S7VEjCx6220D8d8-dwKwHxa1LyUnwUzpA6EfEO32fxiFVoa9obGwgUy1kx6bCyVUCfwLCyKbwzweau0IrwiU8Uow&__csr=&__req=11&__hs=19156.BP%3Abrands_pkg.2.0.0.0.&dpr=1&__ccg=EXCELLENT&__rev=1005672342&__s=q85kh6%3Abmd2ew%3Ahcaq73&__hsi=7108637197964813136-0&__comet_req=0&fb_dtsg=" + string_2 + "&jazoest=25472&lsd=1GGtqTdHYa0ElbkDLlPP7N&__spin_r=1005672342&__spin_b=trunk&__spin_t=1655108573&__jssesw=1";
			string text = B70CF435.Post("https://business.facebook.com/business/objects/add/connections/?business_id=" + string_1 + "&from_id=" + C303FCBF + "&from_asset_type=pixel&to_id=" + string_0.Replace("act_", "") + "&to_asset_type=ad-account", str, "application/x-www-form-urlencoded").ToString();
			if (text.Contains("for (;;);{\"__ar\":1,\"payload\":"))
			{
				return true;
			}
			return false;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_16(HttpRequest F8AAEC2C, string F4913AB2, string string_0, string string_1, string string_2)
	{
		try
		{
			if (!smethod_17(F8AAEC2C, F4913AB2, string_0) && !BB2F4D01(F8AAEC2C, F4913AB2, "{53}Vietnamese Dong (VND)", "\"Asia/Ho_Chi_Minh\":{Ho Chi Minh Time\" Múi giờ:\"+07:00\"}", "VN", "", string_0))
			{
				return false;
			}
			string text = F8AAEC2C.Get(string.Concat(new string[4]
			{
				"https://graph.facebook.com/graphql?method=post&locale=vi_VN&doc_id=",
				"3921069624645957",
				"&variables={\"input\":{\"billable_account_payment_legacy_account_id\":\"" + F4913AB2.Replace("act_", "") + "\",\"logging_data\":{\"logging_counter\":11,\"logging_id\":\"1527407049\"},\"recurring_enabled\":false,\"actor_id\":\"" + string_1 + "\",\"client_mutation_id\":\"1\"}}&access_token=",
				string_0
			})).ToString();
			if (text.Contains("create_stored_balance_for_ad_account") || text.Contains("stored_balance_status"))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_17(HttpRequest httpRequest_0, string string_0, string string_1)
	{
		try
		{
			string text = httpRequest_0.Get("https://graph.facebook.com/v9.0/act_" + string_0.Replace("act_", "") + "?fields=currency,timezone_id,business_country_code&access_token=" + string_1).ToString();
			if (text.Contains("\"currency\": \"VND\",") && text.Contains("\"timezone_id\": 140,") && text.Contains("\"business_country_code\": \"VN\","))
			{
				return true;
			}
			return false;
		}
		catch
		{
		}
		return false;
	}

	public static bool D501A3BF(HttpRequest A698A18C, string string_0, string string_1, string E58B83B4, string B9BA09BD, string BE946D39, string string_2, string B82D47B9)
	{
		try
		{
			E58B83B4 = E58B83B4.Split('(')[1].Replace(")", "");
			B9BA09BD = B9BA09BD.Split(':')[0].Replace("\"", "");
		}
		catch
		{
		}
		BE946D39 = BE946D39.Replace(" ", "");
		BE946D39 = BE946D39.ToUpper();
		try
		{
			string text = "";
			if (BE946D39 == "us" || !(BE946D39 == "US"))
			{
			}
			if (BE946D39 == "BR")
			{
				text = ",\"tax_id\":\"17600195000103\",\"tax_id_type\":\"BRAZIL_CNPJ\"";
			}
			if (string_2 != string.Empty)
			{
				string_2 = "\"name\":\"" + string_2 + "\",";
			}
			string text2 = A698A18C.Get("https://graph.facebook.com/v7.0/graphql?access_token=" + B82D47B9 + "&variables={\"input\":{\"billable_account_payment_legacy_account_id\":\"" + string_0.Replace("act_", "") + "\"," + string_2 + "\"currency\":\"" + E58B83B4 + "\",\"logging_data\":{\"logging_counter\":7,\"logging_id\":\"1948616665\"},\"tax\":{\"business_address\":{\"city\":\"\",\"country_code\":\"" + BE946D39 + "\",\"state\":\"\",\"street1\":\"\",\"street2\":\"\",\"zip\":\"\"},\"business_name\":\"truongphamfb.com\",\"is_personal_use\":false" + text + "},\"timezone\":\"" + B9BA09BD + "\",\"actor_id\":\"" + string_1 + "\",\"client_mutation_id\":\"4\"}}&doc_id=" + "5428097817221702" + "&method=post").ToString();
			if (text2.Contains("billable_account_tax_info"))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool BB2F4D01(HttpRequest F80878A9, string string_0, string F79EEA2B, string BC25F617, string F8397D8B, string string_1, string string_2)
	{
		F79EEA2B = F79EEA2B.Split('(')[1].Replace(")", "");
		BC25F617 = BC25F617.Split(':')[0].Replace("\"", "").Replace("/", "%2F");
		try
		{
			if (string_1 != string.Empty)
			{
				string_1 = "\"name\":\"" + string_1 + "\",";
			}
			string text = F80878A9.Get("https://graph.facebook.com/graphql?method=post&pretty=false&format=json&doc_id=" + "5428097817221702" + "&server_timestamps=true&variables={\"input\":{\"billable_account_payment_legacy_account_id\":\"" + string_0.Replace("act_", "") + "\"," + string_1 + "\"timezone\":\"" + BC25F617 + "\",\"currency\":\"" + F79EEA2B + "\",\"tax\":{\"business_address\":{\"city\":\"\",\"country_code\":\"" + F8397D8B + "\",\"state\":\"Ha Noi\",\"street1\":\"Ha Noi\",\"street2\":\"VietName\",\"zip\":\"10000\"},\"business_name\":\"DOGETOOL\",\"is_personal_use\":false},\"client_mutation_id\":\"3\"}}&access_token=" + string_2).ToString();
			if (text.Contains("billable_account_tax_info"))
			{
				return true;
			}
			return false;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_18(HttpRequest httpRequest_0, string string_0, string string_1, string D527C593, string F2B18B0B, string A8B6792C, string string_2)
	{
		string_1 = string_1.Split('(')[1].Replace(")", "");
		D527C593 = D527C593.Split(':')[0].Replace("\"", "").Replace("/", "%2F");
		try
		{
			if (A8B6792C != string.Empty)
			{
				A8B6792C = "\"name\":\"" + A8B6792C + "\",";
			}
			string text = httpRequest_0.Get("https://graph.facebook.com/graphql?method=post&pretty=false&format=json&doc_id=" + "5428097817221702" + "&server_timestamps=true&variables={\"input\":{\"billable_account_payment_legacy_account_id\":\"" + string_0.Replace("act_", "") + "\"," + A8B6792C + "\"timezone\":\"" + D527C593 + "\",\"currency\":\"" + string_1 + "\",\"tax\":{\"business_address\":{\"city\":\"\",\"country_code\":\"" + F2B18B0B + "\",\"state\":\"Ha Noi\",\"street1\":\"Ha Noi\",\"street2\":\"VietName\",\"zip\":\"10000\"},\"business_name\":\"DOGETOOL\",\"is_personal_use\":false},\"client_mutation_id\":\"3\"}}&access_token=" + string_2).ToString();
			if (text.Contains("billable_account_tax_info"))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static string smethod_19(HttpRequest httpRequest_0, string B39CC223, string string_0, string D114DBAA, string string_1, string string_2, string string_3)
	{
		try
		{
			string_0 = string_0.Split('(')[1].Replace(")", "");
			D114DBAA = D114DBAA.Split(':')[0].Replace("\"", "").Replace("/", "%2F");
		}
		catch
		{
		}
		try
		{
			string value = httpRequest_0.Get(string.Concat("https://graph.facebook.com/graphql?method=post&fb_api_req_friendly_name=BillingAccountInformationUtilsCreateAccountMutation&variables=%7B%22input%22%3A%7B%22current_payment_legacy_account_id%22%3A%22", B39CC223.Replace("act_", ""), "%22%2C%22logging_data%22%3A%7B%22logging_counter%22%3A17%2C%22logging_id%22%3A%22%22%7D%2C%22new_country_code%22%3A%22", string_1, "%22%2C%22new_currency_code%22%3A%22", string_0, "%22%2C%22new_tax%22%3A%7B%22business_address%22%3A%7B%22city%22%3A%22%22%2C%22country_code%22%3A%22", string_1, "%22%2C%22state%22%3A%22%22%2C%22street1%22%3A%22%22%2C%22street2%22%3A%22%22%2C%22zip%22%3A%22%22%7D%2C%22business_name%22%3A%22%22%2C%22is_personal_use%22%3Afalse%2C%22tax_exempt%22%3Afalse%2C%22tax_id%22%3A%22%22%7D%2C%22new_timezone%22%3A%22" + D114DBAA + "%22%2C%22actor_id%22%3A%22", string_3, "%22%2C%22client_mutation_id%22%3A%222%22%7D%7D&server_timestamps=true&doc_id=4649659218451741&access_token=", string_2)).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			return jObject["data"]["new_billable_account_from_old"]["new_account"]["billing_payment_account"]["id"].ToString();
		}
		catch
		{
		}
		return "";
	}

	internal static List<string> A8AF7725(HttpRequest httpRequest_0, string D583F29F, string C697B1B7)
	{
		List<string> list = new List<string>();
		try
		{
			string value = httpRequest_0.Get("https://graph.facebook.com/v14.0/act_" + D583F29F.Replace("act_", "") + "?fields=users{id}&access_token=" + C697B1B7).ToString();
			try
			{
				JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
				for (int i = 0; i < jObject["users"]["data"].ToArray().Length; i++)
				{
					try
					{
						list.Add(jObject["users"]["data"][i]["id"].ToString() ?? "");
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
		return list;
	}

	public static string smethod_20(HttpRequest httpRequest_0, string string_0)
	{
		string text = "";
		try
		{
			string value = httpRequest_0.Get("https://graph.facebook.com/me?access_token=" + string_0).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			return jObject["id"].ToString();
		}
		catch
		{
		}
		return text ?? "";
	}

	public static string smethod_21(HttpRequest C81BF285, string string_0, string F40B7F25)
	{
		string text = D8A05018(C81BF285, string_0, F40B7F25).Split(' ')[0];
		string text2 = smethod_22(C81BF285, F40B7F25);
		return text + "|" + text2;
	}

	public static string D8A05018(HttpRequest A80FEE8C, string string_0, string string_1)
	{
		string text = "";
		try
		{
			string value = A80FEE8C.Get("https://graph.facebook.com/graphql?q=nodes(" + string_0 + ")%7Bregistration_time,friends%7Bcount%7D%7D&access_token=" + string_1).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			return D53A7700.smethod_0(long.Parse(jObject[string_0]["registration_time"].ToString())).ToString();
		}
		catch
		{
		}
		return text ?? "";
	}

	public static string smethod_22(HttpRequest FF33048D, string C6B139BC)
	{
		string text = "";
		string text2 = "";
		try
		{
			string value = FF33048D.Get("https://graph.facebook.com/me/?fields=birthday,gender&access_token=" + C6B139BC).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			try
			{
				text = jObject["birthday"].ToString();
			}
			catch
			{
			}
			try
			{
				text2 = jObject["gender"].ToString();
			}
			catch
			{
			}
		}
		catch
		{
		}
		return text + "|" + text2;
	}

	public static string D32A9897(HttpRequest E62540A9, string string_0, string string_1)
	{
		string text = "";
		try
		{
			string value = E62540A9.Get("https://graph.facebook.com/graphql?q=nodes(" + string_0 + ")%7Bregistration_time,friends%7Bcount%7D%7D&access_token=" + string_1).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			return jObject[string_0]["friends"]["count"].ToString();
		}
		catch
		{
		}
		return text ?? "";
	}

	public static List<string> smethod_23(HttpRequest httpRequest_0, string EF371ABC, string E1B1B196)
	{
		string userAgent = httpRequest_0.UserAgent;
		List<string> list = new List<string>();
		try
		{
			httpRequest_0.UserAgent = "[FBAN/FB4A;FBAV/306.0.0.38.119;FBBV/273654209;FBDM/{density=2.0,width=1600,height=900},FBMF/samsung;FBBD/samsung;FBPN/com.facebook.katana;FBDV/SM-G973N;FBSV/7.1.2;FBOP/1;FBCA/x86:armeabi-v7a;]";
			string value = httpRequest_0.Get("https://graph.facebook.com/graphql?doc_id=5615255645158576&method=post&pretty=false&format=json&variables=%7B%22profileID%22:%22" + EF371ABC + "%22,%22profile_switcher_connection_first%22:200%7D&access_token=" + E1B1B196).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			for (int i = 0; i < jObject["data"]["user"]["profile_switcher_eligible_profiles"]["edges"].ToArray().Length; i++)
			{
				try
				{
					string text = jObject["data"]["user"]["profile_switcher_eligible_profiles"]["edges"][i]["node"]["profile"]["id"].ToString();
					string text2 = jObject["data"]["user"]["profile_switcher_eligible_profiles"]["edges"][i]["node"]["profile"]["name"].ToString();
					list.Add(text + "_" + text2);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		httpRequest_0.UserAgent = userAgent;
		return list;
	}

	public static List<string> E4820929(HttpRequest httpRequest_0, string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			string value = httpRequest_0.Get("https://graph.facebook.com/v2.5/me/accounts?fields=likes,followers_count,name,verification_status&limit=1000&access_token=" + string_0).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			for (int i = 0; i < jObject["data"].ToArray().Length; i++)
			{
				try
				{
					string text = jObject["data"][i]["id"].ToString();
					string text2 = "-";
					string text3 = "-";
					string text4 = "";
					try
					{
						text3 = jObject["data"][i]["likes"].ToString();
					}
					catch
					{
					}
					try
					{
						text2 = jObject["data"][i]["followers_count"].ToString();
					}
					catch
					{
					}
					try
					{
						text4 = jObject["data"][i]["verification_status"].ToString();
					}
					catch
					{
					}
					list.Add(text + "_" + text3 + "Likes_" + text2 + "Followers_" + text4);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_24(HttpRequest httpRequest_0, string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			string value = httpRequest_0.Get("https://graph.facebook.com/me/groups?fields=id,name,member_count,administrator&limit=5000&access_token=" + string_0).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			for (int i = 0; i < jObject["data"].ToArray().Length; i++)
			{
				try
				{
					if (jObject["data"][i]["administrator"].ToString().Contains("rue"))
					{
						string text = jObject["data"][i]["id"].ToString();
						string text2 = jObject["data"][i]["member_count"].ToString();
						list.Add(text + "_" + text2 + "members");
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_25(HttpRequest httpRequest_0, string E0AA539F)
	{
		List<string> list = new List<string>();
		try
		{
			string value = httpRequest_0.Get("https://graph.facebook.com/v14.0/me/adaccounts?fields=adtrust_dsl,adspaymentcycle,account_status,id,currency,amount_spent,balance,min_billing_threshold,business,name&summary=total_count&limit=5000&access_token=" + E0AA539F).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			for (int i = 0; i < jObject["data"].ToArray().Length; i++)
			{
				try
				{
					string text = jObject["data"][i]["id"].ToString();
					string text2 = jObject["data"][i]["adtrust_dsl"].ToString();
					if (text2.Equals("-1"))
					{
						text2 = "nolimit";
					}
					string text3 = jObject["data"][i]["currency"].ToString();
					string text4 = jObject["data"][i]["amount_spent"].ToString();
					try
					{
						if (text3.Contains("USD") || text3.Contains("CAD") || text3.Contains("CHF") || text3.Contains("EUR") || text3.Contains("KYD") || text3.Contains("CNY") || text3.Contains("GBP") || text3.Contains("JOD") || text3.Contains("OMR") || text3.Contains("BHD") || text3.Contains("KWD") || text3.Contains("AUD") || text3.Contains("AZN"))
						{
							text4 = text4.Substring(0, text4.Length - 2);
						}
					}
					catch
					{
					}
					string text5 = "";
					try
					{
						text5 = jObject["data"][i]["min_billing_threshold"]["amount"].ToString();
					}
					catch
					{
					}
					try
					{
						text5 = jObject["data"][i]["adspaymentcycle"]["data"][0]["threshold_amount"].ToString();
						if (text3.Contains("USD") || text3.Contains("CAD") || text3.Contains("CHF") || text3.Contains("EUR") || text3.Contains("KYD") || text3.Contains("CNY") || text3.Contains("GBP") || text3.Contains("JOD") || text3.Contains("OMR") || text3.Contains("BHD") || text3.Contains("KWD") || text3.Contains("AUD") || text3.Contains("AZN"))
						{
							text5 = text5.Substring(0, text5.Length - 2);
						}
					}
					catch
					{
					}
					string text6 = "";
					text6 = (jObject["data"][i]["account_status"].ToString().Equals("1") ? "Hoạt động" : (jObject["data"][i]["account_status"].ToString().Equals("2") ? "Hđbt" : ((!jObject["data"][i]["account_status"].ToString().Equals("101")) ? "kxđ" : "101")));
					string text7 = "";
					try
					{
						text7 = jObject["data"][i]["business"]["id"].ToString() + "_";
					}
					catch
					{
					}
					string text8 = "0";
					try
					{
						text8 = jObject["data"][i]["balance"].ToString();
						if (text3.Contains("USD") || text3.Contains("CAD") || text3.Contains("CHF") || text3.Contains("EUR") || text3.Contains("KYD") || text3.Contains("CNY") || text3.Contains("GBP") || text3.Contains("JOD") || text3.Contains("OMR") || text3.Contains("BHD") || text3.Contains("KWD") || text3.Contains("AUD") || text3.Contains("AZN"))
						{
							text8 = text8.Substring(0, text8.Length - 2);
						}
					}
					catch
					{
					}
					string text9 = "";
					try
					{
						string text10 = text5;
						if ((text3.Contains("USD") || text3.Contains("CAD") || text3.Contains("CHF") || text3.Contains("EUR") || text3.Contains("KYD") || text3.Contains("CNY") || text3.Contains("GBP") || text3.Contains("JOD") || text3.Contains("OMR") || text3.Contains("BHD") || text3.Contains("KWD") || text3.Contains("AUD") || text3.Contains("AZN")) && text10.EndsWith(",00"))
						{
							text10 = text10.Substring(0, text5.Length - 3);
						}
						text9 = (float.Parse(text10.Replace(",", "")) - float.Parse(text8.Replace(",", ""))).ToString();
					}
					catch
					{
					}
					if (text7.Equals(""))
					{
						list.Add("limit: " + text2 + " " + text3 + "_Ngưỡng hiện tại: " + text5 + " " + text3 + "_Đãtiêu: " + text4 + " " + text3 + "_Trạngthái: " + text6 + "_Uid: " + text + "_CònLại: " + text9 + " " + text3);
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_26(HttpRequest httpRequest_0, string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			string value = httpRequest_0.Get("https://graph.facebook.com/v14.0/me/adaccounts?fields=adtrust_dsl,adspaymentcycle,account_status,id,currency,amount_spent,balance,min_billing_threshold,business,name&summary=total_count&limit=5000&access_token=" + string_0).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			for (int i = 0; i < jObject["data"].ToArray().Length; i++)
			{
				try
				{
					string text = jObject["data"][i]["id"].ToString();
					string text2 = jObject["data"][i]["adtrust_dsl"].ToString();
					if (text2.Equals("-1"))
					{
						text2 = "nolimit";
					}
					string text3 = jObject["data"][i]["currency"].ToString();
					string text4 = jObject["data"][i]["amount_spent"].ToString();
					try
					{
						text4 = text4.Substring(0, text4.Length - 2);
					}
					catch
					{
					}
					string text5 = "";
					try
					{
						text5 = jObject["data"][i]["min_billing_threshold"]["amount"].ToString();
					}
					catch
					{
					}
					try
					{
						text5 = jObject["data"][i]["adspaymentcycle"]["data"][0]["threshold_amount"].ToString();
						text5 = text5.Substring(0, text5.Length - 2);
					}
					catch
					{
					}
					string text6 = "";
					text6 = (jObject["data"][i]["account_status"].ToString().Equals("1") ? "Hoạt động" : ((!jObject["data"][i]["account_status"].ToString().Equals("2")) ? "kxđ" : "Hđbt"));
					string text7 = "";
					try
					{
						text7 = jObject["data"][i]["business"]["id"].ToString() + "_";
					}
					catch
					{
					}
					string text8 = "";
					try
					{
						text8 = jObject["data"][i]["name"].ToString();
					}
					catch
					{
					}
					list.Add("limit: " + text2 + " " + text3 + "_Ngưỡng hiện tại: " + text5 + " " + text3 + "_Đãtiêu: " + text4 + " " + text3 + "_Trạngthái: " + text6 + "_Uid: " + text7 + text + "_" + text8);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> smethod_27(HttpRequest CEBF6C16, string string_0)
	{
		List<string> list = new List<string>();
		try
		{
			string value = CEBF6C16.Get("https://graph.facebook.com/v14.0/me/businesses?fields=name,id,owned_ad_accounts{id,adtrust_dsl,adspaymentcycle,account_status,currency,amount_spent,balance,min_billing_threshold,name}&limit=5000&access_token=" + string_0).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			int num = jObject["data"].ToArray().Length;
			for (int i = 0; i < num; i++)
			{
				int num2 = 0;
				try
				{
					num2 = jObject["data"][i]["owned_ad_accounts"]["data"].ToArray().Length;
				}
				catch
				{
				}
				for (int j = 0; j < num2; j++)
				{
					try
					{
						string text = "";
						try
						{
							text = jObject["data"][i]["id"].ToString();
						}
						catch
						{
						}
						string text2 = "";
						try
						{
							text2 = jObject["data"][i]["name"].ToString();
						}
						catch
						{
						}
						string text3 = jObject["data"][i]["owned_ad_accounts"]["data"][j]["id"].ToString();
						string text4 = "";
						try
						{
							text4 = jObject["data"][i]["owned_ad_accounts"]["data"][j]["name"].ToString();
						}
						catch
						{
						}
						string text5 = "kxđ";
						try
						{
							text5 = jObject["data"][i]["owned_ad_accounts"]["data"][j]["adtrust_dsl"].ToString();
						}
						catch
						{
						}
						if (text5.Equals("-1"))
						{
							text5 = "nolimit";
						}
						string text6 = "kxđ";
						try
						{
							text6 = jObject["data"][i]["owned_ad_accounts"]["data"][j]["currency"].ToString();
						}
						catch
						{
						}
						string text7 = "";
						try
						{
							text7 = jObject["data"][i]["owned_ad_accounts"]["data"][j]["amount_spent"].ToString();
							if (text6.Contains("USD") || text6.Contains("CAD") || text6.Contains("CHF") || text6.Contains("EUR") || text6.Contains("KYD") || text6.Contains("CNY") || text6.Contains("GBP") || text6.Contains("JOD") || text6.Contains("OMR") || text6.Contains("BHD") || text6.Contains("KWD") || text6.Contains("AUD") || text6.Contains("AZN"))
							{
								text7 = text7.Substring(0, text7.Length - 2);
							}
						}
						catch
						{
						}
						string text8 = "";
						try
						{
							text8 = jObject["data"][i]["owned_ad_accounts"]["data"][j]["min_billing_threshold"]["amount"].ToString();
						}
						catch
						{
						}
						try
						{
							text8 = jObject["data"][i]["owned_ad_accounts"]["data"][j]["adspaymentcycle"]["data"][0]["threshold_amount"].ToString();
							if (text6.Contains("USD") || text6.Contains("CAD") || text6.Contains("CHF") || text6.Contains("EUR") || text6.Contains("KYD") || text6.Contains("CNY") || text6.Contains("GBP") || text6.Contains("JOD") || text6.Contains("OMR") || text6.Contains("BHD") || text6.Contains("KWD") || text6.Contains("AUD") || text6.Contains("AZN"))
							{
								text8 = text8.Substring(0, text8.Length - 2);
							}
						}
						catch
						{
						}
						string text9 = "";
						text9 = (jObject["data"][i]["owned_ad_accounts"]["data"][j]["account_status"].ToString().Equals("1") ? "Hoạt động" : ((!jObject["data"][i]["owned_ad_accounts"]["data"][j]["account_status"].ToString().Equals("2")) ? "kxđ" : "Hđbt"));
						string text10 = "0";
						try
						{
							text10 = jObject["data"][i]["owned_ad_accounts"]["data"][j]["balance"].ToString();
						}
						catch
						{
						}
						string text11 = "";
						try
						{
							string text12 = text8;
							if ((text6.Contains("USD") || text6.Contains("CAD") || text6.Contains("CHF") || text6.Contains("EUR") || text6.Contains("KYD") || text6.Contains("CNY") || text6.Contains("GBP") || text6.Contains("JOD") || text6.Contains("OMR") || text6.Contains("BHD") || text6.Contains("KWD") || text6.Contains("AUD") || text6.Contains("AZN")) && text12.EndsWith(",00"))
							{
								text12 = text12.Substring(0, text8.Length - 3);
							}
							text11 = (float.Parse(text12.Replace(",", "")) - float.Parse(text10.Replace(",", ""))).ToString();
						}
						catch
						{
						}
						list.Add("limit: " + text5 + " " + text6 + "_Ngưỡng hiện tại: " + text8 + " " + text6 + "_Đãtiêu: " + text7 + " " + text6 + "_Trạngthái: " + text9 + "_Uid: " + text + "_" + text2 + "_" + text3 + "_" + text4 + "_CònLại: " + text11 + " " + text6);
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static List<string> A80FFE86(HttpRequest httpRequest_0, string C1B67215)
	{
		List<string> list = new List<string>();
		try
		{
			string value = httpRequest_0.Get("https://graph.facebook.com/v14.0/me/businesses?fields=is_disabled_for_integrity_reasons,sharing_eligibility_status&limit=2000&access_token=" + C1B67215).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			for (int i = 0; i < jObject["data"].ToArray().Length; i++)
			{
				try
				{
					string text = jObject["data"][i]["id"].ToString();
					string text2 = "undefined";
					string text3 = "undefined";
					try
					{
						if (jObject["data"][i]["sharing_eligibility_status"].ToString().Equals("enabled"))
						{
							text2 = "350";
						}
						if (jObject["data"][i]["sharing_eligibility_status"].ToString().Equals("disabled_due_to_trust_tier"))
						{
							text2 = "50";
						}
					}
					catch
					{
					}
					try
					{
						if (jObject["data"][i]["is_disabled_for_integrity_reasons"].ToString().Contains("rue"))
						{
							text3 = "die";
						}
						if (jObject["data"][i]["is_disabled_for_integrity_reasons"].ToString().Contains("alse"))
						{
							text3 = "live";
						}
					}
					catch
					{
					}
					list.Add(text + "|" + text2 + "|" + text3);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		return list;
	}

	public static bool smethod_28(HttpRequest B907FF81, string string_0, string string_1, string string_2)
	{
		try
		{
			string text = B907FF81.Get("https://graph.facebook.com/v14.0/" + string_1 + "/business_users?method=POST&email=" + string_2 + "&role=ADMIN&access_token=" + string_0).ToString();
			if (text.Contains("\"id\""))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static List<string> smethod_29(HttpRequest F9116281, string string_0, string string_1)
	{
		List<string> list = new List<string>();
		try
		{
			string value = F9116281.Get("https://graph.facebook.com/v14.0/" + string_1 + "/pending_users?access_token=" + string_0).ToString();
			try
			{
				JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
				for (int i = 0; i < jObject["data"].ToArray().Length; i++)
				{
					try
					{
						list.Add(jObject["data"][i]["invite_link"].ToString() + "-" + jObject["data"][i]["status"].ToString());
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
		return list;
	}

	public static bool C418B013(HttpRequest httpRequest_0, HttpRequest httpRequest_1, string A0B6EB31, string AC2FA31F, string string_0, string AB2E2EA0, string D336B495, string string_1)
	{
		string userAgent = httpRequest_0.UserAgent;
		try
		{
			httpRequest_0.AddHeader("Referer", "https://www.facebook.com");
			httpRequest_0.AddHeader("Origin", "https://www.facebook.com");
			httpRequest_0.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.110 Safari/537.36";
			httpRequest_0.AddHeader("Sec-Fetch-Site", "same-origin");
			string str = "user_id=" + AB2E2EA0 + "&role=0&page_id=" + AC2FA31F + "&use_roles=false&__user=" + string_0 + "&__a=1&__dyn=7xeUmBwjbg7ebwKheC1swgE98nwgU6C7UW3q327Eiw8OdwJx63C0Soe8hwem0Ko2_CwjE3awbG782Cwooa87i1WwfmUS1vwnEO3a1PwBgK7o884y0i23S0H8bEjw8y0RE5a1qw8W1uwa-7U1bobodEGdw46w&__csr=&__req=d&__hs=18998.BP%3ADEFAULT.2.0.0.0.&dpr=1&__ccg=EXCELLENT&__rev=1004914322&__s=ygar08%3Ayg4e23%3Akssn73&__hsi=7050179442163655221-0&__comet_req=0&cquick=jsc_c_q&cquick_token=AQ4sNvX-mqUsmq9bces&ctarget=https%3A%2F%2Fwww.facebook.com&fb_dtsg=" + A0B6EB31 + "&jazoest=21997&lsd=hNzXugI-zN592L0Djp7qGI&__spin_r=1004914322&__spin_b=trunk&__spin_t=1641497374&ajax_password=" + D336B495 + "&confirmed=1";
			string text = httpRequest_0.Post("https://www.facebook.com/presma/admin_roles/add_admin/", str, "application/x-www-form-urlencoded").ToString();
			httpRequest_0.UserAgent = userAgent;
			if (text.Contains("USER_ALREADY_HAVE_A_ROLE"))
			{
				return true;
			}
			if (text.Contains("\"isInvited\":true") || text.Contains("USER_ALREADY_INVITED"))
			{
				return F7158117(httpRequest_1, AC2FA31F, AB2E2EA0, string_1);
			}
		}
		catch (Exception)
		{
		}
		httpRequest_0.UserAgent = userAgent;
		return false;
	}

	public static bool smethod_30(HttpRequest httpRequest_0, HttpRequest A1204191, string string_0, string string_1, string BA3E9BAF, string string_2, string string_3, string E028F926)
	{
		string userAgent = httpRequest_0.UserAgent;
		try
		{
			httpRequest_0.Post("https://mbasic.facebook.com/password/reauth/?next=https%3A%2F%2Fmbasic.facebook.com%2Fpages%2Fedit_admin%2F%3Fid%3D" + string_2 + "%26admin_id%3D", "fb_dtsg=" + string_0 + "&jazoest=22098&pass=" + string_3 + "&save=Ti%E1%BA%BFp+t%E1%BB%A5c", "application/x-www-form-urlencoded").ToString();
			httpRequest_0.Post("https://mbasic.facebook.com/a/pages/add_change_admin/?page_id=" + string_1 + "&admin_id=" + string_2, "fb_dtsg=" + string_0 + "&jazoest=21974&admin_role=" + "0" + "&submit=Th%C3%AAm", "application/x-www-form-urlencoded").ToString();
			return F7158117(A1204191, string_1, string_2, E028F926);
		}
		catch
		{
		}
		httpRequest_0.UserAgent = userAgent;
		return false;
	}

	public static bool E6267F16(HttpRequest EE087B9A, HttpRequest E8822003, string string_0, string string_1, string string_2, string string_3, string F2A27A34, string string_4)
	{
		string userAgent = EE087B9A.UserAgent;
		try
		{
			string str = "fb_dtsg=" + string_0 + "&jazoest=22004&admin_role=0&submit=Th%C3%AAm";
			EE087B9A.Post("https://mbasic.facebook.com/a/pages/add_change_admin/?page_id=" + string_1 + "&admin_id=" + string_3 + "&ref=timeline", str, "application/x-www-form-urlencoded").ToString();
			if (EE087B9A.Address.OriginalString.ToString().Contains("https://mbasic.facebook.com/password/reauth"))
			{
				string address = EE087B9A.Address.OriginalString.ToString();
				EE087B9A.AddHeader("Cache-Control", "max-age=0");
				EE087B9A.AddHeader("Sec-Ch-Ua", "\"(Not(A:Brand\";v=\"8\", \"Chromium\";v=\"99\"");
				EE087B9A.AddHeader("Sec-Ch-Ua-Mobile", "?0");
				EE087B9A.AddHeader("Sec-Ch-Ua-Platform", "\"Windows\"");
				EE087B9A.AddHeader("Upgrade-Insecure-Requests", "1");
				EE087B9A.AddHeader("Origin", "https://mbasic.facebook.com");
				EE087B9A.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*;q=0.8,application/signed-exchange;v=b3;q=0.9");
				EE087B9A.AddHeader("Sec-Fetch-Site", "same-origin");
				EE087B9A.AddHeader("Sec-Fetch-Mode", "navigate");
				EE087B9A.AddHeader("Sec-Fetch-User", "?1");
				EE087B9A.AddHeader("Sec-Fetch-Dest", "document");
				EE087B9A.AddHeader("Referer", "https://mbasic.facebook.com/pages/edit_admin/?id=" + string_1 + "&admin_id=" + string_3);
				EE087B9A.AddHeader("Accept-Language", "en-US,en;q=0.9");
				str = "fb_dtsg=" + string_0 + "&jazoest=22008&pass=" + F2A27A34 + "&save=Continue";
				EE087B9A.Post(address, str, "application/x-www-form-urlencoded").ToString();
			}
			return F7158117(E8822003, string_1, string_3, string_4);
		}
		catch (Exception)
		{
		}
		EE087B9A.UserAgent = userAgent;
		return false;
	}

	public static bool F7158117(HttpRequest F5AA78B8, string string_0, string DC007996, string string_1)
	{
		try
		{
			string text = F5AA78B8.Get("https://graph.facebook.com/graphql?doc_id=3348120965246221&method=post&pretty=false&format=json&variables=%7B%22input%22%3A%7B%22client_mutation_id%22%3A%221%22%2C%22actor_id%22%3A%22" + DC007996 + "%22%2C%22page_id%22%3A%22" + string_0 + "%22%7D%7D&fb_api_req_friendly_name=useAcceptPageAdminInviteMutation&access_token=" + string_1).ToString();
			if (text.Contains("\"is_accepted\":true"))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_31(HttpRequest FFA9ADA0, string string_0, string string_1, string CA8FFE08, string B292D08C, string string_2)
	{
		try
		{
			string text = "0";
			string text2 = FFA9ADA0.Get("https://mbasic.facebook.com/pages/remove_admins/confirm/?id=" + string_1 + "&remove_admin_id=" + CA8FFE08 + "&remove_admin_role=" + text).ToString();
			Thread.Sleep(300);
			text2 = FFA9ADA0.Post("https://mbasic.facebook.com/a/pages/remove_admin/?remove_admin_id=" + CA8FFE08 + "&remove_admin_role=" + text + "&page_id=" + string_1 + "&av=" + CA8FFE08, "fb_dtsg=" + string_0 + "&jazoest=21974", "application/x-www-form-urlencoded").ToString();
			Thread.Sleep(1800);
			text2 = FFA9ADA0.Get("https://graph.facebook.com/v2.0/" + string_1 + "?&access_token=" + string_2).ToString();
			if (!text2.Contains("offer_eligible"))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static string FC109712(HttpRequest C8100314, string D114E235)
	{
		string result = "kxđ";
		try
		{
			string value = C8100314.Get("https://graph.facebook.com/v9.0/me/adaccounts?fields=is_user_allowed_to_advertise&access_token=" + D114E235).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			if (jObject["data"].ToArray().Length == 0)
			{
				result = "Live";
			}
			result = ((!jObject["data"][0]["is_user_allowed_to_advertise"].ToString().Contains("rue")) ? "Die" : "Live");
		}
		catch
		{
		}
		return result;
	}

	public static string A9915536(HttpRequest httpRequest_0)
	{
		string result = "kxđ";
		try
		{
			string text = httpRequest_0.Get("https://www.facebook.com/dating/get-started/").ToString();
			result = (text.Contains("unavailable__section-container") ? "No" : ((!text.Contains("download__section-heading")) ? "kxđ" : "Yes"));
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_32(HttpRequest httpRequest_0, string D2995F3B)
	{
		try
		{
			return smethod_33(httpRequest_0, D2995F3B);
		}
		catch
		{
			return smethod_33(httpRequest_0, D2995F3B);
		}
	}

	public static string smethod_33(HttpRequest httpRequest_0, string string_0)
	{
		string result = "kxđ";
		try
		{
			string value = httpRequest_0.Get("https://graph.facebook.com/graphql?method=post&locale=vi_VN&pretty=false&format=json&fb_api_req_friendly_name=PaymentsCometTransactionHubHomeRootQuery&doc_id=4635065423255094&fb_api_caller_class=RelayModern&server_timestamps=true&variables={\"pagination\":{\"after\":\"0\",\"num_items\":3},\"query_params\":{\"payment_type\":\"FBPAY_HUB\"}}&access_token=" + string_0).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			result = jObject["data"]["payment_method_info"]["country"].ToString();
		}
		catch
		{
		}
		return result;
	}

	public static string smethod_34(HttpRequest C40A1E99, string D0ABF03E, string string_0, string DB8B42A5, string string_1)
	{
		string result = "";
		try
		{
			string text = C40A1E99.Get("https://business.facebook.com/home/accounts?business_id=").ToString();
			if (text.Contains("\"EAAG"))
			{
				result = "EAAG" + text.Split(new string[1] { "\"EAAG" }, StringSplitOptions.None)[1].Split('"')[0].Split('\\')[0];
				return result;
			}
			if (C40A1E99.Address.ToString().Contains("&business_id="))
			{
				try
				{
					string text2 = C40A1E99.Address.ToString().Split(new string[1] { "&business_id=" }, StringSplitOptions.None)[1].Trim().Split('&')[0].Trim();
					text = C40A1E99.Get("https://business.facebook.com/settings/ad-accounts?business_id=" + text2).ToString();
					if (text.Contains("\"EAAG"))
					{
						result = "EAAG" + text.Split(new string[1] { "\"EAAG" }, StringSplitOptions.None)[1].Split('"')[0].Split('\\')[0];
						return result;
					}
				}
				catch
				{
				}
			}
			text = C40A1E99.Get("https://business.facebook.com/content_management/").ToString();
			if (text.Contains("\"EAAG"))
			{
				result = "EAAG" + text.Split(new string[1] { "\"EAAG" }, StringSplitOptions.None)[1].Split('"')[0].Split('\\')[0];
			}
			else
			{
				for (int i = 0; i < 30; i++)
				{
					if (CC2B3B38.smethod_8(D0ABF03E) != string_1)
					{
						break;
					}
					Thread.Sleep(1000);
				}
				DB8B42A5 = Regex.Match(Regex.Unescape(text), "\"token\":\"(.*?)\"").Groups[1].Value;
				C40A1E99.Referer = C40A1E99.Address.ToString();
				text = C40A1E99.Post("https://business.facebook.com/security/twofactor/reauth/enter/", "approvals_code=" + CC2B3B38.smethod_8(D0ABF03E) + "&save_device=false&__user=" + string_0 + "&__a=1&__dyn=7xeUmFoO3-SudwCwRyU8EKnFwLBwCwXCwAxu13wqovzEdEnxy7Eiwzwq8S2S4okwAwSz82EyEqx60DU4m0_87Oq1eK1VgC11x-9xm1WxO4Uowuo9oeUa85vzo1eE4aUS1vwnEfU7e2l2UtggzE2DwiUmwnGwWx2365Ey19zUuxe0y83mwkE5G4E7K1uDwau58Gm0hi4Ejyo-3qazo8U3ywbS1bwzw&__csr=&__req=9&__hs=19108.BP:DEFAULT.2.0.0.0.&dpr=1.5&__ccg=EXCELLENT&__rev=1005404255&__s=n7y7to:i7topm:vo61pg&__hsi=7090761015361603355-0&__comet_req=0&fb_dtsg=" + DB8B42A5 + "&jazoest=21954&lsd=Qf7z54nRePaFgnLxvbGQyN&__spin_r=1005404255&__spin_b=trunk&__spin_t=1650946451&__jssesw=1", "application/x-www-form-urlencoded").ToString();
				if (!text.Contains("{\"codeConfirmed\":true"))
				{
					Thread.Sleep(3000);
					text = C40A1E99.Post("https://business.facebook.com/security/twofactor/reauth/enter/", "approvals_code=" + CC2B3B38.smethod_8(D0ABF03E) + "&save_device=false&__user=" + string_0 + "&__a=1&__dyn=7xeUmFoO3-SudwCwRyU8EKnFwLBwCwXCwAxu13wqovzEdEnxy7Eiwzwq8S2S4okwAwSz82EyEqx60DU4m0_87Oq1eK1VgC11x-9xm1WxO4Uowuo9oeUa85vzo1eE4aUS1vwnEfU7e2l2UtggzE2DwiUmwnGwWx2365Ey19zUuxe0y83mwkE5G4E7K1uDwau58Gm0hi4Ejyo-3qazo8U3ywbS1bwzw&__csr=&__req=9&__hs=19108.BP:DEFAULT.2.0.0.0.&dpr=1.5&__ccg=EXCELLENT&__rev=1005404255&__s=n7y7to:i7topm:vo61pg&__hsi=7090761015361603355-0&__comet_req=0&fb_dtsg=" + DB8B42A5 + "&jazoest=21954&lsd=Qf7z54nRePaFgnLxvbGQyN&__spin_r=1005404255&__spin_b=trunk&__spin_t=1650946451&__jssesw=1", "application/x-www-form-urlencoded").ToString();
				}
				Thread.Sleep(1000);
				text = C40A1E99.Get("https://business.facebook.com/content_management").ToString();
				result = "EAAG" + text.Split(new string[1] { "\"EAAG" }, StringSplitOptions.None)[1].Split('"')[0].Split('\\')[0];
			}
		}
		catch
		{
		}
		return result;
	}

	public static string C723A39B(HttpRequest httpRequest_0, string string_0, string CE84BD92, string string_1, string string_2)
	{
		string text = "";
		try
		{
			for (int i = 0; i < 3; i++)
			{
				text = smethod_34(httpRequest_0, string_0, CE84BD92, string_1, string_2);
				if (text == null || text.Equals(""))
				{
					Thread.Sleep(1500);
					continue;
				}
				break;
			}
		}
		catch
		{
		}
		return text;
	}

	public static string E814722A(HttpRequest FB0FDF04)
	{
		string result = "";
		string userAgent = FB0FDF04.UserAgent;
		try
		{
			FB0FDF04.AddHeader("viewport-width", "1229");
			FB0FDF04.AddHeader("sec-ch-ua", "\"Google Chrome\";v=\"89\", \"Chromium\";v=\"89\", \";Not A Brand\";v=\"99\"");
			FB0FDF04.AddHeader("sec-ch-ua-mobile", "?0");
			FB0FDF04.AddHeader("Upgrade-Insecure-Requests", "1");
			FB0FDF04.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/89.0.4389.82 Safari/537.36";
			FB0FDF04.AddHeader("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9");
			FB0FDF04.AddHeader("Sec-Fetch-Site", "none");
			FB0FDF04.AddHeader("Sec-Fetch-Mode", "navigate");
			FB0FDF04.AddHeader("Sec-Fetch-User", "?1");
			FB0FDF04.AddHeader("Sec-Fetch-Dest", "document");
			FB0FDF04.Referer = "https://www.facebook.com/";
			string text = FB0FDF04.Get("https://business.facebook.com/adsmanager/manage/campaigns?act=").ToString();
			if (text.Contains("\"EAAB"))
			{
				result = "EAAB" + text.Split(new string[1] { "\"EAAB" }, StringSplitOptions.None)[1].Split('"')[0].Split('\\')[0];
			}
		}
		catch
		{
		}
		FB0FDF04.UserAgent = userAgent;
		return result;
	}

	public static string EA9AF831(HttpRequest httpRequest_0, string string_0 = "https://m.facebook.com/composer/ocelot/async_loader/?publisher=feed")
	{
		string result = "";
		try
		{
			string str = httpRequest_0.Get(string_0).ToString();
			result = Regex.Match(Regex.Unescape(str), "name=\"fb_dtsg\" value=\"(.*?)\"").Groups[1].Value;
		}
		catch
		{
		}
		return result;
	}

	public static string D7134589(string string_0)
	{
		try
		{
			byte[] secretKey = Base32Encoding.ToBytes(string_0);
			Totp totp = new Totp(secretKey);
			return totp.ComputeTotp();
		}
		catch (Exception)
		{
		}
		return null;
	}

	public static string smethod_35(HttpRequest httpRequest_0, string FEAEB7B7, string C7342228, string DB1CBF03)
	{
		string string_ = CE341825(httpRequest_0, FEAEB7B7, C7342228, DB1CBF03);
		return smethod_36(httpRequest_0, string_, DB1CBF03);
	}

	public static string smethod_36(HttpRequest F9BB540C, string string_0, string string_1)
	{
		string result = "";
		try
		{
			string value = F9BB540C.Get("https://graph.facebook.com/v14.0/act_" + string_0.Replace("act_", "") + "?fields=account_status&access_token=" + string_1).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			if (jObject["account_status"].ToString().Equals("2"))
			{
				return "[DIE_Ca_Nhan]";
			}
			if (jObject["account_status"].ToString().Equals("1"))
			{
				return "[LIVE_Ca_Nhan]";
			}
		}
		catch
		{
		}
		return result;
	}

	public static string CE341825(HttpRequest httpRequest_0, string CB16C420, string string_0, string string_1)
	{
		try
		{
			string empty = string.Empty;
			httpRequest_0.KeepAlive = true;
			empty = httpRequest_0.Post("https://www.facebook.com/api/graphql/", "av=" + CB16C420 + "&session_id=4711e022067c790f&__user=" + CB16C420 + "&__a=1&__dyn=7xeUmBz8aolJ28S1syU8EKnFG3a2q12wAxuq3mq1FxebzEcWAxam4EuGfwhEmx-ezobo_x3U98dEO486C6EC4UScx60C9EcEixWq4o8Efo9UeUryE5mWBBwQzocEiwTgfUK2C0A8swIwEwk8898eUugx0g8lUScyo720FoO12Kh7xWbwFyE8EeAUtxS2K5pUao9k2CEWewi8doa88EfU5WUvxC4e2-5Ey19zUuxe1dx-q4VEkwbG3ifzobEaUiyE-7888myUnwUzpA6EaEjz8c8-5azoa9obGAw-y84ybx6bCyV-ufwLCyKbw&__csr=&__req=1&__beoa=0&__pc=PHASED%3ADEFAULT&__hs=18770.PHASED%3ADEFAULT.2.0.0.0&__bhv=2&dpr=1.5&__ccg=GOOD&__rev=1003840914&__s=xb3mlj%3Ai7usn8%3Aen4cah&__hsi=6965484331858901774-0&__comet_req=0&fb_dtsg=" + string_0 + "&jazoest=22722&lsd=xkJCQ1jt1kZPZH696RZkUS&__spin_r=1003840914&__spin_b=trunk&__spin_t=1621777831&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=AccountQualityHubAssetOwnerViewQuery&variables=%7B%22assetOwnerId%22%3A%22" + CB16C420 + "%22%2C%22startTime%22%3A1619136000%7D&server_timestamps=true&doc_id=", "application/x-www-form-urlencoded").ToString();
			return Regex.Match(empty, "\"payment_legacy_account_id\":\"(\\d+)\"},").Groups[1].Value;
		}
		catch
		{
		}
		return "";
	}

	public static string smethod_37(HttpRequest httpRequest_0, string BA1DB519, string string_0, string string_1)
	{
		string text = "";
		string text2 = "";
		try
		{
			string empty = string.Empty;
			httpRequest_0.KeepAlive = true;
			empty = httpRequest_0.Post("https://www.facebook.com/api/graphql/", "av=" + BA1DB519 + "&session_id=4711e022067c790f&__user=" + BA1DB519 + "&__a=1&__dyn=7xeUmBz8aolJ28S1syU8EKnFG3a2q12wAxuq3mq1FxebzEcWAxam4EuGfwhEmx-ezobo_x3U98dEO486C6EC4UScx60C9EcEixWq4o8Efo9UeUryE5mWBBwQzocEiwTgfUK2C0A8swIwEwk8898eUugx0g8lUScyo720FoO12Kh7xWbwFyE8EeAUtxS2K5pUao9k2CEWewi8doa88EfU5WUvxC4e2-5Ey19zUuxe1dx-q4VEkwbG3ifzobEaUiyE-7888myUnwUzpA6EaEjz8c8-5azoa9obGAw-y84ybx6bCyV-ufwLCyKbw&__csr=&__req=1&__beoa=0&__pc=PHASED%3ADEFAULT&__hs=18770.PHASED%3ADEFAULT.2.0.0.0&__bhv=2&dpr=1.5&__ccg=GOOD&__rev=1003840914&__s=xb3mlj%3Ai7usn8%3Aen4cah&__hsi=6965484331858901774-0&__comet_req=0&fb_dtsg=" + string_0 + "&jazoest=22722&lsd=xkJCQ1jt1kZPZH696RZkUS&__spin_r=1003840914&__spin_b=trunk&__spin_t=1621777831&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=AccountQualityHubAssetOwnerViewQuery&variables=%7B%22assetOwnerId%22%3A%22" + BA1DB519 + "%22%2C%22startTime%22%3A1619136000%7D&server_timestamps=true&doc_id=", "application/x-www-form-urlencoded").ToString();
			text = Regex.Match(empty, "\"status\":\"(.*?)\",").Groups[1].Value;
			try
			{
				_ = Regex.Match(empty, "\"payment_legacy_account_id\":\"(\\d+)\"},").Groups[1].Value;
				text2 = smethod_35(httpRequest_0, BA1DB519, string_0, string_1);
			}
			catch
			{
			}
			if (text == "APPEAL_PENDING")
			{
				text = "->Treo 902";
			}
			if (text == "APPEAL_REJECTED_NO_RETRY")
			{
				text = "->Cấm QC vĩnh viễn";
			}
			if (text == "APPEAL_TIMEOUT")
			{
				text = "->30 ngày XMDT";
			}
			if (text == "NOT_RESTRICTED" || text == "APPEAL_ACCEPTED" || empty.Contains("AuthenticityVerificationRestrictionProviderAdditionalParameters"))
			{
				string value = Regex.Match(empty, "\"payment_legacy_account_id\":\"(\\d+)\"},").Groups[1].Value;
				if (value == string.Empty)
				{
					string text3 = C434C188(httpRequest_0, string_1);
					if (text3.Length < 10)
					{
						text3 = C434C188(httpRequest_0, string_1);
					}
				}
				if (text == "NOT_RESTRICTED" || text == "APPEAL_ACCEPTED")
				{
					if (empty.Contains("ALEBanhammerAdvertisingRestrictionAdditionalParameters"))
					{
						text = "->902 có tích xanh";
					}
					if (empty.Contains("PreHarmAdvertisingRestrictionAdditionalParameters"))
					{
						text = "->XMDT có tích xanh";
					}
					if (text.Equals("NOT_RESTRICTED"))
					{
						text = "";
					}
				}
				if (empty.Contains("AuthenticityVerificationRestrictionProviderAdditionalParameters"))
				{
					text = "->Type79";
				}
			}
			else
			{
				if (empty.Contains("ALEBanhammerAdvertisingRestrictionAdditionalParameters"))
				{
					text = ((!Regex.Match(empty, "\"status\":\"(.*?)\",").Groups[1].Value.Contains("APPEAL_PENDING")) ? "->HCQC 902" : "->HCQC 902->Đang kháng");
				}
				if (empty.Contains("AdAccountPreHarmAdvertisingRestrictionAdditionalParameters"))
				{
					text = "->Type273";
				}
				if (text == "VANILLA_RESTRICTED")
				{
					text = "->Cần XMDT";
				}
			}
		}
		catch
		{
		}
		return text + text2;
	}

	public static string C434C188(HttpRequest E403D8AE, string A01EF522)
	{
		try
		{
			string input = E403D8AE.Get("https://graph.facebook.com/v7.0/graphql?access_token=" + A01EF522 + "&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=" + "5897352003624071" + "&variables={}&server_timestamps=true&doc_id=5897352003624071&method=post").ToString();
			string value = Regex.Match(input, "{\"id\":\"(\\d+)\",").Groups[1].Value;
			if (!(value != string.Empty))
			{
				return "null";
			}
			input = E403D8AE.Get("https://graph.facebook.com/v7.0/graphql?access_token=" + A01EF522 + "&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=AdsManagerAccountHomeView_Query&variables={%22account%22:%22" + value + "%22}&server_timestamps=true&doc_id=3365172470271239&method=post").ToString();
			string value2 = Regex.Match(input, "\"legacy_account_id\":\"(\\d+)\",").Groups[1].Value;
			if (value2 != string.Empty)
			{
				return value2;
			}
			return "null";
		}
		catch
		{
		}
		return Class19.CD2AA435();
	}

	public static string smethod_38(HttpRequest DC859EB5, string F08FCE3E, string string_0)
	{
		//Discarded unreachable code: IL_0057
		try
		{
			string empty = string.Empty;
			DC859EB5.KeepAlive = true;
			_ = new string[9] { "av=", F08FCE3E, "&session_id=4711e022067c790f&__user=", F08FCE3E, "&__a=1&__dyn=7xeUmBz8aolJ28S1syU8EKnFG3a2q12wAxuq3mq1FxebzEcWAxam4EuGfwhEmx-ezobo_x3U98dEO486C6EC4UScx60C9EcEixWq4o8Efo9UeUryE5mWBBwQzocEiwTgfUK2C0A8swIwEwk8898eUugx0g8lUScyo720FoO12Kh7xWbwFyE8EeAUtxS2K5pUao9k2CEWewi8doa88EfU5WUvxC4e2-5Ey19zUuxe1dx-q4VEkwbG3ifzobEaUiyE-7888myUnwUzpA6EaEjz8c8-5azoa9obGAw-y84ybx6bCyV-ufwLCyKbw&__csr=&__req=1&__beoa=0&__pc=PHASED%3ADEFAULT&__hs=18770.PHASED%3ADEFAULT.2.0.0.0&__bhv=2&dpr=1.5&__ccg=GOOD&__rev=1003840914&__s=xb3mlj%3Ai7usn8%3Aen4cah&__hsi=6965484331858901774-0&__comet_req=0&fb_dtsg=", string_0, "&jazoest=22722&lsd=xkJCQ1jt1kZPZH696RZkUS&__spin_r=1003840914&__spin_b=trunk&__spin_t=1621777831&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=AccountQualityHubAssetOwnerViewQuery&variables=%7B%22assetOwnerId%22%3A%22", F08FCE3E, null };
			_ = 8;
			/*Error near IL_0052: Invalid metadata token*/;
		}
		catch
		{
		}
		return "";
	}

	public static string smethod_39(HttpRequest httpRequest_0, string string_0, string A089EE12, string string_1)
	{
		try
		{
			string empty = string.Empty;
			httpRequest_0.KeepAlive = true;
			empty = httpRequest_0.Post("https://www.facebook.com/api/graphql/", "av=" + string_0 + "&__user=" + string_0 + "&__a=1&__dyn=7xeUmBz8fXgydwn8DwyyVuCEcE9E4a2i5aCG6UtyEgwNxK4UKewSAAzpoixWE-bwjElxKdwJz-58jx2263a0x8C8yEqx61QwGwho5G2q1WwCCwTxqqmm2Z17wMQm7o8RU4uU9oiAwu8sgpggwExm3G4UhwXwEwl-dz82iw9G12KdxW10wnHxC2611DwFg942C4oW2e2i11xOfwXxq1uxZxK48G2q4kUy26U8U-7Ejwjo9Ejxy220D98fUS2W2K4E7K1uCgqw8O58Gm7o7CcwnohxabDyoOEdEGdwzwea1Pw&__csr=&__req=4&__hs=18998.BP%3Aads_campaign_manager_pkg.2.0.0.0.&dpr=1&__ccg=MODERATE&__rev=1004913920&__s=ifhxkj%3Ah8dqal%3Abs9jk6&__hsi=7050120874658551991-0&__comet_req=0&fb_dtsg=" + A089EE12 + "&jazoest=22003&lsd=87E1UDk2tY2BUiYVs9d9YR&__spin_r=1004913920&__spin_b=trunk&__spin_t=1641484180&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=BillingAMNexusRootQuery&variables=%7B%22paymentAccountID%22%3A%22" + string_1 + "%22%7D&server_timestamps=true&doc_id=4651129094969670", "application/x-www-form-urlencoded").ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(empty);
			List<string> list = new List<string>();
			for (int i = 0; i < jObject["data"]["billable_account_by_payment_account"]["billing_payment_account"]["primary_funding_source"].ToArray().Length; i++)
			{
				try
				{
					JToken jToken = jObject["data"]["billable_account_by_payment_account"]["billing_payment_account"]["primary_funding_source"];
					if ("USABLE".Equals(jToken[i]["usability"].ToString()))
					{
						list.Add(jToken[i]["credential"]["card_association"].ToString() + "_" + jToken[i]["credential"]["last_four_digits"].ToString());
					}
				}
				catch
				{
				}
			}
			return string.Join(";", list);
		}
		catch
		{
		}
		return "";
	}

	public static string B1A18BB8(HttpRequest httpRequest_0, string string_0, string EF0C2FA1)
	{
		try
		{
			string text = httpRequest_0.Get("https://graph.facebook.com/graphql?method=post&locale=vi_VN&pretty=false&format=json&fb_api_req_friendly_name=CometReshareStoryCreateMutation&doc_id=4187349351354631&fb_api_caller_class=RelayModern&server_timestamps=true&variables={%22input%22:{%22friend_requestee_ids%22:[%22" + string_0 + "%22],%22refs%22:[null],%22source%22:%22profile_button%22,%22warn_ack_for_ids%22:[],%22actor_id%22:%22%22,%22client_mutation_id%22:%2211%22},%22scale%22:1.5}&access_token=" + EF0C2FA1).ToString();
			if (text.Contains("ARE_FRIENDS"))
			{
				return "ARE_FRIENDS";
			}
			if (text.StartsWith("{\"data\":{\"friend_request_send\":{\"friend_requestees\":[{\"id\":\""))
			{
				return "SUCCESS";
			}
		}
		catch (Exception)
		{
		}
		return "";
	}

	public static bool smethod_40(HttpRequest httpRequest_0, string B23ED882, string F3A1F5B7)
	{
		try
		{
			string text = httpRequest_0.Get("https://graph.facebook.com/graphql?method=post&locale=vi_VN&pretty=false&format=json&fb_api_req_friendly_name=CometReshareStoryCreateMutation&fb_api_caller_class=RelayModern&doc_id=4048767518583552&server_timestamps=true&variables={%22input%22:{%22friend_requester_id%22:%22" + B23ED882 + "%22,%22source%22:%22/profile.php%22,%22actor_id%22:%22%22,%22client_mutation_id%22:%222%22},%22scale%22:1.5,%22refresh_num%22:0}&access_token=" + F3A1F5B7).ToString();
			if (text.StartsWith("{\"data\":{\"friend_request_accept\":{\"friend_requester\":"))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_41(HttpRequest F11DF589, string string_0, string string_1)
	{
		try
		{
			string text = F11DF589.Get("https://graph.facebook.com/graphql?method=post&locale=vi_VN&pretty=false&format=json&fb_api_req_friendly_name=FriendingCometUnfriendMutation&doc_id=4281078165250156&fb_api_caller_class=RelayModern&server_timestamps=true&variables={%22input%22:{%22source%22:%22bd_profile_button%22,%22unfriended_user_id%22:%22" + string_0 + "%22,%22actor_id%22:%22%22,%22client_mutation_id%22:%221%22},%22scale%22:1}&access_token=" + string_1).ToString();
			if (text.StartsWith("{\"data\":{\"friend_remove\":{\"unfriended_person\":{"))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool A2BCF5B5(HttpRequest FB8FD02C, string A48656B0, string string_0, string string_1)
	{
		try
		{
			string text = FB8FD02C.Get("https://graph.facebook.com/v14.0/" + A48656B0 + "/users?uid=" + string_0 + "&role=1001&method=post&access_token=" + string_1).ToString();
			if (text.Contains("\"success\":true") || text.Contains("\"success\": true"))
			{
				return true;
			}
		}
		catch (Exception)
		{
		}
		return EE16CDAF(FB8FD02C, A48656B0, string_0, string_1);
	}

	public static bool EE16CDAF(HttpRequest httpRequest_0, string string_0, string B506842F, string string_1)
	{
		try
		{
			string text = httpRequest_0.Post("https://graph.facebook.com/v7.0/" + string_0 + "/users?_reqName=adaccount%2Fusers&access_token=" + string_1 + "&method=post&__cppo=1", "__activeScenarioIDs=%5B%5D&__activeScenarios=%5B%5D&_index=12&_reqName=adaccount%2Fusers&_reqSrc=AdsPermissionDialogController&_sessionID=87345a785eb4e67&account_id=" + string_0 + "&include_headers=false&locale=en_US&method=post&pretty=0&role=281423141961500&suppress_http_code=1&uid=" + B506842F + "&xref=fadc4641ce460c", "application/x-www-form-urlencoded").ToString();
			if (text.Contains("success"))
			{
				return true;
			}
			return false;
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_42(HttpRequest D521DEB1, string string_0, string string_1, string string_2)
	{
		try
		{
			D521DEB1.KeepAlive = true;
			D521DEB1.Referer = "https://m.facebook.com/profile/edit/infotab/section/forms/?section=basic-info&cb=1620616274";
			D521DEB1.Post("https://m.facebook.com/touchedittimeline/write/?info_surface=info&edittype=basic_info", "birthday_month=10&birthday_day=20&privacy%5B8787510733%5D=275425949243301&birthday_year=2021&privacy%5B8787805733%5D=275425949243301&birthday_confirmation=true&bd_surface=m_basic_info&bd_ref=&bd_session_id=1gJNkMW5Drat5fjgR&sex_visibility=&gender=1&privacy%5B237760973066217%5D=286958161406148&sex_preferred_pronouns=1&privacy%5B8787590733%5D=300645083384735&privacy%5B8787625733%5D=300645083384735&privacy%5B8787645733%5D=291667064279714&religion=0&religion_text=&religion_desc=&privacy%5B8787640733%5D=291667064279714&politics=0&politics_text=&politics_desc=&save=Save&fb_dtsg=" + string_1 + "&jazoest=22543&__dyn=1KQEGiFo525Ujwh8-t0BBBgS5UqxKcwRwAxu3-U6C2W3q327E2JxK4ohws83rx60Vo1a852q3q5U2nweS787S78K1Jwt8-0P82xzHzo2Xwbq1gwwyo36w9yq3q0H8-7E2swp834wmE2ewnE2Lwg81soGdw&__csr=&__req=u&__a=AYnV9QniiqziJT0hbuDHbcR9PRS4zQQkVr8tQTGITs_0llVmFLi_zF9XS0feXNp36HuDjVPbXV_4aQe0iIMHRV2fre4Y_dUng8uCZgaCBKa0YQ&__user=" + string_0, "application/x-www-form-urlencoded").ToString();
			Thread.Sleep(3000);
			D521DEB1.Get("https://mbasic.facebook.com/notifications.php");
			if (!D521DEB1.Address.ToString().Contains("notifications.php") || D521DEB1.Address.ToString().Contains("checkpoint"))
			{
				return true;
			}
		}
		catch
		{
		}
		try
		{
			D521DEB1.Referer = "https://www.facebook.com/";
			string str = "cquick_token=AQ43DAI5HgXuPW5XFEk&ctarget=https%253A%252F%252Fwww.facebook.com&cquick=jsc_c_ew&jazoest=21977&fb_dtsg=" + string_1 + "&display_format=reversed&save_password=" + string_2 + "&primary_first_name=MC&primary_last_name=Tr%E1%BA%A5n%20Th%C3%A0nh&alternate_name=&show_alternate=1&__user=" + string_0 + "&__a=1&__dyn=7xu5Fo4OQ1PyUbAjFwn84a2i5U4e1Fx-ewSwMxW0DUS2S4o1j8hwem0Ko2_CwjE28wgo2WxO0FE5-2G1Qw5MKdwnU5Wcwaq3a7o884y0i23S0H8bE2swdq1iwmE2ewnE2Lx-0lK3qazo11E2Zw&__csr=&__req=6&__hs=19065.BP%3ADEFAULT.2.0.0.0.&dpr=1&__ccg=MODERATE&__rev=1005190546&__s=epks14%3Ato0eyr%3A33rrkd&__hsi=7075015479974087667-0&__comet_req=0&lsd=98tUwmP9oAmPZiKZmuIVKX&__spin_r=1005190546&__spin_b=trunk&__spin_t=1647280408";
			D521DEB1.Post("https://www.facebook.com/ajax/settings/account/name.php", str, "application/x-www-form-urlencoded").ToString();
			Thread.Sleep(3000);
			D521DEB1.Get("https://mbasic.facebook.com/notifications.php");
			if (!D521DEB1.Address.ToString().Contains("notifications.php") || D521DEB1.Address.ToString().Contains("checkpoint"))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	internal static string smethod_43(HttpRequest httpRequest_0, string D20BA197, string string_0, string ED132C38)
	{
		try
		{
			httpRequest_0.AddHeader("authority", "business.facebook.com");
			httpRequest_0.AddHeader("accept", "*/*");
			httpRequest_0.AddHeader("accept-language", "en-US,en;q=0.9");
			httpRequest_0.AddHeader("origin", "https://business.facebook.com");
			httpRequest_0.AddHeader("referer", "https://business.facebook.com/ads/manager/account_settings/account_billing/");
			httpRequest_0.AddHeader("sec-ch-prefers-color-scheme", "light");
			httpRequest_0.AddHeader("sec-ch-ua-mobile", "?0");
			httpRequest_0.AddHeader("sec-ch-ua-platform", "\"Windows\"");
			httpRequest_0.AddHeader("sec-fetch-dest", "empty");
			httpRequest_0.AddHeader("sec-fetch-mode", "cors");
			httpRequest_0.AddHeader("sec-fetch-site", "same-origin");
			httpRequest_0.AddHeader("viewport-width", "1091");
			httpRequest_0.AddHeader("x-fb-friendly-name", "BillingHubPaymentSettingsViewQuery");
			httpRequest_0.AddHeader("x-fb-lsd", "n6zS3DajLQEaa39t_zvUud");
			string str = "av=" + ED132C38 + "&__user=" + ED132C38 + "&__a=1&__dyn=7xeUmxa3-Q8zo5O9U8EKnFG2Om2q12wAxiFGxK7oG48corxebzEdF98Sm4EuGfyU4W5orzobo-5Ejwpo24yoyaxG4o7i2G15wmE9E7G2qq3u5FFpobQ4u2SJaEpiwznwhXwBxu1UxO6A48a8lwWxe4oeUa85vzo4i1qw9G7o9bzouwg85WUpwoVUao9k2C4oW2e2i11xOfwXxq1uxZxK48G2q4p8y26U8U-UbE4S2q4Uowww9Oi3-dwKwHxa1XwnFA6E2cxiaBw9ucwnohxabDyoOEdEGdwzweau1Hwio4K2e1FAwGwiUWawCw&__csr=&__req=5&__hs=19361.BP%3Aads_campaign_manager_pkg.2.0.0.0.0&dpr=1&__ccg=EXCELLENT&__rev=1006782881&__s=4tqpy3%3An995bt%3A67brkf&__hsi=7184757846988104916&__comet_req=0&fb_dtsg=" + string_0 + "&jazoest=25635&lsd=n6zS3DajLQEaa39t_zvUud&__aaid=580427490118578&__spin_r=1006782881&__spin_b=trunk&__spin_t=1672831794&__jssesw=1&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=BillingHubPaymentSettingsViewQuery&variables=%7B%22assetID%22%3A%22" + D20BA197.Replace("act_", "") + "%22%7D&server_timestamps=true&doc_id=5621657804619386";
			string text = httpRequest_0.Post("https://business.facebook.com/api/graphql/", str, "application/x-www-form-urlencoded").ToString();
			if (text.Contains("is_eligible_for_flex_billing_onboarding\":true"))
			{
				return "true";
			}
			if (text.Contains("is_eligible_for_flex_billing_onboarding\":false"))
			{
				return "false";
			}
		}
		catch
		{
		}
		return "undefined";
	}

	public static bool A42182B9(HttpRequest A013DF99, string string_0, string A401888A, string B30E8787)
	{
		try
		{
			string str = "_reqName=object%3Abrand%2Fclient_ad_accounts&_reqSrc=AdAccountActions.brands&access_type=AGENCY&adaccount_id=act_" + A401888A.Replace("act_", "") + "&locale=en_US&method=post&permitted_roles=%5B%5D&permitted_tasks=%5B%22ADVERTISE%22%2C%22ANALYZE%22%2C%22DRAFT%22%2C%22MANAGE%22%5D&pretty=0&suppress_http_code=1&xref=f15342f7e53d064";
			string text = A013DF99.Post("https://graph.facebook.com/v14.0/" + string_0 + "/client_ad_accounts?access_token=" + B30E8787, str, "application/x-www-form-urlencoded").ToString();
			if (text.Contains("error"))
			{
				return false;
			}
			if (text.Contains("CONFIRMED"))
			{
				return true;
			}
			if (text.Contains("success"))
			{
				return true;
			}
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static string A49F0C9E(HttpRequest httpRequest_0, string DC237327, string E98CA7AF, string string_0, string F5B5F51D, string string_1, string string_2)
	{
		try
		{
			httpRequest_0.AddHeader("authority", "business.facebook.com");
			httpRequest_0.AddHeader("accept", "*/*");
			httpRequest_0.AddHeader("accept-language", "en-US,en;q=0.9,vi-VN;q=0.8,vi;q=0.7,fr-FR;q=0.6,fr;q=0.5");
			httpRequest_0.AddHeader("origin", "https://business.facebook.com");
			httpRequest_0.AddHeader("referer", "https://business.facebook.com/adsmanager/manage/ads?act=" + DC237327);
			httpRequest_0.Referer = "https://business.facebook.com/adsmanager/manage/ads?act=" + DC237327;
			httpRequest_0.AddHeader("sec-ch-prefers-color-scheme", "light");
			httpRequest_0.AddHeader("sec-ch-ua-mobile", "?0");
			httpRequest_0.AddHeader("sec-ch-ua-platform", "\"Windows\"");
			httpRequest_0.AddHeader("sec-fetch-dest", "empty");
			httpRequest_0.AddHeader("sec-fetch-mode", "cors");
			httpRequest_0.AddHeader("sec-fetch-site", "same-origin");
			httpRequest_0.AddHeader("viewport-width", "1433");
			httpRequest_0.AddHeader("x-fb-lsd", "hm9-2G_n3geJ9aa5755u7c");
			httpRequest_0.AddHeader("x-fb-qpl-active-flows", "270216139");
			string empty = string.Empty;
			httpRequest_0.AddParam("account_id", DC237327.Replace("act_", ""));
			httpRequest_0.AddParam("app_id", "119211728144504");
			httpRequest_0.AddParam("image_mapping", "");
			httpRequest_0.AddParam("video_mapping", "");
			httpRequest_0.AddParam("import_session_token", "f1af9d200df3928");
			httpRequest_0.AddParam("tsv", string_1);
			httpRequest_0.AddParam("__usid", "5-Tqtz7pp19qzrwn:Pqtz7pn3oc32c:3-Aqtz7ppmt2g9y-RV=5:F=");
			httpRequest_0.AddParam("__user", string_2);
			httpRequest_0.AddParam("__a", "1");
			httpRequest_0.AddParam("__dyn", "7AgSXghLzaxd2um5rgydg9omoiyoK6FVpkjFGGx6UmwCwgE99oWFGCxiEjCyJz9FGwwxmm4V9AUC37GiidBCBXxWE-bxa2vxi4EOeAy8K26ULypLBzogwCzUOESegGbwgEmiyoyazoO4oJ1S5FQ6bz8ix2q9hUhCCxaezWK4oWubg9p44889EScxyu6UGq13yHGmmUTxJe9LgbdkGypVRg8RpoiyXzp8KUV2UCcBAyU6O78jCh9XBAzECi9lpubwIAzEOi3Kdx12410zVubUmxSfwgEnxaFo551WcgsxN6Kh7ByUObwAAyFosDwOADggK7onwFDCG4UJ164AbxRoCiexqUyfxd0RyUSWDzUlwBx6i1iyXxJyAfDy8b9azAUy7rKfyoCfzE-eAwEwAz8iCxeq4qz8gwSwDwZAwLzUS7ogUuyEiwAgCnjxK9K8yUnwUzpUqwGzXyKcCxyU-5aCCyrgKEGm2uHQfwPybyUDxa58SEhyVEKvDDAm22eCyKqifxe4E");
			httpRequest_0.AddParam("__csr", "");
			httpRequest_0.AddParam("__req", "11");
			httpRequest_0.AddParam("__hs", "18778.EXP3:ads_manager_pkg.2.0.0.0");
			httpRequest_0.AddParam("dpr", "1.5");
			httpRequest_0.AddParam("__ccg", "UNKNOWN");
			httpRequest_0.AddParam("__rev", "1003879698");
			httpRequest_0.AddParam("__s", "mf4vay:loamft:2zrqvg");
			httpRequest_0.AddParam("__hsi", "6968465876213633534");
			httpRequest_0.AddParam("__comet_req", "0");
			httpRequest_0.AddParam("fb_dtsg", F5B5F51D);
			httpRequest_0.AddParam("jazoest", "22637");
			httpRequest_0.AddParam("lsd", "DakMnDMWWOKDurhlQHxNeN");
			httpRequest_0.AddParam("__spin_r", "1003879698");
			httpRequest_0.AddParam("__spin_b", "trunk");
			httpRequest_0.AddParam("__spin_t", "1622472395");
			httpRequest_0.AddParam("__jssesw", "1");
			empty = httpRequest_0.Post("https://business.facebook.com/adsmanager/loadtsv/").ToString();
			string value = Regex.Match(empty, "\"async_session_id\":\"(\\d+)\"").Groups[1].Value;
			if (!(value != string.Empty))
			{
				return "";
			}
			return value;
		}
		catch
		{
		}
		return "";
	}

	public static List<string> B684C126(HttpRequest DC16D63D, string DD910F0A, string FD3E952D)
	{
		List<string> list = new List<string>();
		try
		{
			string value = DC16D63D.Get("https://graph.facebook.com/v12.0/act_" + FD3E952D.Replace("act_", "") + "/addrafts?access_token=" + DD910F0A + "&fields=name,ad_object_id,id").ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			int num = jObject["data"].ToArray().Length;
			for (int i = 0; i < num; i++)
			{
				list.Add(jObject["data"][i]["id"].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	internal static List<string> smethod_44(HttpRequest httpRequest_0, string string_0, string string_1)
	{
		List<string> list = new List<string>();
		try
		{
			string value = httpRequest_0.Get("https://graph.facebook.com/v14.0/addraft_" + string_1 + "/addraft_fragments?access_token=" + string_0 + "&fields=%5B%22account_id%22%2C%22action%22%2C%22active_errors%22%2C%22ad_creation_package_config%22%2C%22ad_draft_id%22%2C%22ad_object%22%2C%22ad_object_id%22%2C%22ad_object_type%22%2C%22ancestor_ad_object_ids%22%2C%22business_folder%22%2C%22draft_version%22%2C%22fragment_type%22%2C%22fragment_version%22%2C%22id%22%2C%22parent_ad_object_id%22%2C%22publish_error%22%2C%22publish_status%22%2C%22source%22%2C%22status%22%2C%22time_created%22%2C%22time_updated%22%2C%22validation_status%22%2C%22values%22%2C%22branded_content_errors%22%5D").ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			int num = jObject["data"].ToArray().Length;
			for (int i = 0; i < num; i++)
			{
				list.Add(jObject["data"][i]["id"].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	internal static bool D1A88CBA(HttpRequest httpRequest_0, string string_0, string E68A0692, List<string> BE009A00)
	{
		try
		{
			string value = "[\"" + string.Join("\",\"", BE009A00) + "\"]";
			httpRequest_0.AddHeader("authority", "graph.facebook.com");
			httpRequest_0.AddHeader("accept", "*/*");
			httpRequest_0.AddHeader("accept-language", "en-US,en;q=0.9");
			httpRequest_0.AddHeader("origin", "https://business.facebook.com");
			httpRequest_0.AddHeader("referer", "https://business.facebook.com/");
			httpRequest_0.AddHeader("sec-ch-ua-mobile", "?0");
			httpRequest_0.AddHeader("sec-ch-ua-platform", "\"Windows\"");
			httpRequest_0.AddHeader("sec-fetch-dest", "empty");
			httpRequest_0.AddHeader("sec-fetch-mode", "cors");
			httpRequest_0.AddHeader("sec-fetch-site", "same-site");
			httpRequest_0.AddParam("__activeScenarioIDs", "[\"8a6399f5-c6b7-4713-8fe0-c306ae0060a4\"]");
			httpRequest_0.AddParam("__activeScenarios", "[\"am.publish_ads.in_review_and_publish\"]");
			httpRequest_0.AddParam("__interactionsMetadata", "[\"{name:am.publish_ads.in_review_and_publish,flow_instance_id:null,at_section:L3,start_callsite:AdsManagerPerfScenarioTriggerController_AdsPEUploadPreviewDialog.react,revisit:0,current_action_objects_total_count:0,}\"]");
			httpRequest_0.AddParam("_app", "ADS_MANAGER");
			httpRequest_0.AddParam("_reqName", "object:draft_id/publish");
			httpRequest_0.AddParam("_reqSrc", "AdsDraftPublishDataManager");
			httpRequest_0.AddParam("_sessionID", "aed799be3ef842e");
			httpRequest_0.AddParam("fragments", value);
			httpRequest_0.AddParam("ignore_errors", "true");
			httpRequest_0.AddParam("include_fragment_statuses", "true");
			httpRequest_0.AddParam("include_headers", "false");
			httpRequest_0.AddParam("locale", "en_GB");
			httpRequest_0.AddParam("method", "post");
			httpRequest_0.AddParam("pretty", "0");
			httpRequest_0.AddParam("qpl_active_flow_ids", "270208286,270216423");
			httpRequest_0.AddParam("qpl_active_flow_instance_ids", "270208286_2ef39ca9206ea839,270208286_2ef616d69471fc08,270216423_2ef3a4450c68f4af4");
			httpRequest_0.AddParam("suppress_http_code", "1");
			httpRequest_0.AddParam("xref", "f36a2c29adbbe74");
			string text = httpRequest_0.Post("https://graph.facebook.com/v14.0/" + E68A0692 + "/publish?_app=ADS_MANAGER&_reqName=object%3Adraft_id%2Fpublish&access_token=" + string_0 + "&method=post&qpl_active_flow_ids=270208286%2C270216423&qpl_active_flow_instance_ids=270208286_2ef39ca9206ea839%2C270208286_2ef616d69471fc08%2C270216423_2ef3a4450c68f4af4&__cppo=1").ToString();
			if (text.Replace(" ", "").Contains("\"status\":\"IN_PROGRESS\""))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	internal static bool smethod_45(HttpRequest httpRequest_0, string string_0, string string_1, string C11D87AA)
	{
		if (httpRequest_0.Cookies.ContainsKey("i_user"))
		{
			httpRequest_0.Cookies.Remove("i_user");
		}
		httpRequest_0.Cookies.Add("i_user", C11D87AA);
		try
		{
			httpRequest_0.AddHeader("authority", "www.facebook.com");
			httpRequest_0.AddHeader("accept", "*/*");
			httpRequest_0.AddHeader("accept-language", "en-US,en;q=0.9");
			httpRequest_0.AddHeader("origin", "https://www.facebook.com");
			httpRequest_0.AddHeader("referer", "https://www.facebook.com/ad_center/create/boostpost/?");
			httpRequest_0.AddHeader("sec-ch-prefers-color-scheme", "light");
			httpRequest_0.AddHeader("sec-ch-ua-mobile", "?0");
			httpRequest_0.AddHeader("sec-ch-ua-platform", "\"Windows\"");
			httpRequest_0.AddHeader("sec-fetch-dest", "empty");
			httpRequest_0.AddHeader("sec-fetch-mode", "cors");
			httpRequest_0.AddHeader("sec-fetch-site", "same-origin");
			httpRequest_0.AddHeader("viewport-width", "1210");
			httpRequest_0.AddHeader("x-fb-friendly-name", "LWICometCreateBoostedComponentMutation");
			httpRequest_0.AddHeader("x-fb-lsd", "ucAZBKRQvA2BazVPHRHkOt");
			httpRequest_0.AddParam("av", C11D87AA);
			httpRequest_0.AddParam("__usid", "6-Trpu0581vtrmyv:Prpu03z1ydfgyv:0-Arptxy01r6f2t0-RV=6:F=");
			httpRequest_0.AddParam("__user", C11D87AA);
			httpRequest_0.AddParam("__a", "1");
			httpRequest_0.AddParam("__dyn", "7AzHxqUW13yoR0mUyEqxenFwLBwopU98nwgUb84ibyQdwSAxacyUcouw-wYwJyEiwsovgO9wnoe8hw2nVEtwMw65xO2OU7m2210wEwgolzUO0-E4a3aUS2G5Usw9m1cwLwBgK7o884y0Mo4G4UfovwRwlE-U4C14xi4UaEW2au1jxS6FobrwKxm5oe85nxmu3W3i1QBx_y88Ee82xxWm2S3qazo2NwwwOg2cwMwBwwAzUjwTwNxe6Uak1xxWewxyo56");
			httpRequest_0.AddParam("__csr", "gbi9N79b2XmBinH8DVfq8WkKBcLEymRr8TKJitTJR_chRZ-Khapft5C_mXy4y9qhGQR8WhaF4HHBGAKKG8R_HVqiyqV9VaKij9vHqjiGFWBA9HHDyk8DlmVVnmOaV8F2bWGEBqcnxmte4K8Q-nU-Fox8BCm4_FGEGlDiXjXG5FVuGGqmEyuquWoLhWiVF8D-Q4VpaGnKmhauEObK9Jpoi-2h7z8J2otDgx28qK2a26dCyFK8zRXUlWxe58CdAUkxu2u4Gz-mfixO3C3y8x6aKbyF88o426oS9yEvwFxW3HzoJ0Mxa1EBz8OawBwEyo4qbwjopxW2C3S5oK6o465Ef8hwUxS2i0Fp86SawAxW1cxa588EC1iwbadKcwPws8bU0Zm0jC03hu1MwdG01KswhUfUO0gGnG0xEC8iS_UDzKlbF0EAUB3qGAFrVo0zi0dhwfG0LE0oWw18W0X80oQw6Nho2mwbpK0ha0eQw8u0jB07iw43w2SVCq1dwda9w3fohwXG0wUpw");
			httpRequest_0.AddParam("__req", "5o");
			httpRequest_0.AddParam("__hs", "19397.HYP:comet_plat_default_pkg.2.1.0.2.1");
			httpRequest_0.AddParam("dpr", "1");
			httpRequest_0.AddParam("__ccg", "GOOD");
			httpRequest_0.AddParam("__rev", "1006937294");
			httpRequest_0.AddParam("__s", "9cjcud:a5hz4r:faa4r4");
			httpRequest_0.AddParam("__hsi", "7198266292575202924");
			httpRequest_0.AddParam("__comet_req", "1");
			httpRequest_0.AddParam("fb_dtsg", string_0);
			httpRequest_0.AddParam("jazoest", "25467");
			httpRequest_0.AddParam("lsd", "ucAZBKRQvA2BazVPHRHkOt");
			httpRequest_0.AddParam("__spin_r", "1006937294");
			httpRequest_0.AddParam("__spin_b", "trunk");
			httpRequest_0.AddParam("__spin_t", "1675976974");
			httpRequest_0.AddParam("fb_api_caller_class", "RelayModern");
			httpRequest_0.AddParam("fb_api_req_friendly_name", "LWICometCreateBoostedComponentMutation");
			httpRequest_0.AddParam("variables", string_1);
			httpRequest_0.AddParam("server_timestamps", "true");
			httpRequest_0.AddParam("doc_id", "4887866407975731");
			httpRequest_0.AddParam("fb_api_analytics_tags", "[\"qpl_active_flow_ids=30605361\"]");
			string text = httpRequest_0.Post("https://www.facebook.com/api/graphql/").ToString();
			if (text.Replace(" ", "").Contains("boosting_status\":\"CREATING\""))
			{
				if (httpRequest_0.Cookies.ContainsKey("i_user"))
				{
					httpRequest_0.Cookies.Remove("i_user");
				}
				return true;
			}
		}
		catch
		{
		}
		if (httpRequest_0.Cookies.ContainsKey("i_user"))
		{
			httpRequest_0.Cookies.Remove("i_user");
		}
		return false;
	}

	internal static bool E3BAA38B(HttpRequest B030C1BC, string string_0, string string_1, string C2BD5B94)
	{
		try
		{
			B030C1BC.AddHeader("authority", "www.facebook.com");
			B030C1BC.AddHeader("accept", "*/*");
			B030C1BC.AddHeader("accept-language", "en-US,en;q=0.9");
			B030C1BC.AddHeader("origin", "https://www.facebook.com");
			B030C1BC.AddHeader("referer", "https://www.facebook.com/ad_center/create/boostpost/?");
			B030C1BC.AddHeader("sec-ch-prefers-color-scheme", "light");
			B030C1BC.AddHeader("sec-ch-ua-mobile", "?0");
			B030C1BC.AddHeader("sec-ch-ua-platform", "\"Windows\"");
			B030C1BC.AddHeader("sec-fetch-dest", "empty");
			B030C1BC.AddHeader("sec-fetch-mode", "cors");
			B030C1BC.AddHeader("sec-fetch-site", "same-origin");
			B030C1BC.AddHeader("viewport-width", "1210");
			B030C1BC.AddHeader("x-fb-friendly-name", "LWICometCreateBoostedComponentMutation");
			B030C1BC.AddHeader("x-fb-lsd", "ucAZBKRQvA2BazVPHRHkOt");
			B030C1BC.AddParam("av", C2BD5B94);
			B030C1BC.AddParam("__usid", "6-Trpu0581vtrmyv:Prpu03z1ydfgyv:0-Arptxy01r6f2t0-RV=6:F=");
			B030C1BC.AddParam("__user", C2BD5B94);
			B030C1BC.AddParam("__a", "1");
			B030C1BC.AddParam("__dyn", "7AzHxqUW13yoR0mUyEqxenFwLBwopU98nwgUb84ibyQdwSAxacyUcouw-wYwJyEiwsovgO9wnoe8hw2nVEtwMw65xO2OU7m2210wEwgolzUO0-E4a3aUS2G5Usw9m1cwLwBgK7o884y0Mo4G4UfovwRwlE-U4C14xi4UaEW2au1jxS6FobrwKxm5oe85nxmu3W3i1QBx_y88Ee82xxWm2S3qazo2NwwwOg2cwMwBwwAzUjwTwNxe6Uak1xxWewxyo56");
			B030C1BC.AddParam("__csr", "gbi9N79b2XmBinH8DVfq8WkKBcLEymRr8TKJitTJR_chRZ-Khapft5C_mXy4y9qhGQR8WhaF4HHBGAKKG8R_HVqiyqV9VaKij9vHqjiGFWBA9HHDyk8DlmVVnmOaV8F2bWGEBqcnxmte4K8Q-nU-Fox8BCm4_FGEGlDiXjXG5FVuGGqmEyuquWoLhWiVF8D-Q4VpaGnKmhauEObK9Jpoi-2h7z8J2otDgx28qK2a26dCyFK8zRXUlWxe58CdAUkxu2u4Gz-mfixO3C3y8x6aKbyF88o426oS9yEvwFxW3HzoJ0Mxa1EBz8OawBwEyo4qbwjopxW2C3S5oK6o465Ef8hwUxS2i0Fp86SawAxW1cxa588EC1iwbadKcwPws8bU0Zm0jC03hu1MwdG01KswhUfUO0gGnG0xEC8iS_UDzKlbF0EAUB3qGAFrVo0zi0dhwfG0LE0oWw18W0X80oQw6Nho2mwbpK0ha0eQw8u0jB07iw43w2SVCq1dwda9w3fohwXG0wUpw");
			B030C1BC.AddParam("__req", "5o");
			B030C1BC.AddParam("__hs", "19397.HYP:comet_plat_default_pkg.2.1.0.2.1");
			B030C1BC.AddParam("dpr", "1");
			B030C1BC.AddParam("__ccg", "GOOD");
			B030C1BC.AddParam("__rev", "1006937294");
			B030C1BC.AddParam("__s", "9cjcud:a5hz4r:faa4r4");
			B030C1BC.AddParam("__hsi", "7198266292575202924");
			B030C1BC.AddParam("__comet_req", "1");
			B030C1BC.AddParam("fb_dtsg", string_0);
			B030C1BC.AddParam("jazoest", "25467");
			B030C1BC.AddParam("lsd", "ucAZBKRQvA2BazVPHRHkOt");
			B030C1BC.AddParam("__spin_r", "1006937294");
			B030C1BC.AddParam("__spin_b", "trunk");
			B030C1BC.AddParam("__spin_t", "1675976974");
			B030C1BC.AddParam("fb_api_caller_class", "RelayModern");
			B030C1BC.AddParam("fb_api_req_friendly_name", "LWICometCreateBoostedComponentMutation");
			B030C1BC.AddParam("variables", string_1);
			B030C1BC.AddParam("server_timestamps", "true");
			B030C1BC.AddParam("doc_id", "4887866407975731");
			B030C1BC.AddParam("fb_api_analytics_tags", "[\"qpl_active_flow_ids=30605361\"]");
			string text = B030C1BC.Post("https://www.facebook.com/api/graphql/").ToString();
			if (text.Replace(" ", "").Contains("boosting_status\":\"CREATING\""))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static string smethod_46(HttpRequest httpRequest_0, string BFBAB91C, string string_0)
	{
		try
		{
			string value = httpRequest_0.Get("https://graph.facebook.com/v14.0/" + string_0 + "?fields=additional_profile_id,id,likes,followers_count,name,page_created_time&access_token=" + BFBAB91C).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			return jObject["additional_profile_id"].ToString();
		}
		catch
		{
		}
		return "";
	}

	internal static bool smethod_47(HttpRequest httpRequest_0, string E695232C, string string_0, string string_1 = "all_required")
	{
		try
		{
			string str = "__activeScenarioIDs=%5B%5D&__activeScenarios=%5B%5D&__interactionsMetadata=%5B%5D&_reqName=path%3A%2F" + E695232C + "&_reqSrc=adsDaoGraphDataMutator&endpoint=%2F" + E695232C + "&locale=en_GB&method=post&pretty=0&suppress_http_code=1&two_factor_type=" + string_1.Split('|')[0].Trim() + "&version=14.0&xref=f5dbd602d784c4";
			string text = httpRequest_0.Post("https://graph.facebook.com/v14.0/" + E695232C + "?access_token=" + string_0, str, "application/x-www-form-urlencoded").ToString();
			if (text.Contains("\"id\""))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	internal static bool smethod_48(HttpRequest httpRequest_0, string string_0, string string_1, string B10F2107)
	{
		try
		{
			string str = "_reqName=path%3A%2F851342156265409&_reqSrc=adsDaoGraphDataMutator&endpoint=%2F" + string_0 + "&locale=en_US&method=post&name=" + B10F2107 + "&pretty=0&suppress_http_code=1&version=12.0&xref=f25fd15a4543a38";
			string text = httpRequest_0.Post("https://graph.facebook.com/v14.0/" + string_0 + "?access_token=" + string_1, str, "application/x-www-form-urlencoded").ToString();
			if (text.Contains("id") && !text.Contains("error"))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public static bool smethod_49(HttpRequest httpRequest_0, string BC21A79F, string string_0, string string_1)
	{
		try
		{
			string str = "_reqName=path%3A%2F" + string_1 + "%2Fbusinesses&_reqSrc=adsDaoGraphDataMutator&business=" + string_0 + "&endpoint=%2F" + string_1 + "%2Fbusinesses&method=delete&pretty=0&suppress_http_code=1&userID=" + string_1 + "&version=11.0";
			string text = httpRequest_0.Post("https://graph.facebook.com/v14.0/" + string_1 + "/businesses?access_token=" + BC21A79F, str, "application/x-www-form-urlencoded").ToString();
			if (text.Contains("success\": true") || text.Contains("success\":true"))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	internal static string smethod_50(HttpRequest F7A6EDA5, string BE91229C, string string_0)
	{
		try
		{
			F7A6EDA5.AddHeader("authority", "business.facebook.com");
			F7A6EDA5.AddHeader("accept", "application/json, text/plain, */*");
			F7A6EDA5.AddHeader("accept-language", "en-US,en;q=0.9");
			F7A6EDA5.AddHeader("sec-ch-ua-mobile", "?0");
			F7A6EDA5.AddHeader("sec-ch-ua-platform", "\"Windows\"");
			F7A6EDA5.AddHeader("sec-fetch-dest", "empty");
			F7A6EDA5.AddHeader("sec-fetch-mode", "cors");
			F7A6EDA5.AddHeader("sec-fetch-site", "none");
			string address = "https://business.facebook.com/business/adaccount/limits/?business_id=" + BE91229C + "&__a=1&fb_dtsg=" + string_0 + "&lsd=TjnM69uZ_hcs8voJAsOR8Y";
			string text = F7A6EDA5.Post(address).ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(text.Replace("for (;;);", ""));
			return jObject["payload"]["adAccountLimit"].ToString();
		}
		catch
		{
		}
		return "undefined";
	}

	public static List<string> BF89BC16(HttpRequest httpRequest_0, string string_0, string AC3B25A0)
	{
		List<string> list = new List<string>();
		try
		{
			string text = httpRequest_0.Get("https://graph.facebook.com/v14.0/" + AC3B25A0 + "/business_users?access_token=" + string_0 + "&fields=email,+first_name,+last_name,+id,+pending_email,+role&limit=300&locale=en_US").ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(text.Replace("for (;;);", ""));
			for (int i = 0; i < jObject["data"].ToArray().Length; i++)
			{
				list.Add(jObject["data"][i]["id"].ToString());
			}
		}
		catch
		{
		}
		return list;
	}

	internal static List<string> EC322222(HttpRequest C02C4115, string string_0, string string_1, string string_2, string string_3)
	{
		List<string> list = new List<string>();
		try
		{
			C02C4115.AddHeader("authority", "business.facebook.com");
			C02C4115.AddHeader("accept", "*/*");
			C02C4115.AddHeader("accept-language", "en-US,en;q=0.9");
			C02C4115.AddHeader("origin", "https://business.facebook.com");
			C02C4115.AddHeader("referer", "https://business.facebook.com/latest/settings/business_users?business_id=" + string_1);
			C02C4115.Referer = "https://business.facebook.com/latest/settings/business_users?business_id=" + string_1;
			C02C4115.AddHeader("sec-ch-prefers-color-scheme", "light");
			C02C4115.AddHeader("sec-ch-ua-mobile", "?0");
			C02C4115.AddHeader("sec-ch-ua-platform", "\"Windows\"");
			C02C4115.AddHeader("sec-fetch-dest", "empty");
			C02C4115.AddHeader("sec-fetch-mode", "cors");
			C02C4115.AddHeader("sec-fetch-site", "same-origin");
			C02C4115.AddHeader("viewport-width", "967");
			C02C4115.AddHeader("x-fb-friendly-name", "BizKitSettingsPeopleTableContainerQuery");
			C02C4115.AddHeader("x-fb-lsd", "3MxWiotetgUtluyBvqJsX3");
			string str = "av=" + string_3 + "&__usid=6-Trpv2eiq2uk3h%3APrpv2gkrg2z7v%3A0-Arpv2e61m55be6-RV%3D6%3AF%3D&__user=" + string_3 + "&__a=1&__dyn=7xeUmxa2C5rgmwn8K2WnFwLBwCwgE98nwgU6C7UW3q9wCxW4E2czobo9E178qx60DU4m0nCqbwgE3awbG782Cwooa8465o-0nSUS1vwnE2PwBgao884y1uwoE5W3S48W0z8-UbE7i4UeoaE761iwKwHwqU8E5W3e1XxiawbW1Kxe6odEGdw46wbS1bwzwTwNwbO1pw&__csr=&__req=h&__hs=19398.BP%3Abizweb_pkg.2.0.0.0.0&dpr=1&__ccg=GOOD&__rev=1006943240&__s=vy1r4x%3A10q878%3A16byc1&__hsi=7198479762468035795&__comet_req=0&fb_dtsg=" + string_2 + "&jazoest=25517&lsd=3MxWiotetgUtluyBvqJsX3&__aaid=482492120569208&__spin_r=1006943240&__spin_b=trunk&__spin_t=1676026676&__jssesw=1&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=BizKitSettingsPeopleTableContainerQuery&variables=%7B%22businessID%22%3A%22" + string_1 + "%22%2C%22searchTerm%22%3Anull%2C%22orderBy%22%3Anull%2C%22permissions%22%3A%5B%5D%2C%22asset_types%22%3A%5B%22PAGE%22%2C%22AD_ACCOUNT%22%2C%22PRODUCT_CATALOG%22%2C%22APP%22%2C%22PIXEL%22%2C%22INSTAGRAM_ACCOUNT_V2%22%2C%22OFFLINE_CONVERSION_DATA_SET%22%2C%22CUSTOM_CONVERSION%22%2C%22WHATSAPP_BUSINESS_ACCOUNT%22%2C%22BUSINESS_CREATIVE_FOLDER%22%2C%22EVENTS_DATASET_NEW%22%2C%22OFFSITE_EMAIL_ACCOUNT%22%5D%7D&server_timestamps=true&doc_id=5811120718910610";
			string value = C02C4115.Post("https://business.facebook.com/api/graphql/", str, "application/x-www-form-urlencoded").ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			for (int i = 0; i < jObject["data"]["business"]["business_users_and_invitations"]["edges"].ToArray().Length; i++)
			{
				if (jObject["data"]["business"]["business_users_and_invitations"]["edges"][i]["nameColumn"]["invited_email"] == null)
				{
					list.Add(jObject["data"]["business"]["business_users_and_invitations"]["edges"][i]["nameColumn"]["id"].ToString());
				}
			}
		}
		catch
		{
		}
		return list;
	}

	internal static bool FF091488(HttpRequest httpRequest_0, string string_0, string D4019389, string B68DF1A1, string string_1)
	{
		try
		{
			string str = "__activeScenarioIDs=%5B%5D&__activeScenarios=%5B%5D&__interactionsMetadata=%5B%5D&_reqName=object%3Abusiness_user&_reqSrc=UserServerActions.brands&first_name=" + B68DF1A1 + "&last_name=" + string_1 + "&locale=en_GB&method=post&personaId=" + string_0 + "&pretty=0&suppress_http_code=1&xref=f33005a6a91626";
			string text = httpRequest_0.Post("https://graph.facebook.com/v14.0/" + string_0 + "?access_token=" + D4019389, str, "application/x-www-form-urlencoded").ToString();
			if (text.Contains("success") && text.Contains("true"))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	internal static List<string> smethod_51(HttpRequest httpRequest_0, string string_0, string C9BC6037)
	{
		List<string> list = new List<string>();
		try
		{
			string value = httpRequest_0.Get("https://graph.facebook.com/v14.0/" + string_0 + "/business_users?access_token=" + C9BC6037 + "&_reqName=object%3Abusiness%2Fbusiness_users&_reqSrc=BusinessConnectedConfirmedUsersStore.brands&date_format=U&fields=id&limit=100&locale=en_US&method=get&pretty=0&sort=name_ascending&suppress_http_code=1&xref=f2f5f8ef6775918").ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			int num = jObject["data"].ToArray().Length;
			for (int i = 0; i < num; i++)
			{
				try
				{
					if (!jObject["data"][i]["id"].ToString().Equals(""))
					{
						list.Add(jObject["data"][i]["id"].ToString());
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		return list;
	}

	internal static string E1994117(HttpRequest httpRequest_0, string B5905D26, string F038088B)
	{
		try
		{
			string value = httpRequest_0.Get("https://graph.facebook.com/v14.0/" + B5905D26 + "?access_token=" + F038088B + "&__cppo=1&_reqName=object%3Abrand&_reqSrc=BrandResourceRequests.brands&date_format=U&fields=%5B%22id%22%2C%22name%22%2C%22vertical_id%22%2C%22timezone_id%22%2C%22picture.type(square)%22%2C%22primary_page.fields(name%2C%20picture%2C%20link)%22%2C%22payment_account_id%22%2C%22link%22%2C%22created_time%22%2C%22created_by.fields(name)%22%2C%22updated_time%22%2C%22updated_by.fields(name)%22%2C%22extended_updated_time%22%2C%22two_factor_type%22%2C%22allow_page_management_in_www%22%2C%22eligible_app_id_for_ami_initiation%22%2C%22verification_status%22%2C%22sharing_eligibility_status%22%2C%22can_create_ad_account%22%2C%22can_use_extended_credit%22%2C%22is_business_verification_eligible%22%2C%22is_tier_restricted%22%2C%22is_tier_pending_compromise_review%22%2C%22is_non_discrimination_certified%22%2C%22can_add_or_create_page%22%2C%22has_opted_out_business_verification%22%2C%22business_verification_directional_exp_bucket%22%5D&locale=en_US&method=get&pretty=0&suppress_http_code=1&xref=f15c69b39306ca8").ToString();
			JObject jObject = (JObject)JsonConvert.DeserializeObject(value);
			return jObject["updated_by"]["id"].ToString();
		}
		catch
		{
		}
		return "";
	}

	internal static bool smethod_52(HttpRequest D209AD90, string string_0, string B6A7C29D, string string_1, string C5BF480D)
	{
		try
		{
			D209AD90.AddHeader("authority", "business.facebook.com");
			D209AD90.AddHeader("accept", "*/*");
			D209AD90.AddHeader("accept-language", "en-US,en;q=0.9");
			D209AD90.AddHeader("origin", "https://business.facebook.com");
			D209AD90.AddHeader("referer", "https://business.facebook.com/settings/people/" + C5BF480D + "?business_id=" + string_0);
			D209AD90.AddHeader("sec-ch-prefers-color-scheme", "light");
			D209AD90.AddHeader("sec-ch-ua-mobile", "?0");
			D209AD90.AddHeader("sec-ch-ua-platform", "\"Windows\"");
			D209AD90.AddHeader("sec-fetch-dest", "empty");
			D209AD90.AddHeader("sec-fetch-mode", "cors");
			D209AD90.AddHeader("sec-fetch-site", "same-origin");
			D209AD90.AddHeader("viewport-width", "891");
			D209AD90.AddHeader("x-fb-friendly-name", "BizKitSettingsRemoveBusinessUserMutation");
			D209AD90.AddHeader("x-fb-lsd", "EPRnOckDrwR9gVM6C4F0PZ");
			string str = "av=" + string_1 + "&__usid=6-Trpv2eiq2uk3h%3APrpv44ctr52e8%3A0-Arpv2e61m55be6-RV%3D6%3AF%3D&__user=" + string_1 + "&__a=1&__dyn=7xeUmxa2C5rgmwn8K2WnFwLBwCwgE98nwgU6C7UW3q9zooxW4E2czobo9E178qx60DU4m0nCqbwgE3awbG782Cwwwg8a8465o-0nSUS1vwnE2PwBgao884y1uwoE5W3S48W0z8-UbE7i4UeoaE761iwKwHwqU8E5W3e1XxiawQw8C1Kxe6odEGdw46wbS1bwzwTwNwbO1pw&__csr=&__req=1k&__hs=19398.BP%3Abizweb_pkg.2.0.0.0.0&dpr=1&__ccg=GOOD&__rev=1006943240&__s=yptfst%3A10q878%3Aipey5t&__hsi=7198489005209626303&__comet_req=0&fb_dtsg=" + B6A7C29D + "&jazoest=25251&lsd=EPRnOckDrwR9gVM6C4F0PZ&__aaid=482492120569208&__spin_r=1006943240&__spin_b=trunk&__spin_t=1676028828&__jssesw=1&fb_api_caller_class=RelayModern&fb_api_req_friendly_name=BizKitSettingsRemoveBusinessUserMutation&variables=%7B%22businessID%22%3A%22" + string_0 + "%22%2C%22businessUserID%22%3A%22" + C5BF480D + "%22%7D&server_timestamps=true&doc_id=5477386638957765&fb_api_analytics_tags=%5B%22qpl_active_flow_ids%3D558508505%22%5D";
			string text = D209AD90.Post("https://business.facebook.com/api/graphql/", str, "application/x-www-form-urlencoded").ToString();
			if (text.Replace(" ", "").Contains("removed_business_user_id\":\"" + C5BF480D))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}
}
