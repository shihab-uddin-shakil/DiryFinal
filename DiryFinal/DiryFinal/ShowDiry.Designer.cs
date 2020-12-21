namespace DiryFinal
{
    partial class ShowDiry
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
            this.label1 = new System.Windows.Forms.Label();
            this.EperiencetextBox = new System.Windows.Forms.TextBox();
            this.ThoughttextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FellingstextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EventdateTime = new System.Windows.Forms.DateTimePicker();
            this.importancecomboBox = new System.Windows.Forms.ComboBox();
            this.AddEvent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.uploadImage = new System.Windows.Forms.Button();
            this.imgtextBox = new System.Windows.Forms.TextBox();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Backbutton = new System.Windows.Forms.Button();
            this.Backlink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Experience";
            // 
            // EperiencetextBox
            // 
            this.EperiencetextBox.Location = new System.Drawing.Point(56, 100);
            this.EperiencetextBox.Multiline = true;
            this.EperiencetextBox.Name = "EperiencetextBox";
            this.EperiencetextBox.Size = new System.Drawing.Size(268, 61);
            this.EperiencetextBox.TabIndex = 1;
            // 
            // ThoughttextBox
            // 
            this.ThoughttextBox.Location = new System.Drawing.Point(56, 221);
            this.ThoughttextBox.Multiline = true;
            this.ThoughttextBox.Name = "ThoughttextBox";
            this.ThoughttextBox.Size = new System.Drawing.Size(268, 59);
            this.ThoughttextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thought";
            // 
            // FellingstextBox
            // 
            this.FellingstextBox.Location = new System.Drawing.Point(56, 337);
            this.FellingstextBox.Multiline = true;
            this.FellingstextBox.Name = "FellingstextBox";
            this.FellingstextBox.Size = new System.Drawing.Size(275, 88);
            this.FellingstextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fellings";
            // 
            // EventdateTime
            // 
            this.EventdateTime.Location = new System.Drawing.Point(56, 455);
            this.EventdateTime.Name = "EventdateTime";
            this.EventdateTime.Size = new System.Drawing.Size(268, 22);
            this.EventdateTime.TabIndex = 6;
            // 
            // importancecomboBox
            // 
            this.importancecomboBox.FormattingEnabled = true;
            this.importancecomboBox.Items.AddRange(new object[] {
            "High",
            "Moderate",
            "Less important"});
            this.importancecomboBox.Location = new System.Drawing.Point(56, 507);
            this.importancecomboBox.Name = "importancecomboBox";
            this.importancecomboBox.Size = new System.Drawing.Size(268, 24);
            this.importancecomboBox.TabIndex = 7;
            // 
            // AddEvent
            // 
            this.AddEvent.BackColor = System.Drawing.SystemColors.GrayText;
            this.AddEvent.Location = new System.Drawing.Point(89, 659);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(145, 40);
            this.AddEvent.TabIndex = 9;
            this.AddEvent.Text = "Add Event";
            this.AddEvent.UseVisualStyleBackColor = false;
            this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(393, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 536);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(636, 530);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(657, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Event List";
            // 
            // uploadImage
            // 
            this.uploadImage.Location = new System.Drawing.Point(56, 553);
            this.uploadImage.Name = "uploadImage";
            this.uploadImage.Size = new System.Drawing.Size(85, 29);
            this.uploadImage.TabIndex = 12;
            this.uploadImage.Text = "Upload";
            this.uploadImage.UseVisualStyleBackColor = true;
            this.uploadImage.Click += new System.EventHandler(this.uploadImage_Click);
            // 
            // imgtextBox
            // 
            this.imgtextBox.Location = new System.Drawing.Point(194, 553);
            this.imgtextBox.Name = "imgtextBox";
            this.imgtextBox.Size = new System.Drawing.Size(100, 22);
            this.imgtextBox.TabIndex = 13;
            // 
            // Updatebutton
            // 
            this.Updatebutton.BackColor = System.Drawing.SystemColors.Highlight;
            this.Updatebutton.Location = new System.Drawing.Point(316, 659);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(145, 40);
            this.Updatebutton.TabIndex = 14;
            this.Updatebutton.Text = "Update Event";
            this.Updatebutton.UseVisualStyleBackColor = false;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Deletebutton.Location = new System.Drawing.Point(510, 659);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(145, 40);
            this.Deletebutton.TabIndex = 15;
            this.Deletebutton.Text = "Delete Event";
            this.Deletebutton.UseVisualStyleBackColor = false;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Backbutton
            // 
            this.Backbutton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Backbutton.Location = new System.Drawing.Point(900, 12);
            this.Backbutton.Name = "Backbutton";
            this.Backbutton.Size = new System.Drawing.Size(145, 40);
            this.Backbutton.TabIndex = 16;
            this.Backbutton.Text = ".";
            this.Backbutton.UseVisualStyleBackColor = false;
            this.Backbutton.Click += new System.EventHandler(this.Backbutton_Click);
            // 
            // Backlink
            // 
            this.Backlink.AutoSize = true;
            this.Backlink.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backlink.LinkColor = System.Drawing.Color.Black;
            this.Backlink.Location = new System.Drawing.Point(984, 713);
            this.Backlink.Name = "Backlink";
            this.Backlink.Size = new System.Drawing.Size(66, 29);
            this.Backlink.TabIndex = 17;
            this.Backlink.TabStop = true;
            this.Backlink.Text = "Back";
            this.Backlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Backlink_LinkClicked);
            // 
            // ShowDiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 748);
            this.Controls.Add(this.Backlink);
            this.Controls.Add(this.Backbutton);
            this.Controls.Add(this.Deletebutton);
            this.Controls.Add(this.Updatebutton);
            this.Controls.Add(this.imgtextBox);
            this.Controls.Add(this.uploadImage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddEvent);
            this.Controls.Add(this.importancecomboBox);
            this.Controls.Add(this.EventdateTime);
            this.Controls.Add(this.FellingstextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ThoughttextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EperiencetextBox);
            this.Controls.Add(this.label1);
            this.Name = "ShowDiry";
            this.Text = "ShowDiry";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowDiry_FormClosing);
            this.Load += new System.EventHandler(this.ShowDiry_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EperiencetextBox;
        private System.Windows.Forms.TextBox ThoughttextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FellingstextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EventdateTime;
        private System.Windows.Forms.ComboBox importancecomboBox;
        private System.Windows.Forms.Button AddEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button uploadImage;
        private System.Windows.Forms.TextBox imgtextBox;
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Backbutton;
        private System.Windows.Forms.LinkLabel Backlink;
    }
}