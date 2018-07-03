namespace Ja_Projekt
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
            this.textBoxWhere = new System.Windows.Forms.TextBox();
            this.CPP = new System.Windows.Forms.Button();
            this.textBoxString = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.Label();
            this.what = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cppCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.asmCount = new System.Windows.Forms.Label();
            this.ASM = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Label();
            this.partText = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxWhere
            // 
            this.textBoxWhere.Location = new System.Drawing.Point(153, 38);
            this.textBoxWhere.Name = "textBoxWhere";
            this.textBoxWhere.Size = new System.Drawing.Size(337, 20);
            this.textBoxWhere.TabIndex = 0;
            // 
            // CPP
            // 
            this.CPP.Location = new System.Drawing.Point(328, 64);
            this.CPP.Name = "CPP";
            this.CPP.Size = new System.Drawing.Size(75, 23);
            this.CPP.TabIndex = 1;
            this.CPP.Text = "Cpp";
            this.CPP.UseVisualStyleBackColor = true;
            this.CPP.Click += new System.EventHandler(this.Run_Click);
            // 
            // textBoxString
            // 
            this.textBoxString.Location = new System.Drawing.Point(153, 64);
            this.textBoxString.Name = "textBoxString";
            this.textBoxString.Size = new System.Drawing.Size(169, 20);
            this.textBoxString.TabIndex = 2;
            this.textBoxString.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.from.Location = new System.Drawing.Point(103, 38);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(32, 16);
            this.from.TabIndex = 3;
            this.from.Text = "Path:";
            // 
            // what
            // 
            this.what.AutoSize = true;
            this.what.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.what.Location = new System.Drawing.Point(103, 64);
            this.what.Name = "what";
            this.what.Size = new System.Drawing.Size(44, 16);
            this.what.TabIndex = 4;
            this.what.Text = "Pattern:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "C++";
            // 
            // cppCount
            // 
            this.cppCount.AutoSize = true;
            this.cppCount.Location = new System.Drawing.Point(126, 140);
            this.cppCount.Name = "cppCount";
            this.cppCount.Size = new System.Drawing.Size(13, 13);
            this.cppCount.TabIndex = 6;
            this.cppCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(210, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Asembler";
            // 
            // asmCount
            // 
            this.asmCount.AutoSize = true;
            this.asmCount.Location = new System.Drawing.Point(213, 140);
            this.asmCount.Name = "asmCount";
            this.asmCount.Size = new System.Drawing.Size(13, 13);
            this.asmCount.TabIndex = 8;
            this.asmCount.Text = "0";
            // 
            // ASM
            // 
            this.ASM.Location = new System.Drawing.Point(409, 64);
            this.ASM.Name = "ASM";
            this.ASM.Size = new System.Drawing.Size(75, 23);
            this.ASM.TabIndex = 9;
            this.ASM.Text = "Asm";
            this.ASM.UseVisualStyleBackColor = true;
            this.ASM.Click += new System.EventHandler(this.ASM_Click);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(316, 123);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(30, 13);
            this.Time.TabIndex = 10;
            this.Time.Text = "Time";
            // 
            // timer
            // 
            this.timer.AutoSize = true;
            this.timer.Location = new System.Drawing.Point(319, 140);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(13, 13);
            this.timer.TabIndex = 11;
            this.timer.Text = "0";
            // 
            // partText
            // 
            this.partText.AutoSize = true;
            this.partText.Location = new System.Drawing.Point(490, 65);
            this.partText.Name = "partText";
            this.partText.Size = new System.Drawing.Size(99, 17);
            this.partText.TabIndex = 12;
            this.partText.Text = "Only full pattern";
            this.partText.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 261);
            this.Controls.Add(this.partText);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.ASM);
            this.Controls.Add(this.asmCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cppCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.what);
            this.Controls.Add(this.from);
            this.Controls.Add(this.textBoxString);
            this.Controls.Add(this.CPP);
            this.Controls.Add(this.textBoxWhere);
            this.Name = "Form1";
            this.Text = "Algorythm KMP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWhere;
        private System.Windows.Forms.Button CPP;
        private System.Windows.Forms.TextBox textBoxString;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.Label what;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cppCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label asmCount;
        private System.Windows.Forms.Button ASM;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label timer;
        private System.Windows.Forms.CheckBox partText;
    }
}

