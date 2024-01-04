namespace CursoCsharp
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
            lblHolamundo = new Label();
            SuspendLayout();
            // 
            // lblHolamundo
            // 
            lblHolamundo.BackColor = SystemColors.ActiveCaption;
            lblHolamundo.Dock = DockStyle.Fill;
            lblHolamundo.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHolamundo.Location = new Point(0, 0);
            lblHolamundo.Name = "lblHolamundo";
            lblHolamundo.Size = new Size(800, 450);
            lblHolamundo.TabIndex = 0;
            lblHolamundo.Text = "Hola mundo!";
            lblHolamundo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblHolamundo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label lblHolamundo;
    }
}
