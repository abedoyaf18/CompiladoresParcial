
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
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dummydgv = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.reservadadgv = new System.Windows.Forms.DataGridView();
            this.simbolodgv = new System.Windows.Forms.DataGridView();
            this.literaldgv = new System.Windows.Forms.DataGridView();
            this.btnProcess = new System.Windows.Forms.Button();
            this.rbtnText = new System.Windows.Forms.RadioButton();
            this.rbtnFile = new System.Windows.Forms.RadioButton();
            this.latinoButton = new System.Windows.Forms.Button();
            this.ListaComponente = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.rbtnErrores = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dummydgv)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservadadgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simbolodgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.literaldgv)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnFile);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1000, 439);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Archivo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(230, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(724, 110);
            this.btnFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(191, 36);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Seleccionar archivo";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.txtLines);
            this.groupBox2.Controls.Add(this.txtConsole);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 54);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1000, 439);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Texto";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtLines
            // 
            this.txtLines.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtLines.Location = new System.Drawing.Point(4, 28);
            this.txtLines.Margin = new System.Windows.Forms.Padding(4);
            this.txtLines.Multiline = true;
            this.txtLines.Name = "txtLines";
            this.txtLines.Size = new System.Drawing.Size(484, 407);
            this.txtLines.TabIndex = 1;
            this.txtLines.TextChanged += new System.EventHandler(this.txtLines_TextChanged);
            // 
            // txtConsole
            // 
            this.txtConsole.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtConsole.Location = new System.Drawing.Point(512, 28);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ReadOnly = true;
            this.txtConsole.Size = new System.Drawing.Size(484, 407);
            this.txtConsole.TabIndex = 13;
            this.txtConsole.TextChanged += new System.EventHandler(this.txtConsole_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dummydgv);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.reservadadgv);
            this.groupBox3.Controls.Add(this.simbolodgv);
            this.groupBox3.Controls.Add(this.literaldgv);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 54);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1000, 439);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tablas";
            // 
            // dummydgv
            // 
            this.dummydgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dummydgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dummydgv.Location = new System.Drawing.Point(167, 28);
            this.dummydgv.Margin = new System.Windows.Forms.Padding(4);
            this.dummydgv.Name = "dummydgv";
            this.dummydgv.RowHeadersWidth = 51;
            this.dummydgv.RowTemplate.Height = 29;
            this.dummydgv.Size = new System.Drawing.Size(829, 407);
            this.dummydgv.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(4, 28);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(4);
            this.panel2.Size = new System.Drawing.Size(163, 407);
            this.panel2.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(4, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "Símbolo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(4, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Palabra Reservada";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(4, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Literal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Dummy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // reservadadgv
            // 
            this.reservadadgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservadadgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reservadadgv.Location = new System.Drawing.Point(4, 28);
            this.reservadadgv.Margin = new System.Windows.Forms.Padding(4);
            this.reservadadgv.Name = "reservadadgv";
            this.reservadadgv.RowHeadersWidth = 51;
            this.reservadadgv.RowTemplate.Height = 29;
            this.reservadadgv.Size = new System.Drawing.Size(992, 407);
            this.reservadadgv.TabIndex = 3;
            // 
            // simbolodgv
            // 
            this.simbolodgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.simbolodgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simbolodgv.Location = new System.Drawing.Point(4, 28);
            this.simbolodgv.Margin = new System.Windows.Forms.Padding(4);
            this.simbolodgv.Name = "simbolodgv";
            this.simbolodgv.RowHeadersWidth = 51;
            this.simbolodgv.RowTemplate.Height = 29;
            this.simbolodgv.Size = new System.Drawing.Size(992, 407);
            this.simbolodgv.TabIndex = 2;
            // 
            // literaldgv
            // 
            this.literaldgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.literaldgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.literaldgv.Location = new System.Drawing.Point(4, 28);
            this.literaldgv.Margin = new System.Windows.Forms.Padding(4);
            this.literaldgv.Name = "literaldgv";
            this.literaldgv.RowHeadersWidth = 51;
            this.literaldgv.RowTemplate.Height = 29;
            this.literaldgv.Size = new System.Drawing.Size(992, 407);
            this.literaldgv.TabIndex = 1;
            this.literaldgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(472, 9);
            this.btnProcess.Margin = new System.Windows.Forms.Padding(4);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(118, 36);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Morse";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbtnText
            // 
            this.rbtnText.AutoSize = true;
            this.rbtnText.Checked = true;
            this.rbtnText.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnText.Location = new System.Drawing.Point(0, 0);
            this.rbtnText.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnText.Name = "rbtnText";
            this.rbtnText.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.rbtnText.Size = new System.Drawing.Size(94, 54);
            this.rbtnText.TabIndex = 14;
            this.rbtnText.TabStop = true;
            this.rbtnText.Text = "Texto";
            this.rbtnText.UseVisualStyleBackColor = true;
            this.rbtnText.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnFile
            // 
            this.rbtnFile.AutoSize = true;
            this.rbtnFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnFile.Location = new System.Drawing.Point(94, 0);
            this.rbtnFile.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnFile.Name = "rbtnFile";
            this.rbtnFile.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.rbtnFile.Size = new System.Drawing.Size(113, 54);
            this.rbtnFile.TabIndex = 15;
            this.rbtnFile.Text = "Archivo";
            this.rbtnFile.UseVisualStyleBackColor = true;
            this.rbtnFile.CheckedChanged += new System.EventHandler(this.rbtnFile_CheckedChanged);
            // 
            // latinoButton
            // 
            this.latinoButton.Location = new System.Drawing.Point(615, 9);
            this.latinoButton.Margin = new System.Windows.Forms.Padding(4);
            this.latinoButton.Name = "latinoButton";
            this.latinoButton.Size = new System.Drawing.Size(118, 36);
            this.latinoButton.TabIndex = 16;
            this.latinoButton.Text = "Latino";
            this.latinoButton.UseVisualStyleBackColor = true;
            this.latinoButton.Click += new System.EventHandler(this.latinoButton_Click);
            // 
            // ListaComponente
            // 
            this.ListaComponente.AutoSize = true;
            this.ListaComponente.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListaComponente.Location = new System.Drawing.Point(207, 0);
            this.ListaComponente.Margin = new System.Windows.Forms.Padding(4);
            this.ListaComponente.Name = "ListaComponente";
            this.ListaComponente.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.ListaComponente.Size = new System.Drawing.Size(93, 54);
            this.ListaComponente.TabIndex = 17;
            this.ListaComponente.Text = "Tabla";
            this.ListaComponente.UseVisualStyleBackColor = true;
            this.ListaComponente.CheckedChanged += new System.EventHandler(this.ListaComponente_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView5);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 54);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1000, 439);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Errores";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(8, 32);
            this.dataGridView5.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.RowHeadersWidth = 51;
            this.dataGridView5.RowTemplate.Height = 29;
            this.dataGridView5.Size = new System.Drawing.Size(964, 515);
            this.dataGridView5.TabIndex = 0;
            // 
            // rbtnErrores
            // 
            this.rbtnErrores.AutoSize = true;
            this.rbtnErrores.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtnErrores.Location = new System.Drawing.Point(300, 0);
            this.rbtnErrores.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnErrores.Name = "rbtnErrores";
            this.rbtnErrores.Padding = new System.Windows.Forms.Padding(16, 0, 0, 0);
            this.rbtnErrores.Size = new System.Drawing.Size(108, 54);
            this.rbtnErrores.TabIndex = 29;
            this.rbtnErrores.Text = "Errores";
            this.rbtnErrores.UseVisualStyleBackColor = true;
            this.rbtnErrores.CheckedChanged += new System.EventHandler(this.rbtnErrores_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.latinoButton);
            this.panel1.Controls.Add(this.btnProcess);
            this.panel1.Controls.Add(this.rbtnErrores);
            this.panel1.Controls.Add(this.ListaComponente);
            this.panel1.Controls.Add(this.rbtnFile);
            this.panel1.Controls.Add(this.rbtnText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 54);
            this.panel1.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dummydgv)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reservadadgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simbolodgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.literaldgv)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView reservadadgv;
        private System.Windows.Forms.DataGridView simbolodgv;
        private System.Windows.Forms.DataGridView literaldgv;
        private System.Windows.Forms.DataGridView dummydgv;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.RadioButton rbtnErrores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

