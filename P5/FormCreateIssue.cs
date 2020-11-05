using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using P5;

namespace Builder
{
    public partial class FormCreateIssue : Form
    {
        public int newIssueID;
        public FakeIssueRepository formIssueRepo;
        public int selectedProject;
        public FormCreateIssue(int issueID, FakeIssueRepository issueRepo, int project)
        {
            InitializeComponent();

            newIssueID = issueID;
            formIssueRepo = issueRepo;
            selectedProject = project;
        }

        private void FormCreateIssue_Load(object sender, EventArgs e)
        {
            dateTimePicker.MaxDate = DateTime.Today;
            IssueIDBox.Text = newIssueID + "";
            FakeAppUserRepository userRepo = new FakeAppUserRepository();
            FakeIssueStatusRepository statusRepo = new FakeIssueStatusRepository();
            string fullName;

            foreach (AppUser user in userRepo.GetAll())
            {
                fullName = user.LastName + ", " + user.FirstName;
                DiscovererBox.Items.Add(fullName);
            }

            foreach (IssueStatus status in statusRepo.GetAll())
            {
                StatusBox.Items.Add(status.Value);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Dispose();
        }

        private void CreateIssueButton_Click(object sender, EventArgs e)
        {
            Issue newIssue = new Issue();

            if (string.IsNullOrWhiteSpace(TitleBox.Text))
            {
                MessageBox.Show("No issue title provided", "Attention", MessageBoxButtons.OK);

            }

        }
    }
}
