using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

public class fEditInfoBM : Form
{
	private IContainer icontainer_0 = null;

	private CheckBox checkBoxChangeNameBM;

	private Label label1;

	private NumericUpDown numericUpDownIndexNameBM;

	private ComboBox comboBoxTailNameBM;

	private TextBox D4882588;

	private LinkLabel C7A5013B;

	private ComboBox comboBox2FABM;

	private CheckBox checkBoxTurn2FABM;

	private CheckBox EE052F9F;

	private CheckBox checkBoxDaQTVAnBM;

	private CheckBox checkBoxOutBM;

	private LinkLabel linkLabel1;

	private LinkLabel linkLabel2;

	private LinkLabel linkLabel4;

	private CheckBox checkBoxCheckTypeBM;

	private LinkLabel linkLabel5;

	private CheckBox FA13983A;

	private TextBox textBoxTenUserBM;

	public fEditInfoBM()
	{
		//Discarded unreachable code: IL_0044, IL_004f, IL_0069, IL_0074, IL_008e, IL_0099, IL_00b3, IL_00be, IL_00dd, IL_00e8, IL_0102, IL_010d, IL_0127, IL_0132, IL_014c, IL_0157, IL_0171, IL_017c, IL_0196, IL_01a1, IL_01bb, IL_01c6, IL_01e0, IL_01eb, IL_0205, IL_0210
		InitializeComponent();
		string json = Class7.smethod_0(Directory.GetCurrentDirectory() + "\\config.json");
		JObject jObject = JObject.Parse(json);
		jObject["textBoxTenBM"].ToString();
		/*Error near IL_003f: Invalid metadata token*/;
	}

	private void D4882588_TextChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = D4882588.Text;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void FA13983A_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = FA13983A.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void textBoxTenUserBM_TextChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = textBoxTenUserBM.Text;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void comboBoxTailNameBM_SelectedIndexChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = comboBoxTailNameBM.Text;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void numericUpDownIndexNameBM_ValueChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		_ = (int)numericUpDownIndexNameBM.Value;
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void DD07B2A7(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = comboBox2FABM.Text;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void checkBoxChangeNameBM_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxChangeNameBM.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void checkBoxTurn2FABM_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxTurn2FABM.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void EE052F9F_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = EE052F9F.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void AC295E1A(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxDaQTVAnBM.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void FF2E7403(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxCheckTypeBM.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void CE98CD21(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxOutBM.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void C7A5013B_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_doi_ten_bm.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_doi_ten_bm.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_doi_ten_bm.txt");
		}
		catch
		{
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_bat_2fa_bm.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_bat_2fa_bm.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_bat_2fa_bm.txt");
		}
		catch
		{
		}
	}

	private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_check_da_qtv_an_bm.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_check_da_qtv_an_bm.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_check_da_qtv_an_bm.txt");
		}
		catch
		{
		}
	}

