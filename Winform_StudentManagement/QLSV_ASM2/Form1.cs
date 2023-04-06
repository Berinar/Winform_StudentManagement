using System;
using System.Windows.Forms;

namespace QLSV_ASM2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            groupBox1.Visible = false; 
            btnFix.Visible = false;
            btnDel.Visible = false;

        }
        private void DelAll()
        {
            tName.Text = ""; tID.Text = ""; cbSex.Text = ""; tAdrress1.Text = "";
            tNPhone.Text = ""; tCourse.Text = ""; cbStatus.Text = "";
        }
        private void DelAll1()
        {
            tName1.Text =""; tID1.Text ="";cbSex.Text = ""; tAdrress1.Text ="";
            tNPhone1.Text =""; tCourse1.Text ="";cbStatus1.Text ="";
        }
        


        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            if (tName.Text != "" && tID.Text != "" && cbSex.Text != "" && tAdrress.Text != "" &&
                tNPhone.Text != "" && tCourse.Text != "" && cbStatus.Text != "")
            {
                dtInfo.Rows.Add(tName.Text, tID.Text, date.Text, cbSex.Text, tAdrress.Text,
                tNPhone.Text, tCourse.Text, cbStatus.Text);
                MessageBox.Show("Success");
                DelAll();
            }
            else
            {
                MessageBox.Show("Not enough information has been entered");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtInfo.SelectedCells.Count > 0)
            {
                if (tName.Text != "" && tID.Text != "" && cbSex.Text != "" && tAdrress.Text != "" &&
                tNPhone.Text != "" && tCourse.Text != "" && cbStatus.Text != "")
                {
                    int Lc = dtInfo.CurrentCell.RowIndex;
                    dtInfo[0, Lc].Value = tName.Text;
                    dtInfo[1, Lc].Value = tID.Text;
                    dtInfo[2, Lc].Value = date.Text;
                    dtInfo[3, Lc].Value = cbSex.Text;
                    dtInfo[4, Lc].Value = tAdrress.Text;
                    dtInfo[5, Lc].Value = tNPhone.Text;
                    dtInfo[6, Lc].Value = tCourse.Text;
                    dtInfo[7, Lc].Value = cbStatus.Text;
                    MessageBox.Show("Success");
                    DelAll();
                }
                else
                {
                    MessageBox.Show("Can not be empty", "Warning");
                }
            }
        }

        private void dtInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtInfo.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dtInfo.Rows[dtInfo.CurrentCell.RowIndex];
                tName.Text = row.Cells[0].Value.ToString();
                tID.Text = row.Cells[1].Value.ToString();
                date.Text = row.Cells[2].Value.ToString();
                cbSex.Text = row.Cells[3].Value.ToString();
                tAdrress.Text = row.Cells[4].Value.ToString();
                tNPhone.Text = row.Cells[5].Value.ToString();
                tCourse.Text = row.Cells[6].Value.ToString();
                cbStatus.Text = row.Cells[7].Value.ToString();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Rs = MessageBox.Show("Are you want to delete it ?", "Warnning", MessageBoxButtons.YesNo);

            if (Rs == DialogResult.Yes)
            {
                int ind = dtInfo.CurrentCell.RowIndex;
                dtInfo.Rows.RemoveAt(ind);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (raName.Checked)
            {
                dtSearch.Rows.Clear();
                for (int i = 0; i < dtInfo.Rows.Count - 1; i++)
                {
                    if (tName1.Text == dtInfo[0, i].Value.ToString())
                    {
                        dtSearch.Rows.Add(dtInfo[0, i].Value, dtInfo[1, i].Value, dtInfo[2, i].Value,
                        dtInfo[3, i].Value, dtInfo[4, i].Value, dtInfo[5, i].Value, dtInfo[6, i].Value,
                        dtInfo[7, i].Value);
                    }
                }

            }
            if (raID.Checked)
            {
                dtSearch.Rows.Clear();
                for (int i = 0; i < dtInfo.Rows.Count - 1; i++)
                {
                    if (tID1.Text == dtInfo[1, i].Value.ToString())
                    {
                        dtSearch.Rows.Add(dtInfo[0, i].Value, dtInfo[1, i].Value, dtInfo[2, i].Value,
                        dtInfo[3, i].Value, dtInfo[4, i].Value, dtInfo[5, i].Value, dtInfo[6, i].Value,
                        dtInfo[7, i].Value);
                    }
                }
            }
            if (date1.Checked)
            {
                dtSearch.Rows.Clear();
                for (int i = 0; i < dtInfo.Rows.Count - 1; i++)
                {
                    if (date1.Text == dtInfo[2, i].Value.ToString())
                    {
                        dtSearch.Rows.Add(dtInfo[0, i].Value, dtInfo[1, i].Value, dtInfo[2, i].Value,
                        dtInfo[3, i].Value, dtInfo[4, i].Value, dtInfo[5, i].Value, dtInfo[6, i].Value,
                        dtInfo[7, i].Value);
                    }
                }
            }
            if (raSex.Checked)
            {
                dtSearch.Rows.Clear();
                for (int i = 0; i < dtInfo.Rows.Count - 1; i++)
                {
                    if (cbSex1.Text == dtInfo[3, i].Value.ToString())
                    {
                        dtSearch.Rows.Add(dtInfo[0, i].Value, dtInfo[1, i].Value, dtInfo[2, i].Value,
                        dtInfo[3, i].Value, dtInfo[4, i].Value, dtInfo[5, i].Value, dtInfo[6, i].Value,
                        dtInfo[7, i].Value);
                    }
                }
            }
            if (raAdrress.Checked)
            {
                dtSearch.Rows.Clear();
                for (int i = 0; i < dtInfo.Rows.Count - 1; i++)
                {
                    if (tAdrress.Text == dtInfo[4, i].Value.ToString())
                    {
                        dtSearch.Rows.Add(dtInfo[0, i].Value, dtInfo[1, i].Value, dtInfo[2, i].Value,
                        dtInfo[3, i].Value, dtInfo[4, i].Value, dtInfo[5, i].Value, dtInfo[6, i].Value,
                        dtInfo[7, i].Value);
                    }
                }
            }
            if (raNPhone.Checked)
            {
                dtSearch.Rows.Clear();
                for (int i = 0; i < dtInfo.Rows.Count - 1; i++)
                {
                    if (tNPhone.Text == dtInfo[5, i].Value.ToString())
                    {
                        dtSearch.Rows.Add(dtInfo[0, i].Value, dtInfo[1, i].Value, dtInfo[2, i].Value,
                        dtInfo[3, i].Value, dtInfo[4, i].Value, dtInfo[5, i].Value, dtInfo[6, i].Value,
                        dtInfo[7, i].Value);
                    }
                }
            }
            if (raCourse.Checked)
            {
                dtSearch.Rows.Clear();
                for (int i = 0; i < dtInfo.Rows.Count - 1; i++)
                {
                    if (tCourse.Text == dtInfo[6, i].Value.ToString())
                    {
                        dtSearch.Rows.Add(dtInfo[0, i].Value, dtInfo[1, i].Value, dtInfo[2, i].Value,
                        dtInfo[3, i].Value, dtInfo[4, i].Value, dtInfo[5, i].Value, dtInfo[6, i].Value,
                        dtInfo[7, i].Value);
                    }
                }
            }
            if (raStatus.Checked)
            {
                dtSearch.Rows.Clear();
                for (int i = 0; i < dtInfo.Rows.Count - 1; i++)
                {
                    if (cbStatus1.Text == dtInfo[7, i].Value.ToString())
                    {
                        dtSearch.Rows.Add(dtInfo[0, i].Value, dtInfo[1, i].Value, dtInfo[2, i].Value,
                        dtInfo[3, i].Value, dtInfo[4, i].Value, dtInfo[5, i].Value, dtInfo[6, i].Value,
                        dtInfo[7, i].Value);
                    }
                }

            }DelAll1();

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
         
           if (btnUpdate.Visible == true)
            {
               DialogResult f = MessageBox.Show("Are you want to log out","Warning",MessageBoxButtons.YesNo);
                if (f == DialogResult.Yes)
                {
                    btnAdd.Visible = false;
                    btnDelete.Visible = false;
                    btnUpdate.Visible = false;
                    btnFix.Visible = false;
                    btnDel.Visible = false;
                }

            }else
            {
                groupBox1.Visible = true;
                if (t1.Text == "Admin" && t2.Text == "1234")
                {
                    groupBox1.Visible = false;
                    btnAdd.Visible = true;
                    btnDelete.Visible = true;
                    btnUpdate.Visible = true;
                    btnFix.Visible = true;
                    btnDel.Visible = true;

                }
                else
                {
                    MessageBox.Show("Please enter correct and complete information", "Notification");
                }
            }

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult Rs = MessageBox.Show("Are you want to delete it ?", "Warnning", MessageBoxButtons.YesNo);

            if (Rs == DialogResult.Yes)
            {
                int ind = dtSearch.CurrentCell.RowIndex;
                dtInfo.Rows.RemoveAt(ind);
                dtSearch.Rows.RemoveAt(ind);
            }
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            if (tName1.Text != "" && tID1.Text != "" && cbSex1.Text != "" && tAdrress1.Text != "" &&
                tNPhone1.Text != "" && tCourse1.Text != "" && cbStatus1.Text != "")
            {
                int Lc = dtSearch.CurrentCell.RowIndex;
                dtInfo[0, Lc].Value = tName1.Text;
                dtInfo[1, Lc].Value = tID1.Text;
                dtInfo[2, Lc].Value = date1.Text;
                dtInfo[3, Lc].Value = cbSex1.Text;
                dtInfo[4, Lc].Value = tAdrress1.Text;
                dtInfo[5, Lc].Value = tNPhone1.Text;
                dtInfo[6, Lc].Value = tCourse1.Text;
                dtInfo[7, Lc].Value = cbStatus1.Text;
                MessageBox.Show("Success");
                DelAll1();
            }
            else
            {
                MessageBox.Show("Can not be empty", "Warning");
            }
        }
    }
}
