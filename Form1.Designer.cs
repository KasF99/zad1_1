namespace zad1_1
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.name_l = new System.Windows.Forms.Label();
			this.phone_l = new System.Windows.Forms.Label();
			this.id_l = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.btnGet = new System.Windows.Forms.Button();
			this.btnNew = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView
			// 
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(198, 12);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.Height = 25;
			this.dataGridView.Size = new System.Drawing.Size(351, 212);
			this.dataGridView.TabIndex = 0;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(423, 259);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(100, 23);
			this.txtName.TabIndex = 6;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(423, 289);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(100, 23);
			this.txtPhone.TabIndex = 7;
			// 
			// name_l
			// 
			this.name_l.AutoSize = true;
			this.name_l.Location = new System.Drawing.Point(380, 262);
			this.name_l.Name = "name_l";
			this.name_l.Size = new System.Drawing.Size(37, 15);
			this.name_l.TabIndex = 8;
			this.name_l.Text = "name";
			// 
			// phone_l
			// 
			this.phone_l.AutoSize = true;
			this.phone_l.Location = new System.Drawing.Point(376, 292);
			this.phone_l.Name = "phone_l";
			this.phone_l.Size = new System.Drawing.Size(41, 15);
			this.phone_l.TabIndex = 9;
			this.phone_l.Text = "phone";
			// 
			// id_l
			// 
			this.id_l.AutoSize = true;
			this.id_l.Location = new System.Drawing.Point(400, 320);
			this.id_l.Name = "id_l";
			this.id_l.Size = new System.Drawing.Size(17, 15);
			this.id_l.TabIndex = 10;
			this.id_l.Text = "id";
			this.id_l.Click += new System.EventHandler(this.label1_Click);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(423, 317);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(100, 23);
			this.txtId.TabIndex = 11;
			// 
			// btnGet
			// 
			this.btnGet.Location = new System.Drawing.Point(198, 259);
			this.btnGet.Name = "btnGet";
			this.btnGet.Size = new System.Drawing.Size(75, 23);
			this.btnGet.TabIndex = 12;
			this.btnGet.Text = "btnGet";
			this.btnGet.UseVisualStyleBackColor = true;
			this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
			// 
			// btnNew
			// 
			this.btnNew.Location = new System.Drawing.Point(198, 288);
			this.btnNew.Name = "btnNew";
			this.btnNew.Size = new System.Drawing.Size(75, 23);
			this.btnNew.TabIndex = 13;
			this.btnNew.Text = "btnNew";
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(198, 317);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 14;
			this.btnSave.Text = "btnEdit";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(198, 346);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 15;
			this.btnDelete.Text = "btnDelete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.btnGet);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.id_l);
			this.Controls.Add(this.phone_l);
			this.Controls.Add(this.name_l);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.dataGridView);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView dataGridView;
		private TextBox txtName;
		private TextBox txtPhone;
		private Label name_l;
		private Label phone_l;
		private Label id_l;
		private TextBox txtId;
		private Button btnGet;
		private Button btnNew;
		private Button btnSave;
		private Button btnDelete;
	}
}