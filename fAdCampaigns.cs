using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

public class fAdCampaigns : Form
{
	private IContainer E33FFDBA = null;

	private RadioButton radioButtonSetBoostPost;

	private RadioButton radioButtonSetPE;

	private RadioButton radioButtonChangePost;

	private Panel panelControl;

	public fAdCampaigns()
	{
		//Discarded unreachable code: IL_0044, IL_004f, IL_0069, IL_0074, IL_008e, IL_0099
		InitializeComponent();
		string json = Class7.smethod_0(Directory.GetCurrentDirectory() + "\\config.json");
		JObject jObject = JObject.Parse(json);
		_ = (bool)jObject["radioButtonSetBoostPost"];
		/*Error near IL_003f: Invalid metadata token*/;
	}

	private void method_0(object object_0)
	{
		if (panelControl.Controls.Count > 0)
		{
			panelControl.Controls.RemoveAt(0);
		}
		Form form = object_0 as Form;
		form.TopLevel = false;
		form.Dock = DockStyle.Fill;
		panelControl.Controls.Add(form);
		panelControl.Tag = form;
		form.Show();
	}

	private void radioButtonSetBoostPost_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = radioButtonSetBoostPost.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void B03F0401(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = radioButtonSetPE.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void C73A27B4(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = radioButtonChangePost.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	protected override void Dispose(bool F01E2006)
	{
		if (F01E2006 && E33FFDBA != null)
		{
			E33FFDBA.Dispose();
		}
		base.Dispose(F01E2006);
	}

	private void InitializeComponent()
	{
		this.radioButtonSetBoostPost = new System.Windows.Forms.RadioButton();
		this.radioButtonSetPE = new System.Windows.Forms.RadioButton();
		this.radioButtonChangePost = new System.Windows.Forms.RadioButton();
		this.panelControl = new System.Windows.Forms.Panel();
		base.SuspendLayout();
		this.radioButtonSetBoostPost.AutoSize = true;
		this.radioButtonSetBoostPost.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.radioButtonSetBoostPost.ForeColor = System.Drawing.Color.Green;
		this.radioButtonSetBoostPost.Location = new System.Drawing.Point(88, 8);
		this.radioButtonSetBoostPost.Name = "radioButtonSetBoostPost";
		this.radioButtonSetBoostPost.Size = new System.Drawing.Size(140, 18);
		this.radioButtonSetBoostPost.TabIndex = 8;
		this.radioButtonSetBoostPost.Text = "Set camp BoostPost ";
		this.radioButtonSetBoostPost.UseVisualStyleBackColor = true;
		this.radioButtonSetBoostPost.CheckedChanged += new System.EventHandler(radioButtonSetBoostPost_CheckedChanged);
		this.radioButtonSetPE.AutoSize = true;
		this.radioButtonSetPE.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.radioButtonSetPE.ForeColor = System.Drawing.Color.Green;
		this.radioButtonSetPE.Location = new System.Drawing.Point(234, 8);
		this.radioButtonSetPE.Name = "radioButtonSetPE";
		this.radioButtonSetPE.Size = new System.Drawing.Size(95, 18);
		this.radioButtonSetPE.TabIndex = 7;
		this.radioButtonSetPE.Text = "Set camp PE";
		this.radioButtonSetPE.UseVisualStyleBackColor = true;
		this.radioButtonSetPE.CheckedChanged += new System.EventHandler(B03F0401);
		this.radioButtonChangePost.AutoSize = true;
		this.radioButtonChangePost.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.radioButtonChangePost.ForeColor = System.Drawing.Color.Green;
		this.radioButtonChangePost.Location = new System.Drawing.Point(344, 8);
		this.radioButtonChangePost.Name = "radioButtonChangePost";
		this.radioButtonChangePost.Size = new System.Drawing.Size(70, 18);
		this.radioButtonChangePost.TabIndex = 9;
		this.radioButtonChangePost.Text = "Đổi post";
		this.radioButtonChangePost.UseVisualStyleBackColor = true;
		this.radioButtonChangePost.Visible = false;
		this.radioButtonChangePost.CheckedChanged += new System.EventHandler(C73A27B4);
		this.panelControl.Location = new System.Drawing.Point(12, 36);
		this.panelControl.Name = "panelControl";
		this.panelControl.Size = new System.Drawing.Size(803, 383);
		this.panelControl.TabIndex = 10;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 16f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(840, 431);
		base.Controls.Add(this.panelControl);
		base.Controls.Add(this.radioButtonChangePost);
		base.Controls.Add(this.radioButtonSetBoostPost);
		base.Controls.Add(this.radioButtonSetPE);
		this.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
		base.Name = "fAdCampaigns";
		this.Text = "fAdCampaigns";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
