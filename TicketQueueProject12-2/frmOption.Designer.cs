namespace TicketQueueProject12_2
{
    partial class frmOption
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
            this.firstTicketNumber = new System.Windows.Forms.NumericUpDown();
            this.guestPerWindow = new System.Windows.Forms.NumericUpDown();
            this.minPerWindow = new System.Windows.Forms.NumericUpDown();
            this.endTimeValue = new System.Windows.Forms.DateTimePicker();
            this.startTimeValue = new System.Windows.Forms.DateTimePicker();
            this.btnOk = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.firstTicketNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestPerWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPerWindow)).BeginInit();
            this.SuspendLayout();
            // 
            // firstTicketNumber
            // 
            this.firstTicketNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTicketNumber.Location = new System.Drawing.Point(151, 138);
            this.firstTicketNumber.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.firstTicketNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.firstTicketNumber.Name = "firstTicketNumber";
            this.firstTicketNumber.Size = new System.Drawing.Size(100, 24);
            this.firstTicketNumber.TabIndex = 20;
            this.firstTicketNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // guestPerWindow
            // 
            this.guestPerWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestPerWindow.Location = new System.Drawing.Point(151, 36);
            this.guestPerWindow.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.guestPerWindow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.guestPerWindow.Name = "guestPerWindow";
            this.guestPerWindow.Size = new System.Drawing.Size(100, 24);
            this.guestPerWindow.TabIndex = 14;
            this.guestPerWindow.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // minPerWindow
            // 
            this.minPerWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minPerWindow.Location = new System.Drawing.Point(151, 6);
            this.minPerWindow.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.minPerWindow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minPerWindow.Name = "minPerWindow";
            this.minPerWindow.Size = new System.Drawing.Size(100, 24);
            this.minPerWindow.TabIndex = 12;
            this.minPerWindow.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // endTimeValue
            // 
            this.endTimeValue.CustomFormat = "h:mm tt";
            this.endTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endTimeValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endTimeValue.Location = new System.Drawing.Point(151, 104);
            this.endTimeValue.Name = "endTimeValue";
            this.endTimeValue.ShowUpDown = true;
            this.endTimeValue.Size = new System.Drawing.Size(100, 24);
            this.endTimeValue.TabIndex = 18;
            this.endTimeValue.Tag = "End time";
            // 
            // startTimeValue
            // 
            this.startTimeValue.CustomFormat = "h:mm tt";
            this.startTimeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimeValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTimeValue.Location = new System.Drawing.Point(151, 63);
            this.startTimeValue.Name = "startTimeValue";
            this.startTimeValue.ShowUpDown = true;
            this.startTimeValue.Size = new System.Drawing.Size(100, 24);
            this.startTimeValue.TabIndex = 16;
            this.startTimeValue.Tag = "Start time";
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(151, 185);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 23);
            this.btnOk.TabIndex = 21;
            this.btnOk.Text = "&OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "First ticket number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "End time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Start time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Guests per window:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Minutes per window:";
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 223);
            this.Controls.Add(this.firstTicketNumber);
            this.Controls.Add(this.guestPerWindow);
            this.Controls.Add(this.minPerWindow);
            this.Controls.Add(this.endTimeValue);
            this.Controls.Add(this.startTimeValue);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOption";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.FrmOptions_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.firstTicketNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestPerWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minPerWindow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown firstTicketNumber;
        private System.Windows.Forms.NumericUpDown guestPerWindow;
        private System.Windows.Forms.NumericUpDown minPerWindow;
        private System.Windows.Forms.DateTimePicker endTimeValue;
        private System.Windows.Forms.DateTimePicker startTimeValue;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}