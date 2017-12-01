namespace ProfOfWork_BlockChain
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
            this.btn_Start = new System.Windows.Forms.Button();
            this.rtb_Message = new System.Windows.Forms.RichTextBox();
            this.rtb_Hash = new System.Windows.Forms.RichTextBox();
            this.tb_Zeros = new System.Windows.Forms.TextBox();
            this.rtb_Log = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nud_Threads_Count = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_CountOfIterations = new System.Windows.Forms.TextBox();
            this.tb_Current_Number = new System.Windows.Forms.TextBox();
            this.btn_GetCurrHash = new System.Windows.Forms.Button();
            this.tb_Num = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Threads_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(190, 263);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(62, 23);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // rtb_Message
            // 
            this.rtb_Message.Location = new System.Drawing.Point(12, 12);
            this.rtb_Message.Name = "rtb_Message";
            this.rtb_Message.Size = new System.Drawing.Size(240, 118);
            this.rtb_Message.TabIndex = 1;
            this.rtb_Message.Text = "Vadim";
            // 
            // rtb_Hash
            // 
            this.rtb_Hash.Location = new System.Drawing.Point(12, 136);
            this.rtb_Hash.Name = "rtb_Hash";
            this.rtb_Hash.Size = new System.Drawing.Size(240, 96);
            this.rtb_Hash.TabIndex = 2;
            this.rtb_Hash.Text = "";
            // 
            // tb_Zeros
            // 
            this.tb_Zeros.Location = new System.Drawing.Point(64, 238);
            this.tb_Zeros.Name = "tb_Zeros";
            this.tb_Zeros.Size = new System.Drawing.Size(188, 20);
            this.tb_Zeros.TabIndex = 3;
            this.tb_Zeros.Text = "000000000000000";
            // 
            // rtb_Log
            // 
            this.rtb_Log.Location = new System.Drawing.Point(258, 12);
            this.rtb_Log.Name = "rtb_Log";
            this.rtb_Log.Size = new System.Drawing.Size(203, 246);
            this.rtb_Log.TabIndex = 4;
            this.rtb_Log.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zeros";
            // 
            // nud_Threads_Count
            // 
            this.nud_Threads_Count.Location = new System.Drawing.Point(64, 263);
            this.nud_Threads_Count.Name = "nud_Threads_Count";
            this.nud_Threads_Count.Size = new System.Drawing.Size(120, 20);
            this.nud_Threads_Count.TabIndex = 6;
            this.nud_Threads_Count.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Threads";
            // 
            // tb_CountOfIterations
            // 
            this.tb_CountOfIterations.Location = new System.Drawing.Point(64, 318);
            this.tb_CountOfIterations.Name = "tb_CountOfIterations";
            this.tb_CountOfIterations.Size = new System.Drawing.Size(100, 20);
            this.tb_CountOfIterations.TabIndex = 8;
            this.tb_CountOfIterations.Text = "10000";
            // 
            // tb_Current_Number
            // 
            this.tb_Current_Number.Location = new System.Drawing.Point(64, 344);
            this.tb_Current_Number.Name = "tb_Current_Number";
            this.tb_Current_Number.Size = new System.Drawing.Size(100, 20);
            this.tb_Current_Number.TabIndex = 9;
            this.tb_Current_Number.Text = "0";
            // 
            // btn_GetCurrHash
            // 
            this.btn_GetCurrHash.Location = new System.Drawing.Point(333, 315);
            this.btn_GetCurrHash.Name = "btn_GetCurrHash";
            this.btn_GetCurrHash.Size = new System.Drawing.Size(75, 23);
            this.btn_GetCurrHash.TabIndex = 10;
            this.btn_GetCurrHash.Text = "Hash";
            this.btn_GetCurrHash.UseVisualStyleBackColor = true;
            this.btn_GetCurrHash.Click += new System.EventHandler(this.btn_GetCurrHash_Click);
            // 
            // tb_Num
            // 
            this.tb_Num.Location = new System.Drawing.Point(227, 317);
            this.tb_Num.Name = "tb_Num";
            this.tb_Num.Size = new System.Drawing.Size(100, 20);
            this.tb_Num.TabIndex = 11;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 384);
            this.Controls.Add(this.tb_Num);
            this.Controls.Add(this.btn_GetCurrHash);
            this.Controls.Add(this.tb_Current_Number);
            this.Controls.Add(this.tb_CountOfIterations);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nud_Threads_Count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_Log);
            this.Controls.Add(this.tb_Zeros);
            this.Controls.Add(this.rtb_Hash);
            this.Controls.Add(this.rtb_Message);
            this.Controls.Add(this.btn_Start);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Threads_Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.RichTextBox rtb_Message;
        private System.Windows.Forms.RichTextBox rtb_Hash;
        private System.Windows.Forms.TextBox tb_Zeros;
        private System.Windows.Forms.RichTextBox rtb_Log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nud_Threads_Count;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_CountOfIterations;
        private System.Windows.Forms.TextBox tb_Current_Number;
        private System.Windows.Forms.Button btn_GetCurrHash;
        private System.Windows.Forms.TextBox tb_Num;
        private System.Windows.Forms.Timer timer1;
    }
}

