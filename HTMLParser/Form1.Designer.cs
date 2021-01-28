namespace HTMLParser
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listResult = new System.Windows.Forms.ListBox();
            this.labelStartPoint = new System.Windows.Forms.Label();
            this.labelEndPoint = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.numericStart = new System.Windows.Forms.NumericUpDown();
            this.numericEnd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // listResult
            // 
            this.listResult.FormattingEnabled = true;
            this.listResult.Location = new System.Drawing.Point(15, 20);
            this.listResult.Name = "listResult";
            this.listResult.Size = new System.Drawing.Size(396, 407);
            this.listResult.TabIndex = 0;
            // 
            // labelStartPoint
            // 
            this.labelStartPoint.AutoSize = true;
            this.labelStartPoint.Location = new System.Drawing.Point(434, 23);
            this.labelStartPoint.Name = "labelStartPoint";
            this.labelStartPoint.Size = new System.Drawing.Size(56, 13);
            this.labelStartPoint.TabIndex = 1;
            this.labelStartPoint.Text = "Start Point";
            // 
            // labelEndPoint
            // 
            this.labelEndPoint.AutoSize = true;
            this.labelEndPoint.Location = new System.Drawing.Point(434, 71);
            this.labelEndPoint.Name = "labelEndPoint";
            this.labelEndPoint.Size = new System.Drawing.Size(53, 13);
            this.labelEndPoint.TabIndex = 3;
            this.labelEndPoint.Text = "End Point";
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(437, 169);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(130, 21);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(436, 205);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(130, 21);
            this.buttonAbort.TabIndex = 6;
            this.buttonAbort.Text = "Abort";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.buttonAbort_Click);
            // 
            // numericStart
            // 
            this.numericStart.Location = new System.Drawing.Point(437, 40);
            this.numericStart.Maximum = new decimal(new int[] {
            23609,
            0,
            0,
            0});
            this.numericStart.Minimum = new decimal(new int[] {
            23600,
            0,
            0,
            0});
            this.numericStart.Name = "numericStart";
            this.numericStart.Size = new System.Drawing.Size(120, 20);
            this.numericStart.TabIndex = 7;
            this.numericStart.Value = new decimal(new int[] {
            23600,
            0,
            0,
            0});
            // 
            // numericEnd
            // 
            this.numericEnd.Location = new System.Drawing.Point(437, 87);
            this.numericEnd.Maximum = new decimal(new int[] {
            23610,
            0,
            0,
            0});
            this.numericEnd.Minimum = new decimal(new int[] {
            23601,
            0,
            0,
            0});
            this.numericEnd.Name = "numericEnd";
            this.numericEnd.Size = new System.Drawing.Size(120, 20);
            this.numericEnd.TabIndex = 8;
            this.numericEnd.Value = new decimal(new int[] {
            23610,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 450);
            this.Controls.Add(this.numericEnd);
            this.Controls.Add(this.numericStart);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelEndPoint);
            this.Controls.Add(this.labelStartPoint);
            this.Controls.Add(this.listResult);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listResult;
        private System.Windows.Forms.Label labelStartPoint;
        private System.Windows.Forms.Label labelEndPoint;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.NumericUpDown numericStart;
        private System.Windows.Forms.NumericUpDown numericEnd;
    }
}

