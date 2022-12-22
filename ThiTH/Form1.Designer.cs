namespace ThiTH
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.courseLabel = new System.Windows.Forms.Label();
            this.course = new System.Windows.Forms.ComboBox();
            this.regionLabel = new System.Windows.Forms.Label();
            this.nongthonOption = new System.Windows.Forms.RadioButton();
            this.thanhphoOption = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.Button();
            this.sort = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentCourse = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentTinchi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDongia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentFee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentVAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentDiscount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentTotalMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tinchiLabel = new System.Windows.Forms.Label();
            this.tinchi = new System.Windows.Forms.TextBox();
            this.nameError = new System.Windows.Forms.Label();
            this.courseError = new System.Windows.Forms.Label();
            this.tinchiError = new System.Windows.Forms.Label();
            this.regionError = new System.Windows.Forms.Label();
            this.dongiaLabel = new System.Windows.Forms.Label();
            this.thanhtienLabel = new System.Windows.Forms.Label();
            this.vatLabel = new System.Windows.Forms.Label();
            this.discountLabel = new System.Windows.Forms.Label();
            this.tongtienLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameLabel.Location = new System.Drawing.Point(175, 29);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(162, 29);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Tên sinh viên:";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.name.Location = new System.Drawing.Point(298, 29);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(429, 35);
            this.name.TabIndex = 1;
            this.name.TextChanged += new System.EventHandler(this.validateName);
            // 
            // courseLabel
            // 
            this.courseLabel.AutoSize = true;
            this.courseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.courseLabel.Location = new System.Drawing.Point(175, 84);
            this.courseLabel.Name = "courseLabel";
            this.courseLabel.Size = new System.Drawing.Size(126, 29);
            this.courseLabel.TabIndex = 2;
            this.courseLabel.Text = "Khóa học: ";
            // 
            // course
            // 
            this.course.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.course.FormattingEnabled = true;
            this.course.Items.AddRange(new object[] {
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.course.Location = new System.Drawing.Point(298, 81);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(121, 37);
            this.course.TabIndex = 3;
            this.course.TextChanged += new System.EventHandler(this.validateCourse);
            // 
            // regionLabel
            // 
            this.regionLabel.AutoSize = true;
            this.regionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.regionLabel.Location = new System.Drawing.Point(177, 190);
            this.regionLabel.Name = "regionLabel";
            this.regionLabel.Size = new System.Drawing.Size(109, 29);
            this.regionLabel.TabIndex = 4;
            this.regionLabel.Text = "Khu vực: ";
            // 
            // nongthonOption
            // 
            this.nongthonOption.AutoSize = true;
            this.nongthonOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nongthonOption.Location = new System.Drawing.Point(300, 190);
            this.nongthonOption.Name = "nongthonOption";
            this.nongthonOption.Size = new System.Drawing.Size(149, 33);
            this.nongthonOption.TabIndex = 5;
            this.nongthonOption.TabStop = true;
            this.nongthonOption.Text = "Nông thôn";
            this.nongthonOption.UseVisualStyleBackColor = true;
            this.nongthonOption.CheckedChanged += new System.EventHandler(this.handleCheckedChanged);
            // 
            // thanhphoOption
            // 
            this.thanhphoOption.AutoSize = true;
            this.thanhphoOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.thanhphoOption.Location = new System.Drawing.Point(410, 190);
            this.thanhphoOption.Name = "thanhphoOption";
            this.thanhphoOption.Size = new System.Drawing.Size(153, 33);
            this.thanhphoOption.TabIndex = 6;
            this.thanhphoOption.TabStop = true;
            this.thanhphoOption.Text = "Thành phố";
            this.thanhphoOption.UseVisualStyleBackColor = true;
            this.thanhphoOption.CheckedChanged += new System.EventHandler(this.handleCheckedChanged);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.add.ForeColor = System.Drawing.SystemColors.Control;
            this.add.Location = new System.Drawing.Point(378, 249);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 31);
            this.add.TabIndex = 13;
            this.add.Text = "Thêm";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.handleAddNewStudent);
            // 
            // sort
            // 
            this.sort.BackColor = System.Drawing.Color.Gold;
            this.sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.sort.ForeColor = System.Drawing.SystemColors.Control;
            this.sort.Location = new System.Drawing.Point(488, 249);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(108, 31);
            this.sort.TabIndex = 14;
            this.sort.Text = "Sắp xếp";
            this.sort.UseVisualStyleBackColor = false;
            this.sort.Click += new System.EventHandler(this.handleSortStudents);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentName,
            this.studentCourse,
            this.studentRegion,
            this.studentTinchi,
            this.studentDongia,
            this.studentFee,
            this.studentVAT,
            this.studentDiscount,
            this.studentTotalMoney});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 481);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(994, 290);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // studentName
            // 
            this.studentName.Text = "Tên sinh viên";
            this.studentName.Width = 150;
            // 
            // studentCourse
            // 
            this.studentCourse.Text = "Khóa học";
            this.studentCourse.Width = 110;
            // 
            // studentRegion
            // 
            this.studentRegion.Text = "Khu vực";
            this.studentRegion.Width = 80;
            // 
            // studentTinchi
            // 
            this.studentTinchi.Text = "Số tín chỉ";
            this.studentTinchi.Width = 80;
            // 
            // studentDongia
            // 
            this.studentDongia.Text = "Đơn giá";
            this.studentDongia.Width = 100;
            // 
            // studentFee
            // 
            this.studentFee.Text = "Tổng số tiền phải đóng";
            this.studentFee.Width = 180;
            // 
            // studentVAT
            // 
            this.studentVAT.Text = "Thuế VAT";
            this.studentVAT.Width = 100;
            // 
            // studentDiscount
            // 
            this.studentDiscount.Text = "Giảm giá";
            this.studentDiscount.Width = 80;
            // 
            // studentTotalMoney
            // 
            this.studentTotalMoney.Text = "Tổng tiền";
            this.studentTotalMoney.Width = 100;
            // 
            // tinchiLabel
            // 
            this.tinchiLabel.AutoSize = true;
            this.tinchiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tinchiLabel.Location = new System.Drawing.Point(175, 136);
            this.tinchiLabel.Name = "tinchiLabel";
            this.tinchiLabel.Size = new System.Drawing.Size(123, 29);
            this.tinchiLabel.TabIndex = 15;
            this.tinchiLabel.Text = "Số tín chỉ: ";
            // 
            // tinchi
            // 
            this.tinchi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tinchi.Location = new System.Drawing.Point(298, 133);
            this.tinchi.Name = "tinchi";
            this.tinchi.Size = new System.Drawing.Size(429, 35);
            this.tinchi.TabIndex = 16;
            this.tinchi.TextChanged += new System.EventHandler(this.validateTinchi);
            this.tinchi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.handleValidateInput);
            // 
            // nameError
            // 
            this.nameError.AutoSize = true;
            this.nameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nameError.ForeColor = System.Drawing.Color.Red;
            this.nameError.Location = new System.Drawing.Point(303, 58);
            this.nameError.Name = "nameError";
            this.nameError.Size = new System.Drawing.Size(0, 29);
            this.nameError.TabIndex = 17;
            // 
            // courseError
            // 
            this.courseError.AutoSize = true;
            this.courseError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.courseError.ForeColor = System.Drawing.Color.Red;
            this.courseError.Location = new System.Drawing.Point(303, 110);
            this.courseError.Name = "courseError";
            this.courseError.Size = new System.Drawing.Size(0, 29);
            this.courseError.TabIndex = 18;
            // 
            // tinchiError
            // 
            this.tinchiError.AutoSize = true;
            this.tinchiError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tinchiError.ForeColor = System.Drawing.Color.Red;
            this.tinchiError.Location = new System.Drawing.Point(303, 165);
            this.tinchiError.Name = "tinchiError";
            this.tinchiError.Size = new System.Drawing.Size(0, 29);
            this.tinchiError.TabIndex = 19;
            // 
            // regionError
            // 
            this.regionError.AutoSize = true;
            this.regionError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.regionError.ForeColor = System.Drawing.Color.Red;
            this.regionError.Location = new System.Drawing.Point(303, 217);
            this.regionError.Name = "regionError";
            this.regionError.Size = new System.Drawing.Size(0, 29);
            this.regionError.TabIndex = 20;
            // 
            // dongiaLabel
            // 
            this.dongiaLabel.AutoSize = true;
            this.dongiaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dongiaLabel.Location = new System.Drawing.Point(175, 297);
            this.dongiaLabel.Name = "dongiaLabel";
            this.dongiaLabel.Size = new System.Drawing.Size(102, 29);
            this.dongiaLabel.TabIndex = 21;
            this.dongiaLabel.Text = "Đơn giá:";
            // 
            // thanhtienLabel
            // 
            this.thanhtienLabel.AutoSize = true;
            this.thanhtienLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.thanhtienLabel.Location = new System.Drawing.Point(173, 326);
            this.thanhtienLabel.Name = "thanhtienLabel";
            this.thanhtienLabel.Size = new System.Drawing.Size(266, 29);
            this.thanhtienLabel.TabIndex = 22;
            this.thanhtienLabel.Text = "Tổng số tiền phải đóng:";
            // 
            // vatLabel
            // 
            this.vatLabel.AutoSize = true;
            this.vatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.vatLabel.Location = new System.Drawing.Point(175, 355);
            this.vatLabel.Name = "vatLabel";
            this.vatLabel.Size = new System.Drawing.Size(127, 29);
            this.vatLabel.TabIndex = 23;
            this.vatLabel.Text = "Thuế VAT:";
            // 
            // discountLabel
            // 
            this.discountLabel.AutoSize = true;
            this.discountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.discountLabel.Location = new System.Drawing.Point(175, 384);
            this.discountLabel.Name = "discountLabel";
            this.discountLabel.Size = new System.Drawing.Size(115, 29);
            this.discountLabel.TabIndex = 24;
            this.discountLabel.Text = "Giảm giá:";
            // 
            // tongtienLabel
            // 
            this.tongtienLabel.AutoSize = true;
            this.tongtienLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tongtienLabel.Location = new System.Drawing.Point(175, 413);
            this.tongtienLabel.Name = "tongtienLabel";
            this.tongtienLabel.Size = new System.Drawing.Size(121, 29);
            this.tongtienLabel.TabIndex = 25;
            this.tongtienLabel.Text = "Tổng tiền:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(983, 770);
            this.Controls.Add(this.tongtienLabel);
            this.Controls.Add(this.discountLabel);
            this.Controls.Add(this.vatLabel);
            this.Controls.Add(this.thanhtienLabel);
            this.Controls.Add(this.dongiaLabel);
            this.Controls.Add(this.regionError);
            this.Controls.Add(this.tinchiError);
            this.Controls.Add(this.courseError);
            this.Controls.Add(this.nameError);
            this.Controls.Add(this.tinchi);
            this.Controls.Add(this.tinchiLabel);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.add);
            this.Controls.Add(this.thanhphoOption);
            this.Controls.Add(this.nongthonOption);
            this.Controls.Add(this.regionLabel);
            this.Controls.Add(this.course);
            this.Controls.Add(this.courseLabel);
            this.Controls.Add(this.name);
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Danh sách sinh viên đóng học phí";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.handleCloseForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label courseLabel;
        private System.Windows.Forms.ComboBox course;
        private System.Windows.Forms.Label regionLabel;
        private System.Windows.Forms.RadioButton nongthonOption;
        private System.Windows.Forms.RadioButton thanhphoOption;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.ColumnHeader studentCourse;
        private System.Windows.Forms.ColumnHeader studentRegion;
        private System.Windows.Forms.ColumnHeader studentTinchi;
        private System.Windows.Forms.ColumnHeader studentDongia;
        private System.Windows.Forms.ColumnHeader studentFee;
        private System.Windows.Forms.ColumnHeader studentVAT;
        private System.Windows.Forms.ColumnHeader studentDiscount;
        private System.Windows.Forms.ColumnHeader studentTotalMoney;
        private System.Windows.Forms.Label tinchiLabel;
        private System.Windows.Forms.TextBox tinchi;
        private System.Windows.Forms.Label nameError;
        private System.Windows.Forms.Label courseError;
        private System.Windows.Forms.Label tinchiError;
        private System.Windows.Forms.Label regionError;
        private System.Windows.Forms.Label dongiaLabel;
        private System.Windows.Forms.Label thanhtienLabel;
        private System.Windows.Forms.Label vatLabel;
        private System.Windows.Forms.Label discountLabel;
        private System.Windows.Forms.Label tongtienLabel;
    }
}

