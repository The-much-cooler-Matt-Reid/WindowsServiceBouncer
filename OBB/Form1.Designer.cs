namespace OBB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bFilterSearch = new System.Windows.Forms.Button();
            this.bRefreshDGV1 = new System.Windows.Forms.Button();
            this.bStart_IIS = new System.Windows.Forms.Button();
            this.bStop_IIS = new System.Windows.Forms.Button();
            this.bStart_Service = new System.Windows.Forms.Button();
            this.bStop_Service = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.bRefreshDGV1);
            this.panel1.Controls.Add(this.bStart_IIS);
            this.panel1.Controls.Add(this.bStop_IIS);
            this.panel1.Controls.Add(this.bStart_Service);
            this.panel1.Controls.Add(this.bStop_Service);
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(-3, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 177);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.bFilterSearch);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 397);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(768, 350);
            this.dataGridView1.TabIndex = 8;
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(5, 11);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(450, 15);
            this.tbSearch.TabIndex = 1;
            this.tbSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bFilterSearch
            // 
            this.bFilterSearch.BackColor = System.Drawing.Color.Black;
            this.bFilterSearch.BackgroundImage = global::OBB.Properties.Resources.BlueBlackGradient800x600;
            this.bFilterSearch.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bFilterSearch.FlatAppearance.BorderSize = 0;
            this.bFilterSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFilterSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFilterSearch.ForeColor = System.Drawing.Color.White;
            this.bFilterSearch.Location = new System.Drawing.Point(461, 8);
            this.bFilterSearch.Name = "bFilterSearch";
            this.bFilterSearch.Size = new System.Drawing.Size(105, 22);
            this.bFilterSearch.TabIndex = 2;
            this.bFilterSearch.Text = "Search";
            this.bFilterSearch.UseVisualStyleBackColor = false;
            this.bFilterSearch.Click += new System.EventHandler(this.bFilterSearch_Click);
            // 
            // bRefreshDGV1
            // 
            this.bRefreshDGV1.BackColor = System.Drawing.Color.Black;
            this.bRefreshDGV1.BackgroundImage = global::OBB.Properties.Resources.BlueBlackGradient800x600;
            this.bRefreshDGV1.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bRefreshDGV1.FlatAppearance.BorderSize = 0;
            this.bRefreshDGV1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRefreshDGV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRefreshDGV1.ForeColor = System.Drawing.Color.White;
            this.bRefreshDGV1.Location = new System.Drawing.Point(339, 3);
            this.bRefreshDGV1.Name = "bRefreshDGV1";
            this.bRefreshDGV1.Size = new System.Drawing.Size(105, 78);
            this.bRefreshDGV1.TabIndex = 4;
            this.bRefreshDGV1.Text = "Refresh";
            this.bRefreshDGV1.UseVisualStyleBackColor = false;
            this.bRefreshDGV1.Click += new System.EventHandler(this.bRefreshDGV1_Click);
            // 
            // bStart_IIS
            // 
            this.bStart_IIS.BackColor = System.Drawing.Color.Black;
            this.bStart_IIS.BackgroundImage = global::OBB.Properties.Resources.BlueBlackGradient800x600;
            this.bStart_IIS.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bStart_IIS.FlatAppearance.BorderSize = 0;
            this.bStart_IIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart_IIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart_IIS.ForeColor = System.Drawing.Color.White;
            this.bStart_IIS.Location = new System.Drawing.Point(473, 87);
            this.bStart_IIS.Name = "bStart_IIS";
            this.bStart_IIS.Size = new System.Drawing.Size(313, 87);
            this.bStart_IIS.TabIndex = 7;
            this.bStart_IIS.Text = "Start IIS";
            this.bStart_IIS.UseVisualStyleBackColor = false;
            this.bStart_IIS.Click += new System.EventHandler(this.bStart_IIS_Click);
            // 
            // bStop_IIS
            // 
            this.bStop_IIS.BackColor = System.Drawing.Color.Black;
            this.bStop_IIS.BackgroundImage = global::OBB.Properties.Resources.BlueBlackGradient800x600;
            this.bStop_IIS.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bStop_IIS.FlatAppearance.BorderSize = 0;
            this.bStop_IIS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStop_IIS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStop_IIS.ForeColor = System.Drawing.Color.White;
            this.bStop_IIS.Location = new System.Drawing.Point(20, 87);
            this.bStop_IIS.Name = "bStop_IIS";
            this.bStop_IIS.Size = new System.Drawing.Size(280, 87);
            this.bStop_IIS.TabIndex = 6;
            this.bStop_IIS.Text = "Stop IIS";
            this.bStop_IIS.UseVisualStyleBackColor = false;
            this.bStop_IIS.Click += new System.EventHandler(this.bStop_IIS_Click);
            // 
            // bStart_Service
            // 
            this.bStart_Service.BackColor = System.Drawing.Color.Black;
            this.bStart_Service.BackgroundImage = global::OBB.Properties.Resources.BlueBlackGradient800x600;
            this.bStart_Service.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bStart_Service.FlatAppearance.BorderSize = 0;
            this.bStart_Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStart_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart_Service.ForeColor = System.Drawing.Color.White;
            this.bStart_Service.Location = new System.Drawing.Point(473, 3);
            this.bStart_Service.Name = "bStart_Service";
            this.bStart_Service.Size = new System.Drawing.Size(314, 78);
            this.bStart_Service.TabIndex = 5;
            this.bStart_Service.Text = "Start Service(s)";
            this.bStart_Service.UseVisualStyleBackColor = false;
            this.bStart_Service.Click += new System.EventHandler(this.bStart_Service_Click);
            // 
            // bStop_Service
            // 
            this.bStop_Service.BackColor = System.Drawing.Color.Black;
            this.bStop_Service.BackgroundImage = global::OBB.Properties.Resources.BlueBlackGradient800x600;
            this.bStop_Service.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.bStop_Service.FlatAppearance.BorderSize = 0;
            this.bStop_Service.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bStop_Service.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStop_Service.ForeColor = System.Drawing.Color.White;
            this.bStop_Service.Location = new System.Drawing.Point(20, 3);
            this.bStop_Service.Name = "bStop_Service";
            this.bStop_Service.Size = new System.Drawing.Size(280, 78);
            this.bStop_Service.TabIndex = 3;
            this.bStop_Service.Text = " Stop Service(s)";
            this.bStop_Service.UseMnemonic = false;
            this.bStop_Service.UseVisualStyleBackColor = false;
            this.bStop_Service.Click += new System.EventHandler(this.bStop_Service_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(805, 611);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.Name = "Form1";
            this.Text = "Service Bouncer";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bStop_Service;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bStart_IIS;
        private System.Windows.Forms.Button bStop_IIS;
        private System.Windows.Forms.Button bStart_Service;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bRefreshDGV1;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button bFilterSearch;
    }
}

