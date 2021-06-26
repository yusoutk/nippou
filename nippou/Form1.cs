using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace nippou
{
    public partial class MainForm : Form
    {
        MainClass cl = new MainClass();
        List<Button> BUTTON_LIST = new List<Button>();
        private string LOG = "";

        public MainForm()
        {
            InitializeComponent();
            SetTaskButtons();
        }

        private void SetTaskButtons()
        {
            for (int i = 0; i < this.BUTTON_LIST.Count; i++)
            {
                this.panel_TaskButtons.Controls.Remove(this.BUTTON_LIST[i]);
            }
            this.BUTTON_LIST.Clear();
            for (int i = 0; i < cl.TASK_LIST.Count; i++)
            {
                AddTaskButton(cl.TASK_LIST[i]);
            }
        }

        private void AddTaskButton(Task tsk)
        {
            //Buttonクラスのインスタンスを作成する

            Button btn = new Button();
            bool add_button = true;
            foreach (Button button in BUTTON_LIST)
            {
                if (button.Name == "button_task_" + tsk.NAME)
                {
                    btn = button;
                    add_button = false;
                }
            }

            //Buttonコントロールのプロパティを設定する
            btn.Name = "button_task_" + tsk.NAME;
            btn.Text = tsk.NAME;
            if (this.BUTTON_LIST.Count > 0)
            {
                Button latest_button = this.BUTTON_LIST[BUTTON_LIST.Count - 1];
                btn.Location = new Point(0, latest_button.Location.Y + 50);
            }
            else
            {
                btn.Location = new Point(0, 0);
            }

            btn.Size = new Size(150, 50);
            btn.Click += new EventHandler(this.taskbutton_Click);


            if (add_button)
            {
                this.panel_TaskButtons.Controls.Add(btn);
                this.BUTTON_LIST.Add(btn);
            }

        }


        private void taskbutton_Click(object sender, EventArgs e)
        {
            task_Click(sender, e);
        }


        private void task_Click(object sender, EventArgs e)
        {
            if (!(sender is Button button_pushed)) return;
            int task_index = BUTTON_LIST.IndexOf(button_pushed);
            if (cl.TASK_LIST.Count > task_index)
            {
                string log_last = "";
                Task task = cl.TASK_LIST[task_index];

                if (cl.ACTIVE_TASK != task)
                {
                    DialogResult result = MessageBox.Show(task.NAME + "を開始しますか？(現在進行中のタスクの計測は中断されます。)", "タスクの開始", MessageBoxButtons.OKCancel);
                    if(result == DialogResult.OK)
                    {
                        if (cl.ACTIVE_TASK != null)
                        {
                            LOG += cl.ACTIVE_TASK.CountStop() + "\r\n";
                        }

                        cl.ACTIVE_TASK = task;
                        tBox_ActiveTask.Text = task.NAME;
                        log_last = task.CountStart() + "\r\n";
                        tBox_log.Text = LOG + log_last;
                    }
                    
                }
            }
        }


        private void tBox_plan_TextChanged(object sender, EventArgs e)
        {
            cl.LoadPlanText(tBox_plan.Text);
            SetTaskButtons();
            lab_sumPlan.Enabled = false;
        }

        private void ButtonWritePlan_Click(object sender, EventArgs e)
        {
            cl.LoadPlanText(tBox_plan.Text);
            tBox_plan.Text = cl.ReturnPlanText();
            lab_sumPlan.Enabled = true;
            lab_sumPlan.Text = cl.CalcTotalPlan().ToString("F") + "h";
            SetTaskButtons();
        }

        private void ButtonWriteAchive_Click(object sender, EventArgs e)
        {
            tBox_achive.Text = cl.ReturnAchiveText();
            lab_sumAchive.Text = cl.CalcTotalAchive().ToString("F") + "h";
        }

        private void Button_countstop_Click(object sender, EventArgs e)
        {
            if (cl.ACTIVE_TASK != null)
            {
                DialogResult result = MessageBox.Show("計測を中断しますか？", "タスクの中断", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    LOG += cl.ACTIVE_TASK.CountStop() + "\r\n";
                    tBox_ActiveTask.Text = "NEET TIME♨";
                    cl.ACTIVE_TASK = null;
                    tBox_log.Text = LOG;
                }
                
            }
        }
    }
}
