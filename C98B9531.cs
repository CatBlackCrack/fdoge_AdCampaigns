using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

public class C98B9531 : Form
{
	private IContainer icontainer_0 = null;

	private Panel panel1;

	private Panel A3AF8325;

	private Label label1;

	private ComboBox comboBoxProxy;

	private LinkLabel CD396A8E;

	private Panel D2207F10;

	private RadioButton radioButtonAddThe;

	private RadioButton F18B4C02;

	private RadioButton radioButtonEditInfoTKQC;

	private Label label3;

	private Label EC0B781F;

	private TextBox textBoxCookie;

	private LinkLabel linkLabel3;

	private Label label5;

	private TextBox ED220007;

	private GroupBox groupBox1;

	private RadioButton radioButtonEditInfoBM;

	public C98B9531()
	{
		//Discarded unreachable code: IL_0044, IL_004f, IL_0069, IL_0074, IL_008e, IL_0099, IL_00b3, IL_00be, IL_00d8, IL_00e3, IL_00fd, IL_0108, IL_0122, IL_012d
		InitializeComponent();
		string json = Class7.smethod_0(Directory.GetCurrentDirectory() + "\\config.json");
		JObject jObject = JObject.Parse(json);
		jObject["comboBoxProxy"].ToString();
		/*Error near IL_003f: Invalid metadata token*/;
	}

