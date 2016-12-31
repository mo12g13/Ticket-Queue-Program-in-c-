namespace TicketQueueProject12_2
{
    partial class frmTicketQueue
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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnOptions = new System.Windows.Forms.Button();
            this.lstQueueTicket = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIssueTicket = new System.Windows.Forms.Button();
            this.lblNextTimeEntry = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblIssueTicket = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblcurrentEntry = new System.Windows.Forms.Label();
            this.timerConroller = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(201, 392);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnOptions
            // 
            this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOptions.Location = new System.Drawing.Point(8, 391);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(75, 31);
            this.btnOptions.TabIndex = 8;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // lstQueueTicket
            // 
            this.lstQueueTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstQueueTicket.FormattingEnabled = true;
            this.lstQueueTicket.ItemHeight = 16;
            this.lstQueueTicket.Location = new System.Drawing.Point(8, 229);
            this.lstQueueTicket.Name = "lstQueueTicket";
            this.lstQueueTicket.Size = new System.Drawing.Size(268, 132);
            this.lstQueueTicket.TabIndex = 7;
            this.lstQueueTicket.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnIssueTicket);
            this.groupBox2.Controls.Add(this.lblNextTimeEntry);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblIssueTicket);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(8, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(268, 123);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticket Availability";
            // 
            // btnIssueTicket
            // 
            this.btnIssueTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueTicket.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIssueTicket.Location = new System.Drawing.Point(9, 78);
            this.btnIssueTicket.Name = "btnIssueTicket";
            this.btnIssueTicket.Size = new System.Drawing.Size(111, 26);
            this.btnIssueTicket.TabIndex = 4;
            this.btnIssueTicket.Text = "Issue Ticket";
            this.btnIssueTicket.UseVisualStyleBackColor = true;
            this.btnIssueTicket.Click += new System.EventHandler(this.btnIssueTicket_Click_1);
            // 
            // lblNextTimeEntry
            // 
            this.lblNextTimeEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNextTimeEntry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNextTimeEntry.Location = new System.Drawing.Point(169, 48);
            this.lblNextTimeEntry.Name = "lblNextTimeEntry";
            this.lblNextTimeEntry.Size = new System.Drawing.Size(63, 21);
            this.lblNextTimeEntry.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(8, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total tickets outstanding:";
            // 
            // lblIssueTicket
            // 
            this.lblIssueTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIssueTicket.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIssueTicket.Location = new System.Drawing.Point(169, 19);
            this.lblIssueTicket.Name = "lblIssueTicket";
            this.lblIssueTicket.Size = new System.Drawing.Size(63, 21);
            this.lblIssueTicket.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(8, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Next available entry:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblcurrentEntry);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(8, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 52);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Guests with the following tickets may now enter:";
            // 
            // lblcurrentEntry
            // 
            this.lblcurrentEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblcurrentEntry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblcurrentEntry.Location = new System.Drawing.Point(44, 18);
            this.lblcurrentEntry.Name = "lblcurrentEntry";
            this.lblcurrentEntry.Size = new System.Drawing.Size(76, 19);
            this.lblcurrentEntry.TabIndex = 0;
            // 
            // timerConroller
            // 
            this.timerConroller.Tick += new System.EventHandler(this.timerConroller_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Momo Johnson Project 12-1";
            // 
            // frmTicketQueue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 429);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.lstQueueTicket);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTicketQueue";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmTicketQueue_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.ListBox lstQueueTicket;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIssueTicket;
        private System.Windows.Forms.Label lblNextTimeEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIssueTicket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblcurrentEntry;
        private System.Windows.Forms.Timer timerConroller;
        private System.Windows.Forms.Label label1;
    }
}

