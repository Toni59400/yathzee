namespace Yathzee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_joueur2 = new System.Windows.Forms.Label();
            this.joueur1_input = new System.Windows.Forms.TextBox();
            this.joueur2_input = new System.Windows.Forms.TextBox();
            this.btn_jouer = new System.Windows.Forms.PictureBox();
            this.txt_j1 = new System.Windows.Forms.Label();
            this.txt_j2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_jouer)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(83, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_titre
            // 
            this.lbl_titre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lbl_titre.Location = new System.Drawing.Point(430, 36);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(218, 67);
            this.lbl_titre.TabIndex = 1;
            this.lbl_titre.Text = "Yathzee";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(123, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Joueur 1 :";
            // 
            // lbl_joueur2
            // 
            this.lbl_joueur2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_joueur2.AutoSize = true;
            this.lbl_joueur2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_joueur2.Location = new System.Drawing.Point(121, 333);
            this.lbl_joueur2.Name = "lbl_joueur2";
            this.lbl_joueur2.Size = new System.Drawing.Size(112, 29);
            this.lbl_joueur2.TabIndex = 3;
            this.lbl_joueur2.Text = "Joueur 2 :";
            // 
            // joueur1_input
            // 
            this.joueur1_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.joueur1_input.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.joueur1_input.Location = new System.Drawing.Point(489, 190);
            this.joueur1_input.Name = "joueur1_input";
            this.joueur1_input.Size = new System.Drawing.Size(100, 37);
            this.joueur1_input.TabIndex = 4;
            // 
            // joueur2_input
            // 
            this.joueur2_input.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.joueur2_input.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.joueur2_input.Location = new System.Drawing.Point(489, 329);
            this.joueur2_input.Name = "joueur2_input";
            this.joueur2_input.Size = new System.Drawing.Size(100, 37);
            this.joueur2_input.TabIndex = 5;
            // 
            // btn_jouer
            // 
            this.btn_jouer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_jouer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_jouer.Image = ((System.Drawing.Image)(resources.GetObject("btn_jouer.Image")));
            this.btn_jouer.Location = new System.Drawing.Point(799, 452);
            this.btn_jouer.Name = "btn_jouer";
            this.btn_jouer.Size = new System.Drawing.Size(149, 69);
            this.btn_jouer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_jouer.TabIndex = 6;
            this.btn_jouer.TabStop = false;
            this.btn_jouer.Click += new System.EventHandler(this.btn_jouer_Click);
            // 
            // txt_j1
            // 
            this.txt_j1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_j1.AutoSize = true;
            this.txt_j1.BackColor = System.Drawing.Color.Brown;
            this.txt_j1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_j1.Location = new System.Drawing.Point(873, 197);
            this.txt_j1.Name = "txt_j1";
            this.txt_j1.Size = new System.Drawing.Size(0, 23);
            this.txt_j1.TabIndex = 7;
            // 
            // txt_j2
            // 
            this.txt_j2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_j2.AutoSize = true;
            this.txt_j2.BackColor = System.Drawing.Color.Brown;
            this.txt_j2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_j2.Location = new System.Drawing.Point(873, 336);
            this.txt_j2.Name = "txt_j2";
            this.txt_j2.Size = new System.Drawing.Size(0, 23);
            this.txt_j2.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.73581F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.39922F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.96282F));
            this.tableLayoutPanel1.Controls.Add(this.txt_j2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_titre, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_j1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.joueur1_input, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.joueur2_input, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_joueur2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_jouer, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1022, 557);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 551);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Yathzee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_jouer)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_titre;
        private Label label1;
        private Label lbl_joueur2;
        private TextBox joueur1_input;
        private TextBox joueur2_input;
        private PictureBox btn_jouer;
        private Label txt_j1;
        private Label txt_j2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}