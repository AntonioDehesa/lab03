namespace lab03
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
            this.labelSerial = new System.Windows.Forms.Label();
            this.tec = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.setButton = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelb0 = new System.Windows.Forms.Label();
            this.labelb1 = new System.Windows.Forms.Label();
            this.labelb2 = new System.Windows.Forms.Label();
            this.labelb3 = new System.Windows.Forms.Label();
            this.b0 = new System.Windows.Forms.FlowLayoutPanel();
            this.b3 = new System.Windows.Forms.FlowLayoutPanel();
            this.b1 = new System.Windows.Forms.FlowLayoutPanel();
            this.b2 = new System.Windows.Forms.FlowLayoutPanel();
            this.myPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSerial
            // 
            this.labelSerial.AutoSize = true;
            this.labelSerial.Location = new System.Drawing.Point(16, 28);
            this.labelSerial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSerial.Name = "labelSerial";
            this.labelSerial.Size = new System.Drawing.Size(131, 17);
            this.labelSerial.TabIndex = 0;
            this.labelSerial.Text = "Serial I/O Controller";
            // 
            // tec
            // 
            this.tec.AutoSize = true;
            this.tec.Location = new System.Drawing.Point(28, 287);
            this.tec.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tec.Name = "tec";
            this.tec.Size = new System.Drawing.Size(280, 17);
            this.tec.TabIndex = 12;
            this.tec.Text = "Tecnológico de Monterrey, Campus Puebla";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.setButton);
            this.groupBox1.Controls.Add(this.b7);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.b6);
            this.groupBox1.Controls.Add(this.b4);
            this.groupBox1.Controls.Add(this.b5);
            this.groupBox1.Location = new System.Drawing.Point(20, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(267, 123);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output (to external LEDs)";
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(124, 87);
            this.setButton.Margin = new System.Windows.Forms.Padding(4);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(104, 30);
            this.setButton.TabIndex = 19;
            this.setButton.Text = "Set all";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 23);
            this.b7.Margin = new System.Windows.Forms.Padding(4);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(48, 44);
            this.b7.TabIndex = 14;
            this.b7.Text = "b7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(12, 87);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 30);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Clear all";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(68, 23);
            this.b6.Margin = new System.Windows.Forms.Padding(4);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(48, 44);
            this.b6.TabIndex = 15;
            this.b6.Text = "b6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(180, 23);
            this.b4.Margin = new System.Windows.Forms.Padding(4);
            this.b4.Name = "b4";
            this.b4.Padding = new System.Windows.Forms.Padding(1);
            this.b4.Size = new System.Drawing.Size(48, 44);
            this.b4.TabIndex = 17;
            this.b4.Text = "b4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b5
            // 
            this.b5.BackColor = System.Drawing.Color.Gainsboro;
            this.b5.Location = new System.Drawing.Point(124, 23);
            this.b5.Margin = new System.Windows.Forms.Padding(4);
            this.b5.Name = "b5";
            this.b5.Padding = new System.Windows.Forms.Padding(1);
            this.b5.Size = new System.Drawing.Size(48, 44);
            this.b5.TabIndex = 16;
            this.b5.Text = "b5";
            this.b5.UseVisualStyleBackColor = false;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelb0);
            this.groupBox2.Controls.Add(this.labelb1);
            this.groupBox2.Controls.Add(this.labelb2);
            this.groupBox2.Controls.Add(this.labelb3);
            this.groupBox2.Controls.Add(this.b0);
            this.groupBox2.Controls.Add(this.b3);
            this.groupBox2.Controls.Add(this.b1);
            this.groupBox2.Controls.Add(this.b2);
            this.groupBox2.Location = new System.Drawing.Point(295, 114);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(267, 123);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input (from external switches)";
            // 
            // labelb0
            // 
            this.labelb0.AutoSize = true;
            this.labelb0.Location = new System.Drawing.Point(189, 71);
            this.labelb0.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelb0.Name = "labelb0";
            this.labelb0.Size = new System.Drawing.Size(24, 17);
            this.labelb0.TabIndex = 28;
            this.labelb0.Text = "b0";
            // 
            // labelb1
            // 
            this.labelb1.AutoSize = true;
            this.labelb1.Location = new System.Drawing.Point(133, 71);
            this.labelb1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelb1.Name = "labelb1";
            this.labelb1.Size = new System.Drawing.Size(24, 17);
            this.labelb1.TabIndex = 27;
            this.labelb1.Text = "b1";
            // 
            // labelb2
            // 
            this.labelb2.AutoSize = true;
            this.labelb2.Location = new System.Drawing.Point(77, 71);
            this.labelb2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelb2.Name = "labelb2";
            this.labelb2.Size = new System.Drawing.Size(24, 17);
            this.labelb2.TabIndex = 26;
            this.labelb2.Text = "b2";
            // 
            // labelb3
            // 
            this.labelb3.AutoSize = true;
            this.labelb3.Location = new System.Drawing.Point(21, 71);
            this.labelb3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelb3.Name = "labelb3";
            this.labelb3.Size = new System.Drawing.Size(24, 17);
            this.labelb3.TabIndex = 25;
            this.labelb3.Text = "b3";
            // 
            // b0
            // 
            this.b0.BackColor = System.Drawing.SystemColors.Control;
            this.b0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b0.Location = new System.Drawing.Point(192, 23);
            this.b0.Margin = new System.Windows.Forms.Padding(4);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(47, 44);
            this.b0.TabIndex = 23;
            // 
            // b3
            // 
            this.b3.BackColor = System.Drawing.SystemColors.Control;
            this.b3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b3.Location = new System.Drawing.Point(24, 23);
            this.b3.Margin = new System.Windows.Forms.Padding(4);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(47, 44);
            this.b3.TabIndex = 21;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.SystemColors.Control;
            this.b1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b1.Location = new System.Drawing.Point(136, 23);
            this.b1.Margin = new System.Windows.Forms.Padding(4);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(47, 44);
            this.b1.TabIndex = 24;
            // 
            // b2
            // 
            this.b2.BackColor = System.Drawing.SystemColors.Control;
            this.b2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.b2.Location = new System.Drawing.Point(80, 23);
            this.b2.Margin = new System.Windows.Forms.Padding(4);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(47, 44);
            this.b2.TabIndex = 22;
            // 
            // myPort
            // 
            this.myPort.PortName = "COM21";
            this.myPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.myPort_DataReceived);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 310);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tec);
            this.Controls.Add(this.labelSerial);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Laboratory 03";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSerial;
        private System.Windows.Forms.Label tec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelb0;
        private System.Windows.Forms.Label labelb1;
        private System.Windows.Forms.Label labelb2;
        private System.Windows.Forms.Label labelb3;
        private System.Windows.Forms.FlowLayoutPanel b0;
        private System.Windows.Forms.FlowLayoutPanel b3;
        private System.Windows.Forms.FlowLayoutPanel b1;
        private System.Windows.Forms.FlowLayoutPanel b2;
        private System.IO.Ports.SerialPort myPort;
    }
}

