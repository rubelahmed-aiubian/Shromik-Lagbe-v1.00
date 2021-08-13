
namespace Shromik_Lagbe_v1._00
{
    partial class frmsearchworker
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlsearchmain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewworker = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btndeleteworker = new System.Windows.Forms.Button();
            this.btnupdateworker = new System.Windows.Forms.Button();
            this.btnaddworker = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlsearchmain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewworker)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlsearchmain
            // 
            this.pnlsearchmain.Controls.Add(this.panel1);
            this.pnlsearchmain.Controls.Add(this.comboBox2);
            this.pnlsearchmain.Controls.Add(this.btndeleteworker);
            this.pnlsearchmain.Controls.Add(this.btnupdateworker);
            this.pnlsearchmain.Controls.Add(this.btnaddworker);
            this.pnlsearchmain.Controls.Add(this.searchbox);
            this.pnlsearchmain.Controls.Add(this.comboBox1);
            this.pnlsearchmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlsearchmain.Location = new System.Drawing.Point(0, 0);
            this.pnlsearchmain.Name = "pnlsearchmain";
            this.pnlsearchmain.Size = new System.Drawing.Size(994, 516);
            this.pnlsearchmain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.dataGridViewworker);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 413);
            this.panel1.TabIndex = 30;
            // 
            // dataGridViewworker
            // 
            this.dataGridViewworker.AllowUserToAddRows = false;
            this.dataGridViewworker.AllowUserToDeleteRows = false;
            this.dataGridViewworker.AllowUserToOrderColumns = true;
            this.dataGridViewworker.AllowUserToResizeColumns = false;
            this.dataGridViewworker.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridViewworker.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewworker.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.dataGridViewworker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewworker.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewworker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewworker.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewworker.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.dataGridViewworker.Location = new System.Drawing.Point(11, 10);
            this.dataGridViewworker.MultiSelect = false;
            this.dataGridViewworker.Name = "dataGridViewworker";
            this.dataGridViewworker.ReadOnly = true;
            this.dataGridViewworker.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewworker.Size = new System.Drawing.Size(948, 391);
            this.dataGridViewworker.TabIndex = 28;
            this.dataGridViewworker.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewworker_CellClick);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Occupation",
            "House Worker",
            "Electritian",
            "Technician",
            "Driver",
            "Cleaner"});
            this.comboBox2.Location = new System.Drawing.Point(383, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 28;
            this.comboBox2.Text = "Occupation";
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // btndeleteworker
            // 
            this.btndeleteworker.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btndeleteworker.FlatAppearance.BorderSize = 0;
            this.btndeleteworker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btndeleteworker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btndeleteworker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteworker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteworker.ForeColor = System.Drawing.Color.White;
            this.btndeleteworker.Location = new System.Drawing.Point(555, 470);
            this.btndeleteworker.Name = "btndeleteworker";
            this.btndeleteworker.Size = new System.Drawing.Size(110, 34);
            this.btndeleteworker.TabIndex = 26;
            this.btndeleteworker.Text = "DELETE";
            this.btndeleteworker.UseVisualStyleBackColor = false;
            this.btndeleteworker.Click += new System.EventHandler(this.btndeleteworker_Click);
            // 
            // btnupdateworker
            // 
            this.btnupdateworker.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnupdateworker.FlatAppearance.BorderSize = 0;
            this.btnupdateworker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnupdateworker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnupdateworker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateworker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateworker.ForeColor = System.Drawing.Color.White;
            this.btnupdateworker.Location = new System.Drawing.Point(405, 470);
            this.btnupdateworker.Name = "btnupdateworker";
            this.btnupdateworker.Size = new System.Drawing.Size(110, 34);
            this.btnupdateworker.TabIndex = 25;
            this.btnupdateworker.Text = "UPDATE";
            this.btnupdateworker.UseVisualStyleBackColor = false;
            this.btnupdateworker.Click += new System.EventHandler(this.btnupdateworker_Click);
            // 
            // btnaddworker
            // 
            this.btnaddworker.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnaddworker.FlatAppearance.BorderSize = 0;
            this.btnaddworker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnaddworker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnaddworker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddworker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddworker.ForeColor = System.Drawing.Color.White;
            this.btnaddworker.Location = new System.Drawing.Point(256, 470);
            this.btnaddworker.Name = "btnaddworker";
            this.btnaddworker.Size = new System.Drawing.Size(110, 34);
            this.btnaddworker.TabIndex = 24;
            this.btnaddworker.Text = "ADD WORKER";
            this.btnaddworker.UseVisualStyleBackColor = false;
            this.btnaddworker.Click += new System.EventHandler(this.btnaddworker_Click);
            // 
            // searchbox
            // 
            this.searchbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.searchbox.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.searchbox.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbox.ForeColor = System.Drawing.Color.White;
            this.searchbox.Location = new System.Drawing.Point(539, 10);
            this.searchbox.Name = "searchbox";
            this.searchbox.Size = new System.Drawing.Size(153, 23);
            this.searchbox.TabIndex = 23;
            this.searchbox.Text = "Enter Worker Name";
            this.searchbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchbox.TextChanged += new System.EventHandler(this.searchbox_TextChanged);
            this.searchbox.Enter += new System.EventHandler(this.searchbox_Enter);
            this.searchbox.Leave += new System.EventHandler(this.searchbox_Leave);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All Area",
            "Nikunja 1",
            "Nikunja 2",
            "Bashundhara",
            "Khilkhet"});
            this.comboBox1.Location = new System.Drawing.Point(230, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.Text = "All Area";
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // frmsearchworker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(994, 516);
            this.Controls.Add(this.pnlsearchmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmsearchworker";
            this.Text = "frmsearchworker";
            this.pnlsearchmain.ResumeLayout(false);
            this.pnlsearchmain.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewworker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlsearchmain;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btndeleteworker;
        private System.Windows.Forms.Button btnupdateworker;
        private System.Windows.Forms.Button btnaddworker;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewworker;
    }
}