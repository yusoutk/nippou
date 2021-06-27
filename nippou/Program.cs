using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public TaskManager()
        {
            this.ACTIVE_TASK = null;
            this.TASK_PREFIX = '・';
        }


        public void LoadPlanText(string text)
        {
            string LoadLine(string line, int f)
            {
                line = line.Substring(1);
                string[] spl = line.Split(' ');
                string str_name = "";
                for (int i = 0; i < spl.Length - 1; i++)
                {
                    str_name += spl[i] + " ";
                }
                str_name = str_name.Trim();
                string str_h = spl[spl.Length - 1];
                str_h = str_h.Substring(0, str_h.Length - 1);
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
            for (int j = 0; j < lines.Length; j++)
            {
                string line = lines[j];
                bool add = false;
                if (line.Length > 0)
                {
                    if (line[0] != this.TASK_PREFIX)
                    {
                        line = this.TASK_PREFIX + line;
                    }
                    if (line[0] == this.TASK_PREFIX && line[line.Length - 1] == 'h')
                    {
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
                            for (int i = 0; i < this.TASK_LIST.Count; i++)
                            {
                                Task tsk = this.TASK_LIST[i];
                                if (tsk.NAME == str_name)
                                {
                                    add = false;
                                    index = i;
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
                                for (int i = 0; i < new_task_list.Count; i++)
                                {
                                    Task tsk = new_task_list[i];
                                    if (tsk.NAME == str_name)
                                    {
                                        add = false;
                                    }
                                }
                                if (add)
                                {
                                    if (f_h < 0.25)
                                    {
                                        f_h = 0.25f;
                                    }
                                    this.TASK_LIST[index].PLAN_H = (float)Math.Round(f_h * 4) / 4;
                                    new_task_list.Add(this.TASK_LIST[index]);
                                }
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


        public string ReturnPlanText()
        {
            string text = "";
            foreach (Task tsk in this.TASK_LIST)
            {
                text += tsk.GetLine(tsk.PLAN_H) + "h\r\n";
            }
            return text;
        }

        public string ReturnAchiveText()
        {
            string text = "";
            float aa;
            foreach (Task tsk in this.TASK_LIST)
            {
                aa = 0;
                if (tsk == this.ACTIVE_TASK)
                {
                    aa = tsk.ActiveAchive();
                }
                text += tsk.GetLine(tsk.ACHIVE_H + aa) + "h\r\n";
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

        public float CalcTotalAchive()
        {
            float tot = 0;
            float aa;
            foreach (Task tsk in this.TASK_LIST)
            {
                aa = 0;
                if (tsk == this.ACTIVE_TASK)
                {
                    aa = tsk.ActiveAchive();
                }
                tot += (float)Math.Round((tsk.ACHIVE_H + aa) * 4) / 4;
            }
            return tot;
        }

    }
    [Serializable]
    public class Task
    {
        public string NAME;
        public float PLAN_H;
        public float ACHIVE_H;
        private List<DateTime> TIME_STAMPS = new List<DateTime>();

        public Task(string name, float plan_h)
        {
            this.NAME = name;
            if (plan_h < 0.25)
            {
                plan_h = 0.25f;
            }
            this.PLAN_H = (float)Math.Round(plan_h * 4) / 4;
            this.ACHIVE_H = 0;
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
            this.ACHIVE_H += (float)ts.TotalSeconds / 3600;
            string logstr = dtstart.ToShortTimeString() + "-" + dtstop.ToShortTimeString() + " " + this.NAME;
            return logstr;
        }

        public float ActiveAchive()
        {
            DateTime dtstop = DateTime.Now;
            DateTime dtstart = this.TIME_STAMPS[this.TIME_STAMPS.Count - 1];
            TimeSpan ts = dtstop - dtstart;
            float aa = (float)ts.TotalSeconds / 3600;
            return aa;
        }

        public string GetLine(float h)
        {
            float out_h = (float)Math.Round(h * 4) / 4;
            string str = "・" + this.NAME + " " + out_h.ToString("F2");
            return str;
        }


    }
}
