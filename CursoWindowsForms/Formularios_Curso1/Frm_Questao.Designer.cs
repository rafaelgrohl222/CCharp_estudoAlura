﻿
namespace CursoWindowsForms
{
    partial class Frm_Questao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Questao));
            this.Lbl_Questao = new System.Windows.Forms.Label();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.Btn_ = new System.Windows.Forms.Button();
            this.Pic_Imagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Questao
            // 
            this.Lbl_Questao.AutoSize = true;
            this.Lbl_Questao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Questao.Location = new System.Drawing.Point(18, 9);
            this.Lbl_Questao.Name = "Lbl_Questao";
            this.Lbl_Questao.Size = new System.Drawing.Size(229, 20);
            this.Lbl_Questao.TabIndex = 0;
            this.Lbl_Questao.Text = "Você deseja validar o CPF?";
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(147, 60);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(115, 23);
            this.Btn_Ok.TabIndex = 1;
            this.Btn_Ok.Text = "Sim. Continue";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // Btn_
            // 
            this.Btn_.Location = new System.Drawing.Point(147, 89);
            this.Btn_.Name = "Btn_";
            this.Btn_.Size = new System.Drawing.Size(115, 23);
            this.Btn_.TabIndex = 2;
            this.Btn_.Text = "Não. Pare";
            this.Btn_.UseVisualStyleBackColor = true;
            this.Btn_.Click += new System.EventHandler(this.Btn__Click);
            // 
            // Pic_Imagem
            // 
            this.Pic_Imagem.Image = global::CursoWindowsForms.Properties.Resources.Frm_Question96x961;
            this.Pic_Imagem.Location = new System.Drawing.Point(22, 40);
            this.Pic_Imagem.Name = "Pic_Imagem";
            this.Pic_Imagem.Size = new System.Drawing.Size(101, 97);
            this.Pic_Imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Imagem.TabIndex = 3;
            this.Pic_Imagem.TabStop = false;
            // 
            // Frm_Questao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 151);
            this.Controls.Add(this.Pic_Imagem);
            this.Controls.Add(this.Btn_);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Lbl_Questao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Questao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questão";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Questao;
        private System.Windows.Forms.Button Btn_Ok;
        private System.Windows.Forms.Button Btn_;
        private System.Windows.Forms.PictureBox Pic_Imagem;
    }
}