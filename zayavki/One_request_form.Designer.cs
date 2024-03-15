namespace zayavki
{
    partial class One_request_form
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
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            desc_ = new TextBox();
            type_ = new TextBox();
            name_ = new TextBox();
            label4 = new Label();
            label5 = new Label();
            comboBox1 = new ComboBox();
            Request_create = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(14, 191);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 12;
            label3.Text = "Описание";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 128);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 11;
            label1.Text = "Тип неисправности";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 10;
            label2.Text = "Название оборудования";
            // 
            // desc_
            // 
            desc_.BackColor = Color.LemonChiffon;
            desc_.Location = new Point(14, 215);
            desc_.Margin = new Padding(3, 4, 3, 4);
            desc_.Multiline = true;
            desc_.Name = "desc_";
            desc_.Size = new Size(330, 116);
            desc_.TabIndex = 9;
            // 
            // type_
            // 
            type_.BackColor = Color.LemonChiffon;
            type_.Location = new Point(14, 149);
            type_.Margin = new Padding(3, 4, 3, 4);
            type_.Name = "type_";
            type_.Size = new Size(330, 27);
            type_.TabIndex = 8;
            // 
            // name_
            // 
            name_.BackColor = Color.LemonChiffon;
            name_.Location = new Point(14, 97);
            name_.Margin = new Padding(3, 4, 3, 4);
            name_.Name = "name_";
            name_.Size = new Size(330, 27);
            name_.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(161, 9);
            label4.Name = "label4";
            label4.Size = new Size(261, 35);
            label4.TabIndex = 13;
            label4.Text = "Обработка заявки";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(14, 349);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 14;
            label5.Text = "Исполнитель";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.LemonChiffon;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(14, 373);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(329, 28);
            comboBox1.TabIndex = 15;
            // 
            // Request_create
            // 
            Request_create.BackColor = Color.Khaki;
            Request_create.Location = new Point(14, 429);
            Request_create.Margin = new Padding(3, 4, 3, 4);
            Request_create.Name = "Request_create";
            Request_create.Size = new Size(330, 51);
            Request_create.TabIndex = 16;
            Request_create.Text = "Применить";
            Request_create.UseVisualStyleBackColor = false;
            Request_create.Click += Request_create_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Khaki;
            button1.Location = new Point(385, 468);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(165, 52);
            button1.TabIndex = 17;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // One_request_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(562, 525);
            Controls.Add(button1);
            Controls.Add(Request_create);
            Controls.Add(comboBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(desc_);
            Controls.Add(type_);
            Controls.Add(name_);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            Name = "One_request_form";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заявка";
            FormClosing += One_request_form_FormClosing;
            Load += One_request_form_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox desc_;
        private TextBox type_;
        private TextBox name_;
        private Label label4;
        private Label label5;
        private ComboBox comboBox1;
        private Button Request_create;
        private Button button1;
    }
}