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
        List<ColorProgressBar> PROG_LIST = new List<ColorProgressBar>();
        private string LOG = "";

        public MainForm()
        {
            InitializeComponent();
            SetTaskButtons();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
        }

        private void SetTaskButtons()
        {
            for (int i = 0; i < this.BUTTON_LIST.Count; i++)
            {
                this.panel_TaskButtons.Controls.Remove(this.BUTTON_LIST[i]);
                this.panel_TaskButtons.Controls.Remove(this.PROG_LIST[i]);
            }
            this.BUTTON_LIST.Clear();
            this.PROG_LIST.Clear();
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
                btn.Location = new Point(0, latest_button.Location.Y + 60);
            }
            else
            {
                btn.Location = new Point(0, 5);
            }

            btn.Size = new Size(150, 50);
            btn.Click += new EventHandler(this.taskbutton_Click);


            if (add_button)
            {
                this.panel_TaskButtons.Controls.Add(btn);
                this.BUTTON_LIST.Add(btn);
            }



            ColorProgressBar pbar = new ColorProgressBar();
            bool add_pbar = true;
            foreach (ColorProgressBar prog in PROG_LIST)
            {
                if (prog.Name == "proglessbar_task_" + tsk.NAME)
                {
                    pbar = prog;
                    add_pbar = false;
        }
            }

            pbar.Name = "proglessbar_task_" + tsk.NAME;
            //pbar.Text = tsk.NAME;
            if (this.PROG_LIST.Count > 0)
            {
                ColorProgressBar latest_prog = this.PROG_LIST[PROG_LIST.Count - 1];
                pbar.Location = new Point(0, latest_prog.Location.Y + 60);
            }
            else
            {
                pbar.Location = new Point(0, 0);
            }

            pbar.Size = new Size(150, 60);
            pbar.Click += new EventHandler(this.taskbutton_Click);

            if (add_pbar)
            {
                this.panel_TaskButtons.Controls.Add(pbar);
                this.PROG_LIST.Add(pbar);
            }
        }

        private void UpdateProgBars()
        {
            float val, aa;
            foreach (Task tsk in cl.TASK_LIST)
            {
                int task_index = cl.TASK_LIST.IndexOf(tsk);
                ColorProgressBar pbar = this.PROG_LIST[task_index];

                aa = 0;
                if (tsk == cl.ACTIVE_TASK)
                {
                    aa = tsk.ActiveAchive();
                    pbar.ForeColor = SystemColors.Highlight;
                }
                else
                {
                    pbar.ForeColor = SystemColors.ActiveBorder;
                }
                if (tsk.PLAN_H != 0)
                {
                    val = (tsk.ACHIVE_H + aa) / tsk.PLAN_H;
                }
                else
                {
                    val = 0;
                }

                if (val > 1)
                {
                    val = val - 1;
                    if (tsk == cl.ACTIVE_TASK)
                    {
                        aa = tsk.ActiveAchive();
                        pbar.ForeColor = SystemColors.Highlight;
                        pbar.BackColor = SystemColors.ActiveBorder;
                    }
                    else
                    {
                        pbar.ForeColor = SystemColors.GradientActiveCaption;
                        pbar.BackColor = SystemColors.ActiveBorder;
                    }

                    if (val > 2)
                    {
                        val = 1;
                    }

                }

                pbar.Value = (int)Math.Round(val * 100);
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
                    string msg = task.NAME + " を開始しますか？";
                    if (cl.ACTIVE_TASK != null)
                    {
                        msg += "（現在進行中のタスクは中断されます）";
                    }
                    DialogResult result = MessageBox.Show(msg, "タスクの開始", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        if (cl.ACTIVE_TASK != null)
                        {
                            LOG += cl.ACTIVE_TASK.CountStop() + "\r\n";
                        }

                        cl.ACTIVE_TASK = task;
                        tBox_ActiveTask.Text = task.NAME;
                        log_last = task.CountStart() + "\r\n";
                        tBox_log.Text = LOG + log_last;

                        tBox_achive.Text = cl.ReturnAchiveText();
                        lab_sumAchive.Text = cl.CalcTotalAchive().ToString("F") + "h";
                        UpdateProgBars();
                        if (lab_sumPlan.Enabled)
                        {
                            AchiveUpdateTimer.Enabled = true;
                        }
                    }
                    
                }
            }
        }


        private void tBox_plan_TextChanged(object sender, EventArgs e)
        {
            AchiveUpdateTimer.Enabled = false;
            cl.LoadPlanText(tBox_plan.Text);
            //SetTaskButtons();
            ButtonWritePlan.BackColor = SystemColors.ActiveCaption;
            lab_sumPlan.Enabled = false;
        }

        private void ButtonWritePlan_Click(object sender, EventArgs e)
        {
            cl.LoadPlanText(tBox_plan.Text);
            tBox_plan.Text = cl.ReturnPlanText();
            ButtonWritePlan.BackColor = SystemColors.ActiveBorder;
            lab_sumPlan.Enabled = true;
            lab_sumPlan.Text = cl.CalcTotalPlan().ToString("F") + "h";
            SetTaskButtons();
            UpdateProgBars();
            if (cl.ACTIVE_TASK != null)
            {
                AchiveUpdateTimer.Enabled = true;
            }
        }

        private void ButtonWriteAchive_Click(object sender, EventArgs e)
        {
            tBox_achive.Text = cl.ReturnAchiveText();
            lab_sumAchive.Text = cl.CalcTotalAchive().ToString("F") + "h";
            UpdateProgBars();
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
            tBox_achive.Text = cl.ReturnAchiveText();
            lab_sumAchive.Text = cl.CalcTotalAchive().ToString("F") + "h";
            UpdateProgBars();

            AchiveUpdateTimer.Enabled = false;
        }

        private void AchiveUpdateTimer_Tick(object sender, EventArgs e)
        {
            tBox_achive.Text = cl.ReturnAchiveText();
            lab_sumAchive.Text = cl.CalcTotalAchive().ToString("F") + "h";
            UpdateProgBars();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(
                "終了してもいいですか？", "確認",
                MessageBoxButtons.YesNo
                ) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void cBox_live_CheckedChanged(object sender, EventArgs e)
        {
            if(cBox_live.Checked)
            {
                if(cl.ACTIVE_TASK != null)
                {
                    AchiveUpdateTimer.Enabled = true;
                }
            }
            else
            {
                AchiveUpdateTimer.Enabled = false;
            }
        }

        private void button_init_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("初期化しますか？", "初期化", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                cl.TASK_LIST.Clear();
                cl.ACTIVE_TASK = null;
                SetTaskButtons();
                tBox_log.Text = "";
                tBox_achive.Text = "";
                tBox_plan.Text = "";
                tBox_ActiveTask.Text = "";
                lab_sumPlan.Text = "0.00h";
                lab_sumAchive.Text = "0.00h";
            }
        }
    }

    /// <summary>
    /// ForeColorとBackColorプロパティによって色を変えることができる
    /// プログレスバーコントロールを表します。
    /// </summary>
    public class ColorProgressBar : ProgressBar
    {
        public ColorProgressBar()
        {
            //Paintイベントが発生するようにする
            //ダブルバッファリングを有効にする
            base.SetStyle(ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer, true);
            }

        protected override void OnPaint(PaintEventArgs e)
        {
            Brush backBrush = new SolidBrush(this.BackColor);
            Brush foreBrush = new SolidBrush(this.ForeColor);

            //背景を描画する
            e.Graphics.FillRectangle(backBrush, this.ClientRectangle);

            //バーの幅を計算する
            int chunksWidth = (int)(
                (double)this.ClientSize.Width *
                (double)(this.Value - this.Minimum) /
                (double)(this.Maximum - this.Minimum));
            Rectangle chunksRect = new Rectangle(0, 0,
                chunksWidth, this.ClientSize.Height);
            //バーを描画する
            e.Graphics.FillRectangle(foreBrush, chunksRect);

            backBrush.Dispose();
            foreBrush.Dispose();
        }
    }
}
