namespace TicTacToe
{
    partial class TicTacToe
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
            a1 = new Button();
            a2 = new Button();
            a3 = new Button();
            b1 = new Button();
            b2 = new Button();
            b3 = new Button();
            c1 = new Button();
            c2 = new Button();
            c3 = new Button();
            label1 = new Label();
            label2 = new Label();
            playerscore2 = new Label();
            label4 = new Label();
            playerscore1 = new Label();
            displayTurn = new Label();
            playAgain = new Button();
            SuspendLayout();
            // 
            // a1
            // 
            a1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            a1.Location = new Point(34, 84);
            a1.Margin = new Padding(3, 4, 3, 4);
            a1.Name = "a1";
            a1.Size = new Size(114, 119);
            a1.TabIndex = 0;
            a1.UseVisualStyleBackColor = true;
            a1.Click += button_Click;
            // 
            // a2
            // 
            a2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            a2.Location = new Point(155, 84);
            a2.Margin = new Padding(3, 4, 3, 4);
            a2.Name = "a2";
            a2.Size = new Size(114, 119);
            a2.TabIndex = 0;
            a2.UseVisualStyleBackColor = true;
            a2.Click += button_Click;
            // 
            // a3
            // 
            a3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            a3.Location = new Point(277, 84);
            a3.Margin = new Padding(3, 4, 3, 4);
            a3.Name = "a3";
            a3.Size = new Size(114, 119);
            a3.TabIndex = 0;
            a3.UseVisualStyleBackColor = true;
            a3.Click += button_Click;
            // 
            // b1
            // 
            b1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            b1.Location = new Point(34, 211);
            b1.Margin = new Padding(3, 4, 3, 4);
            b1.Name = "b1";
            b1.Size = new Size(114, 119);
            b1.TabIndex = 0;
            b1.UseVisualStyleBackColor = true;
            b1.Click += button_Click;
            // 
            // b2
            // 
            b2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            b2.Location = new Point(155, 211);
            b2.Margin = new Padding(3, 4, 3, 4);
            b2.Name = "b2";
            b2.Size = new Size(114, 119);
            b2.TabIndex = 0;
            b2.UseVisualStyleBackColor = true;
            b2.Click += button_Click;
            // 
            // b3
            // 
            b3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            b3.Location = new Point(277, 211);
            b3.Margin = new Padding(3, 4, 3, 4);
            b3.Name = "b3";
            b3.Size = new Size(114, 119);
            b3.TabIndex = 0;
            b3.UseVisualStyleBackColor = true;
            b3.Click += button_Click;
            // 
            // c1
            // 
            c1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            c1.Location = new Point(34, 337);
            c1.Margin = new Padding(3, 4, 3, 4);
            c1.Name = "c1";
            c1.Size = new Size(114, 119);
            c1.TabIndex = 0;
            c1.UseVisualStyleBackColor = true;
            c1.Click += button_Click;
            // 
            // c2
            // 
            c2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            c2.Location = new Point(155, 337);
            c2.Margin = new Padding(3, 4, 3, 4);
            c2.Name = "c2";
            c2.Size = new Size(114, 119);
            c2.TabIndex = 0;
            c2.UseVisualStyleBackColor = true;
            c2.Click += button_Click;
            // 
            // c3
            // 
            c3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            c3.Location = new Point(277, 337);
            c3.Margin = new Padding(3, 4, 3, 4);
            c3.Name = "c3";
            c3.Size = new Size(114, 119);
            c3.TabIndex = 0;
            c3.UseVisualStyleBackColor = true;
            c3.Click += button_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.DeepSkyBlue;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(398, 84);
            label1.Name = "label1";
            label1.Size = new Size(117, 43);
            label1.TabIndex = 1;
            label1.Text = "Turn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.DeepSkyBlue;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(456, 180);
            label2.Name = "label2";
            label2.Size = new Size(59, 39);
            label2.TabIndex = 1;
            label2.Text = "P:O";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerscore2
            // 
            playerscore2.BackColor = SystemColors.ButtonHighlight;
            playerscore2.BorderStyle = BorderStyle.FixedSingle;
            playerscore2.Location = new Point(456, 220);
            playerscore2.Name = "playerscore2";
            playerscore2.Size = new Size(59, 45);
            playerscore2.TabIndex = 2;
            playerscore2.Text = "0";
            playerscore2.TextAlign = ContentAlignment.MiddleCenter;
            playerscore2.Click += playerscore2_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.DeepSkyBlue;
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(398, 180);
            label4.Name = "label4";
            label4.Size = new Size(61, 39);
            label4.TabIndex = 1;
            label4.Text = "P:X";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // playerscore1
            // 
            playerscore1.BackColor = SystemColors.ButtonHighlight;
            playerscore1.BorderStyle = BorderStyle.FixedSingle;
            playerscore1.Location = new Point(398, 220);
            playerscore1.Name = "playerscore1";
            playerscore1.Size = new Size(61, 45);
            playerscore1.TabIndex = 2;
            playerscore1.Text = "0";
            playerscore1.TextAlign = ContentAlignment.MiddleCenter;
            playerscore1.Click += playerscore1_Click;
            // 
            // displayTurn
            // 
            displayTurn.BackColor = SystemColors.ButtonHighlight;
            displayTurn.BorderStyle = BorderStyle.FixedSingle;
            displayTurn.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            displayTurn.Location = new Point(398, 127);
            displayTurn.Name = "displayTurn";
            displayTurn.Size = new Size(117, 42);
            displayTurn.TabIndex = 2;
            displayTurn.Text = "X";
            displayTurn.TextAlign = ContentAlignment.MiddleCenter;
            displayTurn.Click += displayTurn_Click;
            // 
            // playAgain
            // 
            playAgain.Location = new Point(397, 268);
            playAgain.Name = "playAgain";
            playAgain.Size = new Size(114, 29);
            playAgain.TabIndex = 3;
            playAgain.Text = "Play Again";
            playAgain.UseVisualStyleBackColor = true;
            playAgain.Click += playAgain_Click;
            // 
            // TicTacToe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(606, 605);
            Controls.Add(playAgain);
            Controls.Add(playerscore1);
            Controls.Add(playerscore2);
            Controls.Add(displayTurn);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(c3);
            Controls.Add(c2);
            Controls.Add(c1);
            Controls.Add(b3);
            Controls.Add(b2);
            Controls.Add(b1);
            Controls.Add(a3);
            Controls.Add(a2);
            Controls.Add(a1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TicTacToe";
            Text = "TicTacToe";
            ResumeLayout(false);
        }

        #endregion

        private Button a1;
        private Button a2;
        private Button a3;
        private Button b1;
        private Button b2;
        private Button b3;
        private Button c1;
        private Button c2;
        private Button c3;
        private Label label1;
        private Label label2;
        private Label playerscore2;
        private Label label4;
        private Label playerscore1;
        private Label displayTurn;
        private Button playAgain;
    }
}