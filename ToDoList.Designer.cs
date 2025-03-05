namespace toDOList
{
    partial class ToDoList
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
            lblToDOlst = new Label();
            lblTasks = new Label();
            lblEnterTask = new Label();
            lstTasks = new ListBox();
            bttnRemove = new Button();
            bttnSave = new Button();
            bttnAdd = new Button();
            TxtInput1 = new TextBox();
            SuspendLayout();
            // 
            // lblToDOlst
            // 
            lblToDOlst.AutoSize = true;
            lblToDOlst.Font = new Font("Gloucester MT Extra Condensed", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblToDOlst.Location = new Point(344, 18);
            lblToDOlst.Name = "lblToDOlst";
            lblToDOlst.Size = new Size(151, 41);
            lblToDOlst.TabIndex = 5;
            lblToDOlst.Text = "TO DO LIST ";
            // 
            // lblTasks
            // 
            lblTasks.AutoSize = true;
            lblTasks.Font = new Font("Gloucester MT Extra Condensed", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTasks.Location = new Point(613, 79);
            lblTasks.Name = "lblTasks";
            lblTasks.Size = new Size(59, 25);
            lblTasks.TabIndex = 6;
            lblTasks.Text = "TASKS";
            // 
            // lblEnterTask
            // 
            lblEnterTask.AutoSize = true;
            lblEnterTask.Font = new Font("Gloucester MT Extra Condensed", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEnterTask.Location = new Point(224, 79);
            lblEnterTask.Name = "lblEnterTask";
            lblEnterTask.Size = new Size(111, 25);
            lblEnterTask.TabIndex = 7;
            lblEnterTask.Text = "Enter Task here:";
            // 
            // lstTasks
            // 
            lstTasks.Font = new Font("Gloucester MT Extra Condensed", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lstTasks.FormattingEnabled = true;
            lstTasks.ItemHeight = 18;
            lstTasks.Location = new Point(500, 395);
            lstTasks.Name = "lstTasks";
            lstTasks.Size = new Size(259, 40);
            lstTasks.TabIndex = 4;
            // 
            // bttnRemove
            // 
            bttnRemove.Font = new Font("Gloucester MT Extra Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnRemove.Location = new Point(329, 167);
            bttnRemove.Name = "bttnRemove";
            bttnRemove.Size = new Size(75, 23);
            bttnRemove.TabIndex = 1;
            bttnRemove.Text = "Remove Task";
            bttnRemove.UseVisualStyleBackColor = true;
            bttnRemove.Click += bttnRemove_Click;
            // 
            // bttnSave
            // 
            bttnSave.Font = new Font("Gloucester MT Extra Condensed", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttnSave.Location = new Point(224, 167);
            bttnSave.Name = "bttnSave";
            bttnSave.Size = new Size(75, 23);
            bttnSave.TabIndex = 2;
            bttnSave.Text = "Save Task List";
            bttnSave.UseVisualStyleBackColor = true;
            bttnSave.Click += bttnSave_Click;
            // 
            // bttnAdd
            // 
            bttnAdd.Font = new Font("Gloucester MT Extra Condensed", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            bttnAdd.Location = new Point(124, 167);
            bttnAdd.Name = "bttnAdd";
            bttnAdd.Size = new Size(75, 23);
            bttnAdd.TabIndex = 3;
            bttnAdd.Text = "Add Task";
            bttnAdd.UseVisualStyleBackColor = true;
            bttnAdd.Click += bttnAdd_Click;
            // 
            // TxtInput1
            // 
            TxtInput1.Location = new Point(124, 391);
            TxtInput1.Name = "TxtInput1";
            TxtInput1.Size = new Size(280, 23);
            TxtInput1.TabIndex = 8;
            TxtInput1.TextChanged += TxtInput1_TextChanged;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtInput1);
            Controls.Add(lblEnterTask);
            Controls.Add(lblTasks);
            Controls.Add(lblToDOlst);
            Controls.Add(lstTasks);
            Controls.Add(bttnAdd);
            Controls.Add(bttnSave);
            Controls.Add(bttnRemove);
            Name = "ToDoList";
            Text = "ToDoList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblToDOlst;
        private Label lblTasks;
        private Label lblEnterTask;
        private ListBox lstTasks;
        private Button bttnRemove;
        private Button bttnSave;
        private Button bttnAdd;
        private TextBox TxtInput1;
    }
}
