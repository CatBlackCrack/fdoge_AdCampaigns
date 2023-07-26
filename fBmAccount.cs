using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;

public class fBmAccount : Form
{
	[CompilerGenerated]
	private sealed class F20C1727
	{
		public fBmAccount fBmAccount_0;

		public B3810F27 BD2F40B3;

		internal void method_0()
		{
			if (!fBmAccount_0.CA290A3D.CancellationPending)
			{
				BD2F40B3.DE9E6ABD = "Bắt đầu chạy...";
				BD2F40B3.Int32_1 = 2;
				fBmAccount_0.CA290A3D.ReportProgress(BD2F40B3.Int32_0, BD2F40B3);
				try
				{
					fBmAccount_0.C12CC228(BD2F40B3);
				}
				catch (Exception ex)
				{
					BD2F40B3.EA2AD615 = ex.Message;
					BD2F40B3.Int32_1 = -1;
					fBmAccount_0.CA290A3D.ReportProgress(BD2F40B3.Int32_0, BD2F40B3);
				}
			}
			fBmAccount_0.int_0--;
		}
	}

	[CompilerGenerated]
	private sealed class B61A9F26 : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder ABABAA35;

		public B3810F27 b3810F27_0;

		public fBmAccount F71A5D2E;

		private F20C1727 f20C1727_0;

		private TaskAwaiter taskAwaiter_0;

