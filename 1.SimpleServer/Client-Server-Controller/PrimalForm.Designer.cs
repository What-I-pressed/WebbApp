namespace Client_Server_Controller
{
    partial class PrimalForm
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
            label1 = new Label();
            label2 = new Label();
            txtServerIP = new TextBox();
            txtServerPort = new TextBox();
            btnStartServer = new Button();
            btnStartClient = new Button();
            txtPortServerWorkWith = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(60, 43);
            label1.Name = "label1";
            label1.Size = new Size(100, 30);
            label1.TabIndex = 0;
            label1.Text = "Server IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(60, 143);
            label2.Name = "label2";
            label2.Size = new Size(121, 30);
            label2.TabIndex = 1;
            label2.Text = "Server Port";
            // 
            // txtServerIP
            // 
            txtServerIP.Font = new Font("Segoe UI", 16F);
            txtServerIP.Location = new Point(60, 85);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(183, 36);
            txtServerIP.TabIndex = 2;
            // 
            // txtServerPort
            // 
            txtServerPort.Font = new Font("Segoe UI", 16F);
            txtServerPort.Location = new Point(60, 195);
            txtServerPort.Name = "txtServerPort";
            txtServerPort.Size = new Size(183, 36);
            txtServerPort.TabIndex = 3;
            // 
            // btnStartServer
            // 
            btnStartServer.Font = new Font("Segoe UI", 16F);
            btnStartServer.Location = new Point(543, 350);
            btnStartServer.Name = "btnStartServer";
            btnStartServer.Size = new Size(168, 40);
            btnStartServer.TabIndex = 4;
            btnStartServer.Text = "Start server";
            btnStartServer.UseVisualStyleBackColor = true;
            btnStartServer.Click += btnStartServer_Click;
            // 
            // btnStartClient
            // 
            btnStartClient.Font = new Font("Segoe UI", 16F);
            btnStartClient.Location = new Point(387, 83);
            btnStartClient.Name = "btnStartClient";
            btnStartClient.Size = new Size(168, 40);
            btnStartClient.TabIndex = 5;
            btnStartClient.Text = "Start client";
            btnStartClient.UseVisualStyleBackColor = true;
            btnStartClient.Click += btnStartClient_Click;
            // 
            // txtPortServerWorkWith
            // 
            txtPortServerWorkWith.Font = new Font("Segoe UI", 16F);
            txtPortServerWorkWith.Location = new Point(270, 350);
            txtPortServerWorkWith.Name = "txtPortServerWorkWith";
            txtPortServerWorkWith.Size = new Size(218, 36);
            txtPortServerWorkWith.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(270, 306);
            label3.Name = "label3";
            label3.Size = new Size(218, 30);
            label3.TabIndex = 6;
            label3.Text = "Port server work with";
            // 
            // PrimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPortServerWorkWith);
            Controls.Add(label3);
            Controls.Add(btnStartClient);
            Controls.Add(btnStartServer);
            Controls.Add(txtServerPort);
            Controls.Add(txtServerIP);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PrimalForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtServerIP;
        private TextBox txtServerPort;
        private Button btnStartServer;
        private Button btnStartClient;
        private TextBox txtPortServerWorkWith;
        private Label label3;
    }
}
