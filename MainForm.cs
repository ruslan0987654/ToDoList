using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace TaskManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AddTask(object sender, EventArgs e)
        {
            if (!CheckTaskData())
                return;

            string taskName = txtTask.Text.Trim();
            string taskDetails = txtDetails.Text.Trim();
            DateTime deadline = dtpDeadline.Value;

            dgvTasks.Rows.Add(taskName, taskDetails, deadline.ToString("dd.MM.yyyy"), false);

            txtTask.Clear();
            txtDetails.Clear();
            dtpDeadline.Value = DateTime.Now;
            txtTask.Focus();
        }

        private bool CheckTaskData()
        {
            string taskName = txtTask.Text.Trim();
            string taskDetails = txtDetails.Text.Trim();

            if (string.IsNullOrWhiteSpace(taskName))
                return ShowWarning("Tapşırığın adı boş ola bilməz!", txtTask);

            if (taskName.Length < 3)
                return ShowWarning("Tapşırığın adı ən azı 3 simvol olmalıdır!", txtTask);

            if (taskName.Length > 50)
                return ShowWarning("Tapşırığın adı 50 simvoldan çox ola bilməz!", txtTask);

            if (string.IsNullOrWhiteSpace(taskDetails))
                return ShowWarning("Təsvir boş ola bilməz!", txtDetails);

            if (taskDetails.Length > 200)
                return ShowWarning("Təsvir 200 simvoldan çox ola bilməz!", txtDetails);

            if (dtpDeadline.Value < DateTime.Now)
                return ShowWarning("Tarix keçmişdə ola bilməz!", dtpDeadline);

            string selectedDate = dtpDeadline.Value.ToString("dd.MM.yyyy");

            foreach (DataGridViewRow item in dgvTasks.Rows)
            {
                string savedName = Convert.ToString(item.Cells["taskColumn"].Value);
                string savedDate = Convert.ToString(item.Cells["dateColumn"].Value);

                if (string.Equals(savedName, taskName, StringComparison.OrdinalIgnoreCase)
                    && savedDate == selectedDate)
                {
                    return ShowWarning("Bu ad və tarixlə tapşırıq artıq mövcuddur!", txtTask);
                }
            }

            return true;
        }

        private bool ShowWarning(string message, Control target)
        {
            MessageBox.Show(message, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            target.Focus();
            return false;
        }

        private void GridDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgvTasks.IsCurrentCellDirty)
                dgvTasks.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void TaskCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != removeColumn.Index)
                return;

            bool selected = Convert.ToBoolean(dgvTasks.Rows[e.RowIndex].Cells[removeColumn.Index].Value);

            if (!selected)
                return;

            DialogResult answer = MessageBox.Show(
                "Bu tapşırıq silinsin?",
                "Silmə təsdiqi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (answer == DialogResult.Yes)
                dgvTasks.Rows.RemoveAt(e.RowIndex);
            else
                dgvTasks.Rows[e.RowIndex].Cells[removeColumn.Index].Value = false;
        }
    }
}
