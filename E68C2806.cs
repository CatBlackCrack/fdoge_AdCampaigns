using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DeviceId;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class E68C2806 : Form
{
	[CompilerGenerated]
	private sealed class Class8
	{
		private sealed class F8A1581E : IAsyncStateMachine
		{
			public int int_0;

			public AsyncVoidMethodBuilder asyncVoidMethodBuilder_0;

			public Class8 E20CB51C;

			private bool A3BB8298;

			private bool CC82D119;

			private TaskAwaiter<bool> B325A5BB;

			void IAsyncStateMachine.MoveNext()
			{
				int num = int_0;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						awaiter = E20CB51C.D5BE8CBC.method_0().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							B325A5BB = awaiter;
							F8A1581E stateMachine = this;
							asyncVoidMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							return;
						}
					}
					else
					{
						awaiter = B325A5BB;
						B325A5BB = default(TaskAwaiter<bool>);
						num = -1;
						int_0 = -1;
					}
					CC82D119 = awaiter.GetResult();
					A3BB8298 = CC82D119;
					if (!A3BB8298)
					{
						MessageBox.Show("Khởi tạo tool lỗi, kiểm tra lại network hoặc version của tool trên máy của bạn.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						Environment.Exit(0);
					}
					E20CB51C.D5BE8CBC.method_2(E20CB51C.string_0);
				}
				catch (Exception exception)
				{
					int_0 = -2;
					asyncVoidMethodBuilder_0.SetException(exception);
					return;
				}
				int_0 = -2;
				asyncVoidMethodBuilder_0.SetResult();
			}

			[DebuggerHidden]
			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine A787F08C)
			{
			}
		}

		public string string_0;

		public E68C2806 D5BE8CBC;

		[AsyncStateMachine(typeof(F8A1581E))]
		[DebuggerStepThrough]
		internal void method_0()
		{
			F8A1581E stateMachine = new F8A1581E();
			stateMachine.asyncVoidMethodBuilder_0 = AsyncVoidMethodBuilder.Create();
			stateMachine.E20CB51C = this;
			stateMachine.int_0 = -1;
			stateMachine.asyncVoidMethodBuilder_0.Start(ref stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class Class9
	{
		public JObject jobject_0;

		public E68C2806 e68C2806_0;

		internal void E1B21D17()
		{
			e68C2806_0.A005B8B8.Text = jobject_0["bank"]["MOMO"].ToString();
		}

		internal void method_0()
		{
			e68C2806_0.BEB94E01.Text = jobject_0["bank"]["VCB"].ToString();
		}

		internal void method_1()
		{
			e68C2806_0.labelPrice.Text = jobject_0["ToolList"][Class1.BC09E33E]["price"].ToString() + "vnd /1 tháng (tối thiểu 1 tháng)";
		}
	}

	[CompilerGenerated]
	private sealed class B8A50501 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder_0;

		public E68C2806 e68C2806_0;

		private Class9 class9_0;

		private HttpClient httpClient_0;

		private string string_0;

		private string string_1;

		private Exception BEAD4236;

		private TaskAwaiter<string> taskAwaiter_0;

		private void A2203181()
		{
			int num = int_0;
			bool result;
			try
			{
				if (num == 0)
				{
				}
				try
				{
					TaskAwaiter<string> awaiter;
					if (num != 0)
					{
						class9_0 = new Class9();
						class9_0.e68C2806_0 = e68C2806_0;
						ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
						httpClient_0 = new HttpClient();
						awaiter = httpClient_0.GetStringAsync("https://github.com/phamsytruong/key-license/blob/main/info_2").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = 0;
							int_0 = 0;
							taskAwaiter_0 = awaiter;
							B8A50501 stateMachine = this;
							asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<string>);
						num = -1;
						int_0 = -1;
					}
					string_1 = awaiter.GetResult();
					string_0 = string_1;
					string_1 = null;
					string_0 = string_0.Split(new string[1] { "js-file-line\">" }, StringSplitOptions.None)[1].Split('<')[0].Trim();
					string_0 = smethod_0(string_0);
					class9_0.jobject_0 = (JObject)JsonConvert.DeserializeObject(string_0);
					Class1.String_0 = class9_0.jobject_0["ToolList"]["FacebookSetCamp"]["verion"].ToString();
					Class1.C82F7CB5 = class9_0.jobject_0["Notify"].ToString();
					e68C2806_0.A005B8B8.Invoke((MethodInvoker)delegate
					{
						class9_0.e68C2806_0.A005B8B8.Text = class9_0.jobject_0["bank"]["MOMO"].ToString();
					});
					e68C2806_0.BEB94E01.Invoke((MethodInvoker)delegate
					{
						class9_0.e68C2806_0.BEB94E01.Text = class9_0.jobject_0["bank"]["VCB"].ToString();
					});
					e68C2806_0.labelPrice.Invoke((MethodInvoker)delegate
					{
						class9_0.e68C2806_0.labelPrice.Text = class9_0.jobject_0["ToolList"][Class1.BC09E33E]["price"].ToString() + "vnd /1 tháng (tối thiểu 1 tháng)";
					});
					result = true;
				}
				catch (Exception bEAD)
				{
					BEAD4236 = bEAD;
					e68C2806_0.A005B8B8.Invoke((MethodInvoker)delegate
					{
						e68C2806_0.A005B8B8.Text = "Không lấy được thông tin";
					});
					e68C2806_0.BEB94E01.Invoke((MethodInvoker)delegate
					{
						e68C2806_0.BEB94E01.Text = "Không lấy được thông tin";
					});
					e68C2806_0.labelPrice.Invoke((MethodInvoker)delegate
					{
						e68C2806_0.labelPrice.Text = "Không lấy được thông tin";
					});
					goto IL_0256;
				}
				goto end_IL_0007;
				IL_0256:
				result = false;
				end_IL_0007:;
			}
			catch (Exception bEAD)
			{
				int_0 = -2;
				asyncTaskMethodBuilder_0.SetException(bEAD);
				return;
			}
			int_0 = -2;
			asyncTaskMethodBuilder_0.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in A2203181
			this.A2203181();
		}

		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine AEAF9B3A)
		{
		}
	}

	[CompilerGenerated]
	private sealed class Class10
	{
		public long long_0;

		public long long_1;

		public DateTime B7B7819F;

		public E68C2806 B7116183;

		internal void AC3AC8A1()
		{
			if (long_0 <= long_1)
			{
				B7116183.AB8B4F05.Text = string.Format("{0}-{1}-{2}", ("0" + B7B7819F.Day).Substring(("0" + B7B7819F.Day).Length - 2), ("0" + B7B7819F.Month).Substring(("0" + B7B7819F.Month).Length - 2), B7B7819F.Year);
				B7116183.AB8B4F05.ForeColor = Color.Green;
			}
			else
			{
				B7116183.AB8B4F05.Text = string.Format("{0}-{1}-{2} - ĐÃ HẾT HẠN", ("0" + B7B7819F.Day).Substring(("0" + B7B7819F.Day).Length - 2), ("0" + B7B7819F.Month).Substring(("0" + B7B7819F.Month).Length - 2), B7B7819F.Year);
			}
		}
	}

	[CompilerGenerated]
	private sealed class B8B455B2 : IAsyncStateMachine
	{
		public int DE241394;

		public AsyncTaskMethodBuilder<bool> F084F924;

		public string string_0;

		public E68C2806 EA29C72E;

		private Class10 class10_0;

		private HttpClient DBB28710;

		private string B482C99E;

		private List<string> list_0;

		private string F9B3221C;

		private JObject jobject_0;

		private string string_1;

		private Exception exception_0;

		private TaskAwaiter<string> taskAwaiter_0;

		void IAsyncStateMachine.MoveNext()
		{
			//Discarded unreachable code: IL_0379, IL_0386
			int dE = DE241394;
			bool result;
			try
			{
				if (dE == 0)
				{
				}
				try
				{
					TaskAwaiter<string> awaiter;
					if (dE != 0)
					{
						class10_0 = new Class10();
						class10_0.B7116183 = EA29C72E;
						ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
						DBB28710 = new HttpClient();
						awaiter = DBB28710.GetStringAsync("https://github.com/phamsytruong/key-license/blob/main/fb_set_camp").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							dE = 0;
							DE241394 = 0;
							taskAwaiter_0 = awaiter;
							B8B455B2 stateMachine = this;
							F084F924.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
							return;
						}
					}
					else
					{
						awaiter = taskAwaiter_0;
						taskAwaiter_0 = default(TaskAwaiter<string>);
						dE = -1;
						DE241394 = -1;
					}
					string_1 = awaiter.GetResult();
					B482C99E = string_1;
					string_1 = null;
					B482C99E = B482C99E.Split(new string[1] { "js-file-line\">" }, StringSplitOptions.None)[1].Split('<')[0].Trim();
					list_0 = new List<string>();
					list_0.Add("012!Az");
					list_0.Add("tg");
					list_0.Add("w");
					list_0.Add("@");
					list_0.Add("!");
					list_0.Add("G");
					list_0.Add("f");
					list_0.Add("4");
					list_0.Add("s");
					list_0.Add("z");
					list_0.Add("i");
					list_0.Add("@v1");
					list_0.Add("!w");
					list_0.Add("Gv");
					list_0.Add("fv");
					list_0.Add("4v");
					list_0.Add("sv");
					list_0.Add("zv3");
					F9B3221C = Class2.D522FDBA(B482C99E, string.Join("", list_0));
					Class1.FD101B13 = F9B3221C;
					jobject_0 = (JObject)JsonConvert.DeserializeObject(Class1.FD101B13);
					if (F9B3221C.Contains(string_0))
					{
						class10_0.long_1 = long.Parse(jobject_0.ToString().Split(new string[1] { string_0 }, StringSplitOptions.None)[1].Split('"')[2].Trim());
						class10_0.long_0 = D53A7700.smethod_1(D53A7700.smethod_2());
						Class1.Int64_0 = class10_0.long_0;
						class10_0.B7B7819F = D53A7700.smethod_0(class10_0.long_1);
						EA29C72E.AB8B4F05.Invoke((MethodInvoker)delegate
						{
							if (class10_0.long_0 <= class10_0.long_1)
							{
								class10_0.B7116183.AB8B4F05.Text = string.Format("{0}-{1}-{2}", ("0" + class10_0.B7B7819F.Day).Substring(("0" + class10_0.B7B7819F.Day).Length - 2), ("0" + class10_0.B7B7819F.Month).Substring(("0" + class10_0.B7B7819F.Month).Length - 2), class10_0.B7B7819F.Year);
								class10_0.B7116183.AB8B4F05.ForeColor = Color.Green;
							}
							else
							{
								class10_0.B7116183.AB8B4F05.Text = string.Format("{0}-{1}-{2} - ĐÃ HẾT HẠN", ("0" + class10_0.B7B7819F.Day).Substring(("0" + class10_0.B7B7819F.Day).Length - 2), ("0" + class10_0.B7B7819F.Month).Substring(("0" + class10_0.B7B7819F.Month).Length - 2), class10_0.B7B7819F.Year);
							}
						});
						if (class10_0.long_0 <= class10_0.long_1)
						{
							_ = 1;
							/*Error near IL_0374: Invalid metadata token*/;
						}
						_ = 0;
						/*Error near IL_0381: Invalid metadata token*/;
					}
					try
					{
						EA29C72E.AB8B4F05.Invoke((MethodInvoker)delegate
						{
							EA29C72E.AB8B4F05.Text = "KEY CHƯA ĐƯỢC ĐĂNG KÝ !";
						});
					}
					catch
					{
					}
					result = false;
				}
				catch (Exception ex)
				{
					exception_0 = ex;
					try
					{
						EA29C72E.AB8B4F05.Invoke((MethodInvoker)delegate
						{
							EA29C72E.AB8B4F05.Text = "CAN_NOT_CHECK_LICENSE. ERROR";
						});
					}
					catch
					{
					}
					goto IL_03e5;
				}
				goto end_IL_0007;
				IL_03e5:
				result = false;
				end_IL_0007:;
			}
			catch (Exception ex)
			{
				DE241394 = -2;
				F084F924.SetException(ex);
				return;
			}
			DE241394 = -2;
			F084F924.SetResult(result);
		}

		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private IContainer icontainer_0 = null;

	private Panel panel1;

	private GroupBox groupBox1;

	private Label B43E3CA5;

	private Panel panel7;

	private Label E4A38A0B;

	private Label labelPrice;

	private Panel A01A242E;

	private LinkLabel linkLabelCopyVietcombank;

	private Label D58673AB;

	private Label BEB94E01;

	private Panel panel5;

	private LinkLabel linkLabelCopyMomo;

	private Label label7;

	private Label A005B8B8;

	private Panel panel4;

	private LinkLabel F83244AC;

	private Label label5;

	private Label F22A43B1;

	private Panel panel3;

	private Label AB8B4F05;

	private Label label3;

	private Panel panel2;

	private LinkLabel A3B56E1C;

	private Label label1;

	private Label EAA3D8AD;

	public E68C2806()
	{
        E68C2806.Class8 @class = new E68C2806.Class8();
        @class.D5BE8CBC = this;
        this.ED043710();
        this.method_1();
        @class.string_0 = this.EAA3D8AD.Text;
        new Thread(new ThreadStart(@class.method_0))
        {
            IsBackground = true
        }.Start();
    }

	[AsyncStateMachine(typeof(B8A50501))]
	[DebuggerStepThrough]
	private Task<bool> method_0()
	{
		B8A50501 stateMachine = new B8A50501();
		stateMachine.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine.e68C2806_0 = this;
		stateMachine.int_0 = -1;
		stateMachine.asyncTaskMethodBuilder_0.Start(ref stateMachine);
		return stateMachine.asyncTaskMethodBuilder_0.Task;
	}

	public static string smethod_0(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	private void method_1()
	{
		//Discarded unreachable code: IL_0163, IL_0171
		string text = "";
		bool flag = false;
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName.Contains("vmtoolsd"))
			{
				flag = true;
			}
		}
		if (flag)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("System\\CurrentControlSet\\services\\Doge", writable: true);
			if (registryKey == null)
			{
				text = Class12.CA27BAB2(5);
				registryKey = Registry.CurrentUser.CreateSubKey("System\\CurrentControlSet\\services\\Doge");
				registryKey.SetValue("isActived", text ?? "");
			}
			else
			{
				text = registryKey.GetValue("isActived").ToString().Replace("dword:", "")
					.Trim();
			}
		}
		try
		{
			string text2 = new DeviceIdBuilder().AddMachineName().AddProcessorId().AddMotherboardSerialNumber()
				.AddSystemDriveSerialNumber()
				.ToString();
			using SHA256Managed sHA256Managed = new SHA256Managed();
			byte[] bytes = Encoding.UTF8.GetBytes("FSC" + text2 + text);
			byte[] array2 = sHA256Managed.ComputeHash(bytes);
			EAA3D8AD.Text = "FSC" + BitConverter.ToString(array2).Replace("-", string.Empty).ToString()
				.Substring(0, 19);
			F22A43B1.Text = "DT " + EAA3D8AD.Text;
			_ = EAA3D8AD.Text;
			/*Error near IL_015e: Invalid metadata token*/;
		}
		catch
		{
		}
		if (EAA3D8AD.Text.Trim().Equals("") || EAA3D8AD.Text.Trim().Contains("XXXXXXXXXXX"))
		{
			MessageBox.Show("Cannot get key of license !", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	[AsyncStateMachine(typeof(B8B455B2))]
	[DebuggerStepThrough]
	private Task<bool> method_2(string string_0)
	{
		B8B455B2 stateMachine = new B8B455B2();
		stateMachine.F084F924 = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine.EA29C72E = this;
		stateMachine.string_0 = string_0;
		stateMachine.DE241394 = -1;
		stateMachine.F084F924.Start(ref stateMachine);
		return stateMachine.F084F924.Task;
	}

	private void F83244AC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Clipboard.SetText(F22A43B1.Text);
		MessageBox.Show("Đã copy thành công", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	private void F6B58317(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Clipboard.SetText(BEB94E01.Text);
		MessageBox.Show("Đã copy thành công", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	private void linkLabelCopyMomo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Clipboard.SetText(A005B8B8.Text);
		MessageBox.Show("Đã copy thành công", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	private void A3B56E1C_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Clipboard.SetText(EAA3D8AD.Text);
		MessageBox.Show("Đã copy thành công", "Copied", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	protected override void Dispose(bool CA074012)
	{
		if (CA074012 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(CA074012);
	}

	private void ED043710()
	{
		panel1 = new Panel();
		groupBox1 = new GroupBox();
		B43E3CA5 = new Label();
		panel7 = new Panel();
		E4A38A0B = new Label();
		labelPrice = new Label();
		A01A242E = new Panel();
		linkLabelCopyVietcombank = new LinkLabel();
		D58673AB = new Label();
		BEB94E01 = new Label();
		panel5 = new Panel();
		linkLabelCopyMomo = new LinkLabel();
		label7 = new Label();
		A005B8B8 = new Label();
		panel4 = new Panel();
		F83244AC = new LinkLabel();
		label5 = new Label();
		F22A43B1 = new Label();
		panel3 = new Panel();
		AB8B4F05 = new Label();
		label3 = new Label();
		panel2 = new Panel();
		A3B56E1C = new LinkLabel();
		label1 = new Label();
		EAA3D8AD = new Label();
		panel1.SuspendLayout();
		groupBox1.SuspendLayout();
		panel7.SuspendLayout();
		A01A242E.SuspendLayout();
		panel5.SuspendLayout();
		panel4.SuspendLayout();
		panel3.SuspendLayout();
		panel2.SuspendLayout();
		SuspendLayout();
		panel1.Controls.Add(groupBox1);
		panel1.Controls.Add(panel3);
		panel1.Controls.Add(panel2);
		panel1.Dock = DockStyle.Fill;
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(803, 460);
		panel1.TabIndex = 0;
		panel1.Paint += panel1_Paint;
		groupBox1.Controls.Add(B43E3CA5);
		groupBox1.Controls.Add(panel7);
		groupBox1.Controls.Add(A01A242E);
		groupBox1.Controls.Add(panel5);
		groupBox1.Controls.Add(panel4);
		groupBox1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		groupBox1.Location = new Point(46, 117);
		groupBox1.Name = "groupBox1";
		groupBox1.Size = new Size(581, 228);
		groupBox1.TabIndex = 8;
		groupBox1.TabStop = false;
		groupBox1.Text = "Register or renew (đăng ký hoặc gia hạn mới)";
		B43E3CA5.AutoSize = true;
		B43E3CA5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		B43E3CA5.Location = new Point(68, 187);
		B43E3CA5.Margin = new Padding(4, 0, 4, 0);
		B43E3CA5.Name = "label13";
		B43E3CA5.Size = new Size(412, 16);
		B43E3CA5.TabIndex = 6;
		B43E3CA5.Text = "Sau khi chuyển khoản vui lòng chờ 2 - 3p hệ thống sẽ tự động update !";
		panel7.Controls.Add(E4A38A0B);
		panel7.Controls.Add(labelPrice);
		panel7.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		panel7.Location = new Point(29, 136);
		panel7.Name = "panel7";
		panel7.Size = new Size(525, 31);
		panel7.TabIndex = 9;
		E4A38A0B.AutoSize = true;
		E4A38A0B.Location = new Point(4, 7);
		E4A38A0B.Margin = new Padding(4, 0, 4, 0);
		E4A38A0B.Name = "label11";
		E4A38A0B.Size = new Size(53, 16);
		E4A38A0B.TabIndex = 1;
		E4A38A0B.Text = "Số tiền:";
		labelPrice.AutoSize = true;
		labelPrice.Location = new Point(150, 7);
		labelPrice.Margin = new Padding(4, 0, 4, 0);
		labelPrice.Name = "labelPrice";
		labelPrice.Size = new Size(69, 16);
		labelPrice.TabIndex = 2;
		labelPrice.Text = "updating...";
		A01A242E.Controls.Add(linkLabelCopyVietcombank);
		A01A242E.Controls.Add(D58673AB);
		A01A242E.Controls.Add(BEB94E01);
		A01A242E.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		A01A242E.Location = new Point(29, 65);
		A01A242E.Name = "panel6";
		A01A242E.Size = new Size(525, 31);
		A01A242E.TabIndex = 9;
		linkLabelCopyVietcombank.AutoSize = true;
		linkLabelCopyVietcombank.Location = new Point(474, 7);
		linkLabelCopyVietcombank.Name = "linkLabelCopyVietcombank";
		linkLabelCopyVietcombank.Size = new Size(36, 16);
		linkLabelCopyVietcombank.TabIndex = 3;
		linkLabelCopyVietcombank.TabStop = true;
		linkLabelCopyVietcombank.Text = "Copy";
		linkLabelCopyVietcombank.LinkClicked += F6B58317;
		D58673AB.AutoSize = true;
		D58673AB.Location = new Point(4, 7);
		D58673AB.Margin = new Padding(4, 0, 4, 0);
		D58673AB.Name = "label9";
		D58673AB.Size = new Size(86, 16);
		D58673AB.TabIndex = 1;
		D58673AB.Text = "Vietcombank:";
		BEB94E01.AutoSize = true;
		BEB94E01.Location = new Point(150, 7);
		BEB94E01.Margin = new Padding(4, 0, 4, 0);
		BEB94E01.Name = "labelVcbInfo";
		BEB94E01.Size = new Size(69, 16);
		BEB94E01.TabIndex = 2;
		BEB94E01.Text = "updating...";
		panel5.Controls.Add(linkLabelCopyMomo);
		panel5.Controls.Add(label7);
		panel5.Controls.Add(A005B8B8);
		panel5.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		panel5.Location = new Point(29, 31);
		panel5.Name = "panel5";
		panel5.Size = new Size(525, 31);
		panel5.TabIndex = 8;
		linkLabelCopyMomo.AutoSize = true;
		linkLabelCopyMomo.Location = new Point(474, 7);
		linkLabelCopyMomo.Name = "linkLabelCopyMomo";
		linkLabelCopyMomo.Size = new Size(36, 16);
		linkLabelCopyMomo.TabIndex = 3;
		linkLabelCopyMomo.TabStop = true;
		linkLabelCopyMomo.Text = "Copy";
		linkLabelCopyMomo.LinkClicked += linkLabelCopyMomo_LinkClicked;
		label7.AutoSize = true;
		label7.Location = new Point(4, 7);
		label7.Margin = new Padding(4, 0, 4, 0);
		label7.Name = "label7";
		label7.Size = new Size(48, 16);
		label7.TabIndex = 1;
		label7.Text = "Momo:";
		A005B8B8.AutoSize = true;
		A005B8B8.Location = new Point(150, 7);
		A005B8B8.Margin = new Padding(4, 0, 4, 0);
		A005B8B8.Name = "labelMomoInfo";
		A005B8B8.Size = new Size(69, 16);
		A005B8B8.TabIndex = 2;
		A005B8B8.Text = "updating...";
		panel4.Controls.Add(F83244AC);
		panel4.Controls.Add(label5);
		panel4.Controls.Add(F22A43B1);
		panel4.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		panel4.Location = new Point(29, 100);
		panel4.Name = "panel4";
		panel4.Size = new Size(525, 31);
		panel4.TabIndex = 7;
		F83244AC.AutoSize = true;
		F83244AC.Location = new Point(474, 7);
		F83244AC.Name = "linkLabelCopyContent";
		F83244AC.Size = new Size(36, 16);
		F83244AC.TabIndex = 3;
		F83244AC.TabStop = true;
		F83244AC.Text = "Copy";
		F83244AC.LinkClicked += F83244AC_LinkClicked;
		label5.AutoSize = true;
		label5.Location = new Point(4, 7);
		label5.Margin = new Padding(4, 0, 4, 0);
		label5.Name = "label5";
		label5.Size = new Size(63, 16);
		label5.TabIndex = 1;
		label5.Text = "Nội dung:";
		F22A43B1.AutoSize = true;
		F22A43B1.Location = new Point(150, 7);
		F22A43B1.Margin = new Padding(4, 0, 4, 0);
		F22A43B1.Name = "labelContent";
		F22A43B1.Size = new Size(69, 16);
		F22A43B1.TabIndex = 2;
		F22A43B1.Text = "updating...";
		panel3.Controls.Add(AB8B4F05);
		panel3.Controls.Add(label3);
		panel3.Location = new Point(46, 75);
		panel3.Name = "panel3";
		panel3.Size = new Size(581, 31);
		panel3.TabIndex = 7;
		AB8B4F05.AutoSize = true;
		AB8B4F05.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		AB8B4F05.ForeColor = Color.Red;
		AB8B4F05.Location = new Point(107, 7);
		AB8B4F05.Margin = new Padding(4, 0, 4, 0);
		AB8B4F05.Name = "labelExpiredTime";
		AB8B4F05.Size = new Size(77, 16);
		AB8B4F05.TabIndex = 5;
		AB8B4F05.Text = "updating...";
		label3.AutoSize = true;
		label3.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label3.Location = new Point(4, 7);
		label3.Margin = new Padding(4, 0, 4, 0);
		label3.Name = "label3";
		label3.Size = new Size(84, 16);
		label3.TabIndex = 4;
		label3.Text = "ExpiredTime:";
		panel2.Controls.Add(A3B56E1C);
		panel2.Controls.Add(label1);
		panel2.Controls.Add(EAA3D8AD);
		panel2.Location = new Point(46, 35);
		panel2.Name = "panel2";
		panel2.Size = new Size(581, 31);
		panel2.TabIndex = 6;
		A3B56E1C.AutoSize = true;
		A3B56E1C.Location = new Point(359, 7);
		A3B56E1C.Name = "linkLabel1";
		A3B56E1C.Size = new Size(69, 17);
		A3B56E1C.TabIndex = 3;
		A3B56E1C.TabStop = true;
		A3B56E1C.Text = "Copy Key";
		A3B56E1C.LinkClicked += A3B56E1C_LinkClicked;
		label1.AutoSize = true;
		label1.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		label1.Location = new Point(4, 7);
		label1.Margin = new Padding(4, 0, 4, 0);
		label1.Name = "label1";
		label1.Size = new Size(76, 16);
		label1.TabIndex = 1;
		label1.Text = "Key license:";
		EAA3D8AD.AutoSize = true;
		EAA3D8AD.Font = new Font("Tahoma", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		EAA3D8AD.Location = new Point(107, 7);
		EAA3D8AD.Margin = new Padding(4, 0, 4, 0);
		EAA3D8AD.Name = "labelKey";
		EAA3D8AD.Size = new Size(136, 16);
		EAA3D8AD.TabIndex = 2;
		EAA3D8AD.Text = "XXXXXXXXXXXXXXXX";
		base.AutoScaleDimensions = new SizeF(8f, 17f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(803, 460);
		base.Controls.Add(panel1);
		Font = new Font("Century Gothic", 9.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Margin = new Padding(4);
		base.Name = "fLicense";
		Text = "fLicense";
		panel1.ResumeLayout(performLayout: false);
		groupBox1.ResumeLayout(performLayout: false);
		groupBox1.PerformLayout();
		panel7.ResumeLayout(performLayout: false);
		panel7.PerformLayout();
		A01A242E.ResumeLayout(performLayout: false);
		A01A242E.PerformLayout();
		panel5.ResumeLayout(performLayout: false);
		panel5.PerformLayout();
		panel4.ResumeLayout(performLayout: false);
		panel4.PerformLayout();
		panel3.ResumeLayout(performLayout: false);
		panel3.PerformLayout();
		panel2.ResumeLayout(performLayout: false);
		panel2.PerformLayout();
		ResumeLayout(performLayout: false);
	}

	[CompilerGenerated]
	private void F2A5EF02()
	{
		A005B8B8.Text = "Không lấy được thông tin";
	}

	[CompilerGenerated]
	private void CC8F65B8()
	{
		BEB94E01.Text = "Không lấy được thông tin";
	}

	[CompilerGenerated]
	private void C904AC0B()
	{
		labelPrice.Text = "Không lấy được thông tin";
	}

	[CompilerGenerated]
	private void AC8D589E()
	{
		AB8B4F05.Text = "KEY CHƯA ĐƯỢC ĐĂNG KÝ !";
	}

	[CompilerGenerated]
	private void method_3()
	{
		AB8B4F05.Text = "CAN_NOT_CHECK_LICENSE. ERROR";
	}
}
