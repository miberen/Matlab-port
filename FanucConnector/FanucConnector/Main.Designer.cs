namespace FanucConnector
{
    partial class Main
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
            this.gBox_networking = new System.Windows.Forms.GroupBox();
            this.btn_testSend = new System.Windows.Forms.Button();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.rTBox_main = new System.Windows.Forms.RichTextBox();
            this.btn_openGrapper = new System.Windows.Forms.Button();
            this.btn_closeGrapper = new System.Windows.Forms.Button();
            this.btn_getPos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_moveJoint = new System.Windows.Forms.Button();
            this.txt_coord0 = new System.Windows.Forms.TextBox();
            this.txt_coord1 = new System.Windows.Forms.TextBox();
            this.txt_coord2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_coord5 = new System.Windows.Forms.TextBox();
            this.txt_coord4 = new System.Windows.Forms.TextBox();
            this.txt_coord3 = new System.Windows.Forms.TextBox();
            this.txt_speed = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gBox_networking.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_networking
            // 
            this.gBox_networking.Controls.Add(this.btn_testSend);
            this.gBox_networking.Controls.Add(this.btn_disconnect);
            this.gBox_networking.Controls.Add(this.btn_connect);
            this.gBox_networking.Location = new System.Drawing.Point(12, 12);
            this.gBox_networking.Name = "gBox_networking";
            this.gBox_networking.Size = new System.Drawing.Size(174, 87);
            this.gBox_networking.TabIndex = 0;
            this.gBox_networking.TabStop = false;
            this.gBox_networking.Text = "Networking";
            // 
            // btn_testSend
            // 
            this.btn_testSend.Location = new System.Drawing.Point(87, 19);
            this.btn_testSend.Name = "btn_testSend";
            this.btn_testSend.Size = new System.Drawing.Size(75, 23);
            this.btn_testSend.TabIndex = 2;
            this.btn_testSend.Text = "TestSend";
            this.btn_testSend.UseVisualStyleBackColor = true;
            this.btn_testSend.Click += new System.EventHandler(this.btn_testSend_Click);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(6, 49);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(75, 23);
            this.btn_disconnect.TabIndex = 1;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(6, 19);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // rTBox_main
            // 
            this.rTBox_main.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rTBox_main.HideSelection = false;
            this.rTBox_main.Location = new System.Drawing.Point(18, 170);
            this.rTBox_main.Name = "rTBox_main";
            this.rTBox_main.ReadOnly = true;
            this.rTBox_main.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTBox_main.Size = new System.Drawing.Size(513, 238);
            this.rTBox_main.TabIndex = 1;
            this.rTBox_main.Text = "";
            // 
            // btn_openGrapper
            // 
            this.btn_openGrapper.Location = new System.Drawing.Point(6, 19);
            this.btn_openGrapper.Name = "btn_openGrapper";
            this.btn_openGrapper.Size = new System.Drawing.Size(93, 23);
            this.btn_openGrapper.TabIndex = 2;
            this.btn_openGrapper.Text = "OpenGrapper";
            this.btn_openGrapper.UseVisualStyleBackColor = true;
            this.btn_openGrapper.Click += new System.EventHandler(this.btn_openGrapper_Click);
            // 
            // btn_closeGrapper
            // 
            this.btn_closeGrapper.Location = new System.Drawing.Point(6, 48);
            this.btn_closeGrapper.Name = "btn_closeGrapper";
            this.btn_closeGrapper.Size = new System.Drawing.Size(93, 23);
            this.btn_closeGrapper.TabIndex = 3;
            this.btn_closeGrapper.Text = "CloseGrapper";
            this.btn_closeGrapper.UseVisualStyleBackColor = true;
            this.btn_closeGrapper.Click += new System.EventHandler(this.btn_closeGrapper_Click);
            // 
            // btn_getPos
            // 
            this.btn_getPos.Location = new System.Drawing.Point(315, 31);
            this.btn_getPos.Name = "btn_getPos";
            this.btn_getPos.Size = new System.Drawing.Size(75, 23);
            this.btn_getPos.TabIndex = 4;
            this.btn_getPos.Text = "GetPos";
            this.btn_getPos.UseVisualStyleBackColor = true;
            this.btn_getPos.Click += new System.EventHandler(this.btn_getPos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_openGrapper);
            this.groupBox1.Controls.Add(this.btn_closeGrapper);
            this.groupBox1.Location = new System.Drawing.Point(192, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grapper";
            // 
            // btn_moveJoint
            // 
            this.btn_moveJoint.Location = new System.Drawing.Point(396, 31);
            this.btn_moveJoint.Name = "btn_moveJoint";
            this.btn_moveJoint.Size = new System.Drawing.Size(75, 23);
            this.btn_moveJoint.TabIndex = 6;
            this.btn_moveJoint.Text = "MoveJ";
            this.btn_moveJoint.UseVisualStyleBackColor = true;
            this.btn_moveJoint.Click += new System.EventHandler(this.btn_moveJoint_Click);
            // 
            // txt_coord0
            // 
            this.txt_coord0.Location = new System.Drawing.Point(333, 63);
            this.txt_coord0.Name = "txt_coord0";
            this.txt_coord0.Size = new System.Drawing.Size(70, 20);
            this.txt_coord0.TabIndex = 7;
            // 
            // txt_coord1
            // 
            this.txt_coord1.Location = new System.Drawing.Point(333, 89);
            this.txt_coord1.Name = "txt_coord1";
            this.txt_coord1.Size = new System.Drawing.Size(70, 20);
            this.txt_coord1.TabIndex = 8;
            // 
            // txt_coord2
            // 
            this.txt_coord2.Location = new System.Drawing.Point(333, 115);
            this.txt_coord2.Name = "txt_coord2";
            this.txt_coord2.Size = new System.Drawing.Size(70, 20);
            this.txt_coord2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "P";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(411, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "W";
            // 
            // txt_coord5
            // 
            this.txt_coord5.Location = new System.Drawing.Point(431, 115);
            this.txt_coord5.Name = "txt_coord5";
            this.txt_coord5.Size = new System.Drawing.Size(70, 20);
            this.txt_coord5.TabIndex = 15;
            // 
            // txt_coord4
            // 
            this.txt_coord4.Location = new System.Drawing.Point(431, 89);
            this.txt_coord4.Name = "txt_coord4";
            this.txt_coord4.Size = new System.Drawing.Size(70, 20);
            this.txt_coord4.TabIndex = 14;
            // 
            // txt_coord3
            // 
            this.txt_coord3.Location = new System.Drawing.Point(431, 63);
            this.txt_coord3.Name = "txt_coord3";
            this.txt_coord3.Size = new System.Drawing.Size(70, 20);
            this.txt_coord3.TabIndex = 13;
            // 
            // txt_speed
            // 
            this.txt_speed.BackColor = System.Drawing.Color.Red;
            this.txt_speed.Location = new System.Drawing.Point(431, 142);
            this.txt_speed.Name = "txt_speed";
            this.txt_speed.Size = new System.Drawing.Size(70, 20);
            this.txt_speed.TabIndex = 19;
            this.txt_speed.Text = "250";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Speed";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 420);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_speed);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_coord5);
            this.Controls.Add(this.txt_coord4);
            this.Controls.Add(this.txt_coord3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_coord2);
            this.Controls.Add(this.txt_coord1);
            this.Controls.Add(this.txt_coord0);
            this.Controls.Add(this.btn_moveJoint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_getPos);
            this.Controls.Add(this.rTBox_main);
            this.Controls.Add(this.gBox_networking);
            this.Name = "Main";
            this.Text = "FanucConnector";
            this.gBox_networking.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox_networking;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.RichTextBox rTBox_main;
        private System.Windows.Forms.Button btn_testSend;
        private System.Windows.Forms.Button btn_openGrapper;
        private System.Windows.Forms.Button btn_closeGrapper;
        private System.Windows.Forms.Button btn_getPos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_moveJoint;
        private System.Windows.Forms.TextBox txt_coord0;
        private System.Windows.Forms.TextBox txt_coord1;
        private System.Windows.Forms.TextBox txt_coord2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_coord5;
        private System.Windows.Forms.TextBox txt_coord4;
        private System.Windows.Forms.TextBox txt_coord3;
        private System.Windows.Forms.TextBox txt_speed;
        private System.Windows.Forms.Label label7;
    }
}

