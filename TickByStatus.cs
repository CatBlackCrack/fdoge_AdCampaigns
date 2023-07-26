using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class TickByStatus : Form
{
	public static string C5B2EEB8;

	private IContainer icontainer_0 = null;

	private Label label1;

	private TextBox C2AD0321;

	private Button buttonCancel;

	private Button buttonOK;

	public TickByStatus()
	{
		InitializeComponent();
	}

	private void C0A99C3E(object sender, EventArgs e)
	{
		C5B2EEB8 = C2AD0321.Text.Trim();
		Hide();
	}

	private void E2A49D07(object sender, EventArgs e)
	{
		C5B2EEB8 = null;
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

	private void InitializeComponent()
	{
		this.label1 = new System.Windows.Forms.Label();
		this.C2AD0321 = new System.Windows.Forms.TextBox();
		this.buttonCancel = new System.Windows.Forms.Button();
		this.buttonOK = new System.Windows.Forms.Button();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold);
		this.label1.Location = new System.Drawing.Point(179, 27);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(94, 16);
		this.label1.TabIndex = 7;
		this.label1.Text = "Nhập từ khóa";
		this.C2AD0321.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.C2AD0321.Location = new System.Drawing.Point(112, 57);
		this.C2AD0321.Name = "textBoxKeyword";
		this.C2AD0321.Size = new System.Drawing.Size(220, 22);
		this.C2AD0321.TabIndex = 6;
		this.buttonCancel.BackColor = System.Drawing.Color.Red;
		this.buttonCancel.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonCancel.FlatAppearance.BorderSize = 0;
		this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonCancel.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.buttonCancel.ForeColor = System.Drawing.Color.White;
		this.buttonCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.buttonCancel.Location = new System.Drawing.Point(234, 95);
		this.buttonCancel.Name = "buttonCancel";
		this.buttonCancel.Size = new System.Drawing.Size(98, 29);
		this.buttonCancel.TabIndex = 49;
		this.buttonCancel.Text = "Cancel";
		this.buttonCancel.UseVisualStyleBackColor = false;
		this.buttonCancel.Click += new System.EventHandler(E2A49D07);
		this.buttonOK.BackColor = System.Drawing.Color.Green;
		this.buttonOK.Cursor = System.Windows.Forms.Cursors.Hand;
		this.buttonOK.FlatAppearance.BorderSize = 0;
		this.buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
		this.buttonOK.Font = new System.Drawing.Font("Tahoma", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.buttonOK.ForeColor = System.Drawing.Color.White;
		this.buttonOK.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.buttonOK.Location = new System.Drawing.Point(112, 95);
		this.buttonOK.Name = "buttonOK";
		this.buttonOK.Size = new System.Drawing.Size(103, 29);
		this.buttonOK.TabIndex = 48;
		this.buttonOK.Text = "OK";
		this.buttonOK.UseVisualStyleBackColor = false;
		this.buttonOK.Click += new System.EventHandler(C0A99C3E);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.SystemColors.ActiveCaption;
		base.ClientSize = new System.Drawing.Size(447, 165);
		base.Controls.Add(this.buttonCancel);
		base.Controls.Add(this.buttonOK);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.C2AD0321);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "TickByStatus";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "TickByStatus";
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
