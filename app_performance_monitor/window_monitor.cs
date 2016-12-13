using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.VisualBasic.Devices;
using System.Diagnostics;

namespace app_performance_monitor
{
    public partial class window_monitor : Form
    {
        public string os_name = string.Empty;

        public int cpu_usage = 0;
        
        public int memory_usage = 0;
        public int total_memory = 0;
        
        public int used_hd = 0;
        public int total_hd = 0;

        public bool hd_writing = false;
        public bool hd_reading = false;
        
        public static double Math_Map(double value, double x, double y, double min, double max)
        {
            if(value <= x)
            {
                return min;
            }
            
            if(value >= y)
            {
                return max;
            }
            
            double xy_difference = y - x;
            double minmax_difference = max - min;
            double ratio = minmax_difference / xy_difference;
            double product = value * ratio;
            double result = product + min;

            if(result < min)
            {
                return min;
            }
            else if(result > max)
            {
                return max;
            }
            return result;
        }

        public window_monitor()
        {
            InitializeComponent();
        }

        private void window_monitor_Load(object sender, EventArgs e)
        {
            ComputerInfo info = new ComputerInfo();
            
            this.os_name = info.OSFullName;

            cpu_progress.Style = ProgressBarStyle.Continuous;
            
            this.total_memory = (int) (info.TotalPhysicalMemory / 1024 / 1024);

            memory_progress.Style = ProgressBarStyle.Continuous;
            harddrive_progress.Style = ProgressBarStyle.Continuous;
        }

        public void Tick()
        {
            os_label.Text = this.os_name;
            
            cpu_text.Text = string.Format("{0}% / 100%", this.cpu_usage);
            
            cpu_progress.Value = this.cpu_usage;
            
            if(this.cpu_usage > 0)
            {
                cpu_progress.ForeColor = Color.Green;
            }
            if(this.cpu_usage > 40)
            {
                cpu_progress.ForeColor = Color.Orange;
            }
            if(this.cpu_usage > 80)
            {
                cpu_progress.ForeColor = Color.Red;
            }
            
            int available_memory = (int) Math_Map(this.memory_usage, 0, this.total_memory, 0, 100);

            memory_text.Text = string.Format("{0}(MB) / {1}(MB) [{2}%]", (this.total_memory - this.memory_usage), this.total_memory, available_memory);
        
            memory_progress.Value = available_memory;
            
            if(available_memory < 100)
            {
                memory_progress.ForeColor = Color.Green;
            }
            if(available_memory < 60)
            {
                memory_progress.ForeColor = Color.Orange;
            }
            if(available_memory < 20)
            {
                memory_progress.ForeColor = Color.Red;
            }
            
            this.used_hd = 0;
            this.total_hd = 0;

            foreach(DriveInfo drive in DriveInfo.GetDrives())
            {
                if(drive.IsReady)
                {
                    this.used_hd += (int)(drive.AvailableFreeSpace / 1024 / 1024 / 1024);
                    this.total_hd += (int)(drive.TotalSize / 1024 / 1024 / 1024);
                }
            }
            
            int available_hd = (int) Math_Map(this.used_hd, 0, this.total_hd, 0, 100);

            harddrive_text.Text = string.Format("{0}(GB) / {1}(GB) [{2}%]", (this.total_hd - this.used_hd), this.total_hd, available_hd);
        
            harddrive_progress.Value = available_hd;
            
            if(available_hd > 0)
            {
                harddrive_progress.ForeColor = Color.Green;
            }
            if(available_hd > 60)
            {
                harddrive_progress.ForeColor = Color.Orange;
            }
            if(available_hd > 80)
            {
                harddrive_progress.ForeColor = Color.Red;
            }

            up_arrow.Visible = this.hd_reading;
            down_arrow.Visible = this.hd_writing;
        }

        private void task_button_Click(object sender, EventArgs e)
        {
            Process.Start("taskmgr.exe");
        }
    }
}
