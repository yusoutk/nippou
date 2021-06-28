using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.IO;

namespace nippou
{
    static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }


    [Serializable]
    public class TaskManager
    {
        public List<Task> TASK_LIST = new List<Task>();
        public Task ACTIVE_TASK;
        public char TASK_PREFIX;
        public string LOG_SAVE;

        public TaskFormat FORMAT;

        private float COEF;

        public TaskManager()
        {
            this.ACTIVE_TASK = null;
            this.FORMAT = new TaskFormat();
            UnitIsMin(false);
        }

        public void UnitIsMin(bool min)
        {
            if(min)
            {
                this.COEF = 60f;
            }
            else
            {
                this.COEF = 1;
            }

        }


        public void LoadPlanText(string text)
        {
            string LoadLine(string line, int f)
            {
                string[] spl = line.Split(new[] { this.FORMAT.JOINT }, StringSplitOptions.None);

                string str_h = spl[spl.Length - 1];

                string str_name = "";
                for (int i = 0; i < spl.Length - 1; i++)
                {
                    str_name += spl[i];
                    if (i < spl.Length - 2)
                    {
                        str_name += this.FORMAT.JOINT;
                    }
                }

                if (f == 0)
                {
                    return str_name;
                }
                else
                {
                    return str_h;
                }

            }

            List<Task> new_task_list = new List<Task>();

            string[] lines = text.Replace("\r\n", "\n").Split('\n');
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                bool add = false;
                if (line.Length > 0)
                {
                    if (line.StartsWith(this.FORMAT.HEAD))
                    {
                        line = line.Remove(0, this.FORMAT.HEAD.Length);
                    }

                    if (line.EndsWith(this.FORMAT.TAIL))
                    {
                        line = line.Remove(line.Length - this.FORMAT.TAIL.Length);
                    }


                    string str_name = LoadLine(line, 0);
                    string str_h = LoadLine(line, 1);


                    if (str_name != "" && str_h != "")
                    {
                        add = true;
                    }


                    if (!float.TryParse(str_h, out float f_h))
                    {
                        add = false;
                    }


                    if (add)
                    {
                        int index = 0;
                        for (int j = 0; j < this.TASK_LIST.Count; j++)
                        {
                            Task tsk = this.TASK_LIST[j];
                            if (tsk.NAME == str_name)
                            {
                                add = false;
                                index = j;
                            }
                        }
                        if (add)
                        {
                            Task new_task = new Task(str_name, float.Parse(str_h));
                            new_task_list.Add(new_task);
                        }
                        else
                        {
                            add = true;
                            for (int j = 0; j < new_task_list.Count; j++)
                            {
                                Task tsk = new_task_list[j];
                                if (tsk.NAME == str_name)
                                {
                                    add = false;
                                }
                            }
                            if (add)
                            {
                                if (f_h < this.FORMAT.UNIT)
                                {
                                    f_h = this.FORMAT.UNIT;
                                }
                                this.TASK_LIST[index].PLAN_H = (float)Math.Round(f_h * this.COEF / this.FORMAT.UNIT) * this.FORMAT.UNIT;
                                new_task_list.Add(this.TASK_LIST[index]);
                            }
                        }
                    }

                }
            }
            if (this.ACTIVE_TASK != null)
            {
                bool add_active = true;
                foreach (Task tsk in new_task_list)
                {
                    if (tsk == this.ACTIVE_TASK)
                    {
                        add_active = false;
                    }
                }

                if (add_active)
                {
                    new_task_list.Add(this.ACTIVE_TASK);
                }
            }
            this.TASK_LIST = new_task_list;

        }


        private string GetLine(Task tsk, float h)
        {
            float out_h = (float)Math.Round(h / this.FORMAT.UNIT) * this.FORMAT.UNIT;
            string str = this.FORMAT.HEAD + tsk.NAME + this.FORMAT.JOINT + out_h.ToString(this.FORMAT.NUMBER) + this.FORMAT.TAIL;
            return str;
        }

        public string ReturnPlanText()
        {
            string text = "";
            foreach (Task tsk in this.TASK_LIST)
            {
                text += GetLine(tsk, tsk.PLAN_H) + "\r\n";
            }
            return text;
        }

        public string ReturnAchieveText()
        {
            string text = "";
            float aa;
            foreach (Task tsk in this.TASK_LIST)
            {
                aa = 0;
                if (tsk == this.ACTIVE_TASK)
                {
                    aa = tsk.ActiveAchieve();
                }
                text += GetLine(tsk, tsk.ACHIEVE_H + aa) + "\r\n";
            }
            return text;
        }

        public float CalcTotalPlan()
        {
            float tot = 0;
            foreach (Task tsk in this.TASK_LIST)
            {
                tot += (float)Math.Round(tsk.PLAN_H * 4) / 4;
            }
            return tot;
        }

        public float CalcTotalAchieve()
        {
            float tot = 0;
            float aa;
            foreach (Task tsk in this.TASK_LIST)
            {
                aa = 0;
                if (tsk == this.ACTIVE_TASK)
                {
                    aa = tsk.ActiveAchieve();
                }
                tot += (float)Math.Round((tsk.ACHIEVE_H + aa) * 4) / 4;
            }
            return tot;
        }

    }
    [Serializable]
    public class Task : TaskManager
    {
        public string NAME;
        public float PLAN_H;
        public float ACHIEVE_H;
        private List<DateTime> TIME_STAMPS = new List<DateTime>();

        public Task(string name, float plan_h)
        {
            this.NAME = name;
            if (plan_h < 0.25)
            {
                plan_h = 0.25f;
            }
            this.PLAN_H = (float)Math.Round(plan_h * 4) / 4;
            this.ACHIEVE_H = 0;
        }

        public string CountStart()
        {
            DateTime dtstart = DateTime.Now;
            this.TIME_STAMPS.Add(dtstart);
            string logstr = dtstart.ToShortTimeString() + "- " + this.NAME;
            return logstr;
        }

        public string CountStop()
        {
            DateTime dtstop = DateTime.Now;
            DateTime dtstart = this.TIME_STAMPS[this.TIME_STAMPS.Count - 1];
            TimeSpan ts = dtstop - dtstart;
            this.TIME_STAMPS.Add(dtstop);
            this.ACHIEVE_H += (float)ts.TotalSeconds / 3600;
            string logstr = dtstart.ToShortTimeString() + "-" + dtstop.ToShortTimeString() + " " + this.NAME;
            return logstr;
        }

        public float ActiveAchieve()
        {
            DateTime dtstop = DateTime.Now;
            DateTime dtstart = this.TIME_STAMPS[this.TIME_STAMPS.Count - 1];
            TimeSpan ts = dtstop - dtstart;
            float aa = (float)ts.TotalSeconds / 3600;
            return aa;
        }
    }

    [Serializable]
    public class TaskFormat
    {
        public string NAME;
        public string HEAD;
        public string JOINT;
        public string TAIL;
        public string NUMBER;
        public float UNIT;
        public bool UNIT_IS_MIN;

        public TaskFormat()
        {
            this.HEAD = "・";
            this.JOINT = " ";
            this.TAIL = "h";
            this.NUMBER = "F2";
            this.UNIT = 0.25f;
            this.UNIT_IS_MIN = false;
            this.NAME = SetName();
        }

        public string SetName()
        {
            this.NAME = this.HEAD + "[TASK]" + this.JOINT + 0.ToString(this.NUMBER) + this.TAIL;
            return this.NAME;
        }
    }
}
