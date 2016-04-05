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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.btn_listRemove = new System.Windows.Forms.Button();
            this.btn_listAdd = new System.Windows.Forms.Button();
            this.lbl_isValidated = new System.Windows.Forms.Label();
            this.btn_build = new System.Windows.Forms.Button();
            this.btn_validate = new System.Windows.Forms.Button();
            this.lb_orders = new System.Windows.Forms.ListBox();
            this.lb_figures = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gBox_networking.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox_networking
            // 
            this.gBox_networking.Controls.Add(this.btn_testSend);
            this.gBox_networking.Controls.Add(this.btn_disconnect);
            this.gBox_networking.Controls.Add(this.btn_connect);
            this.gBox_networking.Location = new System.Drawing.Point(12, 3);
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
            this.btn_getPos.Location = new System.Drawing.Point(6, 19);
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
            this.groupBox1.Location = new System.Drawing.Point(192, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 78);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grapper";
            // 
            // btn_moveJoint
            // 
            this.btn_moveJoint.Location = new System.Drawing.Point(87, 19);
            this.btn_moveJoint.Name = "btn_moveJoint";
            this.btn_moveJoint.Size = new System.Drawing.Size(75, 23);
            this.btn_moveJoint.TabIndex = 6;
            this.btn_moveJoint.Text = "MoveJ";
            this.btn_moveJoint.UseVisualStyleBackColor = true;
            this.btn_moveJoint.Click += new System.EventHandler(this.btn_moveJoint_Click);
            // 
            // txt_coord0
            // 
            this.txt_coord0.Location = new System.Drawing.Point(24, 51);
            this.txt_coord0.Name = "txt_coord0";
            this.txt_coord0.Size = new System.Drawing.Size(70, 20);
            this.txt_coord0.TabIndex = 7;
            // 
            // txt_coord1
            // 
            this.txt_coord1.Location = new System.Drawing.Point(24, 77);
            this.txt_coord1.Name = "txt_coord1";
            this.txt_coord1.Size = new System.Drawing.Size(70, 20);
            this.txt_coord1.TabIndex = 8;
            // 
            // txt_coord2
            // 
            this.txt_coord2.Location = new System.Drawing.Point(24, 103);
            this.txt_coord2.Name = "txt_coord2";
            this.txt_coord2.Size = new System.Drawing.Size(70, 20);
            this.txt_coord2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Z";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "P";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(102, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "W";
            // 
            // txt_coord5
            // 
            this.txt_coord5.Location = new System.Drawing.Point(122, 103);
            this.txt_coord5.Name = "txt_coord5";
            this.txt_coord5.Size = new System.Drawing.Size(70, 20);
            this.txt_coord5.TabIndex = 15;
            // 
            // txt_coord4
            // 
            this.txt_coord4.Location = new System.Drawing.Point(122, 77);
            this.txt_coord4.Name = "txt_coord4";
            this.txt_coord4.Size = new System.Drawing.Size(70, 20);
            this.txt_coord4.TabIndex = 14;
            // 
            // txt_coord3
            // 
            this.txt_coord3.Location = new System.Drawing.Point(122, 51);
            this.txt_coord3.Name = "txt_coord3";
            this.txt_coord3.Size = new System.Drawing.Size(70, 20);
            this.txt_coord3.TabIndex = 13;
            // 
            // txt_speed
            // 
            this.txt_speed.BackColor = System.Drawing.Color.Red;
            this.txt_speed.Location = new System.Drawing.Point(122, 130);
            this.txt_speed.Name = "txt_speed";
            this.txt_speed.Size = new System.Drawing.Size(70, 20);
            this.txt_speed.TabIndex = 19;
            this.txt_speed.Text = "250";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Speed";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_down);
            this.groupBox2.Controls.Add(this.btn_up);
            this.groupBox2.Controls.Add(this.btn_listRemove);
            this.groupBox2.Controls.Add(this.btn_listAdd);
            this.groupBox2.Controls.Add(this.lbl_isValidated);
            this.groupBox2.Controls.Add(this.btn_build);
            this.groupBox2.Controls.Add(this.btn_validate);
            this.groupBox2.Controls.Add(this.lb_orders);
            this.groupBox2.Controls.Add(this.lb_figures);
            this.groupBox2.Location = new System.Drawing.Point(537, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 395);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orders";
            // 
            // btn_down
            // 
            this.btn_down.Location = new System.Drawing.Point(275, 184);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(42, 23);
            this.btn_down.TabIndex = 8;
            this.btn_down.Text = "↓";
            this.btn_down.UseVisualStyleBackColor = true;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // btn_up
            // 
            this.btn_up.Location = new System.Drawing.Point(275, 155);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(42, 23);
            this.btn_up.TabIndex = 7;
            this.btn_up.Text = "↑";
            this.btn_up.UseVisualStyleBackColor = true;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_listRemove
            // 
            this.btn_listRemove.Location = new System.Drawing.Point(113, 184);
            this.btn_listRemove.Name = "btn_listRemove";
            this.btn_listRemove.Size = new System.Drawing.Size(43, 23);
            this.btn_listRemove.TabIndex = 6;
            this.btn_listRemove.Text = "<<";
            this.btn_listRemove.UseVisualStyleBackColor = true;
            this.btn_listRemove.Click += new System.EventHandler(this.btn_listRemove_Click);
            // 
            // btn_listAdd
            // 
            this.btn_listAdd.Location = new System.Drawing.Point(113, 155);
            this.btn_listAdd.Name = "btn_listAdd";
            this.btn_listAdd.Size = new System.Drawing.Size(43, 23);
            this.btn_listAdd.TabIndex = 5;
            this.btn_listAdd.Text = ">>";
            this.btn_listAdd.UseVisualStyleBackColor = true;
            this.btn_listAdd.Click += new System.EventHandler(this.btn_listAdd_Click);
            // 
            // lbl_isValidated
            // 
            this.lbl_isValidated.AutoSize = true;
            this.lbl_isValidated.Location = new System.Drawing.Point(198, 341);
            this.lbl_isValidated.Name = "lbl_isValidated";
            this.lbl_isValidated.Size = new System.Drawing.Size(29, 13);
            this.lbl_isValidated.TabIndex = 4;
            this.lbl_isValidated.Text = "false";
            // 
            // btn_build
            // 
            this.btn_build.Location = new System.Drawing.Point(162, 366);
            this.btn_build.Name = "btn_build";
            this.btn_build.Size = new System.Drawing.Size(100, 23);
            this.btn_build.TabIndex = 3;
            this.btn_build.Text = "Build";
            this.btn_build.UseVisualStyleBackColor = true;
            this.btn_build.Click += new System.EventHandler(this.btn_build_Click);
            // 
            // btn_validate
            // 
            this.btn_validate.Location = new System.Drawing.Point(162, 315);
            this.btn_validate.Name = "btn_validate";
            this.btn_validate.Size = new System.Drawing.Size(100, 23);
            this.btn_validate.TabIndex = 2;
            this.btn_validate.Text = "Validate";
            this.btn_validate.UseVisualStyleBackColor = true;
            this.btn_validate.Click += new System.EventHandler(this.btn_validate_Click);
            // 
            // lb_orders
            // 
            this.lb_orders.FormattingEnabled = true;
            this.lb_orders.Location = new System.Drawing.Point(162, 19);
            this.lb_orders.Name = "lb_orders";
            this.lb_orders.Size = new System.Drawing.Size(100, 290);
            this.lb_orders.TabIndex = 1;
            this.lb_orders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_orders_MouseDoubleClick);
            // 
            // lb_figures
            // 
            this.lb_figures.FormattingEnabled = true;
            this.lb_figures.Location = new System.Drawing.Point(7, 133);
            this.lb_figures.Name = "lb_figures";
            this.lb_figures.Size = new System.Drawing.Size(100, 95);
            this.lb_figures.TabIndex = 0;
            this.lb_figures.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_figures_MouseDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_getPos);
            this.groupBox3.Controls.Add(this.btn_moveJoint);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txt_coord0);
            this.groupBox3.Controls.Add(this.txt_speed);
            this.groupBox3.Controls.Add(this.txt_coord1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_coord2);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txt_coord5);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txt_coord4);
            this.groupBox3.Controls.Add(this.txt_coord3);
            this.groupBox3.Location = new System.Drawing.Point(303, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 160);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Movement";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 420);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rTBox_main);
            this.Controls.Add(this.gBox_networking);
            this.Name = "Main";
            this.Text = "FanucConnector";
            this.gBox_networking.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lb_orders;
        private System.Windows.Forms.ListBox lb_figures;
        private System.Windows.Forms.Label lbl_isValidated;
        private System.Windows.Forms.Button btn_build;
        private System.Windows.Forms.Button btn_validate;
        private System.Windows.Forms.Button btn_listRemove;
        private System.Windows.Forms.Button btn_listAdd;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_up;
    }
}

