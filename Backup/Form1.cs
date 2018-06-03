using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Forms_Example
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class fclsExample : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button btnShowForm;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public fclsExample()
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
				if (components != null) 
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(fclsExample));
			this.btnShowForm = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnShowForm
			// 
			this.btnShowForm.Location = new System.Drawing.Point(112, 112);
			this.btnShowForm.Name = "btnShowForm";
			this.btnShowForm.TabIndex = 0;
			this.btnShowForm.Text = "Show Form";
			this.btnShowForm.Click += new System.EventHandler(this.btnShowForm_Click);
			// 
			// fclsExample
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackgroundImage = ((System.Drawing.Bitmap)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(292, 273);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.btnShowForm});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "fclsExample";
			this.Text = "Building Forms Example";
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new fclsExample());
		}

		private void btnShowForm_Click(object sender, System.EventArgs e)
		{
			fclsMyNewForm frmTest = new fclsMyNewForm();
			frmTest.ShowDialog();
		}
	}
}
