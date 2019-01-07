namespace list_dir
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.file_saving_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.saving_dir = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dir_to_analyze = new System.Windows.Forms.TextBox();
            this.browse_analyze_dir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // file_saving_name
            // 
            this.file_saving_name.Location = new System.Drawing.Point(17, 29);
            this.file_saving_name.Name = "file_saving_name";
            this.file_saving_name.Size = new System.Drawing.Size(271, 20);
            this.file_saving_name.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Analyze Directory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.start_analyze_dir);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Saving file name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Saving directory:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(57, 25);
            this.button2.TabIndex = 5;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.browse_saving_dir_Click);
            // 
            // saving_dir
            // 
            this.saving_dir.Location = new System.Drawing.Point(17, 77);
            this.saving_dir.Name = "saving_dir";
            this.saving_dir.Size = new System.Drawing.Size(208, 20);
            this.saving_dir.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.Location = new System.Drawing.Point(17, 162);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.progressBar1.Size = new System.Drawing.Size(271, 25);
            this.progressBar1.TabIndex = 8;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dir_to_analyze
            // 
            this.dir_to_analyze.Location = new System.Drawing.Point(17, 125);
            this.dir_to_analyze.Name = "dir_to_analyze";
            this.dir_to_analyze.Size = new System.Drawing.Size(208, 20);
            this.dir_to_analyze.TabIndex = 11;
            // 
            // browse_analyze_dir
            // 
            this.browse_analyze_dir.Location = new System.Drawing.Point(231, 122);
            this.browse_analyze_dir.Name = "browse_analyze_dir";
            this.browse_analyze_dir.Size = new System.Drawing.Size(57, 25);
            this.browse_analyze_dir.TabIndex = 10;
            this.browse_analyze_dir.Text = "Browse";
            this.browse_analyze_dir.UseVisualStyleBackColor = true;
            this.browse_analyze_dir.Click += new System.EventHandler(this.browse_anaylze_dir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Directory to analyze:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::list_dir.Properties.Resources.installer_background;
            this.ClientSize = new System.Drawing.Size(311, 199);
            this.Controls.Add(this.dir_to_analyze);
            this.Controls.Add(this.browse_analyze_dir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.saving_dir);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.file_saving_name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Analyze Directory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox file_saving_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox saving_dir;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox dir_to_analyze;
        private System.Windows.Forms.Button browse_analyze_dir;
        private System.Windows.Forms.Label label3;
    }
}

