
namespace Shromik_Lagbe_v1._00
{
    partial class frmsearchclient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlsearchmain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btndeleteclient = new System.Windows.Forms.Button();
            this.btnupdateclient = new System.Windows.Forms.Button();
            this.btnaddclient = new System.Windows.Forms.Button();
            this.searchbox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlsearchmain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlsearchmain
            // 
            this.pnlsearchmain.Controls.Add(this.panel1);
            this.pnlsearchmain.Controls.Add(this.comboBox2);
            this.pnlsearchmain.Controls.Add(this.btndeleteclient);
            this.pnlsearchmain.Controls.Add(this.btnupdateclient);
            this.pnlsearchmain.Controls.Add(this.btnaddclient);
            this.pnlsearchmain.Controls.Add(this.searchbox);
            this.pnlsearchmain.Controls.Add(this.comboBox1);
            this.pnlsearchmain.Location = new System.Drawing.Point(0, 0);
            this.pnlsearchmain.Name = "pnlsearchmain";
            this.pnlsearchmain.Size = new System.Drawing.Size(994, 516);
            this.pnlsearchmain.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.panel1.Controls.Add(this.dataGridViewClient);
            this.panel1.Location = new System.Drawing.Point(12, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 413);
            this.panel1.TabIndex = 29;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.AllowUserToOrderColumns = true;
            this.dataGridViewClient.AllowUserToResizeColumns = false;
            this.dataGridViewClient.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            this.dataGridViewClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.dataGridViewClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewClient.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.dataGridViewClient.Location = new System.Drawing.Point(11, 10);
            this.dataGridViewClient.MultiSelect = false;
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClient.Size = new System.Drawing.Size(948, 391);
            this.dataGridViewClient.TabIndex = 28;
            this.dataGridViewClient.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewClient_CellClick);
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Worker Hired OR Not",
            "Yes",
            "No"});
            this.comboBox2.Location = new System.Drawing.Point(383, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 28;
            this.comboBox2.Text = "Worker Hired OR Not";
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // btndeleteclient
            // 
            this.btndeleteclient.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btndeleteclient.FlatAppearance.BorderSize = 0;
            this.btndeleteclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btndeleteclient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btndeleteclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteclient.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteclient.ForeColor = System.Drawing.Color.White;
            this.btndeleteclient.Location = new System.Drawing.Point(555, 470);
            this.btndeleteclient.Name = "btndeleteclient";
            this.btndeleteclient.Size = new System.Drawing.Size(110, 34);
            this.btndeleteclient.TabIndex = 26;
            this.btndeleteclient.Text = "DELETE";
            this.btndeleteclient.UseVisualStyleBackColor = false;
            this.btndeleteclient.Click += new System.EventHandler(this.btndeleteclient_Click);
            // 
            // btnupdateclient
            // 
            this.btnupdateclient.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnupdateclient.FlatAppearance.BorderSize = 0;
            this.btnupdateclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnupdateclient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnupdateclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateclient.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateclient.ForeColor = System.Drawing.Color.White;
            this.btnupdateclient.Location = new System.Drawing.Point(405, 470);
            this.btnupdateclient.Name = "btnupdateclient";
            this.btnupdateclient.Size = new System.Drawing.Size(110, 34);
            this.btnupdateclient.TabIndex = 25;
            this.btnupdateclient.Text = "UPDATE";
            this.btnupdateclient.UseVisualStyleBackColor = false;
            this.btnupdateclient.Click += new System.EventHandler(this.btnupdateclient_Click);
            // 
            // btnaddclient
            // 
            this.btnaddclient.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnaddclient.FlatAppearance.BorderSize = 0;
            this.btnaddclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnaddclient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnaddclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddclient.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddclient.ForeColor = System.Drawing.Color.White;
            this.btnaddclient.Location = new System.Drawing.Point(256, 470);
            this.btnaddclient.Name = "btnaddclient";
            this.btnaddclient.Size = new System.Drawing.Size(110, 34);
            this.btnaddclient.TabIndex = 24;
            this.btnaddclient.Text = "ADD CLIENT";
            this.btnaddclient.UseVisualStyleBackColor = false;
            this.btnaddclient.Click += new System.EventHandler(this.btnaddclient_Click);
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
            this.searchbox.Text = "Enter Client Name";
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
            // frmsearchclient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(994, 516);
            this.Controls.Add(this.pnlsearchmain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmsearchclient";
            this.Text = "searchclient";
            this.pnlsearchmain.ResumeLayout(false);
            this.pnlsearchmain.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlsearchmain;
        private System.Windows.Forms.Button btndeleteclient;
        private System.Windows.Forms.Button btnupdateclient;
        private System.Windows.Forms.Button btnaddclient;
        private System.Windows.Forms.TextBox searchbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewClient;
    }
}