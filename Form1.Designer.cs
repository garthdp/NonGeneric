namespace NonGeneric
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
            btnPrint = new Button();
            lstDictionary = new ListBox();
            lstHashSet = new ListBox();
            lstQueue = new ListBox();
            SuspendLayout();
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(12, 12);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "PRINT";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // lstDictionary
            // 
            lstDictionary.FormattingEnabled = true;
            lstDictionary.ItemHeight = 15;
            lstDictionary.Location = new Point(12, 41);
            lstDictionary.Name = "lstDictionary";
            lstDictionary.Size = new Size(202, 94);
            lstDictionary.TabIndex = 1;
            // 
            // lstHashSet
            // 
            lstHashSet.FormattingEnabled = true;
            lstHashSet.ItemHeight = 15;
            lstHashSet.Location = new Point(294, 41);
            lstHashSet.Name = "lstHashSet";
            lstHashSet.Size = new Size(202, 94);
            lstHashSet.TabIndex = 2;
            // 
            // lstQueue
            // 
            lstQueue.FormattingEnabled = true;
            lstQueue.ItemHeight = 15;
            lstQueue.Location = new Point(586, 41);
            lstQueue.Name = "lstQueue";
            lstQueue.Size = new Size(202, 94);
            lstQueue.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 155);
            Controls.Add(lstQueue);
            Controls.Add(lstHashSet);
            Controls.Add(lstDictionary);
            Controls.Add(btnPrint);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPrint;
        private ListBox lstDictionary;
        private ListBox lstHashSet;
        private ListBox lstQueue;
    }
}
