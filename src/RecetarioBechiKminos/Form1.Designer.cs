﻿namespace RecetarioBechiKminos
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
            this.Modificar_button2 = new System.Windows.Forms.Button();
            this.Comprarbutton3 = new System.Windows.Forms.Button();
            this.Cocinar_button8 = new System.Windows.Forms.Button();
            this.Modificar_button10 = new System.Windows.Forms.Button();
            this.Ingrediente_ListBox = new System.Windows.Forms.ListBox();
            this.Receta_ListBox = new System.Windows.Forms.ListBox();
            this.RecetaIngrediente_ListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cantidad_textBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.precio_textBox = new System.Windows.Forms.TextBox();
            this.nombre_textBox = new System.Windows.Forms.TextBox();
            this.puntodepedido_textBox = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Eliminar_button9 = new System.Windows.Forms.Button();
            this.Agregar_button11 = new System.Windows.Forms.Button();
            this.Eliminar_button5 = new System.Windows.Forms.Button();
            this.Modificar_button6 = new System.Windows.Forms.Button();
            this.Agregar_button7 = new System.Windows.Forms.Button();
            this.Agregar_button4 = new System.Windows.Forms.Button();
            this.Eliminar_button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Modificar_button2
            // 
            this.Modificar_button2.Location = new System.Drawing.Point(217, 360);
            this.Modificar_button2.Name = "Modificar_button2";
            this.Modificar_button2.Size = new System.Drawing.Size(75, 23);
            this.Modificar_button2.TabIndex = 1;
            this.Modificar_button2.Text = "Modificar";
            this.Modificar_button2.UseVisualStyleBackColor = true;
            this.Modificar_button2.Click += new System.EventHandler(this.Modificar_button2_Click);
            // 
            // Comprarbutton3
            // 
            this.Comprarbutton3.Location = new System.Drawing.Point(217, 418);
            this.Comprarbutton3.Name = "Comprarbutton3";
            this.Comprarbutton3.Size = new System.Drawing.Size(156, 23);
            this.Comprarbutton3.TabIndex = 2;
            this.Comprarbutton3.Text = "Comprar";
            this.Comprarbutton3.UseVisualStyleBackColor = true;
            // 
            // Cocinar_button8
            // 
            this.Cocinar_button8.Location = new System.Drawing.Point(217, 200);
            this.Cocinar_button8.Name = "Cocinar_button8";
            this.Cocinar_button8.Size = new System.Drawing.Size(156, 23);
            this.Cocinar_button8.TabIndex = 4;
            this.Cocinar_button8.Text = "Cocinar";
            this.Cocinar_button8.UseVisualStyleBackColor = true;
            // 
            // Modificar_button10
            // 
            this.Modificar_button10.Location = new System.Drawing.Point(572, 285);
            this.Modificar_button10.Name = "Modificar_button10";
            this.Modificar_button10.Size = new System.Drawing.Size(75, 23);
            this.Modificar_button10.TabIndex = 9;
            this.Modificar_button10.Text = "Modificar";
            this.Modificar_button10.UseVisualStyleBackColor = true;
            // 
            // Ingrediente_ListBox
            // 
            this.Ingrediente_ListBox.DisplayMember = "Ingrediente.Nombre";
            this.Ingrediente_ListBox.FormattingEnabled = true;
            this.Ingrediente_ListBox.Location = new System.Drawing.Point(217, 229);
            this.Ingrediente_ListBox.Name = "Ingrediente_ListBox";
            this.Ingrediente_ListBox.Size = new System.Drawing.Size(156, 121);
            this.Ingrediente_ListBox.TabIndex = 11;
            this.Ingrediente_ListBox.SelectedIndexChanged += new System.EventHandler(this.Ingrediente_ListBox_SelectedIndexChanged);
            // 
            // Receta_ListBox
            // 
            this.Receta_ListBox.FormattingEnabled = true;
            this.Receta_ListBox.Location = new System.Drawing.Point(217, 12);
            this.Receta_ListBox.Name = "Receta_ListBox";
            this.Receta_ListBox.Size = new System.Drawing.Size(156, 121);
            this.Receta_ListBox.TabIndex = 12;
            // 
            // RecetaIngrediente_ListBox
            // 
            this.RecetaIngrediente_ListBox.FormattingEnabled = true;
            this.RecetaIngrediente_ListBox.Location = new System.Drawing.Point(572, 126);
            this.RecetaIngrediente_ListBox.Name = "RecetaIngrediente_ListBox";
            this.RecetaIngrediente_ListBox.Size = new System.Drawing.Size(158, 147);
            this.RecetaIngrediente_ListBox.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // cantidad_textBox
            // 
            this.cantidad_textBox.Location = new System.Drawing.Point(108, 264);
            this.cantidad_textBox.Name = "cantidad_textBox";
            this.cantidad_textBox.Size = new System.Drawing.Size(100, 20);
            this.cantidad_textBox.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(108, 62);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 17;
            // 
            // precio_textBox
            // 
            this.precio_textBox.Location = new System.Drawing.Point(108, 300);
            this.precio_textBox.Name = "precio_textBox";
            this.precio_textBox.Size = new System.Drawing.Size(100, 20);
            this.precio_textBox.TabIndex = 21;
            // 
            // nombre_textBox
            // 
            this.nombre_textBox.Location = new System.Drawing.Point(108, 229);
            this.nombre_textBox.Name = "nombre_textBox";
            this.nombre_textBox.Size = new System.Drawing.Size(100, 20);
            this.nombre_textBox.TabIndex = 20;
            // 
            // puntodepedido_textBox
            // 
            this.puntodepedido_textBox.Location = new System.Drawing.Point(108, 330);
            this.puntodepedido_textBox.Name = "puntodepedido_textBox";
            this.puntodepedido_textBox.Size = new System.Drawing.Size(100, 20);
            this.puntodepedido_textBox.TabIndex = 18;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(462, 160);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Punto de pedido ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Tiempo Prep";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Ingrediente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(398, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Cantidad";
            // 
            // Eliminar_button9
            // 
            this.Eliminar_button9.Location = new System.Drawing.Point(653, 285);
            this.Eliminar_button9.Name = "Eliminar_button9";
            this.Eliminar_button9.Size = new System.Drawing.Size(75, 23);
            this.Eliminar_button9.TabIndex = 10;
            this.Eliminar_button9.Text = "Eliminar";
            this.Eliminar_button9.UseVisualStyleBackColor = true;
            // 
            // Agregar_button11
            // 
            this.Agregar_button11.Image = global::RecetarioBechiKminos.Properties.Resources.index;
            this.Agregar_button11.Location = new System.Drawing.Point(572, 314);
            this.Agregar_button11.Name = "Agregar_button11";
            this.Agregar_button11.Size = new System.Drawing.Size(156, 23);
            this.Agregar_button11.TabIndex = 8;
            this.Agregar_button11.Text = "Agregar";
            this.Agregar_button11.UseVisualStyleBackColor = true;
            // 
            // Eliminar_button5
            // 
            this.Eliminar_button5.Location = new System.Drawing.Point(298, 142);
            this.Eliminar_button5.Name = "Eliminar_button5";
            this.Eliminar_button5.Size = new System.Drawing.Size(75, 23);
            this.Eliminar_button5.TabIndex = 7;
            this.Eliminar_button5.Text = "Eliminar";
            this.Eliminar_button5.UseVisualStyleBackColor = true;
            // 
            // Modificar_button6
            // 
            this.Modificar_button6.Location = new System.Drawing.Point(217, 142);
            this.Modificar_button6.Name = "Modificar_button6";
            this.Modificar_button6.Size = new System.Drawing.Size(75, 23);
            this.Modificar_button6.TabIndex = 6;
            this.Modificar_button6.Text = "Modificar";
            this.Modificar_button6.UseVisualStyleBackColor = true;
            // 
            // Agregar_button7
            // 
            this.Agregar_button7.Image = global::RecetarioBechiKminos.Properties.Resources.index;
            this.Agregar_button7.Location = new System.Drawing.Point(217, 171);
            this.Agregar_button7.Name = "Agregar_button7";
            this.Agregar_button7.Size = new System.Drawing.Size(156, 23);
            this.Agregar_button7.TabIndex = 5;
            this.Agregar_button7.Text = "Agregar";
            this.Agregar_button7.UseVisualStyleBackColor = true;
            // 
            // Agregar_button4
            // 
            this.Agregar_button4.Image = global::RecetarioBechiKminos.Properties.Resources.index;
            this.Agregar_button4.Location = new System.Drawing.Point(217, 389);
            this.Agregar_button4.Name = "Agregar_button4";
            this.Agregar_button4.Size = new System.Drawing.Size(156, 23);
            this.Agregar_button4.TabIndex = 3;
            this.Agregar_button4.Text = "Agregar";
            this.Agregar_button4.UseVisualStyleBackColor = true;
            this.Agregar_button4.Click += new System.EventHandler(this.Agregar_button4_Click);
            // 
            // Eliminar_button1
            // 
            this.Eliminar_button1.Location = new System.Drawing.Point(298, 360);
            this.Eliminar_button1.Name = "Eliminar_button1";
            this.Eliminar_button1.Size = new System.Drawing.Size(75, 23);
            this.Eliminar_button1.TabIndex = 0;
            this.Eliminar_button1.Text = "Eliminar";
            this.Eliminar_button1.UseVisualStyleBackColor = true;
            this.Eliminar_button1.Click += new System.EventHandler(this.Eliminar_button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(465, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 463);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.precio_textBox);
            this.Controls.Add(this.nombre_textBox);
            this.Controls.Add(this.puntodepedido_textBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.cantidad_textBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.RecetaIngrediente_ListBox);
            this.Controls.Add(this.Receta_ListBox);
            this.Controls.Add(this.Ingrediente_ListBox);
            this.Controls.Add(this.Eliminar_button9);
            this.Controls.Add(this.Modificar_button10);
            this.Controls.Add(this.Agregar_button11);
            this.Controls.Add(this.Eliminar_button5);
            this.Controls.Add(this.Modificar_button6);
            this.Controls.Add(this.Agregar_button7);
            this.Controls.Add(this.Cocinar_button8);
            this.Controls.Add(this.Agregar_button4);
            this.Controls.Add(this.Comprarbutton3);
            this.Controls.Add(this.Modificar_button2);
            this.Controls.Add(this.Eliminar_button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Eliminar_button1;
        private System.Windows.Forms.Button Modificar_button2;
        private System.Windows.Forms.Button Comprarbutton3;
        private System.Windows.Forms.Button Agregar_button4;
        private System.Windows.Forms.Button Eliminar_button5;
        private System.Windows.Forms.Button Modificar_button6;
        private System.Windows.Forms.Button Agregar_button7;
        private System.Windows.Forms.Button Cocinar_button8;
        private System.Windows.Forms.Button Eliminar_button9;
        private System.Windows.Forms.Button Modificar_button10;
        private System.Windows.Forms.Button Agregar_button11;
        private System.Windows.Forms.ListBox Ingrediente_ListBox;
        private System.Windows.Forms.ListBox Receta_ListBox;
        private System.Windows.Forms.ListBox RecetaIngrediente_ListBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox cantidad_textBox;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox precio_textBox;
        private System.Windows.Forms.TextBox nombre_textBox;
        private System.Windows.Forms.TextBox puntodepedido_textBox;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

