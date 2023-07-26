using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

public class fDoiInfoTKQC : Form
{
	private IContainer icontainer_0 = null;

	private ComboBox comboBoxAddBMOption;

	private LinkLabel linkLabel9;

	private CheckBox checkBoxOutTkqc;

	private LinkLabel linkLabel5;

	private CheckBox checkBoxSharePixel;

	private TextBox DE874420;

	private Label label7;

	private TextBox textBoxPixelID;

	private Label label8;

	private RadioButton radioButtonAnalyst;

	private RadioButton radioButtonAdvertiser;

	private RadioButton radioButtonAdmin;

	private Label label3;

	private TextBox textBoxUidViaNhan;

	private LinkLabel linkLabel4;

	private CheckBox checkBoxTatTBTkqc;

	private LinkLabel linkLabel2;

	private LinkLabel linkLabel1;

	private Label label6;

	private TextBox textBoxBmIdViaNhan;

	private CheckBox checkBoxAddTkqcToBmViaNhan;

	private Label label5;

	private TextBox textBoxBmIdVia;

	private CheckBox FD284831;

	private Label D4245706;

	private TextBox textBoxTokenViaNhan;

	private CheckBox checkBoxShareTkqc;

	private Label label1;

	private NumericUpDown E2BA331A;

	private ComboBox D42B0196;

	private TextBox D486A4A5;

	private CheckBox A102F987;

	private LinkLabel linkLabel3;

	private Label F7B1CDA0;

	private CheckBox checkBoxDoiTTTkqc;

	private ComboBox EEA01829;

	private ComboBox comboBoxChangeTimezone;

	private LinkLabel linkLabel10;

	private Label label9;

	private LinkLabel linkLabel8;

	private LinkLabel A92B6CA4;

	private LinkLabel linkLabel6;

	private RadioButton B42FCEB6;

	private RadioButton radioButtonDaAll;

	private CheckBox checkBoxDaQTV;

	private LinkLabel linkLabel11;

	private CheckBox checkBoxKichMomo;

	private LinkLabel F2BBCD25;

	private CheckBox checkBoxPheDuyetPayment;

	private Panel panel1;

	private Panel panel2;

	private TextBox textBoxChangeCountry;

	private LinkLabel B5123FB0;

	private Panel panel3;

	private RadioButton radioButtonTaoTKQCMoi;

	private RadioButton radioButtonDoiTT;

	private CheckBox checkBox30days;

	private LinkLabel linkLabel14;

	public fDoiInfoTKQC()
	{
		//Discarded unreachable code: IL_0044, IL_004f, IL_0069, IL_0074, IL_008e, IL_0099, IL_00b3, IL_00be, IL_00d8, IL_00e3, IL_00fd, IL_0108, IL_0127, IL_0132, IL_014c, IL_0157, IL_0171, IL_017c, IL_0196, IL_01a1, IL_01bb, IL_01c6, IL_01e0, IL_01eb, IL_0205, IL_0210, IL_022a, IL_0235, IL_024f, IL_025a, IL_0274, IL_027f, IL_0299, IL_02a4, IL_02be, IL_02c9, IL_02e3, IL_02ee, IL_0308, IL_0313, IL_032d, IL_0338, IL_0352, IL_035d, IL_0377, IL_0382, IL_039c, IL_03a7, IL_03c1, IL_03cc, IL_03e6, IL_03f1, IL_040b, IL_0416, IL_0430, IL_043b, IL_0455, IL_0460, IL_047a, IL_0485, IL_049f, IL_04aa, IL_04c4, IL_04cf
		InitializeComponent();
		string json = Class7.smethod_0(Directory.GetCurrentDirectory() + "\\config.json");
		JObject jObject = JObject.Parse(json);
		_ = (bool)jObject["checkBoxDoiTenTkqc"];
		/*Error near IL_003f: Invalid metadata token*/;
	}

