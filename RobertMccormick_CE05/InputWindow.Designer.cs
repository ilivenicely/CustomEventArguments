namespace CustomEventApp
{
    partial class InputWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numCrewSize = new System.Windows.Forms.NumericUpDown();
            this.chbActiveDuty = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbCruiser = new System.Windows.Forms.RadioButton();
            this.rdbDestroyer = new System.Windows.Forms.RadioButton();
            this.rdbFreighter = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numCrewSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(79, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Crew size";
            // 
            // numCrewSize
            // 
            this.numCrewSize.Location = new System.Drawing.Point(79, 33);
            this.numCrewSize.Name = "numCrewSize";
            this.numCrewSize.Size = new System.Drawing.Size(47, 20);
            this.numCrewSize.TabIndex = 3;
            // 
            // chbActiveDuty
            // 
            this.chbActiveDuty.AutoSize = true;
            this.chbActiveDuty.Location = new System.Drawing.Point(79, 59);
            this.chbActiveDuty.Name = "chbActiveDuty";
            this.chbActiveDuty.Size = new System.Drawing.Size(79, 17);
            this.chbActiveDuty.TabIndex = 4;
            this.chbActiveDuty.Text = "Active duty";
            this.chbActiveDuty.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbFreighter);
            this.groupBox1.Controls.Add(this.rdbDestroyer);
            this.groupBox1.Controls.Add(this.rdbCruiser);
            this.groupBox1.Location = new System.Drawing.Point(15, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 93);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ship type";
            // 
            // rdbCruiser
            // 
            this.rdbCruiser.AutoSize = true;
            this.rdbCruiser.Checked = true;
            this.rdbCruiser.Location = new System.Drawing.Point(26, 19);
            this.rdbCruiser.Name = "rdbCruiser";
            this.rdbCruiser.Size = new System.Drawing.Size(57, 17);
            this.rdbCruiser.TabIndex = 0;
            this.rdbCruiser.TabStop = true;
            this.rdbCruiser.Text = "Cruiser";
            this.rdbCruiser.UseVisualStyleBackColor = true;
            // 
            // rdbDestroyer
            // 
            this.rdbDestroyer.AutoSize = true;
            this.rdbDestroyer.Location = new System.Drawing.Point(26, 42);
            this.rdbDestroyer.Name = "rdbDestroyer";
            this.rdbDestroyer.Size = new System.Drawing.Size(70, 17);
            this.rdbDestroyer.TabIndex = 1;
            this.rdbDestroyer.TabStop = true;
            this.rdbDestroyer.Text = "Destroyer";
            this.rdbDestroyer.UseVisualStyleBackColor = true;
            // 
            // rdbFreighter
            // 
            this.rdbFreighter.AutoSize = true;
            this.rdbFreighter.Location = new System.Drawing.Point(26, 65);
            this.rdbFreighter.Name = "rdbFreighter";
            this.rdbFreighter.Size = new System.Drawing.Size(66, 17);
            this.rdbFreighter.TabIndex = 2;
            this.rdbFreighter.TabStop = true;
            this.rdbFreighter.Text = "Freighter";
            this.rdbFreighter.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(14, 188);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(95, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(176, 188);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // InputWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 222);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chbActiveDuty);
            this.Controls.Add(this.numCrewSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "InputWindow";
            this.Text = "InputWindow";
            ((System.ComponentModel.ISupportInitialize)(this.numCrewSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numCrewSize;
        private System.Windows.Forms.CheckBox chbActiveDuty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbFreighter;
        private System.Windows.Forms.RadioButton rdbDestroyer;
        private System.Windows.Forms.RadioButton rdbCruiser;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnApply;
    }
}