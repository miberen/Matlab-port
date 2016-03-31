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
            this.rTBox_main.Location = new System.Drawing.Point(18, 170);
            this.rTBox_main.Name = "rTBox_main";
            this.rTBox_main.ReadOnly = true;
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 420);
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
    }
}

