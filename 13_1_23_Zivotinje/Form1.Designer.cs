namespace _13_1_23_Zivotinje
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblShowReturn = new System.Windows.Forms.Label();
            this.cbxVrsta = new System.Windows.Forms.ComboBox();
            this.rbtM = new System.Windows.Forms.RadioButton();
            this.rbtF = new System.Windows.Forms.RadioButton();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.btnUdomi = new System.Windows.Forms.Button();
            this.btnNahrani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(36, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(32, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Spol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(30, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vrsta:";
            // 
            // lblShowReturn
            // 
            this.lblShowReturn.AutoSize = true;
            this.lblShowReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblShowReturn.Location = new System.Drawing.Point(51, 168);
            this.lblShowReturn.Name = "lblShowReturn";
            this.lblShowReturn.Size = new System.Drawing.Size(0, 15);
            this.lblShowReturn.TabIndex = 3;
            // 
            // cbxVrsta
            // 
            this.cbxVrsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbxVrsta.FormattingEnabled = true;
            this.cbxVrsta.Items.AddRange(new object[] {
            "Pas",
            "Mačka"});
            this.cbxVrsta.Location = new System.Drawing.Point(73, 107);
            this.cbxVrsta.Name = "cbxVrsta";
            this.cbxVrsta.Size = new System.Drawing.Size(121, 23);
            this.cbxVrsta.TabIndex = 4;
            // 
            // rbtM
            // 
            this.rbtM.AutoSize = true;
            this.rbtM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtM.Location = new System.Drawing.Point(89, 73);
            this.rbtM.Name = "rbtM";
            this.rbtM.Size = new System.Drawing.Size(36, 19);
            this.rbtM.TabIndex = 5;
            this.rbtM.TabStop = true;
            this.rbtM.Text = "M";
            this.rbtM.UseVisualStyleBackColor = true;
            // 
            // rbtF
            // 
            this.rbtF.AutoSize = true;
            this.rbtF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbtF.Location = new System.Drawing.Point(147, 73);
            this.rbtF.Name = "rbtF";
            this.rbtF.Size = new System.Drawing.Size(32, 19);
            this.rbtF.TabIndex = 6;
            this.rbtF.TabStop = true;
            this.rbtF.Text = "Ž";
            this.rbtF.UseVisualStyleBackColor = true;
            // 
            // txtIme
            // 
            this.txtIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtIme.Location = new System.Drawing.Point(73, 42);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(121, 21);
            this.txtIme.TabIndex = 7;
            // 
            // btnUdomi
            // 
            this.btnUdomi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUdomi.Location = new System.Drawing.Point(227, 87);
            this.btnUdomi.Name = "btnUdomi";
            this.btnUdomi.Size = new System.Drawing.Size(92, 43);
            this.btnUdomi.TabIndex = 8;
            this.btnUdomi.Text = "Udomi";
            this.btnUdomi.UseVisualStyleBackColor = true;
            this.btnUdomi.Click += new System.EventHandler(this.btnUdomi_Click);
            // 
            // btnNahrani
            // 
            this.btnNahrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNahrani.Location = new System.Drawing.Point(227, 182);
            this.btnNahrani.Name = "btnNahrani";
            this.btnNahrani.Size = new System.Drawing.Size(92, 23);
            this.btnNahrani.TabIndex = 9;
            this.btnNahrani.Text = "Nahrani";
            this.btnNahrani.UseVisualStyleBackColor = true;
            this.btnNahrani.Click += new System.EventHandler(this.btnNahrani_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 305);
            this.Controls.Add(this.btnNahrani);
            this.Controls.Add(this.btnUdomi);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.rbtF);
            this.Controls.Add(this.rbtM);
            this.Controls.Add(this.cbxVrsta);
            this.Controls.Add(this.lblShowReturn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblShowReturn;
        private System.Windows.Forms.ComboBox cbxVrsta;
        private System.Windows.Forms.RadioButton rbtM;
        private System.Windows.Forms.RadioButton rbtF;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnUdomi;
        private System.Windows.Forms.Button btnNahrani;
    }
}

