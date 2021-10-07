
namespace BoulderMichigan
{
    partial class frm_GroupsLessThan10Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_GroupsLessThan10Book));
            this.lbl_Book = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_ReturnToBookingMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Book
            // 
            this.lbl_Book.AutoSize = true;
            this.lbl_Book.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Book.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_Book.Location = new System.Drawing.Point(338, 127);
            this.lbl_Book.Name = "lbl_Book";
            this.lbl_Book.Size = new System.Drawing.Size(1224, 60);
            this.lbl_Book.TabIndex = 23;
            this.lbl_Book.Text = "Host Your Next Outing at Boulder Michigan!";
            this.lbl_Book.Click += new System.EventHandler(this.lbl_Book_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DimGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("OPTICopperplate-Light", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(407, 393);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(1072, 143);
            this.textBox2.TabIndex = 52;
            this.textBox2.TabStop = false;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_ReturnToBookingMenu
            // 
            this.btn_ReturnToBookingMenu.BackColor = System.Drawing.Color.Transparent;
            this.btn_ReturnToBookingMenu.FlatAppearance.BorderColor = System.Drawing.Color.Snow;
            this.btn_ReturnToBookingMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.AntiqueWhite;
            this.btn_ReturnToBookingMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_ReturnToBookingMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReturnToBookingMenu.Font = new System.Drawing.Font("OPTICopperplate-Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ReturnToBookingMenu.ForeColor = System.Drawing.Color.Goldenrod;
            this.btn_ReturnToBookingMenu.Location = new System.Drawing.Point(663, 645);
            this.btn_ReturnToBookingMenu.Name = "btn_ReturnToBookingMenu";
            this.btn_ReturnToBookingMenu.Size = new System.Drawing.Size(462, 53);
            this.btn_ReturnToBookingMenu.TabIndex = 53;
            this.btn_ReturnToBookingMenu.Text = "Return to Booking Menu";
            this.btn_ReturnToBookingMenu.UseVisualStyleBackColor = false;
            this.btn_ReturnToBookingMenu.Click += new System.EventHandler(this.btn_ReturnToBookingMenu_Click);
            // 
            // frm_GroupsLessThan10Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1546, 852);
            this.Controls.Add(this.btn_ReturnToBookingMenu);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbl_Book);
            this.Name = "frm_GroupsLessThan10Book";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Book;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_ReturnToBookingMenu;
    }
}