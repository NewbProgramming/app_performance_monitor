namespace app_performance_monitor
{
    partial class window_monitor
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
        if(disposing && (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window_monitor));
            this.os_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cpu_progress = new System.Windows.Forms.ProgressBar();
            this.cpu_text = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.memory_progress = new System.Windows.Forms.ProgressBar();
            this.memory_text = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.harddrive_progress = new System.Windows.Forms.ProgressBar();
            this.harddrive_text = new System.Windows.Forms.Label();
            this.task_button = new System.Windows.Forms.Button();
            this.up_arrow = new System.Windows.Forms.PictureBox();
            this.down_arrow = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.up_arrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down_arrow)).BeginInit();
            this.SuspendLayout();
            // 
            // os_label
            // 
            this.os_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.os_label.AutoSize = true;
            this.os_label.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.os_label.Location = new System.Drawing.Point(169, 9);
            this.os_label.Name = "os_label";
            this.os_label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.os_label.Size = new System.Drawing.Size(99, 30);
            this.os_label.TabIndex = 0;
            this.os_label.Text = "Windows";
            this.os_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Operating System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "CPU Usage (%)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cpu_progress
            // 
            this.cpu_progress.Location = new System.Drawing.Point(169, 58);
            this.cpu_progress.Name = "cpu_progress";
            this.cpu_progress.Size = new System.Drawing.Size(330, 23);
            this.cpu_progress.TabIndex = 3;
            // 
            // cpu_text
            // 
            this.cpu_text.Location = new System.Drawing.Point(169, 66);
            this.cpu_text.Name = "cpu_text";
            this.cpu_text.Size = new System.Drawing.Size(330, 11);
            this.cpu_text.TabIndex = 4;
            this.cpu_text.Text = "0 / 100";
            this.cpu_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "System RAM (MB)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // memory_progress
            // 
            this.memory_progress.Location = new System.Drawing.Point(169, 102);
            this.memory_progress.Name = "memory_progress";
            this.memory_progress.Size = new System.Drawing.Size(330, 23);
            this.memory_progress.TabIndex = 6;
            // 
            // memory_text
            // 
            this.memory_text.Location = new System.Drawing.Point(169, 110);
            this.memory_text.Name = "memory_text";
            this.memory_text.Size = new System.Drawing.Size(330, 11);
            this.memory_text.TabIndex = 7;
            this.memory_text.Text = "0(MB) / 0(MB)";
            this.memory_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hard Drive (GB)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // harddrive_progress
            // 
            this.harddrive_progress.Location = new System.Drawing.Point(197, 143);
            this.harddrive_progress.Name = "harddrive_progress";
            this.harddrive_progress.Size = new System.Drawing.Size(279, 23);
            this.harddrive_progress.TabIndex = 9;
            // 
            // harddrive_text
            // 
            this.harddrive_text.Location = new System.Drawing.Point(169, 151);
            this.harddrive_text.Name = "harddrive_text";
            this.harddrive_text.Size = new System.Drawing.Size(330, 11);
            this.harddrive_text.TabIndex = 10;
            this.harddrive_text.Text = "0(GB) / 0(GB)";
            this.harddrive_text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // task_button
            // 
            this.task_button.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.task_button.Location = new System.Drawing.Point(169, 186);
            this.task_button.Name = "task_button";
            this.task_button.Size = new System.Drawing.Size(330, 23);
            this.task_button.TabIndex = 11;
            this.task_button.Text = "Open Task Manager";
            this.task_button.UseVisualStyleBackColor = true;
            this.task_button.Click += new System.EventHandler(this.task_button_Click);
            // 
            // up_arrow
            // 
            this.up_arrow.Image = global::app_performance_monitor.Properties.Resources.green_up;
            this.up_arrow.InitialImage = global::app_performance_monitor.Properties.Resources.green_up;
            this.up_arrow.Location = new System.Drawing.Point(169, 143);
            this.up_arrow.Name = "up_arrow";
            this.up_arrow.Size = new System.Drawing.Size(29, 23);
            this.up_arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.up_arrow.TabIndex = 12;
            this.up_arrow.TabStop = false;
            // 
            // down_arrow
            // 
            this.down_arrow.Image = global::app_performance_monitor.Properties.Resources.red_down;
            this.down_arrow.InitialImage = global::app_performance_monitor.Properties.Resources.red_down;
            this.down_arrow.Location = new System.Drawing.Point(473, 143);
            this.down_arrow.Name = "down_arrow";
            this.down_arrow.Size = new System.Drawing.Size(26, 23);
            this.down_arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.down_arrow.TabIndex = 13;
            this.down_arrow.TabStop = false;
            // 
            // window_monitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 221);
            this.ControlBox = false;
            this.Controls.Add(this.down_arrow);
            this.Controls.Add(this.up_arrow);
            this.Controls.Add(this.task_button);
            this.Controls.Add(this.harddrive_text);
            this.Controls.Add(this.harddrive_progress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.memory_text);
            this.Controls.Add(this.memory_progress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cpu_text);
            this.Controls.Add(this.cpu_progress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.os_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "window_monitor";
            this.Text = "Performance Monitor";
            this.Load += new System.EventHandler(this.window_monitor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.up_arrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down_arrow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label os_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar cpu_progress;
        private System.Windows.Forms.Label cpu_text;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar memory_progress;
        private System.Windows.Forms.Label memory_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar harddrive_progress;
        private System.Windows.Forms.Label harddrive_text;
        private System.Windows.Forms.Button task_button;
        private System.Windows.Forms.PictureBox up_arrow;
        private System.Windows.Forms.PictureBox down_arrow;
    }
}