namespace DataBaseTestApp
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_connection = new System.Windows.Forms.Button();
            this.connection_status = new System.Windows.Forms.TextBox();
            this.button_ShowDatabase = new System.Windows.Forms.Button();
            this.button_query = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.button_exit);
            this.panel1.Controls.Add(this.button_query);
            this.panel1.Controls.Add(this.button_ShowDatabase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 610);
            this.panel1.TabIndex = 0;
            // 
            // button_connection
            // 
            this.button_connection.Location = new System.Drawing.Point(423, 452);
            this.button_connection.Name = "button_connection";
            this.button_connection.Size = new System.Drawing.Size(393, 56);
            this.button_connection.TabIndex = 1;
            this.button_connection.Text = "Connect";
            this.button_connection.UseVisualStyleBackColor = true;
            this.button_connection.Click += new System.EventHandler(this.button_connection_Click);
            // 
            // connection_status
            // 
            this.connection_status.Location = new System.Drawing.Point(423, 124);
            this.connection_status.Multiline = true;
            this.connection_status.Name = "connection_status";
            this.connection_status.Size = new System.Drawing.Size(393, 258);
            this.connection_status.TabIndex = 2;
            this.connection_status.TextChanged += new System.EventHandler(this.connection_status_TextChanged);
            // 
            // button_ShowDatabase
            // 
            this.button_ShowDatabase.Location = new System.Drawing.Point(27, 74);
            this.button_ShowDatabase.Name = "button_ShowDatabase";
            this.button_ShowDatabase.Size = new System.Drawing.Size(139, 79);
            this.button_ShowDatabase.TabIndex = 3;
            this.button_ShowDatabase.Text = "Show DataBase";
            this.button_ShowDatabase.UseVisualStyleBackColor = true;
            // 
            // button_query
            // 
            this.button_query.Location = new System.Drawing.Point(27, 223);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(139, 88);
            this.button_query.TabIndex = 4;
            this.button_query.Text = "Query";
            this.button_query.UseVisualStyleBackColor = true;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(27, 374);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(139, 88);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 68);
            this.panel2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.connection_status);
            this.Controls.Add(this.button_connection);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.Button button_ShowDatabase;
        private System.Windows.Forms.Button button_connection;
        private System.Windows.Forms.TextBox connection_status;
        private System.Windows.Forms.Panel panel2;
    }
}

