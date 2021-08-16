
namespace Shromik_Lagbe_v1._00
{
    partial class frmaddworker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmaddworker));
            this.label12 = new System.Windows.Forms.Label();
            this.pregender = new System.Windows.Forms.Label();
            this.prename = new System.Windows.Forms.Label();
            this.btnphoto = new System.Windows.Forms.Button();
            this.paymentstatus = new System.Windows.Forms.ComboBox();
            this.servicearea = new System.Windows.Forms.ComboBox();
            this.address = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.preservice = new System.Windows.Forms.Label();
            this.prephone = new System.Windows.Forms.Label();
            this.preocc = new System.Windows.Forms.Label();
            this.preworkerphoto = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.preadd = new System.Windows.Forms.Label();
            this.btnworkerback = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnpreview = new System.Windows.Forms.Button();
            this.l_name = new System.Windows.Forms.TextBox();
            this.pnlpreview = new System.Windows.Forms.Panel();
            this.prepayment = new System.Windows.Forms.Label();
            this.pnlmainpreview = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.f_name = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.pnlclientinformation = new System.Windows.Forms.Panel();
            this.occupation = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.preworkerphoto)).BeginInit();
            this.pnlpreview.SuspendLayout();
            this.pnlmainpreview.SuspendLayout();
            this.pnlclientinformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(78, 183);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Preview Will Be Load Here...";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pregender
            // 
            this.pregender.AutoSize = true;
            this.pregender.BackColor = System.Drawing.Color.Transparent;
            this.pregender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregender.ForeColor = System.Drawing.Color.White;
            this.pregender.Location = new System.Drawing.Point(48, 161);
            this.pregender.Name = "pregender";
            this.pregender.Size = new System.Drawing.Size(60, 19);
            this.pregender.TabIndex = 40;
            this.pregender.Text = "Gender:";
            // 
            // prename
            // 
            this.prename.AutoSize = true;
            this.prename.BackColor = System.Drawing.Color.Transparent;
            this.prename.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prename.ForeColor = System.Drawing.Color.White;
            this.prename.Location = new System.Drawing.Point(48, 126);
            this.prename.Name = "prename";
            this.prename.Size = new System.Drawing.Size(51, 19);
            this.prename.TabIndex = 39;
            this.prename.Text = "Name:";
            // 
            // btnphoto
            // 
            this.btnphoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.btnphoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnphoto.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnphoto.ForeColor = System.Drawing.Color.White;
            this.btnphoto.Location = new System.Drawing.Point(71, 343);
            this.btnphoto.Name = "btnphoto";
            this.btnphoto.Size = new System.Drawing.Size(118, 30);
            this.btnphoto.TabIndex = 17;
            this.btnphoto.Text = "Browse...";
            this.btnphoto.UseVisualStyleBackColor = false;
            this.btnphoto.Click += new System.EventHandler(this.btnphoto_Click);
            // 
            // paymentstatus
            // 
            this.paymentstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.paymentstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paymentstatus.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentstatus.ForeColor = System.Drawing.Color.White;
            this.paymentstatus.FormattingEnabled = true;
            this.paymentstatus.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.paymentstatus.Location = new System.Drawing.Point(308, 258);
            this.paymentstatus.Name = "paymentstatus";
            this.paymentstatus.Size = new System.Drawing.Size(200, 26);
            this.paymentstatus.TabIndex = 16;
            // 
            // servicearea
            // 
            this.servicearea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.servicearea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servicearea.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.servicearea.ForeColor = System.Drawing.Color.White;
            this.servicearea.FormattingEnabled = true;
            this.servicearea.Items.AddRange(new object[] {
            "Nikunja 1",
            "Nikunja 2",
            "Khilkhet",
            "Bashundhara"});
            this.servicearea.Location = new System.Drawing.Point(71, 258);
            this.servicearea.Name = "servicearea";
            this.servicearea.Size = new System.Drawing.Size(198, 26);
            this.servicearea.TabIndex = 15;
            // 
            // address
            // 
            this.address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.address.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.Color.White;
            this.address.Location = new System.Drawing.Point(308, 190);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(200, 24);
            this.address.TabIndex = 14;
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phone.ForeColor = System.Drawing.Color.White;
            this.phone.Location = new System.Drawing.Point(71, 190);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(198, 24);
            this.phone.TabIndex = 13;
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gender
            // 
            this.gender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gender.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.ForeColor = System.Drawing.Color.White;
            this.gender.FormattingEnabled = true;
            this.gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.gender.Location = new System.Drawing.Point(71, 121);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(198, 26);
            this.gender.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(67, 310);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "Upload A Photo:";
            // 
            // preservice
            // 
            this.preservice.AutoSize = true;
            this.preservice.BackColor = System.Drawing.Color.Transparent;
            this.preservice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preservice.ForeColor = System.Drawing.Color.White;
            this.preservice.Location = new System.Drawing.Point(48, 299);
            this.preservice.Name = "preservice";
            this.preservice.Size = new System.Drawing.Size(93, 19);
            this.preservice.TabIndex = 44;
            this.preservice.Text = "Service Area:";
            // 
            // prephone
            // 
            this.prephone.AutoSize = true;
            this.prephone.BackColor = System.Drawing.Color.Transparent;
            this.prephone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prephone.ForeColor = System.Drawing.Color.White;
            this.prephone.Location = new System.Drawing.Point(48, 232);
            this.prephone.Name = "prephone";
            this.prephone.Size = new System.Drawing.Size(53, 19);
            this.prephone.TabIndex = 42;
            this.prephone.Text = "Phone:";
            // 
            // preocc
            // 
            this.preocc.AutoSize = true;
            this.preocc.BackColor = System.Drawing.Color.Transparent;
            this.preocc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preocc.ForeColor = System.Drawing.Color.White;
            this.preocc.Location = new System.Drawing.Point(48, 196);
            this.preocc.Name = "preocc";
            this.preocc.Size = new System.Drawing.Size(87, 19);
            this.preocc.TabIndex = 41;
            this.preocc.Text = "Occupation:";
            // 
            // preworkerphoto
            // 
            this.preworkerphoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("preworkerphoto.ErrorImage")));
            this.preworkerphoto.Image = ((System.Drawing.Image)(resources.GetObject("preworkerphoto.Image")));
            this.preworkerphoto.Location = new System.Drawing.Point(131, 12);
            this.preworkerphoto.Name = "preworkerphoto";
            this.preworkerphoto.Size = new System.Drawing.Size(80, 80);
            this.preworkerphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.preworkerphoto.TabIndex = 38;
            this.preworkerphoto.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(304, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Paymnet Status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(67, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Service Area:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(304, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(67, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phone Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(67, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender:";
            // 
            // preadd
            // 
            this.preadd.AutoSize = true;
            this.preadd.BackColor = System.Drawing.Color.Transparent;
            this.preadd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preadd.ForeColor = System.Drawing.Color.White;
            this.preadd.Location = new System.Drawing.Point(48, 266);
            this.preadd.Name = "preadd";
            this.preadd.Size = new System.Drawing.Size(65, 19);
            this.preadd.TabIndex = 43;
            this.preadd.Text = "Address:";
            // 
            // btnworkerback
            // 
            this.btnworkerback.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnworkerback.FlatAppearance.BorderSize = 0;
            this.btnworkerback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnworkerback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnworkerback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnworkerback.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnworkerback.ForeColor = System.Drawing.Color.White;
            this.btnworkerback.Location = new System.Drawing.Point(390, 467);
            this.btnworkerback.Name = "btnworkerback";
            this.btnworkerback.Size = new System.Drawing.Size(99, 34);
            this.btnworkerback.TabIndex = 36;
            this.btnworkerback.Text = "BACK";
            this.btnworkerback.UseVisualStyleBackColor = false;
            this.btnworkerback.Click += new System.EventHandler(this.btnworkerback_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(771, 467);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(99, 34);
            this.btnsave.TabIndex = 35;
            this.btnsave.Text = "SAVE";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Visible = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(304, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Occupation:";
            // 
            // btnpreview
            // 
            this.btnpreview.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnpreview.FlatAppearance.BorderSize = 0;
            this.btnpreview.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnpreview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnpreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpreview.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpreview.ForeColor = System.Drawing.Color.White;
            this.btnpreview.Location = new System.Drawing.Point(245, 467);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(99, 34);
            this.btnpreview.TabIndex = 38;
            this.btnpreview.Text = "PREVIEW";
            this.btnpreview.UseVisualStyleBackColor = false;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // l_name
            // 
            this.l_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.l_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.l_name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_name.ForeColor = System.Drawing.Color.White;
            this.l_name.Location = new System.Drawing.Point(308, 55);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(200, 24);
            this.l_name.TabIndex = 3;
            this.l_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlpreview
            // 
            this.pnlpreview.Controls.Add(this.prepayment);
            this.pnlpreview.Controls.Add(this.preservice);
            this.pnlpreview.Controls.Add(this.preadd);
            this.pnlpreview.Controls.Add(this.prephone);
            this.pnlpreview.Controls.Add(this.preocc);
            this.pnlpreview.Controls.Add(this.pregender);
            this.pnlpreview.Controls.Add(this.prename);
            this.pnlpreview.Controls.Add(this.preworkerphoto);
            this.pnlpreview.Location = new System.Drawing.Point(14, 12);
            this.pnlpreview.Name = "pnlpreview";
            this.pnlpreview.Size = new System.Drawing.Size(329, 380);
            this.pnlpreview.TabIndex = 0;
            this.pnlpreview.Visible = false;
            // 
            // prepayment
            // 
            this.prepayment.AutoSize = true;
            this.prepayment.BackColor = System.Drawing.Color.Transparent;
            this.prepayment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepayment.ForeColor = System.Drawing.Color.White;
            this.prepayment.Location = new System.Drawing.Point(48, 331);
            this.prepayment.Name = "prepayment";
            this.prepayment.Size = new System.Drawing.Size(113, 19);
            this.prepayment.TabIndex = 45;
            this.prepayment.Text = "Payment Status:";
            // 
            // pnlmainpreview
            // 
            this.pnlmainpreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.pnlmainpreview.Controls.Add(this.pnlpreview);
            this.pnlmainpreview.Controls.Add(this.label12);
            this.pnlmainpreview.Location = new System.Drawing.Point(625, 47);
            this.pnlmainpreview.Name = "pnlmainpreview";
            this.pnlmainpreview.Size = new System.Drawing.Size(357, 406);
            this.pnlmainpreview.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(304, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // f_name
            // 
            this.f_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.f_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.f_name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.f_name.ForeColor = System.Drawing.Color.White;
            this.f_name.Location = new System.Drawing.Point(69, 55);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(200, 24);
            this.f_name.TabIndex = 0;
            this.f_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(768, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 17);
            this.label11.TabIndex = 37;
            this.label11.Text = "PREVIEW";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnreset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.Color.White;
            this.btnreset.Location = new System.Drawing.Point(102, 467);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(99, 34);
            this.btnreset.TabIndex = 33;
            this.btnreset.Text = "RESET";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // pnlclientinformation
            // 
            this.pnlclientinformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.pnlclientinformation.Controls.Add(this.occupation);
            this.pnlclientinformation.Controls.Add(this.btnphoto);
            this.pnlclientinformation.Controls.Add(this.paymentstatus);
            this.pnlclientinformation.Controls.Add(this.servicearea);
            this.pnlclientinformation.Controls.Add(this.address);
            this.pnlclientinformation.Controls.Add(this.phone);
            this.pnlclientinformation.Controls.Add(this.gender);
            this.pnlclientinformation.Controls.Add(this.label10);
            this.pnlclientinformation.Controls.Add(this.label9);
            this.pnlclientinformation.Controls.Add(this.label8);
            this.pnlclientinformation.Controls.Add(this.label7);
            this.pnlclientinformation.Controls.Add(this.label6);
            this.pnlclientinformation.Controls.Add(this.label5);
            this.pnlclientinformation.Controls.Add(this.label4);
            this.pnlclientinformation.Controls.Add(this.l_name);
            this.pnlclientinformation.Controls.Add(this.label3);
            this.pnlclientinformation.Controls.Add(this.label2);
            this.pnlclientinformation.Controls.Add(this.f_name);
            this.pnlclientinformation.Location = new System.Drawing.Point(12, 47);
            this.pnlclientinformation.Name = "pnlclientinformation";
            this.pnlclientinformation.Size = new System.Drawing.Size(583, 406);
            this.pnlclientinformation.TabIndex = 32;
            // 
            // occupation
            // 
            this.occupation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.occupation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.occupation.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.occupation.ForeColor = System.Drawing.Color.White;
            this.occupation.FormattingEnabled = true;
            this.occupation.Items.AddRange(new object[] {
            "House Worker",
            "Electritian",
            "Technician",
            "Driver",
            "Cleaner"});
            this.occupation.Location = new System.Drawing.Point(308, 119);
            this.occupation.Name = "occupation";
            this.occupation.Size = new System.Drawing.Size(200, 26);
            this.occupation.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(192, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "ADD WORKER INFORMATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmaddworker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(995, 517);
            this.Controls.Add(this.btnworkerback);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.pnlmainpreview);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.pnlclientinformation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmaddworker";
            this.Text = "frmworker";
            ((System.ComponentModel.ISupportInitialize)(this.preworkerphoto)).EndInit();
            this.pnlpreview.ResumeLayout(false);
            this.pnlpreview.PerformLayout();
            this.pnlmainpreview.ResumeLayout(false);
            this.pnlmainpreview.PerformLayout();
            this.pnlclientinformation.ResumeLayout(false);
            this.pnlclientinformation.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label pregender;
        private System.Windows.Forms.Label prename;
        private System.Windows.Forms.Button btnphoto;
        private System.Windows.Forms.ComboBox paymentstatus;
        private System.Windows.Forms.ComboBox servicearea;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label preservice;
        private System.Windows.Forms.Label prephone;
        private System.Windows.Forms.Label preocc;
        private System.Windows.Forms.PictureBox preworkerphoto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label preadd;
        private System.Windows.Forms.Button btnworkerback;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.TextBox l_name;
        private System.Windows.Forms.Panel pnlpreview;
        private System.Windows.Forms.Label prepayment;
        private System.Windows.Forms.Panel pnlmainpreview;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox f_name;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Panel pnlclientinformation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox occupation;
    }
}