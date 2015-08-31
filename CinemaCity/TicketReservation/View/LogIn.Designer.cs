namespace TicketReservation {
	partial class LogIn {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.LayoutLogIn = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonClient = new System.Windows.Forms.Button();
			this.buttonAdmin = new System.Windows.Forms.Button();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.buttonLogAdmin = new System.Windows.Forms.Button();
			this.LayoutUsrPass = new System.Windows.Forms.TableLayoutPanel();
			this.labelUsr = new System.Windows.Forms.Label();
			this.labelPasswd = new System.Windows.Forms.Label();
			this.textBoxUser = new System.Windows.Forms.TextBox();
			this.textBoxPasswd = new System.Windows.Forms.TextBox();
			this.LayoutLogIn.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.LayoutUsrPass.SuspendLayout();
			this.SuspendLayout();
			// 
			// LayoutLogIn
			// 
			this.LayoutLogIn.ColumnCount = 1;
			this.LayoutLogIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.LayoutLogIn.Controls.Add(this.tableLayoutPanel2, 0, 1);
			this.LayoutLogIn.Controls.Add(this.tableLayoutPanel3, 0, 0);
			this.LayoutLogIn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LayoutLogIn.Location = new System.Drawing.Point(0, 0);
			this.LayoutLogIn.Name = "LayoutLogIn";
			this.LayoutLogIn.RowCount = 2;
			this.LayoutLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.93507F));
			this.LayoutLogIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.06493F));
			this.LayoutLogIn.Size = new System.Drawing.Size(617, 376);
			this.LayoutLogIn.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Controls.Add(this.buttonClient, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.buttonAdmin, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 247);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(611, 126);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// buttonClient
			// 
			this.buttonClient.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonClient.Location = new System.Drawing.Point(3, 3);
			this.buttonClient.Name = "buttonClient";
			this.buttonClient.Size = new System.Drawing.Size(299, 55);
			this.buttonClient.TabIndex = 0;
			this.buttonClient.Text = "Client";
			this.buttonClient.UseVisualStyleBackColor = true;
			this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
			// 
			// buttonAdmin
			// 
			this.buttonAdmin.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonAdmin.Location = new System.Drawing.Point(308, 3);
			this.buttonAdmin.Name = "buttonAdmin";
			this.buttonAdmin.Size = new System.Drawing.Size(300, 55);
			this.buttonAdmin.TabIndex = 1;
			this.buttonAdmin.Text = "Admin";
			this.buttonAdmin.UseVisualStyleBackColor = true;
			this.buttonAdmin.Click += new System.EventHandler(this.buttonAdmin_Click);
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.78947F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.21053F));
			this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 0);
			this.tableLayoutPanel3.Controls.Add(this.LayoutUsrPass, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(611, 238);
			this.tableLayoutPanel3.TabIndex = 1;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.buttonLogAdmin, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(368, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.7931F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.84483F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.7931F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(240, 232);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// buttonLogAdmin
			// 
			this.buttonLogAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonLogAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogAdmin.Location = new System.Drawing.Point(3, 92);
			this.buttonLogAdmin.Name = "buttonLogAdmin";
			this.buttonLogAdmin.Size = new System.Drawing.Size(234, 46);
			this.buttonLogAdmin.TabIndex = 3;
			this.buttonLogAdmin.Text = "Log In";
			this.buttonLogAdmin.UseVisualStyleBackColor = true;
			this.buttonLogAdmin.Visible = false;
			this.buttonLogAdmin.Click += new System.EventHandler(this.buttonLogAdmin_Click);
			// 
			// LayoutUsrPass
			// 
			this.LayoutUsrPass.ColumnCount = 2;
			this.LayoutUsrPass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.73684F));
			this.LayoutUsrPass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.26316F));
			this.LayoutUsrPass.Controls.Add(this.labelUsr, 0, 0);
			this.LayoutUsrPass.Controls.Add(this.labelPasswd, 0, 1);
			this.LayoutUsrPass.Controls.Add(this.textBoxUser, 1, 0);
			this.LayoutUsrPass.Controls.Add(this.textBoxPasswd, 1, 1);
			this.LayoutUsrPass.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LayoutUsrPass.Location = new System.Drawing.Point(3, 3);
			this.LayoutUsrPass.Name = "LayoutUsrPass";
			this.LayoutUsrPass.RowCount = 2;
			this.LayoutUsrPass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.LayoutUsrPass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.LayoutUsrPass.Size = new System.Drawing.Size(359, 232);
			this.LayoutUsrPass.TabIndex = 2;
			this.LayoutUsrPass.Visible = false;
			// 
			// labelUsr
			// 
			this.labelUsr.AutoSize = true;
			this.labelUsr.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.labelUsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelUsr.Location = new System.Drawing.Point(3, 91);
			this.labelUsr.Name = "labelUsr";
			this.labelUsr.Size = new System.Drawing.Size(154, 25);
			this.labelUsr.TabIndex = 0;
			this.labelUsr.Text = "User:";
			this.labelUsr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// labelPasswd
			// 
			this.labelPasswd.AutoSize = true;
			this.labelPasswd.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelPasswd.Location = new System.Drawing.Point(3, 116);
			this.labelPasswd.Name = "labelPasswd";
			this.labelPasswd.Size = new System.Drawing.Size(154, 25);
			this.labelPasswd.TabIndex = 1;
			this.labelPasswd.Text = "Password:";
			this.labelPasswd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// textBoxUser
			// 
			this.textBoxUser.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.textBoxUser.Location = new System.Drawing.Point(163, 91);
			this.textBoxUser.Name = "textBoxUser";
			this.textBoxUser.Size = new System.Drawing.Size(193, 22);
			this.textBoxUser.TabIndex = 2;
			// 
			// textBoxPasswd
			// 
			this.textBoxPasswd.Dock = System.Windows.Forms.DockStyle.Top;
			this.textBoxPasswd.Location = new System.Drawing.Point(163, 119);
			this.textBoxPasswd.Name = "textBoxPasswd";
			this.textBoxPasswd.PasswordChar = '*';
			this.textBoxPasswd.Size = new System.Drawing.Size(193, 22);
			this.textBoxPasswd.TabIndex = 3;
			// 
			// LogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(617, 376);
			this.Controls.Add(this.LayoutLogIn);
			this.Name = "LogIn";
			this.Text = "Log In";
			this.LayoutLogIn.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.LayoutUsrPass.ResumeLayout(false);
			this.LayoutUsrPass.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel LayoutLogIn;
		private System.Windows.Forms.Button buttonClient;
		private System.Windows.Forms.Button buttonAdmin;
		private System.Windows.Forms.TableLayoutPanel LayoutUsrPass;
		private System.Windows.Forms.Label labelUsr;
		private System.Windows.Forms.Label labelPasswd;
		private System.Windows.Forms.TextBox textBoxUser;
		private System.Windows.Forms.TextBox textBoxPasswd;
		private System.Windows.Forms.Button buttonLogAdmin;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
	}
}

