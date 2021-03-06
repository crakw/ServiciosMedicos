﻿namespace PrototipoSeguridad
{
    partial class Enfermedades
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
            this.primarykey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navegador1 = new Navegador.Navegador();
            this.label2 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.Lbl_des = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // primarykey
            // 
            this.primarykey.Location = new System.Drawing.Point(497, 202);
            this.primarykey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.primarykey.Name = "primarykey";
            this.primarykey.Size = new System.Drawing.Size(143, 22);
            this.primarykey.TabIndex = 39;
            this.primarykey.Tag = "id_enfermedad";
            this.primarykey.TextChanged += new System.EventHandler(this.primarykey_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(409, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Codigo:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.Color.Gainsboro;
            this.navegador1.Location = new System.Drawing.Point(54, 81);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.sAppNumero = "6";
            this.navegador1.Size = new System.Drawing.Size(900, 82);
            this.navegador1.sNom_Usuario = "3";
            this.navegador1.sNombreBD = "bd_seguridad";
            this.navegador1.sNombreTabla = "enfermedades";
            this.navegador1.sPass = null;
            this.navegador1.sServidor = "localhost";
            this.navegador1.sUsuario = "root";
            this.navegador1.TabIndex = 41;
            this.navegador1.NavInsertar += new System.EventHandler(this.navegador1_NavInsertar);
            this.navegador1.NavActualizar += new System.EventHandler(this.navegador1_NavActualizar);
            this.navegador1.NavEliminar += new System.EventHandler(this.navegador1_NavEliminar);
            this.navegador1.NavGuardar += new System.EventHandler(this.navegador1_NavGuardar);
            this.navegador1.NavInicio += new System.EventHandler(this.navegador1_NavInicio);
            this.navegador1.NavAnterior += new System.EventHandler(this.navegador1_NavAnterior);
            this.navegador1.NavSiguiente += new System.EventHandler(this.navegador1_NavSiguiente);
            this.navegador1.NavFin += new System.EventHandler(this.navegador1_NavFin);
            this.navegador1.NavSalir += new System.EventHandler(this.navegador1_NavSalir);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 32);
            this.label2.TabIndex = 40;
            this.label2.Text = "Mantenimiento de Enfermedades";
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(497, 252);
            this.descripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(143, 22);
            this.descripcion.TabIndex = 37;
            this.descripcion.Tag = "descrip_enfer";
            this.descripcion.TextChanged += new System.EventHandler(this.descripcion_TextChanged);
            // 
            // Lbl_des
            // 
            this.Lbl_des.AutoSize = true;
            this.Lbl_des.Location = new System.Drawing.Point(379, 252);
            this.Lbl_des.Name = "Lbl_des";
            this.Lbl_des.Size = new System.Drawing.Size(86, 17);
            this.Lbl_des.TabIndex = 36;
            this.Lbl_des.Text = "Descripcion:";
            this.Lbl_des.Click += new System.EventHandler(this.Lbl_des_Click);
            // 
            // Enfermedades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(996, 331);
            this.Controls.Add(this.primarykey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.Lbl_des);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Enfermedades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alergias";
            this.Load += new System.EventHandler(this.Alergias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox primarykey;
        private System.Windows.Forms.Label label1;
        private Navegador.Navegador navegador1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.Label Lbl_des;
    }
}