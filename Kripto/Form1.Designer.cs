namespace Kripto
{
    partial class Kripto
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
            this.btn_start = new System.Windows.Forms.Button();
            this.lbl_text = new System.Windows.Forms.Label();
            this.dgw_matrix = new System.Windows.Forms.DataGridView();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.tb_keyword = new System.Windows.Forms.TextBox();
            this.lbl_keyword = new System.Windows.Forms.Label();
            this.lbl_crypted = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_key = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_matrix)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(1009, 122);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_ClickAsync);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Location = new System.Drawing.Point(856, 45);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(59, 17);
            this.lbl_text.TabIndex = 1;
            this.lbl_text.Text = "Szöveg:";
            // 
            // dgw_matrix
            // 
            this.dgw_matrix.AllowUserToAddRows = false;
            this.dgw_matrix.AllowUserToDeleteRows = false;
            this.dgw_matrix.AllowUserToResizeColumns = false;
            this.dgw_matrix.AllowUserToResizeRows = false;
            this.dgw_matrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgw_matrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_matrix.ColumnHeadersVisible = false;
            this.dgw_matrix.Location = new System.Drawing.Point(34, 46);
            this.dgw_matrix.Name = "dgw_matrix";
            this.dgw_matrix.ReadOnly = true;
            this.dgw_matrix.RowHeadersVisible = false;
            this.dgw_matrix.RowHeadersWidth = 51;
            this.dgw_matrix.RowTemplate.Height = 24;
            this.dgw_matrix.Size = new System.Drawing.Size(738, 709);
            this.dgw_matrix.TabIndex = 2;
            // 
            // tb_text
            // 
            this.tb_text.Location = new System.Drawing.Point(859, 65);
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(225, 22);
            this.tb_text.TabIndex = 3;
            // 
            // tb_keyword
            // 
            this.tb_keyword.Location = new System.Drawing.Point(859, 123);
            this.tb_keyword.Name = "tb_keyword";
            this.tb_keyword.Size = new System.Drawing.Size(100, 22);
            this.tb_keyword.TabIndex = 4;
            // 
            // lbl_keyword
            // 
            this.lbl_keyword.AutoSize = true;
            this.lbl_keyword.Location = new System.Drawing.Point(856, 103);
            this.lbl_keyword.Name = "lbl_keyword";
            this.lbl_keyword.Size = new System.Drawing.Size(72, 17);
            this.lbl_keyword.TabIndex = 5;
            this.lbl_keyword.Text = "Kulcs szó:";
            // 
            // lbl_crypted
            // 
            this.lbl_crypted.AutoSize = true;
            this.lbl_crypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_crypted.Location = new System.Drawing.Point(856, 727);
            this.lbl_crypted.Name = "lbl_crypted";
            this.lbl_crypted.Size = new System.Drawing.Size(0, 17);
            this.lbl_crypted.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(856, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Magyarázat:";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(856, 266);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(0, 17);
            this.lbl_description.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(856, 695);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Titkosított szöveg:";
            // 
            // lbl_key
            // 
            this.lbl_key.AutoSize = true;
            this.lbl_key.Location = new System.Drawing.Point(859, 163);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.Size = new System.Drawing.Size(0, 17);
            this.lbl_key.TabIndex = 10;
            // 
            // Kripto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 779);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_crypted);
            this.Controls.Add(this.lbl_keyword);
            this.Controls.Add(this.tb_keyword);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.dgw_matrix);
            this.Controls.Add(this.lbl_text);
            this.Controls.Add(this.btn_start);
            this.Name = "Kripto";
            this.Text = "Vigenére módszer";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_matrix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.DataGridView dgw_matrix;
        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.TextBox tb_keyword;
        private System.Windows.Forms.Label lbl_keyword;
        private System.Windows.Forms.Label lbl_crypted;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_key;
    }
}

