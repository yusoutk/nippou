using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace nippou
{
    public partial class MainForm : Form
    {
        TaskManager task_mng = new TaskManager();
        List<Button> BUTTON_LIST = new List<Button>();
        List<ColorProgressBar> PROG_LIST = new List<ColorProgressBar>();
        private string NEET_TEXT;
        private bool CHANGED;
        private string plantext_checkdif;
        private int btn_height;
        public MainForm()
        {
            InitializeComponent();
            SetTaskButtons();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.NEET_TEXT = "NEET TIME ♨";
            this.plantext_checkdif = "";
            this.btn_height = 0;
            ChangeChecker(false);

            this.ActiveControl = tBox_plan;
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
            for (int i = 0; i < task_mng.TASK_LIST.Count; i++)
            {
                AddTaskButton(task_mng.TASK_LIST[i]);
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

            btn.Size = new Size(135, 50);
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

            pbar.Size = new Size(135, 60);
            pbar.Click += new EventHandler(this.taskbutton_Click);

            if (add_pbar)
            {
                this.panel_TaskButtons.Controls.Add(pbar);
                this.PROG_LIST.Add(pbar);
            }

            if(this.BUTTON_LIST.Count * 60 > panel_TaskButtons.Height)
            {
                vScrollBar_tasks.Enabled = true;
                vScrollBar_tasks.Maximum = this.BUTTON_LIST.Count * 60 + 3;
                vScrollBar_tasks.LargeChange = panel_TaskButtons.Height;
                vScrollBar_tasks.SmallChange = 60;
            }
            else
            {
                vScrollBar_tasks.Enabled = false;
            }
        }

        private void UpdateProgBars()
        {
            float val, aa;
            foreach (Task tsk in task_mng.TASK_LIST)
            {
                int task_index = task_mng.TASK_LIST.IndexOf(tsk);
                ColorProgressBar pbar = this.PROG_LIST[task_index];

                aa = 0;
                if (tsk == task_mng.ACTIVE_TASK)
                {
                    aa = tsk.ActiveAchieve();
                    pbar.ForeColor = SystemColors.Highlight;
                }
                else
                {
                    pbar.ForeColor = SystemColors.ActiveBorder;
                }
                if (tsk.PLAN_H != 0)
                {
                    val = (tsk.ACHIEVE_H + aa) / tsk.PLAN_H;
                }
                else
                {
                    val = 0;
                }

                if (val > 1)
                {
                    val = val - 1;
                    if (tsk == task_mng.ACTIVE_TASK)
                    {
                        aa = tsk.ActiveAchieve();
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
                if(val > 1)
                {
                    val = val - (float)Math.Floor(val);
                }

                pbar.Value = (int)Math.Round(val * 100);


                var btn = this.BUTTON_LIST[task_index];
                pbar.Location = new Point(0, this.btn_height + task_index * 60);
                btn.Location = new Point(0, this.btn_height + 5 + task_index * 60);
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
            if (task_mng.TASK_LIST.Count > task_index)
            {
                Task task = task_mng.TASK_LIST[task_index];

                if (task_mng.ACTIVE_TASK != task)
                {
                    string msg = task.NAME + " を開始しますか？";
                    if (task_mng.ACTIVE_TASK != null)
                    {
                        msg = task_mng.ACTIVE_TASK.NAME + "を終了し、" + msg;
                    }
                    DialogResult result = MessageBox.Show(msg, "タスクの開始", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.OK)
                    {
                        if (task_mng.ACTIVE_TASK != null)
                        {
                            WriteStopLog();
                        }

                        task_mng.ACTIVE_TASK = task;
                        tBox_ActiveTask.Text = task.NAME;
                        tBox_log.Text += task.CountStart() + "\r\n";

                        tBox_achieve.Text = task_mng.ReturnAchieveText();
                        lab_sumAchieve.Text = task_mng.CalcTotalAchieve().ToString("F") + "h";
                        UpdateProgBars();
                        if (lab_sumPlan.Enabled)
                        {
                            AchieveUpdateTimer.Enabled = true;
                        }
                        ChangeChecker(true);
                    }

                }
            }
        }

        private void WriteStopLog()
        {
            tBox_log.Text = tBox_log.Text.TrimEnd('\r', '\n');
            string[] log_ls = tBox_log.Text.Replace("\r\n", "\n").Split('\n');
            tBox_log.Text = string.Join("\r\n", log_ls, 0, log_ls.Length - 1) + "\r\n";
            tBox_log.Text = tBox_log.Text.TrimStart('\r', '\n');
            tBox_log.Text += task_mng.ACTIVE_TASK.CountStop() + "\r\n";
        }


        private void tBox_plan_TextChanged(object sender, EventArgs e)
        {
            AchieveUpdateTimer.Enabled = false;
            task_mng.LoadPlanText(tBox_plan.Text);
            //SetTaskButtons();
            ButtonWritePlan.BackColor = SystemColors.ActiveCaption;
            lab_sumPlan.Enabled = false;
        }

        private void ButtonWritePlan_Click(object sender, EventArgs e)
        {
            task_mng.LoadPlanText(tBox_plan.Text);
            tBox_plan.Text = task_mng.ReturnPlanText();
            ButtonWritePlan.BackColor = SystemColors.ActiveBorder;
            lab_sumPlan.Enabled = true;
            lab_sumPlan.Text = task_mng.CalcTotalPlan().ToString("F") + "h";
            SetTaskButtons();
            UpdateProgBars();
            if (task_mng.ACTIVE_TASK != null)
            {
                AchieveUpdateTimer.Enabled = true;
            }
            
            if(tBox_plan.Text == this.plantext_checkdif)
            {
                ChangeChecker(false);
            }
            else
            {
                ChangeChecker(true);
            }
        }

        private void ButtonWriteAchieve_Click(object sender, EventArgs e)
        {
            tBox_achieve.Text = task_mng.ReturnAchieveText();
            lab_sumAchieve.Text = task_mng.CalcTotalAchieve().ToString("F") + "h";
            UpdateProgBars();
        }

        private void Button_countstop_Click(object sender, EventArgs e)
        {
            if (task_mng.ACTIVE_TASK != null)
            {
                DialogResult result = MessageBox.Show(task_mng.ACTIVE_TASK.NAME + "を終了しますか？", "タスクの終了", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    WriteStopLog();
                    tBox_ActiveTask.Text = this.NEET_TEXT;
                    task_mng.ACTIVE_TASK = null;
                    ChangeChecker(false);

                    tBox_achieve.Text = task_mng.ReturnAchieveText();
                    lab_sumAchieve.Text = task_mng.CalcTotalAchieve().ToString("F") + "h";
                    UpdateProgBars();
                }

            }
            AchieveUpdateTimer.Enabled = false;
        }

        private void AchieveUpdateTimer_Tick(object sender, EventArgs e)
        {
            tBox_achieve.Text = task_mng.ReturnAchieveText();
            lab_sumAchieve.Text = task_mng.CalcTotalAchieve().ToString("F") + "h";
            UpdateProgBars();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            string str = "アプリを終了してもいいですか？";
            if (this.CHANGED)
            {
                str += "（保存されていないアクションは失われます）";
                if (MessageBox.Show(
                str, "確認",
                MessageBoxButtons.YesNo
                ) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }

        private void cBox_live_CheckedChanged(object sender, EventArgs e)
        {
            if (cBox_live.Checked)
            {
                if (task_mng.ACTIVE_TASK != null)
                {
                    AchieveUpdateTimer.Enabled = true;
                }
            }
            else
            {
                AchieveUpdateTimer.Enabled = false;
            }
        }

        private void button_init_Click(object sender, EventArgs e)
        {
            string str = "初期化しますか？";
            if (this.CHANGED)
            {
                str += "（保存されていないアクションは失われます）";
            }
            DialogResult result = MessageBox.Show(str, "初期化", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                task_mng.TASK_LIST.Clear();
                task_mng.ACTIVE_TASK = null;
                SetTaskButtons();
                tBox_log.Text = "";
                tBox_achieve.Text = "";
                tBox_ActiveTask.Text = "";
                lab_sumPlan.Text = "0.00h";
                lab_sumAchieve.Text = "0.00h";
                tBox_fileName.Text = "";
                ChangeChecker(false);
            }
        }

        private void ChangeChecker(bool changed)
        {
            this.CHANGED = changed;
            if (changed)
            {
                if (tBox_fileName.Text == "")
                {
                    UpdateButton.Enabled = false;
                }
                else
                {
                    UpdateButton.Enabled = true;
                }

            }
            else
            {
                UpdateButton.Enabled = false;
            }
        }


        private void SaveForm(bool update)
        {
            this.task_mng.LOG_SAVE = tBox_log.Text;
            FileControl file = new FileControl();
            if (update)
            {
                file.filename = tBox_fileName.Text;
                if (file.update(this.task_mng))
                {
                    ChangeChecker(false);
                    this.plantext_checkdif = tBox_plan.Text;
                }
                else
                {
                    MessageBox.Show("ファイルが存在しないため、上書きできません。");
                    UpdateButton.Enabled = false;
                }
            }
            else
            {
                if (file.save(this.task_mng))
                {
                    tBox_fileName.Text = file.filename;
                    ChangeChecker(false);
                    this.plantext_checkdif = tBox_plan.Text;
                }
            }

        }

        private void LoadForm()
        {
            bool go = false;
            if (this.CHANGED)
            {
                string str = "保存されたデータを読み込みますか？（保存されていないアクションは失われます）";
                DialogResult result = MessageBox.Show(str, "読み込み", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    go = true;
                }
            }
            else
            {
                go = true;
            }

            if (go)
            {
                FileControl file = new FileControl();
                Object obj = file.load();
                tBox_fileName.Text = file.filename;
                //キャスト
                if (obj == null) return;
                this.task_mng = (TaskManager)obj;


                // 予定テキストボックスの復元
                tBox_plan.Text = task_mng.ReturnPlanText();
                ButtonWritePlan.BackColor = SystemColors.ActiveBorder;
                lab_sumPlan.Enabled = true;
                lab_sumPlan.Text = task_mng.CalcTotalPlan().ToString("F") + "h";
                if (task_mng.ACTIVE_TASK != null)
                {
                    AchieveUpdateTimer.Enabled = true;
                }

                // 実績テキストボックスの復元
                tBox_achieve.Text = task_mng.ReturnAchieveText();
                lab_sumAchieve.Text = task_mng.CalcTotalAchieve().ToString("F") + "h";


                // ボタンの復元
                SetTaskButtons();
                UpdateProgBars();

                if (task_mng.ACTIVE_TASK == null)
                {
                    tBox_ActiveTask.Text = this.NEET_TEXT;
                }
                else
                {
                    tBox_ActiveTask.Text = task_mng.ACTIVE_TASK.NAME;
                }

                // ログテキストボックスの復元
                tBox_log.Text = task_mng.LOG_SAVE;

                this.plantext_checkdif = tBox_plan.Text;


                ChangeChecker(false);
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveForm(false);
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SaveForm(true);
        }

        private void vScrollBar_tasks_Scroll(object sender, ScrollEventArgs e)
        {
            this.btn_height = -vScrollBar_tasks.Value;
            UpdateProgBars();
        }

        private void panel_TaskButtons_Scroll(object sender, ScrollEventArgs e)
        {

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

    class FileControl
    {
        internal string filename;
        internal string filepath;
        internal string rootpath;
        public FileControl()
        {
            this.filename = "";
            this.rootpath = Directory.GetCurrentDirectory() + @"\Userdata";
        }
        internal bool save(Object saveData)
        {
            //保存先を指定するダイアログを開く
            Directory.CreateDirectory(@"Userdata");
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = this.rootpath;
            sfd.FileName = DateTime.Now.Year + "年" + DateTime.Now.Month.ToString("D2") + "月" + DateTime.Now.Day.ToString("D2") + "日実績" + "_" + DateTime.Now.Hour.ToString("D2") + DateTime.Now.Minute.ToString("D2") + DateTime.Now.Second.ToString("D2");

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //指定したパスにファイルを保存する
                Stream fileStream = sfd.OpenFile();
                BinaryFormatter bF = new BinaryFormatter();
                bF.Serialize(fileStream, saveData);
                fileStream.Close();

                this.filepath = sfd.FileName;
                this.filename = Path.GetFileName(this.filepath);
                return true;
            }
            return false;
        }

        internal bool update(Object saveData)
        {
            string path = this.rootpath + "\\" + this.filename;
            if (File.Exists(path))
            {
                //指定したパスにファイルを保存する
                Stream fileStream = File.OpenWrite(path);
                BinaryFormatter bF = new BinaryFormatter();
                bF.Serialize(fileStream, saveData);
                fileStream.Close();

                this.filepath = path;
                this.filename = Path.GetFileName(path);
                return true;
            }
            return false;
        }

        internal Object load()
        {
            //開くファイルを選択するダイアログを開く
            Object loadedData = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Directory.GetCurrentDirectory() + @"\Userdata";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //ファイルを読込
                Stream fileStream = ofd.OpenFile();
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                loadedData = binaryFormatter.Deserialize(fileStream);
                fileStream.Close();

                this.filepath = ofd.FileName;
                this.filename = Path.GetFileName(this.filepath);
            }

            return loadedData;

        }
    }
}
