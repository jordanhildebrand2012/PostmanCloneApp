namespace PostmanCloneUI
{
    partial class Dashboard
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
            formHeader = new Label();
            apiLabel = new Label();
            apiText = new TextBox();
            resultText = new TextBox();
            callApi = new Button();
            resultLabel = new Label();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(50, 50);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(317, 60);
            formHeader.TabIndex = 0;
            formHeader.Text = "Postman Clone";
            // 
            // apiLabel
            // 
            apiLabel.AutoSize = true;
            apiLabel.Location = new Point(50, 148);
            apiLabel.Name = "apiLabel";
            apiLabel.Size = new Size(45, 28);
            apiLabel.TabIndex = 1;
            apiLabel.Text = "API:";
            // 
            // apiText
            // 
            apiText.BorderStyle = BorderStyle.FixedSingle;
            apiText.Location = new Point(101, 148);
            apiText.Name = "apiText";
            apiText.Size = new Size(649, 34);
            apiText.TabIndex = 2;
            // 
            // resultText
            // 
            resultText.BackColor = Color.White;
            resultText.BorderStyle = BorderStyle.FixedSingle;
            resultText.Location = new Point(101, 268);
            resultText.Multiline = true;
            resultText.Name = "resultText";
            resultText.ReadOnly = true;
            resultText.ScrollBars = ScrollBars.Both;
            resultText.Size = new Size(783, 291);
            resultText.TabIndex = 3;
            // 
            // callApi
            // 
            callApi.Location = new Point(773, 148);
            callApi.Name = "callApi";
            callApi.Size = new Size(128, 41);
            callApi.TabIndex = 4;
            callApi.Text = "Go";
            callApi.UseVisualStyleBackColor = true;
            callApi.Click += callApi_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(101, 220);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(72, 28);
            resultLabel.TabIndex = 5;
            resultLabel.Text = "Results";
            // 
            // statusStrip
            // 
            statusStrip.ImageScalingSize = new Size(20, 20);
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 596);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(923, 34);
            statusStrip.TabIndex = 6;
            statusStrip.Text = "System Status";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(65, 28);
            systemStatus.Text = "Ready";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(923, 630);
            Controls.Add(statusStrip);
            Controls.Add(resultLabel);
            Controls.Add(callApi);
            Controls.Add(resultText);
            Controls.Add(apiText);
            Controls.Add(apiLabel);
            Controls.Add(formHeader);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Dashboard";
            Text = "Postman Clone Desktop App";
            Load += Dashboard_Load;
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label formHeader;
        private Label apiLabel;
        private TextBox apiText;
        private TextBox resultText;
        private Button callApi;
        private Label resultLabel;
        private StatusStrip statusStrip;
        private ToolStripStatusLabel systemStatus;
    }
}
