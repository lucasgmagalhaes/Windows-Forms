namespace Leitor_Base_TI
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
            this.btnrun = new System.Windows.Forms.Button();
            this.listallprocess = new System.Windows.Forms.ListView();
            this.listfinished = new System.Windows.Forms.ListView();
            this.btncarregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnrun
            // 
            this.btnrun.Location = new System.Drawing.Point(414, 41);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(112, 30);
            this.btnrun.TabIndex = 2;
            this.btnrun.Text = "Executar";
            this.btnrun.UseVisualStyleBackColor = true;
            // 
            // listallprocess
            // 
            this.listallprocess.Location = new System.Drawing.Point(12, 41);
            this.listallprocess.Name = "listallprocess";
            this.listallprocess.Size = new System.Drawing.Size(396, 316);
            this.listallprocess.TabIndex = 3;
            this.listallprocess.UseCompatibleStateImageBehavior = false;
            this.listallprocess.View = System.Windows.Forms.View.Details;
            // 
            // listfinished
            // 
            this.listfinished.Location = new System.Drawing.Point(532, 41);
            this.listfinished.Name = "listfinished";
            this.listfinished.Size = new System.Drawing.Size(396, 316);
            this.listfinished.TabIndex = 4;
            this.listfinished.UseCompatibleStateImageBehavior = false;
            this.listfinished.View = System.Windows.Forms.View.Details;
            // 
            // btncarregar
            // 
            this.btncarregar.Location = new System.Drawing.Point(12, 5);
            this.btncarregar.Name = "btncarregar";
            this.btncarregar.Size = new System.Drawing.Size(112, 30);
            this.btncarregar.TabIndex = 5;
            this.btncarregar.Text = "Carregar arquivo";
            this.btncarregar.UseVisualStyleBackColor = true;
            this.btncarregar.Click += new System.EventHandler(this.btncarregar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 378);
            this.Controls.Add(this.btncarregar);
            this.Controls.Add(this.listfinished);
            this.Controls.Add(this.listallprocess);
            this.Controls.Add(this.btnrun);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnrun;
        private System.Windows.Forms.ListView listallprocess;
        private System.Windows.Forms.ListView listfinished;
        private System.Windows.Forms.Button btncarregar;
    }
}

