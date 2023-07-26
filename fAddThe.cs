using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

public class fAddThe : Form
{
	private IContainer C486B72F = null;

	private TextBox AE256283;

	private Label EF16F12F;

	private GroupBox C2B4F9BC;

	private TextBox textBoxCountryAddThe;

	private Label label2;

	private TextBox DA9D3722;

	private Label label1;

	private NumericUpDown numericUpDownSoTKQCThe;

	private Label A58F7338;

	private LinkLabel FC091126;

	private Label label5;

	private ComboBox comboBoxOrderGetThe;

	private TextBox C834CA29;

	private LinkLabel B4B3740A;

	private ComboBox comboBoxChangeTimezoneAddThe;

	private ComboBox B99E5A9E;

	private Label FD03E63E;

	private CheckBox FD157803;

	private CheckBox BBA6E585;

	private RadioButton radioButtonDoiTTAddThe;

	private RadioButton DDB1A988;

	private Panel AB2F95BA;

	public fAddThe()
	{
		//Discarded unreachable code: IL_0044, IL_004f, IL_0069, IL_0074, IL_008e, IL_0099, IL_00b3, IL_00be, IL_00d8, IL_00e3, IL_00fd, IL_0108, IL_0122, IL_012d, IL_0147, IL_0152, IL_016c, IL_0177, IL_0191, IL_019c, IL_01b6, IL_01c1, IL_01e0, IL_01eb
		InitializeComponent();
		string json = Class7.smethod_0(Directory.GetCurrentDirectory() + "\\config.json");
		JObject jObject = JObject.Parse(json);
		_ = (bool)jObject["checkBoxDoiTTTkqcAddThe"];
		/*Error near IL_003f: Invalid metadata token*/;
	}

	private void B4B3740A_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