	private void E4AE0FAC(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = FD284831.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void DD91651E(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		textBoxBmIdVia.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void comboBoxAddBMOption_SelectedIndexChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		comboBoxAddBMOption.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void AF07AF02(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxSharePixel.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void A939BBB3(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		DE874420.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void textBoxPixelID_TextChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		textBoxPixelID.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void checkBoxDaQTV_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxDaQTV.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void radioButtonDaAll_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = radioButtonDaAll.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void B42FCEB6_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = B42FCEB6.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void checkBoxKichMomo_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxKichMomo.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void F71C40A5(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxPheDuyetPayment.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void checkBoxTatTBTkqc_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxTatTBTkqc.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void FCB016AB(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxOutTkqc.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void D486A4A5_TextChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		D486A4A5.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void D42B0196_SelectedIndexChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		D42B0196.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void F23F3A22(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		_ = (int)E2BA331A.Value;
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void checkBoxDoiTTTkqc_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxDoiTTTkqc.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void B7085417(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		EEA01829.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void E1AD211B(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		comboBoxChangeTimezone.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void checkBoxShareTkqc_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxShareTkqc.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void D82B3210(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = radioButtonAdmin.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void radioButtonAdvertiser_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = radioButtonAdvertiser.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void radioButtonAnalyst_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = radioButtonAnalyst.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void textBoxUidViaNhan_TextChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		textBoxUidViaNhan.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void E821EDBD(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxAddTkqcToBmViaNhan.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void textBoxBmIdViaNhan_TextChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		textBoxBmIdViaNhan.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void textBoxTokenViaNhan_TextChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		textBoxTokenViaNhan.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void CE393839(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = A102F987.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void fDoiInfoTKQC_Load(object sender, EventArgs e)
	{
	}

	private void B321E5BD(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		textBoxChangeCountry.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_share_pixel.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_share_pixel.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_share_pixel.txt");
		}
		catch
		{
		}
	}

	private void CCBC670E(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_them_tkqc_vao_bm.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_them_tkqc_vao_bm.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_them_tkqc_vao_bm.txt");
		}
		catch
		{
		}
	}

	private void CF0753A2(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_share_tkqc.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_share_tkqc.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_share_tkqc.txt");
		}
		catch
		{
		}
	}

	private void F1A48218(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_doi_thong_tin_tkqc.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_doi_thong_tin_tkqc.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_doi_thong_tin_tkqc.txt");
		}
		catch
		{
		}
	}

	private void D00D2121(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_doi_ten_tkqc.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_doi_ten_tkqc.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_doi_ten_tkqc.txt");
		}
		catch
		{
		}
	}

	private void CA3EE1A9(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_phe_duyet_payment.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_phe_duyet_payment.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_phe_duyet_payment.txt");
		}
		catch
		{
		}
	}

	private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_kich_momo.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_kich_momo.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_kich_momo.txt");
		}
		catch
		{
		}
	}

	private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_tat_thong_bao_tkqc.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_tat_thong_bao_tkqc.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_tat_thong_bao_tkqc.txt");
		}
		catch
		{
		}
	}

	private void A3007302(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_out_tkqc.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_out_tkqc.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_out_tkqc.txt");
		}
		catch
		{
		}
	}

	private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\config\\uid_da_tkqc_theo_cau_hinh.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\config\\uid_da_tkqc_theo_cau_hinh.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\config\\uid_da_tkqc_theo_cau_hinh.txt");
		}
		catch
		{
		}
	}

	private void A92B6CA4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\config\\uid_khong_da_tkqc.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\config\\uid_khong_da_tkqc.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\config\\uid_khong_da_tkqc.txt");
		}
		catch
		{
		}
	}

	private void C6BC352A(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_da_qtv.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_da_qtv.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_da_qtv.txt");
		}
		catch
		{
		}
	}

	private void radioButtonDoiTT_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = radioButtonDoiTT.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void radioButtonTaoTKQCMoi_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = radioButtonTaoTKQCMoi.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void ADA3FE2D(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBox30days.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_check_xin_tin.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_check_xin_tin.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_check_xin_tin.txt");
		}
		catch
		{
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

	private void InitializeComponent()
	{
		this.comboBoxAddBMOption = new System.Windows.Forms.ComboBox();
		this.linkLabel9 = new System.Windows.Forms.LinkLabel();
		this.checkBoxOutTkqc = new System.Windows.Forms.CheckBox();
		this.linkLabel5 = new System.Windows.Forms.LinkLabel();
		this.checkBoxSharePixel = new System.Windows.Forms.CheckBox();
		this.DE874420 = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.textBoxPixelID = new System.Windows.Forms.TextBox();
		this.label8 = new System.Windows.Forms.Label();
		this.radioButtonAnalyst = new System.Windows.Forms.RadioButton();
		this.radioButtonAdvertiser = new System.Windows.Forms.RadioButton();
		this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
		this.label3 = new System.Windows.Forms.Label();
		this.textBoxUidViaNhan = new System.Windows.Forms.TextBox();
		this.linkLabel4 = new System.Windows.Forms.LinkLabel();
		this.checkBoxTatTBTkqc = new System.Windows.Forms.CheckBox();
		this.linkLabel2 = new System.Windows.Forms.LinkLabel();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.label6 = new System.Windows.Forms.Label();
		this.textBoxBmIdViaNhan = new System.Windows.Forms.TextBox();
		this.checkBoxAddTkqcToBmViaNhan = new System.Windows.Forms.CheckBox();
		this.label5 = new System.Windows.Forms.Label();
		this.textBoxBmIdVia = new System.Windows.Forms.TextBox();
		this.FD284831 = new System.Windows.Forms.CheckBox();
		this.D4245706 = new System.Windows.Forms.Label();
		this.textBoxTokenViaNhan = new System.Windows.Forms.TextBox();
		this.checkBoxShareTkqc = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		this.E2BA331A = new System.Windows.Forms.NumericUpDown();
		this.D42B0196 = new System.Windows.Forms.ComboBox();
		this.D486A4A5 = new System.Windows.Forms.TextBox();
		this.A102F987 = new System.Windows.Forms.CheckBox();
		this.linkLabel3 = new System.Windows.Forms.LinkLabel();
		this.F7B1CDA0 = new System.Windows.Forms.Label();
		this.checkBoxDoiTTTkqc = new System.Windows.Forms.CheckBox();
		this.EEA01829 = new System.Windows.Forms.ComboBox();
		this.comboBoxChangeTimezone = new System.Windows.Forms.ComboBox();
		this.linkLabel10 = new System.Windows.Forms.LinkLabel();
		this.label9 = new System.Windows.Forms.Label();
		this.linkLabel8 = new System.Windows.Forms.LinkLabel();
		this.A92B6CA4 = new System.Windows.Forms.LinkLabel();
		this.linkLabel6 = new System.Windows.Forms.LinkLabel();
		this.B42FCEB6 = new System.Windows.Forms.RadioButton();
		this.radioButtonDaAll = new System.Windows.Forms.RadioButton();
		this.checkBoxDaQTV = new System.Windows.Forms.CheckBox();
		this.linkLabel11 = new System.Windows.Forms.LinkLabel();
		this.checkBoxKichMomo = new System.Windows.Forms.CheckBox();
		this.F2BBCD25 = new System.Windows.Forms.LinkLabel();
		this.checkBoxPheDuyetPayment = new System.Windows.Forms.CheckBox();
		this.panel1 = new System.Windows.Forms.Panel();
		this.panel2 = new System.Windows.Forms.Panel();
		this.textBoxChangeCountry = new System.Windows.Forms.TextBox();
		this.B5123FB0 = new System.Windows.Forms.LinkLabel();
		this.panel3 = new System.Windows.Forms.Panel();
		this.radioButtonTaoTKQCMoi = new System.Windows.Forms.RadioButton();
		this.radioButtonDoiTT = new System.Windows.Forms.RadioButton();
		this.checkBox30days = new System.Windows.Forms.CheckBox();
		this.linkLabel14 = new System.Windows.Forms.LinkLabel();
		((System.ComponentModel.ISupportInitialize)this.E2BA331A).BeginInit();
		this.panel1.SuspendLayout();
		this.panel2.SuspendLayout();
		this.panel3.SuspendLayout();
		base.SuspendLayout();
		this.comboBoxAddBMOption.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.comboBoxAddBMOption.FormattingEnabled = true;
		this.comboBoxAddBMOption.Items.AddRange(new object[2] { "Dòng 1", "Dòng 2" });
		this.comboBoxAddBMOption.Location = new System.Drawing.Point(366, 182);
		this.comboBoxAddBMOption.Name = "comboBoxAddBMOption";
		this.comboBoxAddBMOption.Size = new System.Drawing.Size(133, 21);
		this.comboBoxAddBMOption.TabIndex = 211;
		this.comboBoxAddBMOption.SelectedIndexChanged += new System.EventHandler(comboBoxAddBMOption_SelectedIndexChanged);
		this.linkLabel9.AutoSize = true;
		this.linkLabel9.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel9.Location = new System.Drawing.Point(405, 318);
		this.linkLabel9.Name = "linkLabel9";
		this.linkLabel9.Size = new System.Drawing.Size(139, 14);
		this.linkLabel9.TabIndex = 210;
		this.linkLabel9.TabStop = true;
		this.linkLabel9.Text = "Mở file kết quả out tkqc";
		this.linkLabel9.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(A3007302);
		this.checkBoxOutTkqc.AutoSize = true;
		this.checkBoxOutTkqc.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxOutTkqc.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBoxOutTkqc.Location = new System.Drawing.Point(88, 317);
		this.checkBoxOutTkqc.Name = "checkBoxOutTkqc";
		this.checkBoxOutTkqc.Size = new System.Drawing.Size(101, 18);
		this.checkBoxOutTkqc.TabIndex = 209;
		this.checkBoxOutTkqc.Text = "Out khỏi tkqc";
		this.checkBoxOutTkqc.UseVisualStyleBackColor = true;
		this.checkBoxOutTkqc.CheckedChanged += new System.EventHandler(FCB016AB);
		this.linkLabel5.AutoSize = true;
		this.linkLabel5.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel5.Location = new System.Drawing.Point(505, 235);
		this.linkLabel5.Name = "linkLabel5";
		this.linkLabel5.Size = new System.Drawing.Size(149, 14);
		this.linkLabel5.TabIndex = 200;
		this.linkLabel5.TabStop = true;
		this.linkLabel5.Text = "Mở file kết quả share pixel";
		this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel5_LinkClicked);
		this.checkBoxSharePixel.AutoSize = true;
		this.checkBoxSharePixel.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxSharePixel.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBoxSharePixel.Location = new System.Drawing.Point(88, 213);
		this.checkBoxSharePixel.Name = "checkBoxSharePixel";
		this.checkBoxSharePixel.Size = new System.Drawing.Size(85, 18);
		this.checkBoxSharePixel.TabIndex = 197;
		this.checkBoxSharePixel.Text = "Share Pixel";
		this.checkBoxSharePixel.UseVisualStyleBackColor = true;
		this.checkBoxSharePixel.CheckedChanged += new System.EventHandler(AF07AF02);
		this.DE874420.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DE874420.Location = new System.Drawing.Point(159, 231);
		this.DE874420.Name = "textBoxBMIDPixel";
		this.DE874420.Size = new System.Drawing.Size(148, 21);
		this.DE874420.TabIndex = 198;
		this.DE874420.TextChanged += new System.EventHandler(A939BBB3);
		this.label7.AutoSize = true;
		this.label7.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label7.ForeColor = System.Drawing.Color.Black;
		this.label7.Location = new System.Drawing.Point(116, 234);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(40, 14);
		this.label7.TabIndex = 199;
		this.label7.Text = "Bm ID";
		this.textBoxPixelID.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBoxPixelID.Location = new System.Drawing.Point(366, 231);
		this.textBoxPixelID.Name = "textBoxPixelID";
		this.textBoxPixelID.Size = new System.Drawing.Size(133, 21);
		this.textBoxPixelID.TabIndex = 201;
		this.textBoxPixelID.TextChanged += new System.EventHandler(textBoxPixelID_TextChanged);
		this.label8.AutoSize = true;
		this.label8.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label8.ForeColor = System.Drawing.Color.Black;
		this.label8.Location = new System.Drawing.Point(315, 234);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(47, 14);
		this.label8.TabIndex = 202;
		this.label8.Text = "Pixel ID";
		this.radioButtonAnalyst.AutoSize = true;
		this.radioButtonAnalyst.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.radioButtonAnalyst.Location = new System.Drawing.Point(164, 3);
		this.radioButtonAnalyst.Name = "radioButtonAnalyst";
		this.radioButtonAnalyst.Size = new System.Drawing.Size(64, 18);
		this.radioButtonAnalyst.TabIndex = 196;
		this.radioButtonAnalyst.TabStop = true;
		this.radioButtonAnalyst.Text = "Analyst";
		this.radioButtonAnalyst.UseVisualStyleBackColor = true;
		this.radioButtonAnalyst.CheckedChanged += new System.EventHandler(radioButtonAnalyst_CheckedChanged);
		this.radioButtonAdvertiser.AutoSize = true;
		this.radioButtonAdvertiser.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.radioButtonAdvertiser.Location = new System.Drawing.Point(78, 3);
		this.radioButtonAdvertiser.Name = "radioButtonAdvertiser";
		this.radioButtonAdvertiser.Size = new System.Drawing.Size(80, 18);
		this.radioButtonAdvertiser.TabIndex = 195;
		this.radioButtonAdvertiser.TabStop = true;
		this.radioButtonAdvertiser.Text = "Advertiser";
		this.radioButtonAdvertiser.UseVisualStyleBackColor = true;
		this.radioButtonAdvertiser.CheckedChanged += new System.EventHandler(radioButtonAdvertiser_CheckedChanged);
		this.radioButtonAdmin.AutoSize = true;
		this.radioButtonAdmin.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.radioButtonAdmin.Location = new System.Drawing.Point(6, 3);
		this.radioButtonAdmin.Name = "radioButtonAdmin";
		this.radioButtonAdmin.Size = new System.Drawing.Size(59, 18);
		this.radioButtonAdmin.TabIndex = 194;
		this.radioButtonAdmin.TabStop = true;
		this.radioButtonAdmin.Text = "Admin";
		this.radioButtonAdmin.UseVisualStyleBackColor = true;
		this.radioButtonAdmin.CheckedChanged += new System.EventHandler(D82B3210);
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = System.Drawing.Color.Black;
		this.label3.Location = new System.Drawing.Point(436, 159);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(103, 14);
		this.label3.TabIndex = 193;
		this.label3.Text = "Token|Cookie Via";
		this.textBoxUidViaNhan.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBoxUidViaNhan.Location = new System.Drawing.Point(160, 129);
		this.textBoxUidViaNhan.Name = "textBoxUidViaNhan";
		this.textBoxUidViaNhan.Size = new System.Drawing.Size(148, 21);
		this.textBoxUidViaNhan.TabIndex = 192;
		this.textBoxUidViaNhan.TextChanged += new System.EventHandler(textBoxUidViaNhan_TextChanged);
		this.linkLabel4.AutoSize = true;
		this.linkLabel4.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel4.Location = new System.Drawing.Point(405, 340);
		this.linkLabel4.Name = "linkLabel4";
		this.linkLabel4.Size = new System.Drawing.Size(197, 14);
		this.linkLabel4.TabIndex = 191;
		this.linkLabel4.TabStop = true;
		this.linkLabel4.Text = "Mở file kết quả tắt thông báo tkqc";
		this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel4_LinkClicked);
		this.checkBoxTatTBTkqc.AutoSize = true;
		this.checkBoxTatTBTkqc.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxTatTBTkqc.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBoxTatTBTkqc.Location = new System.Drawing.Point(88, 339);
		this.checkBoxTatTBTkqc.Name = "checkBoxTatTBTkqc";
		this.checkBoxTatTBTkqc.Size = new System.Drawing.Size(134, 18);
		this.checkBoxTatTBTkqc.TabIndex = 190;
		this.checkBoxTatTBTkqc.Text = "Tắt thông báo tkqc";
		this.checkBoxTatTBTkqc.UseVisualStyleBackColor = true;
		this.checkBoxTatTBTkqc.CheckedChanged += new System.EventHandler(checkBoxTatTBTkqc_CheckedChanged);
		this.linkLabel2.AutoSize = true;
		this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel2.Location = new System.Drawing.Point(505, 186);
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.Size = new System.Drawing.Size(193, 14);
		this.linkLabel2.TabIndex = 189;
		this.linkLabel2.TabStop = true;
		this.linkLabel2.Text = "Mở file kết quả thêm tkqc vào bm";
		this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(CCBC670E);
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel1.Location = new System.Drawing.Point(731, 130);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(149, 14);
		this.linkLabel1.TabIndex = 188;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Mở file kết quả share tkqc";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(CF0753A2);
		this.label6.AutoSize = true;
		this.label6.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label6.ForeColor = System.Drawing.Color.Black;
		this.label6.Location = new System.Drawing.Point(499, 132);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(40, 14);
		this.label6.TabIndex = 187;
		this.label6.Text = "Bm ID";
		this.textBoxBmIdViaNhan.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBoxBmIdViaNhan.Location = new System.Drawing.Point(542, 129);
		this.textBoxBmIdViaNhan.Name = "textBoxBmIdViaNhan";
		this.textBoxBmIdViaNhan.Size = new System.Drawing.Size(183, 21);
		this.textBoxBmIdViaNhan.TabIndex = 186;
		this.textBoxBmIdViaNhan.TextChanged += new System.EventHandler(textBoxBmIdViaNhan_TextChanged);
		this.checkBoxAddTkqcToBmViaNhan.AutoSize = true;
		this.checkBoxAddTkqcToBmViaNhan.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxAddTkqcToBmViaNhan.Location = new System.Drawing.Point(315, 131);
		this.checkBoxAddTkqcToBmViaNhan.Name = "checkBoxAddTkqcToBmViaNhan";
		this.checkBoxAddTkqcToBmViaNhan.Size = new System.Drawing.Size(164, 18);
		this.checkBoxAddTkqcToBmViaNhan.TabIndex = 185;
		this.checkBoxAddTkqcToBmViaNhan.Text = "Add vào bm của via nhận";
		this.checkBoxAddTkqcToBmViaNhan.UseVisualStyleBackColor = true;
		this.checkBoxAddTkqcToBmViaNhan.CheckedChanged += new System.EventHandler(E821EDBD);
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = System.Drawing.Color.Black;
		this.label5.Location = new System.Drawing.Point(117, 185);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(40, 14);
		this.label5.TabIndex = 184;
		this.label5.Text = "Bm ID";
		this.textBoxBmIdVia.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBoxBmIdVia.Location = new System.Drawing.Point(160, 182);
		this.textBoxBmIdVia.Name = "textBoxBmIdVia";
		this.textBoxBmIdVia.Size = new System.Drawing.Size(148, 21);
		this.textBoxBmIdVia.TabIndex = 183;
		this.textBoxBmIdVia.TextChanged += new System.EventHandler(DD91651E);
		this.FD284831.AutoSize = true;
		this.FD284831.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FD284831.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.FD284831.Location = new System.Drawing.Point(88, 163);
		this.FD284831.Name = "checkBoxAddTkqcToBMVia";
		this.FD284831.Size = new System.Drawing.Size(228, 18);
		this.FD284831.TabIndex = 182;
		this.FD284831.Text = "Thêm tkqc vào bm của via đang cầm";
		this.FD284831.UseVisualStyleBackColor = true;
		this.FD284831.CheckedChanged += new System.EventHandler(E4AE0FAC);
		this.D4245706.AutoSize = true;
		this.D4245706.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.D4245706.ForeColor = System.Drawing.Color.Black;
		this.D4245706.Location = new System.Drawing.Point(113, 132);
		this.D4245706.Name = "label2";
		this.D4245706.Size = new System.Drawing.Size(44, 14);
		this.D4245706.TabIndex = 181;
		this.D4245706.Text = "Uid Via";
		this.textBoxTokenViaNhan.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBoxTokenViaNhan.Location = new System.Drawing.Point(542, 155);
		this.textBoxTokenViaNhan.Name = "textBoxTokenViaNhan";
		this.textBoxTokenViaNhan.Size = new System.Drawing.Size(183, 21);
		this.textBoxTokenViaNhan.TabIndex = 180;
		this.textBoxTokenViaNhan.TextChanged += new System.EventHandler(textBoxTokenViaNhan_TextChanged);
		this.checkBoxShareTkqc.AutoSize = true;
		this.checkBoxShareTkqc.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxShareTkqc.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBoxShareTkqc.Location = new System.Drawing.Point(88, 109);
		this.checkBoxShareTkqc.Name = "checkBoxShareTkqc";
		this.checkBoxShareTkqc.Size = new System.Drawing.Size(174, 18);
		this.checkBoxShareTkqc.TabIndex = 179;
		this.checkBoxShareTkqc.Text = "Share tkqc (yc đã kết bạn)";
		this.checkBoxShareTkqc.UseVisualStyleBackColor = true;
		this.checkBoxShareTkqc.CheckedChanged += new System.EventHandler(checkBoxShareTkqc_CheckedChanged);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.Color.Black;
		this.label1.Location = new System.Drawing.Point(100, 30);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(57, 14);
		this.label1.TabIndex = 178;
		this.label1.Text = "Tên tkqc";
		this.E2BA331A.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.E2BA331A.Location = new System.Drawing.Point(445, 27);
		this.E2BA331A.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.E2BA331A.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.E2BA331A.Name = "numericUpDownIndex";
		this.E2BA331A.Size = new System.Drawing.Size(54, 22);
		this.E2BA331A.TabIndex = 177;
		this.E2BA331A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.E2BA331A.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.E2BA331A.ValueChanged += new System.EventHandler(F23F3A22);
		this.D42B0196.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.D42B0196.FormattingEnabled = true;
		this.D42B0196.Items.AddRange(new object[4] { "None", "Random", "Theo stt", "Theo stt from" });
		this.D42B0196.Location = new System.Drawing.Point(315, 27);
		this.D42B0196.Name = "comboBoxTailName";
		this.D42B0196.Size = new System.Drawing.Size(124, 21);
		this.D42B0196.TabIndex = 176;
		this.D42B0196.SelectedIndexChanged += new System.EventHandler(D42B0196_SelectedIndexChanged);
		this.D486A4A5.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.D486A4A5.Location = new System.Drawing.Point(160, 27);
		this.D486A4A5.Name = "textBoxTenTkqc";
		this.D486A4A5.Size = new System.Drawing.Size(148, 21);
		this.D486A4A5.TabIndex = 175;
		this.D486A4A5.TextChanged += new System.EventHandler(D486A4A5_TextChanged);
		this.A102F987.AutoSize = true;
		this.A102F987.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A102F987.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.A102F987.Location = new System.Drawing.Point(88, 8);
		this.A102F987.Name = "checkBoxDoiTenTkqc";
		this.A102F987.Size = new System.Drawing.Size(94, 18);
		this.A102F987.TabIndex = 174;
		this.A102F987.Text = "Đổi tên tkqc";
		this.A102F987.UseVisualStyleBackColor = true;
		this.A102F987.CheckedChanged += new System.EventHandler(CE393839);
		this.linkLabel3.AutoSize = true;
		this.linkLabel3.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel3.Location = new System.Drawing.Point(504, 30);
		this.linkLabel3.Name = "linkLabel3";
		this.linkLabel3.Size = new System.Drawing.Size(159, 14);
		this.linkLabel3.TabIndex = 173;
		this.linkLabel3.TabStop = true;
		this.linkLabel3.Text = "Mở file kết quả đổi tên tkqc";
		this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(D00D2121);
		this.F7B1CDA0.AutoSize = true;
		this.F7B1CDA0.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.F7B1CDA0.ForeColor = System.Drawing.Color.Black;
		this.F7B1CDA0.Location = new System.Drawing.Point(100, 80);
		this.F7B1CDA0.Name = "label4";
		this.F7B1CDA0.Size = new System.Drawing.Size(57, 14);
		this.F7B1CDA0.TabIndex = 214;
		this.F7B1CDA0.Text = "Info tkqc";
		this.checkBoxDoiTTTkqc.AutoSize = true;
		this.checkBoxDoiTTTkqc.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxDoiTTTkqc.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBoxDoiTTTkqc.Location = new System.Drawing.Point(88, 57);
		this.checkBoxDoiTTTkqc.Name = "checkBoxDoiTTTkqc";
		this.checkBoxDoiTTTkqc.Size = new System.Drawing.Size(126, 18);
		this.checkBoxDoiTTTkqc.TabIndex = 212;
		this.checkBoxDoiTTTkqc.Text = "Đổi thông tin tkqc";
		this.checkBoxDoiTTTkqc.UseVisualStyleBackColor = true;
		this.checkBoxDoiTTTkqc.CheckedChanged += new System.EventHandler(checkBoxDoiTTTkqc_CheckedChanged);
		this.EEA01829.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.EEA01829.FormattingEnabled = true;
		this.EEA01829.Items.AddRange(new object[56]
		{
			"", "{1}UAE Dirham (AED)", "{2}Argentine Peso (ARS)", "{3}Australian Dollar (AUD)", "{4}Bangladeshi Taka (BDT)", "{5}Bolivian Boliviano (BOB)", "{6}Brazilian Real (BRL)", "{7}Canadian Dollar (CAD)", "{8}Swiss Franc (CHF)", "{9}Chilean Peso (CLP)",
			"{10}Chinese Yuan (CNY)", "{11}Colombian Peso (COP)", "{12}Costa Rican Col?n (CRC)", "{13}Czech Koruna (CZK)", "{14}Danish Krone (DKK)", "{15}Algerian Dinar (DZD)", "{16}Egyptian Pound (EGP)", "{17}Euro (EUR)", "{18}British Pound (GBP)", "{19}Guatemalan Quetzal (GTQ)",
			"{20}Hong Kong Dollar (HKD)", "{21}Honduran Lempira (HNL)", "{22}Hungarian Forint (HUF)", "{23}Indonesian Rupiah (IDR)", "{24}Israeli New Shekel (ILS)", "{25}Indian Rupee (INR)", "{26}Iceland Krona (ISK)", "{27}Japanese Yen (JPY)", "{28}Kenyan Shilling (KES)", "{29}Korean Won (KRW)",
			"{30}Macau Patacas (MOP)", "{31}Mexican Peso (MXN)", "{32}Malaysian Ringgit (MYR)", "{33}Nigerian Naira (NGN)", "{34}Nicaraguan Cordoba (NIO)", "{35}Norwegian Krone (NOK)", "{36}New Zealand Dollar (NZD)", "{37}Peruvian Nuevo Sol (PEN)", "{38}Philippine Peso (PHP)", "{39}Pakistani Rupee (PKR)",
			"{40}Polish Zloty (PLN)", "{41}Paraguayan Guarani (PYG)", "{42}Qatari Rials (QAR)", "{43}Romanian Leu (RON)", "{44}Russian Ruble (RUB)", "{45}Saudi Arabian Riyal (SAR)", "{46}Swedish Krona (SEK)", "{47}Singapore Dollar (SGD)", "{48}Thai Baht (THB)", "{49}Turkish Lira (TRY)",
			"{50}Taiwan Dollar (TWD)", "{51}US Dollars (USD)", "{52}Uruguay Peso (UYU)", "{53}Vietnamese Dong (VND)", "{54}South African Rand (ZAR)", "{55}Ucraina Hryvnia (UAH)"
		});
		this.EEA01829.Location = new System.Drawing.Point(314, 76);
		this.EEA01829.Name = "comboBoxChangeCurrency";
		this.EEA01829.Size = new System.Drawing.Size(185, 21);
		this.EEA01829.TabIndex = 216;
		this.EEA01829.SelectedIndexChanged += new System.EventHandler(B7085417);
		this.comboBoxChangeTimezone.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.comboBoxChangeTimezone.FormattingEnabled = true;
		this.comboBoxChangeTimezone.Items.AddRange(new object[147]
		{
			"", "\"America/Los_Angeles\":{Pacific -07:00}", "\"America/Denver\":{Mountain -06:00}", "\"Pacific/Honolulu\":{Hawaii -10:00}", "\"America/Anchorage\":{Alaska -08:00}", "\"America/Phoenix\":{Mountain Standard Time (Arizona)\" \"-07:00}", "\"America/Chicago\":{Central -05:00}", "\"America/New_York\":{Eastern -04:00}", "\"Asia/Dubai\":{Dubai +04:00}", "\"America/Argentina/San_Luis\":{San Luis -03:00}",
			"\"America/Argentina/Buenos_Aires\":{Buenos Aires -03:00}", "\"America/Argentina/Salta\":{Salta -03:00}", "\"Europe/Vienna\":{Vienna +02:00}", "\"Australia/Perth\":{Perth +08:00}", "\"Australia/Broken_Hill\":{Broken Hill +09:30}", "\"Australia/Sydney\":{Sydney +10:00}", "\"Europe/Sarajevo\":{Sarajevo +02:00}", "\"Asia/Dhaka\":{Dhaka +06:00}", "\"Europe/Brussels\":{Brussels +02:00}", "\"Europe/Sofia\":{Sofia +03:00}",
			"\"Asia/Bahrain\":{Bahrain +03:00}", "\"America/La_Paz\":{La Paz -04:00}", "\"America/Noronha\":{Noronha -02:00}", "\"America/Campo_Grande\":{Campo Grande -04:00}", "\"America/Belem\":{Belem -03:00}", "\"America/Sao_Paulo\":{Sao Paulo -03:00}", "\"America/Nassau\":{Nassau -04:00}", "\"America/Dawson\":{Dawson -07:00}", "\"America/Vancouver\":{Vancouver -07:00}", "\"America/Dawson_Creek\":{Dawson Creek -07:00}",
			"\"America/Edmonton\":{Edmonton -06:00}", "\"America/Rainy_River\":{Rainy River -05:00}", "\"America/Regina\":{Regina -06:00}", "\"America/Atikokan\":{Atikokan -05:00}", "\"America/Iqaluit\":{Iqaluit -04:00}", "\"America/Toronto\":{Toronto -04:00}", "\"America/Blanc-Sablon\":{Blanc-Sablon -04:00}", "\"America/Halifax\":{Halifax -03:00}", "\"America/St_Johns\":{St Johns -02:30}", "\"Europe/Zurich\":{Zurich +02:00}",
			"\"Pacific/Easter\":{Easter Island -06:00}", "\"America/Santiago\":{Santiago -04:00}", "\"Asia/Shanghai\":{Beijing +08:00}", "\"America/Bogota\":{Bogota -05:00}", "\"America/Costa_Rica\":{Costa Rica -06:00}", "\"Asia/Nicosia\":{Nicosia +03:00}", "\"Europe/Prague\":{Prague +02:00}", "\"Europe/Berlin\":{Berlin +02:00}", "\"Europe/Copenhagen\":{Copenhagen +02:00}", "\"America/Santo_Domingo\":{Santo Domingo -04:00}",
			"\"Pacific/Galapagos\":{Galapagos -06:00}", "\"America/Guayaquil\":{Guayaquil -05:00}", "\"Europe/Tallinn\":{Tallinn +03:00}", "\"Africa/Cairo\":{Cairo +02:00}", "\"Atlantic/Canary\":{Canary +01:00}", "\"Europe/Madrid\":{Madrid +02:00}", "\"Europe/Helsinki\":{Helsinki +03:00}", "\"Europe/Paris\":{Paris +02:00}", "\"Europe/London\":{London +01:00}", "\"Africa/Accra\":{Accra +00:00}",
			"\"Europe/Athens\":{Athens +03:00}", "\"America/Guatemala\":{Guatemala -06:00}", "\"Asia/Hong_Kong\":{Hong Kong +08:00}", "\"America/Tegucigalpa\":{Tegucigalpa -06:00}", "\"Europe/Zagreb\":{Zagreb +02:00}", "\"Europe/Budapest\":{Budapest +02:00}", "\"Asia/Jakarta\":{Jakarta +07:00}", "\"Asia/Makassar\":{Makassar +08:00}", "\"Asia/Jayapura\":{Jayapura +09:00}", "\"Europe/Dublin\":{Dublin +01:00}",
			"\"Asia/Jerusalem\":{Jerusalem +03:00}", "\"Asia/Kolkata\":{Kolkata +05:30}", "\"Asia/Baghdad\":{Baghdad +03:00}", "\"Atlantic/Reykjavik\":{Reykjavik +00:00}", "\"Europe/Rome\":{Rome +02:00}", "\"America/Jamaica\":{Jamaica -05:00}", "\"Asia/Amman\":{Amman +03:00}", "\"Asia/Tokyo\":{Tokyo +09:00}", "\"Africa/Nairobi\":{Nairobi +03:00}", "\"Asia/Seoul\":{Seoul +09:00}",
			"\"Asia/Kuwait\":{Kuwait +03:00}", "\"Asia/Beirut\":{Beirut +03:00}", "\"Asia/Colombo\":{Colombo +05:30}", "\"Europe/Vilnius\":{Vilnius +03:00}", "\"Europe/Luxembourg\":{Luxembourg +02:00}", "\"Europe/Riga\":{Riga +03:00}", "\"Africa/Casablanca\":{Casablanca +00:00}", "\"Europe/Skopje\":{Skopje +02:00}", "\"Europe/Malta\":{Malta +02:00}", "\"Indian/Mauritius\":{Mauritius +04:00}",
			"\"Indian/Maldives\":{Maldives +05:00}", "\"America/Tijuana\":{Tijuana -07:00}", "\"America/Hermosillo\":{Hermosillo -07:00}", "\"America/Mazatlan\":{Mazatlan -06:00}", "\"America/Mexico_City\":{Mexico City -05:00}", "\"Asia/Kuala_Lumpur\":{Kuala Lumpur +08:00}", "\"Africa/Lagos\":{Lagos +01:00}", "\"America/Managua\":{Managua -06:00}", "\"Europe/Amsterdam\":{Amsterdam +02:00}", "\"Europe/Oslo\":{Oslo +02:00}",
			"\"Pacific/Auckland\":{Auckland +12:00}", "\"Asia/Muscat\":{Muscat +04:00}", "\"America/Panama\":{Panama -05:00}", "\"America/Lima\":{Lima -05:00}", "\"Asia/Manila\":{Manila +08:00}", "\"Asia/Karachi\":{Karachi +05:00}", "\"Europe/Warsaw\":{Warsaw +02:00}", "\"America/Puerto_Rico\":{Puerto Rico -04:00}", "\"Asia/Gaza\":{Gaza +03:00}", "\"Atlantic/Azores\":{Azores +00:00}",
			"\"Europe/Lisbon\":{Lisbon +01:00}", "\"America/Asuncion\":{Asuncion -04:00}", "\"Asia/Qatar\":{Qatar +03:00}", "\"Europe/Bucharest\":{Bucharest +03:00}", "\"Europe/Belgrade\":{Belgrade +02:00}", "\"Europe/Kaliningrad\":{Kaliningrad +02:00}", "\"Europe/Moscow\":{Moscow +03:00}", "\"Europe/Samara\":{Samara +04:00}", "\"Asia/Yekaterinburg\":{Yekaterinburg +05:00}", "\"Asia/Omsk\":{Omsk +06:00}",
			"\"Asia/Krasnoyarsk\":{Krasnoyarsk +07:00}", "\"Asia/Irkutsk\":{Irkutsk +08:00}", "\"Asia/Yakutsk\":{Yakutsk +09:00}", "\"Asia/Vladivostok\":{Vladivostok +10:00}", "\"Asia/Magadan\":{Magadan +11:00}", "\"Asia/Kamchatka\":{Kamchatka +12:00}", "\"Asia/Riyadh\":{Riyadh +03:00}", "\"Europe/Stockholm\":{Stockholm +02:00}", "\"Asia/Singapore\":{Singapore +08:00}", "\"Europe/Ljubljana\":{Ljubljana +02:00}",
			"\"Europe/Bratislava\":{Bratislava +02:00}", "\"America/El_Salvador\":{El Salvador -06:00}", "\"Asia/Bangkok\":{Bangkok +07:00}", "\"Africa/Tunis\":{Tunis +01:00}", "\"Europe/Istanbul\":{Istanbul +03:00}", "\"America/Port_of_Spain\":{Port of Spain -04:00}", "\"Asia/Taipei\":{Taipei +08:00}", "\"Europe/Kiev\":{Kiev +03:00}", "\"America/Montevideo\":{Montevideo -03:00}", "\"America/Caracas\":{Caracas -04:00}",
			"\"Asia/Ho_Chi_Minh\":{Ho Chi Minh +07:00}", "\"Africa/Johannesburg\":{Johannesburg +02:00}", "\"America/Winnipeg\":{Winnipeg -05:00}", "\"America/Detroit\":{Detroit -04:00}", "\"Australia/Melbourne\":{Melbourne +10:00}", "\"Asia/Kathmandu\":{Kathmandu +05:45}", "\"Asia/Baku\":{Baku +04:00}"
		});
		this.comboBoxChangeTimezone.Location = new System.Drawing.Point(505, 76);
		this.comboBoxChangeTimezone.Name = "comboBoxChangeTimezone";
		this.comboBoxChangeTimezone.Size = new System.Drawing.Size(220, 21);
		this.comboBoxChangeTimezone.TabIndex = 217;
		this.comboBoxChangeTimezone.SelectedIndexChanged += new System.EventHandler(E1AD211B);
		this.linkLabel10.AutoSize = true;
		this.linkLabel10.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel10.Location = new System.Drawing.Point(731, 80);
		this.linkLabel10.Name = "linkLabel10";
		this.linkLabel10.Size = new System.Drawing.Size(163, 14);
		this.linkLabel10.TabIndex = 218;
		this.linkLabel10.TabStop = true;
		this.linkLabel10.Text = "Mở file kết quả đổi thông tin";
		this.linkLabel10.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(F1A48218);
		this.label9.AutoSize = true;
		this.label9.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label9.ForeColor = System.Drawing.Color.Black;
		this.label9.Location = new System.Drawing.Point(320, 185);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(35, 14);
		this.label9.TabIndex = 219;
		this.label9.Text = "Type";
		this.linkLabel8.AutoSize = true;
		this.linkLabel8.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel8.Location = new System.Drawing.Point(753, 286);
		this.linkLabel8.Name = "linkLabel8";
		this.linkLabel8.Size = new System.Drawing.Size(105, 14);
		this.linkLabel8.TabIndex = 225;
		this.linkLabel8.TabStop = true;
		this.linkLabel8.Text = "Mở file kết quả đá";
		this.linkLabel8.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(C6BC352A);
		this.A92B6CA4.AutoSize = true;
		this.A92B6CA4.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A92B6CA4.Location = new System.Drawing.Point(579, 286);
		this.A92B6CA4.Name = "linkLabel7";
		this.A92B6CA4.Size = new System.Drawing.Size(162, 14);
		this.A92B6CA4.TabIndex = 224;
		this.A92B6CA4.TabStop = true;
		this.A92B6CA4.Text = "Cấu hình uid ngoại trừ ko đá";
		this.A92B6CA4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(A92B6CA4_LinkClicked);
		this.linkLabel6.AutoSize = true;
		this.linkLabel6.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel6.Location = new System.Drawing.Point(405, 286);
		this.linkLabel6.Name = "linkLabel6";
		this.linkLabel6.Size = new System.Drawing.Size(167, 14);
		this.linkLabel6.TabIndex = 223;
		this.linkLabel6.TabStop = true;
		this.linkLabel6.Text = "Cấu hình đá theo uid chỉ định";
		this.linkLabel6.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel6_LinkClicked);
		this.B42FCEB6.AutoSize = true;
		this.B42FCEB6.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B42FCEB6.Location = new System.Drawing.Point(104, 3);
		this.B42FCEB6.Name = "radioButtonDaTheoCustome";
		this.B42FCEB6.Size = new System.Drawing.Size(139, 18);
		this.B42FCEB6.TabIndex = 222;
		this.B42FCEB6.TabStop = true;
		this.B42FCEB6.Text = "Đá theo uid cấu hình";
		this.B42FCEB6.UseVisualStyleBackColor = true;
		this.B42FCEB6.CheckedChanged += new System.EventHandler(B42FCEB6_CheckedChanged);
		this.radioButtonDaAll.AutoSize = true;
		this.radioButtonDaAll.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.radioButtonDaAll.Location = new System.Drawing.Point(3, 3);
		this.radioButtonDaAll.Name = "radioButtonDaAll";
		this.radioButtonDaAll.Size = new System.Drawing.Size(97, 18);
		this.radioButtonDaAll.TabIndex = 221;
		this.radioButtonDaAll.TabStop = true;
		this.radioButtonDaAll.Text = "Đá tất cả qtv";
		this.radioButtonDaAll.UseVisualStyleBackColor = true;
		this.radioButtonDaAll.CheckedChanged += new System.EventHandler(radioButtonDaAll_CheckedChanged);
		this.checkBoxDaQTV.AutoSize = true;
		this.checkBoxDaQTV.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxDaQTV.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBoxDaQTV.Location = new System.Drawing.Point(88, 263);
		this.checkBoxDaQTV.Name = "checkBoxDaQTV";
		this.checkBoxDaQTV.Size = new System.Drawing.Size(140, 18);
		this.checkBoxDaQTV.TabIndex = 220;
		this.checkBoxDaQTV.Text = "Đá quản trị viên tkqc";
		this.checkBoxDaQTV.UseVisualStyleBackColor = true;
		this.checkBoxDaQTV.CheckedChanged += new System.EventHandler(checkBoxDaQTV_CheckedChanged);
		this.linkLabel11.AutoSize = true;
		this.linkLabel11.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel11.Location = new System.Drawing.Point(405, 361);
		this.linkLabel11.Name = "linkLabel11";
		this.linkLabel11.Size = new System.Drawing.Size(151, 14);
		this.linkLabel11.TabIndex = 229;
		this.linkLabel11.TabStop = true;
		this.linkLabel11.Text = "Mở file kết quả kích momo";
		this.linkLabel11.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel11_LinkClicked);
		this.checkBoxKichMomo.AutoSize = true;
		this.checkBoxKichMomo.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxKichMomo.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBoxKichMomo.Location = new System.Drawing.Point(88, 360);
		this.checkBoxKichMomo.Name = "checkBoxKichMomo";
		this.checkBoxKichMomo.Size = new System.Drawing.Size(86, 18);
		this.checkBoxKichMomo.TabIndex = 228;
		this.checkBoxKichMomo.Text = "Kích momo";
		this.checkBoxKichMomo.UseVisualStyleBackColor = true;
		this.checkBoxKichMomo.CheckedChanged += new System.EventHandler(checkBoxKichMomo_CheckedChanged);
		this.F2BBCD25.AutoSize = true;
		this.F2BBCD25.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.F2BBCD25.Location = new System.Drawing.Point(405, 382);
		this.F2BBCD25.Name = "linkLabel12";
		this.F2BBCD25.Size = new System.Drawing.Size(201, 14);
		this.F2BBCD25.TabIndex = 227;
		this.F2BBCD25.TabStop = true;
		this.F2BBCD25.Text = "Mở file kết quả phê duyệt payment";
		this.F2BBCD25.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(CA3EE1A9);
		this.checkBoxPheDuyetPayment.AutoSize = true;
		this.checkBoxPheDuyetPayment.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxPheDuyetPayment.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBoxPheDuyetPayment.Location = new System.Drawing.Point(88, 381);
		this.checkBoxPheDuyetPayment.Name = "checkBoxPheDuyetPayment";
		this.checkBoxPheDuyetPayment.Size = new System.Drawing.Size(135, 18);
		this.checkBoxPheDuyetPayment.TabIndex = 226;
		this.checkBoxPheDuyetPayment.Text = "Phê duyệt payment";
		this.checkBoxPheDuyetPayment.UseVisualStyleBackColor = true;
		this.checkBoxPheDuyetPayment.CheckedChanged += new System.EventHandler(F71C40A5);
		this.panel1.Controls.Add(this.B42FCEB6);
		this.panel1.Controls.Add(this.radioButtonDaAll);
		this.panel1.Location = new System.Drawing.Point(154, 281);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(252, 22);
		this.panel1.TabIndex = 230;
		this.panel2.Controls.Add(this.radioButtonAnalyst);
		this.panel2.Controls.Add(this.radioButtonAdmin);
		this.panel2.Controls.Add(this.radioButtonAdvertiser);
		this.panel2.Location = new System.Drawing.Point(266, 105);
		this.panel2.Name = "panel2";
		this.panel2.Size = new System.Drawing.Size(259, 22);
		this.panel2.TabIndex = 231;
		this.textBoxChangeCountry.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBoxChangeCountry.Location = new System.Drawing.Point(160, 76);
		this.textBoxChangeCountry.Name = "textBoxChangeCountry";
		this.textBoxChangeCountry.Size = new System.Drawing.Size(148, 21);
		this.textBoxChangeCountry.TabIndex = 232;
		this.textBoxChangeCountry.TextChanged += new System.EventHandler(B321E5BD);
		this.B5123FB0.AutoSize = true;
		this.B5123FB0.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B5123FB0.Location = new System.Drawing.Point(369, 209);
		this.B5123FB0.Name = "linkLabel13";
		this.B5123FB0.Size = new System.Drawing.Size(159, 14);
		this.B5123FB0.TabIndex = 233;
		this.B5123FB0.TabStop = true;
		this.B5123FB0.Text = "Mở file kết quả đổi tên tkqc";
		this.panel3.Controls.Add(this.radioButtonTaoTKQCMoi);
		this.panel3.Controls.Add(this.radioButtonDoiTT);
		this.panel3.Location = new System.Drawing.Point(221, 54);
		this.panel3.Name = "panel3";
		this.panel3.Size = new System.Drawing.Size(312, 22);
		this.panel3.TabIndex = 246;
		this.radioButtonTaoTKQCMoi.AutoSize = true;
		this.radioButtonTaoTKQCMoi.Location = new System.Drawing.Point(199, 1);
		this.radioButtonTaoTKQCMoi.Name = "radioButtonTaoTKQCMoi";
		this.radioButtonTaoTKQCMoi.Size = new System.Drawing.Size(100, 20);
		this.radioButtonTaoTKQCMoi.TabIndex = 244;
		this.radioButtonTaoTKQCMoi.TabStop = true;
		this.radioButtonTaoTKQCMoi.Text = "Tạo tkqc mới";
		this.radioButtonTaoTKQCMoi.UseVisualStyleBackColor = true;
		this.radioButtonTaoTKQCMoi.CheckedChanged += new System.EventHandler(radioButtonTaoTKQCMoi_CheckedChanged);
		this.radioButtonDoiTT.AutoSize = true;
		this.radioButtonDoiTT.Location = new System.Drawing.Point(4, 1);
		this.radioButtonDoiTT.Name = "radioButtonDoiTT";
		this.radioButtonDoiTT.Size = new System.Drawing.Size(189, 20);
		this.radioButtonDoiTT.TabIndex = 243;
		this.radioButtonDoiTT.TabStop = true;
		this.radioButtonDoiTT.Text = "Chỉ đổi thông tin, ko tạo tkqc";
		this.radioButtonDoiTT.UseVisualStyleBackColor = true;
		this.radioButtonDoiTT.CheckedChanged += new System.EventHandler(radioButtonDoiTT_CheckedChanged);
		this.checkBox30days.AutoSize = true;
		this.checkBox30days.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBox30days.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBox30days.Location = new System.Drawing.Point(88, 402);
		this.checkBox30days.Name = "checkBox30days";
		this.checkBox30days.Size = new System.Drawing.Size(205, 18);
		this.checkBox30days.TabIndex = 247;
		this.checkBox30days.Text = "Check xin tín (check tkqc có tín)";
		this.checkBox30days.UseVisualStyleBackColor = true;
		this.checkBox30days.CheckedChanged += new System.EventHandler(ADA3FE2D);
		this.linkLabel14.AutoSize = true;
		this.linkLabel14.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel14.Location = new System.Drawing.Point(405, 403);
		this.linkLabel14.Name = "linkLabel14";
		this.linkLabel14.Size = new System.Drawing.Size(161, 14);
		this.linkLabel14.TabIndex = 248;
		this.linkLabel14.TabStop = true;
		this.linkLabel14.Text = "Mở file kết quả check xin tín";
		this.linkLabel14.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel14_LinkClicked);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(896, 455);
		base.Controls.Add(this.linkLabel14);
		base.Controls.Add(this.checkBox30days);
		base.Controls.Add(this.panel3);
		base.Controls.Add(this.B5123FB0);
		base.Controls.Add(this.textBoxChangeCountry);
		base.Controls.Add(this.panel2);
		base.Controls.Add(this.panel1);
		base.Controls.Add(this.linkLabel11);
		base.Controls.Add(this.checkBoxKichMomo);
		base.Controls.Add(this.F2BBCD25);
		base.Controls.Add(this.checkBoxPheDuyetPayment);
		base.Controls.Add(this.linkLabel8);
		base.Controls.Add(this.A92B6CA4);
		base.Controls.Add(this.linkLabel6);
		base.Controls.Add(this.checkBoxDaQTV);
		base.Controls.Add(this.label9);
		base.Controls.Add(this.linkLabel10);
		base.Controls.Add(this.comboBoxChangeTimezone);
		base.Controls.Add(this.EEA01829);
		base.Controls.Add(this.F7B1CDA0);
		base.Controls.Add(this.checkBoxDoiTTTkqc);
		base.Controls.Add(this.comboBoxAddBMOption);
		base.Controls.Add(this.linkLabel9);
		base.Controls.Add(this.checkBoxOutTkqc);
		base.Controls.Add(this.linkLabel5);
		base.Controls.Add(this.checkBoxSharePixel);
		base.Controls.Add(this.DE874420);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.textBoxPixelID);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.textBoxUidViaNhan);
		base.Controls.Add(this.linkLabel4);
		base.Controls.Add(this.checkBoxTatTBTkqc);
		base.Controls.Add(this.linkLabel2);
		base.Controls.Add(this.linkLabel1);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.textBoxBmIdViaNhan);
		base.Controls.Add(this.checkBoxAddTkqcToBmViaNhan);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.textBoxBmIdVia);
		base.Controls.Add(this.FD284831);
		base.Controls.Add(this.D4245706);
		base.Controls.Add(this.textBoxTokenViaNhan);
		base.Controls.Add(this.checkBoxShareTkqc);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.E2BA331A);
		base.Controls.Add(this.D42B0196);
		base.Controls.Add(this.D486A4A5);
		base.Controls.Add(this.A102F987);
		base.Controls.Add(this.linkLabel3);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fDoiInfoTKQC";
		this.Text = "fDoiInfoTKQC";
		base.Load += new System.EventHandler(fDoiInfoTKQC_Load);
		((System.ComponentModel.ISupportInitialize)this.E2BA331A).EndInit();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.panel2.ResumeLayout(false);
		this.panel2.PerformLayout();
		this.panel3.ResumeLayout(false);
		this.panel3.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
