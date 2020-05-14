namespace WindowsFormsApp59
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.wysokoscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wiekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plecDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.zwierzeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pozywienieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kalorycznosc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zwierzeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozywienieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(953, 617);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 73);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.wysokoscDataGridViewTextBoxColumn,
            this.masaDataGridViewTextBoxColumn,
            this.kolorDataGridViewTextBoxColumn,
            this.wiekDataGridViewTextBoxColumn,
            this.nazwaDataGridViewTextBoxColumn,
            this.plecDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.zwierzeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(685, 264);
            this.dataGridView1.TabIndex = 2;
            // 
            // wysokoscDataGridViewTextBoxColumn
            // 
            this.wysokoscDataGridViewTextBoxColumn.DataPropertyName = "Wysokosc";
            this.wysokoscDataGridViewTextBoxColumn.HeaderText = "Wysokosc";
            this.wysokoscDataGridViewTextBoxColumn.Name = "wysokoscDataGridViewTextBoxColumn";
            // 
            // masaDataGridViewTextBoxColumn
            // 
            this.masaDataGridViewTextBoxColumn.DataPropertyName = "Masa";
            this.masaDataGridViewTextBoxColumn.HeaderText = "Masa";
            this.masaDataGridViewTextBoxColumn.Name = "masaDataGridViewTextBoxColumn";
            // 
            // kolorDataGridViewTextBoxColumn
            // 
            this.kolorDataGridViewTextBoxColumn.DataPropertyName = "Kolor";
            this.kolorDataGridViewTextBoxColumn.HeaderText = "Kolor";
            this.kolorDataGridViewTextBoxColumn.Name = "kolorDataGridViewTextBoxColumn";
            // 
            // wiekDataGridViewTextBoxColumn
            // 
            this.wiekDataGridViewTextBoxColumn.DataPropertyName = "Wiek";
            this.wiekDataGridViewTextBoxColumn.HeaderText = "Wiek";
            this.wiekDataGridViewTextBoxColumn.Name = "wiekDataGridViewTextBoxColumn";
            // 
            // nazwaDataGridViewTextBoxColumn
            // 
            this.nazwaDataGridViewTextBoxColumn.DataPropertyName = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.HeaderText = "Nazwa";
            this.nazwaDataGridViewTextBoxColumn.Name = "nazwaDataGridViewTextBoxColumn";
            // 
            // plecDataGridViewCheckBoxColumn
            // 
            this.plecDataGridViewCheckBoxColumn.DataPropertyName = "Plec";
            this.plecDataGridViewCheckBoxColumn.HeaderText = "Plec";
            this.plecDataGridViewCheckBoxColumn.Name = "plecDataGridViewCheckBoxColumn";
            // 
            // zwierzeBindingSource
            // 
            this.zwierzeBindingSource.DataSource = typeof(WindowsFormsApp59.Zwierze);
            this.zwierzeBindingSource.PositionChanged += new System.EventHandler(this.zwierzeBindingSource_PositionChanged);
            // 
            // pozywienieBindingSource
            // 
            this.pozywienieBindingSource.DataSource = typeof(WindowsFormsApp59.Pozywienie);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.Ilosc,
            this.Kalorycznosc});
            this.dataGridView2.DataSource = this.pozywienieBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(31, 345);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(685, 264);
            this.dataGridView2.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nazwa";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nazwa";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Ilosc
            // 
            this.Ilosc.DataPropertyName = "Ilosc";
            this.Ilosc.HeaderText = "Ilosc";
            this.Ilosc.Name = "Ilosc";
            // 
            // Kalorycznosc
            // 
            this.Kalorycznosc.DataPropertyName = "Kalorycznosc";
            this.Kalorycznosc.HeaderText = "Kalorycznosc";
            this.Kalorycznosc.Name = "Kalorycznosc";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 710);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zwierzeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pozywienieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource zwierzeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn wysokoscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn wiekDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn plecDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource pozywienieBindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kalorycznosc;
    }
}

