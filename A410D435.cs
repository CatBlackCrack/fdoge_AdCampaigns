using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

public class A410D435 : Form
{
	private IContainer icontainer_0 = null;

	private Label label1;

	private TextBox textBoxBPBudget;

	private Label label2;

	private Label label3;

	private TextBox textBoxBPAge;

	private Label DF82EB3D;

	private TextBox C3031EA1;

	private Label label5;

	private TextBox A485ED91;

	private Label label6;

	private TextBox textBoxBPCountry;

	private Label A035408D;

	private ComboBox comboBoxTypeBP;

	private ComboBox CC2757B2;

	private Button buttonConfigBPJson;

	private Label label8;

	public A410D435()
	{
		//Discarded unreachable code: IL_0044, IL_004f, IL_0069, IL_0074, IL_008e, IL_0099, IL_00b3, IL_00be, IL_00d8, IL_00e3, IL_00fd, IL_0108, IL_0122, IL_012d
		InitializeComponent();
		string json = Class7.smethod_0(Directory.GetCurrentDirectory() + "\\config.json");
		JObject jObject = JObject.Parse(json);
		jObject["comboBoxTypeBP"].ToString();
		/*Error near IL_003f: Invalid metadata token*/;
	}

	private void D832638A(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a, IL_0036, IL_0044, IL_0050
		_ = comboBoxTypeBP.Text;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void F715FE97(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = A485ED91.Text;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void C3031EA1_TextChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = C3031EA1.Text;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void textBoxBPAge_TextChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = textBoxBPAge.Text;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void E323288B(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = CC2757B2.Text;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void textBoxBPBudget_TextChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = textBoxBPBudget.Text;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void textBoxBPCountry_TextChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = textBoxBPCountry.Text;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void A2B6F884(object sender, EventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\config\\json_custome.txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\config\\json_custome.txt", "");
				Thread.Sleep(500);
			}
			Process.Start("notepad.exe", Directory.GetCurrentDirectory() + "\\config\\json_custome.txt");
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
		this.label1 = new System.Windows.Forms.Label();
		this.textBoxBPBudget = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.textBoxBPAge = new System.Windows.Forms.TextBox();
		this.DF82EB3D = new System.Windows.Forms.Label();
		this.C3031EA1 = new System.Windows.Forms.TextBox();
		this.label5 = new System.Windows.Forms.Label();
		this.A485ED91 = new System.Windows.Forms.TextBox();
		this.label6 = new System.Windows.Forms.Label();
		this.textBoxBPCountry = new System.Windows.Forms.TextBox();
		this.A035408D = new System.Windows.Forms.Label();
		this.comboBoxTypeBP = new System.Windows.Forms.ComboBox();
		this.CC2757B2 = new System.Windows.Forms.ComboBox();
		this.buttonConfigBPJson = new System.Windows.Forms.Button();
		this.label8 = new System.Windows.Forms.Label();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(88, 8);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(59, 14);
		this.label1.TabIndex = 187;
		this.label1.Text = "Kiểu chạy";
		this.textBoxBPBudget.Location = new System.Drawing.Point(152, 145);
		this.textBoxBPBudget.Name = "textBoxBPBudget";
		this.textBoxBPBudget.Size = new System.Drawing.Size(354, 22);
		this.textBoxBPBudget.TabIndex = 190;
		this.textBoxBPBudget.TextChanged += new System.EventHandler(textBoxBPBudget_TextChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(88, 148);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(63, 14);
		this.label2.TabIndex = 189;
		this.label2.Text = "Ngân sách";
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(88, 120);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(51, 14);
		this.label3.TabIndex = 191;
		this.label3.Text = "Giới tính";
		this.textBoxBPAge.Location = new System.Drawing.Point(152, 89);
		this.textBoxBPAge.Name = "textBoxBPAge";
		this.textBoxBPAge.Size = new System.Drawing.Size(354, 22);
		this.textBoxBPAge.TabIndex = 194;
		this.textBoxBPAge.TextChanged += new System.EventHandler(textBoxBPAge_TextChanged);
		this.DF82EB3D.AutoSize = true;
		this.DF82EB3D.Location = new System.Drawing.Point(88, 92);
		this.DF82EB3D.Name = "label4";
		this.DF82EB3D.Size = new System.Drawing.Size(47, 14);
		this.DF82EB3D.TabIndex = 193;
		this.DF82EB3D.Text = "Độ tuổi";
		this.C3031EA1.Location = new System.Drawing.Point(152, 61);
		this.C3031EA1.Name = "textBoxBPPostID";
		this.C3031EA1.Size = new System.Drawing.Size(354, 22);
		this.C3031EA1.TabIndex = 196;
		this.C3031EA1.TextChanged += new System.EventHandler(C3031EA1_TextChanged);
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(88, 64);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(47, 14);
		this.label5.TabIndex = 195;
		this.label5.Text = "Post ID";
		this.A485ED91.Location = new System.Drawing.Point(152, 33);
		this.A485ED91.Name = "textBoxBPPageID";
		this.A485ED91.Size = new System.Drawing.Size(354, 22);
		this.A485ED91.TabIndex = 198;
		this.A485ED91.TextChanged += new System.EventHandler(F715FE97);
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(88, 36);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(50, 14);
		this.label6.TabIndex = 197;
		this.label6.Text = "Page ID";
		this.textBoxBPCountry.Location = new System.Drawing.Point(152, 173);
		this.textBoxBPCountry.Name = "textBoxBPCountry";
		this.textBoxBPCountry.Size = new System.Drawing.Size(354, 22);
		this.textBoxBPCountry.TabIndex = 200;
		this.textBoxBPCountry.TextChanged += new System.EventHandler(textBoxBPCountry_TextChanged);
		this.A035408D.AutoSize = true;
		this.A035408D.Location = new System.Drawing.Point(88, 176);
		this.A035408D.Name = "label7";
		this.A035408D.Size = new System.Drawing.Size(55, 14);
		this.A035408D.TabIndex = 199;
		this.A035408D.Text = "Quốc gia";
		this.comboBoxTypeBP.FormattingEnabled = true;
		this.comboBoxTypeBP.Items.AddRange(new object[3] { "messages", "engagement", "tùy chỉnh json" });
		this.comboBoxTypeBP.Location = new System.Drawing.Point(152, 5);
		this.comboBoxTypeBP.Name = "comboBoxTypeBP";
		this.comboBoxTypeBP.Size = new System.Drawing.Size(354, 22);
		this.comboBoxTypeBP.TabIndex = 201;
		this.comboBoxTypeBP.SelectedIndexChanged += new System.EventHandler(D832638A);
		this.CC2757B2.FormattingEnabled = true;
		this.CC2757B2.Items.AddRange(new object[3] { "Tất cả", "Nam", "Nữ" });
		this.CC2757B2.Location = new System.Drawing.Point(152, 117);
		this.CC2757B2.Name = "comboBoxBPGender";
		this.CC2757B2.Size = new System.Drawing.Size(354, 22);
		this.CC2757B2.TabIndex = 202;
		this.CC2757B2.SelectedIndexChanged += new System.EventHandler(E323288B);
		this.buttonConfigBPJson.Location = new System.Drawing.Point(513, 4);
		this.buttonConfigBPJson.Name = "buttonConfigBPJson";
		this.buttonConfigBPJson.Size = new System.Drawing.Size(117, 23);
		this.buttonConfigBPJson.TabIndex = 203;
		this.buttonConfigBPJson.Text = "Cấu hình file json";
		this.buttonConfigBPJson.UseVisualStyleBackColor = true;
		this.buttonConfigBPJson.Click += new System.EventHandler(A2B6F884);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(512, 92);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(75, 14);
		this.label8.TabIndex = 204;
		this.label8.Text = "Ví dụ: 18-65";
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 14f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(741, 367);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.buttonConfigBPJson);
		base.Controls.Add(this.CC2757B2);
		base.Controls.Add(this.comboBoxTypeBP);
		base.Controls.Add(this.textBoxBPCountry);
		base.Controls.Add(this.A035408D);
		base.Controls.Add(this.A485ED91);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.C3031EA1);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.textBoxBPAge);
		base.Controls.Add(this.DF82EB3D);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.textBoxBPBudget);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		this.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fSetBP";
		this.Text = "fSetBP";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
