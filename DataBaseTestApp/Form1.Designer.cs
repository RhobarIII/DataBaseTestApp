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
            this.button_exit = new System.Windows.Forms.Button();
            this.button_query = new System.Windows.Forms.Button();
            this.button_ShowDatabase = new System.Windows.Forms.Button();
            this.button_connection = new System.Windows.Forms.Button();
            this.queryPanel = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.connectionStatus = new System.Windows.Forms.Label();
            this.tableDisplay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisplay)).BeginInit();
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
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(27, 374);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(139, 88);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            // 
            // button_query
            // 
            this.button_query.Location = new System.Drawing.Point(27, 223);
            this.button_query.Name = "button_query";
            this.button_query.Size = new System.Drawing.Size(139, 88);
            this.button_query.TabIndex = 4;
            this.button_query.Text = "Query";
            this.button_query.UseVisualStyleBackColor = true;
            this.button_query.Click += new System.EventHandler(this.button_query_Click);
            // 
            // button_ShowDatabase
            // 
            this.button_ShowDatabase.Location = new System.Drawing.Point(27, 74);
            this.button_ShowDatabase.Name = "button_ShowDatabase";
            this.button_ShowDatabase.Size = new System.Drawing.Size(139, 79);
            this.button_ShowDatabase.TabIndex = 3;
            this.button_ShowDatabase.Text = "Show DataBase";
            this.button_ShowDatabase.UseVisualStyleBackColor = true;
            this.button_ShowDatabase.Click += new System.EventHandler(this.button_ShowDatabase_Click);
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
            // queryPanel
            // 
            this.queryPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.queryPanel.Location = new System.Drawing.Point(423, 374);
            this.queryPanel.Multiline = true;
            this.queryPanel.Name = "queryPanel";
            this.queryPanel.Size = new System.Drawing.Size(393, 30);
            this.queryPanel.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.connectionStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(852, 68);
            this.panel2.TabIndex = 3;
            // 
            // connectionStatus
            // 
            this.connectionStatus.AutoSize = true;
            this.connectionStatus.BackColor = System.Drawing.Color.White;
            this.connectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.connectionStatus.ForeColor = System.Drawing.Color.Red;
            this.connectionStatus.Location = new System.Drawing.Point(273, 29);
            this.connectionStatus.Name = "connectionStatus";
            this.connectionStatus.Size = new System.Drawing.Size(296, 29);
            this.connectionStatus.TabIndex = 4;
            this.connectionStatus.Text = "Database is not connected";
            // 
            // tableDisplay
            // 
            this.tableDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDisplay.Location = new System.Drawing.Point(449, 101);
            this.tableDisplay.Name = "tableDisplay";
            this.tableDisplay.Size = new System.Drawing.Size(344, 210);
            this.tableDisplay.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(565, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Insert Query";
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.InfoLabel.Location = new System.Drawing.Point(592, 543);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(51, 20);
            this.InfoLabel.TabIndex = 7;
            this.InfoLabel.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 610);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableDisplay);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.queryPanel);
            this.Controls.Add(this.button_connection);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_query;
        private System.Windows.Forms.Button button_ShowDatabase;
        private System.Windows.Forms.Button button_connection;
        private System.Windows.Forms.TextBox queryPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label connectionStatus;
        private System.Windows.Forms.DataGridView tableDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InfoLabel;
    }
}

