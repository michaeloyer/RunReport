using System;
using System.Windows.Forms;

namespace DataPull
{
    public partial class DataPullGeneratorForm : Form
    {
        private IReportCreator selectedReportCreator
        {
            get
            {
                if (tabControl.SelectedTab == tabStandard)
                    return treStandard.SelectedNode?.Tag as IReportCreator;
                else
                    return null;
            }
        }

        private bool reportCreatorSelected => 
            (selectedReportCreator != null);

        public DataPullGeneratorForm()
        {
            InitializeComponent();

            var standardReportCreatorNodes = Utilities.ReportCreators.GetStandardReportCreatorNodes();
            GenerateReportCreators(treStandard, standardReportCreatorNodes);
            CheckFormState();
        }

        private void GenerateReportCreators(TreeView treeView, TreeNode[] creatorNodes)
        {
            treeView.Nodes.Clear();
            treeView.Nodes.AddRange(creatorNodes);
            treeView.ExpandAll();
        }

        private void CheckFormState()
        {
            //Parent node tags are null, child node tags are ReportCreator objects.
            cmdGenerate.Enabled = reportCreatorSelected;
            cmdGenerateAndClose.Enabled = reportCreatorSelected;
            treStandard.Enabled = true;
        }

        private void GenerateReport()
        {
            DisableButtons();

            using (var loadForm = new LoadForm())
            {
                loadForm.Show();

                try
                {
                    selectedReportCreator.CreateReport();
                }
                catch (System.Data.SqlClient.SqlException e)
                {
                    MessageBox.Show("There was an error getting data from the SQL Database.\n\nError Message:\n" + e.Message);
                }

                loadForm.Hide();
            }
        }

        private void DisableButtons()
        {
            treStandard.Enabled = false;
            cmdGenerate.Enabled = false;
            cmdGenerateAndClose.Enabled = false;
        }

        private void cmdGenerate_Click(object sender, EventArgs e)
        {
            GenerateReport();
            CheckFormState();
        }

        private void cmdGenerateAndClose_Click(object sender, EventArgs e)
        {
            GenerateReport();
            this.Close();
        }

        private void treStandard_AfterSelect(object sender, TreeViewEventArgs e)
        {
            CheckFormState();
        }

        private void treStandard_DoubleClick(object sender, EventArgs e)
        {
            cmdGenerate_Click(sender, e);
        }
    }
}
