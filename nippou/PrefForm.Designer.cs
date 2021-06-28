
namespace nippou
{
    partial class PrefForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Format = new System.Windows.Forms.GroupBox();
            this.checkBox_zero = new System.Windows.Forms.CheckBox();
            this.tBox_F = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cBox_temp = new System.Windows.Forms.ComboBox();
            this.tBox_tail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBox_joint = new System.Windows.Forms.TextBox();
            this.label_zero = new System.Windows.Forms.Label();
            this.tBox_head = new System.Windows.Forms.TextBox();
            this.groupBox_MsgBox = new System.Windows.Forms.GroupBox();
            this.ExecutionButton = new System.Windows.Forms.Button();
            this.rBtn02 = new System.Windows.Forms.RadioButton();
            this.labDlg0 = new System.Windows.Forms.Label();
            this.rBtn00 = new System.Windows.Forms.RadioButton();
            this.rBtn01 = new System.Windows.Forms.RadioButton();
            this.paneldlg0 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rBtn11 = new System.Windows.Forms.RadioButton();
            this.rBtn12 = new System.Windows.Forms.RadioButton();
            this.rBtn10 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rBtn21 = new System.Windows.Forms.RadioButton();
            this.rBtn22 = new System.Windows.Forms.RadioButton();
            this.rBtn20 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rBtn31 = new System.Windows.Forms.RadioButton();
            this.rBtn32 = new System.Windows.Forms.RadioButton();
            this.rBtn30 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rBtn41 = new System.Windows.Forms.RadioButton();
            this.rBtn42 = new System.Windows.Forms.RadioButton();
            this.rBtn40 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox_Format.SuspendLayout();
            this.groupBox_MsgBox.SuspendLayout();
            this.paneldlg0.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Format
            // 
            this.groupBox_Format.Controls.Add(this.checkBox_zero);
            this.groupBox_Format.Controls.Add(this.tBox_F);
            this.groupBox_Format.Controls.Add(this.label1);
            this.groupBox_Format.Controls.Add(this.cBox_temp);
            this.groupBox_Format.Controls.Add(this.tBox_tail);
            this.groupBox_Format.Controls.Add(this.label3);
            this.groupBox_Format.Controls.Add(this.tBox_joint);
            this.groupBox_Format.Controls.Add(this.label_zero);
            this.groupBox_Format.Controls.Add(this.tBox_head);
            this.groupBox_Format.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Format.Name = "groupBox_Format";
            this.groupBox_Format.Size = new System.Drawing.Size(250, 85);
            this.groupBox_Format.TabIndex = 0;
            this.groupBox_Format.TabStop = false;
            this.groupBox_Format.Text = "日報フォーマット";
            // 
            // checkBox_zero
            // 
            this.checkBox_zero.AutoSize = true;
            this.checkBox_zero.Location = new System.Drawing.Point(147, 41);
            this.checkBox_zero.Name = "checkBox_zero";
            this.checkBox_zero.Size = new System.Drawing.Size(75, 16);
            this.checkBox_zero.TabIndex = 9;
            this.checkBox_zero.Text = "常に0表示";
            this.checkBox_zero.UseVisualStyleBackColor = true;
            this.checkBox_zero.CheckedChanged += new System.EventHandler(this.checkBox_zero_CheckedChanged);
            // 
            // tBox_F
            // 
            this.tBox_F.Location = new System.Drawing.Point(108, 39);
            this.tBox_F.Name = "tBox_F";
            this.tBox_F.Size = new System.Drawing.Size(30, 19);
            this.tBox_F.TabIndex = 8;
            this.tBox_F.TextChanged += new System.EventHandler(this.tBox_F_TextChanged);
            this.tBox_F.Leave += new System.EventHandler(this.tBox_F_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "小数点以下桁数";
            // 
            // cBox_temp
            // 
            this.cBox_temp.FormattingEnabled = true;
            this.cBox_temp.Location = new System.Drawing.Point(20, 18);
            this.cBox_temp.Name = "cBox_temp";
            this.cBox_temp.Size = new System.Drawing.Size(121, 20);
            this.cBox_temp.TabIndex = 6;
            this.cBox_temp.Text = "選択";
            this.cBox_temp.SelectedIndexChanged += new System.EventHandler(this.cBox_temp_SelectedIndexChanged);
            // 
            // tBox_tail
            // 
            this.tBox_tail.Location = new System.Drawing.Point(147, 59);
            this.tBox_tail.Name = "tBox_tail";
            this.tBox_tail.Size = new System.Drawing.Size(30, 19);
            this.tBox_tail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "[TASK]";
            // 
            // tBox_joint
            // 
            this.tBox_joint.Location = new System.Drawing.Point(92, 59);
            this.tBox_joint.Name = "tBox_joint";
            this.tBox_joint.Size = new System.Drawing.Size(30, 19);
            this.tBox_joint.TabIndex = 3;
            this.tBox_joint.TextChanged += new System.EventHandler(this.tBox_joint_TextChanged);
            // 
            // label_zero
            // 
            this.label_zero.AutoSize = true;
            this.label_zero.Location = new System.Drawing.Point(122, 62);
            this.label_zero.Name = "label_zero";
            this.label_zero.Size = new System.Drawing.Size(25, 12);
            this.label_zero.TabIndex = 2;
            this.label_zero.Text = "0.00";
            // 
            // tBox_head
            // 
            this.tBox_head.Location = new System.Drawing.Point(20, 59);
            this.tBox_head.Name = "tBox_head";
            this.tBox_head.Size = new System.Drawing.Size(30, 19);
            this.tBox_head.TabIndex = 1;
            // 
            // groupBox_MsgBox
            // 
            this.groupBox_MsgBox.Controls.Add(this.panel4);
            this.groupBox_MsgBox.Controls.Add(this.paneldlg0);
            this.groupBox_MsgBox.Controls.Add(this.panel3);
            this.groupBox_MsgBox.Controls.Add(this.panel1);
            this.groupBox_MsgBox.Controls.Add(this.panel2);
            this.groupBox_MsgBox.Location = new System.Drawing.Point(12, 100);
            this.groupBox_MsgBox.Name = "groupBox_MsgBox";
            this.groupBox_MsgBox.Size = new System.Drawing.Size(250, 120);
            this.groupBox_MsgBox.TabIndex = 1;
            this.groupBox_MsgBox.TabStop = false;
            this.groupBox_MsgBox.Text = "確認ダイアログ";
            // 
            // ExecutionButton
            // 
            this.ExecutionButton.Location = new System.Drawing.Point(94, 223);
            this.ExecutionButton.Name = "ExecutionButton";
            this.ExecutionButton.Size = new System.Drawing.Size(75, 23);
            this.ExecutionButton.TabIndex = 2;
            this.ExecutionButton.Text = "確定";
            this.ExecutionButton.UseVisualStyleBackColor = true;
            this.ExecutionButton.Click += new System.EventHandler(this.ExecutionButton_Click);
            // 
            // rBtn02
            // 
            this.rBtn02.AutoSize = true;
            this.rBtn02.Location = new System.Drawing.Point(58, 1);
            this.rBtn02.Name = "rBtn02";
            this.rBtn02.Size = new System.Drawing.Size(47, 16);
            this.rBtn02.TabIndex = 4;
            this.rBtn02.TabStop = true;
            this.rBtn02.Text = "有効";
            this.rBtn02.UseVisualStyleBackColor = true;
            this.rBtn02.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // labDlg0
            // 
            this.labDlg0.AutoSize = true;
            this.labDlg0.Location = new System.Drawing.Point(3, 3);
            this.labDlg0.Name = "labDlg0";
            this.labDlg0.Size = new System.Drawing.Size(54, 12);
            this.labDlg0.TabIndex = 5;
            this.labDlg0.Text = "タスク押下";
            // 
            // rBtn00
            // 
            this.rBtn00.AutoSize = true;
            this.rBtn00.Location = new System.Drawing.Point(179, 1);
            this.rBtn00.Name = "rBtn00";
            this.rBtn00.Size = new System.Drawing.Size(47, 16);
            this.rBtn00.TabIndex = 6;
            this.rBtn00.TabStop = true;
            this.rBtn00.Text = "無効";
            this.rBtn00.UseVisualStyleBackColor = true;
            this.rBtn00.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // rBtn01
            // 
            this.rBtn01.AutoSize = true;
            this.rBtn01.Location = new System.Drawing.Point(107, 1);
            this.rBtn01.Name = "rBtn01";
            this.rBtn01.Size = new System.Drawing.Size(71, 16);
            this.rBtn01.TabIndex = 23;
            this.rBtn01.TabStop = true;
            this.rBtn01.Text = "未保存時";
            this.rBtn01.UseVisualStyleBackColor = true;
            this.rBtn01.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // paneldlg0
            // 
            this.paneldlg0.Controls.Add(this.rBtn01);
            this.paneldlg0.Controls.Add(this.rBtn02);
            this.paneldlg0.Controls.Add(this.rBtn00);
            this.paneldlg0.Controls.Add(this.labDlg0);
            this.paneldlg0.Location = new System.Drawing.Point(9, 16);
            this.paneldlg0.Name = "paneldlg0";
            this.paneldlg0.Size = new System.Drawing.Size(231, 19);
            this.paneldlg0.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rBtn11);
            this.panel1.Controls.Add(this.rBtn12);
            this.panel1.Controls.Add(this.rBtn10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(9, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 19);
            this.panel1.TabIndex = 24;
            // 
            // rBtn11
            // 
            this.rBtn11.AutoSize = true;
            this.rBtn11.Location = new System.Drawing.Point(107, 1);
            this.rBtn11.Name = "rBtn11";
            this.rBtn11.Size = new System.Drawing.Size(71, 16);
            this.rBtn11.TabIndex = 23;
            this.rBtn11.TabStop = true;
            this.rBtn11.Text = "未保存時";
            this.rBtn11.UseVisualStyleBackColor = true;
            this.rBtn11.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // rBtn12
            // 
            this.rBtn12.AutoSize = true;
            this.rBtn12.Location = new System.Drawing.Point(58, 1);
            this.rBtn12.Name = "rBtn12";
            this.rBtn12.Size = new System.Drawing.Size(47, 16);
            this.rBtn12.TabIndex = 4;
            this.rBtn12.TabStop = true;
            this.rBtn12.Text = "有効";
            this.rBtn12.UseVisualStyleBackColor = true;
            this.rBtn12.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // rBtn10
            // 
            this.rBtn10.AutoSize = true;
            this.rBtn10.Location = new System.Drawing.Point(179, 1);
            this.rBtn10.Name = "rBtn10";
            this.rBtn10.Size = new System.Drawing.Size(47, 16);
            this.rBtn10.TabIndex = 6;
            this.rBtn10.TabStop = true;
            this.rBtn10.Text = "無効";
            this.rBtn10.UseVisualStyleBackColor = true;
            this.rBtn10.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "タスク中断";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rBtn21);
            this.panel2.Controls.Add(this.rBtn22);
            this.panel2.Controls.Add(this.rBtn20);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(9, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 19);
            this.panel2.TabIndex = 25;
            // 
            // rBtn21
            // 
            this.rBtn21.AutoSize = true;
            this.rBtn21.Location = new System.Drawing.Point(107, 1);
            this.rBtn21.Name = "rBtn21";
            this.rBtn21.Size = new System.Drawing.Size(71, 16);
            this.rBtn21.TabIndex = 23;
            this.rBtn21.TabStop = true;
            this.rBtn21.Text = "未保存時";
            this.rBtn21.UseVisualStyleBackColor = true;
            this.rBtn21.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // rBtn22
            // 
            this.rBtn22.AutoSize = true;
            this.rBtn22.Location = new System.Drawing.Point(58, 1);
            this.rBtn22.Name = "rBtn22";
            this.rBtn22.Size = new System.Drawing.Size(47, 16);
            this.rBtn22.TabIndex = 4;
            this.rBtn22.TabStop = true;
            this.rBtn22.Text = "有効";
            this.rBtn22.UseVisualStyleBackColor = true;
            this.rBtn22.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // rBtn20
            // 
            this.rBtn20.AutoSize = true;
            this.rBtn20.Location = new System.Drawing.Point(179, 1);
            this.rBtn20.Name = "rBtn20";
            this.rBtn20.Size = new System.Drawing.Size(47, 16);
            this.rBtn20.TabIndex = 6;
            this.rBtn20.TabStop = true;
            this.rBtn20.Text = "無効";
            this.rBtn20.UseVisualStyleBackColor = true;
            this.rBtn20.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "データ読込";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rBtn31);
            this.panel3.Controls.Add(this.rBtn32);
            this.panel3.Controls.Add(this.rBtn30);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(9, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 19);
            this.panel3.TabIndex = 26;
            // 
            // rBtn31
            // 
            this.rBtn31.AutoSize = true;
            this.rBtn31.Location = new System.Drawing.Point(107, 1);
            this.rBtn31.Name = "rBtn31";
            this.rBtn31.Size = new System.Drawing.Size(71, 16);
            this.rBtn31.TabIndex = 23;
            this.rBtn31.TabStop = true;
            this.rBtn31.Text = "未保存時";
            this.rBtn31.UseVisualStyleBackColor = true;
            this.rBtn31.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // rBtn32
            // 
            this.rBtn32.AutoSize = true;
            this.rBtn32.Location = new System.Drawing.Point(58, 1);
            this.rBtn32.Name = "rBtn32";
            this.rBtn32.Size = new System.Drawing.Size(47, 16);
            this.rBtn32.TabIndex = 4;
            this.rBtn32.TabStop = true;
            this.rBtn32.Text = "有効";
            this.rBtn32.UseVisualStyleBackColor = true;
            this.rBtn32.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // rBtn30
            // 
            this.rBtn30.AutoSize = true;
            this.rBtn30.Location = new System.Drawing.Point(179, 1);
            this.rBtn30.Name = "rBtn30";
            this.rBtn30.Size = new System.Drawing.Size(47, 16);
            this.rBtn30.TabIndex = 6;
            this.rBtn30.TabStop = true;
            this.rBtn30.Text = "無効";
            this.rBtn30.UseVisualStyleBackColor = true;
            this.rBtn30.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "初期化";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rBtn41);
            this.panel4.Controls.Add(this.rBtn42);
            this.panel4.Controls.Add(this.rBtn40);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Location = new System.Drawing.Point(9, 92);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(231, 19);
            this.panel4.TabIndex = 27;
            // 
            // rBtn41
            // 
            this.rBtn41.AutoSize = true;
            this.rBtn41.Location = new System.Drawing.Point(107, 1);
            this.rBtn41.Name = "rBtn41";
            this.rBtn41.Size = new System.Drawing.Size(71, 16);
            this.rBtn41.TabIndex = 23;
            this.rBtn41.TabStop = true;
            this.rBtn41.Text = "未保存時";
            this.rBtn41.UseVisualStyleBackColor = true;
            this.rBtn41.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // rBtn42
            // 
            this.rBtn42.AutoSize = true;
            this.rBtn42.Location = new System.Drawing.Point(58, 1);
            this.rBtn42.Name = "rBtn42";
            this.rBtn42.Size = new System.Drawing.Size(47, 16);
            this.rBtn42.TabIndex = 4;
            this.rBtn42.TabStop = true;
            this.rBtn42.Text = "有効";
            this.rBtn42.UseVisualStyleBackColor = true;
            this.rBtn42.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // rBtn40
            // 
            this.rBtn40.AutoSize = true;
            this.rBtn40.Location = new System.Drawing.Point(179, 1);
            this.rBtn40.Name = "rBtn40";
            this.rBtn40.Size = new System.Drawing.Size(47, 16);
            this.rBtn40.TabIndex = 6;
            this.rBtn40.TabStop = true;
            this.rBtn40.Text = "無効";
            this.rBtn40.UseVisualStyleBackColor = true;
            this.rBtn40.CheckedChanged += new System.EventHandler(this.rBtn_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "アプリ終了";
            // 
            // PrefForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 249);
            this.Controls.Add(this.ExecutionButton);
            this.Controls.Add(this.groupBox_MsgBox);
            this.Controls.Add(this.groupBox_Format);
            this.Name = "PrefForm";
            this.Text = "PrefForm";
            this.groupBox_Format.ResumeLayout(false);
            this.groupBox_Format.PerformLayout();
            this.groupBox_MsgBox.ResumeLayout(false);
            this.paneldlg0.ResumeLayout(false);
            this.paneldlg0.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Format;
        private System.Windows.Forms.GroupBox groupBox_MsgBox;
        private System.Windows.Forms.TextBox tBox_tail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBox_joint;
        private System.Windows.Forms.Label label_zero;
        private System.Windows.Forms.TextBox tBox_head;
        private System.Windows.Forms.Button ExecutionButton;
        private System.Windows.Forms.ComboBox cBox_temp;
        private System.Windows.Forms.CheckBox checkBox_zero;
        private System.Windows.Forms.TextBox tBox_F;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labDlg0;
        private System.Windows.Forms.RadioButton rBtn02;
        private System.Windows.Forms.RadioButton rBtn01;
        private System.Windows.Forms.RadioButton rBtn00;
        private System.Windows.Forms.Panel paneldlg0;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rBtn41;
        private System.Windows.Forms.RadioButton rBtn42;
        private System.Windows.Forms.RadioButton rBtn40;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rBtn31;
        private System.Windows.Forms.RadioButton rBtn32;
        private System.Windows.Forms.RadioButton rBtn30;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rBtn11;
        private System.Windows.Forms.RadioButton rBtn12;
        private System.Windows.Forms.RadioButton rBtn10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rBtn21;
        private System.Windows.Forms.RadioButton rBtn22;
        private System.Windows.Forms.RadioButton rBtn20;
        private System.Windows.Forms.Label label4;
    }
}