namespace PW_Lab6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tytuł = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wydawnictwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miasto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rokwydania = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Statuswypozyczenia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tytuł,
            this.Autor,
            this.Wydawnictwo,
            this.Miasto,
            this.Rokwydania,
            this.Statuswypozyczenia,
            this.ID});
            this.dataGridView1.Location = new System.Drawing.Point(67, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1253, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // Tytuł
            // 
            this.Tytuł.HeaderText = "Tytuł";
            this.Tytuł.MinimumWidth = 6;
            this.Tytuł.Name = "Tytuł";
            // 
            // Autor
            // 
            this.Autor.HeaderText = "Autor";
            this.Autor.MinimumWidth = 6;
            this.Autor.Name = "Autor";
            // 
            // Wydawnictwo
            // 
            this.Wydawnictwo.HeaderText = "Wydawnictwo";
            this.Wydawnictwo.MinimumWidth = 6;
            this.Wydawnictwo.Name = "Wydawnictwo";
            // 
            // Miasto
            // 
            this.Miasto.HeaderText = "Miasto";
            this.Miasto.MinimumWidth = 6;
            this.Miasto.Name = "Miasto";
            // 
            // Rokwydania
            // 
            this.Rokwydania.HeaderText = "Rok wydania";
            this.Rokwydania.MinimumWidth = 6;
            this.Rokwydania.Name = "Rokwydania";
            // 
            // Statuswypozyczenia
            // 
            this.Statuswypozyczenia.HeaderText = "Status wypożyczenia";
            this.Statuswypozyczenia.MinimumWidth = 6;
            this.Statuswypozyczenia.Name = "Statuswypozyczenia";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(217, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 77);
            this.button1.TabIndex = 1;
            this.button1.Text = "Zapisz do CSV";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(839, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(247, 77);
            this.button2.TabIndex = 2;
            this.button2.Text = "UML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(1448, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 100);
            this.button3.TabIndex = 3;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1655, 511);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn Tytuł;
        private DataGridViewTextBoxColumn Autor;
        private DataGridViewTextBoxColumn Wydawnictwo;
        private DataGridViewTextBoxColumn Miasto;
        private DataGridViewTextBoxColumn Rokwydania;
        private DataGridViewTextBoxColumn Statuswypozyczenia;
        private DataGridViewTextBoxColumn ID;
        public DataGridView dataGridView1;
    }
}