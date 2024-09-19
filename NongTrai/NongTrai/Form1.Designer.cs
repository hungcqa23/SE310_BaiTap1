namespace NongTrai
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
            this.txtNameFarm = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBo = new System.Windows.Forms.TextBox();
            this.txtCuu = new System.Windows.Forms.TextBox();
            this.txtDe = new System.Windows.Forms.TextBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtTiengKeu = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.txtLamMoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNameFarm
            // 
            this.txtNameFarm.AutoSize = true;
            this.txtNameFarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameFarm.ForeColor = System.Drawing.Color.Crimson;
            this.txtNameFarm.Location = new System.Drawing.Point(202, 55);
            this.txtNameFarm.Name = "txtNameFarm";
            this.txtNameFarm.Size = new System.Drawing.Size(450, 39);
            this.txtNameFarm.TabIndex = 0;
            this.txtNameFarm.Text = "Nông Trại nhà Thạch Sang";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLamMoi);
            this.groupBox1.Controls.Add(this.btnThongKe);
            this.groupBox1.Controls.Add(this.txtTiengKeu);
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Controls.Add(this.txtDe);
            this.groupBox1.Controls.Add(this.txtCuu);
            this.groupBox1.Controls.Add(this.txtBo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(56, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(750, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số lượng bò:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số lượng cừu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng dê:";
            // 
            // txtBo
            // 
            this.txtBo.Location = new System.Drawing.Point(176, 42);
            this.txtBo.Name = "txtBo";
            this.txtBo.Size = new System.Drawing.Size(202, 22);
            this.txtBo.TabIndex = 1;
            this.txtBo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBo_KeyPress);
            // 
            // txtCuu
            // 
            this.txtCuu.Location = new System.Drawing.Point(176, 88);
            this.txtCuu.Name = "txtCuu";
            this.txtCuu.Size = new System.Drawing.Size(202, 22);
            this.txtCuu.TabIndex = 1;
            this.txtCuu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuu_KeyPress);
            // 
            // txtDe
            // 
            this.txtDe.Location = new System.Drawing.Point(176, 129);
            this.txtDe.Name = "txtDe";
            this.txtDe.Size = new System.Drawing.Size(202, 22);
            this.txtDe.TabIndex = 1;
            this.txtDe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDe_KeyPress);
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(436, 42);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(130, 46);
            this.btnNhap.TabIndex = 2;
            this.btnNhap.Text = "Nhập";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtTiengKeu
            // 
            this.txtTiengKeu.Location = new System.Drawing.Point(604, 42);
            this.txtTiengKeu.Name = "txtTiengKeu";
            this.txtTiengKeu.Size = new System.Drawing.Size(124, 46);
            this.txtTiengKeu.TabIndex = 2;
            this.txtTiengKeu.Text = "Tiếng kêu";
            this.txtTiengKeu.UseVisualStyleBackColor = true;
            this.txtTiengKeu.Click += new System.EventHandler(this.txtTiengKeu_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(436, 114);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(130, 48);
            this.btnThongKe.TabIndex = 2;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // txtLamMoi
            // 
            this.txtLamMoi.Location = new System.Drawing.Point(604, 116);
            this.txtLamMoi.Name = "txtLamMoi";
            this.txtLamMoi.Size = new System.Drawing.Size(130, 48);
            this.txtLamMoi.TabIndex = 2;
            this.txtLamMoi.Text = "Làm mới";
            this.txtLamMoi.UseVisualStyleBackColor = true;
            this.txtLamMoi.Click += new System.EventHandler(this.txtLamMoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 528);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNameFarm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtNameFarm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button txtTiengKeu;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtDe;
        private System.Windows.Forms.TextBox txtCuu;
        private System.Windows.Forms.TextBox txtBo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtLamMoi;
    }
}

