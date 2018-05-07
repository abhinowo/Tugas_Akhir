namespace Tugas_Akhir
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dgvCS14 = new System.Windows.Forms.DataGridView();
            this.minatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.minatDataSet1 = new Tugas_Akhir.minatDataSet1();
            this.minatTableAdapter = new Tugas_Akhir.minatDataSet1TableAdapters.minatTableAdapter();
            this.textNim = new System.Windows.Forms.TextBox();
            this.textNama = new System.Windows.Forms.TextBox();
            this.textTLahir = new System.Windows.Forms.TextBox();
            this.textAD = new System.Windows.Forms.TextBox();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboJK = new System.Windows.Forms.ComboBox();
            this.nIMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TLahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisKelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.asalDaerahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCS14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minatDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(386, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "INPUT DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(764, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 44);
            this.button2.TabIndex = 1;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(764, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 44);
            this.button3.TabIndex = 2;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(762, 248);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 44);
            this.button4.TabIndex = 3;
            this.button4.Text = "EDIT";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(911, 183);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(151, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "SEARCH";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(911, 250);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(151, 40);
            this.button6.TabIndex = 5;
            this.button6.Text = "REFRESH";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dgvCS14
            // 
            this.dgvCS14.AutoGenerateColumns = false;
            this.dgvCS14.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCS14.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIMDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.TLahirDataGridViewTextBoxColumn,
            this.jenisKelaminDataGridViewTextBoxColumn,
            this.asalDaerahDataGridViewTextBoxColumn});
            this.dgvCS14.DataSource = this.minatBindingSource;
            this.dgvCS14.Location = new System.Drawing.Point(52, 360);
            this.dgvCS14.Name = "dgvCS14";
            this.dgvCS14.RowTemplate.Height = 24;
            this.dgvCS14.Size = new System.Drawing.Size(972, 319);
            this.dgvCS14.TabIndex = 6;
            this.dgvCS14.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // minatBindingSource
            // 
            this.minatBindingSource.DataMember = "minat";
            this.minatBindingSource.DataSource = this.minatDataSet1;
            // 
            // minatDataSet1
            // 
            this.minatDataSet1.DataSetName = "minatDataSet1";
            this.minatDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // minatTableAdapter
            // 
            this.minatTableAdapter.ClearBeforeFill = true;
            // 
            // textNim
            // 
            this.textNim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNim.Location = new System.Drawing.Point(145, 112);
            this.textNim.Multiline = true;
            this.textNim.Name = "textNim";
            this.textNim.Size = new System.Drawing.Size(196, 42);
            this.textNim.TabIndex = 8;
            this.textNim.TextChanged += new System.EventHandler(this.textNim_TextChanged);
            // 
            // textNama
            // 
            this.textNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNama.Location = new System.Drawing.Point(145, 183);
            this.textNama.Multiline = true;
            this.textNama.Name = "textNama";
            this.textNama.Size = new System.Drawing.Size(196, 42);
            this.textNama.TabIndex = 9;
            // 
            // textTLahir
            // 
            this.textTLahir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTLahir.Location = new System.Drawing.Point(145, 250);
            this.textTLahir.Multiline = true;
            this.textTLahir.Name = "textTLahir";
            this.textTLahir.Size = new System.Drawing.Size(196, 42);
            this.textTLahir.TabIndex = 10;
            this.textTLahir.TextChanged += new System.EventHandler(this.textTLahir_TextChanged);
            // 
            // textAD
            // 
            this.textAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAD.Location = new System.Drawing.Point(550, 182);
            this.textAD.Multiline = true;
            this.textAD.Name = "textAD";
            this.textAD.Size = new System.Drawing.Size(197, 42);
            this.textAD.TabIndex = 11;
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(909, 113);
            this.textSearch.Multiline = true;
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(158, 41);
            this.textSearch.TabIndex = 12;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 13;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboJK
            // 
            this.comboJK.FormattingEnabled = true;
            this.comboJK.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.comboJK.Location = new System.Drawing.Point(550, 123);
            this.comboJK.Name = "comboJK";
            this.comboJK.Size = new System.Drawing.Size(195, 24);
            this.comboJK.TabIndex = 14;
            this.comboJK.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // nIMDataGridViewTextBoxColumn
            // 
            this.nIMDataGridViewTextBoxColumn.DataPropertyName = "NIM";
            this.nIMDataGridViewTextBoxColumn.HeaderText = "NIM";
            this.nIMDataGridViewTextBoxColumn.Name = "nIMDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // TLahirDataGridViewTextBoxColumn
            // 
            this.TLahirDataGridViewTextBoxColumn.DataPropertyName = "TLahir";
            this.TLahirDataGridViewTextBoxColumn.HeaderText = "Tanggal Lahir";
            this.TLahirDataGridViewTextBoxColumn.Name = "TLahirDataGridViewTextBoxColumn";
            // 
            // jenisKelaminDataGridViewTextBoxColumn
            // 
            this.jenisKelaminDataGridViewTextBoxColumn.DataPropertyName = "Jenis Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.HeaderText = "Jenis Kelamin";
            this.jenisKelaminDataGridViewTextBoxColumn.Name = "jenisKelaminDataGridViewTextBoxColumn";
            // 
            // asalDaerahDataGridViewTextBoxColumn
            // 
            this.asalDaerahDataGridViewTextBoxColumn.DataPropertyName = "Asal Daerah";
            this.asalDaerahDataGridViewTextBoxColumn.HeaderText = "Asal Daerah";
            this.asalDaerahDataGridViewTextBoxColumn.Name = "asalDaerahDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1081, 719);
            this.Controls.Add(this.comboJK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.textAD);
            this.Controls.Add(this.textTLahir);
            this.Controls.Add(this.textNama);
            this.Controls.Add(this.textNim);
            this.Controls.Add(this.dgvCS14);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCS14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minatDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dgvCS14;
        private minatDataSet1 minatDataSet1;
        private System.Windows.Forms.BindingSource minatBindingSource;
        private minatDataSet1TableAdapters.minatTableAdapter minatTableAdapter;
        private System.Windows.Forms.TextBox textNim;
        private System.Windows.Forms.TextBox textNama;
        private System.Windows.Forms.TextBox textTLahir;
        private System.Windows.Forms.TextBox textAD;
        private System.Windows.Forms.TextBox textSearch;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboJK;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TLahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisKelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn asalDaerahDataGridViewTextBoxColumn;
    }
}

