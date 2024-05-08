namespace Client_Server_Controller.Networking
{
    partial class ServerForm
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
            lbMessages = new ListBox();
            btnStart = new Button();
            SuspendLayout();
            // 
            // lbMessages
            // 
            lbMessages.Font = new Font("Segoe UI", 16F);
            lbMessages.FormattingEnabled = true;
            lbMessages.ItemHeight = 30;
            lbMessages.Location = new Point(63, 29);
            lbMessages.Name = "lbMessages";
            lbMessages.Size = new Size(673, 364);
            lbMessages.TabIndex = 0;
            lbMessages.SelectedIndexChanged += lbMessages_SelectedIndexChanged;
            // 
            // btnStart
            // 
            btnStart.Font = new Font("Segoe UI", 16F);
            btnStart.Location = new Point(365, 399);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(127, 39);
            btnStart.TabIndex = 1;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += StartListen;
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(lbMessages);
            Name = "ServerForm";
            Text = "ServerForm";
            Load += ServerForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbMessages;
        private Button btnStart;
    }
}