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
            this.date1.Location = new System.Drawing.Point(12, 45);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(167, 20);
            this.date1.TabIndex = 1;
            this.date1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.date1_KeyPress);
            // 
            // date2
            // 
            this.date2.Location = new System.Drawing.Point(12, 71);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(167, 20);
            this.date2.TabIndex = 2;
            this.date2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.date2_KeyPress);
            // 
            // date3
            // 
            this.date3.Location = new System.Drawing.Point(12, 97);
            this.date3.Name = "date3";
            this.date3.Size = new System.Drawing.Size(167, 20);
            this.date3.TabIndex = 3;
            this.date3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.date3_KeyPress);
            // 
            // doPrediction
            // 
            this.doPrediction.Location = new System.Drawing.Point(18, 142);
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
            this.selectedEntries.Location = new System.Drawing.Point(154, 134);
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
            this.selectedExits.Location = new System.Drawing.Point(154, 157);
            this.selectedExits.Name = "selectedExits";
            this.selectedExits.Size = new System.Drawing.Size(112, 17);
            this.selectedExits.TabIndex = 6;
            this.selectedExits.TabStop = true;
            this.selectedExits.Text = "Predikcija izlazaka";
            this.selectedExits.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 186);
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
    }
}

