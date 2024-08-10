namespace EFDBFirst
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
            this.btnGet3TopExpensive = new System.Windows.Forms.Button();
            this.btn10TopCheap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetFourthExpensive = new System.Windows.Forms.Button();
            this.btnTotalProduct = new System.Windows.Forms.Button();
            this.gbPagination = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGet3TopExpensive
            // 
            this.btnGet3TopExpensive.Location = new System.Drawing.Point(12, 70);
            this.btnGet3TopExpensive.Name = "btnGet3TopExpensive";
            this.btnGet3TopExpensive.Size = new System.Drawing.Size(212, 39);
            this.btnGet3TopExpensive.TabIndex = 0;
            this.btnGet3TopExpensive.Text = "سه محصول گران";
            this.btnGet3TopExpensive.UseVisualStyleBackColor = true;
            this.btnGet3TopExpensive.Click += new System.EventHandler(this.btnGet3TopExpensive_Click);
            // 
            // btn10TopCheap
            // 
            this.btn10TopCheap.Location = new System.Drawing.Point(12, 125);
            this.btn10TopCheap.Name = "btn10TopCheap";
            this.btn10TopCheap.Size = new System.Drawing.Size(212, 39);
            this.btn10TopCheap.TabIndex = 1;
            this.btn10TopCheap.Text = "ده محصول ارزان";
            this.btn10TopCheap.UseVisualStyleBackColor = true;
            this.btn10TopCheap.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Result :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(288, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 184);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnGetFourthExpensive
            // 
            this.btnGetFourthExpensive.Location = new System.Drawing.Point(12, 170);
            this.btnGetFourthExpensive.Name = "btnGetFourthExpensive";
            this.btnGetFourthExpensive.Size = new System.Drawing.Size(212, 39);
            this.btnGetFourthExpensive.TabIndex = 4;
            this.btnGetFourthExpensive.Text = "چهارمین محصول گران";
            this.btnGetFourthExpensive.UseVisualStyleBackColor = true;
            this.btnGetFourthExpensive.Click += new System.EventHandler(this.btnGetFourthExpensive_Click);
            // 
            // btnTotalProduct
            // 
            this.btnTotalProduct.Location = new System.Drawing.Point(12, 25);
            this.btnTotalProduct.Name = "btnTotalProduct";
            this.btnTotalProduct.Size = new System.Drawing.Size(212, 39);
            this.btnTotalProduct.TabIndex = 5;
            this.btnTotalProduct.Text = "کل محصولات";
            this.btnTotalProduct.UseVisualStyleBackColor = true;
            this.btnTotalProduct.Click += new System.EventHandler(this.btnTotalProduct_Click);
            // 
            // gbPagination
            // 
            this.gbPagination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.gbPagination.Location = new System.Drawing.Point(288, 215);
            this.gbPagination.Name = "gbPagination";
            this.gbPagination.Size = new System.Drawing.Size(730, 69);
            this.gbPagination.TabIndex = 6;
            this.gbPagination.TabStop = false;
            this.gbPagination.Text = "Pagination";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.gbPagination);
            this.Controls.Add(this.btnTotalProduct);
            this.Controls.Add(this.btnGetFourthExpensive);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn10TopCheap);
            this.Controls.Add(this.btnGet3TopExpensive);
            this.Name = "Form1";
            this.Text = "EFDbFirst";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGet3TopExpensive;
        private System.Windows.Forms.Button btn10TopCheap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGetFourthExpensive;
        private System.Windows.Forms.Button btnTotalProduct;
        private System.Windows.Forms.GroupBox gbPagination;
    }
}

