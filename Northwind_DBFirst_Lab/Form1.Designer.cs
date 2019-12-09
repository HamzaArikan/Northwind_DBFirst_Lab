namespace Northwind_DBFirst_Lab
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
            this.btnGroupBy = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAny = new System.Windows.Forms.Button();
            this.btnEndWith = new System.Windows.Forms.Button();
            this.btnStartsWith = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.BtnFirstOrDefault = new System.Windows.Forms.Button();
            this.btnFirtst = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnOrderBy = new System.Windows.Forms.Button();
            this.btnWhere = new System.Windows.Forms.Button();
            this.btnToList = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEmployeeList2 = new System.Windows.Forms.Button();
            this.btnOrderList = new System.Windows.Forms.Button();
            this.btnProductList = new System.Windows.Forms.Button();
            this.btnEmployeeList1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGroupBy
            // 
            this.btnGroupBy.Location = new System.Drawing.Point(771, 403);
            this.btnGroupBy.Name = "btnGroupBy";
            this.btnGroupBy.Size = new System.Drawing.Size(144, 45);
            this.btnGroupBy.TabIndex = 29;
            this.btnGroupBy.Text = "Stock per Category(Group By)";
            this.btnGroupBy.UseVisualStyleBackColor = true;
            this.btnGroupBy.Click += new System.EventHandler(this.btnGroupBy_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(771, 346);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(144, 45);
            this.btnSelect.TabIndex = 28;
            this.btnSelect.Text = "Customer List (Select)";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAny
            // 
            this.btnAny.Location = new System.Drawing.Point(634, 460);
            this.btnAny.Name = "btnAny";
            this.btnAny.Size = new System.Drawing.Size(131, 45);
            this.btnAny.TabIndex = 27;
            this.btnAny.Text = "Category Name (Any)";
            this.btnAny.UseVisualStyleBackColor = true;
            this.btnAny.Click += new System.EventHandler(this.btnAny_Click);
            // 
            // btnEndWith
            // 
            this.btnEndWith.Location = new System.Drawing.Point(632, 403);
            this.btnEndWith.Name = "btnEndWith";
            this.btnEndWith.Size = new System.Drawing.Size(130, 45);
            this.btnEndWith.TabIndex = 26;
            this.btnEndWith.Text = "List of Products (Ends With)";
            this.btnEndWith.UseVisualStyleBackColor = true;
            this.btnEndWith.Click += new System.EventHandler(this.btnEndWith_Click);
            // 
            // btnStartsWith
            // 
            this.btnStartsWith.Location = new System.Drawing.Point(634, 346);
            this.btnStartsWith.Name = "btnStartsWith";
            this.btnStartsWith.Size = new System.Drawing.Size(131, 45);
            this.btnStartsWith.TabIndex = 25;
            this.btnStartsWith.Text = "List of Products (Starts With)";
            this.btnStartsWith.UseVisualStyleBackColor = true;
            this.btnStartsWith.Click += new System.EventHandler(this.btnStartsWith_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(490, 463);
            this.btnContains.Margin = new System.Windows.Forms.Padding(4);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(134, 42);
            this.btnContains.TabIndex = 24;
            this.btnContains.Text = "List of Products (Contains)";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(488, 403);
            this.btnSkip.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(136, 45);
            this.btnSkip.TabIndex = 23;
            this.btnSkip.Text = "List of Products (Skip)";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(490, 346);
            this.btnTake.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(136, 44);
            this.btnTake.TabIndex = 22;
            this.btnTake.Text = "Top 10 Products per Range";
            this.btnTake.UseVisualStyleBackColor = true;
            this.btnTake.Click += new System.EventHandler(this.btnTake_Click);
            // 
            // BtnFirstOrDefault
            // 
            this.BtnFirstOrDefault.Location = new System.Drawing.Point(345, 463);
            this.BtnFirstOrDefault.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BtnFirstOrDefault.Name = "BtnFirstOrDefault";
            this.BtnFirstOrDefault.Size = new System.Drawing.Size(136, 42);
            this.BtnFirstOrDefault.TabIndex = 21;
            this.BtnFirstOrDefault.Text = "Find a Category (FirstOrDefault)";
            this.BtnFirstOrDefault.UseVisualStyleBackColor = true;
            this.BtnFirstOrDefault.Click += new System.EventHandler(this.BtnFirstOrDefault_Click);
            // 
            // btnFirtst
            // 
            this.btnFirtst.Location = new System.Drawing.Point(345, 403);
            this.btnFirtst.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFirtst.Name = "btnFirtst";
            this.btnFirtst.Size = new System.Drawing.Size(136, 45);
            this.btnFirtst.TabIndex = 20;
            this.btnFirtst.Text = "Find the First Category After ID";
            this.btnFirtst.UseVisualStyleBackColor = true;
            this.btnFirtst.Click += new System.EventHandler(this.btnFirtst_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(345, 346);
            this.btnFind.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(136, 45);
            this.btnFind.TabIndex = 19;
            this.btnFind.Text = "Find a Category";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnOrderBy
            // 
            this.btnOrderBy.Location = new System.Drawing.Point(205, 460);
            this.btnOrderBy.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnOrderBy.Name = "btnOrderBy";
            this.btnOrderBy.Size = new System.Drawing.Size(130, 45);
            this.btnOrderBy.TabIndex = 18;
            this.btnOrderBy.Text = "List Products in Order";
            this.btnOrderBy.UseVisualStyleBackColor = true;
            this.btnOrderBy.Click += new System.EventHandler(this.btnOrderBy_Click);
            // 
            // btnWhere
            // 
            this.btnWhere.Location = new System.Drawing.Point(204, 403);
            this.btnWhere.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnWhere.Name = "btnWhere";
            this.btnWhere.Size = new System.Drawing.Size(131, 45);
            this.btnWhere.TabIndex = 17;
            this.btnWhere.Text = "List Products per U/P Range";
            this.btnWhere.UseVisualStyleBackColor = true;
            this.btnWhere.Click += new System.EventHandler(this.btnWhere_Click);
            // 
            // btnToList
            // 
            this.btnToList.Location = new System.Drawing.Point(201, 346);
            this.btnToList.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnToList.Name = "btnToList";
            this.btnToList.Size = new System.Drawing.Size(134, 45);
            this.btnToList.TabIndex = 16;
            this.btnToList.Text = "List Categories";
            this.btnToList.UseVisualStyleBackColor = true;
            this.btnToList.Click += new System.EventHandler(this.btnToList_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1258, 316);
            this.dataGridView1.TabIndex = 15;
            // 
            // btnEmployeeList2
            // 
            this.btnEmployeeList2.Location = new System.Drawing.Point(921, 348);
            this.btnEmployeeList2.Name = "btnEmployeeList2";
            this.btnEmployeeList2.Size = new System.Drawing.Size(144, 44);
            this.btnEmployeeList2.TabIndex = 30;
            this.btnEmployeeList2.Text = "List of Employees 2";
            this.btnEmployeeList2.UseVisualStyleBackColor = true;
            this.btnEmployeeList2.Click += new System.EventHandler(this.btnEmployeeList2_Click);
            // 
            // btnOrderList
            // 
            this.btnOrderList.Location = new System.Drawing.Point(921, 403);
            this.btnOrderList.Name = "btnOrderList";
            this.btnOrderList.Size = new System.Drawing.Size(144, 44);
            this.btnOrderList.TabIndex = 30;
            this.btnOrderList.Text = "List of Orders";
            this.btnOrderList.UseVisualStyleBackColor = true;
            this.btnOrderList.Click += new System.EventHandler(this.btnOrderList_Click);
            // 
            // btnProductList
            // 
            this.btnProductList.Location = new System.Drawing.Point(921, 460);
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.Size = new System.Drawing.Size(144, 44);
            this.btnProductList.TabIndex = 30;
            this.btnProductList.Text = "List of Products (>$40)";
            this.btnProductList.UseVisualStyleBackColor = true;
            this.btnProductList.Click += new System.EventHandler(this.btnProductList_Click);
            // 
            // btnEmployeeList1
            // 
            this.btnEmployeeList1.Location = new System.Drawing.Point(771, 460);
            this.btnEmployeeList1.Name = "btnEmployeeList1";
            this.btnEmployeeList1.Size = new System.Drawing.Size(144, 44);
            this.btnEmployeeList1.TabIndex = 30;
            this.btnEmployeeList1.Text = "List of Employees 1";
            this.btnEmployeeList1.UseVisualStyleBackColor = true;
            this.btnEmployeeList1.Click += new System.EventHandler(this.btnEmployeeList1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 519);
            this.Controls.Add(this.btnEmployeeList1);
            this.Controls.Add(this.btnProductList);
            this.Controls.Add(this.btnOrderList);
            this.Controls.Add(this.btnEmployeeList2);
            this.Controls.Add(this.btnGroupBy);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnAny);
            this.Controls.Add(this.btnEndWith);
            this.Controls.Add(this.btnStartsWith);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnSkip);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.BtnFirstOrDefault);
            this.Controls.Add(this.btnFirtst);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnOrderBy);
            this.Controls.Add(this.btnWhere);
            this.Controls.Add(this.btnToList);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGroupBy;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAny;
        private System.Windows.Forms.Button btnEndWith;
        private System.Windows.Forms.Button btnStartsWith;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button BtnFirstOrDefault;
        private System.Windows.Forms.Button btnFirtst;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnOrderBy;
        private System.Windows.Forms.Button btnWhere;
        private System.Windows.Forms.Button btnToList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEmployeeList2;
        private System.Windows.Forms.Button btnOrderList;
        private System.Windows.Forms.Button btnProductList;
        private System.Windows.Forms.Button btnEmployeeList1;
    }
}

