
namespace Shromik_Lagbe_v1._00
{
    partial class frmupdateworker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmupdateworker));
            this.label13 = new System.Windows.Forms.Label();
            this.paymentstatus = new System.Windows.Forms.ComboBox();
            this.pnlclientinformation = new System.Windows.Forms.Panel();
            this.servicearea = new System.Windows.Forms.ComboBox();
            this.address = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.gender = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.l_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.f_name = new System.Windows.Forms.TextBox();
            this.preservice = new System.Windows.Forms.Label();
            this.pregender = new System.Windows.Forms.Label();
            this.preadd = new System.Windows.Forms.Label();
            this.preoccupation = new System.Windows.Forms.Label();
            this.prephone = new System.Windows.Forms.Label();
            this.btnpreview = new System.Windows.Forms.Button();
            this.prename = new System.Windows.Forms.Label();
            this.btnsavechanges = new System.Windows.Forms.Button();
            this.btnupdatecancel = new System.Windows.Forms.Button();
            this.pnlmainpreview = new System.Windows.Forms.Panel();
            this.preclphoto = new System.Windows.Forms.PictureBox();
            this.prepayment = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.occupation = new System.Windows.Forms.ComboBox();
            this.pnlclientinformation.SuspendLayout();
            this.pnlmainpreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preclphoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(114, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 17);
            this.label13.TabIndex = 39;
            this.label13.Text = "PREVIEW INFORMATION";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.paymentstatus.Location = new System.Drawing.Point(315, 301);
            this.paymentstatus.Name = "paymentstatus";
            this.paymentstatus.Size = new System.Drawing.Size(200, 26);
            this.paymentstatus.TabIndex = 16;
            // 
            // pnlclientinformation
            // 
            this.pnlclientinformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.pnlclientinformation.Controls.Add(this.occupation);
            this.pnlclientinformation.Controls.Add(this.paymentstatus);
            this.pnlclientinformation.Controls.Add(this.servicearea);
            this.pnlclientinformation.Controls.Add(this.address);
            this.pnlclientinformation.Controls.Add(this.phone);
            this.pnlclientinformation.Controls.Add(this.gender);
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
            this.pnlclientinformation.Location = new System.Drawing.Point(398, 43);
            this.pnlclientinformation.Name = "pnlclientinformation";
            this.pnlclientinformation.Size = new System.Drawing.Size(583, 406);
            this.pnlclientinformation.TabIndex = 40;
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
            this.servicearea.Location = new System.Drawing.Point(78, 301);
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
            this.address.Location = new System.Drawing.Point(315, 233);
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
            this.phone.Location = new System.Drawing.Point(78, 233);
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
            this.gender.Location = new System.Drawing.Point(78, 164);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(198, 26);
            this.gender.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(311, 269);
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
            this.label8.Location = new System.Drawing.Point(74, 269);
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
            this.label7.Location = new System.Drawing.Point(311, 201);
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
            this.label6.Location = new System.Drawing.Point(74, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(311, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Occupation:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gender:";
            // 
            // l_name
            // 
            this.l_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(114)))), ((int)(((byte)(142)))));
            this.l_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.l_name.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_name.ForeColor = System.Drawing.Color.White;
            this.l_name.Location = new System.Drawing.Point(315, 98);
            this.l_name.Name = "l_name";
            this.l_name.Size = new System.Drawing.Size(200, 24);
            this.l_name.TabIndex = 3;
            this.l_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(311, 70);
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
            this.label2.Location = new System.Drawing.Point(72, 70);
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
            this.f_name.Location = new System.Drawing.Point(76, 98);
            this.f_name.Name = "f_name";
            this.f_name.Size = new System.Drawing.Size(200, 24);
            this.f_name.TabIndex = 0;
            this.f_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // preservice
            // 
            this.preservice.AutoSize = true;
            this.preservice.BackColor = System.Drawing.Color.Transparent;
            this.preservice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preservice.ForeColor = System.Drawing.Color.White;
            this.preservice.Location = new System.Drawing.Point(54, 308);
            this.preservice.Name = "preservice";
            this.preservice.Size = new System.Drawing.Size(98, 19);
            this.preservice.TabIndex = 44;
            this.preservice.Text = "Service Area:";
            // 
            // pregender
            // 
            this.pregender.AutoSize = true;
            this.pregender.BackColor = System.Drawing.Color.Transparent;
            this.pregender.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pregender.ForeColor = System.Drawing.Color.White;
            this.pregender.Location = new System.Drawing.Point(54, 170);
            this.pregender.Name = "pregender";
            this.pregender.Size = new System.Drawing.Size(63, 19);
            this.pregender.TabIndex = 40;
            this.pregender.Text = "Gender:";
            // 
            // preadd
            // 
            this.preadd.AutoSize = true;
            this.preadd.BackColor = System.Drawing.Color.Transparent;
            this.preadd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preadd.ForeColor = System.Drawing.Color.White;
            this.preadd.Location = new System.Drawing.Point(54, 275);
            this.preadd.Name = "preadd";
            this.preadd.Size = new System.Drawing.Size(67, 19);
            this.preadd.TabIndex = 43;
            this.preadd.Text = "Address:";
            // 
            // preoccupation
            // 
            this.preoccupation.AutoSize = true;
            this.preoccupation.BackColor = System.Drawing.Color.Transparent;
            this.preoccupation.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preoccupation.ForeColor = System.Drawing.Color.White;
            this.preoccupation.Location = new System.Drawing.Point(54, 205);
            this.preoccupation.Name = "preoccupation";
            this.preoccupation.Size = new System.Drawing.Size(91, 19);
            this.preoccupation.TabIndex = 41;
            this.preoccupation.Text = "Occupation:";
            // 
            // prephone
            // 
            this.prephone.AutoSize = true;
            this.prephone.BackColor = System.Drawing.Color.Transparent;
            this.prephone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prephone.ForeColor = System.Drawing.Color.White;
            this.prephone.Location = new System.Drawing.Point(54, 241);
            this.prephone.Name = "prephone";
            this.prephone.Size = new System.Drawing.Size(57, 19);
            this.prephone.TabIndex = 42;
            this.prephone.Text = "Phone:";
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
            this.btnpreview.Location = new System.Drawing.Point(535, 468);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(139, 34);
            this.btnpreview.TabIndex = 45;
            this.btnpreview.Text = "PREVIEW CHANGES";
            this.btnpreview.UseVisualStyleBackColor = false;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // prename
            // 
            this.prename.AutoSize = true;
            this.prename.BackColor = System.Drawing.Color.Transparent;
            this.prename.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prename.ForeColor = System.Drawing.Color.White;
            this.prename.Location = new System.Drawing.Point(54, 135);
            this.prename.Name = "prename";
            this.prename.Size = new System.Drawing.Size(53, 19);
            this.prename.TabIndex = 39;
            this.prename.Text = "Name:";
            // 
            // btnsavechanges
            // 
            this.btnsavechanges.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnsavechanges.FlatAppearance.BorderSize = 0;
            this.btnsavechanges.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnsavechanges.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnsavechanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsavechanges.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavechanges.ForeColor = System.Drawing.Color.White;
            this.btnsavechanges.Location = new System.Drawing.Point(720, 468);
            this.btnsavechanges.Name = "btnsavechanges";
            this.btnsavechanges.Size = new System.Drawing.Size(126, 34);
            this.btnsavechanges.TabIndex = 43;
            this.btnsavechanges.Text = "SAVE CHANGES";
            this.btnsavechanges.UseVisualStyleBackColor = false;
            this.btnsavechanges.Click += new System.EventHandler(this.btnsavechanges_Click);
            // 
            // btnupdatecancel
            // 
            this.btnupdatecancel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnupdatecancel.FlatAppearance.BorderSize = 0;
            this.btnupdatecancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btnupdatecancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnupdatecancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdatecancel.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdatecancel.ForeColor = System.Drawing.Color.White;
            this.btnupdatecancel.Location = new System.Drawing.Point(127, 468);
            this.btnupdatecancel.Name = "btnupdatecancel";
            this.btnupdatecancel.Size = new System.Drawing.Size(99, 34);
            this.btnupdatecancel.TabIndex = 42;
            this.btnupdatecancel.Text = "CANCEL";
            this.btnupdatecancel.UseVisualStyleBackColor = false;
            this.btnupdatecancel.Click += new System.EventHandler(this.btnupdatecancel_Click);
            // 
            // pnlmainpreview
            // 
            this.pnlmainpreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(68)))), ((int)(((byte)(101)))));
            this.pnlmainpreview.Controls.Add(this.preclphoto);
            this.pnlmainpreview.Controls.Add(this.prepayment);
            this.pnlmainpreview.Controls.Add(this.prename);
            this.pnlmainpreview.Controls.Add(this.preservice);
            this.pnlmainpreview.Controls.Add(this.pregender);
            this.pnlmainpreview.Controls.Add(this.preadd);
            this.pnlmainpreview.Controls.Add(this.preoccupation);
            this.pnlmainpreview.Controls.Add(this.prephone);
            this.pnlmainpreview.Location = new System.Drawing.Point(13, 43);
            this.pnlmainpreview.Name = "pnlmainpreview";
            this.pnlmainpreview.Size = new System.Drawing.Size(357, 406);
            this.pnlmainpreview.TabIndex = 41;
            // 
            // preclphoto
            // 
            this.preclphoto.Image = ((System.Drawing.Image)(resources.GetObject("preclphoto.Image")));
            this.preclphoto.Location = new System.Drawing.Point(137, 29);
            this.preclphoto.Name = "preclphoto";
            this.preclphoto.Size = new System.Drawing.Size(86, 81);
            this.preclphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.preclphoto.TabIndex = 38;
            this.preclphoto.TabStop = false;
            // 
            // prepayment
            // 
            this.prepayment.AutoSize = true;
            this.prepayment.BackColor = System.Drawing.Color.Transparent;
            this.prepayment.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prepayment.ForeColor = System.Drawing.Color.White;
            this.prepayment.Location = new System.Drawing.Point(54, 340);
            this.prepayment.Name = "prepayment";
            this.prepayment.Size = new System.Drawing.Size(121, 19);
            this.prepayment.TabIndex = 45;
            this.prepayment.Text = "Payment Status:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(594, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "UPDATE WORKER INFORAMTION";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.occupation.Location = new System.Drawing.Point(315, 163);
            this.occupation.Name = "occupation";
            this.occupation.Size = new System.Drawing.Size(198, 26);
            this.occupation.TabIndex = 17;
            // 
            // frmupdateworker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(994, 516);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.pnlclientinformation);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.btnsavechanges);
            this.Controls.Add(this.btnupdatecancel);
            this.Controls.Add(this.pnlmainpreview);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmupdateworker";
            this.Text = "frmupdateworker";
            this.pnlclientinformation.ResumeLayout(false);
            this.pnlclientinformation.PerformLayout();
            this.pnlmainpreview.ResumeLayout(false);
            this.pnlmainpreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.preclphoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox paymentstatus;
        private System.Windows.Forms.Panel pnlclientinformation;
        private System.Windows.Forms.ComboBox servicearea;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.ComboBox gender;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox l_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox f_name;
        private System.Windows.Forms.Label preservice;
        private System.Windows.Forms.Label pregender;
        private System.Windows.Forms.Label preadd;
        private System.Windows.Forms.Label preoccupation;
        private System.Windows.Forms.Label prephone;
        private System.Windows.Forms.Button btnpreview;
        private System.Windows.Forms.Label prename;
        private System.Windows.Forms.Button btnsavechanges;
        private System.Windows.Forms.Button btnupdatecancel;
        private System.Windows.Forms.Panel pnlmainpreview;
        private System.Windows.Forms.PictureBox preclphoto;
        private System.Windows.Forms.Label prepayment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox occupation;
    }
}