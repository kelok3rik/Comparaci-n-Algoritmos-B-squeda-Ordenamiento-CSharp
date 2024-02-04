namespace SimularCarreras
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
            this.arregloTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_memoria = new System.Windows.Forms.Label();
            this.labelInsercion = new System.Windows.Forms.Label();
            this.labelQuik = new System.Windows.Forms.Label();
            this.labelBurbuja = new System.Windows.Forms.Label();
            this.labelBinaria = new System.Windows.Forms.Label();
            this.labelSecuencial = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTiempoSecuencial = new System.Windows.Forms.Label();
            this.labelTiempoBinario = new System.Windows.Forms.Label();
            this.labelTiempoQuickSort = new System.Windows.Forms.Label();
            this.labelTiempoBurbuja = new System.Windows.Forms.Label();
            this.labelMetodoInsercion = new System.Windows.Forms.Label();
            this.labelMemoriaConsumida = new System.Windows.Forms.Label();
            this.labelResultadoCarrera = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxBuscar = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelResultadoCarreraOrd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // arregloTxt
            // 
            this.arregloTxt.Location = new System.Drawing.Point(12, 132);
            this.arregloTxt.Name = "arregloTxt";
            this.arregloTxt.Size = new System.Drawing.Size(799, 223);
            this.arregloTxt.TabIndex = 0;
            this.arregloTxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "CARRERA ALGORITMO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arreglo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "TIEMPOS";
            // 
            // t_memoria
            // 
            this.t_memoria.AutoSize = true;
            this.t_memoria.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_memoria.Location = new System.Drawing.Point(26, 575);
            this.t_memoria.Name = "t_memoria";
            this.t_memoria.Size = new System.Drawing.Size(253, 23);
            this.t_memoria.TabIndex = 30;
            this.t_memoria.Text = "Total de memoria consumida:";
            // 
            // labelInsercion
            // 
            this.labelInsercion.AutoSize = true;
            this.labelInsercion.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInsercion.Location = new System.Drawing.Point(26, 542);
            this.labelInsercion.Name = "labelInsercion";
            this.labelInsercion.Size = new System.Drawing.Size(181, 23);
            this.labelInsercion.TabIndex = 29;
            this.labelInsercion.Text = "Metodo de Insercion";
            // 
            // labelQuik
            // 
            this.labelQuik.AutoSize = true;
            this.labelQuik.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQuik.Location = new System.Drawing.Point(26, 510);
            this.labelQuik.Name = "labelQuik";
            this.labelQuik.Size = new System.Drawing.Size(81, 23);
            this.labelQuik.TabIndex = 28;
            this.labelQuik.Text = "QuikSort";
            // 
            // labelBurbuja
            // 
            this.labelBurbuja.AutoSize = true;
            this.labelBurbuja.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBurbuja.Location = new System.Drawing.Point(26, 476);
            this.labelBurbuja.Name = "labelBurbuja";
            this.labelBurbuja.Size = new System.Drawing.Size(169, 23);
            this.labelBurbuja.TabIndex = 27;
            this.labelBurbuja.Text = "Metodo de Burbuja";
            // 
            // labelBinaria
            // 
            this.labelBinaria.AutoSize = true;
            this.labelBinaria.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBinaria.Location = new System.Drawing.Point(26, 442);
            this.labelBinaria.Name = "labelBinaria";
            this.labelBinaria.Size = new System.Drawing.Size(150, 23);
            this.labelBinaria.TabIndex = 26;
            this.labelBinaria.Text = "Busqueda Binaria";
            // 
            // labelSecuencial
            // 
            this.labelSecuencial.AutoSize = true;
            this.labelSecuencial.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSecuencial.Location = new System.Drawing.Point(26, 411);
            this.labelSecuencial.Name = "labelSecuencial";
            this.labelSecuencial.Size = new System.Drawing.Size(182, 23);
            this.labelSecuencial.TabIndex = 25;
            this.labelSecuencial.Text = "Busqueda Secuencial";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(822, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 38);
            this.button1.TabIndex = 31;
            this.button1.Text = "EJECUTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "RESULTADO:";
            // 
            // labelTiempoSecuencial
            // 
            this.labelTiempoSecuencial.AutoSize = true;
            this.labelTiempoSecuencial.Location = new System.Drawing.Point(223, 416);
            this.labelTiempoSecuencial.Name = "labelTiempoSecuencial";
            this.labelTiempoSecuencial.Size = new System.Drawing.Size(0, 16);
            this.labelTiempoSecuencial.TabIndex = 33;
            // 
            // labelTiempoBinario
            // 
            this.labelTiempoBinario.AutoSize = true;
            this.labelTiempoBinario.Location = new System.Drawing.Point(223, 447);
            this.labelTiempoBinario.Name = "labelTiempoBinario";
            this.labelTiempoBinario.Size = new System.Drawing.Size(0, 16);
            this.labelTiempoBinario.TabIndex = 34;
            // 
            // labelTiempoQuickSort
            // 
            this.labelTiempoQuickSort.AutoSize = true;
            this.labelTiempoQuickSort.Location = new System.Drawing.Point(223, 517);
            this.labelTiempoQuickSort.Name = "labelTiempoQuickSort";
            this.labelTiempoQuickSort.Size = new System.Drawing.Size(0, 16);
            this.labelTiempoQuickSort.TabIndex = 36;
            // 
            // labelTiempoBurbuja
            // 
            this.labelTiempoBurbuja.AutoSize = true;
            this.labelTiempoBurbuja.Location = new System.Drawing.Point(223, 483);
            this.labelTiempoBurbuja.Name = "labelTiempoBurbuja";
            this.labelTiempoBurbuja.Size = new System.Drawing.Size(0, 16);
            this.labelTiempoBurbuja.TabIndex = 35;
            // 
            // labelMetodoInsercion
            // 
            this.labelMetodoInsercion.AutoSize = true;
            this.labelMetodoInsercion.Location = new System.Drawing.Point(223, 547);
            this.labelMetodoInsercion.Name = "labelMetodoInsercion";
            this.labelMetodoInsercion.Size = new System.Drawing.Size(0, 16);
            this.labelMetodoInsercion.TabIndex = 37;
            // 
            // labelMemoriaConsumida
            // 
            this.labelMemoriaConsumida.AutoSize = true;
            this.labelMemoriaConsumida.Location = new System.Drawing.Point(305, 580);
            this.labelMemoriaConsumida.Name = "labelMemoriaConsumida";
            this.labelMemoriaConsumida.Size = new System.Drawing.Size(0, 16);
            this.labelMemoriaConsumida.TabIndex = 38;
            // 
            // labelResultadoCarrera
            // 
            this.labelResultadoCarrera.AutoSize = true;
            this.labelResultadoCarrera.Location = new System.Drawing.Point(198, 652);
            this.labelResultadoCarrera.Name = "labelResultadoCarrera";
            this.labelResultadoCarrera.Size = new System.Drawing.Size(0, 16);
            this.labelResultadoCarrera.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(817, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 25);
            this.label5.TabIndex = 40;
            this.label5.Text = "Buscar";
            // 
            // txtBoxBuscar
            // 
            this.txtBoxBuscar.Location = new System.Drawing.Point(896, 135);
            this.txtBoxBuscar.Name = "txtBoxBuscar";
            this.txtBoxBuscar.Size = new System.Drawing.Size(103, 22);
            this.txtBoxBuscar.TabIndex = 41;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(822, 182);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(143, 38);
            this.btnGenerar.TabIndex = 42;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 652);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Algoritmo de busqueda:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 681);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "Algoritmo de ordenamiento:";
            // 
            // labelResultadoCarreraOrd
            // 
            this.labelResultadoCarreraOrd.AutoSize = true;
            this.labelResultadoCarreraOrd.Location = new System.Drawing.Point(208, 681);
            this.labelResultadoCarreraOrd.Name = "labelResultadoCarreraOrd";
            this.labelResultadoCarreraOrd.Size = new System.Drawing.Size(0, 16);
            this.labelResultadoCarreraOrd.TabIndex = 45;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 742);
            this.Controls.Add(this.labelResultadoCarreraOrd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtBoxBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelResultadoCarrera);
            this.Controls.Add(this.labelMemoriaConsumida);
            this.Controls.Add(this.labelMetodoInsercion);
            this.Controls.Add(this.labelTiempoQuickSort);
            this.Controls.Add(this.labelTiempoBurbuja);
            this.Controls.Add(this.labelTiempoBinario);
            this.Controls.Add(this.labelTiempoSecuencial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_memoria);
            this.Controls.Add(this.labelInsercion);
            this.Controls.Add(this.labelQuik);
            this.Controls.Add(this.labelBurbuja);
            this.Controls.Add(this.labelBinaria);
            this.Controls.Add(this.labelSecuencial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arregloTxt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox arregloTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label t_memoria;
        private System.Windows.Forms.Label labelInsercion;
        private System.Windows.Forms.Label labelQuik;
        private System.Windows.Forms.Label labelBurbuja;
        private System.Windows.Forms.Label labelBinaria;
        private System.Windows.Forms.Label labelSecuencial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTiempoSecuencial;
        private System.Windows.Forms.Label labelTiempoBinario;
        private System.Windows.Forms.Label labelTiempoQuickSort;
        private System.Windows.Forms.Label labelTiempoBurbuja;
        private System.Windows.Forms.Label labelMetodoInsercion;
        private System.Windows.Forms.Label labelMemoriaConsumida;
        private System.Windows.Forms.Label labelResultadoCarrera;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxBuscar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelResultadoCarreraOrd;
    }
}

