using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class A618D5A2 : Form
{
	private FBBE97AE fbbe97AE_0 = new FBBE97AE();

	private C98B9531 c98B9531_0 = new C98B9531();

	private fBmAccount fBmAccount_0 = new fBmAccount();

	private const int F49F9336 = 16;

	private const int int_0 = 32;

	private IContainer icontainer_0 = null;

	private Panel MenuVertical;

	private PictureBox btnlogoInicio;

	private Panel BarraTitulo;

	private PictureBox btnMenu;

	private Panel A988A784;

	private PictureBox BB186D8F;

	private PictureBox CB941E21;

	private PictureBox B23B170F;

	private PictureBox EE9A0085;

	private Button btnAdData;

	private Button buttonSetting;

	private Button buttonLicense;

	private LinkLabel DF0EDB9B;

	private Label DA23D80E;

	private LinkLabel linkLabelTelegram;

	private LinkLabel linkLabelFacebook;

	private Label labelToolName;

	private LinkLabel linkLabelZalo;

	private Button C2B249A6;

	public A618D5A2()
	{
		InitializeComponent();
		DoubleBuffered = true;
		SetStyle(ControlStyles.ResizeRedraw, value: true);
		labelToolName.MouseDown += BarraTitulo_MouseDown;
		DA23D80E.MouseDown += BarraTitulo_MouseDown;
		method_0();
		new fEditInfoBM();
		new fDoiInfoTKQC();
		new fAddThe();
	}

	private void method_0()
	{
		try
		{
			FileInfo[] files = new DirectoryInfo("C:\\Windows\\Prefetch").GetFiles();
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					File.Delete(files[i].FullName);
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

	protected override void OnPaint(PaintEventArgs C62A5F3C)
	{
		Rectangle rectangle = new Rectangle(base.ClientSize.Width - 16, base.ClientSize.Height - 16, 16, 16);
		ControlPaint.DrawSizeGrip(C62A5F3C.Graphics, BackColor, rectangle);
		rectangle = new Rectangle(0, 0, base.ClientSize.Width, 32);
		C62A5F3C.Graphics.FillRectangle(Brushes.DarkBlue, rectangle);
	}

	protected override void WndProc(ref Message m)
	{
		if (m.Msg == 132)
		{
			Point p = new Point(m.LParam.ToInt32());
			p = PointToClient(p);
			if (p.Y < 32)
			{
				m.Result = (IntPtr)2;
				return;
			}
			if (p.X >= base.ClientSize.Width - 16 && p.Y >= base.ClientSize.Height - 16)
			{
				m.Result = (IntPtr)17;
				return;
			}
		}
		base.WndProc(ref m);
	}

	private void D0112598(object sender, EventArgs e)
	{
		if (MenuVertical.Width == 233)
		{
			MenuVertical.Width = 65;
		}
		else
		{
			MenuVertical.Width = 233;
		}
	}

	private void A211D805(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void D880B712(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Maximized;
		CB941E21.Visible = true;
		B23B170F.Visible = false;
	}

	private void CB941E21_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Normal;
		CB941E21.Visible = false;
		B23B170F.Visible = true;
	}

	private void BB186D8F_Click(object sender, EventArgs e)
	{
		base.WindowState = FormWindowState.Minimized;
	}

	[DllImport("user32.DLL")]
	private static extern void ReleaseCapture();

	[DllImport("user32.DLL")]
	private static extern void SendMessage(IntPtr intptr_0, int AE8FDC1E, int int_1, int int_2);

	private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
	{
		ReleaseCapture();
		SendMessage(base.Handle, 274, 61458, 0);
	}

	private void A03CCFB7(object D992B410)
	{
		if (A988A784.Controls.Count > 0)
		{
			A988A784.Controls.RemoveAt(0);
		}
		Form form = D992B410 as Form;
		form.TopLevel = false;
		form.Dock = DockStyle.Fill;
		A988A784.Controls.Add(form);
		A988A784.Tag = form;
		form.Show();
	}

	private void E80E7F08(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_001f, IL_002b
		//IL_0006: Invalid comparison between Unknown and I4
		/*Error: Invalid metadata token*/;
	}

	private void EFBDB4AF(object sender, EventArgs e)
	{
		A03CCFB7(new E68C2806());
	}

	private void F9913527(object sender, EventArgs e)
	{
		A03CCFB7(new E68C2806());
	}

	private void A988A784_Paint(object sender, PaintEventArgs e)
	{
	}

	private void MenuVertical_Paint(object sender, PaintEventArgs e)
	{
	}

	private void buttonLicense_Click(object sender, EventArgs e)
	{
		A03CCFB7(new E68C2806());
	}

	private void buttonSetting_Click(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_001f, IL_002b
		//IL_0006: Invalid comparison between Unknown and I4
		/*Error: Invalid metadata token*/;
	}

	private void BarraTitulo_Paint(object sender, PaintEventArgs e)
	{
	}

	private void linkLabelFacebook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("chrome.exe", "https://fb.com/truongps9x");
		}
		catch
		{
			Process.Start("https://fb.com/truongps9x");
		}
	}

	private void linkLabelTelegram_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("chrome.exe", "https://t.me/truongps9x");
		}
		catch
		{
			Process.Start("https://t.me/truongps9x");
		}
	}

	private void DF0EDB9B_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("chrome.exe", "https://dogetool.github.io/product");
		}
		catch
		{
			Process.Start("https://dogetool.github.io/product");
		}
	}

	private void linkLabelZalo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("chrome.exe", "https://zalo.me/g/eeskwj330");
		}
		catch
		{
			Process.Start("https://zalo.me/g/eeskwj330");
		}
	}

	private void labelToolName_Click(object sender, EventArgs e)
	{
	}

	private void AAAFEB3A(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_001f, IL_002b
		//IL_0006: Invalid comparison between Unknown and I4
		/*Error: Invalid metadata token*/;
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A618D5A2));
		this.MenuVertical = new System.Windows.Forms.Panel();
		this.C2B249A6 = new System.Windows.Forms.Button();
		this.buttonLicense = new System.Windows.Forms.Button();
		this.buttonSetting = new System.Windows.Forms.Button();
		this.btnAdData = new System.Windows.Forms.Button();
		this.btnlogoInicio = new System.Windows.Forms.PictureBox();
		this.BarraTitulo = new System.Windows.Forms.Panel();
		this.linkLabelZalo = new System.Windows.Forms.LinkLabel();
		this.DF0EDB9B = new System.Windows.Forms.LinkLabel();
		this.DA23D80E = new System.Windows.Forms.Label();
		this.linkLabelTelegram = new System.Windows.Forms.LinkLabel();
		this.linkLabelFacebook = new System.Windows.Forms.LinkLabel();
		this.labelToolName = new System.Windows.Forms.Label();
		this.BB186D8F = new System.Windows.Forms.PictureBox();
		this.CB941E21 = new System.Windows.Forms.PictureBox();
		this.B23B170F = new System.Windows.Forms.PictureBox();
		this.EE9A0085 = new System.Windows.Forms.PictureBox();
		this.btnMenu = new System.Windows.Forms.PictureBox();
		this.A988A784 = new System.Windows.Forms.Panel();
		this.MenuVertical.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.btnlogoInicio).BeginInit();
		this.BarraTitulo.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.BB186D8F).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.CB941E21).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.B23B170F).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.EE9A0085).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.btnMenu).BeginInit();
		base.SuspendLayout();
		this.MenuVertical.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
		this.MenuVertical.Controls.Add(this.C2B249A6);
		this.MenuVertical.Controls.Add(this.buttonLicense);
		this.MenuVertical.Controls.Add(this.buttonSetting);
		this.MenuVertical.Controls.Add(this.btnAdData);
		this.MenuVertical.Controls.Add(this.btnlogoInicio);
		this.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left;
		this.MenuVertical.Location = new System.Drawing.Point(0, 0);
		this.MenuVertical.Name = "MenuVertical";
		this.MenuVertical.Size = new System.Drawing.Size(233, 648);
		this.MenuVertical.TabIndex = 0;
		this.MenuVertical.Paint += new System.Windows.Forms.PaintEventHandler(MenuVertical_Paint);
		this.C2B249A6.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
		this.C2B249A6.FlatAppearance.BorderSize = 0;
		this.C2B249A6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 48);
		this.C2B249A6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.C2B249A6.Font = new System.Drawing.Font("Tahoma", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.C2B249A6.ForeColor = System.Drawing.Color.White;
		this.C2B249A6.Image = (System.Drawing.Image)resources.GetObject("buttonBmData.Image");
		this.C2B249A6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.C2B249A6.Location = new System.Drawing.Point(2, 173);
		this.C2B249A6.Name = "buttonBmData";
		this.C2B249A6.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.C2B249A6.Size = new System.Drawing.Size(230, 40);
		this.C2B249A6.TabIndex = 19;
		this.C2B249A6.Text = "Bm_Account";
		this.C2B249A6.UseVisualStyleBackColor = false;
		this.C2B249A6.Click += new System.EventHandler(AAAFEB3A);
		this.buttonLicense.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.buttonLicense.FlatAppearance.BorderSize = 0;
		this.buttonLicense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 48);
		this.buttonLicense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonLicense.Font = new System.Drawing.Font("Tahoma", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.buttonLicense.ForeColor = System.Drawing.Color.White;
		this.buttonLicense.Image = (System.Drawing.Image)resources.GetObject("buttonLicense.Image");
		this.buttonLicense.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.buttonLicense.Location = new System.Drawing.Point(2, 597);
		this.buttonLicense.Name = "buttonLicense";
		this.buttonLicense.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.buttonLicense.Size = new System.Drawing.Size(229, 47);
		this.buttonLicense.TabIndex = 18;
		this.buttonLicense.Text = "License";
		this.buttonLicense.UseVisualStyleBackColor = true;
		this.buttonLicense.Click += new System.EventHandler(buttonLicense_Click);
		this.buttonSetting.FlatAppearance.BorderSize = 0;
		this.buttonSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 48);
		this.buttonSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonSetting.Font = new System.Drawing.Font("Tahoma", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.buttonSetting.ForeColor = System.Drawing.Color.White;
		this.buttonSetting.Image = (System.Drawing.Image)resources.GetObject("buttonSetting.Image");
		this.buttonSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.buttonSetting.Location = new System.Drawing.Point(-2, 219);
		this.buttonSetting.Name = "buttonSetting";
		this.buttonSetting.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.buttonSetting.Size = new System.Drawing.Size(235, 45);
		this.buttonSetting.TabIndex = 2;
		this.buttonSetting.Text = "Setting";
		this.buttonSetting.UseVisualStyleBackColor = true;
		this.buttonSetting.Click += new System.EventHandler(buttonSetting_Click);
		this.btnAdData.BackColor = System.Drawing.Color.FromArgb(0, 122, 204);
		this.btnAdData.FlatAppearance.BorderSize = 0;
		this.btnAdData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(45, 45, 48);
		this.btnAdData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.btnAdData.Font = new System.Drawing.Font("Tahoma", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.btnAdData.ForeColor = System.Drawing.Color.White;
		this.btnAdData.Image = (System.Drawing.Image)resources.GetObject("btnAdData.Image");
		this.btnAdData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnAdData.Location = new System.Drawing.Point(3, 126);
		this.btnAdData.Name = "btnAdData";
		this.btnAdData.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
		this.btnAdData.Size = new System.Drawing.Size(228, 40);
		this.btnAdData.TabIndex = 1;
		this.btnAdData.Text = "Ad_Account";
		this.btnAdData.UseVisualStyleBackColor = false;
		this.btnAdData.Click += new System.EventHandler(E80E7F08);
		this.btnlogoInicio.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnlogoInicio.Image = (System.Drawing.Image)resources.GetObject("btnlogoInicio.Image");
		this.btnlogoInicio.Location = new System.Drawing.Point(4, 10);
		this.btnlogoInicio.Name = "btnlogoInicio";
		this.btnlogoInicio.Size = new System.Drawing.Size(222, 48);
		this.btnlogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.btnlogoInicio.TabIndex = 0;
		this.btnlogoInicio.TabStop = false;
		this.btnlogoInicio.Click += new System.EventHandler(EFBDB4AF);
		this.BarraTitulo.BackColor = System.Drawing.Color.WhiteSmoke;
		this.BarraTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.BarraTitulo.Controls.Add(this.linkLabelZalo);
		this.BarraTitulo.Controls.Add(this.DF0EDB9B);
		this.BarraTitulo.Controls.Add(this.DA23D80E);
		this.BarraTitulo.Controls.Add(this.linkLabelTelegram);
		this.BarraTitulo.Controls.Add(this.linkLabelFacebook);
		this.BarraTitulo.Controls.Add(this.labelToolName);
		this.BarraTitulo.Controls.Add(this.BB186D8F);
		this.BarraTitulo.Controls.Add(this.CB941E21);
		this.BarraTitulo.Controls.Add(this.B23B170F);
		this.BarraTitulo.Controls.Add(this.EE9A0085);
		this.BarraTitulo.Controls.Add(this.btnMenu);
		this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
		this.BarraTitulo.Location = new System.Drawing.Point(233, 0);
		this.BarraTitulo.Name = "BarraTitulo";
		this.BarraTitulo.Size = new System.Drawing.Size(1067, 45);
		this.BarraTitulo.TabIndex = 1;
		this.BarraTitulo.Paint += new System.Windows.Forms.PaintEventHandler(BarraTitulo_Paint);
		this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(BarraTitulo_MouseDown);
		this.linkLabelZalo.AutoSize = true;
		this.linkLabelZalo.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabelZalo.Font = new System.Drawing.Font("Century Gothic", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabelZalo.LinkColor = System.Drawing.Color.Purple;
		this.linkLabelZalo.Location = new System.Drawing.Point(296, 14);
		this.linkLabelZalo.Name = "linkLabelZalo";
		this.linkLabelZalo.Size = new System.Drawing.Size(40, 18);
		this.linkLabelZalo.TabIndex = 10;
		this.linkLabelZalo.TabStop = true;
		this.linkLabelZalo.Text = "Zalo";
		this.linkLabelZalo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelZalo_LinkClicked);
		this.DF0EDB9B.AutoSize = true;
		this.DF0EDB9B.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DF0EDB9B.Font = new System.Drawing.Font("Century Gothic", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.DF0EDB9B.LinkColor = System.Drawing.Color.Purple;
		this.DF0EDB9B.Location = new System.Drawing.Point(227, 14);
		this.DF0EDB9B.Name = "linkLabelWebsite";
		this.DF0EDB9B.Size = new System.Drawing.Size(66, 18);
		this.DF0EDB9B.TabIndex = 9;
		this.DF0EDB9B.TabStop = true;
		this.DF0EDB9B.Text = "Website";
		this.DF0EDB9B.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(DF0EDB9B_LinkClicked);
		this.DA23D80E.AutoSize = true;
		this.DA23D80E.Cursor = System.Windows.Forms.Cursors.Hand;
		this.DA23D80E.Font = new System.Drawing.Font("MS Reference Sans Serif", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.DA23D80E.ForeColor = System.Drawing.Color.Maroon;
		this.DA23D80E.Location = new System.Drawing.Point(340, 14);
		this.DA23D80E.Name = "labelPhone";
		this.DA23D80E.Size = new System.Drawing.Size(339, 19);
		this.DA23D80E.TabIndex = 8;
		this.DA23D80E.Text = "https://fb.com/truongps9x - 0585.33.0000";
		this.linkLabelTelegram.AutoSize = true;
		this.linkLabelTelegram.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabelTelegram.Font = new System.Drawing.Font("Century Gothic", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabelTelegram.LinkColor = System.Drawing.Color.Purple;
		this.linkLabelTelegram.Location = new System.Drawing.Point(149, 14);
		this.linkLabelTelegram.Name = "linkLabelTelegram";
		this.linkLabelTelegram.Size = new System.Drawing.Size(77, 18);
		this.linkLabelTelegram.TabIndex = 7;
		this.linkLabelTelegram.TabStop = true;
		this.linkLabelTelegram.Text = "Telegram";
		this.linkLabelTelegram.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelTelegram_LinkClicked);
		this.linkLabelFacebook.AutoSize = true;
		this.linkLabelFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
		this.linkLabelFacebook.Font = new System.Drawing.Font("Century Gothic", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.linkLabelFacebook.LinkColor = System.Drawing.Color.Purple;
		this.linkLabelFacebook.Location = new System.Drawing.Point(62, 14);
		this.linkLabelFacebook.Name = "linkLabelFacebook";
		this.linkLabelFacebook.Size = new System.Drawing.Size(84, 18);
		this.linkLabelFacebook.TabIndex = 6;
		this.linkLabelFacebook.TabStop = true;
		this.linkLabelFacebook.Text = "Facebook";
		this.linkLabelFacebook.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabelFacebook_LinkClicked);
		this.labelToolName.AutoSize = true;
		this.labelToolName.Cursor = System.Windows.Forms.Cursors.Hand;
		this.labelToolName.Font = new System.Drawing.Font("Tahoma", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.labelToolName.ForeColor = System.Drawing.Color.Green;
		this.labelToolName.Location = new System.Drawing.Point(690, 14);
		this.labelToolName.Name = "labelToolName";
		this.labelToolName.Size = new System.Drawing.Size(258, 18);
		this.labelToolName.TabIndex = 5;
		this.labelToolName.Text = "Ad Campaigns All In One | V2.0.4";
		this.labelToolName.Click += new System.EventHandler(labelToolName_Click);
		this.BB186D8F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.BB186D8F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.BB186D8F.Image = (System.Drawing.Image)resources.GetObject("iconminimizar.Image");
		this.BB186D8F.Location = new System.Drawing.Point(984, 13);
		this.BB186D8F.Name = "iconminimizar";
		this.BB186D8F.Size = new System.Drawing.Size(18, 18);
		this.BB186D8F.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.BB186D8F.TabIndex = 4;
		this.BB186D8F.TabStop = false;
		this.BB186D8F.Click += new System.EventHandler(BB186D8F_Click);
		this.CB941E21.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.CB941E21.Cursor = System.Windows.Forms.Cursors.Hand;
		this.CB941E21.Image = (System.Drawing.Image)resources.GetObject("iconrestaurar.Image");
		this.CB941E21.Location = new System.Drawing.Point(1010, 13);
		this.CB941E21.Name = "iconrestaurar";
		this.CB941E21.Size = new System.Drawing.Size(18, 18);
		this.CB941E21.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.CB941E21.TabIndex = 3;
		this.CB941E21.TabStop = false;
		this.CB941E21.Visible = false;
		this.CB941E21.Click += new System.EventHandler(CB941E21_Click);
		this.B23B170F.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.B23B170F.Cursor = System.Windows.Forms.Cursors.Hand;
		this.B23B170F.Image = (System.Drawing.Image)resources.GetObject("iconmaximizar.Image");
		this.B23B170F.Location = new System.Drawing.Point(1010, 12);
		this.B23B170F.Name = "iconmaximizar";
		this.B23B170F.Size = new System.Drawing.Size(18, 18);
		this.B23B170F.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.B23B170F.TabIndex = 2;
		this.B23B170F.TabStop = false;
		this.B23B170F.Click += new System.EventHandler(D880B712);
		this.EE9A0085.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		this.EE9A0085.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EE9A0085.Image = (System.Drawing.Image)resources.GetObject("iconcerrar.Image");
		this.EE9A0085.Location = new System.Drawing.Point(1036, 13);
		this.EE9A0085.Name = "iconcerrar";
		this.EE9A0085.Size = new System.Drawing.Size(18, 18);
		this.EE9A0085.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.EE9A0085.TabIndex = 1;
		this.EE9A0085.TabStop = false;
		this.EE9A0085.Click += new System.EventHandler(A211D805);
		this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
		this.btnMenu.Image = (System.Drawing.Image)resources.GetObject("btnMenu.Image");
		this.btnMenu.Location = new System.Drawing.Point(8, 6);
		this.btnMenu.Name = "btnMenu";
		this.btnMenu.Size = new System.Drawing.Size(35, 35);
		this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
		this.btnMenu.TabIndex = 0;
		this.btnMenu.TabStop = false;
		this.btnMenu.Click += new System.EventHandler(D0112598);
		this.A988A784.AutoSize = true;
		this.A988A784.BackColor = System.Drawing.Color.WhiteSmoke;
		this.A988A784.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.A988A784.Dock = System.Windows.Forms.DockStyle.Fill;
		this.A988A784.Location = new System.Drawing.Point(233, 45);
		this.A988A784.Margin = new System.Windows.Forms.Padding(0);
		this.A988A784.Name = "panelContenedor";
		this.A988A784.Size = new System.Drawing.Size(1067, 603);
		this.A988A784.TabIndex = 2;
		this.A988A784.Paint += new System.Windows.Forms.PaintEventHandler(A988A784_Paint);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(1300, 650);
		base.Controls.Add(this.A988A784);
		base.Controls.Add(this.BarraTitulo);
		base.Controls.Add(this.MenuVertical);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		this.MinimumSize = new System.Drawing.Size(1200, 650);
		base.Name = "fMain";
		base.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "DOGETOOL";
		base.Load += new System.EventHandler(F9913527);
		this.MenuVertical.ResumeLayout(false);
		((System.ComponentModel.ISupportInitialize)this.btnlogoInicio).EndInit();
		this.BarraTitulo.ResumeLayout(false);
		this.BarraTitulo.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.BB186D8F).EndInit();
		((System.ComponentModel.ISupportInitialize)this.CB941E21).EndInit();
		((System.ComponentModel.ISupportInitialize)this.B23B170F).EndInit();
		((System.ComponentModel.ISupportInitialize)this.EE9A0085).EndInit();
		((System.ComponentModel.ISupportInitialize)this.btnMenu).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
