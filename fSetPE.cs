using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

public class fSetPE : Form
{
	private IContainer icontainer_0 = null;

	private CheckBox checkBoxCreateDraft;

	private CheckBox checkBoxPublishDraft;

	private Label label1;

	private TextBox A8B7773D;

	private Button buttonOpenCSV;

	public fSetPE()
	{
		//Discarded unreachable code: IL_0044, IL_004f, IL_0069, IL_0074, IL_008e, IL_0099
		InitializeComponent();
		string json = Class7.smethod_0(Directory.GetCurrentDirectory() + "\\config.json");
		JObject jObject = JObject.Parse(json);
		_ = (bool)jObject["checkBoxCreateDraft"];
		/*Error near IL_003f: Invalid metadata token*/;
	}

	private void checkBoxCreateDraft_CheckedChanged(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxCreateDraft.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void D415890C(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = checkBoxPublishDraft.Checked;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void CC17F31B(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0010, IL_001a
		_ = A8B7773D.Text;
		/*Error near IL_000b: Invalid metadata token*/;
	}

	private void buttonOpenCSV_Click(object sender, EventArgs e)
	{
		try
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.FilterIndex = 0;
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				A8B7773D.Text = openFileDialog.FileName;
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
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
		this.checkBoxCreateDraft = new System.Windows.Forms.CheckBox();
		this.checkBoxPublishDraft = new System.Windows.Forms.CheckBox();
		this.label1 = new System.Windows.Forms.Label();
		this.A8B7773D = new System.Windows.Forms.TextBox();
		this.buttonOpenCSV = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.checkBoxCreateDraft.AutoSize = true;
		this.checkBoxCreateDraft.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxCreateDraft.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBoxCreateDraft.Location = new System.Drawing.Point(88, 8);
		this.checkBoxCreateDraft.Name = "checkBoxCreateDraft";
		this.checkBoxCreateDraft.Size = new System.Drawing.Size(102, 18);
		this.checkBoxCreateDraft.TabIndex = 183;
		this.checkBoxCreateDraft.Text = "Tạo bản nháp";
		this.checkBoxCreateDraft.UseVisualStyleBackColor = true;
		this.checkBoxCreateDraft.CheckedChanged += new System.EventHandler(checkBoxCreateDraft_CheckedChanged);
		this.checkBoxPublishDraft.AutoSize = true;
		this.checkBoxPublishDraft.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.checkBoxPublishDraft.ForeColor = System.Drawing.Color.FromArgb(192, 0, 0);
		this.checkBoxPublishDraft.Location = new System.Drawing.Point(207, 8);
		this.checkBoxPublishDraft.Name = "checkBoxPublishDraft";
		this.checkBoxPublishDraft.Size = new System.Drawing.Size(109, 18);
		this.checkBoxPublishDraft.TabIndex = 184;
		this.checkBoxPublishDraft.Text = "Đăng bản nháp";
		this.checkBoxPublishDraft.UseVisualStyleBackColor = true;
		this.checkBoxPublishDraft.CheckedChanged += new System.EventHandler(D415890C);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(85, 37);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(79, 14);
		this.label1.TabIndex = 185;
		this.label1.Text = "Chọn file csv:";
		this.A8B7773D.Location = new System.Drawing.Point(170, 34);
		this.A8B7773D.Name = "textBoxPathFileCSV";
		this.A8B7773D.Size = new System.Drawing.Size(482, 22);
		this.A8B7773D.TabIndex = 186;
		this.A8B7773D.TextChanged += new System.EventHandler(CC17F31B);
		this.buttonOpenCSV.Location = new System.Drawing.Point(659, 34);
		this.buttonOpenCSV.Name = "buttonOpenCSV";
		this.buttonOpenCSV.Size = new System.Drawing.Size(59, 23);
		this.buttonOpenCSV.TabIndex = 187;
		this.buttonOpenCSV.Text = "...";
		this.buttonOpenCSV.UseVisualStyleBackColor = true;
		this.buttonOpenCSV.Click += new System.EventHandler(buttonOpenCSV_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 14f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(732, 272);
		base.Controls.Add(this.buttonOpenCSV);
		base.Controls.Add(this.A8B7773D);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.checkBoxPublishDraft);
		base.Controls.Add(this.checkBoxCreateDraft);
		this.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fSetPE";
		this.Text = "fSetPE";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
