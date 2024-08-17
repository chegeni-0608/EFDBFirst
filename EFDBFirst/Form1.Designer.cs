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
            this.btnInsertWithGenericRepository = new System.Windows.Forms.Button();
            this.btnGetTop10 = new System.Windows.Forms.Button();
            this.btnEployeeListBirthDate1964To1999 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            // btnInsertWithGenericRepository
            // 
            this.btnInsertWithGenericRepository.Location = new System.Drawing.Point(12, 226);
            this.btnInsertWithGenericRepository.Name = "btnInsertWithGenericRepository";
            this.btnInsertWithGenericRepository.Size = new System.Drawing.Size(212, 39);
            this.btnInsertWithGenericRepository.TabIndex = 7;
            this.btnInsertWithGenericRepository.Text = "Insert With Generic Repository";
            this.btnInsertWithGenericRepository.UseVisualStyleBackColor = true;
            this.btnInsertWithGenericRepository.Click += new System.EventHandler(this.btnInsertWithGenericRepository_Click);
            // 
            // btnGetTop10
            // 
            this.btnGetTop10.Location = new System.Drawing.Point(12, 271);
            this.btnGetTop10.Name = "btnGetTop10";
            this.btnGetTop10.Size = new System.Drawing.Size(212, 39);
            this.btnGetTop10.TabIndex = 8;
            this.btnGetTop10.Text = "Get Top 10 Cheap without Category =1";
            this.btnGetTop10.UseVisualStyleBackColor = true;
            this.btnGetTop10.Click += new System.EventHandler(this.btnGetTop10_Click);
            // 
            // btnEployeeListBirthDate1964To1999
            // 
            this.btnEployeeListBirthDate1964To1999.Location = new System.Drawing.Point(12, 332);
            this.btnEployeeListBirthDate1964To1999.Name = "btnEployeeListBirthDate1964To1999";
            this.btnEployeeListBirthDate1964To1999.Size = new System.Drawing.Size(212, 39);
            this.btnEployeeListBirthDate1964To1999.TabIndex = 9;
            this.btnEployeeListBirthDate1964To1999.Text = "لیست کارمندان  از سال 1964 تا 1999";
            this.btnEployeeListBirthDate1964To1999.UseVisualStyleBackColor = true;
            this.btnEployeeListBirthDate1964To1999.Click += new System.EventHandler(this.btnEployeeListBirthDate1964To1999_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Input:";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(340, 289);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(299, 20);
            this.txtInput.TabIndex = 11;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(645, 286);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 12;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(772, 333);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 15;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(340, 332);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(426, 20);
            this.txtOutput.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Output:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 450);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEployeeListBirthDate1964To1999);
            this.Controls.Add(this.btnGetTop10);
            this.Controls.Add(this.btnInsertWithGenericRepository);
            this.Controls.Add(this.gbPagination);
            this.Controls.Add(this.btnTotalProduct);
            this.Controls.Add(this.btnGetFourthExpensive);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn10TopCheap);
            this.Controls.Add(this.btnGet3TopExpensive);
            this.Name = "Form1";
            this.Text = "EFDbFirst";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnInsertWithGenericRepository;
        private System.Windows.Forms.Button btnGetTop10;
        private System.Windows.Forms.Button btnEployeeListBirthDate1964To1999;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label3;
    }
}

