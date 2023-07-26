using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class F9AD692B : Form
{
	public static string string_0;

	private IContainer icontainer_0 = null;

	private Label label1;

	private Button buttonCancel;

	private Button buttonOK;

	private RichTextBox richTextBoxID;

	public F9AD692B()
	{
		BCB24C24();
	}

	private void buttonOK_Click(object sender, EventArgs e)
	{
		string_0 = richTextBoxID.Text.Trim();
		Hide();
	}

	private void C3BBE50C(object sender, EventArgs e)
	{
		string_0 = null;
		Hide();
	}

	protected override void Dispose(bool A7272B8F)
	{
		if (A7272B8F && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(A7272B8F);
	}

	private void BCB24C24()
	{
		label1 = new Label();
		buttonCancel = new Button();
		buttonOK = new Button();
		richTextBoxID = new RichTextBox();
		SuspendLayout();
		label1.AutoSize = true;
		label1.Font = new Font("Tahoma", 9.75f, FontStyle.Bold);
		label1.Location = new Point(198, 28);
		label1.Name = "label1";
		label1.Size = new Size(111, 16);
		label1.TabIndex = 61;
		label1.Text = "Nhập id vào đây";
		buttonCancel.BackColor = Color.Red;
		buttonCancel.Cursor = Cursors.Hand;
		buttonCancel.FlatAppearance.BorderSize = 0;
		buttonCancel.FlatStyle = FlatStyle.Flat;
		buttonCancel.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		buttonCancel.ForeColor = Color.White;
		buttonCancel.ImageAlign = ContentAlignment.MiddleRight;
		buttonCancel.Location = new Point(255, 100);
		buttonCancel.Name = "buttonCancel";
		buttonCancel.Size = new Size(98, 29);
		buttonCancel.TabIndex = 60;
		buttonCancel.Text = "Cancel";
		buttonCancel.UseVisualStyleBackColor = false;
		buttonCancel.Click += C3BBE50C;
		buttonOK.BackColor = Color.Green;
		buttonOK.Cursor = Cursors.Hand;
		buttonOK.FlatAppearance.BorderSize = 0;
		buttonOK.FlatStyle = FlatStyle.Flat;
		buttonOK.Font = new Font("Tahoma", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
		buttonOK.ForeColor = Color.White;
		buttonOK.ImageAlign = ContentAlignment.MiddleRight;
		buttonOK.Location = new Point(133, 100);
		buttonOK.Name = "buttonOK";
		buttonOK.Size = new Size(103, 29);
		buttonOK.TabIndex = 59;
		buttonOK.Text = "OK";
		buttonOK.UseVisualStyleBackColor = false;
		buttonOK.Click += buttonOK_Click;
		richTextBoxID.Location = new Point(133, 55);
		richTextBoxID.Name = "richTextBoxID";
		richTextBoxID.Size = new Size(220, 39);
		richTextBoxID.TabIndex = 62;
		richTextBoxID.Text = "";
		base.AutoScaleDimensions = new SizeF(7f, 14f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = SystemColors.ActiveCaption;
		base.ClientSize = new Size(483, 188);
		base.Controls.Add(richTextBoxID);
		base.Controls.Add(label1);
		base.Controls.Add(buttonCancel);
		base.Controls.Add(buttonOK);
		Font = new Font("Tahoma", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "fNhapID";
		base.StartPosition = FormStartPosition.CenterScreen;
		Text = "fNhapID";
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
