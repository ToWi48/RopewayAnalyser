namespace RopewayAnalyser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.LB_ThermoUmschalter = new System.Windows.Forms.ListBox();
            this.LB_ThermoSchuetz = new System.Windows.Forms.ListBox();
            this.LB_Handnotaus = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_Hilfsschuetz = new System.Windows.Forms.Button();
            this.BT_ThermoSchuetz = new System.Windows.Forms.Button();
            this.BT_Handnotaus = new System.Windows.Forms.Button();
            this.BT_ThermoUmschalter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_Hilfsschuetz = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.88889F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.11111F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 338);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Schleppliftanlage Schwarzenberg - Diagnose";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.LB_ThermoUmschalter, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.LB_ThermoSchuetz, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.LB_Handnotaus, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.BT_Hilfsschuetz, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BT_ThermoSchuetz, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BT_Handnotaus, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.BT_ThermoUmschalter, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.LB_Hilfsschuetz, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 72);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(695, 264);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // LB_ThermoUmschalter
            // 
            this.LB_ThermoUmschalter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_ThermoUmschalter.FormattingEnabled = true;
            this.LB_ThermoUmschalter.ItemHeight = 15;
            this.LB_ThermoUmschalter.Location = new System.Drawing.Point(523, 31);
            this.LB_ThermoUmschalter.Name = "LB_ThermoUmschalter";
            this.LB_ThermoUmschalter.Size = new System.Drawing.Size(168, 202);
            this.LB_ThermoUmschalter.TabIndex = 13;
            // 
            // LB_ThermoSchuetz
            // 
            this.LB_ThermoSchuetz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_ThermoSchuetz.FormattingEnabled = true;
            this.LB_ThermoSchuetz.ItemHeight = 15;
            this.LB_ThermoSchuetz.Location = new System.Drawing.Point(350, 31);
            this.LB_ThermoSchuetz.Name = "LB_ThermoSchuetz";
            this.LB_ThermoSchuetz.Size = new System.Drawing.Size(166, 202);
            this.LB_ThermoSchuetz.TabIndex = 12;
            // 
            // LB_Handnotaus
            // 
            this.LB_Handnotaus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Handnotaus.FormattingEnabled = true;
            this.LB_Handnotaus.ItemHeight = 15;
            this.LB_Handnotaus.Location = new System.Drawing.Point(177, 31);
            this.LB_Handnotaus.Name = "LB_Handnotaus";
            this.LB_Handnotaus.Size = new System.Drawing.Size(166, 202);
            this.LB_Handnotaus.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Thermoschalter Stern/Dreieck";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Thermoschalter Schütz";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Handnotaus (Schleife)";
            // 
            // BT_Hilfsschuetz
            // 
            this.BT_Hilfsschuetz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BT_Hilfsschuetz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BT_Hilfsschuetz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Hilfsschuetz.Location = new System.Drawing.Point(4, 239);
            this.BT_Hilfsschuetz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Hilfsschuetz.Name = "BT_Hilfsschuetz";
            this.BT_Hilfsschuetz.Size = new System.Drawing.Size(166, 22);
            this.BT_Hilfsschuetz.TabIndex = 5;
            this.BT_Hilfsschuetz.Text = "Schleife";
            this.BT_Hilfsschuetz.UseVisualStyleBackColor = false;
            this.BT_Hilfsschuetz.Click += new System.EventHandler(this.BT_Hilfsschuetz_Click);
            // 
            // BT_ThermoSchuetz
            // 
            this.BT_ThermoSchuetz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BT_ThermoSchuetz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BT_ThermoSchuetz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ThermoSchuetz.Location = new System.Drawing.Point(350, 239);
            this.BT_ThermoSchuetz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_ThermoSchuetz.Name = "BT_ThermoSchuetz";
            this.BT_ThermoSchuetz.Size = new System.Drawing.Size(166, 22);
            this.BT_ThermoSchuetz.TabIndex = 4;
            this.BT_ThermoSchuetz.Text = "Schleife";
            this.BT_ThermoSchuetz.UseVisualStyleBackColor = false;
            // 
            // BT_Handnotaus
            // 
            this.BT_Handnotaus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BT_Handnotaus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BT_Handnotaus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_Handnotaus.Location = new System.Drawing.Point(177, 239);
            this.BT_Handnotaus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_Handnotaus.Name = "BT_Handnotaus";
            this.BT_Handnotaus.Size = new System.Drawing.Size(166, 22);
            this.BT_Handnotaus.TabIndex = 3;
            this.BT_Handnotaus.Text = "Schleife";
            this.BT_Handnotaus.UseVisualStyleBackColor = false;
            // 
            // BT_ThermoUmschalter
            // 
            this.BT_ThermoUmschalter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BT_ThermoUmschalter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BT_ThermoUmschalter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ThermoUmschalter.Location = new System.Drawing.Point(523, 239);
            this.BT_ThermoUmschalter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BT_ThermoUmschalter.Name = "BT_ThermoUmschalter";
            this.BT_ThermoUmschalter.Size = new System.Drawing.Size(168, 22);
            this.BT_ThermoUmschalter.TabIndex = 1;
            this.BT_ThermoUmschalter.Text = "Schleife";
            this.BT_ThermoUmschalter.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Startfreigabe (Schleife)";
            // 
            // LB_Hilfsschuetz
            // 
            this.LB_Hilfsschuetz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Hilfsschuetz.FormattingEnabled = true;
            this.LB_Hilfsschuetz.ItemHeight = 15;
            this.LB_Hilfsschuetz.Location = new System.Drawing.Point(4, 31);
            this.LB_Hilfsschuetz.Name = "LB_Hilfsschuetz";
            this.LB_Hilfsschuetz.Size = new System.Drawing.Size(166, 202);
            this.LB_Hilfsschuetz.Sorted = true;
            this.LB_Hilfsschuetz.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button BT_ThermoUmschalter;
        private ListBox LB_ThermoUmschalter;
        private ListBox LB_ThermoSchuetz;
        private ListBox LB_Handnotaus;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button BT_Hilfsschuetz;
        private Button BT_ThermoSchuetz;
        private Button BT_Handnotaus;
        private Label label2;
        private ListBox LB_Hilfsschuetz;
    }
}