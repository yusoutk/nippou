using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nippou
{
    public partial class PrefForm : Form
    {
        TaskManager task_mng;
        MainForm main_form;
        TaskFormat ACTIVE_FORMAT;
        private int KETA;
        private int[] DLG;
        List<TaskFormat> form_temps = new List<TaskFormat>();
        public PrefForm(TaskManager t_mng, MainForm mform)
        {
            InitializeComponent();
            PrepFormTemps();

            foreach (TaskFormat temp in this.form_temps)
            {
                cBox_temp.Items.Add(temp.NAME);
            }
            this.task_mng = t_mng;

            this.ACTIVE_FORMAT = task_mng.FORMAT;
            GetKETA(this.ACTIVE_FORMAT.NUMBER);

            this.main_form = mform;
            this.DLG = mform.DLG;

            cBox_temp.SelectedIndex = 0;
            UpdateForm();
            UpdateRadio();
        }


        private List<TaskFormat> PrepFormTemps()
        {
            this.form_temps.Add(new TaskFormat());

            this.form_temps.Add(
                new TaskFormat()
                {
                    JOINT = " (",
                    TAIL = "h)"
                });

            this.form_temps.Add(
                new TaskFormat()
                {
                    JOINT = " (",
                    TAIL = "h)",
                    NUMBER = "0.##"
                });

            foreach (TaskFormat temp in this.form_temps)
            {
                temp.SetName();
            }

            return this.form_temps;
        }

        private void tBox_joint_TextChanged(object sender, EventArgs e)
        {
            if (tBox_joint.Text == "")
            {
                tBox_joint.Text = " ";
            }
        }


        private void ExecutionButton_Click(object sender, EventArgs e)
        {
            task_mng.FORMAT = this.ACTIVE_FORMAT;
            this.main_form.DLG = this.DLG;
            this.Close();
        }

        private void cBox_temp_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ACTIVE_FORMAT = form_temps[cBox_temp.SelectedIndex];
            UpdateForm();
        }

        private void UpdateForm()
        {
            tBox_head.Text = this.ACTIVE_FORMAT.HEAD;
            tBox_joint.Text = this.ACTIVE_FORMAT.JOINT;
            tBox_tail.Text = this.ACTIVE_FORMAT.TAIL;
            label_zero.Text = 0.ToString(this.ACTIVE_FORMAT.NUMBER);
            tBox_F.Text = GetKETA(this.ACTIVE_FORMAT.NUMBER).ToString();
            GetFN();

            tBox_tail.Location = new Point(label_zero.Location.X + label_zero.Width, tBox_tail.Location.Y);
        }

        private void UpdateRadio()
        {
            Control FindControl(Control hParent, string stName)
            {
                // hParent 内のすべてのコントロールを列挙する
                foreach (Control cControl in hParent.Controls)
                {
                    // 列挙したコントロールにコントロールが含まれている場合は再帰呼び出しする
                    if (cControl.HasChildren)
                    {
                        Control cFindControl = FindControl(cControl, stName);

                        // 再帰呼び出し先でコントロールが見つかった場合はそのまま返す
                        if (cFindControl != null)
                        {
                            return cFindControl;
                        }
                    }

                    // コントロール名が合致した場合はそのコントロールのインスタンスを返す
                    if (cControl.Name == stName)
                    {
                        return cControl;
                    }
                }

                return null;
            }
            for (int i = 0; i < 5; i++)
            {
                RadioButton rBtn0 = (RadioButton)FindControl(this, "rBtn" + i.ToString() + (this.DLG[i] % 3).ToString());
                rBtn0.Checked = true;
                RadioButton rBtn1 = (RadioButton)FindControl(this, "rBtn" + i.ToString() + ((this.DLG[i] + 1) % 3).ToString());
                rBtn1.Checked = false;
                RadioButton rBtn2 = (RadioButton)FindControl(this, "rBtn" + i.ToString() + ((this.DLG[i] + 2) % 3).ToString());
                rBtn2.Checked = false;
            }
        }

        private int GetKETA(string af_number)
        {
            if (af_number.StartsWith("F"))
            {
                if (!int.TryParse(af_number.TrimStart('F'), out this.KETA))
                {
                    return 0;
                }
            }
            else if (af_number.StartsWith("0."))
            {
                this.KETA = af_number.Length - af_number.Replace("#", "").Length;
            }
            else
            {
                return 0;
            }
            return this.KETA;
        }

        private string GetFN()
        {
            int v;
            if (!int.TryParse(tBox_F.Text, out v))
            {
                return "";
            }

            if (checkBox_zero.Checked)
            {
                return "0." + new string('#', v);
            }
            else
            {
                return "F" + v.ToString();
            }
        }

        private void tBox_F_TextChanged(object sender, EventArgs e)
        {
        }

        private void checkBox_zero_CheckedChanged(object sender, EventArgs e)
        {
            this.ACTIVE_FORMAT.NUMBER = GetFN();
            UpdateForm();
        }

        private void tBox_F_Leave(object sender, EventArgs e)
        {
            this.ACTIVE_FORMAT.NUMBER = GetFN();
            UpdateForm();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is RadioButton rBtn_checked)) return;
            int btn = int.Parse(rBtn_checked.Name.Replace("rBtn", ""));

            this.DLG[(int)Math.Floor(btn / 10f)] = (int)btn % 10;
        }
    }

}
