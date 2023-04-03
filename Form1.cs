using Microsoft.EntityFrameworkCore;

namespace zad1_1
{
	public partial class Form1 : Form
	{
		private BindingSource userBindingSource = new BindingSource();

		public Form1()
		{
			InitializeComponent();
			dataGridView.DataSource = userBindingSource;
		}

		

		private void Form1_Load(object sender, EventArgs e)
		{
			RefreshUserList();
		}

		private void RefreshUserList()
		{
			using (var db = new MyDbContext())
			{
				userBindingSource.DataSource = db.Users.ToList();
			}
			userBindingSource.ResetBindings(false);
		}


		private void GetRecord(int id)
		{
			using (var db = new MyDbContext())
			{
				var user = db.Users.FirstOrDefault(u => u.Id == id);
				if (user != null)
				{
					txtName.Text = user.Name;
					txtPhone.Text = user.Phone;
				}
				else
				{
					MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void NewRecord()
		{
			txtName.Text = "";
			txtPhone.Text = "";
			txtId.Text = "";
		}


		private void AddRecord()
		{
			using (var db = new MyDbContext())
			{
				// Create a new User object with data from the form
				var newUser = new User
				{
					Name = txtName.Text,
					Phone = txtPhone.Text
				};
				// Check if user exists in database
				var existingUser = db.Users.FirstOrDefault(u => u.Name == newUser.Name);
				if (existingUser != null)
				{
					MessageBox.Show("User is already in database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{

					// Add the new user to the database
					db.Users.Add(newUser);
					db.SaveChanges();

					// Refresh the user list to display the new user
					RefreshUserList();

					// Clear the form fields
					NewRecord();
				}
				
			}
		}

		private void EditRecord(int id)
		{
			using (var db = new MyDbContext())
			{
				var user = db.Users.FirstOrDefault(u => u.Id == id);
				if (user != null)
				{
					//Edit selected user
					user.Name = txtName.Text;
					user.Phone = txtPhone.Text;
					db.SaveChanges();
				}

				else
				{
					MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				// Refresh the user list to display the new user
				RefreshUserList();

				// Clear the form fields
				NewRecord();
			}
		}

		private void DeleteRecord(int id)
		{
			using (var db = new MyDbContext())
			{
				var user = db.Users.FirstOrDefault(u => u.Id == id);
				if (user != null)
				{

					// Remove user from database
					db.Users.Remove(user);
					db.SaveChanges();
					RefreshUserList();
				}
				else
				{
					MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				// Refresh the user list to display the new user
				RefreshUserList();

				// Clear the form fields
				NewRecord();
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
		
		}

		private void btnGet_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtId.Text);
            GetRecord(id);
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			string name = txtName.Text;
			AddRecord();
			RefreshUserList();

		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtId.Text);
			EditRecord(id);
			RefreshUserList();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = Convert.ToInt32(txtId.Text);
			DeleteRecord(id);

		}
	}
}