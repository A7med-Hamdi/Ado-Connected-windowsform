namespace ado
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
            this.DGV_course = new System.Windows.Forms.DataGridView();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_duaration = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_topic = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_course)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_course
            // 
            this.DGV_course.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_course.Location = new System.Drawing.Point(132, 230);
            this.DGV_course.Name = "DGV_course";
            this.DGV_course.Size = new System.Drawing.Size(497, 150);
            this.DGV_course.TabIndex = 0;
            this.DGV_course.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_course_RowHeaderMouseClick);
            this.DGV_course.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_course_RowHeaderMouseDoubleClick);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(116, 12);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 1;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(116, 38);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 2;
            this.txt_name.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_duaration
            // 
            this.txt_duaration.Location = new System.Drawing.Point(116, 64);
            this.txt_duaration.Name = "txt_duaration";
            this.txt_duaration.Size = new System.Drawing.Size(100, 20);
            this.txt_duaration.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Duaration";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(103, 132);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(63, 23);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "topic";
            // 
            // cmb_topic
            // 
            this.cmb_topic.FormattingEnabled = true;
            this.cmb_topic.Location = new System.Drawing.Point(116, 100);
            this.cmb_topic.Name = "cmb_topic";
            this.cmb_topic.Size = new System.Drawing.Size(121, 21);
            this.cmb_topic.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "search";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(548, 16);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 20);
            this.txt_search.TabIndex = 12;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(666, 13);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(183, 132);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(183, 170);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 15;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmb_topic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_duaration);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.DGV_course);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_course)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_course;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_duaration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_topic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
    }
}

