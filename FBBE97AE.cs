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

public class FBBE97AE : Form
{
	[CompilerGenerated]
	private sealed class Class5
	{
		public FBBE97AE fbbe97AE_0;

		public Class11 class11_0;

		internal void method_0()
		{
			if (!fbbe97AE_0.backgroundWorker_0.CancellationPending)
			{
				class11_0.String_9 = "Bắt đầu chạy...";
				class11_0.Int32_0 = 2;
				fbbe97AE_0.backgroundWorker_0.ReportProgress(class11_0.B4902023, class11_0);
				try
				{
					fbbe97AE_0.method_0(class11_0);
				}
				catch (Exception ex)
				{
					class11_0.String_0 = ex.Message;
					class11_0.Int32_0 = -1;
					fbbe97AE_0.backgroundWorker_0.ReportProgress(class11_0.B4902023, class11_0);
				}
			}
			fbbe97AE_0.int_0--;
		}
	}

	[CompilerGenerated]
	private sealed class A833F4BE : IAsyncStateMachine
	{
		public int int_0;

		public AsyncTaskMethodBuilder asyncTaskMethodBuilder_0;

		public Class11 CF11BC1A;

		public FBBE97AE EDB2659A;

		private Class5 D69C48AC;

		private TaskAwaiter B98CE8A8;

