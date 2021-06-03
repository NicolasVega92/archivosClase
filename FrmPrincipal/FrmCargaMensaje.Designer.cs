
namespace FrmPrincipal
{
    partial class FrmCargaMensaje
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.rbtCargaMensaje = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(12, 260);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(129, 61);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // rbtCargaMensaje
            // 
            this.rbtCargaMensaje.Location = new System.Drawing.Point(12, 33);
            this.rbtCargaMensaje.Name = "rbtCargaMensaje";
            this.rbtCargaMensaje.Size = new System.Drawing.Size(350, 221);
            this.rbtCargaMensaje.TabIndex = 1;
            this.rbtCargaMensaje.Text = "";
            // 
            // FrmCargaMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 411);
            this.Controls.Add(this.rbtCargaMensaje);
            this.Controls.Add(this.btnVolver);
            this.Location = new System.Drawing.Point(391, 0);
            this.Name = "FrmCargaMensaje";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmCargaMensaje";
            this.Load += new System.EventHandler(this.FrmCargaMensaje_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.RichTextBox rbtCargaMensaje;
    }
}