
namespace slot_machines
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnJeton = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblPara = new System.Windows.Forms.Label();
            this.lblJeton = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.Orange;
            this.btnBasla.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBasla.Location = new System.Drawing.Point(93, 299);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnJeton
            // 
            this.btnJeton.BackColor = System.Drawing.Color.Orange;
            this.btnJeton.Location = new System.Drawing.Point(516, 299);
            this.btnJeton.Name = "btnJeton";
            this.btnJeton.Size = new System.Drawing.Size(75, 23);
            this.btnJeton.TabIndex = 1;
            this.btnJeton.Text = "JETON AL";
            this.btnJeton.UseVisualStyleBackColor = false;
            this.btnJeton.Click += new System.EventHandler(this.btnJeton_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.Orange;
            this.btnDurdur.Location = new System.Drawing.Point(311, 299);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(75, 23);
            this.btnDurdur.TabIndex = 2;
            this.btnDurdur.Text = "DURDUR";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(250, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(202, 194);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(458, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 194);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.LightCoral;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(56, 233);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(86, 25);
            this.lbl1.TabIndex = 6;
            this.lbl1.Text = "KASA :";
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.BackColor = System.Drawing.Color.LightCoral;
            this.lblPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPara.Location = new System.Drawing.Point(148, 233);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(73, 25);
            this.lblPara.TabIndex = 7;
            this.lblPara.Text = "PARA";
            // 
            // lblJeton
            // 
            this.lblJeton.AutoSize = true;
            this.lblJeton.BackColor = System.Drawing.Color.LightCoral;
            this.lblJeton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblJeton.Location = new System.Drawing.Point(550, 233);
            this.lblJeton.Name = "lblJeton";
            this.lblJeton.Size = new System.Drawing.Size(86, 25);
            this.lblJeton.TabIndex = 9;
            this.lblJeton.Text = "JETON";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.LightCoral;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl2.Location = new System.Drawing.Point(444, 233);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(100, 25);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "JETON :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::slot_machines.Properties.Resources.arkaplan;
            this.ClientSize = new System.Drawing.Size(708, 368);
            this.Controls.Add(this.lblJeton);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnJeton);
            this.Controls.Add(this.btnBasla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnJeton;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Label lblJeton;
        private System.Windows.Forms.Label lbl2;
    }
}

