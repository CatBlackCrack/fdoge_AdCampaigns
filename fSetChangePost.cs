using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class fSetChangePost : Form
{
	private IContainer E508908E = null;

	public fSetChangePost()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool A7272B8F)
	{
		if (A7272B8F && E508908E != null)
		{
			E508908E.Dispose();
		}
		base.Dispose(A7272B8F);
	}

	private void InitializeComponent()
	{
		base.SuspendLayout();
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(800, 450);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "fSetChangePost";
		this.Text = "fSetChangePost";
		base.ResumeLayout(false);
	}
}
