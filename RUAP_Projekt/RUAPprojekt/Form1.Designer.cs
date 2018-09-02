namespace RUAPprojekt
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
            this.date1 = new System.Windows.Forms.TextBox();
            this.date2 = new System.Windows.Forms.TextBox();
            this.date3 = new System.Windows.Forms.TextBox();
            this.doPrediction = new System.Windows.Forms.Button();
            this.selectedEntries = new System.Windows.Forms.RadioButton();
            this.selectedExits = new System.Windows.Forms.RadioButton();
            this.date4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rez = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unesite broj putnika za 3 dana unazad:";
            // 
            // date1
            // 
            this.date1.Location = new System.Drawing.Point(12, 60);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(167, 20);
            this.date1.TabIndex = 1;
            this.date1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.date1_KeyPress);
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(12, 101);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(167, 20);
            this.date2.TabIndex = 2;
            this.date2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.date2_KeyPress);
            // 
            // date3
            // 
            this.date3.Location = new System.Drawing.Point(12, 142);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(167, 20);
            this.date3.TabIndex = 3;
            this.date3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.date3_KeyPress);
            // 
            // doPrediction
            // 
            this.doPrediction.Location = new System.Drawing.Point(15, 222);
            this.doPrediction.Name = "doPrediction";
            this.doPrediction.Size = new System.Drawing.Size(115, 25);
            this.doPrediction.TabIndex = 4;
            this.doPrediction.Text = "Obavi predikciju";
            this.doPrediction.UseVisualStyleBackColor = true;
            this.doPrediction.Click += new System.EventHandler(this.doPrediction_Click);
            // 
            // selectedEntries
            // 
            this.selectedEntries.AutoSize = true;
            this.selectedEntries.Location = new System.Drawing.Point(151, 214);
            this.selectedEntries.Name = "selectedEntries";
            this.selectedEntries.Size = new System.Drawing.Size(111, 17);
            this.selectedEntries.TabIndex = 5;
            this.selectedEntries.TabStop = true;
            this.selectedEntries.Text = "Predikcija ulazaka";
            this.selectedEntries.UseVisualStyleBackColor = true;
            // 
            // selectedExits
            // 
            this.selectedExits.AutoSize = true;
            this.selectedExits.Location = new System.Drawing.Point(151, 237);
            this.selectedExits.Name = "selectedExits";
            this.selectedExits.Size = new System.Drawing.Size(112, 17);
            this.selectedExits.TabIndex = 6;
            this.selectedExits.TabStop = true;
            this.selectedExits.Text = "Predikcija izlazaka";
            this.selectedExits.UseVisualStyleBackColor = true;
            // 
            // date4
            // 
            this.date4.Location = new System.Drawing.Point(12, 183);
            this.date4.Name = "date4";
            this.date4.Size = new System.Drawing.Size(167, 20);
            this.date4.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Unesite broj putnika za datum predviđanja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Unesite broj putnika za prvi prethodni datum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(259, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Unesite broj putnika za drugi prethodni datum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Unesite broj putnika za treći prethodni datum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(17, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Rezultat predviđanja:";
            // 
            // rez
            // 
            this.rez.Location = new System.Drawing.Point(17, 287);
            this.rez.Name = "rez";
            this.rez.ReadOnly = true;
            this.rez.Size = new System.Drawing.Size(167, 20);
            this.rez.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 324);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rez);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date4);
            this.Controls.Add(this.selectedExits);
            this.Controls.Add(this.selectedEntries);
            this.Controls.Add(this.doPrediction);
            this.Controls.Add(this.date3);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Broj putnika jedne stanice u Manhattan-u";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox date1;
        private System.Windows.Forms.TextBox date2;
        private System.Windows.Forms.TextBox date3;
        private System.Windows.Forms.Button doPrediction;
        private System.Windows.Forms.RadioButton selectedEntries;
        private System.Windows.Forms.RadioButton selectedExits;
        private System.Windows.Forms.TextBox date4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox rez;
    }
}

