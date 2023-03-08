
namespace Library_Management_System
{
    partial class frm_Book_View
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
            this.pnl_Add_Stud = new System.Windows.Forms.Panel();
            this.dgv_Books_List = new System.Windows.Forms.DataGridView();
            this.btn_View = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.lbl_HEAD = new System.Windows.Forms.Label();
            this.pnl_Add_Stud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books_List)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Add_Stud
            // 
            this.pnl_Add_Stud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_Add_Stud.Controls.Add(this.lbl_HEAD);
            this.pnl_Add_Stud.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Add_Stud.Location = new System.Drawing.Point(0, 0);
            this.pnl_Add_Stud.Name = "pnl_Add_Stud";
            this.pnl_Add_Stud.Size = new System.Drawing.Size(1288, 164);
            this.pnl_Add_Stud.TabIndex = 24;
            // 
            // dgv_Books_List
            // 
            this.dgv_Books_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Books_List.Location = new System.Drawing.Point(12, 182);
            this.dgv_Books_List.Name = "dgv_Books_List";
            this.dgv_Books_List.RowHeadersWidth = 51;
            this.dgv_Books_List.RowTemplate.Height = 29;
            this.dgv_Books_List.Size = new System.Drawing.Size(1251, 487);
            this.dgv_Books_List.TabIndex = 25;
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_View.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_View.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_View.Location = new System.Drawing.Point(754, 698);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(226, 62);
            this.btn_View.TabIndex = 42;
            this.btn_View.Text = "View";
            this.btn_View.UseVisualStyleBackColor = false;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.Goldenrod;
            this.btn_Refresh.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Refresh.ForeColor = System.Drawing.Color.FloralWhite;
            this.btn_Refresh.Location = new System.Drawing.Point(235, 698);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(237, 62);
            this.btn_Refresh.TabIndex = 43;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            // 
            // lbl_HEAD
            // 
            this.lbl_HEAD.AutoSize = true;
            this.lbl_HEAD.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_HEAD.ForeColor = System.Drawing.Color.Orange;
            this.lbl_HEAD.Location = new System.Drawing.Point(398, 49);
            this.lbl_HEAD.Name = "lbl_HEAD";
            this.lbl_HEAD.Size = new System.Drawing.Size(421, 70);
            this.lbl_HEAD.TabIndex = 0;
            this.lbl_HEAD.Text = "VIEW BOOKS";
            // 
            // frm_Book_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1288, 772);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.dgv_Books_List);
            this.Controls.Add(this.pnl_Add_Stud);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Book_View";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Book_View";
            this.pnl_Add_Stud.ResumeLayout(false);
            this.pnl_Add_Stud.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Books_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Add_Stud;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgv_Books_List;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Label lbl_HEAD;
    }
}