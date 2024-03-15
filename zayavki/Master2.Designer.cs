namespace zayavki
{
    partial class Master2
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
            button1 = new Button();
            Request_create = new Button();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            desc_ = new TextBox();
            type_ = new TextBox();
            name_ = new TextBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Khaki;
            button1.Location = new Point(909, 600);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(203, 47);
            button1.TabIndex = 28;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Request_create
            // 
            Request_create.BackColor = Color.Khaki;
            Request_create.Location = new Point(12, 558);
            Request_create.Margin = new Padding(3, 4, 3, 4);
            Request_create.Name = "Request_create";
            Request_create.Size = new Size(507, 51);
            Request_create.TabIndex = 27;
            Request_create.Text = "Выполнение заявки и создание отчета\r\n";
            Request_create.UseVisualStyleBackColor = false;
            Request_create.Click += Request_create_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(354, 12);
            label4.Name = "label4";
            label4.Size = new Size(285, 35);
            label4.TabIndex = 24;
            label4.Text = "Выполнение заявки";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(703, 191);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 23;
            label3.Text = "Описание";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(703, 126);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 22;
            label1.Text = "Тип неисправности";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(703, 71);
            label2.Name = "label2";
            label2.Size = new Size(187, 20);
            label2.TabIndex = 21;
            label2.Text = "Название оборудования";
            // 
            // desc_
            // 
            desc_.BackColor = Color.LemonChiffon;
            desc_.Location = new Point(703, 215);
            desc_.Margin = new Padding(3, 4, 3, 4);
            desc_.Multiline = true;
            desc_.Name = "desc_";
            desc_.ReadOnly = true;
            desc_.Size = new Size(330, 116);
            desc_.TabIndex = 20;
            // 
            // type_
            // 
            type_.BackColor = Color.LemonChiffon;
            type_.Location = new Point(703, 150);
            type_.Margin = new Padding(3, 4, 3, 4);
            type_.Name = "type_";
            type_.ReadOnly = true;
            type_.Size = new Size(330, 27);
            type_.TabIndex = 19;
            // 
            // name_
            // 
            name_.BackColor = Color.LemonChiffon;
            name_.Location = new Point(703, 95);
            name_.Margin = new Padding(3, 4, 3, 4);
            name_.Name = "name_";
            name_.ReadOnly = true;
            name_.Size = new Size(330, 27);
            name_.TabIndex = 18;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LemonChiffon;
            textBox1.Location = new Point(12, 475);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(507, 73);
            textBox1.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 451);
            label5.Name = "label5";
            label5.Size = new Size(209, 20);
            label5.TabIndex = 30;
            label5.Text = "Комментарий исполнителя";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(12, 50);
            label6.Name = "label6";
            label6.Size = new Size(161, 20);
            label6.TabIndex = 33;
            label6.Text = "Затраченные ресуры";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(12, 71);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(507, 260);
            listView1.TabIndex = 34;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Название";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Количество";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Цена";
            columnHeader3.Width = 150;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LemonChiffon;
            textBox2.Location = new Point(12, 362);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(217, 27);
            textBox2.TabIndex = 35;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.LemonChiffon;
            textBox3.Location = new Point(269, 362);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(108, 27);
            textBox3.TabIndex = 36;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LemonChiffon;
            textBox4.Location = new Point(397, 362);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(122, 27);
            textBox4.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(12, 339);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 38;
            label7.Text = "Название";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(269, 339);
            label8.Name = "label8";
            label8.Size = new Size(95, 20);
            label8.TabIndex = 39;
            label8.Text = "Количество";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(397, 338);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 40;
            label9.Text = "Цена";
            // 
            // button2
            // 
            button2.BackColor = Color.Khaki;
            button2.Location = new Point(12, 400);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(507, 29);
            button2.TabIndex = 41;
            button2.Text = "Добавить";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // Master_form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1124, 660);
            Controls.Add(button2);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(listView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(Request_create);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(desc_);
            Controls.Add(type_);
            Controls.Add(name_);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Master_form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Выполнение заявки";
            FormClosing += Master_form2_FormClosing;
            Load += Master_form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button Request_create;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TextBox desc_;
        private TextBox type_;
        private TextBox name_;
        private TextBox textBox1;
        private Label label5;
        private Label label6;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button2;
    }
}