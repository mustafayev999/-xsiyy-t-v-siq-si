namespace IDCardApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBoxID = new System.Windows.Forms.GroupBox();
            this.pictureBoxID = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            
            this.lblSerialNumber = new System.Windows.Forms.Label();
            this.txtSerialNumber = new System.Windows.Forms.TextBox();
            
            this.lblFIN = new System.Windows.Forms.Label();
            this.txtFIN = new System.Windows.Forms.TextBox();
            
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            
            this.lblPatronymic = new System.Windows.Forms.Label();
            this.txtPatronymic = new System.Windows.Forms.TextBox();
            
            this.lblGender = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.txtBirthDate = new System.Windows.Forms.TextBox();
            
            this.lblBirthPlace = new System.Windows.Forms.Label();
            this.txtBirthPlace = new System.Windows.Forms.TextBox();
            
            this.lblMaritalStatus = new System.Windows.Forms.Label();
            this.txtMaritalStatus = new System.Windows.Forms.TextBox();
            
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.txtIssueDate = new System.Windows.Forms.TextBox();
            
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            
            this.lblIssuer = new System.Windows.Forms.Label();
            this.txtIssuer = new System.Windows.Forms.TextBox();

            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();

            this.groupBoxID.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxID)).BeginInit();
            this.groupBoxInfo.SuspendLayout();
            this.SuspendLayout();
            
            // 
            // groupBoxID
            // 
            this.groupBoxID.Controls.Add(this.pictureBoxID);
            this.groupBoxID.Controls.Add(this.btnUploadImage);
            this.groupBoxID.Location = new System.Drawing.Point(12, 12);
            this.groupBoxID.Name = "groupBoxID";
            this.groupBoxID.Size = new System.Drawing.Size(460, 480);
            this.groupBoxID.TabIndex = 0;
            this.groupBoxID.TabStop = false;
            this.groupBoxID.Text = "Şəxsiyyət vəsiqəsi";
            
            // 
            // pictureBoxID
            // 
            this.pictureBoxID.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxID.Location = new System.Drawing.Point(20, 30);
            this.pictureBoxID.Name = "pictureBoxID";
            this.pictureBoxID.Size = new System.Drawing.Size(420, 350);
            this.pictureBoxID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxID.TabIndex = 0;
            this.pictureBoxID.TabStop = false;
            
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(20, 400);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(420, 30);
            this.btnUploadImage.TabIndex = 1;
            this.btnUploadImage.Text = "Şəkil yüklə...";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.txtIssuer);
            this.groupBoxInfo.Controls.Add(this.lblIssuer);
            this.groupBoxInfo.Controls.Add(this.txtExpiryDate);
            this.groupBoxInfo.Controls.Add(this.lblExpiryDate);
            this.groupBoxInfo.Controls.Add(this.txtIssueDate);
            this.groupBoxInfo.Controls.Add(this.lblIssueDate);
            this.groupBoxInfo.Controls.Add(this.txtMaritalStatus);
            this.groupBoxInfo.Controls.Add(this.lblMaritalStatus);
            this.groupBoxInfo.Controls.Add(this.txtBirthPlace);
            this.groupBoxInfo.Controls.Add(this.lblBirthPlace);
            this.groupBoxInfo.Controls.Add(this.txtBirthDate);
            this.groupBoxInfo.Controls.Add(this.lblBirthDate);
            this.groupBoxInfo.Controls.Add(this.txtGender);
            this.groupBoxInfo.Controls.Add(this.lblGender);
            this.groupBoxInfo.Controls.Add(this.txtPatronymic);
            this.groupBoxInfo.Controls.Add(this.lblPatronymic);
            this.groupBoxInfo.Controls.Add(this.txtName);
            this.groupBoxInfo.Controls.Add(this.lblName);
            this.groupBoxInfo.Controls.Add(this.txtSurname);
            this.groupBoxInfo.Controls.Add(this.lblSurname);
            this.groupBoxInfo.Controls.Add(this.txtFIN);
            this.groupBoxInfo.Controls.Add(this.lblFIN);
            this.groupBoxInfo.Controls.Add(this.txtSerialNumber);
            this.groupBoxInfo.Controls.Add(this.lblSerialNumber);
            this.groupBoxInfo.Location = new System.Drawing.Point(490, 12);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Size = new System.Drawing.Size(480, 480);
            this.groupBoxInfo.TabIndex = 1;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Vəsiqə məlumatları";
            
            int yPos = 30;
            int yOffset = 35;
            
            // 
            // Serial Number
            // 
            this.lblSerialNumber.AutoSize = true;
            this.lblSerialNumber.Location = new System.Drawing.Point(20, yPos);
            this.lblSerialNumber.Name = "lblSerialNumber";
            this.lblSerialNumber.Size = new System.Drawing.Size(89, 15);
            this.lblSerialNumber.TabIndex = 0;
            this.lblSerialNumber.Text = "Seriya və nömrə:";
            
            this.txtSerialNumber.Location = new System.Drawing.Point(150, yPos - 3);
            this.txtSerialNumber.Name = "txtSerialNumber";
            this.txtSerialNumber.Size = new System.Drawing.Size(310, 23);
            this.txtSerialNumber.TabIndex = 1;
            
            yPos += yOffset;
            
            // FIN
            this.lblFIN.AutoSize = true;
            this.lblFIN.Location = new System.Drawing.Point(20, yPos);
            this.lblFIN.Text = "FIN kod:";
            this.txtFIN.Location = new System.Drawing.Point(150, yPos - 3);
            this.txtFIN.Size = new System.Drawing.Size(310, 23);
            
            yPos += yOffset;
            
            // Surname
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(20, yPos);
            this.lblSurname.Text = "Soyad:";
            this.txtSurname.Location = new System.Drawing.Point(150, yPos - 3);
            this.txtSurname.Size = new System.Drawing.Size(310, 23);
            
            yPos += yOffset;
            
            // Name
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(20, yPos);
            this.lblName.Text = "Ad:";
            this.txtName.Location = new System.Drawing.Point(150, yPos - 3);
            this.txtName.Size = new System.Drawing.Size(310, 23);
            
            yPos += yOffset;
            
            // Patronymic
            this.lblPatronymic.AutoSize = true;
            this.lblPatronymic.Location = new System.Drawing.Point(20, yPos);
            this.lblPatronymic.Text = "Ata adı:";
            this.txtPatronymic.Location = new System.Drawing.Point(150, yPos - 3);
            this.txtPatronymic.Size = new System.Drawing.Size(310, 23);
            
            yPos += yOffset;
            
            // Gender
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, yPos);
            this.lblGender.Text = "Cins:";
            this.txtGender.Location = new System.Drawing.Point(150, yPos - 3);
            this.txtGender.Size = new System.Drawing.Size(310, 23);
            
            yPos += yOffset;
            
            // BirthDate
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(20, yPos);
            this.lblBirthDate.Text = "Doğum tarixi:";
            this.txtBirthDate.Location = new System.Drawing.Point(150, yPos - 3);
            this.txtBirthDate.Size = new System.Drawing.Size(310, 23);
            
            yPos += yOffset;
            
            // BirthPlace
            this.lblBirthPlace.AutoSize = true;
            this.lblBirthPlace.Location = new System.Drawing.Point(20, yPos);
            this.lblBirthPlace.Text = "Doğum yeri:";
            this.txtBirthPlace.Location = new System.Drawing.Point(150, yPos - 3);
            this.txtBirthPlace.Size = new System.Drawing.Size(310, 23);
            
            yPos += yOffset;
            
            // MaritalStatus
            this.lblMaritalStatus.AutoSize = true;
            this.lblMaritalStatus.Location = new System.Drawing.Point(20, yPos);
            this.lblMaritalStatus.Text = "Ailə vəziyyəti:";
            this.txtMaritalStatus.Location = new System.Drawing.Point(150, yPos - 3);
            this.txtMaritalStatus.Size = new System.Drawing.Size(310, 23);
            
            yPos += yOffset;
            
            // IssueDate
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Location = new System.Drawing.Point(20, yPos);
            this.lblIssueDate.Text = "Verilmə tarixi:";
            this.txtIssueDate.Location = new System.Drawing.Point(150, yPos - 3);
            this.txtIssueDate.Size = new System.Drawing.Size(310, 23);
            
            yPos += yOffset;
            
            // ExpiryDate
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Location = new System.Drawing.Point(20, yPos);
            this.lblExpiryDate.Text = "Etibarlıdır:";
            this.txtExpiryDate.Location = new System.Drawing.Point(150, yPos - 3);
            this.txtExpiryDate.Size = new System.Drawing.Size(310, 23);
            
            yPos += yOffset;
            
            // Issuer
            this.lblIssuer.AutoSize = true;
            this.lblIssuer.Location = new System.Drawing.Point(20, yPos);
            this.lblIssuer.Text = "Verən orqan:";
            this.txtIssuer.Location = new System.Drawing.Point(150, yPos - 3);
            this.txtIssuer.Size = new System.Drawing.Size(310, 23);

            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(750, 510);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Təmizlə";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(860, 510);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Yadda saxla";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.groupBoxID);
            this.Name = "Form1";
            this.Text = "Azərbaycan Şəxsiyyət Vəsiqəsi";
            
            this.groupBoxID.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxID)).EndInit();
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxID;
        private System.Windows.Forms.PictureBox pictureBoxID;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Label lblSerialNumber;
        private System.Windows.Forms.TextBox txtSerialNumber;
        private System.Windows.Forms.Label lblFIN;
        private System.Windows.Forms.TextBox txtFIN;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblPatronymic;
        private System.Windows.Forms.TextBox txtPatronymic;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.TextBox txtBirthDate;
        private System.Windows.Forms.Label lblBirthPlace;
        private System.Windows.Forms.TextBox txtBirthPlace;
        private System.Windows.Forms.Label lblMaritalStatus;
        private System.Windows.Forms.TextBox txtMaritalStatus;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.TextBox txtIssueDate;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.Label lblIssuer;
        private System.Windows.Forms.TextBox txtIssuer;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
    }
}
