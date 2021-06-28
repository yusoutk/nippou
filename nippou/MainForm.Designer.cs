
namespace nippou
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Button_countstop = new System.Windows.Forms.Button();
            this.tBox_log = new System.Windows.Forms.TextBox();
            this.tBox_ActiveTask = new System.Windows.Forms.TextBox();
            this.tBox_plan = new System.Windows.Forms.TextBox();
            this.ButtonWritePlan = new System.Windows.Forms.Button();
            this.tBox_achieve = new System.Windows.Forms.TextBox();
            this.ButtonWriteAchieve = new System.Windows.Forms.Button();
            this.lab_sumPlan = new System.Windows.Forms.Label();
            this.panel_TaskButtons = new System.Windows.Forms.Panel();
            this.vScrollBar_tasks = new System.Windows.Forms.VScrollBar();
            this.panel_Plan = new System.Windows.Forms.Panel();
            this.panel_Achieve = new System.Windows.Forms.Panel();
            this.lab_sumAchieve = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AchieveUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.button_init = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.tBox_fileName = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.cBox_live = new System.Windows.Forms.CheckBox();
            this.PrefButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel_TaskButtons.SuspendLayout();
            this.panel_Plan.SuspendLayout();
            this.panel_Achieve.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button_countstop
            // 
            this.Button_countstop.Location = new System.Drawing.Point(523, 28);
            this.Button_countstop.Name = "Button_countstop";
            this.Button_countstop.Size = new System.Drawing.Size(75, 23);
            this.Button_countstop.TabIndex = 0;
            this.Button_countstop.Text = "作業中断";
            this.Button_countstop.UseVisualStyleBackColor = true;
            this.Button_countstop.Click += new System.EventHandler(this.Button_countstop_Click);
            // 
            // tBox_log
            // 
            this.tBox_log.Location = new System.Drawing.Point(422, 74);
            this.tBox_log.Multiline = true;
            this.tBox_log.Name = "tBox_log";
            this.tBox_log.ReadOnly = true;
            this.tBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBox_log.Size = new System.Drawing.Size(176, 259);
            this.tBox_log.TabIndex = 1;
            this.tBox_log.WordWrap = false;
            // 
            // tBox_ActiveTask
            // 
            this.tBox_ActiveTask.Location = new System.Drawing.Point(311, 30);
            this.tBox_ActiveTask.Name = "tBox_ActiveTask";
            this.tBox_ActiveTask.ReadOnly = true;
            this.tBox_ActiveTask.Size = new System.Drawing.Size(206, 19);
            this.tBox_ActiveTask.TabIndex = 4;
            // 
            // tBox_plan
            // 
            this.tBox_plan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tBox_plan.Location = new System.Drawing.Point(0, 23);
            this.tBox_plan.Multiline = true;
            this.tBox_plan.Name = "tBox_plan";
            this.tBox_plan.Size = new System.Drawing.Size(250, 127);
            this.tBox_plan.TabIndex = 5;
            this.tBox_plan.TextChanged += new System.EventHandler(this.tBox_plan_TextChanged);
            // 
            // ButtonWritePlan
            // 
            this.ButtonWritePlan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonWritePlan.Location = new System.Drawing.Point(0, 0);
            this.ButtonWritePlan.Name = "ButtonWritePlan";
            this.ButtonWritePlan.Size = new System.Drawing.Size(75, 23);
            this.ButtonWritePlan.TabIndex = 6;
            this.ButtonWritePlan.Text = "予定読込";
            this.ButtonWritePlan.UseVisualStyleBackColor = false;
            this.ButtonWritePlan.Click += new System.EventHandler(this.ButtonWritePlan_Click);
            // 
            // tBox_achieve
            // 
            this.tBox_achieve.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tBox_achieve.Location = new System.Drawing.Point(0, 23);
            this.tBox_achieve.Multiline = true;
            this.tBox_achieve.Name = "tBox_achieve";
            this.tBox_achieve.ReadOnly = true;
            this.tBox_achieve.Size = new System.Drawing.Size(250, 127);
            this.tBox_achieve.TabIndex = 7;
            // 
            // ButtonWriteAchieve
            // 
            this.ButtonWriteAchieve.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonWriteAchieve.Location = new System.Drawing.Point(0, 0);
            this.ButtonWriteAchieve.Name = "ButtonWriteAchieve";
            this.ButtonWriteAchieve.Size = new System.Drawing.Size(75, 23);
            this.ButtonWriteAchieve.TabIndex = 8;
            this.ButtonWriteAchieve.Text = "実績出力";
            this.ButtonWriteAchieve.UseVisualStyleBackColor = false;
            this.ButtonWriteAchieve.Click += new System.EventHandler(this.ButtonWriteAchieve_Click);
            // 
            // lab_sumPlan
            // 
            this.lab_sumPlan.AutoSize = true;
            this.lab_sumPlan.Location = new System.Drawing.Point(214, 5);
            this.lab_sumPlan.Name = "lab_sumPlan";
            this.lab_sumPlan.Size = new System.Drawing.Size(31, 12);
            this.lab_sumPlan.TabIndex = 9;
            this.lab_sumPlan.Text = "0.00h";
            this.lab_sumPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_TaskButtons
            // 
            this.panel_TaskButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_TaskButtons.Controls.Add(this.vScrollBar_tasks);
            this.panel_TaskButtons.Location = new System.Drawing.Point(260, 72);
            this.panel_TaskButtons.Name = "panel_TaskButtons";
            this.panel_TaskButtons.Size = new System.Drawing.Size(156, 261);
            this.panel_TaskButtons.TabIndex = 10;
            this.panel_TaskButtons.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel_TaskButtons_Scroll);
            // 
            // vScrollBar_tasks
            // 
            this.vScrollBar_tasks.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar_tasks.Enabled = false;
            this.vScrollBar_tasks.Location = new System.Drawing.Point(137, 0);
            this.vScrollBar_tasks.Name = "vScrollBar_tasks";
            this.vScrollBar_tasks.Size = new System.Drawing.Size(15, 257);
            this.vScrollBar_tasks.TabIndex = 0;
            this.vScrollBar_tasks.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_tasks_Scroll);
            // 
            // panel_Plan
            // 
            this.panel_Plan.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_Plan.Controls.Add(this.ButtonWritePlan);
            this.panel_Plan.Controls.Add(this.lab_sumPlan);
            this.panel_Plan.Controls.Add(this.tBox_plan);
            this.panel_Plan.Location = new System.Drawing.Point(6, 28);
            this.panel_Plan.Name = "panel_Plan";
            this.panel_Plan.Size = new System.Drawing.Size(250, 150);
            this.panel_Plan.TabIndex = 11;
            // 
            // panel_Achieve
            // 
            this.panel_Achieve.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_Achieve.Controls.Add(this.lab_sumAchieve);
            this.panel_Achieve.Controls.Add(this.ButtonWriteAchieve);
            this.panel_Achieve.Controls.Add(this.tBox_achieve);
            this.panel_Achieve.Location = new System.Drawing.Point(6, 183);
            this.panel_Achieve.Name = "panel_Achieve";
            this.panel_Achieve.Size = new System.Drawing.Size(250, 150);
            this.panel_Achieve.TabIndex = 12;
            // 
            // lab_sumAchieve
            // 
            this.lab_sumAchieve.AutoSize = true;
            this.lab_sumAchieve.Location = new System.Drawing.Point(214, 5);
            this.lab_sumAchieve.Name = "lab_sumAchieve";
            this.lab_sumAchieve.Size = new System.Drawing.Size(31, 12);
            this.lab_sumAchieve.TabIndex = 10;
            this.lab_sumAchieve.Text = "0.00h";
            this.lab_sumAchieve.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "進行中：";
            // 
            // AchieveUpdateTimer
            // 
            this.AchieveUpdateTimer.Interval = 1000;
            this.AchieveUpdateTimer.Tick += new System.EventHandler(this.AchieveUpdateTimer_Tick);
            // 
            // button_init
            // 
            this.button_init.Location = new System.Drawing.Point(436, 2);
            this.button_init.Name = "button_init";
            this.button_init.Size = new System.Drawing.Size(75, 23);
            this.button_init.TabIndex = 15;
            this.button_init.Text = "Initialize";
            this.button_init.UseVisualStyleBackColor = true;
            this.button_init.Click += new System.EventHandler(this.button_init_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(361, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(65, 23);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "別名保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(2, 2);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(50, 23);
            this.LoadButton.TabIndex = 17;
            this.LoadButton.Text = "開く";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // tBox_fileName
            // 
            this.tBox_fileName.Location = new System.Drawing.Point(54, 4);
            this.tBox_fileName.Name = "tBox_fileName";
            this.tBox_fileName.ReadOnly = true;
            this.tBox_fileName.Size = new System.Drawing.Size(253, 19);
            this.tBox_fileName.TabIndex = 18;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(311, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(50, 23);
            this.UpdateButton.TabIndex = 19;
            this.UpdateButton.Text = "上書き";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // cBox_live
            // 
            this.cBox_live.AutoSize = true;
            this.cBox_live.Checked = true;
            this.cBox_live.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBox_live.Location = new System.Drawing.Point(335, 55);
            this.cBox_live.Name = "cBox_live";
            this.cBox_live.Size = new System.Drawing.Size(81, 16);
            this.cBox_live.TabIndex = 14;
            this.cBox_live.Text = "LiveUpdate";
            this.cBox_live.UseVisualStyleBackColor = true;
            this.cBox_live.CheckedChanged += new System.EventHandler(this.cBox_live_CheckedChanged);
            // 
            // PrefButton
            // 
            this.PrefButton.Location = new System.Drawing.Point(523, 2);
            this.PrefButton.Name = "PrefButton";
            this.PrefButton.Size = new System.Drawing.Size(75, 23);
            this.PrefButton.TabIndex = 20;
            this.PrefButton.Text = "Preference";
            this.PrefButton.UseVisualStyleBackColor = true;
            this.PrefButton.Click += new System.EventHandler(this.PrefButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(265, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "開始/中断";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 22;
            this.label3.Text = "作業履歴";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(602, 336);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrefButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.tBox_fileName);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button_init);
            this.Controls.Add(this.cBox_live);
            this.Controls.Add(this.panel_Achieve);
            this.Controls.Add(this.panel_Plan);
            this.Controls.Add(this.panel_TaskButtons);
            this.Controls.Add(this.tBox_ActiveTask);
            this.Controls.Add(this.tBox_log);
            this.Controls.Add(this.Button_countstop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoadButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "実績記録";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel_TaskButtons.ResumeLayout(false);
            this.panel_Plan.ResumeLayout(false);
            this.panel_Plan.PerformLayout();
            this.panel_Achieve.ResumeLayout(false);
            this.panel_Achieve.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_countstop;
        private System.Windows.Forms.TextBox tBox_log;
        private System.Windows.Forms.TextBox tBox_ActiveTask;
        private System.Windows.Forms.TextBox tBox_plan;
        private System.Windows.Forms.Button ButtonWritePlan;
        private System.Windows.Forms.TextBox tBox_achieve;
        private System.Windows.Forms.Button ButtonWriteAchieve;
        private System.Windows.Forms.Label lab_sumPlan;
        private System.Windows.Forms.Panel panel_TaskButtons;
        private System.Windows.Forms.Panel panel_Plan;
        private System.Windows.Forms.Panel panel_Achieve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_sumAchieve;
        private System.Windows.Forms.Timer AchieveUpdateTimer;
        private System.Windows.Forms.Button button_init;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox tBox_fileName;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.VScrollBar vScrollBar_tasks;
        private System.Windows.Forms.CheckBox cBox_live;
        private System.Windows.Forms.Button PrefButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