		private void BC2E629B()
		{
			int num = int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					f20C1727_0 = new F20C1727();
					f20C1727_0.fBmAccount_0 = F71A5D2E;
					f20C1727_0.BD2F40B3 = b3810F27_0;
					awaiter = Task.Run(delegate
					{
						if (!f20C1727_0.fBmAccount_0.CA290A3D.CancellationPending)
						{
							f20C1727_0.BD2F40B3.DE9E6ABD = "Bắt đầu chạy...";
							f20C1727_0.BD2F40B3.Int32_1 = 2;
							f20C1727_0.fBmAccount_0.CA290A3D.ReportProgress(f20C1727_0.BD2F40B3.Int32_0, f20C1727_0.BD2F40B3);
							try
							{
								f20C1727_0.fBmAccount_0.C12CC228(f20C1727_0.BD2F40B3);
							}
							catch (Exception ex)
							{
								f20C1727_0.BD2F40B3.EA2AD615 = ex.Message;
								f20C1727_0.BD2F40B3.Int32_1 = -1;
								f20C1727_0.fBmAccount_0.CA290A3D.ReportProgress(f20C1727_0.BD2F40B3.Int32_0, f20C1727_0.BD2F40B3);
							}
						}
						f20C1727_0.fBmAccount_0.int_0 = f20C1727_0.fBmAccount_0.int_0 - 1;
					}).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						taskAwaiter_0 = awaiter;
						B61A9F26 stateMachine = this;
						ABABAA35.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
				}
				else
				{
					awaiter = taskAwaiter_0;
					taskAwaiter_0 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				int_0 = -2;
				f20C1727_0 = null;
				ABABAA35.SetException(exception);
				return;
			}
			int_0 = -2;
			f20C1727_0 = null;
			ABABAA35.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in BC2E629B
			this.BC2E629B();
		}

		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class F312920B
	{
		public static readonly F312920B _003C_003E9 = new F312920B();

		public static Comparison<FileInfo> _003C_003E9__22_1;

		internal int method_0(FileInfo BD85AA3D, FileInfo E6245DAF)
		{
			return StringComparer.OrdinalIgnoreCase.Compare(BD85AA3D.CreationTime, E6245DAF.CreationTime);
		}
	}

	[CompilerGenerated]
	private sealed class Class4
	{
		public B3810F27 b3810F27_0;

		public fBmAccount fBmAccount_0;

		internal void method_0()
		{
			int num = fBmAccount_0.dataGridViewBmAccount.Rows.Add();
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[0].Value = (num + 1).ToString();
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[2].Value = b3810F27_0.String_0;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[3].Value = b3810F27_0.String_1;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[4].Value = b3810F27_0.DE9E6ABD;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[5].Value = b3810F27_0.EA2AD615;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[6].Value = b3810F27_0.A1871E97;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[7].Value = b3810F27_0.String_2;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[8].Value = b3810F27_0.String_3;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[9].Value = b3810F27_0.String_4;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[10].Value = b3810F27_0.String_5;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[11].Value = b3810F27_0.String_6;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[12].Value = b3810F27_0.F336300F;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[13].Value = b3810F27_0.B182F912;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[14].Value = b3810F27_0.String_7;
		}
	}

	[CompilerGenerated]
	private sealed class A319300A
	{
		public B3810F27 E3AA6D12;

		public fBmAccount fBmAccount_0;

		internal void method_0()
		{
			int num = fBmAccount_0.dataGridViewBmAccount.Rows.Add();
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[0].Value = (num + 1).ToString();
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[2].Value = E3AA6D12.String_0;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[3].Value = E3AA6D12.String_1;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[4].Value = E3AA6D12.DE9E6ABD;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[5].Value = E3AA6D12.EA2AD615;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[6].Value = E3AA6D12.A1871E97;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[7].Value = E3AA6D12.String_2;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[8].Value = E3AA6D12.String_3;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[9].Value = E3AA6D12.String_4;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[10].Value = E3AA6D12.String_5;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[11].Value = E3AA6D12.String_6;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[12].Value = E3AA6D12.F336300F;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[13].Value = E3AA6D12.B182F912;
			fBmAccount_0.dataGridViewBmAccount.Rows[num].Cells[14].Value = E3AA6D12.String_7;
		}
	}

	public static HttpRequest FEAF0BB6 = new HttpRequest();

	private volatile Queue<string> queue_0 = new Queue<string>();

	private BackgroundWorker CA290A3D = new BackgroundWorker();

	private Random AB38E83A = new Random();

	private volatile int int_0;

	private string string_0;

	private string string_1;

	private volatile List<B3810F27> list_0 = new List<B3810F27>();

	private static object object_0 = new object();

	private int ED08F3B5 = 0;

	private IContainer C0064D38 = null;

	private Label labelStatus;

	private ToolStripMenuItem E12E7821;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem BF2FB40A;

	private ToolStripMenuItem AF8AED06;

	private ToolStripMenuItem F2ADDB9A;

	private ToolStripMenuItem DBB5F2BF;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem3;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem AEB62892;

	private ToolStripMenuItem E82F49BA;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem toolStripMenuItem_5;

	private NumericUpDown numericUpDownDelay;

	private NumericUpDown numericUpDownThread;

	private DataGridView dataGridViewBmAccount;

	private Panel D18663B0;

	private Label AC2F5196;

	private Label E0836392;

	private Button buttonStop;

	private Button buttonStart;

	private DataGridViewTextBoxColumn index;

	private DataGridViewCheckBoxColumn F304CA3F;

	private DataGridViewTextBoxColumn F00BCEA8;

	private DataGridViewTextBoxColumn Bm_ID;

	private DataGridViewTextBoxColumn B123BBB4;

	private DataGridViewTextBoxColumn Status;

	private DataGridViewTextBoxColumn Type;

	private DataGridViewTextBoxColumn Role;

	private new DataGridViewTextBoxColumn Created;

	private DataGridViewTextBoxColumn Limit;

	private DataGridViewTextBoxColumn Admin;

	private DataGridViewTextBoxColumn B9042C9F;

	private DataGridViewTextBoxColumn Admin_Hide;

	private DataGridViewTextBoxColumn AB825736;

	private DataGridViewTextBoxColumn Page;

	private DataGridViewTextBoxColumn errorCodeStatus;

	public fBmAccount()
	{
		InitializeComponent();
		Class1.String_3 = "https://mbasic.facebook.com/login/";
		Class1.D22BF503 = "https://mbasic.facebook.com/login/checkpoint/?ref=dbl";
		Class1.String_2 = "https://mbasic.facebook.com/login/checkpoint/";
		Class1.String_1 = "https://m.facebook.com/composer/ocelot/async_loader/?publisher=feed";
		dataGridViewBmAccount.CurrentCellDirtyStateChanged += CDB96121;
		dataGridViewBmAccount.SizeChanged += B2370E85;
		dataGridViewBmAccount.MouseDown += dataGridViewBmAccount_MouseDown;
		dataGridViewBmAccount.CellValueChanged += dataGridViewBmAccount_CellValueChanged;
		dataGridViewBmAccount.Sorted += D231DFB9;
		CA290A3D.DoWork += CA290A3D_DoWork;
		CA290A3D.ProgressChanged += CA290A3D_ProgressChanged;
		CA290A3D.RunWorkerCompleted += CA290A3D_RunWorkerCompleted;
		CA290A3D.WorkerReportsProgress = true;
		CA290A3D.WorkerSupportsCancellation = true;
		buttonStart.Enabled = true;
		buttonStop.Enabled = true;
		method_1();
	}

	private void D231DFB9(object sender, EventArgs e)
	{
	}

	private void dataGridViewBmAccount_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void dataGridViewBmAccount_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Right)
		{
			contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
		}
	}

	private void CDB96121(object sender, EventArgs e)
	{
		if (dataGridViewBmAccount.IsCurrentCellDirty)
		{
			dataGridViewBmAccount.CommitEdit(DataGridViewDataErrorContexts.Commit);
		}
		dataGridViewBmAccount.CommitEdit(DataGridViewDataErrorContexts.Commit);
	}

	private void B2370E85(object sender, EventArgs e)
	{
	}

	private void BDA0AE04(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void CA290A3D_DoWork(object sender, DoWorkEventArgs e)
	{
		//Discarded unreachable code: IL_009f, IL_00a9, IL_00b5, IL_00cd, IL_00d2, IL_00e1, IL_00f9, IL_010c, IL_0113, IL_012c, IL_012d, IL_0132, IL_0163, IL_017b, IL_01b6, IL_01c8, IL_01d6, IL_01e4, IL_01f2, IL_0200, IL_020e, IL_020f, IL_0211, IL_0224, IL_0232, IL_0252, IL_0257, IL_0262, IL_0285, IL_02a1, IL_02d1, IL_0310, IL_0340, IL_0378, IL_04f6, IL_0502, IL_0507, IL_0523, IL_0538, IL_0542, IL_0552, IL_0562, IL_057d, IL_058a, IL_059f, IL_05a5, IL_05bb, IL_05bd, IL_05c7, IL_05d4
		//IL_0125: Invalid comparison between Unknown and I4
		try
		{
			if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Log Data Bm"))
			{
				Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Log Data Bm");
			}
			if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\output"))
			{
				Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\output Bm");
			}
			if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\config"))
			{
				Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\config");
			}
		}
		catch
		{
		}
		int_0 = 0;
		/*Error near IL_009a: Invalid metadata token*/;
	}

	private void CA290A3D_ProgressChanged(object sender, ProgressChangedEventArgs e)
	{
		try
		{
			B3810F27 b3810F = (B3810F27)e.UserState;
			if (b3810F == null || b3810F.DE9E6ABD == null)
			{
				return;
			}
			int num = -1;
			for (int i = 0; i < dataGridViewBmAccount.Rows.Count; i++)
			{
				if (dataGridViewBmAccount.Rows[i].Cells["index"].Value.ToString().Equals((b3810F.Int32_0 + 1).ToString()))
				{
					num = i;
					break;
				}
			}
			dataGridViewBmAccount.Rows[num].Cells[3].Value = b3810F.String_1;
			dataGridViewBmAccount.Rows[num].Cells[2].Value = b3810F.String_0;
			dataGridViewBmAccount.Rows[num].Cells[6].Value = b3810F.A1871E97;
			dataGridViewBmAccount.Rows[num].Cells[12].Value = b3810F.F336300F;
			dataGridViewBmAccount.Rows[num].Cells[4].Value = b3810F.DE9E6ABD;
			try
			{
				if (b3810F.Int32_1 == 2)
				{
					dataGridViewBmAccount.Rows[num].Cells[4].Style.ForeColor = Color.DarkViolet;
				}
				if (b3810F.Int32_1 == 1)
				{
					dataGridViewBmAccount.Rows[num].Cells[4].Style.ForeColor = Color.Green;
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
	}

	private void CA290A3D_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		buttonStart.Enabled = true;
		buttonStop.Enabled = false;
		numericUpDownThread.Enabled = true;
		buttonStart.Text = "Bắt đầu";
		method_2();
		try
		{
			for (int i = 0; i < dataGridViewBmAccount.Columns.Count; i++)
			{
				dataGridViewBmAccount.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
			}
		}
		catch
		{
		}
		MessageBox.Show("Hoàn thành !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	[AsyncStateMachine(typeof(B61A9F26))]
	[DebuggerStepThrough]
	private Task method_0(B3810F27 E38FDB18)
	{
		B61A9F26 stateMachine = new B61A9F26();
		stateMachine.ABABAA35 = AsyncTaskMethodBuilder.Create();
		stateMachine.F71A5D2E = this;
		stateMachine.b3810F27_0 = E38FDB18;
		stateMachine.int_0 = -1;
		stateMachine.ABABAA35.Start(ref stateMachine);
		return stateMachine.ABABAA35.Task;
	}

	private void C12CC228(B3810F27 b3810F27_0)
	{
		//Discarded unreachable code: IL_000c, IL_000e, IL_0013, IL_0015, IL_0016, IL_001b, IL_0044, IL_004b, IL_0057, IL_0070, IL_0075, IL_0081, IL_00a2, IL_00a7, IL_00b3, IL_00bd, IL_00fb, IL_010b, IL_0114, IL_0130, IL_0142, IL_0162, IL_016d, IL_0172, IL_01a9, IL_01b5, IL_020a, IL_020f, IL_0222, IL_022f, IL_0233, IL_023d, IL_0248, IL_0252, IL_025d, IL_0268, IL_026a, IL_026f, IL_0271, IL_0272, IL_0277, IL_0309, IL_0314, IL_0316, IL_031b, IL_031d, IL_031e, IL_0323, IL_0347, IL_0351, IL_0368, IL_03bb, IL_03bd, IL_03cc, IL_03cd, IL_03d2, IL_0400, IL_0428, IL_043a, IL_046e, IL_0491, IL_04a6, IL_04b9, IL_04bf, IL_04ca, IL_04e2, IL_04f0, IL_0527, IL_0533, IL_0535, IL_053a, IL_053c, IL_053d, IL_0542, IL_0576, IL_057b, IL_0582, IL_058c, IL_0595, IL_059f, IL_05a6, IL_05cc, IL_05d8, IL_05da, IL_05df, IL_05e1, IL_05e2, IL_05e4, IL_0612, IL_0625, IL_062e, IL_0635, IL_065b
		//IL_0015: Incompatible stack heights: 0 vs 1
		//IL_0271: Incompatible stack heights: 0 vs 1
		//IL_031d: Incompatible stack heights: 0 vs 1
		//IL_053c: Incompatible stack heights: 0 vs 1
		//IL_05e1: Incompatible stack heights: 0 vs 1
		try
		{
			string text = "";
			/*Error near IL_0007: Invalid metadata token*/;
		}
		catch (Exception ex)
		{
			b3810F27_0.DE9E6ABD = ex.Message;
			b3810F27_0.Int32_1 = -1;
			CA290A3D.ReportProgress(b3810F27_0.Int32_0, b3810F27_0);
		}
		finally
		{
		}
	}

	private void method_1()
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				FileInfo[] files = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\Log Data Bm").GetFiles("*.txt");
				Array.Sort(files, (FileInfo BD85AA3D, FileInfo E6245DAF) => StringComparer.OrdinalIgnoreCase.Compare(BD85AA3D.CreationTime, E6245DAF.CreationTime));
				string[] array = File.ReadAllText(files[files.Length - 1].FullName).Trim().Split('\n');
				for (int i = 0; i < array.Length; i++)
				{
					try
					{
						dataGridViewBmAccount.Rows.Add();
						dataGridViewBmAccount.Rows[i].Cells[0].Value = array[i].Split(new string[1] { "<=><=>" }, StringSplitOptions.None)[0].Trim();
						if (array[i].Split(new string[1] { "<=><=>" }, StringSplitOptions.None)[1].Trim().Equals("True"))
						{
							dataGridViewBmAccount.Rows[i].Cells[1].Value = true;
						}
						for (int j = 2; j < dataGridViewBmAccount.Columns.Count; j++)
						{
							try
							{
								dataGridViewBmAccount.Rows[i].Cells[j].Value = array[i].Split(new string[1] { "<=><=>" }, StringSplitOptions.None)[j].Trim();
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
			}
			catch (Exception)
			{
			}
		});
		thread.IsBackground = true;
		thread.Start();
	}

	private void buttonStart_Click(object sender, EventArgs e)
	{
		try
		{
			for (int i = 0; i < dataGridViewBmAccount.Columns.Count; i++)
			{
				dataGridViewBmAccount.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}
		catch
		{
		}
		buttonStart.Enabled = false;
		buttonStop.Enabled = true;
		numericUpDownThread.Enabled = false;
		CA290A3D.RunWorkerAsync();
	}

	private void BF2FB40A_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0026, IL_002b, IL_003a, IL_004f, IL_006e
		/*Error: Invalid metadata token*/;
	}

	public static string smethod_0(string string_2)
	{
		byte[] bytes = Convert.FromBase64String(string_2);
		return Encoding.UTF8.GetString(bytes);
	}

	private void method_2()
	{
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Log Data Bm"))
				{
					Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Log Data Bm");
				}
				dataGridViewBmAccount.Invoke((MethodInvoker)delegate
				{
					List<string> list = new List<string>();
					for (int i = 0; i < dataGridViewBmAccount.Rows.Count; i++)
					{
						List<string> list2 = new List<string>
						{
							dataGridViewBmAccount.Rows[i].Cells[0].Value.ToString(),
							dataGridViewBmAccount.Rows[i].Cells[1].FormattedValue.ToString()
						};
						for (int j = 2; j < dataGridViewBmAccount.Columns.Count; j++)
						{
							try
							{
								list2.Add(dataGridViewBmAccount.Rows[i].Cells[j].Value.ToString());
							}
							catch
							{
								list2.Add("");
							}
						}
						list.Add(string.Join("<=><=>", list2));
					}
					Class7.smethod_2(Directory.GetCurrentDirectory() + "\\Log Data Bm\\" + $"Log_{DateTime.Now.Month}thang_{DateTime.Now.Day}ngay_{DateTime.Now.Hour}gio_{DateTime.Now.Minute}phut_{DateTime.Now.Second}giay.txt", string.Join("\n", list));
				});
			});
			thread.IsBackground = true;
			thread.Start();
		}
		catch
		{
		}
	}

	private void D1991F3F(object sender, EventArgs e)
	{
		if (CA290A3D.IsBusy)
		{
			buttonStart.Text = "Đang dừng...";
			CA290A3D.CancelAsync();
			CA290A3D.Dispose();
		}
	}

	private void C9A11C87(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0026, IL_002b, IL_003a, IL_004f, IL_0064, IL_0083
		/*Error: Invalid metadata token*/;
	}

	private void DBB5F2BF_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < dataGridViewBmAccount.Rows.Count; i++)
		{
			dataGridViewBmAccount.Rows[i].Cells["Tick"].Value = true;
		}
		method_2();
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < dataGridViewBmAccount.Rows.Count; i++)
		{
			dataGridViewBmAccount.Rows[i].Cells["Tick"].Value = false;
		}
		method_2();
	}

	private void BF3276A8(object sender, EventArgs e)
	{
		for (int i = 0; i < dataGridViewBmAccount.Rows.Count; i++)
		{
			if (dataGridViewBmAccount.Rows[i].Cells[2].Selected)
			{
				dataGridViewBmAccount.Rows[i].Cells[1].Value = true;
			}
			else if ((bool)dataGridViewBmAccount.Rows[i].Cells[1].FormattedValue)
			{
				dataGridViewBmAccount.Rows[i].Cells[1].Value = false;
			}
		}
		method_2();
	}

	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		new A4B3049A().ShowDialog();
		if (A4B3049A.string_0 == null)
		{
			return;
		}
		for (int i = 0; i < dataGridViewBmAccount.Rows.Count; i++)
		{
			if (dataGridViewBmAccount.Rows[i].Cells["Progress"].Value != null && dataGridViewBmAccount.Rows[i].Cells["Progress"].Value.ToString().Contains(A4B3049A.string_0))
			{
				dataGridViewBmAccount.Rows[i].Cells[1].Value = true;
			}
			else if ((bool)dataGridViewBmAccount.Rows[i].Cells[1].FormattedValue)
			{
				dataGridViewBmAccount.Rows[i].Cells[1].Value = false;
			}
		}
		method_2();
	}

	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Xóa dòng bôi đen?", "QA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
		{
			return;
		}
		try
		{
			List<int> list = new List<int>();
			for (int num = dataGridViewBmAccount.Rows.Count - 1; num >= 0; num--)
			{
				if (dataGridViewBmAccount.Rows[num].Cells[2].Selected)
				{
					list.Add(num);
				}
			}
			for (int num2 = dataGridViewBmAccount.Rows.Count - 1; num2 >= 0; num2--)
			{
				if (list.Contains(num2))
				{
					dataGridViewBmAccount.Rows.Remove(dataGridViewBmAccount.Rows[num2]);
				}
			}
			method_2();
		}
		catch
		{
		}
	}

	private void AEB62892_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Xóa dòng đã chọn?", "QA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
		{
			return;
		}
		for (int num = dataGridViewBmAccount.Rows.Count - 1; num >= 0; num--)
		{
			if ((bool)dataGridViewBmAccount.Rows[num].Cells[1].FormattedValue)
			{
				dataGridViewBmAccount.Rows.Remove(dataGridViewBmAccount.Rows[num]);
			}
		}
		method_2();
	}

	private void E82F49BA_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Xóa dòng không chọn?", "QA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
		{
			return;
		}
		for (int num = dataGridViewBmAccount.Rows.Count - 1; num >= 0; num--)
		{
			if (!(bool)dataGridViewBmAccount.Rows[num].Cells[1].FormattedValue)
			{
				dataGridViewBmAccount.Rows.Remove(dataGridViewBmAccount.Rows[num]);
			}
		}
		method_2();
	}

	private void CB0C06AB(object sender, EventArgs e)
	{
		if (MessageBox.Show("Chắc chắn xóa toàn bộ dòng?", "QA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		{
			dataGridViewBmAccount.Rows.Clear();
		}
	}

	private void toolStripMenuItem_5_Click(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < dataGridViewBmAccount.Rows.Count; i++)
		{
			List<string> list2 = new List<string>();
			for (int j = 2; j < dataGridViewBmAccount.ColumnCount; j++)
			{
				if (dataGridViewBmAccount.Rows[i].Cells[j].Selected)
				{
					try
					{
						list2.Add(dataGridViewBmAccount.Rows[i].Cells[j].Value.ToString());
					}
					catch
					{
						list2.Add("");
					}
				}
			}
			if (list2.Count != 0)
			{
				list.Add(string.Join("|", list2));
			}
		}
		if (list.Count == 0)
		{
			MessageBox.Show("Không có dữ liệu hợp lệ !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			return;
		}
		Clipboard.SetText(string.Join("\n", list));
		MessageBox.Show("Đã copy thành công !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	protected override void Dispose(bool A7272B8F)
	{
		if (A7272B8F && C0064D38 != null)
		{
			C0064D38.Dispose();
		}
		base.Dispose(A7272B8F);
	}

	private void InitializeComponent()
	{
		this.C0064D38 = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fBmAccount));
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
		System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
		this.labelStatus = new System.Windows.Forms.Label();
		this.E12E7821 = new System.Windows.Forms.ToolStripMenuItem();
		this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.C0064D38);
		this.BF2FB40A = new System.Windows.Forms.ToolStripMenuItem();
		this.AF8AED06 = new System.Windows.Forms.ToolStripMenuItem();
		this.F2ADDB9A = new System.Windows.Forms.ToolStripMenuItem();
		this.DBB5F2BF = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_0 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_1 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_3 = new System.Windows.Forms.ToolStripMenuItem();
		this.AEB62892 = new System.Windows.Forms.ToolStripMenuItem();
		this.E82F49BA = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_4 = new System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_5 = new System.Windows.Forms.ToolStripMenuItem();
		this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
		this.numericUpDownThread = new System.Windows.Forms.NumericUpDown();
		this.dataGridViewBmAccount = new System.Windows.Forms.DataGridView();
		this.D18663B0 = new System.Windows.Forms.Panel();
		this.AC2F5196 = new System.Windows.Forms.Label();
		this.E0836392 = new System.Windows.Forms.Label();
		this.buttonStop = new System.Windows.Forms.Button();
		this.buttonStart = new System.Windows.Forms.Button();
		this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.F304CA3F = new System.Windows.Forms.DataGridViewCheckBoxColumn();
		this.F00BCEA8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Bm_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.B123BBB4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Limit = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Admin = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.B9042C9F = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Admin_Hide = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.AB825736 = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.Page = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.errorCodeStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
		this.contextMenuStrip1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownDelay).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownThread).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.dataGridViewBmAccount).BeginInit();
		this.D18663B0.SuspendLayout();
		base.SuspendLayout();
		this.labelStatus.AutoSize = true;
		this.labelStatus.Location = new System.Drawing.Point(366, 56);
		this.labelStatus.Name = "labelStatus";
		this.labelStatus.Size = new System.Drawing.Size(19, 14);
		this.labelStatus.TabIndex = 52;
		this.labelStatus.Text = "---";
		this.E12E7821.Name = "toolStripMenuItem4";
		this.E12E7821.Size = new System.Drawing.Size(258, 22);
		this.E12E7821.Text = "----------------------------------------------";
		this.contextMenuStrip1.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[14]
		{
			this.BF2FB40A, this.AF8AED06, this.F2ADDB9A, this.DBB5F2BF, this.toolStripMenuItem_0, this.toolStripMenuItem_1, this.toolStripMenuItem_2, this.toolStripMenuItem3, this.toolStripMenuItem_3, this.AEB62892,
			this.E82F49BA, this.toolStripMenuItem_4, this.E12E7821, this.toolStripMenuItem_5
		});
		this.contextMenuStrip1.Name = "contextMenuStrip1";
		this.contextMenuStrip1.Size = new System.Drawing.Size(259, 334);
		this.BF2FB40A.Image = (System.Drawing.Image)resources.GetObject("ImportAccountToolStripMenuItem.Image");
		this.BF2FB40A.Name = "ImportAccountToolStripMenuItem";
		this.BF2FB40A.Size = new System.Drawing.Size(258, 22);
		this.BF2FB40A.Text = "Load tài khoản bm [tất cả]";
		this.BF2FB40A.Click += new System.EventHandler(BF2FB40A_Click);
		this.AF8AED06.Image = (System.Drawing.Image)resources.GetObject("toolStripMenuItem6.Image");
		this.AF8AED06.Name = "toolStripMenuItem6";
		this.AF8AED06.Size = new System.Drawing.Size(258, 22);
		this.AF8AED06.Text = "Load tài khoản bm [theo bm id]";
		this.AF8AED06.Click += new System.EventHandler(C9A11C87);
		this.F2ADDB9A.Name = "toolStripMenuItem2";
		this.F2ADDB9A.Size = new System.Drawing.Size(258, 22);
		this.F2ADDB9A.Text = "----------------------------------------------";
		this.DBB5F2BF.Image = (System.Drawing.Image)resources.GetObject("chọnTấtCảToolStripMenuItem.Image");
		this.DBB5F2BF.Name = "chọnTấtCảToolStripMenuItem";
		this.DBB5F2BF.Size = new System.Drawing.Size(258, 22);
		this.DBB5F2BF.Text = "Chọn tất cả";
		this.DBB5F2BF.Click += new System.EventHandler(DBB5F2BF_Click);
		this.toolStripMenuItem_0.Image = (System.Drawing.Image)resources.GetObject("bỏChọnTấtCảToolStripMenuItem.Image");
		this.toolStripMenuItem_0.Name = "bỏChọnTấtCảToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new System.Drawing.Size(258, 22);
		this.toolStripMenuItem_0.Text = "Bỏ chọn tất cả";
		this.toolStripMenuItem_0.Click += new System.EventHandler(toolStripMenuItem_0_Click);
		this.toolStripMenuItem_1.Image = (System.Drawing.Image)resources.GetObject("chọnDòngBôiĐenToolStripMenuItem.Image");
		this.toolStripMenuItem_1.Name = "chọnDòngBôiĐenToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new System.Drawing.Size(258, 22);
		this.toolStripMenuItem_1.Text = "Chọn dòng bôi đen";
		this.toolStripMenuItem_1.Click += new System.EventHandler(BF3276A8);
		this.toolStripMenuItem_2.Image = (System.Drawing.Image)resources.GetObject("chọnDòngTheoStatusToolStripMenuItem.Image");
		this.toolStripMenuItem_2.Name = "chọnDòngTheoStatusToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new System.Drawing.Size(258, 22);
		this.toolStripMenuItem_2.Text = "Chọn dòng theo status";
		this.toolStripMenuItem_2.Click += new System.EventHandler(toolStripMenuItem_2_Click);
		this.toolStripMenuItem3.Name = "toolStripMenuItem3";
		this.toolStripMenuItem3.Size = new System.Drawing.Size(258, 22);
		this.toolStripMenuItem3.Text = "----------------------------------------------";
		this.toolStripMenuItem_3.Image = (System.Drawing.Image)resources.GetObject("xóaDòngBôiĐenToolStripMenuItem.Image");
		this.toolStripMenuItem_3.Name = "xóaDòngBôiĐenToolStripMenuItem";
		this.toolStripMenuItem_3.Size = new System.Drawing.Size(258, 22);
		this.toolStripMenuItem_3.Text = "Xóa dòng bôi đen";
		this.toolStripMenuItem_3.Click += new System.EventHandler(toolStripMenuItem_3_Click);
		this.AEB62892.Image = (System.Drawing.Image)resources.GetObject("xóaDòngĐãChọnToolStripMenuItem.Image");
		this.AEB62892.Name = "xóaDòngĐãChọnToolStripMenuItem";
		this.AEB62892.Size = new System.Drawing.Size(258, 22);
		this.AEB62892.Text = "Xóa dòng đã chọn";
		this.AEB62892.Click += new System.EventHandler(AEB62892_Click);
		this.E82F49BA.Image = (System.Drawing.Image)resources.GetObject("xóaDòngKhôngChọnToolStripMenuItem.Image");
		this.E82F49BA.Name = "xóaDòngKhôngChọnToolStripMenuItem";
		this.E82F49BA.Size = new System.Drawing.Size(258, 22);
		this.E82F49BA.Text = "Xóa dòng không chọn";
		this.E82F49BA.Click += new System.EventHandler(E82F49BA_Click);
		this.toolStripMenuItem_4.Image = (System.Drawing.Image)resources.GetObject("xóaToànBộDòngToolStripMenuItem.Image");
		this.toolStripMenuItem_4.Name = "xóaToànBộDòngToolStripMenuItem";
		this.toolStripMenuItem_4.Size = new System.Drawing.Size(258, 22);
		this.toolStripMenuItem_4.Text = "Xóa toàn bộ dòng";
		this.toolStripMenuItem_4.Click += new System.EventHandler(CB0C06AB);
		this.toolStripMenuItem_5.Image = (System.Drawing.Image)resources.GetObject("xuấtTàiKhoảnĐãChọnToolStripMenuItem.Image");
		this.toolStripMenuItem_5.Name = "xuấtTàiKhoảnĐãChọnToolStripMenuItem";
		this.toolStripMenuItem_5.Size = new System.Drawing.Size(258, 22);
		this.toolStripMenuItem_5.Text = "Copy tài khoản bôi đen";
		this.toolStripMenuItem_5.Click += new System.EventHandler(toolStripMenuItem_5_Click);
		this.numericUpDownDelay.Location = new System.Drawing.Point(251, 15);
		this.numericUpDownDelay.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		this.numericUpDownDelay.Name = "numericUpDownDelay";
		this.numericUpDownDelay.Size = new System.Drawing.Size(75, 22);
		this.numericUpDownDelay.TabIndex = 51;
		this.numericUpDownThread.Location = new System.Drawing.Point(80, 15);
		this.numericUpDownThread.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		this.numericUpDownThread.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.numericUpDownThread.Name = "numericUpDownThread";
		this.numericUpDownThread.Size = new System.Drawing.Size(90, 22);
		this.numericUpDownThread.TabIndex = 50;
		this.numericUpDownThread.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.dataGridViewBmAccount.AllowUserToAddRows = false;
		this.dataGridViewBmAccount.AllowUserToResizeRows = false;
		this.dataGridViewBmAccount.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
		this.dataGridViewBmAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
		dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
		dataGridViewCellStyle.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = System.Drawing.Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
		this.dataGridViewBmAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		this.dataGridViewBmAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dataGridViewBmAccount.Columns.AddRange(this.index, this.F304CA3F, this.F00BCEA8, this.Bm_ID, this.B123BBB4, this.Status, this.Type, this.Role, this.Created, this.Limit, this.Admin, this.B9042C9F, this.Admin_Hide, this.AB825736, this.Page, this.errorCodeStatus);
		this.dataGridViewBmAccount.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dataGridViewBmAccount.Location = new System.Drawing.Point(0, 90);
		this.dataGridViewBmAccount.Name = "dataGridViewBmAccount";
		this.dataGridViewBmAccount.RowHeadersVisible = false;
		this.dataGridViewBmAccount.Size = new System.Drawing.Size(1135, 484);
		this.dataGridViewBmAccount.TabIndex = 89;
		this.D18663B0.Controls.Add(this.labelStatus);
		this.D18663B0.Controls.Add(this.numericUpDownDelay);
		this.D18663B0.Controls.Add(this.numericUpDownThread);
		this.D18663B0.Controls.Add(this.AC2F5196);
		this.D18663B0.Controls.Add(this.E0836392);
		this.D18663B0.Controls.Add(this.buttonStop);
		this.D18663B0.Controls.Add(this.buttonStart);
		this.D18663B0.Dock = System.Windows.Forms.DockStyle.Top;
		this.D18663B0.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.D18663B0.Location = new System.Drawing.Point(0, 0);
		this.D18663B0.Name = "panel1";
		this.D18663B0.Size = new System.Drawing.Size(1135, 90);
		this.D18663B0.TabIndex = 88;
		this.AC2F5196.AutoSize = true;
		this.AC2F5196.Location = new System.Drawing.Point(173, 19);
		this.AC2F5196.Name = "label2";
		this.AC2F5196.Size = new System.Drawing.Size(65, 14);
		this.AC2F5196.TabIndex = 49;
		this.AC2F5196.Text = "Delay(ms):";
		this.E0836392.AutoSize = true;
		this.E0836392.Location = new System.Drawing.Point(19, 19);
		this.E0836392.Name = "label1";
		this.E0836392.Size = new System.Drawing.Size(50, 14);
		this.E0836392.TabIndex = 48;
		this.E0836392.Text = "Thread:";
		this.buttonStop.BackColor = System.Drawing.Color.Red;
		this.buttonStop.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonStop.Enabled = false;
		this.buttonStop.FlatAppearance.BorderSize = 0;
		this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonStop.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.buttonStop.ForeColor = System.Drawing.Color.White;
		this.buttonStop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.buttonStop.Location = new System.Drawing.Point(177, 47);
		this.buttonStop.Name = "buttonStop";
		this.buttonStop.Size = new System.Drawing.Size(148, 31);
		this.buttonStop.TabIndex = 47;
		this.buttonStop.Text = "Stop";
		this.buttonStop.UseVisualStyleBackColor = false;
		this.buttonStop.Click += new System.EventHandler(D1991F3F);
		this.buttonStart.BackColor = System.Drawing.Color.Green;
		this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonStart.Enabled = false;
		this.buttonStart.FlatAppearance.BorderSize = 0;
		this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonStart.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.buttonStart.ForeColor = System.Drawing.Color.White;
		this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.buttonStart.Location = new System.Drawing.Point(22, 47);
		this.buttonStart.Name = "buttonStart";
		this.buttonStart.Size = new System.Drawing.Size(148, 31);
		this.buttonStart.TabIndex = 46;
		this.buttonStart.Text = "Start";
		this.buttonStart.UseVisualStyleBackColor = false;
		this.buttonStart.Click += new System.EventHandler(buttonStart_Click);
		dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
		this.index.DefaultCellStyle = dataGridViewCellStyle2;
		this.index.HeaderText = "STT";
		this.index.Name = "index";
		this.index.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
		this.index.Width = 40;
		this.F304CA3F.HeaderText = "x";
		this.F304CA3F.Name = "Tick";
		this.F304CA3F.TrueValue = "";
		this.F304CA3F.Width = 30;
		this.F00BCEA8.HeaderText = "Bm_Name";
		this.F00BCEA8.Name = "Bm_Name";
		this.Bm_ID.HeaderText = "Bm_ID";
		this.Bm_ID.Name = "Bm_ID";
		this.B123BBB4.HeaderText = "Progress";
		this.B123BBB4.Name = "Progress";
		this.B123BBB4.Width = 150;
		this.Status.HeaderText = "Status";
		this.Status.Name = "Status";
		this.Type.HeaderText = "Type (Bm?)";
		this.Type.Name = "Type";
		this.Role.HeaderText = "Role";
		this.Role.Name = "Role";
		this.Created.HeaderText = "Created";
		this.Created.Name = "Created";
		this.Limit.HeaderText = "Limit";
		this.Limit.Name = "Limit";
		this.Admin.HeaderText = "Admin";
		this.Admin.Name = "Admin";
		this.B9042C9F.HeaderText = "AdAccount";
		this.B9042C9F.Name = "AdAccount";
		this.Admin_Hide.HeaderText = "Admin_Hide";
		this.Admin_Hide.Name = "Admin_Hide";
		this.AB825736.HeaderText = "Verified";
		this.AB825736.Name = "Verified";
		this.Page.HeaderText = "Page";
		this.Page.Name = "Page";
		this.errorCodeStatus.HeaderText = "errorCodeStatus";
		this.errorCodeStatus.Name = "errorCodeStatus";
		this.errorCodeStatus.Visible = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 14f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1135, 574);
		base.Controls.Add(this.dataGridViewBmAccount);
		base.Controls.Add(this.D18663B0);
		this.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fBmAccount";
		this.Text = "fBmAccount";
		this.contextMenuStrip1.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.numericUpDownDelay).EndInit();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownThread).EndInit();
		((System.ComponentModel.ISupportInitialize)this.dataGridViewBmAccount).EndInit();
		this.D18663B0.ResumeLayout(false);
		this.D18663B0.PerformLayout();
		base.ResumeLayout(false);
	}

	[CompilerGenerated]
	private void A7B4B882()
	{
		labelStatus.Text = "Đang xử lý, check live cookie...";
	}

	[CompilerGenerated]
	private void method_3()
	{
		labelStatus.Text = "";
	}

	[CompilerGenerated]
	private void CF1153AA()
	{
		labelStatus.Text = "Đang xử lý, khởi tạo tham số...";
	}

	[CompilerGenerated]
	private void method_4()
	{
		labelStatus.Text = "";
	}

	[CompilerGenerated]
	private void method_5()
	{
		labelStatus.Text = "";
	}

	[CompilerGenerated]
	private void method_6()
	{
		list_0.Clear();
		for (int i = 0; i < dataGridViewBmAccount.Rows.Count; i++)
		{
			B3810F27 b3810F = new B3810F27
			{
				Int32_0 = i,
				Boolean_0 = (bool)dataGridViewBmAccount.Rows[i].Cells[1].FormattedValue
			};
			dataGridViewBmAccount.Rows[i].Cells["index"].Value = (b3810F.Int32_0 + 1).ToString();
			b3810F.String_1 = ((dataGridViewBmAccount.Rows[i].Cells[3].Value != null) ? dataGridViewBmAccount.Rows[i].Cells[3].Value.ToString() : "");
			b3810F.String_0 = ((dataGridViewBmAccount.Rows[i].Cells[2].Value != null) ? dataGridViewBmAccount.Rows[i].Cells[2].Value.ToString() : "");
			b3810F.EA2AD615 = ((dataGridViewBmAccount.Rows[i].Cells[5].Value != null) ? dataGridViewBmAccount.Rows[i].Cells[5].Value.ToString() : "");
			b3810F.A1871E97 = ((dataGridViewBmAccount.Rows[i].Cells[6].Value != null) ? dataGridViewBmAccount.Rows[i].Cells[6].Value.ToString() : "");
			b3810F.String_2 = ((dataGridViewBmAccount.Rows[i].Cells[7].Value != null) ? dataGridViewBmAccount.Rows[i].Cells[7].Value.ToString() : "");
			b3810F.String_3 = ((dataGridViewBmAccount.Rows[i].Cells[8].Value != null) ? dataGridViewBmAccount.Rows[i].Cells[8].Value.ToString() : "");
			b3810F.String_4 = ((dataGridViewBmAccount.Rows[i].Cells[9].Value != null) ? dataGridViewBmAccount.Rows[i].Cells[9].Value.ToString() : "");
			b3810F.String_5 = ((dataGridViewBmAccount.Rows[i].Cells[10].Value != null) ? dataGridViewBmAccount.Rows[i].Cells[10].Value.ToString() : "");
			b3810F.String_6 = ((dataGridViewBmAccount.Rows[i].Cells[11].Value != null) ? dataGridViewBmAccount.Rows[i].Cells[11].Value.ToString() : "");
			b3810F.F336300F = ((dataGridViewBmAccount.Rows[i].Cells[12].Value != null) ? dataGridViewBmAccount.Rows[i].Cells[12].Value.ToString() : "");
			b3810F.B182F912 = ((dataGridViewBmAccount.Rows[i].Cells[13].Value != null) ? dataGridViewBmAccount.Rows[i].Cells[13].Value.ToString() : "");
			b3810F.Int32_1 = 0;
			list_0.Add(b3810F);
		}
	}

	[CompilerGenerated]
	private void E38273AC()
	{
		try
		{
			FileInfo[] files = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\Log Data Bm").GetFiles("*.txt");
			Array.Sort(files, (FileInfo BD85AA3D, FileInfo E6245DAF) => StringComparer.OrdinalIgnoreCase.Compare(BD85AA3D.CreationTime, E6245DAF.CreationTime));
			string[] array = File.ReadAllText(files[files.Length - 1].FullName).Trim().Split('\n');
			for (int i = 0; i < array.Length; i++)
			{
				try
				{
					dataGridViewBmAccount.Rows.Add();
					dataGridViewBmAccount.Rows[i].Cells[0].Value = array[i].Split(new string[1] { "<=><=>" }, StringSplitOptions.None)[0].Trim();
					if (array[i].Split(new string[1] { "<=><=>" }, StringSplitOptions.None)[1].Trim().Equals("True"))
					{
						dataGridViewBmAccount.Rows[i].Cells[1].Value = true;
					}
					for (int j = 2; j < dataGridViewBmAccount.Columns.Count; j++)
					{
						try
						{
							dataGridViewBmAccount.Rows[i].Cells[j].Value = array[i].Split(new string[1] { "<=><=>" }, StringSplitOptions.None)[j].Trim();
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
		}
		catch (Exception)
		{
		}
	}

	[CompilerGenerated]
	private void DB9D598C()
	{
		//Discarded unreachable code: IL_0018, IL_0031, IL_0032, IL_0037, IL_0066, IL_007d, IL_00b6, IL_00c7, IL_00d4, IL_00e1, IL_00ee, IL_00fb, IL_0108, IL_0109, IL_010b, IL_011d, IL_012a, IL_014a, IL_014f, IL_0158, IL_0162, IL_0175, IL_018d, IL_01b5, IL_01d6, IL_01e2, IL_01e3, IL_021f, IL_0227, IL_0258
		//IL_002a: Invalid comparison between Unknown and I4
		FEAF0BB6.Cookies = new CookieDictionary();
		int num = 0;
		/*Error near IL_0013: Invalid metadata token*/;
	}

	[CompilerGenerated]
	private void method_7()
	{
		labelStatus.Text = "Fetching bm account...";
	}

	[CompilerGenerated]
	private void method_8()
	{
		dataGridViewBmAccount.Rows.Clear();
	}

	[CompilerGenerated]
	private void F8A8888C()
	{
		labelStatus.Text = "";
	}

	[CompilerGenerated]
	private void method_9()
	{
		if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Log Data Bm"))
		{
			Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Log Data Bm");
		}
		dataGridViewBmAccount.Invoke((MethodInvoker)delegate
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dataGridViewBmAccount.Rows.Count; i++)
			{
				List<string> list2 = new List<string>
				{
					dataGridViewBmAccount.Rows[i].Cells[0].Value.ToString(),
					dataGridViewBmAccount.Rows[i].Cells[1].FormattedValue.ToString()
				};
				for (int j = 2; j < dataGridViewBmAccount.Columns.Count; j++)
				{
					try
					{
						list2.Add(dataGridViewBmAccount.Rows[i].Cells[j].Value.ToString());
					}
					catch
					{
						list2.Add("");
					}
				}
				list.Add(string.Join("<=><=>", list2));
			}
			Class7.smethod_2(Directory.GetCurrentDirectory() + "\\Log Data Bm\\" + $"Log_{DateTime.Now.Month}thang_{DateTime.Now.Day}ngay_{DateTime.Now.Hour}gio_{DateTime.Now.Minute}phut_{DateTime.Now.Second}giay.txt", string.Join("\n", list));
		});
	}

	[CompilerGenerated]
	private void method_10()
	{
		List<string> list = new List<string>();
		for (int i = 0; i < dataGridViewBmAccount.Rows.Count; i++)
		{
			List<string> list2 = new List<string>
			{
				dataGridViewBmAccount.Rows[i].Cells[0].Value.ToString(),
				dataGridViewBmAccount.Rows[i].Cells[1].FormattedValue.ToString()
			};
			for (int j = 2; j < dataGridViewBmAccount.Columns.Count; j++)
			{
				try
				{
					list2.Add(dataGridViewBmAccount.Rows[i].Cells[j].Value.ToString());
				}
				catch
				{
					list2.Add("");
				}
			}
			list.Add(string.Join("<=><=>", list2));
		}
		Class7.smethod_2(Directory.GetCurrentDirectory() + "\\Log Data Bm\\" + $"Log_{DateTime.Now.Month}thang_{DateTime.Now.Day}ngay_{DateTime.Now.Hour}gio_{DateTime.Now.Minute}phut_{DateTime.Now.Second}giay.txt", string.Join("\n", list));
	}

	[CompilerGenerated]
	private void method_11()
	{
		//Discarded unreachable code: IL_0019, IL_0032, IL_0033, IL_0038, IL_0067, IL_007e, IL_00b6, IL_00c7, IL_00d4, IL_00e1, IL_00ee, IL_00fb, IL_0108, IL_0109, IL_010b, IL_011c, IL_0129, IL_0148, IL_014d, IL_0156, IL_0160, IL_0173, IL_018b, IL_01c3, IL_0218, IL_024d, IL_0272
		//IL_002b: Invalid comparison between Unknown and I4
		try
		{
			FEAF0BB6.Cookies = new CookieDictionary();
			int num = 0;
			/*Error near IL_0014: Invalid metadata token*/;
		}
		catch
		{
		}
		labelStatus.Invoke((MethodInvoker)delegate
		{
			labelStatus.Text = "";
		});
		method_2();
		MessageBox.Show("Load xong !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	[CompilerGenerated]
	private void method_12()
	{
		labelStatus.Text = "Fetching bm account...";
	}

	[CompilerGenerated]
	private void method_13()
	{
		dataGridViewBmAccount.Rows.Clear();
	}

	[CompilerGenerated]
	private void method_14()
	{
		labelStatus.Text = "";
	}
}