	private void B12CA896(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_out_bm.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_out_bm.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_out_bm.txt");
		}
		catch
		{
		}
	}

	private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\output\\ket_qua_check_type_bm.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\output\\ket_qua_check_type_bm.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\output\\ket_qua_check_type_bm.txt");
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
		this.checkBoxChangeNameBM = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		this.numericUpDownIndexNameBM = new System.Windows.Forms.NumericUpDown();
		this.comboBoxTailNameBM = new System.Windows.Forms.ComboBox();
		this.D4882588 = new System.Windows.Forms.TextBox();
		this.C7A5013B = new System.Windows.Forms.LinkLabel();
		this.comboBox2FABM = new System.Windows.Forms.ComboBox();
		this.checkBoxTurn2FABM = new System.Windows.Forms.CheckBox();
		this.EE052F9F = new System.Windows.Forms.CheckBox();
		this.checkBoxDaQTVAnBM = new System.Windows.Forms.CheckBox();
		this.checkBoxOutBM = new System.Windows.Forms.CheckBox();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		this.linkLabel2 = new System.Windows.Forms.LinkLabel();
		this.linkLabel4 = new System.Windows.Forms.LinkLabel();
		this.checkBoxCheckTypeBM = new System.Windows.Forms.CheckBox();
		this.linkLabel5 = new System.Windows.Forms.LinkLabel();
		this.FA13983A = new System.Windows.Forms.CheckBox();
		this.textBoxTenUserBM = new System.Windows.Forms.TextBox();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownIndexNameBM).BeginInit();
		base.SuspendLayout();
		this.checkBoxChangeNameBM.AutoSize = true;
		this.checkBoxChangeNameBM.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxChangeNameBM.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBoxChangeNameBM.Location = new System.Drawing.Point(88, 8);
		this.checkBoxChangeNameBM.Name = "checkBoxChangeNameBM";
		this.checkBoxChangeNameBM.Size = new System.Drawing.Size(87, 18);
		this.checkBoxChangeNameBM.TabIndex = 210;
		this.checkBoxChangeNameBM.Text = "Đổi tên bm";
		this.checkBoxChangeNameBM.UseVisualStyleBackColor = true;
		this.checkBoxChangeNameBM.CheckedChanged += new System.EventHandler(checkBoxChangeNameBM_CheckedChanged);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.Color.Black;
		this.label1.Location = new System.Drawing.Point(113, 34);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(50, 14);
		this.label1.TabIndex = 215;
		this.label1.Text = "Tên bm";
		this.numericUpDownIndexNameBM.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.numericUpDownIndexNameBM.Location = new System.Drawing.Point(502, 30);
		this.numericUpDownIndexNameBM.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.numericUpDownIndexNameBM.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.numericUpDownIndexNameBM.Name = "numericUpDownIndexNameBM";
		this.numericUpDownIndexNameBM.Size = new System.Drawing.Size(63, 22);
		this.numericUpDownIndexNameBM.TabIndex = 214;
		this.numericUpDownIndexNameBM.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.numericUpDownIndexNameBM.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.numericUpDownIndexNameBM.ValueChanged += new System.EventHandler(numericUpDownIndexNameBM_ValueChanged);
		this.comboBoxTailNameBM.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.comboBoxTailNameBM.FormattingEnabled = true;
		this.comboBoxTailNameBM.Items.AddRange(new object[4] { "None", "Random", "Theo stt", "Theo stt from" });
		this.comboBoxTailNameBM.Location = new System.Drawing.Point(350, 30);
		this.comboBoxTailNameBM.Name = "comboBoxTailNameBM";
		this.comboBoxTailNameBM.Size = new System.Drawing.Size(144, 21);
		this.comboBoxTailNameBM.TabIndex = 213;
		this.comboBoxTailNameBM.SelectedIndexChanged += new System.EventHandler(comboBoxTailNameBM_SelectedIndexChanged);
		this.D4882588.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.D4882588.Location = new System.Drawing.Point(169, 30);
		this.D4882588.Name = "textBoxTenBM";
		this.D4882588.Size = new System.Drawing.Size(172, 21);
		this.D4882588.TabIndex = 212;
		this.D4882588.TextChanged += new System.EventHandler(D4882588_TextChanged);
		this.C7A5013B.AutoSize = true;
		this.C7A5013B.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.C7A5013B.Location = new System.Drawing.Point(570, 33);
		this.C7A5013B.Name = "linkLabel3";
		this.C7A5013B.Size = new System.Drawing.Size(152, 14);
		this.C7A5013B.TabIndex = 211;
		this.C7A5013B.TabStop = true;
		this.C7A5013B.Text = "Mở file kết quả đổi tên bm";
		this.C7A5013B.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(C7A5013B_LinkClicked);
		this.comboBox2FABM.FormattingEnabled = true;
		this.comboBox2FABM.Items.AddRange(new object[3] { "none | No one", "admin_required | Admin Only", "all_required | Everyone" });
		this.comboBox2FABM.Location = new System.Drawing.Point(169, 111);
		this.comboBox2FABM.Name = "comboBox2FABM";
		this.comboBox2FABM.Size = new System.Drawing.Size(172, 22);
		this.comboBox2FABM.TabIndex = 217;
		this.comboBox2FABM.SelectedIndexChanged += new System.EventHandler(DD07B2A7);
		this.checkBoxTurn2FABM.AutoSize = true;
		this.checkBoxTurn2FABM.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBoxTurn2FABM.Location = new System.Drawing.Point(88, 113);
		this.checkBoxTurn2FABM.Name = "checkBoxTurn2FABM";
		this.checkBoxTurn2FABM.Size = new System.Drawing.Size(65, 18);
		this.checkBoxTurn2FABM.TabIndex = 216;
		this.checkBoxTurn2FABM.Text = "Bật 2fa";
		this.checkBoxTurn2FABM.UseVisualStyleBackColor = true;
		this.checkBoxTurn2FABM.CheckedChanged += new System.EventHandler(checkBoxTurn2FABM_CheckedChanged);
		this.EE052F9F.AutoSize = true;
		this.EE052F9F.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.EE052F9F.Location = new System.Drawing.Point(88, 144);
		this.EE052F9F.Name = "checkBoxCheckQtvAnBM";
		this.EE052F9F.Size = new System.Drawing.Size(169, 18);
		this.EE052F9F.TabIndex = 218;
		this.EE052F9F.Text = "Check quản trị viên ẩn bm";
		this.EE052F9F.UseVisualStyleBackColor = true;
		this.EE052F9F.CheckedChanged += new System.EventHandler(EE052F9F_CheckedChanged);
		this.checkBoxDaQTVAnBM.AutoSize = true;
		this.checkBoxDaQTVAnBM.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBoxDaQTVAnBM.Location = new System.Drawing.Point(274, 144);
		this.checkBoxDaQTVAnBM.Name = "checkBoxDaQTVAnBM";
		this.checkBoxDaQTVAnBM.Size = new System.Drawing.Size(150, 18);
		this.checkBoxDaQTVAnBM.TabIndex = 219;
		this.checkBoxDaQTVAnBM.Text = "Đá quản trị viên ẩn bm";
		this.checkBoxDaQTVAnBM.UseVisualStyleBackColor = true;
		this.checkBoxDaQTVAnBM.CheckedChanged += new System.EventHandler(AC295E1A);
		this.checkBoxOutBM.AutoSize = true;
		this.checkBoxOutBM.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBoxOutBM.Location = new System.Drawing.Point(88, 197);
		this.checkBoxOutBM.Name = "checkBoxOutBM";
		this.checkBoxOutBM.Size = new System.Drawing.Size(68, 18);
		this.checkBoxOutBM.TabIndex = 220;
		this.checkBoxOutBM.Text = "Out bm";
		this.checkBoxOutBM.UseVisualStyleBackColor = true;
		this.checkBoxOutBM.CheckedChanged += new System.EventHandler(CE98CD21);
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel1.Location = new System.Drawing.Point(570, 116);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(152, 14);
		this.linkLabel1.TabIndex = 222;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Mở file kết quả bật 2fa bm";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.linkLabel2.AutoSize = true;
		this.linkLabel2.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel2.Location = new System.Drawing.Point(570, 198);
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.Size = new System.Drawing.Size(132, 14);
		this.linkLabel2.TabIndex = 223;
		this.linkLabel2.TabStop = true;
		this.linkLabel2.Text = "Mở file kết quả out bm";
		this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(B12CA896);
		this.linkLabel4.AutoSize = true;
		this.linkLabel4.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel4.Location = new System.Drawing.Point(570, 143);
		this.linkLabel4.Name = "linkLabel4";
		this.linkLabel4.Size = new System.Drawing.Size(181, 14);
		this.linkLabel4.TabIndex = 224;
		this.linkLabel4.TabStop = true;
		this.linkLabel4.Text = "Mở file kết quả check/đá qtv ẩn";
		this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel4_LinkClicked);
		this.checkBoxCheckTypeBM.AutoSize = true;
		this.checkBoxCheckTypeBM.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBoxCheckTypeBM.Location = new System.Drawing.Point(88, 171);
		this.checkBoxCheckTypeBM.Name = "checkBoxCheckTypeBM";
		this.checkBoxCheckTypeBM.Size = new System.Drawing.Size(183, 18);
		this.checkBoxCheckTypeBM.TabIndex = 225;
		this.checkBoxCheckTypeBM.Text = "Check loại bm1,bm5,bm10...";
		this.checkBoxCheckTypeBM.UseVisualStyleBackColor = true;
		this.checkBoxCheckTypeBM.CheckedChanged += new System.EventHandler(FF2E7403);
		this.linkLabel5.AutoSize = true;
		this.linkLabel5.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabel5.Location = new System.Drawing.Point(570, 171);
		this.linkLabel5.Name = "linkLabel5";
		this.linkLabel5.Size = new System.Drawing.Size(174, 14);
		this.linkLabel5.TabIndex = 226;
		this.linkLabel5.TabStop = true;
		this.linkLabel5.Text = "Mở file kết quả check type bm";
		this.linkLabel5.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel5_LinkClicked);
		this.FA13983A.AutoSize = true;
		this.FA13983A.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FA13983A.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.FA13983A.Location = new System.Drawing.Point(88, 60);
		this.FA13983A.Name = "checkBoxChangeNameUserInBM";
		this.FA13983A.Size = new System.Drawing.Size(169, 18);
		this.FA13983A.TabIndex = 227;
		this.FA13983A.Text = "Đổi tên bm user trong bm";
		this.FA13983A.UseVisualStyleBackColor = true;
		this.FA13983A.CheckedChanged += new System.EventHandler(FA13983A_CheckedChanged);
		this.textBoxTenUserBM.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBoxTenUserBM.Location = new System.Drawing.Point(263, 57);
		this.textBoxTenUserBM.Name = "textBoxTenUserBM";
		this.textBoxTenUserBM.Size = new System.Drawing.Size(78, 21);
		this.textBoxTenUserBM.TabIndex = 228;
		this.textBoxTenUserBM.TextChanged += new System.EventHandler(textBoxTenUserBM_TextChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 14f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(933, 485);
		base.Controls.Add(this.textBoxTenUserBM);
		base.Controls.Add(this.FA13983A);
		base.Controls.Add(this.linkLabel5);
		base.Controls.Add(this.checkBoxCheckTypeBM);
		base.Controls.Add(this.linkLabel4);
		base.Controls.Add(this.linkLabel2);
		base.Controls.Add(this.linkLabel1);
		base.Controls.Add(this.checkBoxOutBM);
		base.Controls.Add(this.checkBoxDaQTVAnBM);
		base.Controls.Add(this.EE052F9F);
		base.Controls.Add(this.comboBox2FABM);
		base.Controls.Add(this.checkBoxTurn2FABM);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.numericUpDownIndexNameBM);
		base.Controls.Add(this.comboBoxTailNameBM);
		base.Controls.Add(this.D4882588);
		base.Controls.Add(this.C7A5013B);
		base.Controls.Add(this.checkBoxChangeNameBM);
		this.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fEditInfoBM";
		this.Text = "fEditInfoBM";
		((System.ComponentModel.ISupportInitialize)this.numericUpDownIndexNameBM).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
