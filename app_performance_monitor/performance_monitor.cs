using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_performance_monitor
{
    public partial class performance_monitor : Form
    {
        PerformanceCounter cpu_usage = null;
        PerformanceCounter memory_usage = null;

        PerformanceCounter disk_write_activity = null;
        PerformanceCounter disk_read_activity = null;
        // PerformanceCounter  = null;

        window_monitor monitor = new window_monitor();

        public performance_monitor()
        {
            InitializeComponent();
        }

        private void performance_monitor_Load(object sender, EventArgs e)
        {
            cpu_usage = new PerformanceCounter("Processor Information", "% Processor Time", "_Total");
            memory_usage = new PerformanceCounter("Memory", "Available MBytes");
            
            disk_write_activity = new PerformanceCounter("FileSystem Disk Activity", "FileSystem Bytes Read", "_Total");
            disk_read_activity = new PerformanceCounter("FileSystem Disk Activity", "FileSystem Bytes Written", "_Total");
            
            this.Hide();
        }

        private void performance_monitor_Resize(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
            }
        }

        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(monitor.Visible == false)
            {
                monitor.Show();
            }
            else if(monitor.Visible == true)
            {
                monitor.Hide();
            }
        }

        private void update_Tick(object sender, EventArgs e)
        {
            if(monitor.Visible == true) {
                monitor.cpu_usage = (int) cpu_usage.NextValue();
                monitor.memory_usage = (int) memory_usage.NextValue();
                
                monitor.hd_writing = (disk_write_activity.NextValue() > 0) ? true : false;
                monitor.hd_reading = (disk_read_activity.NextValue() > 0) ? true : false;
                
                monitor.Tick();
            }
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
