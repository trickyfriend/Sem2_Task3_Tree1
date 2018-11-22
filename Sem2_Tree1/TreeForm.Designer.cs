namespace Sem2_Tree1
{
    partial class TreeForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonCreateTree = new System.Windows.Forms.Button();
            this.buttonShowList = new System.Windows.Forms.Button();
            this.textBoxShowList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "INPUT.txt";
            // 
            // buttonCreateTree
            // 
            this.buttonCreateTree.Location = new System.Drawing.Point(1171, 40);
            this.buttonCreateTree.Name = "buttonCreateTree";
            this.buttonCreateTree.Size = new System.Drawing.Size(230, 51);
            this.buttonCreateTree.TabIndex = 0;
            this.buttonCreateTree.Text = "Create tree";
            this.buttonCreateTree.UseVisualStyleBackColor = true;
            this.buttonCreateTree.Click += new System.EventHandler(this.buttonCreateTree_Click);
            // 
            // buttonShowList
            // 
            this.buttonShowList.Location = new System.Drawing.Point(1171, 120);
            this.buttonShowList.Name = "buttonShowList";
            this.buttonShowList.Size = new System.Drawing.Size(230, 51);
            this.buttonShowList.TabIndex = 1;
            this.buttonShowList.Text = "Show list";
            this.buttonShowList.UseVisualStyleBackColor = true;
            this.buttonShowList.Click += new System.EventHandler(this.buttonShowList_Click);
            // 
            // textBoxShowList
            // 
            this.textBoxShowList.Location = new System.Drawing.Point(1171, 187);
            this.textBoxShowList.Multiline = true;
            this.textBoxShowList.Name = "textBoxShowList";
            this.textBoxShowList.Size = new System.Drawing.Size(230, 294);
            this.textBoxShowList.TabIndex = 2;
            this.textBoxShowList.Text = "Условие задачи: Упорядочить строки данного текстового файла в порядке возрастания" +
    " их длин.";
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1472, 706);
            this.Controls.Add(this.textBoxShowList);
            this.Controls.Add(this.buttonShowList);
            this.Controls.Add(this.buttonCreateTree);
            this.Name = "TreeForm";
            this.Text = "Tree";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonCreateTree;
        private System.Windows.Forms.Button buttonShowList;
        private System.Windows.Forms.TextBox textBoxShowList;
    }
}

