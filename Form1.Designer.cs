namespace CheltuieliApp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gazeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abonament_Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Utilitati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abonament_autobuz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timpLiberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alteCheltuieliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cheltuieliBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new CheltuieliApp.DataSet1();
            this.cheltuieliTableAdapter = new CheltuieliApp.DataSet1TableAdapters.CheltuieliTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.cheltuieliBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnActualizare = new System.Windows.Forms.Button();
            this.BtnSalvare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.gazeDataGridViewTextBoxColumn,
            this.Abonament_Telefon,
            this.Utilitati,
            this.TV,
            this.Abonament_autobuz,
            this.timpLiberDataGridViewTextBoxColumn,
            this.alteCheltuieliDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cheltuieliBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1051, 228);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.MinimumWidth = 6;
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            this.Data.Width = 125;
            // 
            // gazeDataGridViewTextBoxColumn
            // 
            this.gazeDataGridViewTextBoxColumn.DataPropertyName = "Gaze";
            this.gazeDataGridViewTextBoxColumn.HeaderText = "Gaze";
            this.gazeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gazeDataGridViewTextBoxColumn.Name = "gazeDataGridViewTextBoxColumn";
            this.gazeDataGridViewTextBoxColumn.Width = 125;
            // 
            // Abonament_Telefon
            // 
            this.Abonament_Telefon.DataPropertyName = "Abonament_Telefon";
            this.Abonament_Telefon.HeaderText = "Abonament_Telefon";
            this.Abonament_Telefon.MinimumWidth = 6;
            this.Abonament_Telefon.Name = "Abonament_Telefon";
            this.Abonament_Telefon.Width = 125;
            // 
            // Utilitati
            // 
            this.Utilitati.DataPropertyName = "Utilitati";
            this.Utilitati.HeaderText = "Utilitati";
            this.Utilitati.MinimumWidth = 6;
            this.Utilitati.Name = "Utilitati";
            this.Utilitati.Width = 125;
            // 
            // TV
            // 
            this.TV.DataPropertyName = "TV";
            this.TV.HeaderText = "TV";
            this.TV.MinimumWidth = 6;
            this.TV.Name = "TV";
            this.TV.Width = 125;
            // 
            // Abonament_autobuz
            // 
            this.Abonament_autobuz.DataPropertyName = "Abonament_autobuz";
            this.Abonament_autobuz.HeaderText = "Abonament_autobuz";
            this.Abonament_autobuz.MinimumWidth = 6;
            this.Abonament_autobuz.Name = "Abonament_autobuz";
            this.Abonament_autobuz.Width = 125;
            // 
            // timpLiberDataGridViewTextBoxColumn
            // 
            this.timpLiberDataGridViewTextBoxColumn.DataPropertyName = "Timp_Liber";
            this.timpLiberDataGridViewTextBoxColumn.HeaderText = "Timp_Liber";
            this.timpLiberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timpLiberDataGridViewTextBoxColumn.Name = "timpLiberDataGridViewTextBoxColumn";
            this.timpLiberDataGridViewTextBoxColumn.Width = 125;
            // 
            // alteCheltuieliDataGridViewTextBoxColumn
            // 
            this.alteCheltuieliDataGridViewTextBoxColumn.DataPropertyName = "Alte_Cheltuieli";
            this.alteCheltuieliDataGridViewTextBoxColumn.HeaderText = "Alte_Cheltuieli";
            this.alteCheltuieliDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alteCheltuieliDataGridViewTextBoxColumn.Name = "alteCheltuieliDataGridViewTextBoxColumn";
            this.alteCheltuieliDataGridViewTextBoxColumn.Width = 125;
            // 
            // cheltuieliBindingSource
            // 
            this.cheltuieliBindingSource.DataMember = "Cheltuieli";
            this.cheltuieliBindingSource.DataSource = this.dataSet1;
            this.cheltuieliBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.cheltuieliBindingSource_AddingNew);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cheltuieliTableAdapter
            // 
            this.cheltuieliTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(923, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.cheltuieliBindingSource;
            this.listBox1.DisplayMember = "Data";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 336);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(113, 132);
            this.listBox1.TabIndex = 3;
            this.listBox1.ValueMember = "ID_cheltuieli";
            // 
            // cheltuieliBindingSource1
            // 
            this.cheltuieliBindingSource1.DataMember = "Cheltuieli";
            this.cheltuieliBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cauta Dupa Data";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(441, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cheltuieli";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(923, 512);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(923, 297);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(141, 33);
            this.btnActualizare.TabIndex = 10;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnSalvare
            // 
            this.BtnSalvare.Location = new System.Drawing.Point(923, 352);
            this.BtnSalvare.Name = "BtnSalvare";
            this.BtnSalvare.Size = new System.Drawing.Size(141, 37);
            this.BtnSalvare.TabIndex = 12;
            this.BtnSalvare.Text = "Salvare";
            this.BtnSalvare.UseVisualStyleBackColor = true;
            this.BtnSalvare.Click += new System.EventHandler(this.BtnSalvare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(923, 406);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(141, 36);
            this.btnRenuntare.TabIndex = 13;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 578);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.BtnSalvare);
            this.Controls.Add(this.btnActualizare);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "CheltuieliApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cheltuieliBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cheltuieliBindingSource;
        private DataSet1TableAdapters.CheltuieliTableAdapter cheltuieliTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource cheltuieliBindingSource1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn gazeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abonament_Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Utilitati;
        private System.Windows.Forms.DataGridViewTextBoxColumn TV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abonament_autobuz;
        private System.Windows.Forms.DataGridViewTextBoxColumn timpLiberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alteCheltuieliDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button BtnSalvare;
        private System.Windows.Forms.Button btnRenuntare;
    }
}

