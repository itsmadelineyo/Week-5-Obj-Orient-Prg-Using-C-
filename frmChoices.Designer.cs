namespace Project5Dorse
{
    partial class frmChoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoices));
            lblInstructions = new Label();
            lblLeftNumber = new Label();
            label2 = new Label();
            lblRightNumber = new Label();
            txtLeftNumber = new TextBox();
            txtCheckNumber = new TextBox();
            txtRightNumber = new TextBox();
            lblMessage = new Label();
            btnClear = new Button();
            btnCheck = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblInstructions
            // 
            lblInstructions.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions.Location = new Point(49, 20);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(987, 93);
            lblInstructions.TabIndex = 0;
            lblInstructions.Text = resources.GetString("lblInstructions.Text");
            lblInstructions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLeftNumber
            // 
            lblLeftNumber.AutoSize = true;
            lblLeftNumber.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLeftNumber.Location = new Point(141, 152);
            lblLeftNumber.Name = "lblLeftNumber";
            lblLeftNumber.Size = new Size(109, 22);
            lblLeftNumber.TabIndex = 1;
            lblLeftNumber.Text = "Left Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(415, 152);
            label2.Name = "label2";
            label2.Size = new Size(186, 22);
            label2.TabIndex = 2;
            label2.Text = "Number to be checked";
            // 
            // lblRightNumber
            // 
            lblRightNumber.AutoSize = true;
            lblRightNumber.Font = new Font("Times New Roman", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRightNumber.Location = new Point(789, 149);
            lblRightNumber.Name = "lblRightNumber";
            lblRightNumber.Size = new Size(120, 22);
            lblRightNumber.TabIndex = 3;
            lblRightNumber.Text = "Right Number";
            // 
            // txtLeftNumber
            // 
            txtLeftNumber.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtLeftNumber.Location = new Point(117, 186);
            txtLeftNumber.Name = "txtLeftNumber";
            txtLeftNumber.Size = new Size(150, 30);
            txtLeftNumber.TabIndex = 4;
            txtLeftNumber.TabStop = false;
            txtLeftNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCheckNumber
            // 
            txtCheckNumber.BackColor = Color.LightSteelBlue;
            txtCheckNumber.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtCheckNumber.Location = new Point(438, 186);
            txtCheckNumber.Name = "txtCheckNumber";
            txtCheckNumber.Size = new Size(150, 30);
            txtCheckNumber.TabIndex = 5;
            txtCheckNumber.TabStop = false;
            txtCheckNumber.TextAlign = HorizontalAlignment.Center;
            // 
            // txtRightNumber
            // 
            txtRightNumber.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRightNumber.Location = new Point(775, 186);
            txtRightNumber.Name = "txtRightNumber";
            txtRightNumber.Size = new Size(150, 30);
            txtRightNumber.TabIndex = 6;
            txtRightNumber.TabStop = false;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = Color.LightSteelBlue;
            lblMessage.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(117, 246);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(808, 68);
            lblMessage.TabIndex = 7;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Click += lblMessage_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.LightSteelBlue;
            btnClear.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(281, 341);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 8;
            btnClear.Text = "C&lear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCheck
            // 
            btnCheck.BackColor = Color.LightSteelBlue;
            btnCheck.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheck.Location = new Point(456, 341);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(112, 34);
            btnCheck.TabIndex = 9;
            btnCheck.Text = "&Check";
            btnCheck.UseVisualStyleBackColor = false;
            btnCheck.Click += btnCheck_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.LightSteelBlue;
            btnExit.Font = new Font("Times New Roman", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(627, 341);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(112, 34);
            btnExit.TabIndex = 10;
            btnExit.Text = "&Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // frmChoices
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1085, 450);
            Controls.Add(btnExit);
            Controls.Add(btnCheck);
            Controls.Add(btnClear);
            Controls.Add(lblMessage);
            Controls.Add(txtRightNumber);
            Controls.Add(txtCheckNumber);
            Controls.Add(txtLeftNumber);
            Controls.Add(lblRightNumber);
            Controls.Add(label2);
            Controls.Add(lblLeftNumber);
            Controls.Add(lblInstructions);
            Name = "frmChoices";
            Text = "Dorse Choices";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInstructions;
        private Label lblLeftNumber;
        private Label label2;
        private Label lblRightNumber;
        private TextBox txtLeftNumber;
        private TextBox txtCheckNumber;
        private TextBox txtRightNumber;
        private Label lblMessage;
        private Button btnClear;
        private Button btnCheck;
        private Button btnExit;
    }
}