	private void FC091126_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			if (!File.Exists(Directory.GetCurrentDirectory() + "\\config\\credit[number_mm_yyyy_ccv].txt"))
			{
				Class7.smethod_1(Directory.GetCurrentDirectory() + "\\config\\credit[number_mm_yyyy_ccv].txt", "");
				Thread.Sleep(500);
			}
			Process.Start("explorer.exe", Directory.GetCurrentDirectory() + "\\config\\credit[number_mm_yyyy_ccv].txt");
		}
		catch
		{
		}
	}

	private void FD157803_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = FD157803.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void C834CA29_TextChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		C834CA29.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void B99E5A9E_SelectedIndexChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		B99E5A9E.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void comboBoxChangeTimezoneAddThe_SelectedIndexChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		comboBoxChangeTimezoneAddThe.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void AE256283_TextChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		AE256283.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void E90AF738(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		DA9D3722.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void EC146632(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		textBoxCountryAddThe.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void numericUpDownSoTKQCThe_ValueChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		_ = (int)numericUpDownSoTKQCThe.Value;
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void AB2B2EA3(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0015, IL_001f
		comboBoxOrderGetThe.Text.Trim();
		/*Error near IL_0010: Invalid metadata token*/;
	}

	private void DDA19893(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = BBA6E585.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void fAddThe_Load(object sender, EventArgs e)
	{
	}

	private void radioButtonDoiTTAddThe_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = radioButtonDoiTTAddThe.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void DDB1A988_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = DDB1A988.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	protected override void Dispose(bool A7272B8F)
	{
		if (A7272B8F && C486B72F != null)
		{
			C486B72F.Dispose();
		}
		base.Dispose(A7272B8F);
	}

	private void InitializeComponent()
	{
		this.AE256283 = new System.Windows.Forms.TextBox();
		this.EF16F12F = new System.Windows.Forms.Label();
		this.C2B4F9BC = new System.Windows.Forms.GroupBox();
		this.label5 = new System.Windows.Forms.Label();
		this.comboBoxOrderGetThe = new System.Windows.Forms.ComboBox();
		this.A58F7338 = new System.Windows.Forms.Label();
		this.FC091126 = new System.Windows.Forms.LinkLabel();
		this.numericUpDownSoTKQCThe = new System.Windows.Forms.NumericUpDown();
		this.textBoxCountryAddThe = new System.Windows.Forms.TextBox();
		this.label2 = new System.Windows.Forms.Label();
		this.DA9D3722 = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.C834CA29 = new System.Windows.Forms.TextBox();
		this.B4B3740A = new System.Windows.Forms.LinkLabel();
		this.comboBoxChangeTimezoneAddThe = new System.Windows.Forms.ComboBox();
		this.B99E5A9E = new System.Windows.Forms.ComboBox();
		this.FD03E63E = new System.Windows.Forms.Label();
		this.FD157803 = new System.Windows.Forms.CheckBox();
		this.BBA6E585 = new System.Windows.Forms.CheckBox();
		this.radioButtonDoiTTAddThe = new System.Windows.Forms.RadioButton();
		this.DDB1A988 = new System.Windows.Forms.RadioButton();
		this.AB2F95BA = new System.Windows.Forms.Panel();
		this.C2B4F9BC.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownSoTKQCThe).BeginInit();
		this.AB2F95BA.SuspendLayout();
		base.SuspendLayout();
		this.AE256283.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.AE256283.Location = new System.Drawing.Point(102, 22);
		this.AE256283.Name = "textBoxAuthorAddThe";
		this.AE256283.Size = new System.Drawing.Size(177, 21);
		this.AE256283.TabIndex = 234;
		this.AE256283.TextChanged += new System.EventHandler(AE256283_TextChanged);
		this.EF16F12F.AutoSize = true;
		this.EF16F12F.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.EF16F12F.ForeColor = System.Drawing.Color.Black;
		this.EF16F12F.Location = new System.Drawing.Point(23, 26);
		this.EF16F12F.Name = "label4";
		this.EF16F12F.Size = new System.Drawing.Size(76, 14);
		this.EF16F12F.TabIndex = 233;
		this.EF16F12F.Text = "Tên chủ thẻ";
		this.C2B4F9BC.Controls.Add(this.label5);
		this.C2B4F9BC.Controls.Add(this.comboBoxOrderGetThe);
		this.C2B4F9BC.Controls.Add(this.A58F7338);
		this.C2B4F9BC.Controls.Add(this.FC091126);
		this.C2B4F9BC.Controls.Add(this.numericUpDownSoTKQCThe);
		this.C2B4F9BC.Controls.Add(this.textBoxCountryAddThe);
		this.C2B4F9BC.Controls.Add(this.label2);
		this.C2B4F9BC.Controls.Add(this.DA9D3722);
		this.C2B4F9BC.Controls.Add(this.label1);
		this.C2B4F9BC.Controls.Add(this.AE256283);
		this.C2B4F9BC.Controls.Add(this.EF16F12F);
		this.C2B4F9BC.Location = new System.Drawing.Point(88, 89);
		this.C2B4F9BC.Name = "groupBox1";
		this.C2B4F9BC.Size = new System.Drawing.Size(596, 111);
		this.C2B4F9BC.TabIndex = 235;
		this.C2B4F9BC.TabStop = false;
		this.C2B4F9BC.Text = "Cấu hình add thẻ";
		this.label5.AutoSize = true;
		this.label5.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = System.Drawing.Color.Black;
		this.label5.Location = new System.Drawing.Point(289, 80);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(70, 14);
		this.label5.TabIndex = 243;
		this.label5.Text = "Thứ tự thẻ";
		this.comboBoxOrderGetThe.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.comboBoxOrderGetThe.FormattingEnabled = true;
		this.comboBoxOrderGetThe.Items.AddRange(new object[2] { "Theo thứ tự", "Random" });
		this.comboBoxOrderGetThe.Location = new System.Drawing.Point(375, 76);
		this.comboBoxOrderGetThe.Name = "comboBoxOrderGetThe";
		this.comboBoxOrderGetThe.Size = new System.Drawing.Size(185, 21);
		this.comboBoxOrderGetThe.TabIndex = 242;
		this.comboBoxOrderGetThe.SelectedIndexChanged += new System.EventHandler(AB2B2EA3);
		this.A58F7338.AutoSize = true;
		this.A58F7338.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.A58F7338.ForeColor = System.Drawing.Color.Black;
		this.A58F7338.Location = new System.Drawing.Point(291, 52);
		this.A58F7338.Name = "label3";
		this.A58F7338.Size = new System.Drawing.Size(80, 14);
		this.A58F7338.TabIndex = 241;
		this.A58F7338.Text = "Số TKQC/thẻ";
		this.FC091126.AutoSize = true;
		this.FC091126.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FC091126.Location = new System.Drawing.Point(289, 24);
		this.FC091126.Name = "linkLabel3";
		this.FC091126.Size = new System.Drawing.Size(248, 14);
		this.FC091126.TabIndex = 240;
		this.FC091126.TabStop = true;
		this.FC091126.Text = "Cấu hình danh sách thẻ tại đây (id|m|y|ccv)";
		this.FC091126.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(FC091126_LinkClicked);
		this.numericUpDownSoTKQCThe.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.numericUpDownSoTKQCThe.Location = new System.Drawing.Point(375, 48);
		this.numericUpDownSoTKQCThe.Maximum = new decimal(new int[4] { 30000, 0, 0, 0 });
		this.numericUpDownSoTKQCThe.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.numericUpDownSoTKQCThe.Name = "numericUpDownSoTKQCThe";
		this.numericUpDownSoTKQCThe.Size = new System.Drawing.Size(185, 22);
		this.numericUpDownSoTKQCThe.TabIndex = 239;
		this.numericUpDownSoTKQCThe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
		this.numericUpDownSoTKQCThe.Value = new decimal(new int[4] { 1, 0, 0, 0 });
		this.numericUpDownSoTKQCThe.ValueChanged += new System.EventHandler(numericUpDownSoTKQCThe_ValueChanged);
		this.textBoxCountryAddThe.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBoxCountryAddThe.Location = new System.Drawing.Point(102, 76);
		this.textBoxCountryAddThe.Name = "textBoxCountryAddThe";
		this.textBoxCountryAddThe.Size = new System.Drawing.Size(177, 21);
		this.textBoxCountryAddThe.TabIndex = 238;
		this.textBoxCountryAddThe.TextChanged += new System.EventHandler(EC146632);
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.Color.Black;
		this.label2.Location = new System.Drawing.Point(44, 79);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(55, 14);
		this.label2.TabIndex = 237;
		this.label2.Text = "Quốc gia";
		this.DA9D3722.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DA9D3722.Location = new System.Drawing.Point(102, 49);
		this.DA9D3722.Name = "textBoxZipcodeAddThe";
		this.DA9D3722.Size = new System.Drawing.Size(177, 21);
		this.DA9D3722.TabIndex = 236;
		this.DA9D3722.TextChanged += new System.EventHandler(E90AF738);
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.Color.Black;
		this.label1.Location = new System.Drawing.Point(49, 52);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(50, 14);
		this.label1.TabIndex = 235;
		this.label1.Text = "Zipcode";
		this.C834CA29.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.C834CA29.Location = new System.Drawing.Point(190, 30);
		this.C834CA29.Name = "textBoxChangeCountryAddThe";
		this.C834CA29.Size = new System.Drawing.Size(117, 21);
		this.C834CA29.TabIndex = 241;
		this.C834CA29.TextChanged += new System.EventHandler(C834CA29_TextChanged);
		this.B4B3740A.AutoSize = true;
		this.B4B3740A.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B4B3740A.Location = new System.Drawing.Point(690, 34);
		this.B4B3740A.Name = "linkLabel10";
		this.B4B3740A.Size = new System.Drawing.Size(163, 14);
		this.B4B3740A.TabIndex = 240;
		this.B4B3740A.TabStop = true;
		this.B4B3740A.Text = "Mở file kết quả đổi thông tin";
		this.B4B3740A.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(B4B3740A_LinkClicked);
		this.comboBoxChangeTimezoneAddThe.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.comboBoxChangeTimezoneAddThe.FormattingEnabled = true;
		this.comboBoxChangeTimezoneAddThe.Items.AddRange(new object[146]
		{
			"\"America/Los_Angeles\":{Pacific -07:00}", "\"America/Denver\":{Mountain -06:00}", "\"Pacific/Honolulu\":{Hawaii -10:00}", "\"America/Anchorage\":{Alaska -08:00}", "\"America/Phoenix\":{Mountain Standard Time (Arizona)\" \"-07:00}", "\"America/Chicago\":{Central -05:00}", "\"America/New_York\":{Eastern -04:00}", "\"Asia/Dubai\":{Dubai +04:00}", "\"America/Argentina/San_Luis\":{San Luis -03:00}", "\"America/Argentina/Buenos_Aires\":{Buenos Aires -03:00}",
			"\"America/Argentina/Salta\":{Salta -03:00}", "\"Europe/Vienna\":{Vienna +02:00}", "\"Australia/Perth\":{Perth +08:00}", "\"Australia/Broken_Hill\":{Broken Hill +09:30}", "\"Australia/Sydney\":{Sydney +10:00}", "\"Europe/Sarajevo\":{Sarajevo +02:00}", "\"Asia/Dhaka\":{Dhaka +06:00}", "\"Europe/Brussels\":{Brussels +02:00}", "\"Europe/Sofia\":{Sofia +03:00}", "\"Asia/Bahrain\":{Bahrain +03:00}",
			"\"America/La_Paz\":{La Paz -04:00}", "\"America/Noronha\":{Noronha -02:00}", "\"America/Campo_Grande\":{Campo Grande -04:00}", "\"America/Belem\":{Belem -03:00}", "\"America/Sao_Paulo\":{Sao Paulo -03:00}", "\"America/Nassau\":{Nassau -04:00}", "\"America/Dawson\":{Dawson -07:00}", "\"America/Vancouver\":{Vancouver -07:00}", "\"America/Dawson_Creek\":{Dawson Creek -07:00}", "\"America/Edmonton\":{Edmonton -06:00}",
			"\"America/Rainy_River\":{Rainy River -05:00}", "\"America/Regina\":{Regina -06:00}", "\"America/Atikokan\":{Atikokan -05:00}", "\"America/Iqaluit\":{Iqaluit -04:00}", "\"America/Toronto\":{Toronto -04:00}", "\"America/Blanc-Sablon\":{Blanc-Sablon -04:00}", "\"America/Halifax\":{Halifax -03:00}", "\"America/St_Johns\":{St Johns -02:30}", "\"Europe/Zurich\":{Zurich +02:00}", "\"Pacific/Easter\":{Easter Island -06:00}",
			"\"America/Santiago\":{Santiago -04:00}", "\"Asia/Shanghai\":{Beijing +08:00}", "\"America/Bogota\":{Bogota -05:00}", "\"America/Costa_Rica\":{Costa Rica -06:00}", "\"Asia/Nicosia\":{Nicosia +03:00}", "\"Europe/Prague\":{Prague +02:00}", "\"Europe/Berlin\":{Berlin +02:00}", "\"Europe/Copenhagen\":{Copenhagen +02:00}", "\"America/Santo_Domingo\":{Santo Domingo -04:00}", "\"Pacific/Galapagos\":{Galapagos -06:00}",
			"\"America/Guayaquil\":{Guayaquil -05:00}", "\"Europe/Tallinn\":{Tallinn +03:00}", "\"Africa/Cairo\":{Cairo +02:00}", "\"Atlantic/Canary\":{Canary +01:00}", "\"Europe/Madrid\":{Madrid +02:00}", "\"Europe/Helsinki\":{Helsinki +03:00}", "\"Europe/Paris\":{Paris +02:00}", "\"Europe/London\":{London +01:00}", "\"Africa/Accra\":{Accra +00:00}", "\"Europe/Athens\":{Athens +03:00}",
			"\"America/Guatemala\":{Guatemala -06:00}", "\"Asia/Hong_Kong\":{Hong Kong +08:00}", "\"America/Tegucigalpa\":{Tegucigalpa -06:00}", "\"Europe/Zagreb\":{Zagreb +02:00}", "\"Europe/Budapest\":{Budapest +02:00}", "\"Asia/Jakarta\":{Jakarta +07:00}", "\"Asia/Makassar\":{Makassar +08:00}", "\"Asia/Jayapura\":{Jayapura +09:00}", "\"Europe/Dublin\":{Dublin +01:00}", "\"Asia/Jerusalem\":{Jerusalem +03:00}",
			"\"Asia/Kolkata\":{Kolkata +05:30}", "\"Asia/Baghdad\":{Baghdad +03:00}", "\"Atlantic/Reykjavik\":{Reykjavik +00:00}", "\"Europe/Rome\":{Rome +02:00}", "\"America/Jamaica\":{Jamaica -05:00}", "\"Asia/Amman\":{Amman +03:00}", "\"Asia/Tokyo\":{Tokyo +09:00}", "\"Africa/Nairobi\":{Nairobi +03:00}", "\"Asia/Seoul\":{Seoul +09:00}", "\"Asia/Kuwait\":{Kuwait +03:00}",
			"\"Asia/Beirut\":{Beirut +03:00}", "\"Asia/Colombo\":{Colombo +05:30}", "\"Europe/Vilnius\":{Vilnius +03:00}", "\"Europe/Luxembourg\":{Luxembourg +02:00}", "\"Europe/Riga\":{Riga +03:00}", "\"Africa/Casablanca\":{Casablanca +00:00}", "\"Europe/Skopje\":{Skopje +02:00}", "\"Europe/Malta\":{Malta +02:00}", "\"Indian/Mauritius\":{Mauritius +04:00}", "\"Indian/Maldives\":{Maldives +05:00}",
			"\"America/Tijuana\":{Tijuana -07:00}", "\"America/Hermosillo\":{Hermosillo -07:00}", "\"America/Mazatlan\":{Mazatlan -06:00}", "\"America/Mexico_City\":{Mexico City -05:00}", "\"Asia/Kuala_Lumpur\":{Kuala Lumpur +08:00}", "\"Africa/Lagos\":{Lagos +01:00}", "\"America/Managua\":{Managua -06:00}", "\"Europe/Amsterdam\":{Amsterdam +02:00}", "\"Europe/Oslo\":{Oslo +02:00}", "\"Pacific/Auckland\":{Auckland +12:00}",
			"\"Asia/Muscat\":{Muscat +04:00}", "\"America/Panama\":{Panama -05:00}", "\"America/Lima\":{Lima -05:00}", "\"Asia/Manila\":{Manila +08:00}", "\"Asia/Karachi\":{Karachi +05:00}", "\"Europe/Warsaw\":{Warsaw +02:00}", "\"America/Puerto_Rico\":{Puerto Rico -04:00}", "\"Asia/Gaza\":{Gaza +03:00}", "\"Atlantic/Azores\":{Azores +00:00}", "\"Europe/Lisbon\":{Lisbon +01:00}",
			"\"America/Asuncion\":{Asuncion -04:00}", "\"Asia/Qatar\":{Qatar +03:00}", "\"Europe/Bucharest\":{Bucharest +03:00}", "\"Europe/Belgrade\":{Belgrade +02:00}", "\"Europe/Kaliningrad\":{Kaliningrad +02:00}", "\"Europe/Moscow\":{Moscow +03:00}", "\"Europe/Samara\":{Samara +04:00}", "\"Asia/Yekaterinburg\":{Yekaterinburg +05:00}", "\"Asia/Omsk\":{Omsk +06:00}", "\"Asia/Krasnoyarsk\":{Krasnoyarsk +07:00}",
			"\"Asia/Irkutsk\":{Irkutsk +08:00}", "\"Asia/Yakutsk\":{Yakutsk +09:00}", "\"Asia/Vladivostok\":{Vladivostok +10:00}", "\"Asia/Magadan\":{Magadan +11:00}", "\"Asia/Kamchatka\":{Kamchatka +12:00}", "\"Asia/Riyadh\":{Riyadh +03:00}", "\"Europe/Stockholm\":{Stockholm +02:00}", "\"Asia/Singapore\":{Singapore +08:00}", "\"Europe/Ljubljana\":{Ljubljana +02:00}", "\"Europe/Bratislava\":{Bratislava +02:00}",
			"\"America/El_Salvador\":{El Salvador -06:00}", "\"Asia/Bangkok\":{Bangkok +07:00}", "\"Africa/Tunis\":{Tunis +01:00}", "\"Europe/Istanbul\":{Istanbul +03:00}", "\"America/Port_of_Spain\":{Port of Spain -04:00}", "\"Asia/Taipei\":{Taipei +08:00}", "\"Europe/Kiev\":{Kiev +03:00}", "\"America/Montevideo\":{Montevideo -03:00}", "\"America/Caracas\":{Caracas -04:00}", "\"Asia/Ho_Chi_Minh\":{Ho Chi Minh +07:00}",
			"\"Africa/Johannesburg\":{Johannesburg +02:00}", "\"America/Winnipeg\":{Winnipeg -05:00}", "\"America/Detroit\":{Detroit -04:00}", "\"Australia/Melbourne\":{Melbourne +10:00}", "\"Asia/Kathmandu\":{Kathmandu +05:45}", "\"Asia/Baku\":{Baku +04:00}"
		});
		this.comboBoxChangeTimezoneAddThe.Location = new System.Drawing.Point(463, 30);
		this.comboBoxChangeTimezoneAddThe.Name = "comboBoxChangeTimezoneAddThe";
		this.comboBoxChangeTimezoneAddThe.Size = new System.Drawing.Size(221, 21);
		this.comboBoxChangeTimezoneAddThe.TabIndex = 239;
		this.comboBoxChangeTimezoneAddThe.SelectedIndexChanged += new System.EventHandler(comboBoxChangeTimezoneAddThe_SelectedIndexChanged);
		this.B99E5A9E.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.B99E5A9E.FormattingEnabled = true;
		this.B99E5A9E.Items.AddRange(new object[55]
		{
			"{1}UAE Dirham (AED)", "{2}Argentine Peso (ARS)", "{3}Australian Dollar (AUD)", "{4}Bangladeshi Taka (BDT)", "{5}Bolivian Boliviano (BOB)", "{6}Brazilian Real (BRL)", "{7}Canadian Dollar (CAD)", "{8}Swiss Franc (CHF)", "{9}Chilean Peso (CLP)", "{10}Chinese Yuan (CNY)",
			"{11}Colombian Peso (COP)", "{12}Costa Rican Col?n (CRC)", "{13}Czech Koruna (CZK)", "{14}Danish Krone (DKK)", "{15}Algerian Dinar (DZD)", "{16}Egyptian Pound (EGP)", "{17}Euro (EUR)", "{18}British Pound (GBP)", "{19}Guatemalan Quetzal (GTQ)", "{20}Hong Kong Dollar (HKD)",
			"{21}Honduran Lempira (HNL)", "{22}Hungarian Forint (HUF)", "{23}Indonesian Rupiah (IDR)", "{24}Israeli New Shekel (ILS)", "{25}Indian Rupee (INR)", "{26}Iceland Krona (ISK)", "{27}Japanese Yen (JPY)", "{28}Kenyan Shilling (KES)", "{29}Korean Won (KRW)", "{30}Macau Patacas (MOP)",
			"{31}Mexican Peso (MXN)", "{32}Malaysian Ringgit (MYR)", "{33}Nigerian Naira (NGN)", "{34}Nicaraguan Cordoba (NIO)", "{35}Norwegian Krone (NOK)", "{36}New Zealand Dollar (NZD)", "{37}Peruvian Nuevo Sol (PEN)", "{38}Philippine Peso (PHP)", "{39}Pakistani Rupee (PKR)", "{40}Polish Zloty (PLN)",
			"{41}Paraguayan Guarani (PYG)", "{42}Qatari Rials (QAR)", "{43}Romanian Leu (RON)", "{44}Russian Ruble (RUB)", "{45}Saudi Arabian Riyal (SAR)", "{46}Swedish Krona (SEK)", "{47}Singapore Dollar (SGD)", "{48}Thai Baht (THB)", "{49}Turkish Lira (TRY)", "{50}Taiwan Dollar (TWD)",
			"{51}US Dollars (USD)", "{52}Uruguay Peso (UYU)", "{53}Vietnamese Dong (VND)", "{54}South African Rand (ZAR)", "{55}Ucraina Hryvnia (UAH)"
		});
		this.B99E5A9E.Location = new System.Drawing.Point(312, 30);
		this.B99E5A9E.Name = "comboBoxChangeCurrencyAddThe";
		this.B99E5A9E.Size = new System.Drawing.Size(146, 21);
		this.B99E5A9E.TabIndex = 238;
		this.B99E5A9E.SelectedIndexChanged += new System.EventHandler(B99E5A9E_SelectedIndexChanged);
		this.FD03E63E.AutoSize = true;
		this.FD03E63E.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FD03E63E.ForeColor = System.Drawing.Color.Black;
		this.FD03E63E.Location = new System.Drawing.Point(129, 34);
		this.FD03E63E.Name = "label6";
		this.FD03E63E.Size = new System.Drawing.Size(57, 14);
		this.FD03E63E.TabIndex = 237;
		this.FD03E63E.Text = "Info tkqc";
		this.FD157803.AutoSize = true;
		this.FD157803.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.FD157803.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.FD157803.Location = new System.Drawing.Point(88, 8);
		this.FD157803.Name = "checkBoxDoiTTTkqcAddThe";
		this.FD157803.Size = new System.Drawing.Size(126, 18);
		this.FD157803.TabIndex = 236;
		this.FD157803.Text = "Đổi thông tin tkqc";
		this.FD157803.UseVisualStyleBackColor = true;
		this.FD157803.CheckedChanged += new System.EventHandler(FD157803_CheckedChanged);
		this.BBA6E585.AutoSize = true;
		this.BBA6E585.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.BBA6E585.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.BBA6E585.Location = new System.Drawing.Point(88, 66);
		this.BBA6E585.Name = "checkBoxAddThe";
		this.BBA6E585.Size = new System.Drawing.Size(202, 18);
		this.BBA6E585.TabIndex = 242;
		this.BBA6E585.Text = "Add thẻ theo cấu hình dưới đây";
		this.BBA6E585.UseVisualStyleBackColor = true;
		this.BBA6E585.CheckedChanged += new System.EventHandler(DDA19893);
		this.radioButtonDoiTTAddThe.AutoSize = true;
		this.radioButtonDoiTTAddThe.Location = new System.Drawing.Point(4, 1);
		this.radioButtonDoiTTAddThe.Name = "radioButtonDoiTTAddThe";
		this.radioButtonDoiTTAddThe.Size = new System.Drawing.Size(189, 20);
		this.radioButtonDoiTTAddThe.TabIndex = 243;
		this.radioButtonDoiTTAddThe.TabStop = true;
		this.radioButtonDoiTTAddThe.Text = "Chỉ đổi thông tin, ko tạo tkqc";
		this.radioButtonDoiTTAddThe.UseVisualStyleBackColor = true;
		this.radioButtonDoiTTAddThe.CheckedChanged += new System.EventHandler(radioButtonDoiTTAddThe_CheckedChanged);
		this.DDB1A988.AutoSize = true;
		this.DDB1A988.Location = new System.Drawing.Point(199, 1);
		this.DDB1A988.Name = "radioButtonTaoTKQCMoiAddThe";
		this.DDB1A988.Size = new System.Drawing.Size(100, 20);
		this.DDB1A988.TabIndex = 244;
		this.DDB1A988.TabStop = true;
		this.DDB1A988.Text = "Tạo tkqc mới";
		this.DDB1A988.UseVisualStyleBackColor = true;
		this.DDB1A988.CheckedChanged += new System.EventHandler(DDB1A988_CheckedChanged);
		this.AB2F95BA.Controls.Add(this.DDB1A988);
		this.AB2F95BA.Controls.Add(this.radioButtonDoiTTAddThe);
		this.AB2F95BA.Location = new System.Drawing.Point(220, 6);
		this.AB2F95BA.Name = "panel1";
		this.AB2F95BA.Size = new System.Drawing.Size(312, 24);
		this.AB2F95BA.TabIndex = 245;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(923, 436);
		base.Controls.Add(this.AB2F95BA);
		base.Controls.Add(this.BBA6E585);
		base.Controls.Add(this.C834CA29);
		base.Controls.Add(this.B4B3740A);
		base.Controls.Add(this.comboBoxChangeTimezoneAddThe);
		base.Controls.Add(this.B99E5A9E);
		base.Controls.Add(this.FD03E63E);
		base.Controls.Add(this.FD157803);
		base.Controls.Add(this.C2B4F9BC);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fAddThe";
		this.Text = "fAddThe";
		base.Load += new System.EventHandler(fAddThe_Load);
		this.C2B4F9BC.ResumeLayout(false);
		this.C2B4F9BC.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.numericUpDownSoTKQCThe).EndInit();
		this.AB2F95BA.ResumeLayout(false);
		this.AB2F95BA.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