		void IAsyncStateMachine.MoveNext()
		{
			int num = int_0;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					D69C48AC = new Class5();
					D69C48AC.fbbe97AE_0 = EDB2659A;
					D69C48AC.class11_0 = CF11BC1A;
					awaiter = Task.Run(delegate
					{
						if (!D69C48AC.fbbe97AE_0.backgroundWorker_0.CancellationPending)
						{
							D69C48AC.class11_0.String_9 = "Bắt đầu chạy...";
							D69C48AC.class11_0.Int32_0 = 2;
							D69C48AC.fbbe97AE_0.backgroundWorker_0.ReportProgress(D69C48AC.class11_0.B4902023, D69C48AC.class11_0);
							try
							{
								D69C48AC.fbbe97AE_0.method_0(D69C48AC.class11_0);
							}
							catch (Exception ex)
							{
								D69C48AC.class11_0.String_0 = ex.Message;
								D69C48AC.class11_0.Int32_0 = -1;
								D69C48AC.fbbe97AE_0.backgroundWorker_0.ReportProgress(D69C48AC.class11_0.B4902023, D69C48AC.class11_0);
							}
						}
						D69C48AC.fbbe97AE_0.int_0 = D69C48AC.fbbe97AE_0.int_0 - 1;
					}).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = 0;
						int_0 = 0;
						B98CE8A8 = awaiter;
						A833F4BE stateMachine = this;
						asyncTaskMethodBuilder_0.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
						return;
					}
				}
				else
				{
					awaiter = B98CE8A8;
					B98CE8A8 = default(TaskAwaiter);
					num = -1;
					int_0 = -1;
				}
				awaiter.GetResult();
			}
			catch (Exception exception)
			{
				int_0 = -2;
				D69C48AC = null;
				asyncTaskMethodBuilder_0.SetException(exception);
				return;
			}
			int_0 = -2;
			D69C48AC = null;
			asyncTaskMethodBuilder_0.SetResult();
		}

		[DebuggerHidden]
		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class E83403AB
	{
		public static readonly E83403AB _003C_003E9 = new E83403AB();

		public static Comparison<FileInfo> _003C_003E9__27_1;

		internal int method_0(FileInfo F70F7684, FileInfo fileInfo_0)
		{
			return StringComparer.OrdinalIgnoreCase.Compare(F70F7684.CreationTime, fileInfo_0.CreationTime);
		}
	}

	[CompilerGenerated]
	private sealed class A0934C07
	{
		public Class11 class11_0;

		public FBBE97AE fbbe97AE_0;

		internal void C3B2162A()
		{
			int num = fbbe97AE_0.dataGridViewTable.Rows.Add();
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[0].Value = (num + 1).ToString();
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[2].Value = class11_0.String_1;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[3].Value = class11_0.String_0;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[4].Value = class11_0.String_9;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[5].Value = class11_0.C9321781;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[6].Value = class11_0.String_3;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[7].Value = class11_0.String_2;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[8].Value = class11_0.String_5;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[9].Value = class11_0.AD910B99;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[10].Value = class11_0.String_4;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[11].Value = class11_0.String_10;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[12].Value = class11_0.String_7;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[13].Value = class11_0.String_6;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[14].Value = class11_0.String_8;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[15].Value = class11_0.A717C383;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[16].Value = class11_0.String_12;
		}
	}

	[CompilerGenerated]
	private sealed class Class6
	{
		public Class11 C607D733;

		public FBBE97AE D20C8798;

		internal void B008813B()
		{
			int num = D20C8798.dataGridViewTable.Rows.Add();
			D20C8798.dataGridViewTable.Rows[num].Cells[0].Value = (num + 1).ToString();
			D20C8798.dataGridViewTable.Rows[num].Cells[2].Value = C607D733.String_1;
			D20C8798.dataGridViewTable.Rows[num].Cells[3].Value = C607D733.String_0;
			D20C8798.dataGridViewTable.Rows[num].Cells[4].Value = C607D733.String_9;
			D20C8798.dataGridViewTable.Rows[num].Cells[5].Value = C607D733.C9321781;
			D20C8798.dataGridViewTable.Rows[num].Cells[6].Value = C607D733.String_3;
			D20C8798.dataGridViewTable.Rows[num].Cells[7].Value = C607D733.String_2;
			D20C8798.dataGridViewTable.Rows[num].Cells[8].Value = C607D733.String_5;
			D20C8798.dataGridViewTable.Rows[num].Cells[9].Value = C607D733.AD910B99;
			D20C8798.dataGridViewTable.Rows[num].Cells[10].Value = C607D733.String_4;
			D20C8798.dataGridViewTable.Rows[num].Cells[11].Value = C607D733.String_10;
			D20C8798.dataGridViewTable.Rows[num].Cells[12].Value = C607D733.String_7;
			D20C8798.dataGridViewTable.Rows[num].Cells[13].Value = C607D733.String_6;
			D20C8798.dataGridViewTable.Rows[num].Cells[15].Value = C607D733.A717C383;
			D20C8798.dataGridViewTable.Rows[num].Cells[14].Value = C607D733.String_8;
			D20C8798.dataGridViewTable.Rows[num].Cells[16].Value = C607D733.String_12;
		}
	}

	[CompilerGenerated]
	private sealed class B59E7103
	{
		public Class11 class11_0;

		public FBBE97AE fbbe97AE_0;

		internal void method_0()
		{
			int num = fbbe97AE_0.dataGridViewTable.Rows.Add();
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[0].Value = (num + 1).ToString();
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[2].Value = class11_0.String_1;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[3].Value = class11_0.String_0;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[4].Value = class11_0.String_9;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[5].Value = class11_0.C9321781;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[6].Value = class11_0.String_3;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[7].Value = class11_0.String_2;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[8].Value = class11_0.String_5;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[9].Value = class11_0.AD910B99;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[10].Value = class11_0.String_4;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[11].Value = class11_0.String_10;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[12].Value = class11_0.String_7;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[13].Value = class11_0.String_6;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[15].Value = class11_0.A717C383;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[14].Value = class11_0.String_8;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[16].Value = class11_0.String_12;
		}
	}

	[CompilerGenerated]
	private sealed class C809CF20
	{
		public Class11 class11_0;

		public FBBE97AE fbbe97AE_0;

		internal void ECB4FA1D()
		{
			int num = fbbe97AE_0.dataGridViewTable.Rows.Add();
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[0].Value = (num + 1).ToString();
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[2].Value = class11_0.String_1;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[3].Value = class11_0.String_0;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[4].Value = class11_0.String_9;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[5].Value = class11_0.C9321781;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[6].Value = class11_0.String_3;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[7].Value = class11_0.String_2;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[8].Value = class11_0.String_5;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[9].Value = class11_0.AD910B99;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[10].Value = class11_0.String_4;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[11].Value = class11_0.String_10;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[12].Value = class11_0.String_7;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[13].Value = class11_0.String_6;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[15].Value = class11_0.A717C383;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[14].Value = class11_0.String_8;
			fbbe97AE_0.dataGridViewTable.Rows[num].Cells[16].Value = class11_0.String_12;
		}
	}

	[CompilerGenerated]
	private sealed class E71F26BC
	{
		public Class11 class11_0;

		public FBBE97AE EB97ED15;

		internal void method_0()
		{
			int num = EB97ED15.dataGridViewTable.Rows.Add();
			EB97ED15.dataGridViewTable.Rows[num].Cells[0].Value = (num + 1).ToString();
			EB97ED15.dataGridViewTable.Rows[num].Cells[2].Value = class11_0.String_1;
			EB97ED15.dataGridViewTable.Rows[num].Cells[3].Value = class11_0.String_0;
			EB97ED15.dataGridViewTable.Rows[num].Cells[4].Value = class11_0.String_9;
			EB97ED15.dataGridViewTable.Rows[num].Cells[5].Value = class11_0.C9321781;
			EB97ED15.dataGridViewTable.Rows[num].Cells[6].Value = class11_0.String_3;
			EB97ED15.dataGridViewTable.Rows[num].Cells[7].Value = class11_0.String_2;
			EB97ED15.dataGridViewTable.Rows[num].Cells[8].Value = class11_0.String_5;
			EB97ED15.dataGridViewTable.Rows[num].Cells[9].Value = class11_0.AD910B99;
			EB97ED15.dataGridViewTable.Rows[num].Cells[10].Value = class11_0.String_4;
			EB97ED15.dataGridViewTable.Rows[num].Cells[11].Value = class11_0.String_10;
			EB97ED15.dataGridViewTable.Rows[num].Cells[12].Value = class11_0.String_7;
			EB97ED15.dataGridViewTable.Rows[num].Cells[13].Value = class11_0.String_6;
			EB97ED15.dataGridViewTable.Rows[num].Cells[15].Value = class11_0.A717C383;
			EB97ED15.dataGridViewTable.Rows[num].Cells[14].Value = class11_0.String_8;
			EB97ED15.dataGridViewTable.Rows[num].Cells[16].Value = class11_0.String_12;
		}
	}

	private volatile Queue<string> queue_0 = new Queue<string>();

	private BackgroundWorker backgroundWorker_0 = new BackgroundWorker();

	private Random random_0 = new Random();

	private volatile Queue<string> queue_1 = new Queue<string>();

	private volatile List<Class11> B18DAC37 = new List<Class11>();

	private volatile List<string> list_0 = new List<string>();

	private volatile List<string> list_1 = new List<string>();

	private volatile int int_0 = 0;

	private static object E5177DB7 = new object();

	public static HttpRequest httpRequest_0 = new HttpRequest();

	private string string_0 = null;

	private string string_1 = null;

	private int int_1 = 0;

	private IContainer icontainer_0 = null;

	private DataGridView dataGridViewTable;

	private Panel panel1;

	private NumericUpDown D737EE2C;

	private NumericUpDown numericUpDownThread;

	private Label label2;

	private Label D20BA919;

	private Button buttonStop;

	private Button C4AC56A5;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem ImportAccountToolStripMenuItem;

	private ToolStripMenuItem ImportNewAccountToolStripMenuItem;

	private ToolStripMenuItem toolStripMenuItem2;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private ToolStripMenuItem F803673D;

	private ToolStripMenuItem toolStripMenuItem_2;

	private ToolStripMenuItem toolStripMenuItem3;

	private ToolStripMenuItem toolStripMenuItem_3;

	private ToolStripMenuItem C40ABE97;

	private ToolStripMenuItem toolStripMenuItem_4;

	private ToolStripMenuItem F409F285;

	private ToolStripMenuItem A81ECB90;

	private ToolStripMenuItem DE3D022C;

	private Label FC2E6486;

	private ToolStripMenuItem toolStripMenuItem5;

	private ToolStripMenuItem AE3CD08A;

	private ToolStripMenuItem toolStripMenuItem6;

	private DataGridViewTextBoxColumn index;

	private DataGridViewCheckBoxColumn Tick;

	private DataGridViewTextBoxColumn AdID;

	private DataGridViewTextBoxColumn Status;

	private DataGridViewTextBoxColumn A0AD2CB4;

	private DataGridViewTextBoxColumn AdName;

	private DataGridViewTextBoxColumn Currency;

	private DataGridViewTextBoxColumn Limit;

	private DataGridViewTextBoxColumn Threshold;

	private DataGridViewTextBoxColumn F3950994;

	private DataGridViewTextBoxColumn AmountSpent;

	private DataGridViewTextBoxColumn B180D3AA;

	private DataGridViewTextBoxColumn Timezone;

	private DataGridViewTextBoxColumn AdCampaign;

	private DataGridViewTextBoxColumn Type;

	private DataGridViewTextBoxColumn CreatedDate;

	private DataGridViewTextBoxColumn AE1DD0B9;

	private DataGridViewTextBoxColumn A52792B4;

	public FBBE97AE()
	{
		E82D5018();
		Class1.String_3 = "https://mbasic.facebook.com/login/";
		Class1.D22BF503 = "https://mbasic.facebook.com/login/checkpoint/?ref=dbl";
		Class1.String_2 = "https://mbasic.facebook.com/login/checkpoint/";
		Class1.String_1 = "https://m.facebook.com/composer/ocelot/async_loader/?publisher=feed";
		dataGridViewTable.CurrentCellDirtyStateChanged += dataGridViewTable_CurrentCellDirtyStateChanged;
		dataGridViewTable.SizeChanged += dataGridViewTable_SizeChanged;
		dataGridViewTable.MouseDown += dataGridViewTable_MouseDown;
		dataGridViewTable.CellValueChanged += dataGridViewTable_CellValueChanged;
		dataGridViewTable.Sorted += dataGridViewTable_Sorted;
		backgroundWorker_0.DoWork += backgroundWorker_0_DoWork;
		backgroundWorker_0.ProgressChanged += C8040108;
		backgroundWorker_0.RunWorkerCompleted += D21591B7;
		backgroundWorker_0.WorkerReportsProgress = true;
		backgroundWorker_0.WorkerSupportsCancellation = true;
		C4AC56A5.Enabled = true;
		buttonStop.Enabled = true;
		A63F0524();
	}

	private void dataGridViewTable_Sorted(object sender, EventArgs e)
	{
		FEAB52BC();
	}

	private void dataGridViewTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		FEAB52BC();
	}

	private void FEAB52BC()
	{
	}

	private void dataGridViewTable_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Right)
		{
			contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
		}
	}

	private void dataGridViewTable_CurrentCellDirtyStateChanged(object sender, EventArgs e)
	{
		if (dataGridViewTable.IsCurrentCellDirty)
		{
			dataGridViewTable.CommitEdit(DataGridViewDataErrorContexts.Commit);
		}
		dataGridViewTable.CommitEdit(DataGridViewDataErrorContexts.Commit);
	}

	private void dataGridViewTable_SizeChanged(object sender, EventArgs e)
	{
	}

	private void DB2072BA(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
		//Discarded unreachable code: IL_0011, IL_0016, IL_003b, IL_0049, IL_0053, IL_0069, IL_00aa, IL_00bf, IL_00df, IL_00e0, IL_00e2, IL_00e7, IL_0103, IL_010a, IL_010e, IL_0114, IL_011d, IL_012c, IL_0131, IL_0133, IL_0138, IL_013d, IL_013e, IL_0140, IL_0158, IL_0159, IL_01e8, IL_01f7, IL_0201, IL_020d, IL_0225, IL_022a, IL_0239, IL_0251, IL_0264, IL_026b, IL_0284, IL_0285, IL_028a, IL_02bb, IL_02d3, IL_030e, IL_0320, IL_032e, IL_033c, IL_034a, IL_0358, IL_0366, IL_0367, IL_0369, IL_037c, IL_038a, IL_03aa, IL_03af, IL_03ba, IL_03dd, IL_03f9, IL_0429, IL_0468, IL_0498, IL_04d0, IL_0591, IL_059d, IL_05a2, IL_05be, IL_05d3, IL_05dd, IL_05ed, IL_05fd, IL_0618, IL_0625, IL_063a, IL_0640, IL_0656, IL_0658, IL_0662, IL_066f
		//IL_0065: Invalid comparison between Unknown and I4
		//IL_0139: Invalid comparison between Unknown and I4
		//IL_027d: Invalid comparison between Unknown and I4
		list_1.Clear();
		int num = 0;
		/*Error near IL_004e: Invalid metadata token*/;
	}

	private void C8040108(object sender, ProgressChangedEventArgs e)
	{
		try
		{
			Class11 @class = (Class11)e.UserState;
			if (@class == null || @class.String_9 == null)
			{
				return;
			}
			int num = -1;
			for (int i = 0; i < dataGridViewTable.Rows.Count; i++)
			{
				if (dataGridViewTable.Rows[i].Cells["index"].Value.ToString().Equals((@class.B4902023 + 1).ToString()))
				{
					num = i;
					break;
				}
			}
			dataGridViewTable.Rows[num].Cells[2].Value = @class.String_1;
			dataGridViewTable.Rows[num].Cells[4].Value = @class.String_9;
			dataGridViewTable.Rows[num].Cells[5].Value = @class.C9321781;
			dataGridViewTable.Rows[num].Cells[6].Value = @class.String_3;
			dataGridViewTable.Rows[num].Cells[12].Value = @class.String_7;
			try
			{
				if (@class.Int32_0 == 2)
				{
					dataGridViewTable.Rows[num].Cells[4].Style.ForeColor = Color.DarkViolet;
				}
				if (@class.Int32_0 == 1)
				{
					dataGridViewTable.Rows[num].Cells[4].Style.ForeColor = Color.Green;
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

	private void D21591B7(object sender, RunWorkerCompletedEventArgs e)
	{
		C4AC56A5.Enabled = true;
		buttonStop.Enabled = false;
		numericUpDownThread.Enabled = true;
		C4AC56A5.Text = "Bắt đầu";
		D0095095();
		try
		{
			for (int i = 0; i < dataGridViewTable.Columns.Count; i++)
			{
				dataGridViewTable.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
			}
		}
		catch
		{
		}
		MessageBox.Show("Hoàn thành !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	private void D0095095()
	{
		try
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Log Data"))
				{
					Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Log Data");
				}
				dataGridViewTable.Invoke((MethodInvoker)delegate
				{
					List<string> list = new List<string>();
					for (int i = 0; i < dataGridViewTable.Rows.Count; i++)
					{
						List<string> list2 = new List<string>
						{
							dataGridViewTable.Rows[i].Cells[0].Value.ToString(),
							dataGridViewTable.Rows[i].Cells[1].FormattedValue.ToString()
						};
						for (int j = 2; j < dataGridViewTable.Columns.Count; j++)
						{
							try
							{
								list2.Add(dataGridViewTable.Rows[i].Cells[j].Value.ToString());
							}
							catch
							{
								list2.Add("");
							}
						}
						list.Add(string.Join("<=><=>", list2));
					}
					Class7.smethod_2(Directory.GetCurrentDirectory() + "\\Log Data\\" + $"Log_{DateTime.Now.Month}thang_{DateTime.Now.Day}ngay_{DateTime.Now.Hour}gio_{DateTime.Now.Minute}phut_{DateTime.Now.Second}giay.txt", string.Join("\n", list));
				});
			});
			thread.IsBackground = true;
			thread.Start();
		}
		catch
		{
		}
	}

	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(A833F4BE))]
	private Task C09038B8(Class11 class11_0)
	{
		A833F4BE stateMachine = new A833F4BE();
		stateMachine.asyncTaskMethodBuilder_0 = AsyncTaskMethodBuilder.Create();
		stateMachine.EDB2659A = this;
		stateMachine.CF11BC1A = class11_0;
		stateMachine.int_0 = -1;
		stateMachine.asyncTaskMethodBuilder_0.Start(ref stateMachine);
		return stateMachine.asyncTaskMethodBuilder_0.Task;
	}

	private void method_0(Class11 class11_0)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0016, IL_0018, IL_001d, IL_001f, IL_0020, IL_0025, IL_0059, IL_0080, IL_008f, IL_0094, IL_00c6, IL_00cb, IL_00da, IL_00df, IL_0102, IL_0107, IL_0116, IL_011b, IL_0122, IL_0127, IL_012c, IL_015f, IL_017d, IL_01b2, IL_01c2, IL_01d2, IL_01e4, IL_01ef, IL_0210, IL_0216, IL_023b, IL_0252, IL_025b, IL_0262, IL_0290, IL_0299, IL_02a0, IL_02b0, IL_02ca, IL_02d1, IL_033e, IL_034e, IL_035e, IL_0369, IL_0374, IL_0376, IL_037b, IL_037d, IL_037e, IL_0383, IL_03ac, IL_03b3, IL_03bf, IL_03d8, IL_03dd, IL_03e9, IL_040a, IL_040f, IL_041b, IL_0425, IL_0463, IL_0475, IL_047c, IL_0498, IL_04aa, IL_04ca, IL_04d5, IL_04d7, IL_04dc, IL_04de, IL_04df, IL_04e4, IL_0512, IL_0519, IL_0537, IL_054b, IL_058f, IL_05bf, IL_05c7, IL_05c9, IL_05db, IL_05e9, IL_05ee, IL_05f0, IL_0602, IL_0610, IL_0622, IL_062e, IL_0635, IL_0652, IL_0657, IL_065c, IL_067a, IL_06b6, IL_06d3, IL_06d4, IL_07e9, IL_07f0, IL_07ff, IL_0819, IL_0833, IL_084b, IL_0855, IL_0860, IL_086b, IL_08a2, IL_08ae, IL_08b0, IL_08b5, IL_08b7, IL_08b8, IL_08bd, IL_08e6, IL_08f5, IL_0909, IL_0940, IL_094a, IL_0967, IL_09b9, IL_09bd, IL_09d2, IL_09dc, IL_09e8, IL_0a0b, IL_0a15, IL_0a20, IL_0a27, IL_0a31, IL_0a3f, IL_0a49, IL_0a55, IL_0a76, IL_0a82, IL_0a84, IL_0a89, IL_0a8b, IL_0a8c, IL_0a91, IL_0ac5, IL_0aca, IL_0add, IL_0ae6, IL_0aed, IL_0b13, IL_0b1f, IL_0b21, IL_0b26, IL_0b28, IL_0b29, IL_0b2e, IL_0b6f, IL_0b7e, IL_0bfe, IL_0c0e, IL_0c13, IL_0c15, IL_0c39, IL_0c5a, IL_0c7a, IL_0c95, IL_0cae, IL_0cb4, IL_0cc4, IL_0d0e, IL_0d1a, IL_0d1c, IL_0d21, IL_0d23, IL_0d24, IL_0d26, IL_0d6e, IL_0d77, IL_0d7e, IL_0da4, IL_0db0, IL_0db2, IL_0db7, IL_0db9, IL_0dba, IL_0dbc, IL_0dfe, IL_0e07, IL_0e0e, IL_0e2f, IL_0e3b, IL_0e3d, IL_0e42, IL_0e44, IL_0e45, IL_0e47, IL_0e7b, IL_0e8e, IL_0e97, IL_0e9e, IL_0ec4, IL_0ed0, IL_0ed2, IL_0ed7, IL_0ed9, IL_0eda, IL_0edc, IL_0f10, IL_0f17, IL_0f20, IL_0f27, IL_0f4d, IL_0f59, IL_0f5b, IL_0f60, IL_0f62, IL_0f63, IL_0f65, IL_0fdc, IL_104b, IL_1050, IL_1055, IL_1061, IL_1063, IL_1068, IL_106a, IL_106b, IL_1070, IL_1099, IL_109b, IL_10ab, IL_10b0, IL_10b5, IL_10ba, IL_10d8, IL_10fb, IL_1106, IL_111c, IL_1121, IL_1126, IL_1130, IL_1136, IL_1154, IL_1167, IL_118f, IL_1196, IL_119c, IL_11c7, IL_11ce, IL_11da, IL_1202, IL_1209, IL_120f, IL_123a, IL_1241, IL_1291, IL_12a1, IL_12b1, IL_12bc, IL_12cf, IL_12d1, IL_12d6, IL_12d8, IL_12d9, IL_12de, IL_1302, IL_130e, IL_131a, IL_134f, IL_1359, IL_1391, IL_139f, IL_13ac, IL_13ad, IL_13af, IL_13ba, IL_1430, IL_1443, IL_1448, IL_1452, IL_1465, IL_146f, IL_147f, IL_148f, IL_1495, IL_149f, IL_14ac, IL_14c1, IL_14d6, IL_14e9, IL_1502, IL_1543, IL_1548, IL_154d, IL_1552, IL_1557, IL_1561, IL_1566, IL_157e, IL_158d, IL_159b, IL_15f7, IL_1653, IL_1658, IL_1667, IL_1675, IL_16d1, IL_172d, IL_1732, IL_173e, IL_1797, IL_17bb, IL_17ce, IL_17d9, IL_17ef, IL_17f3, IL_1874, IL_18a2, IL_18d0, IL_18da, IL_1921, IL_1984, IL_19e7, IL_1a33, IL_1a93, IL_1aab, IL_1ac5, IL_1ac9, IL_1af2, IL_1b1b, IL_1b20, IL_1b25, IL_1b31, IL_1b36, IL_1b5f, IL_1c4b, IL_1c54, IL_1c5b, IL_1c67, IL_1c6c, IL_1ca1, IL_1cb6, IL_1d0e, IL_1d21, IL_1d2c, IL_1d40, IL_1d55, IL_1d6a, IL_1d7f, IL_1d92, IL_1d98, IL_1da8, IL_1dc0, IL_1dea, IL_1def, IL_1df1
		//IL_001f: Incompatible stack heights: 0 vs 1
		//IL_037d: Incompatible stack heights: 0 vs 1
		//IL_04de: Incompatible stack heights: 0 vs 1
		//IL_0530: Invalid comparison between Unknown and I4
		//IL_08b7: Incompatible stack heights: 0 vs 1
		//IL_0a8b: Incompatible stack heights: 0 vs 1
		//IL_0b28: Incompatible stack heights: 0 vs 1
		//IL_0d23: Incompatible stack heights: 0 vs 1
		//IL_0db9: Incompatible stack heights: 0 vs 1
		//IL_0e44: Incompatible stack heights: 0 vs 1
		//IL_0ed9: Incompatible stack heights: 0 vs 1
		//IL_0f62: Incompatible stack heights: 0 vs 1
		//IL_106a: Incompatible stack heights: 0 vs 1
		//IL_12d8: Incompatible stack heights: 0 vs 1
		try
		{
			/*Error near IL_0001: Invalid metadata token*/;
		}
		catch (Exception ex)
		{
			class11_0.String_9 = ex.Message;
			class11_0.Int32_0 = -1;
			backgroundWorker_0.ReportProgress(class11_0.B4902023, class11_0);
		}
		finally
		{
		}
	}

	private void A63F0524()
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			try
			{
				FileInfo[] files = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\Log Data").GetFiles("*.txt");
				Array.Sort(files, (FileInfo F70F7684, FileInfo fileInfo_0) => StringComparer.OrdinalIgnoreCase.Compare(F70F7684.CreationTime, fileInfo_0.CreationTime));
				string[] array = File.ReadAllText(files[files.Length - 1].FullName).Trim().Split('\n');
				for (int i = 0; i < array.Length; i++)
				{
					try
					{
						dataGridViewTable.Rows.Add();
						dataGridViewTable.Rows[i].Cells[0].Value = array[i].Split(new string[1] { "<=><=>" }, StringSplitOptions.None)[0].Trim();
						if (array[i].Split(new string[1] { "<=><=>" }, StringSplitOptions.None)[1].Trim().Equals("True"))
						{
							dataGridViewTable.Rows[i].Cells[1].Value = true;
						}
						for (int j = 2; j < dataGridViewTable.Columns.Count; j++)
						{
							try
							{
								dataGridViewTable.Rows[i].Cells[j].Value = array[i].Split(new string[1] { "<=><=>" }, StringSplitOptions.None)[j].Trim();
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

	public static string smethod_0(string B707B309)
	{
		byte[] bytes = Convert.FromBase64String(B707B309);
		return Encoding.UTF8.GetString(bytes);
	}

	private void ImportAccountToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0026, IL_002b, IL_003a, IL_004f, IL_006e
		/*Error: Invalid metadata token*/;
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < dataGridViewTable.Rows.Count; i++)
		{
			dataGridViewTable.Rows[i].Cells["Tick"].Value = true;
		}
		D0095095();
	}

	private void E599EAB1(object sender, EventArgs e)
	{
		for (int i = 0; i < dataGridViewTable.Rows.Count; i++)
		{
			dataGridViewTable.Rows[i].Cells["Tick"].Value = false;
		}
		D0095095();
	}

	private void F803673D_Click(object sender, EventArgs e)
	{
		for (int i = 0; i < dataGridViewTable.Rows.Count; i++)
		{
			if (dataGridViewTable.Rows[i].Cells[2].Selected)
			{
				dataGridViewTable.Rows[i].Cells[1].Value = true;
			}
			else if ((bool)dataGridViewTable.Rows[i].Cells[1].FormattedValue)
			{
				dataGridViewTable.Rows[i].Cells[1].Value = false;
			}
		}
		D0095095();
	}

	private void C1367338(object sender, EventArgs e)
	{
		new A4B3049A().ShowDialog();
		if (A4B3049A.string_0 == null)
		{
			return;
		}
		for (int i = 0; i < dataGridViewTable.Rows.Count; i++)
		{
			if (dataGridViewTable.Rows[i].Cells["Progress"].Value != null && dataGridViewTable.Rows[i].Cells["Progress"].Value.ToString().Contains(A4B3049A.string_0))
			{
				dataGridViewTable.Rows[i].Cells[1].Value = true;
			}
			else if ((bool)dataGridViewTable.Rows[i].Cells[1].FormattedValue)
			{
				dataGridViewTable.Rows[i].Cells[1].Value = false;
			}
		}
		D0095095();
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
			for (int num = dataGridViewTable.Rows.Count - 1; num >= 0; num--)
			{
				if (dataGridViewTable.Rows[num].Cells[2].Selected)
				{
					list.Add(num);
				}
			}
			for (int num2 = dataGridViewTable.Rows.Count - 1; num2 >= 0; num2--)
			{
				if (list.Contains(num2))
				{
					dataGridViewTable.Rows.Remove(dataGridViewTable.Rows[num2]);
				}
			}
			D0095095();
		}
		catch
		{
		}
	}

	private void C40ABE97_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Xóa dòng đã chọn?", "QA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
		{
			return;
		}
		for (int num = dataGridViewTable.Rows.Count - 1; num >= 0; num--)
		{
			if ((bool)dataGridViewTable.Rows[num].Cells[1].FormattedValue)
			{
				dataGridViewTable.Rows.Remove(dataGridViewTable.Rows[num]);
			}
		}
		D0095095();
	}

	private void toolStripMenuItem_4_Click(object sender, EventArgs e)
	{
		if (MessageBox.Show("Xóa dòng không chọn?", "QA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
		{
			return;
		}
		for (int num = dataGridViewTable.Rows.Count - 1; num >= 0; num--)
		{
			if (!(bool)dataGridViewTable.Rows[num].Cells[1].FormattedValue)
			{
				dataGridViewTable.Rows.Remove(dataGridViewTable.Rows[num]);
			}
		}
		D0095095();
	}

	private void FF9EED01(object sender, EventArgs e)
	{
		if (MessageBox.Show("Chắc chắn xóa toàn bộ dòng?", "QA?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		{
			dataGridViewTable.Rows.Clear();
		}
	}

	private void DE3D022C_Click(object sender, EventArgs e)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < dataGridViewTable.Rows.Count; i++)
		{
			List<string> list2 = new List<string>();
			for (int j = 2; j < dataGridViewTable.ColumnCount; j++)
			{
				if (dataGridViewTable.Rows[i].Cells[j].Selected)
				{
					try
					{
						list2.Add(dataGridViewTable.Rows[i].Cells[j].Value.ToString());
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

	private void toolStripMenuItem5_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0026, IL_002b, IL_003a, IL_004f, IL_006e
		/*Error: Invalid metadata token*/;
	}

	private void AE3CD08A_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0026, IL_002b, IL_003a, IL_004f, IL_006e
		/*Error: Invalid metadata token*/;
	}

	private void A6B18F04(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void ImportNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0026, IL_002b, IL_003a, IL_004f, IL_0064, IL_0083
		/*Error: Invalid metadata token*/;
	}

	private void A282F5A5(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0026, IL_002b, IL_003a, IL_004f, IL_0064, IL_0083
		/*Error: Invalid metadata token*/;
	}

	private void C4AC56A5_Click(object sender, EventArgs e)
	{
		try
		{
			for (int i = 0; i < dataGridViewTable.Columns.Count; i++)
			{
				dataGridViewTable.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
			}
		}
		catch
		{
		}
		C4AC56A5.Enabled = false;
		buttonStop.Enabled = true;
		numericUpDownThread.Enabled = false;
		backgroundWorker_0.RunWorkerAsync();
	}

	private void A1A020AA(object sender, EventArgs e)
	{
		if (backgroundWorker_0.IsBusy)
		{
			C4AC56A5.Text = "Đang dừng...";
			backgroundWorker_0.CancelAsync();
			backgroundWorker_0.Dispose();
		}
	}

	protected override void Dispose(bool A7272B8F)
	{
		if (A7272B8F && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(A7272B8F);
	}

	private void E82D5018()
	{
		icontainer_0 = new Container();
		DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(FBBE97AE));
		DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
		dataGridViewTable = new DataGridView();
		panel1 = new Panel();
		FC2E6486 = new Label();
		D737EE2C = new NumericUpDown();
		numericUpDownThread = new NumericUpDown();
		label2 = new Label();
		D20BA919 = new Label();
		buttonStop = new Button();
		C4AC56A5 = new Button();
		contextMenuStrip1 = new ContextMenuStrip(icontainer_0);
		ImportAccountToolStripMenuItem = new ToolStripMenuItem();
		AE3CD08A = new ToolStripMenuItem();
		toolStripMenuItem5 = new ToolStripMenuItem();
		toolStripMenuItem6 = new ToolStripMenuItem();
		ImportNewAccountToolStripMenuItem = new ToolStripMenuItem();
		toolStripMenuItem2 = new ToolStripMenuItem();
		toolStripMenuItem_0 = new ToolStripMenuItem();
		toolStripMenuItem_1 = new ToolStripMenuItem();
		F803673D = new ToolStripMenuItem();
		toolStripMenuItem_2 = new ToolStripMenuItem();
		toolStripMenuItem3 = new ToolStripMenuItem();
		toolStripMenuItem_3 = new ToolStripMenuItem();
		C40ABE97 = new ToolStripMenuItem();
		toolStripMenuItem_4 = new ToolStripMenuItem();
		F409F285 = new ToolStripMenuItem();
		A81ECB90 = new ToolStripMenuItem();
		DE3D022C = new ToolStripMenuItem();
		index = new DataGridViewTextBoxColumn();
		Tick = new DataGridViewCheckBoxColumn();
		AdID = new DataGridViewTextBoxColumn();
		Status = new DataGridViewTextBoxColumn();
		A0AD2CB4 = new DataGridViewTextBoxColumn();
		AdName = new DataGridViewTextBoxColumn();
		Currency = new DataGridViewTextBoxColumn();
		Limit = new DataGridViewTextBoxColumn();
		Threshold = new DataGridViewTextBoxColumn();
		F3950994 = new DataGridViewTextBoxColumn();
		AmountSpent = new DataGridViewTextBoxColumn();
		B180D3AA = new DataGridViewTextBoxColumn();
		Timezone = new DataGridViewTextBoxColumn();
		AdCampaign = new DataGridViewTextBoxColumn();
		Type = new DataGridViewTextBoxColumn();
		CreatedDate = new DataGridViewTextBoxColumn();
		AE1DD0B9 = new DataGridViewTextBoxColumn();
		A52792B4 = new DataGridViewTextBoxColumn();
		((ISupportInitialize)dataGridViewTable).BeginInit();
		panel1.SuspendLayout();
		((ISupportInitialize)D737EE2C).BeginInit();
		((ISupportInitialize)numericUpDownThread).BeginInit();
		contextMenuStrip1.SuspendLayout();
		SuspendLayout();
		dataGridViewTable.AllowUserToAddRows = false;
		dataGridViewTable.AllowUserToResizeRows = false;
		dataGridViewTable.BackgroundColor = SystemColors.ButtonHighlight;
		dataGridViewTable.BorderStyle = BorderStyle.None;
		dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
		dataGridViewCellStyle.BackColor = SystemColors.Control;
		dataGridViewCellStyle.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		dataGridViewCellStyle.ForeColor = SystemColors.WindowText;
		dataGridViewCellStyle.SelectionBackColor = Color.Teal;
		dataGridViewCellStyle.SelectionForeColor = SystemColors.HighlightText;
		dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
		dataGridViewTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
		dataGridViewTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		dataGridViewTable.Columns.AddRange(index, Tick, AdID, Status, A0AD2CB4, AdName, Currency, Limit, Threshold, F3950994, AmountSpent, B180D3AA, Timezone, AdCampaign, Type, CreatedDate, AE1DD0B9, A52792B4);
		dataGridViewTable.Dock = DockStyle.Fill;
		dataGridViewTable.Location = new Point(0, 84);
		dataGridViewTable.Name = "dataGridViewTable";
		dataGridViewTable.RowHeadersVisible = false;
		dataGridViewTable.Size = new Size(933, 401);
		dataGridViewTable.TabIndex = 87;
		dataGridViewTable.CellContentClick += A6B18F04;
		panel1.Controls.Add(FC2E6486);
		panel1.Controls.Add(D737EE2C);
		panel1.Controls.Add(numericUpDownThread);
		panel1.Controls.Add(label2);
		panel1.Controls.Add(D20BA919);
		panel1.Controls.Add(buttonStop);
		panel1.Controls.Add(C4AC56A5);
		panel1.Dock = DockStyle.Top;
		panel1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		panel1.Location = new Point(0, 0);
		panel1.Name = "panel1";
		panel1.Size = new Size(933, 84);
		panel1.TabIndex = 86;
		FC2E6486.AutoSize = true;
		FC2E6486.Location = new Point(314, 52);
		FC2E6486.Name = "labelStatus";
		FC2E6486.Size = new Size(19, 14);
		FC2E6486.TabIndex = 52;
		FC2E6486.Text = "---";
		D737EE2C.Location = new Point(215, 14);
		D737EE2C.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		D737EE2C.Name = "numericUpDownDelay";
		D737EE2C.Size = new Size(64, 22);
		D737EE2C.TabIndex = 51;
		numericUpDownThread.Location = new Point(69, 14);
		numericUpDownThread.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		numericUpDownThread.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		numericUpDownThread.Name = "numericUpDownThread";
		numericUpDownThread.Size = new Size(77, 22);
		numericUpDownThread.TabIndex = 50;
		numericUpDownThread.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		label2.AutoSize = true;
		label2.Location = new Point(148, 18);
		label2.Name = "label2";
		label2.Size = new Size(65, 14);
		label2.TabIndex = 49;
		label2.Text = "Delay(ms):";
		D20BA919.AutoSize = true;
		D20BA919.Location = new Point(16, 18);
		D20BA919.Name = "label1";
		D20BA919.Size = new Size(50, 14);
		D20BA919.TabIndex = 48;
		D20BA919.Text = "Thread:";
		buttonStop.BackColor = Color.Red;
		buttonStop.Cursor = Cursors.Hand;
		buttonStop.Enabled = false;
		buttonStop.FlatAppearance.BorderSize = 0;
		buttonStop.FlatStyle = FlatStyle.Flat;
		buttonStop.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		buttonStop.ForeColor = Color.White;
		buttonStop.ImageAlign = ContentAlignment.MiddleRight;
		buttonStop.Location = new Point(152, 44);
		buttonStop.Name = "buttonStop";
		buttonStop.Size = new Size(127, 29);
		buttonStop.TabIndex = 47;
		buttonStop.Text = "Stop";
		buttonStop.UseVisualStyleBackColor = false;
		buttonStop.Click += A1A020AA;
		C4AC56A5.BackColor = Color.Green;
		C4AC56A5.Cursor = Cursors.Hand;
		C4AC56A5.Enabled = false;
		C4AC56A5.FlatAppearance.BorderSize = 0;
		C4AC56A5.FlatStyle = FlatStyle.Flat;
		C4AC56A5.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		C4AC56A5.ForeColor = Color.White;
		C4AC56A5.ImageAlign = ContentAlignment.MiddleRight;
		C4AC56A5.Location = new Point(19, 44);
		C4AC56A5.Name = "buttonStart";
		C4AC56A5.Size = new Size(127, 29);
		C4AC56A5.TabIndex = 46;
		C4AC56A5.Text = "Start";
		C4AC56A5.UseVisualStyleBackColor = false;
		C4AC56A5.Click += C4AC56A5_Click;
		contextMenuStrip1.Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		contextMenuStrip1.Items.AddRange(new ToolStripItem[17]
		{
			ImportAccountToolStripMenuItem, AE3CD08A, toolStripMenuItem5, toolStripMenuItem6, ImportNewAccountToolStripMenuItem, toolStripMenuItem2, toolStripMenuItem_0, toolStripMenuItem_1, F803673D, toolStripMenuItem_2,
			toolStripMenuItem3, toolStripMenuItem_3, C40ABE97, toolStripMenuItem_4, F409F285, A81ECB90, DE3D022C
		});
		contextMenuStrip1.Name = "contextMenuStrip1";
		contextMenuStrip1.Size = new Size(259, 378);
		ImportAccountToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("ImportAccountToolStripMenuItem.Image");
		ImportAccountToolStripMenuItem.Name = "ImportAccountToolStripMenuItem";
		ImportAccountToolStripMenuItem.Size = new Size(258, 22);
		ImportAccountToolStripMenuItem.Text = "Load tài khoản [tất cả]";
		ImportAccountToolStripMenuItem.Click += ImportAccountToolStripMenuItem_Click;
		AE3CD08A.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem1.Image");
		AE3CD08A.Name = "toolStripMenuItem1";
		AE3CD08A.Size = new Size(258, 22);
		AE3CD08A.Text = "Load tài khoản [bm]";
		AE3CD08A.Click += AE3CD08A_Click;
		toolStripMenuItem5.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem5.Image");
		toolStripMenuItem5.Name = "toolStripMenuItem5";
		toolStripMenuItem5.Size = new Size(258, 22);
		toolStripMenuItem5.Text = "Load tài khoản [tkcn]";
		toolStripMenuItem5.Click += toolStripMenuItem5_Click;
		toolStripMenuItem6.Image = (Image)componentResourceManager.GetObject("toolStripMenuItem6.Image");
		toolStripMenuItem6.Name = "toolStripMenuItem6";
		toolStripMenuItem6.Size = new Size(258, 22);
		toolStripMenuItem6.Text = "Load tài khoản [theo bm id]";
		toolStripMenuItem6.Click += A282F5A5;
		ImportNewAccountToolStripMenuItem.Image = (Image)componentResourceManager.GetObject("ImportNewAccountToolStripMenuItem.Image");
		ImportNewAccountToolStripMenuItem.Name = "ImportNewAccountToolStripMenuItem";
		ImportNewAccountToolStripMenuItem.Size = new Size(258, 22);
		ImportNewAccountToolStripMenuItem.Text = "Load tài khoản [theo tkqc id]";
		ImportNewAccountToolStripMenuItem.Click += ImportNewAccountToolStripMenuItem_Click;
		toolStripMenuItem2.Name = "toolStripMenuItem2";
		toolStripMenuItem2.Size = new Size(258, 22);
		toolStripMenuItem2.Text = "----------------------------------------------";
		toolStripMenuItem_0.Image = (Image)componentResourceManager.GetObject("chọnTấtCảToolStripMenuItem.Image");
		toolStripMenuItem_0.Name = "chọnTấtCảToolStripMenuItem";
		toolStripMenuItem_0.Size = new Size(258, 22);
		toolStripMenuItem_0.Text = "Chọn tất cả";
		toolStripMenuItem_0.Click += toolStripMenuItem_0_Click;
		toolStripMenuItem_1.Image = (Image)componentResourceManager.GetObject("bỏChọnTấtCảToolStripMenuItem.Image");
		toolStripMenuItem_1.Name = "bỏChọnTấtCảToolStripMenuItem";
		toolStripMenuItem_1.Size = new Size(258, 22);
		toolStripMenuItem_1.Text = "Bỏ chọn tất cả";
		toolStripMenuItem_1.Click += E599EAB1;
		F803673D.Image = (Image)componentResourceManager.GetObject("chọnDòngBôiĐenToolStripMenuItem.Image");
		F803673D.Name = "chọnDòngBôiĐenToolStripMenuItem";
		F803673D.Size = new Size(258, 22);
		F803673D.Text = "Chọn dòng bôi đen";
		F803673D.Click += F803673D_Click;
		toolStripMenuItem_2.Image = (Image)componentResourceManager.GetObject("chọnDòngTheoStatusToolStripMenuItem.Image");
		toolStripMenuItem_2.Name = "chọnDòngTheoStatusToolStripMenuItem";
		toolStripMenuItem_2.Size = new Size(258, 22);
		toolStripMenuItem_2.Text = "Chọn dòng theo status";
		toolStripMenuItem_2.Click += C1367338;
		toolStripMenuItem3.Name = "toolStripMenuItem3";
		toolStripMenuItem3.Size = new Size(258, 22);
		toolStripMenuItem3.Text = "----------------------------------------------";
		toolStripMenuItem_3.Image = (Image)componentResourceManager.GetObject("xóaDòngBôiĐenToolStripMenuItem.Image");
		toolStripMenuItem_3.Name = "xóaDòngBôiĐenToolStripMenuItem";
		toolStripMenuItem_3.Size = new Size(258, 22);
		toolStripMenuItem_3.Text = "Xóa dòng bôi đen";
		toolStripMenuItem_3.Click += toolStripMenuItem_3_Click;
		C40ABE97.Image = (Image)componentResourceManager.GetObject("xóaDòngĐãChọnToolStripMenuItem.Image");
		C40ABE97.Name = "xóaDòngĐãChọnToolStripMenuItem";
		C40ABE97.Size = new Size(258, 22);
		C40ABE97.Text = "Xóa dòng đã chọn";
		C40ABE97.Click += C40ABE97_Click;
		toolStripMenuItem_4.Image = (Image)componentResourceManager.GetObject("xóaDòngKhôngChọnToolStripMenuItem.Image");
		toolStripMenuItem_4.Name = "xóaDòngKhôngChọnToolStripMenuItem";
		toolStripMenuItem_4.Size = new Size(258, 22);
		toolStripMenuItem_4.Text = "Xóa dòng không chọn";
		toolStripMenuItem_4.Click += toolStripMenuItem_4_Click;
		F409F285.Image = (Image)componentResourceManager.GetObject("xóaToànBộDòngToolStripMenuItem.Image");
		F409F285.Name = "xóaToànBộDòngToolStripMenuItem";
		F409F285.Size = new Size(258, 22);
		F409F285.Text = "Xóa toàn bộ dòng";
		F409F285.Click += FF9EED01;
		A81ECB90.Name = "toolStripMenuItem4";
		A81ECB90.Size = new Size(258, 22);
		A81ECB90.Text = "----------------------------------------------";
		DE3D022C.Image = (Image)componentResourceManager.GetObject("xuấtTàiKhoảnĐãChọnToolStripMenuItem.Image");
		DE3D022C.Name = "xuấtTàiKhoảnĐãChọnToolStripMenuItem";
		DE3D022C.Size = new Size(258, 22);
		DE3D022C.Text = "Copy tài khoản bôi đen";
		DE3D022C.Click += DE3D022C_Click;
		dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
		index.DefaultCellStyle = dataGridViewCellStyle2;
		index.HeaderText = "STT";
		index.Name = "index";
		index.SortMode = DataGridViewColumnSortMode.NotSortable;
		index.Width = 40;
		Tick.HeaderText = "x";
		Tick.Name = "Tick";
		Tick.TrueValue = "";
		Tick.Width = 30;
		AdID.HeaderText = "AdID";
		AdID.Name = "AdID";
		Status.HeaderText = "Status";
		Status.Name = "Status";
		A0AD2CB4.HeaderText = "Progress";
		A0AD2CB4.MinimumWidth = 100;
		A0AD2CB4.Name = "Progress";
		A0AD2CB4.Width = 200;
		AdName.HeaderText = "AdName";
		AdName.Name = "AdName";
		Currency.HeaderText = "Currency";
		Currency.Name = "Currency";
		Limit.HeaderText = "Limit";
		Limit.Name = "Limit";
		Threshold.HeaderText = "Threshold";
		Threshold.Name = "Threshold";
		F3950994.HeaderText = "Balance";
		F3950994.Name = "Balance";
		AmountSpent.HeaderText = "AmountSpent";
		AmountSpent.Name = "AmountSpent";
		B180D3AA.HeaderText = "Payment";
		B180D3AA.Name = "Payment";
		Timezone.HeaderText = "Timezone";
		Timezone.Name = "Timezone";
		AdCampaign.HeaderText = "AdCampaign";
		AdCampaign.Name = "AdCampaign";
		Type.HeaderText = "Type";
		Type.Name = "Type";
		CreatedDate.HeaderText = "CreatedDate";
		CreatedDate.MinimumWidth = 150;
		CreatedDate.Name = "CreatedDate";
		CreatedDate.Width = 150;
		AE1DD0B9.HeaderText = "TypeAccount";
		AE1DD0B9.Name = "is_prepay_account";
		A52792B4.HeaderText = "errorCodeStatus";
		A52792B4.Name = "errorCodeStatus";
		A52792B4.SortMode = DataGridViewColumnSortMode.NotSortable;
		A52792B4.Visible = false;
		base.AutoScaleDimensions = new SizeF(7f, 14f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(933, 485);
		base.Controls.Add(dataGridViewTable);
		base.Controls.Add(panel1);
		Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fAdAccount";
		Text = "fRun";
		((ISupportInitialize)dataGridViewTable).EndInit();
		panel1.ResumeLayout(performLayout: false);
		panel1.PerformLayout();
		((ISupportInitialize)D737EE2C).EndInit();
		((ISupportInitialize)numericUpDownThread).EndInit();
		contextMenuStrip1.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
	}

	[CompilerGenerated]
	private void method_1()
	{
		FC2E6486.Text = "Đang xử lý, check live cookie...";
	}

	[CompilerGenerated]
	private void method_2()
	{
		FC2E6486.Text = "";
	}

	[CompilerGenerated]
	private void method_3()
	{
		FC2E6486.Text = "Đang xử lý, khởi tạo tham số...";
	}

	[CompilerGenerated]
	private void method_4()
	{
		FC2E6486.Text = "";
	}

	[CompilerGenerated]
	private void method_5()
	{
		FC2E6486.Text = "";
	}

	[CompilerGenerated]
	private void D626EE25()
	{
		B18DAC37.Clear();
		for (int i = 0; i < dataGridViewTable.Rows.Count; i++)
		{
			Class11 @class = new Class11
			{
				B4902023 = i,
				F032C212 = (bool)dataGridViewTable.Rows[i].Cells[1].FormattedValue
			};
			dataGridViewTable.Rows[i].Cells["index"].Value = (@class.B4902023 + 1).ToString();
			@class.String_1 = ((dataGridViewTable.Rows[i].Cells[2].Value != null) ? dataGridViewTable.Rows[i].Cells[2].Value.ToString() : "");
			@class.C9321781 = ((dataGridViewTable.Rows[i].Cells[5].Value != null) ? dataGridViewTable.Rows[i].Cells[5].Value.ToString() : "");
			@class.String_3 = ((dataGridViewTable.Rows[i].Cells[6].Value != null) ? dataGridViewTable.Rows[i].Cells[6].Value.ToString() : "");
			@class.String_7 = ((dataGridViewTable.Rows[i].Cells[12].Value != null) ? dataGridViewTable.Rows[i].Cells[12].Value.ToString() : "");
			@class.Int32_0 = 0;
			B18DAC37.Add(@class);
		}
	}

	[CompilerGenerated]
	private void F2A04717()
	{
		if (!Directory.Exists(Directory.GetCurrentDirectory() + "\\Log Data"))
		{
			Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Log Data");
		}
		dataGridViewTable.Invoke((MethodInvoker)delegate
		{
			List<string> list = new List<string>();
			for (int i = 0; i < dataGridViewTable.Rows.Count; i++)
			{
				List<string> list2 = new List<string>
				{
					dataGridViewTable.Rows[i].Cells[0].Value.ToString(),
					dataGridViewTable.Rows[i].Cells[1].FormattedValue.ToString()
				};
				for (int j = 2; j < dataGridViewTable.Columns.Count; j++)
				{
					try
					{
						list2.Add(dataGridViewTable.Rows[i].Cells[j].Value.ToString());
					}
					catch
					{
						list2.Add("");
					}
				}
				list.Add(string.Join("<=><=>", list2));
			}
			Class7.smethod_2(Directory.GetCurrentDirectory() + "\\Log Data\\" + $"Log_{DateTime.Now.Month}thang_{DateTime.Now.Day}ngay_{DateTime.Now.Hour}gio_{DateTime.Now.Minute}phut_{DateTime.Now.Second}giay.txt", string.Join("\n", list));
		});
	}

	[CompilerGenerated]
	private void method_6()
	{
		List<string> list = new List<string>();
		for (int i = 0; i < dataGridViewTable.Rows.Count; i++)
		{
			List<string> list2 = new List<string>
			{
				dataGridViewTable.Rows[i].Cells[0].Value.ToString(),
				dataGridViewTable.Rows[i].Cells[1].FormattedValue.ToString()
			};
			for (int j = 2; j < dataGridViewTable.Columns.Count; j++)
			{
				try
				{
					list2.Add(dataGridViewTable.Rows[i].Cells[j].Value.ToString());
				}
				catch
				{
					list2.Add("");
				}
			}
			list.Add(string.Join("<=><=>", list2));
		}
		Class7.smethod_2(Directory.GetCurrentDirectory() + "\\Log Data\\" + $"Log_{DateTime.Now.Month}thang_{DateTime.Now.Day}ngay_{DateTime.Now.Hour}gio_{DateTime.Now.Minute}phut_{DateTime.Now.Second}giay.txt", string.Join("\n", list));
	}

	[CompilerGenerated]
	private void F820BE0A()
	{
		try
		{
			FileInfo[] files = new DirectoryInfo(Directory.GetCurrentDirectory() + "\\Log Data").GetFiles("*.txt");
			Array.Sort(files, (FileInfo F70F7684, FileInfo fileInfo_0) => StringComparer.OrdinalIgnoreCase.Compare(F70F7684.CreationTime, fileInfo_0.CreationTime));
			string[] array = File.ReadAllText(files[files.Length - 1].FullName).Trim().Split('\n');
			for (int i = 0; i < array.Length; i++)
			{
				try
				{
					dataGridViewTable.Rows.Add();
					dataGridViewTable.Rows[i].Cells[0].Value = array[i].Split(new string[1] { "<=><=>" }, StringSplitOptions.None)[0].Trim();
					if (array[i].Split(new string[1] { "<=><=>" }, StringSplitOptions.None)[1].Trim().Equals("True"))
					{
						dataGridViewTable.Rows[i].Cells[1].Value = true;
					}
					for (int j = 2; j < dataGridViewTable.Columns.Count; j++)
					{
						try
						{
							dataGridViewTable.Rows[i].Cells[j].Value = array[i].Split(new string[1] { "<=><=>" }, StringSplitOptions.None)[j].Trim();
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
	private void method_7()
	{
		//Discarded unreachable code: IL_0018, IL_0031, IL_0032, IL_0037, IL_0066, IL_007d, IL_00b6, IL_00c7, IL_00d4, IL_00e1, IL_00ee, IL_00fb, IL_0108, IL_0109, IL_010b, IL_011d, IL_012a, IL_014a, IL_014f, IL_0158, IL_0162, IL_0175, IL_018d, IL_01b5, IL_01d6, IL_01e2, IL_01e3, IL_021f, IL_0227, IL_0258
		//IL_002a: Invalid comparison between Unknown and I4
		httpRequest_0.Cookies = new CookieDictionary();
		int num = 0;
		/*Error near IL_0013: Invalid metadata token*/;
	}

	[CompilerGenerated]
	private void method_8()
	{
		FC2E6486.Text = "Fetching ad account...";
	}

	[CompilerGenerated]
	private void F5852F2D()
	{
		dataGridViewTable.Rows.Clear();
	}

	[CompilerGenerated]
	private void FD09261B()
	{
		FC2E6486.Text = "";
	}

	[CompilerGenerated]
	private void method_9()
	{
		//Discarded unreachable code: IL_0018, IL_0031, IL_0032, IL_0037, IL_0066, IL_007d, IL_00b6, IL_00c7, IL_00d4, IL_00e1, IL_00ee, IL_00fb, IL_0108, IL_0109, IL_010b, IL_011d, IL_012a, IL_014a, IL_014f, IL_0158, IL_0162, IL_0175, IL_018d, IL_01b5, IL_01d6, IL_01e2, IL_01e3, IL_023d, IL_0245, IL_0276
		//IL_002a: Invalid comparison between Unknown and I4
		httpRequest_0.Cookies = new CookieDictionary();
		int num = 0;
		/*Error near IL_0013: Invalid metadata token*/;
	}

	[CompilerGenerated]
	private void method_10()
	{
		FC2E6486.Text = "Fetching ad account...";
	}

	[CompilerGenerated]
	private void CE32373B()
	{
		dataGridViewTable.Rows.Clear();
	}

	[CompilerGenerated]
	private void method_11()
	{
		FC2E6486.Text = "";
	}

	[CompilerGenerated]
	private void method_12()
	{
		//Discarded unreachable code: IL_0018, IL_0031, IL_0032, IL_0037, IL_0066, IL_007d, IL_00b6, IL_00c7, IL_00d4, IL_00e1, IL_00ee, IL_00fb, IL_0108, IL_0109, IL_010b, IL_011d, IL_012a, IL_014a, IL_014f, IL_0158, IL_0162, IL_0175, IL_018d, IL_01b5, IL_01d6, IL_01e2, IL_01e3, IL_023d, IL_0245, IL_0276
		//IL_002a: Invalid comparison between Unknown and I4
		httpRequest_0.Cookies = new CookieDictionary();
		int num = 0;
		/*Error near IL_0013: Invalid metadata token*/;
	}

	[CompilerGenerated]
	private void E218190B()
	{
		FC2E6486.Text = "Fetching ad account...";
	}

	[CompilerGenerated]
	private void EBAC4EB8()
	{
		dataGridViewTable.Rows.Clear();
	}

	[CompilerGenerated]
	private void method_13()
	{
		FC2E6486.Text = "";
	}

	[CompilerGenerated]
	private void AF93483F()
	{
		//Discarded unreachable code: IL_0019, IL_0032, IL_0033, IL_0038, IL_0067, IL_007e, IL_00b6, IL_00c7, IL_00d4, IL_00e1, IL_00ee, IL_00fb, IL_0108, IL_0109, IL_010b, IL_011c, IL_0129, IL_0148, IL_014d, IL_0156, IL_0160, IL_0173, IL_018b, IL_01c3, IL_023d, IL_0266, IL_028b
		//IL_002b: Invalid comparison between Unknown and I4
		try
		{
			httpRequest_0.Cookies = new CookieDictionary();
			int num = 0;
			/*Error near IL_0014: Invalid metadata token*/;
		}
		catch
		{
		}
		FC2E6486.Invoke((MethodInvoker)delegate
		{
			FC2E6486.Text = "";
		});
		D0095095();
		MessageBox.Show("Load xong !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	[CompilerGenerated]
	private void D6A30617()
	{
		FC2E6486.Text = "Fetching ad account...";
	}

	[CompilerGenerated]
	private void method_14()
	{
		dataGridViewTable.Rows.Clear();
	}

	[CompilerGenerated]
	private void method_15()
	{
		FC2E6486.Text = "";
	}

	[CompilerGenerated]
	private void method_16()
	{
		//Discarded unreachable code: IL_0019, IL_0032, IL_0033, IL_0038, IL_0067, IL_007e, IL_00b7, IL_00c8, IL_00d5, IL_00e2, IL_00ef, IL_00fc, IL_0109, IL_010a, IL_010c, IL_011e, IL_012b, IL_014b, IL_0150, IL_0159, IL_0163, IL_0176, IL_018e, IL_019e, IL_01bf, IL_01ce, IL_01cf, IL_0257, IL_0262
		//IL_002b: Invalid comparison between Unknown and I4
		try
		{
			httpRequest_0.Cookies = new CookieDictionary();
			int num = 0;
			/*Error near IL_0014: Invalid metadata token*/;
		}
		catch
		{
		}
		FC2E6486.Invoke((MethodInvoker)delegate
		{
			FC2E6486.Text = "";
		});
		D0095095();
		MessageBox.Show("Load xong !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	[CompilerGenerated]
	private void A82C4A3A()
	{
		dataGridViewTable.Rows.Clear();
	}

	[CompilerGenerated]
	private void A08871AB()
	{
		FC2E6486.Text = "";
	}
}
