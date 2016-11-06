namespace VentanasFintech
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:  ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 24);
            this.textBox1.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(581, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 28);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Programador";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Location = new System.Drawing.Point(28, 131);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(195, 263);
            this.treeView1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add Node";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(245, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 27);
            this.button3.TabIndex = 6;
            this.button3.Text = "Remove Node";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // treeView2
            // 
            this.treeView2.AllowDrop = true;
            this.treeView2.CheckBoxes = true;
            this.treeView2.Location = new System.Drawing.Point(357, 131);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(195, 263);
            this.treeView2.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(840, 453);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(732, 454);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 28);
            this.button5.TabIndex = 9;
            this.button5.Text = "Programar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(625, 455);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(91, 27);
            this.button6.TabIndex = 10;
            this.button6.Text = "Ejecutar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(577, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Descripcion: ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(581, 155);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(350, 177);
            this.textBox3.TabIndex = 16;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(516, 456);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(89, 26);
            this.Guardar.TabIndex = 17;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(968, 494);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Name = "Form2";
            this.Text = "Nueva Secuencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Guardar;
    }
}