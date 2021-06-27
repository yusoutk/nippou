
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
            this.tBox_achive = new System.Windows.Forms.TextBox();
            this.ButtonWriteAchive = new System.Windows.Forms.Button();
            this.lab_sumPlan = new System.Windows.Forms.Label();
            this.panel_TaskButtons = new System.Windows.Forms.Panel();
            this.panel_Plan = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab_sumAchive = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AchiveUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.cBox_live = new System.Windows.Forms.CheckBox();
            this.button_init = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.tBox_fileName = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.panel_Plan.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.tBox_log.Location = new System.Drawing.Point(422, 51);
            this.tBox_log.Multiline = true;
            this.tBox_log.Name = "tBox_log";
            this.tBox_log.ReadOnly = true;
            this.tBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBox_log.Size = new System.Drawing.Size(176, 282);
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
            // tBox_achive
            // 
            this.tBox_achive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tBox_achive.Location = new System.Drawing.Point(0, 23);
            this.tBox_achive.Multiline = true;
            this.tBox_achive.Name = "tBox_achive";
            this.tBox_achive.ReadOnly = true;
            this.tBox_achive.Size = new System.Drawing.Size(250, 127);
            this.tBox_achive.TabIndex = 7;
            // 
            // ButtonWriteAchive
            // 
            this.ButtonWriteAchive.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonWriteAchive.Location = new System.Drawing.Point(0, 0);
            this.ButtonWriteAchive.Name = "ButtonWriteAchive";
            this.ButtonWriteAchive.Size = new System.Drawing.Size(75, 23);
            this.ButtonWriteAchive.TabIndex = 8;
            this.ButtonWriteAchive.Text = "実績出力";
            this.ButtonWriteAchive.UseVisualStyleBackColor = false;
            this.ButtonWriteAchive.Click += new System.EventHandler(this.ButtonWriteAchive_Click);
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
            this.panel_TaskButtons.AutoScroll = true;
            this.panel_TaskButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_TaskButtons.Location = new System.Drawing.Point(260, 51);
            this.panel_TaskButtons.Name = "panel_TaskButtons";
            this.panel_TaskButtons.Size = new System.Drawing.Size(156, 282);
            this.panel_TaskButtons.TabIndex = 10;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.lab_sumAchive);
            this.panel1.Controls.Add(this.ButtonWriteAchive);
            this.panel1.Controls.Add(this.tBox_achive);
            this.panel1.Location = new System.Drawing.Point(6, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 150);
            this.panel1.TabIndex = 12;
            // 
            // lab_sumAchive
            // 
            this.lab_sumAchive.AutoSize = true;
            this.lab_sumAchive.Location = new System.Drawing.Point(214, 5);
            this.lab_sumAchive.Name = "lab_sumAchive";
            this.lab_sumAchive.Size = new System.Drawing.Size(31, 12);
            this.lab_sumAchive.TabIndex = 10;
            this.lab_sumAchive.Text = "0.00h";
            this.lab_sumAchive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // AchiveUpdateTimer
            // 
            this.AchiveUpdateTimer.Interval = 1000;
            this.AchiveUpdateTimer.Tick += new System.EventHandler(this.AchiveUpdateTimer_Tick);
            // 
            // cBox_live
            // 
            this.cBox_live.AutoSize = true;
            this.cBox_live.Checked = true;
            this.cBox_live.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBox_live.Location = new System.Drawing.Point(517, 6);
            this.cBox_live.Name = "cBox_live";
            this.cBox_live.Size = new System.Drawing.Size(81, 16);
            this.cBox_live.TabIndex = 14;
            this.cBox_live.Text = "LiveUpdate";
            this.cBox_live.UseVisualStyleBackColor = true;
            this.cBox_live.CheckedChanged += new System.EventHandler(this.cBox_live_CheckedChanged);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(602, 336);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.tBox_fileName);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button_init);
            this.Controls.Add(this.cBox_live);
            this.Controls.Add(this.panel1);
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
            this.panel_Plan.ResumeLayout(false);
            this.panel_Plan.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_countstop;
        private System.Windows.Forms.TextBox tBox_log;
        private System.Windows.Forms.TextBox tBox_ActiveTask;
        private System.Windows.Forms.TextBox tBox_plan;
        private System.Windows.Forms.Button ButtonWritePlan;
        private System.Windows.Forms.TextBox tBox_achive;
        private System.Windows.Forms.Button ButtonWriteAchive;
        private System.Windows.Forms.Label lab_sumPlan;
        private System.Windows.Forms.Panel panel_TaskButtons;
        private System.Windows.Forms.Panel panel_Plan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab_sumAchive;
        private System.Windows.Forms.Timer AchiveUpdateTimer;
        private System.Windows.Forms.CheckBox cBox_live;
        private System.Windows.Forms.Button button_init;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.TextBox tBox_fileName;
        private System.Windows.Forms.Button UpdateButton;
    }
}

