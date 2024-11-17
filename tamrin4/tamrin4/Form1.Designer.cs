
namespace tamrin4
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
            this.txtspeed = new System.Windows.Forms.TextBox();
            this.txtbrand = new System.Windows.Forms.TextBox();
            this.btncreatcar = new System.Windows.Forms.Button();
            this.lblinfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtspeed
            // 
            this.txtspeed.Location = new System.Drawing.Point(124, 206);
            this.txtspeed.Name = "txtspeed";
            this.txtspeed.Size = new System.Drawing.Size(125, 27);
            this.txtspeed.TabIndex = 0;
            // 
            // txtbrand
            // 
            this.txtbrand.Location = new System.Drawing.Point(124, 140);
            this.txtbrand.Name = "txtbrand";
            this.txtbrand.Size = new System.Drawing.Size(125, 27);
            this.txtbrand.TabIndex = 1;
            // 
            // btncreatcar
            // 
            this.btncreatcar.Location = new System.Drawing.Point(145, 273);
            this.btncreatcar.Name = "btncreatcar";
            this.btncreatcar.Size = new System.Drawing.Size(94, 29);
            this.btncreatcar.TabIndex = 2;
            this.btncreatcar.Text = "نمایش";
            this.btncreatcar.UseVisualStyleBackColor = true;
            this.btncreatcar.Click += new System.EventHandler(this.btncreatcar_Click);
            // 
            // lblinfo
            // 
            this.lblinfo.AutoSize = true;
            this.lblinfo.Location = new System.Drawing.Point(72, 24);
            this.lblinfo.Name = "lblinfo";
            this.lblinfo.Size = new System.Drawing.Size(0, 20);
            this.lblinfo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "سرعت";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "برند";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblinfo);
            this.Controls.Add(this.btncreatcar);
            this.Controls.Add(this.txtbrand);
            this.Controls.Add(this.txtspeed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtspeed;
        private System.Windows.Forms.TextBox txtbrand;
        private System.Windows.Forms.Button btncreatcar;
        private System.Windows.Forms.Label lblinfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

