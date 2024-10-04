namespace ArchivosVisual
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbGen = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbShow = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(105, 28);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(221, 26);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edad:";
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(87, 86);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(221, 26);
            this.tbAge.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota:";
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(87, 146);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(221, 26);
            this.tbGrade.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genero:";
            // 
            // cmbGen
            // 
            this.cmbGen.FormattingEnabled = true;
            this.cmbGen.Items.AddRange(new object[] {
            "F",
            "M"});
            this.cmbGen.Location = new System.Drawing.Point(103, 208);
            this.cmbGen.Name = "cmbGen";
            this.cmbGen.Size = new System.Drawing.Size(121, 28);
            this.cmbGen.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(34, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 69);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Registrar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbShow
            // 
            this.lbShow.FormattingEnabled = true;
            this.lbShow.ItemHeight = 20;
            this.lbShow.Location = new System.Drawing.Point(439, 12);
            this.lbShow.Name = "lbShow";
            this.lbShow.Size = new System.Drawing.Size(269, 284);
            this.lbShow.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbShow);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbGen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbGrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbGen;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lbShow;
    }
}

