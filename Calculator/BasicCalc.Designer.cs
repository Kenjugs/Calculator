namespace Calculator
{
    partial class Calculator
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
			this.btn_add = new System.Windows.Forms.Button();
			this.txtbox_result = new System.Windows.Forms.TextBox();
			this.btn_subtract = new System.Windows.Forms.Button();
			this.btn_divide = new System.Windows.Forms.Button();
			this.btn_multiply = new System.Windows.Forms.Button();
			this.btn_1 = new System.Windows.Forms.Button();
			this.btn_2 = new System.Windows.Forms.Button();
			this.btn_3 = new System.Windows.Forms.Button();
			this.btn_4 = new System.Windows.Forms.Button();
			this.btn_5 = new System.Windows.Forms.Button();
			this.btn_6 = new System.Windows.Forms.Button();
			this.btn_7 = new System.Windows.Forms.Button();
			this.btn_8 = new System.Windows.Forms.Button();
			this.btn_9 = new System.Windows.Forms.Button();
			this.btn_0 = new System.Windows.Forms.Button();
			this.btn_period = new System.Windows.Forms.Button();
			this.btn_equal = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.btn_backspace = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_memClear = new System.Windows.Forms.Button();
			this.btn_memPlus = new System.Windows.Forms.Button();
			this.btn_memMinus = new System.Windows.Forms.Button();
			this.btn_memRecall = new System.Windows.Forms.Button();
			this.btn_memStore = new System.Windows.Forms.Button();
			this.lbl_expr = new System.Windows.Forms.Label();
			this.menuStrip_calc = new System.Windows.Forms.MenuStrip();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.basicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.scientificToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.lbl_memory = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.menuStrip_calc.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_add
			// 
			this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_add.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_add.Location = new System.Drawing.Point(168, 54);
			this.btn_add.Margin = new System.Windows.Forms.Padding(0);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(42, 42);
			this.btn_add.TabIndex = 13;
			this.btn_add.TabStop = false;
			this.btn_add.Text = "+";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// txtbox_result
			// 
			this.txtbox_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
			this.txtbox_result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtbox_result.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtbox_result.Font = new System.Drawing.Font("Droid Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtbox_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
			this.txtbox_result.Location = new System.Drawing.Point(12, 27);
			this.txtbox_result.MaxLength = 12;
			this.txtbox_result.Name = "txtbox_result";
			this.txtbox_result.ReadOnly = true;
			this.txtbox_result.Size = new System.Drawing.Size(273, 30);
			this.txtbox_result.TabIndex = 1;
			this.txtbox_result.Text = "0";
			this.txtbox_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtbox_result.WordWrap = false;
			// 
			// btn_subtract
			// 
			this.btn_subtract.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_subtract.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_subtract.Location = new System.Drawing.Point(168, 104);
			this.btn_subtract.Margin = new System.Windows.Forms.Padding(0);
			this.btn_subtract.Name = "btn_subtract";
			this.btn_subtract.Size = new System.Drawing.Size(42, 42);
			this.btn_subtract.TabIndex = 14;
			this.btn_subtract.TabStop = false;
			this.btn_subtract.Text = "−";
			this.btn_subtract.UseVisualStyleBackColor = true;
			this.btn_subtract.Click += new System.EventHandler(this.btn_subtract_Click);
			// 
			// btn_divide
			// 
			this.btn_divide.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_divide.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_divide.Location = new System.Drawing.Point(168, 204);
			this.btn_divide.Margin = new System.Windows.Forms.Padding(0);
			this.btn_divide.Name = "btn_divide";
			this.btn_divide.Size = new System.Drawing.Size(42, 42);
			this.btn_divide.TabIndex = 16;
			this.btn_divide.TabStop = false;
			this.btn_divide.Text = "÷";
			this.btn_divide.UseVisualStyleBackColor = true;
			this.btn_divide.Click += new System.EventHandler(this.btn_divide_Click);
			// 
			// btn_multiply
			// 
			this.btn_multiply.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_multiply.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_multiply.Location = new System.Drawing.Point(168, 155);
			this.btn_multiply.Margin = new System.Windows.Forms.Padding(0);
			this.btn_multiply.Name = "btn_multiply";
			this.btn_multiply.Size = new System.Drawing.Size(42, 40);
			this.btn_multiply.TabIndex = 15;
			this.btn_multiply.TabStop = false;
			this.btn_multiply.Text = "×";
			this.btn_multiply.UseVisualStyleBackColor = true;
			this.btn_multiply.Click += new System.EventHandler(this.btn_multiply_Click);
			// 
			// btn_1
			// 
			this.btn_1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_1.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_1.Location = new System.Drawing.Point(6, 154);
			this.btn_1.Margin = new System.Windows.Forms.Padding(0);
			this.btn_1.Name = "btn_1";
			this.btn_1.Size = new System.Drawing.Size(42, 42);
			this.btn_1.TabIndex = 2;
			this.btn_1.TabStop = false;
			this.btn_1.Text = "1";
			this.btn_1.UseVisualStyleBackColor = true;
			this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
			// 
			// btn_2
			// 
			this.btn_2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_2.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_2.Location = new System.Drawing.Point(60, 155);
			this.btn_2.Margin = new System.Windows.Forms.Padding(0);
			this.btn_2.Name = "btn_2";
			this.btn_2.Size = new System.Drawing.Size(42, 40);
			this.btn_2.TabIndex = 3;
			this.btn_2.TabStop = false;
			this.btn_2.Text = "2";
			this.btn_2.UseVisualStyleBackColor = true;
			this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
			// 
			// btn_3
			// 
			this.btn_3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_3.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_3.Location = new System.Drawing.Point(114, 155);
			this.btn_3.Margin = new System.Windows.Forms.Padding(0);
			this.btn_3.Name = "btn_3";
			this.btn_3.Size = new System.Drawing.Size(42, 40);
			this.btn_3.TabIndex = 4;
			this.btn_3.TabStop = false;
			this.btn_3.Text = "3";
			this.btn_3.UseVisualStyleBackColor = true;
			this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
			// 
			// btn_4
			// 
			this.btn_4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_4.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_4.Location = new System.Drawing.Point(6, 104);
			this.btn_4.Margin = new System.Windows.Forms.Padding(0);
			this.btn_4.Name = "btn_4";
			this.btn_4.Size = new System.Drawing.Size(42, 42);
			this.btn_4.TabIndex = 5;
			this.btn_4.TabStop = false;
			this.btn_4.Text = "4";
			this.btn_4.UseVisualStyleBackColor = true;
			this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
			// 
			// btn_5
			// 
			this.btn_5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_5.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_5.Location = new System.Drawing.Point(60, 104);
			this.btn_5.Margin = new System.Windows.Forms.Padding(0);
			this.btn_5.Name = "btn_5";
			this.btn_5.Size = new System.Drawing.Size(42, 42);
			this.btn_5.TabIndex = 6;
			this.btn_5.TabStop = false;
			this.btn_5.Text = "5";
			this.btn_5.UseVisualStyleBackColor = true;
			this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
			// 
			// btn_6
			// 
			this.btn_6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_6.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_6.Location = new System.Drawing.Point(114, 104);
			this.btn_6.Margin = new System.Windows.Forms.Padding(0);
			this.btn_6.Name = "btn_6";
			this.btn_6.Size = new System.Drawing.Size(42, 42);
			this.btn_6.TabIndex = 7;
			this.btn_6.TabStop = false;
			this.btn_6.Text = "6";
			this.btn_6.UseVisualStyleBackColor = true;
			this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
			// 
			// btn_7
			// 
			this.btn_7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_7.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_7.Location = new System.Drawing.Point(6, 54);
			this.btn_7.Margin = new System.Windows.Forms.Padding(0);
			this.btn_7.Name = "btn_7";
			this.btn_7.Size = new System.Drawing.Size(42, 42);
			this.btn_7.TabIndex = 8;
			this.btn_7.TabStop = false;
			this.btn_7.Text = "7";
			this.btn_7.UseVisualStyleBackColor = true;
			this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
			// 
			// btn_8
			// 
			this.btn_8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_8.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_8.Location = new System.Drawing.Point(60, 54);
			this.btn_8.Margin = new System.Windows.Forms.Padding(0);
			this.btn_8.Name = "btn_8";
			this.btn_8.Size = new System.Drawing.Size(42, 42);
			this.btn_8.TabIndex = 9;
			this.btn_8.TabStop = false;
			this.btn_8.Text = "8";
			this.btn_8.UseVisualStyleBackColor = true;
			this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
			// 
			// btn_9
			// 
			this.btn_9.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_9.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_9.Location = new System.Drawing.Point(114, 54);
			this.btn_9.Margin = new System.Windows.Forms.Padding(0);
			this.btn_9.Name = "btn_9";
			this.btn_9.Size = new System.Drawing.Size(42, 42);
			this.btn_9.TabIndex = 10;
			this.btn_9.TabStop = false;
			this.btn_9.Text = "9";
			this.btn_9.UseVisualStyleBackColor = true;
			this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
			// 
			// btn_0
			// 
			this.btn_0.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_0.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_0.Location = new System.Drawing.Point(60, 204);
			this.btn_0.Margin = new System.Windows.Forms.Padding(0);
			this.btn_0.Name = "btn_0";
			this.btn_0.Size = new System.Drawing.Size(42, 42);
			this.btn_0.TabIndex = 11;
			this.btn_0.TabStop = false;
			this.btn_0.Text = "0";
			this.btn_0.UseVisualStyleBackColor = true;
			this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
			// 
			// btn_period
			// 
			this.btn_period.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_period.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_period.Location = new System.Drawing.Point(6, 204);
			this.btn_period.Margin = new System.Windows.Forms.Padding(0);
			this.btn_period.Name = "btn_period";
			this.btn_period.Size = new System.Drawing.Size(42, 42);
			this.btn_period.TabIndex = 12;
			this.btn_period.TabStop = false;
			this.btn_period.Text = ".";
			this.btn_period.UseVisualStyleBackColor = true;
			this.btn_period.Click += new System.EventHandler(this.btn_period_Click);
			// 
			// btn_equal
			// 
			this.btn_equal.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_equal.Font = new System.Drawing.Font("Droid Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_equal.Location = new System.Drawing.Point(114, 204);
			this.btn_equal.Margin = new System.Windows.Forms.Padding(0);
			this.btn_equal.Name = "btn_equal";
			this.btn_equal.Size = new System.Drawing.Size(42, 42);
			this.btn_equal.TabIndex = 17;
			this.btn_equal.TabStop = false;
			this.btn_equal.Text = "=";
			this.btn_equal.UseVisualStyleBackColor = true;
			this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
			// 
			// btn_clear
			// 
			this.btn_clear.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_clear.Font = new System.Drawing.Font("Droid Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_clear.Location = new System.Drawing.Point(114, 4);
			this.btn_clear.Margin = new System.Windows.Forms.Padding(0);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(42, 42);
			this.btn_clear.TabIndex = 19;
			this.btn_clear.TabStop = false;
			this.btn_clear.Text = "AC";
			this.btn_clear.UseVisualStyleBackColor = true;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// btn_backspace
			// 
			this.btn_backspace.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_backspace.Font = new System.Drawing.Font("Wingdings", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
			this.btn_backspace.Location = new System.Drawing.Point(168, 4);
			this.btn_backspace.Margin = new System.Windows.Forms.Padding(0);
			this.btn_backspace.Name = "btn_backspace";
			this.btn_backspace.Size = new System.Drawing.Size(42, 42);
			this.btn_backspace.TabIndex = 18;
			this.btn_backspace.TabStop = false;
			this.btn_backspace.Text = "Õ";
			this.btn_backspace.UseVisualStyleBackColor = true;
			this.btn_backspace.Click += new System.EventHandler(this.btn_backspace_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.Controls.Add(this.btn_backspace, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_period, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.btn_equal, 2, 4);
			this.tableLayoutPanel1.Controls.Add(this.btn_0, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.btn_add, 3, 1);
			this.tableLayoutPanel1.Controls.Add(this.btn_clear, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_3, 2, 3);
			this.tableLayoutPanel1.Controls.Add(this.btn_8, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.btn_subtract, 3, 2);
			this.tableLayoutPanel1.Controls.Add(this.btn_multiply, 3, 3);
			this.tableLayoutPanel1.Controls.Add(this.btn_4, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.btn_5, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.btn_6, 2, 2);
			this.tableLayoutPanel1.Controls.Add(this.btn_1, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.btn_7, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.btn_2, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.btn_9, 2, 1);
			this.tableLayoutPanel1.Controls.Add(this.btn_divide, 3, 4);
			this.tableLayoutPanel1.Controls.Add(this.btn_memClear, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.btn_memPlus, 4, 1);
			this.tableLayoutPanel1.Controls.Add(this.btn_memMinus, 4, 2);
			this.tableLayoutPanel1.Controls.Add(this.btn_memRecall, 4, 3);
			this.tableLayoutPanel1.Controls.Add(this.btn_memStore, 4, 4);
			this.tableLayoutPanel1.Controls.Add(this.lbl_expr, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 63);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 250);
			this.tableLayoutPanel1.TabIndex = 19;
			// 
			// btn_memClear
			// 
			this.btn_memClear.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_memClear.Font = new System.Drawing.Font("Droid Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_memClear.Location = new System.Drawing.Point(223, 4);
			this.btn_memClear.Margin = new System.Windows.Forms.Padding(0);
			this.btn_memClear.Name = "btn_memClear";
			this.btn_memClear.Size = new System.Drawing.Size(42, 42);
			this.btn_memClear.TabIndex = 20;
			this.btn_memClear.TabStop = false;
			this.btn_memClear.Text = "MC";
			this.btn_memClear.UseVisualStyleBackColor = true;
			this.btn_memClear.Click += new System.EventHandler(this.btn_memClear_Click);
			// 
			// btn_memPlus
			// 
			this.btn_memPlus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_memPlus.Font = new System.Drawing.Font("Droid Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_memPlus.Location = new System.Drawing.Point(223, 54);
			this.btn_memPlus.Margin = new System.Windows.Forms.Padding(0);
			this.btn_memPlus.Name = "btn_memPlus";
			this.btn_memPlus.Size = new System.Drawing.Size(42, 42);
			this.btn_memPlus.TabIndex = 21;
			this.btn_memPlus.TabStop = false;
			this.btn_memPlus.Text = "M+";
			this.btn_memPlus.UseVisualStyleBackColor = true;
			this.btn_memPlus.Click += new System.EventHandler(this.btn_memPlus_Click);
			// 
			// btn_memMinus
			// 
			this.btn_memMinus.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_memMinus.Font = new System.Drawing.Font("Droid Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_memMinus.Location = new System.Drawing.Point(223, 104);
			this.btn_memMinus.Margin = new System.Windows.Forms.Padding(0);
			this.btn_memMinus.Name = "btn_memMinus";
			this.btn_memMinus.Size = new System.Drawing.Size(42, 42);
			this.btn_memMinus.TabIndex = 22;
			this.btn_memMinus.TabStop = false;
			this.btn_memMinus.Text = "M−";
			this.btn_memMinus.UseVisualStyleBackColor = true;
			this.btn_memMinus.Click += new System.EventHandler(this.btn_memMinus_Click);
			// 
			// btn_memRecall
			// 
			this.btn_memRecall.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_memRecall.Font = new System.Drawing.Font("Droid Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_memRecall.Location = new System.Drawing.Point(223, 154);
			this.btn_memRecall.Margin = new System.Windows.Forms.Padding(0);
			this.btn_memRecall.Name = "btn_memRecall";
			this.btn_memRecall.Size = new System.Drawing.Size(42, 42);
			this.btn_memRecall.TabIndex = 23;
			this.btn_memRecall.TabStop = false;
			this.btn_memRecall.Text = "MR";
			this.btn_memRecall.UseVisualStyleBackColor = true;
			this.btn_memRecall.Click += new System.EventHandler(this.btn_memRecall_Click);
			// 
			// btn_memStore
			// 
			this.btn_memStore.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_memStore.Font = new System.Drawing.Font("Droid Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_memStore.Location = new System.Drawing.Point(223, 204);
			this.btn_memStore.Margin = new System.Windows.Forms.Padding(0);
			this.btn_memStore.Name = "btn_memStore";
			this.btn_memStore.Size = new System.Drawing.Size(42, 42);
			this.btn_memStore.TabIndex = 24;
			this.btn_memStore.TabStop = false;
			this.btn_memStore.Text = "MS";
			this.btn_memStore.UseVisualStyleBackColor = true;
			this.btn_memStore.Click += new System.EventHandler(this.btn_memStore_Click);
			// 
			// lbl_expr
			// 
			this.lbl_expr.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lbl_expr.AutoSize = true;
			this.tableLayoutPanel1.SetColumnSpan(this.lbl_expr, 2);
			this.lbl_expr.Location = new System.Drawing.Point(95, 0);
			this.lbl_expr.Name = "lbl_expr";
			this.lbl_expr.Size = new System.Drawing.Size(10, 13);
			this.lbl_expr.TabIndex = 0;
			this.lbl_expr.Text = " ";
			// 
			// menuStrip_calc
			// 
			this.menuStrip_calc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem});
			this.menuStrip_calc.Location = new System.Drawing.Point(0, 0);
			this.menuStrip_calc.Name = "menuStrip_calc";
			this.menuStrip_calc.Size = new System.Drawing.Size(297, 24);
			this.menuStrip_calc.TabIndex = 20;
			this.menuStrip_calc.Text = "menuStrip1";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basicToolStripMenuItem,
            this.scientificToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// basicToolStripMenuItem
			// 
			this.basicToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.basicToolStripMenuItem.Name = "basicToolStripMenuItem";
			this.basicToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.basicToolStripMenuItem.Text = "Basic";
			// 
			// scientificToolStripMenuItem
			// 
			this.scientificToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.scientificToolStripMenuItem.Enabled = false;
			this.scientificToolStripMenuItem.Name = "scientificToolStripMenuItem";
			this.scientificToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.scientificToolStripMenuItem.Text = "Scientific";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 20);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
			// 
			// lbl_memory
			// 
			this.lbl_memory.AutoSize = true;
			this.lbl_memory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(232)))), ((int)(((byte)(248)))));
			this.lbl_memory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(101)))));
			this.lbl_memory.Location = new System.Drawing.Point(15, 30);
			this.lbl_memory.Name = "lbl_memory";
			this.lbl_memory.Size = new System.Drawing.Size(10, 13);
			this.lbl_memory.TabIndex = 21;
			this.lbl_memory.Text = " ";
			// 
			// Calculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(297, 325);
			this.Controls.Add(this.lbl_memory);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.txtbox_result);
			this.Controls.Add(this.menuStrip_calc);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip_calc;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(313, 346);
			this.Name = "Calculator";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Calculator";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.menuStrip_calc.ResumeLayout(false);
			this.menuStrip_calc.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txtbox_result;
        private System.Windows.Forms.Button btn_subtract;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_period;
        private System.Windows.Forms.Button btn_equal;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.Button btn_backspace;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label lbl_expr;
		private System.Windows.Forms.MenuStrip menuStrip_calc;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem basicToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem scientificToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.Button btn_memClear;
		private System.Windows.Forms.Button btn_memPlus;
		private System.Windows.Forms.Button btn_memMinus;
		private System.Windows.Forms.Button btn_memRecall;
		private System.Windows.Forms.Button btn_memStore;
		private System.Windows.Forms.Label lbl_memory;
	}
}

