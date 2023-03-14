
namespace kasir
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
            this.KodeBarang = new System.Windows.Forms.Label();
            this.tbKodeBarang = new System.Windows.Forms.TextBox();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.NamaBarang = new System.Windows.Forms.Label();
            this.tbHargaBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbJmlBarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnTampil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // KodeBarang
            // 
            this.KodeBarang.AutoSize = true;
            this.KodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KodeBarang.Location = new System.Drawing.Point(45, 71);
            this.KodeBarang.Name = "KodeBarang";
            this.KodeBarang.Size = new System.Drawing.Size(127, 25);
            this.KodeBarang.TabIndex = 0;
            this.KodeBarang.Text = "Kode Barang";
            // 
            // tbKodeBarang
            // 
            this.tbKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbKodeBarang.Location = new System.Drawing.Point(50, 108);
            this.tbKodeBarang.Name = "tbKodeBarang";
            this.tbKodeBarang.Size = new System.Drawing.Size(200, 35);
            this.tbKodeBarang.TabIndex = 1;
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNamaBarang.Location = new System.Drawing.Point(50, 204);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(200, 35);
            this.tbNamaBarang.TabIndex = 3;
            // 
            // NamaBarang
            // 
            this.NamaBarang.AutoSize = true;
            this.NamaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamaBarang.Location = new System.Drawing.Point(45, 167);
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.Size = new System.Drawing.Size(132, 25);
            this.NamaBarang.TabIndex = 2;
            this.NamaBarang.Text = "Nama Barang";
            // 
            // tbHargaBarang
            // 
            this.tbHargaBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHargaBarang.Location = new System.Drawing.Point(50, 322);
            this.tbHargaBarang.Name = "tbHargaBarang";
            this.tbHargaBarang.Size = new System.Drawing.Size(200, 35);
            this.tbHargaBarang.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Harga Barang";
            // 
            // tbJmlBarang
            // 
            this.tbJmlBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbJmlBarang.Location = new System.Drawing.Point(50, 419);
            this.tbJmlBarang.Name = "tbJmlBarang";
            this.tbJmlBarang.Size = new System.Drawing.Size(200, 35);
            this.tbJmlBarang.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Jumlah Barang";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(314, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(699, 257);
            this.dataGridView1.TabIndex = 10;
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Location = new System.Drawing.Point(314, 340);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(310, 48);
            this.btnTambah.TabIndex = 11;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.Red;
            this.btnHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.Color.White;
            this.btnHapus.Location = new System.Drawing.Point(314, 413);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(310, 48);
            this.btnHapus.TabIndex = 12;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gold;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(703, 340);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(310, 48);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnTampil
            // 
            this.btnTampil.BackColor = System.Drawing.Color.ForestGreen;
            this.btnTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampil.ForeColor = System.Drawing.Color.White;
            this.btnTampil.Location = new System.Drawing.Point(703, 413);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(310, 48);
            this.btnTampil.TabIndex = 14;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = false;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 496);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tbJmlBarang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbHargaBarang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNamaBarang);
            this.Controls.Add(this.NamaBarang);
            this.Controls.Add(this.tbKodeBarang);
            this.Controls.Add(this.KodeBarang);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KodeBarang;
        private System.Windows.Forms.TextBox tbKodeBarang;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.Label NamaBarang;
        private System.Windows.Forms.TextBox tbHargaBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbJmlBarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnTampil;
    }
}

