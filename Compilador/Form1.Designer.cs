
namespace Compilador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtLines = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnProcess = new System.Windows.Forms.Button();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.rbtnText = new System.Windows.Forms.RadioButton();
            this.rbtnFile = new System.Windows.Forms.RadioButton();
            this.latinoButton = new System.Windows.Forms.Button();
            this.ListaComponente = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.rbtnErrores = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFile);
            this.groupBox1.Location = new System.Drawing.Point(11, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 423);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "archivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(579, 88);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(153, 29);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Seleccionar archivo";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtLines);
            this.groupBox2.Location = new System.Drawing.Point(4, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 431);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "texto";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtLines
            // 
            this.txtLines.Location = new System.Drawing.Point(29, 37);
            this.txtLines.Multiline = true;
            this.txtLines.Name = "txtLines";
            this.txtLines.Size = new System.Drawing.Size(729, 339);
            this.txtLines.TabIndex = 1;
            this.txtLines.TextChanged += new System.EventHandler(this.txtLines_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Controls.Add(this.dataGridView4);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(5, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 457);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tablas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Simbolo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Palabra reservada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Litera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dummy";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(13, 233);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(744, 96);
            this.dataGridView3.TabIndex = 3;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(12, 335);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 29;
            this.dataGridView4.Size = new System.Drawing.Size(744, 95);
            this.dataGridView4.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 133);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(744, 94);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(744, 93);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(11, 522);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(94, 29);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "morse";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(11, 572);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(777, 287);
            this.txtConsole.TabIndex = 13;
            this.txtConsole.TextChanged += new System.EventHandler(this.txtConsole_TextChanged);
            // 
            // rbtnText
            // 
            this.rbtnText.AutoSize = true;
            this.rbtnText.Checked = true;
            this.rbtnText.Location = new System.Drawing.Point(18, 21);
            this.rbtnText.Name = "rbtnText";
            this.rbtnText.Size = new System.Drawing.Size(64, 24);
            this.rbtnText.TabIndex = 14;
            this.rbtnText.TabStop = true;
            this.rbtnText.Text = "texto";
            this.rbtnText.UseVisualStyleBackColor = true;
            this.rbtnText.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnFile
            // 
            this.rbtnFile.AutoSize = true;
            this.rbtnFile.Location = new System.Drawing.Point(163, 20);
            this.rbtnFile.Name = "rbtnFile";
            this.rbtnFile.Size = new System.Drawing.Size(78, 24);
            this.rbtnFile.TabIndex = 15;
            this.rbtnFile.Text = "archivo";
            this.rbtnFile.UseVisualStyleBackColor = true;
            this.rbtnFile.CheckedChanged += new System.EventHandler(this.rbtnFile_CheckedChanged);
            // 
            // latinoButton
            // 
            this.latinoButton.Location = new System.Drawing.Point(277, 522);
            this.latinoButton.Name = "latinoButton";
            this.latinoButton.Size = new System.Drawing.Size(94, 29);
            this.latinoButton.TabIndex = 16;
            this.latinoButton.Text = "latino";
            this.latinoButton.UseVisualStyleBackColor = true;
            this.latinoButton.Click += new System.EventHandler(this.latinoButton_Click);
            // 
            // ListaComponente
            // 
            this.ListaComponente.AutoSize = true;
            this.ListaComponente.Location = new System.Drawing.Point(311, 21);
            this.ListaComponente.Name = "ListaComponente";
            this.ListaComponente.Size = new System.Drawing.Size(65, 24);
            this.ListaComponente.TabIndex = 17;
            this.ListaComponente.Text = "Tabla";
            this.ListaComponente.UseVisualStyleBackColor = true;
            this.ListaComponente.CheckedChanged += new System.EventHandler(this.ListaComponente_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView5);
            this.groupBox4.Location = new System.Drawing.Point(3, 51);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(784, 444);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Errores";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(6, 26);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 29;
            this.dataGridView5.Size = new System.Drawing.Size(771, 412);
            this.dataGridView5.TabIndex = 0;
            // 
            // rbtnErrores
            // 
            this.rbtnErrores.AutoSize = true;
            this.rbtnErrores.Location = new System.Drawing.Point(430, 21);
            this.rbtnErrores.Name = "rbtnErrores";
            this.rbtnErrores.Size = new System.Drawing.Size(76, 24);
            this.rbtnErrores.TabIndex = 29;
            this.rbtnErrores.Text = "errores";
            this.rbtnErrores.UseVisualStyleBackColor = true;
            this.rbtnErrores.CheckedChanged += new System.EventHandler(this.rbtnErrores_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 869);
            this.Controls.Add(this.rbtnErrores);
            this.Controls.Add(this.ListaComponente);
            this.Controls.Add(this.latinoButton);
            this.Controls.Add(this.rbtnFile);
            this.Controls.Add(this.rbtnText);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txtConsole);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnText;
        private System.Windows.Forms.RadioButton rbtnFile;
        private System.Windows.Forms.TextBox txtLines;
        private System.Windows.Forms.Button latinoButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton ListaComponente;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.RadioButton rbtnErrores;
    }
}

