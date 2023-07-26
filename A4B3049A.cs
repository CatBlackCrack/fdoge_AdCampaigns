using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class A4B3049A : Form
{
	public static string string_0;

	private IContainer BF857A32 = null;

	private Label A6B7D2AE;

	private Button buttonCancel;

	private Button EE24DC23;

	private TextBox textBoxKeyword;

	public A4B3049A()
	{
		InitializeComponent();
	}

	private void EE24DC23_Click(object sender, EventArgs e)
	{
		string_0 = textBoxKeyword.Text.Trim();
		Hide();
	}

	private void A4AA2182(object sender, EventArgs e)
	{
		string_0 = null;
		Hide();
	}

	private void textBoxKeyword_TextChanged(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool A7272B8F)
	{
		if (A7272B8F && BF857A32 != null)
		{
			BF857A32.Dispose();
		}
		base.Dispose(A7272B8F);
	}

	private void InitializeComponent()
	{
		this.A6B7D2AE = new System.Windows.Forms.Label();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.EE24DC23 = new System.Windows.Forms.Button();
		this.textBoxKeyword = new System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.A6B7D2AE.AutoSize = true;
		this.A6B7D2AE.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold);
		this.A6B7D2AE.Location = new System.Drawing.Point(200, 21);
		this.A6B7D2AE.Name = "label1";
		this.A6B7D2AE.Size = new System.Drawing.Size(99, 16);
		this.A6B7D2AE.TabIndex = 57;
		this.A6B7D2AE.Text = "Nhập nội dung";
		this.buttonCancel.BackColor = System.Drawing.Color.Red;
		this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonCancel.FlatAppearance.BorderSize = 0;
		this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.buttonCancel.ForeColor = System.Drawing.Color.White;
		this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.buttonCancel.Location = new System.Drawing.Point(257, 95);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(98, 29);
		this.buttonCancel.TabIndex = 56;
		this.buttonCancel.Text = "Cancel";
		this.buttonCancel.UseVisualStyleBackColor = false;
		this.buttonCancel.Click += new System.EventHandler(A4AA2182);
		this.EE24DC23.BackColor = System.Drawing.Color.Green;
		this.EE24DC23.Cursor = System.Windows.Forms.Cursors.Hand;
		this.EE24DC23.FlatAppearance.BorderSize = 0;
		this.EE24DC23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.EE24DC23.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.EE24DC23.ForeColor = System.Drawing.Color.White;
		this.EE24DC23.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.EE24DC23.Location = new System.Drawing.Point(135, 95);
		this.EE24DC23.Name = "buttonOK";
		this.EE24DC23.Size = new System.Drawing.Size(103, 29);
		this.EE24DC23.TabIndex = 55;
		this.EE24DC23.Text = "OK";
		this.EE24DC23.UseVisualStyleBackColor = false;
		this.EE24DC23.Click += new System.EventHandler(EE24DC23_Click);
		this.textBoxKeyword.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.textBoxKeyword.Location = new System.Drawing.Point(135, 57);
		this.textBoxKeyword.Name = "textBoxKeyword";
		this.textBoxKeyword.Size = new System.Drawing.Size(220, 22);
		this.textBoxKeyword.TabIndex = 54;
		this.textBoxKeyword.TextChanged += new System.EventHandler(textBoxKeyword_TextChanged);
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 14f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.ActiveCaption;
		base.ClientSize = new System.Drawing.Size(494, 180);
		base.Controls.Add(this.A6B7D2AE);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.EE24DC23);
		base.Controls.Add(this.textBoxKeyword);
		this.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fNhapTuKhoa";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "fNhapTuKhoa";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
