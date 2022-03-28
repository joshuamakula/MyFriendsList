namespace MyFriendsList
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_newfriend = new System.Windows.Forms.TextBox();
            this.btn_addfriend = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_addfive = new System.Windows.Forms.Button();
            this.btn_sortAscending = new System.Windows.Forms.Button();
            this.btn_sortDescending = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(12, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(343, 404);
            this.listBox1.TabIndex = 0;
            // 
            // txt_newfriend
            // 
            this.txt_newfriend.Location = new System.Drawing.Point(389, 25);
            this.txt_newfriend.Name = "txt_newfriend";
            this.txt_newfriend.Size = new System.Drawing.Size(351, 26);
            this.txt_newfriend.TabIndex = 1;
            // 
            // btn_addfriend
            // 
            this.btn_addfriend.Location = new System.Drawing.Point(389, 75);
            this.btn_addfriend.Name = "btn_addfriend";
            this.btn_addfriend.Size = new System.Drawing.Size(113, 56);
            this.btn_addfriend.TabIndex = 2;
            this.btn_addfriend.Text = "Add Friend";
            this.btn_addfriend.UseVisualStyleBackColor = true;
            this.btn_addfriend.Click += new System.EventHandler(this.btn_addfriend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(541, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // btn_addfive
            // 
            this.btn_addfive.Location = new System.Drawing.Point(389, 152);
            this.btn_addfive.Name = "btn_addfive";
            this.btn_addfive.Size = new System.Drawing.Size(113, 54);
            this.btn_addfive.TabIndex = 4;
            this.btn_addfive.Text = "Add 5 Friends";
            this.btn_addfive.UseVisualStyleBackColor = true;
            this.btn_addfive.Click += new System.EventHandler(this.btn_addfive_Click);
            // 
            // btn_sortAscending
            // 
            this.btn_sortAscending.Location = new System.Drawing.Point(389, 374);
            this.btn_sortAscending.Name = "btn_sortAscending";
            this.btn_sortAscending.Size = new System.Drawing.Size(93, 44);
            this.btn_sortAscending.TabIndex = 5;
            this.btn_sortAscending.Text = "A -> Z";
            this.btn_sortAscending.UseVisualStyleBackColor = true;
            this.btn_sortAscending.Click += new System.EventHandler(this.btn_sortAscending_Click);
            // 
            // btn_sortDescending
            // 
            this.btn_sortDescending.Location = new System.Drawing.Point(505, 374);
            this.btn_sortDescending.Name = "btn_sortDescending";
            this.btn_sortDescending.Size = new System.Drawing.Size(87, 44);
            this.btn_sortDescending.TabIndex = 6;
            this.btn_sortDescending.Text = "Z -> A";
            this.btn_sortDescending.UseVisualStyleBackColor = true;
            this.btn_sortDescending.Click += new System.EventHandler(this.btn_sortDescending_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(623, 374);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(90, 44);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_sortDescending);
            this.Controls.Add(this.btn_sortAscending);
            this.Controls.Add(this.btn_addfive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addfriend);
            this.Controls.Add(this.txt_newfriend);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox txt_newfriend;
        private System.Windows.Forms.Button btn_addfriend;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_addfive;
        private System.Windows.Forms.Button btn_sortAscending;
        private System.Windows.Forms.Button btn_sortDescending;
        private System.Windows.Forms.Button btn_clear;
    }
}

