using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Forms_Example
{
	/// <summary>
	/// Summary description for fclsMyNewForm.
	/// </summary>
	public class fclsMyNewForm : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnCloseMe;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public fclsMyNewForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnCloseMe = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnCloseMe
			// 
			this.btnCloseMe.Location = new System.Drawing.Point(112, 112);
			this.btnCloseMe.Name = "btnCloseMe";
			this.btnCloseMe.TabIndex = 0;
			this.btnCloseMe.Text = "Close Me";
			this.btnCloseMe.Click += new System.EventHandler(this.btnCloseMe_Click);
			// 
			// fclsMyNewForm
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnCloseMe});
			this.Name = "fclsMyNewForm";
			this.Text = "fclsMyNewForm";
			this.ResumeLayout(false);

		}
		#endregion

		private void btnCloseMe_Click(object sender, System.EventArgs e)
		{
			this.Close();

		}

	
	}
}