	private void comboBoxProxy_SelectedIndexChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0038, IL_0042
		if (comboBoxProxy.SelectedIndex == -1)
		{
			MessageBox.Show("Chọn không hợp lệ !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
		comboBoxProxy.Text.Trim();
		/*Error near IL_0033: Invalid metadata token*/;
	}

	private void CD396A8E_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\proxy.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\proxy.txt", "");
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\proxy.txt");
		}
		catch
		{
		}
	}

	private void BC2CF694(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\userAgent.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\userAgent.txt", "");
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\userAgent.txt");
		}
		catch
		{
		}
	}

	private void method_0(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("chrome.exe", "https://plus24h.com/download/getcookie.zip");
		}
		catch
		{
			Process.Start("https://plus24h.com/download/getcookie.zip");
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("chrome.exe", "https://plus24h.com/fplus/downloadgetcookieforfplus");
		}
		catch
		{
			Process.Start("https://plus24h.com/fplus/downloadgetcookieforfplus");
		}
	}

	private void textBoxCookie_TextChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		textBoxCookie.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void ED220007_TextChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		ED220007.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void method_1(object D51D8C25)
	{
		if (A3AF8325.Controls.Count > 0)
		{
			A3AF8325.Controls.RemoveAt(0);
		}
		Form form = D51D8C25 as Form;
		form.TopLevel = false;
		form.Dock = DockStyle.Fill;
		A3AF8325.Controls.Add(form);
		A3AF8325.Tag = form;
		form.Show();
	}

	private void F18B4C02_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_001e, IL_0026, IL_0030
		method_1(new fAdCampaigns());
		if (F18B4C02.Checked)
		{
			_ = 1;
			/*Error near IL_0019: Invalid metadata token*/;
		}
		_ = 0;
		/*Error near IL_0021: Invalid metadata token*/;
	}

	private void FE38AC0D(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_001e, IL_0026, IL_0030
		method_1(new fDoiInfoTKQC());
		if (radioButtonEditInfoTKQC.Checked)
		{
			_ = 1;
			/*Error near IL_0019: Invalid metadata token*/;
		}
		_ = 0;
		/*Error near IL_0021: Invalid metadata token*/;
	}

	private void radioButtonAddThe_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_001e, IL_0026, IL_0030
		method_1(new fAddThe());
		if (radioButtonAddThe.Checked)
		{
			_ = 1;
			/*Error near IL_0019: Invalid metadata token*/;
		}
		_ = 0;
		/*Error near IL_0021: Invalid metadata token*/;
	}

	private void D1A62A07(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_001e, IL_0026, IL_0030
		method_1(new fEditInfoBM());
		if (radioButtonEditInfoBM.Checked)
		{
			_ = 1;
			/*Error near IL_0019: Invalid metadata token*/;
		}
		_ = 0;
		/*Error near IL_0021: Invalid metadata token*/;
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
		this.panel1 = new System.Windows.Forms.Panel();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.label5 = new System.Windows.Forms.Label();
		this.CD396A8E = new System.Windows.Forms.LinkLabel();
		this.ED220007 = new System.Windows.Forms.TextBox();
		this.linkLabel3 = new System.Windows.Forms.LinkLabel();
		this.label1 = new System.Windows.Forms.Label();
		this.EC0B781F = new System.Windows.Forms.Label();
		this.comboBoxProxy = new System.Windows.Forms.ComboBox();
		this.textBoxCookie = new System.Windows.Forms.TextBox();
		this.D2207F10 = new System.Windows.Forms.Panel();
		this.radioButtonEditInfoBM = new System.Windows.Forms.RadioButton();
		this.radioButtonAddThe = new System.Windows.Forms.RadioButton();
		this.F18B4C02 = new System.Windows.Forms.RadioButton();
		this.radioButtonEditInfoTKQC = new System.Windows.Forms.RadioButton();
		this.label3 = new System.Windows.Forms.Label();
		this.A3AF8325 = new System.Windows.Forms.Panel();
		this.panel1.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.D2207F10.SuspendLayout();
		base.SuspendLayout();
		this.panel1.Controls.Add(this.groupBox1);
		this.panel1.Controls.Add(this.D2207F10);
		this.panel1.Controls.Add(this.A3AF8325);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(973, 601);
		this.panel1.TabIndex = 0;
		this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
		this.groupBox1.Controls.Add(this.label5);
		this.groupBox1.Controls.Add(this.CD396A8E);
		this.groupBox1.Controls.Add(this.ED220007);
		this.groupBox1.Controls.Add(this.linkLabel3);
		this.groupBox1.Controls.Add(this.label1);
		this.groupBox1.Controls.Add(this.EC0B781F);
		this.groupBox1.Controls.Add(this.comboBoxProxy);
		this.groupBox1.Controls.Add(this.textBoxCookie);
		this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(192, 64, 0);
		this.groupBox1.Location = new System.Drawing.Point(20, 13);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(914, 104);
		this.groupBox1.TabIndex = 9;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Cấu hình proxy, tài khoản Facebook";
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.label5.Location = new System.Drawing.Point(40, 81);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(46, 14);
		this.label5.TabIndex = 73;
		this.label5.Text = "Token:";
		this.CD396A8E.AutoSize = true;
		this.CD396A8E.Location = new System.Drawing.Point(270, 30);
		this.CD396A8E.Name = "linkLabel1";
		this.CD396A8E.Size = new System.Drawing.Size(37, 14);
		this.CD396A8E.TabIndex = 7;
		this.CD396A8E.TabStop = true;
		this.CD396A8E.Text = "Open";
		this.CD396A8E.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(CD396A8E_LinkClicked);
		this.ED220007.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.ED220007.Location = new System.Drawing.Point(88, 77);
		this.ED220007.Name = "textBoxToken";
		this.ED220007.Size = new System.Drawing.Size(811, 21);
		this.ED220007.TabIndex = 72;
		this.ED220007.TextChanged += new System.EventHandler(ED220007_TextChanged);
		this.linkLabel3.AutoSize = true;
		this.linkLabel3.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel3.ForeColor = System.Drawing.Color.FromArgb(128, 64, 0);
		this.linkLabel3.LinkColor = System.Drawing.Color.Blue;
		this.linkLabel3.Location = new System.Drawing.Point(731, 56);
		this.linkLabel3.Name = "linkLabel3";
		this.linkLabel3.Size = new System.Drawing.Size(168, 14);
		this.linkLabel3.TabIndex = 71;
		this.linkLabel3.TabStop = true;
		this.linkLabel3.Text = "Tải extension lấy cookie Fplus";
		this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel3_LinkClicked);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.label1.Location = new System.Drawing.Point(45, 29);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(41, 14);
		this.label1.TabIndex = 0;
		this.label1.Text = "Proxy:";
		this.EC0B781F.AutoSize = true;
		this.EC0B781F.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.EC0B781F.ForeColor = System.Drawing.Color.FromArgb(0, 0, 192);
		this.EC0B781F.Location = new System.Drawing.Point(38, 55);
		this.EC0B781F.Name = "label4";
		this.EC0B781F.Size = new System.Drawing.Size(47, 14);
		this.EC0B781F.TabIndex = 9;
		this.EC0B781F.Text = "Cookie:";
		this.comboBoxProxy.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.comboBoxProxy.FormattingEnabled = true;
		this.comboBoxProxy.Items.AddRange(new object[8] { "None", "Http", "Socks5", "911", "Tinsoft", "Tmproxy", "Minproxy", "Shoplike" });
		this.comboBoxProxy.Location = new System.Drawing.Point(88, 26);
		this.comboBoxProxy.Name = "comboBoxProxy";
		this.comboBoxProxy.Size = new System.Drawing.Size(176, 22);
		this.comboBoxProxy.TabIndex = 1;
		this.comboBoxProxy.Text = "None";
		this.comboBoxProxy.SelectedIndexChanged += new System.EventHandler(comboBoxProxy_SelectedIndexChanged);
		this.textBoxCookie.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBoxCookie.Location = new System.Drawing.Point(88, 52);
		this.textBoxCookie.Name = "textBoxCookie";
		this.textBoxCookie.Size = new System.Drawing.Size(637, 21);
		this.textBoxCookie.TabIndex = 1;
		this.textBoxCookie.TextChanged += new System.EventHandler(textBoxCookie_TextChanged);
		this.D2207F10.Controls.Add(this.radioButtonEditInfoBM);
		this.D2207F10.Controls.Add(this.radioButtonAddThe);
		this.D2207F10.Controls.Add(this.F18B4C02);
		this.D2207F10.Controls.Add(this.radioButtonEditInfoTKQC);
		this.D2207F10.Controls.Add(this.label3);
		this.D2207F10.Location = new System.Drawing.Point(20, 123);
		this.D2207F10.Name = "panel3";
		this.D2207F10.Size = new System.Drawing.Size(918, 31);
		this.D2207F10.TabIndex = 8;
		this.radioButtonEditInfoBM.AutoSize = true;
		this.radioButtonEditInfoBM.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.radioButtonEditInfoBM.ForeColor = System.Drawing.Color.Crimson;
		this.radioButtonEditInfoBM.Location = new System.Drawing.Point(491, 7);
		this.radioButtonEditInfoBM.Name = "radioButtonEditInfoBM";
		this.radioButtonEditInfoBM.Size = new System.Drawing.Size(124, 20);
		this.radioButtonEditInfoBM.TabIndex = 11;
		this.radioButtonEditInfoBM.Text = "Đổi Info BM (Bm)";
		this.radioButtonEditInfoBM.UseVisualStyleBackColor = true;
		this.radioButtonEditInfoBM.CheckedChanged += new System.EventHandler(D1A62A07);
		this.radioButtonAddThe.AutoSize = true;
		this.radioButtonAddThe.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.radioButtonAddThe.ForeColor = System.Drawing.Color.Purple;
		this.radioButtonAddThe.Location = new System.Drawing.Point(351, 7);
		this.radioButtonAddThe.Name = "radioButtonAddThe";
		this.radioButtonAddThe.Size = new System.Drawing.Size(135, 20);
		this.radioButtonAddThe.TabIndex = 10;
		this.radioButtonAddThe.Text = "Add thẻ TKQC (Ad)";
		this.radioButtonAddThe.UseVisualStyleBackColor = true;
		this.radioButtonAddThe.CheckedChanged += new System.EventHandler(radioButtonAddThe_CheckedChanged);
		this.F18B4C02.AutoSize = true;
		this.F18B4C02.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.F18B4C02.ForeColor = System.Drawing.Color.Purple;
		this.F18B4C02.Location = new System.Drawing.Point(89, 7);
		this.F18B4C02.Name = "radioButtonAdCampaigns";
		this.F18B4C02.Size = new System.Drawing.Size(117, 20);
		this.F18B4C02.TabIndex = 6;
		this.F18B4C02.Text = "Set Camps (Ad)";
		this.F18B4C02.UseVisualStyleBackColor = true;
		this.F18B4C02.CheckedChanged += new System.EventHandler(F18B4C02_CheckedChanged);
		this.radioButtonEditInfoTKQC.AutoSize = true;
		this.radioButtonEditInfoTKQC.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.radioButtonEditInfoTKQC.ForeColor = System.Drawing.Color.Purple;
		this.radioButtonEditInfoTKQC.Location = new System.Drawing.Point(211, 7);
		this.radioButtonEditInfoTKQC.Name = "radioButtonEditInfoTKQC";
		this.radioButtonEditInfoTKQC.Size = new System.Drawing.Size(136, 20);
		this.radioButtonEditInfoTKQC.TabIndex = 5;
		this.radioButtonEditInfoTKQC.Text = "Đổi Info TKQC (Ad)";
		this.radioButtonEditInfoTKQC.UseVisualStyleBackColor = true;
		this.radioButtonEditInfoTKQC.CheckedChanged += new System.EventHandler(FE38AC0D);
		this.label3.AutoSize = true;
		this.label3.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = System.Drawing.Color.Green;
		this.label3.Location = new System.Drawing.Point(3, 8);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(77, 14);
		this.label3.TabIndex = 3;
		this.label3.Text = "Chức năng:";
		this.A3AF8325.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.A3AF8325.Location = new System.Drawing.Point(20, 157);
		this.A3AF8325.Name = "panelControl";
		this.A3AF8325.Size = new System.Drawing.Size(918, 432);
		this.A3AF8325.TabIndex = 7;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 17f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(973, 601);
		base.Controls.Add(this.panel1);
		this.Font = new System.Drawing.Font("Century Gothic", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fSetting";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "fSetting";
		this.panel1.ResumeLayout(false);
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.D2207F10.ResumeLayout(false);
		this.D2207F10.PerformLayout();
		base.ResumeLayout(false);
	}
}
