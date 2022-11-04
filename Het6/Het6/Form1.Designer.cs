
namespace Het6
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
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ballButton = new System.Windows.Forms.Button();
            this.carButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.buttonColor = new System.Windows.Forms.Button();
            this.presentButton = new System.Windows.Forms.Button();
            this.buttonBoxcolor = new System.Windows.Forms.Button();
            this.buttonRibboncolor = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.buttonRibboncolor);
            this.mainPanel.Controls.Add(this.buttonBoxcolor);
            this.mainPanel.Controls.Add(this.presentButton);
            this.mainPanel.Controls.Add(this.buttonColor);
            this.mainPanel.Controls.Add(this.ballButton);
            this.mainPanel.Controls.Add(this.carButton);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Location = new System.Drawing.Point(-3, 1);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1071, 554);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // ballButton
            // 
            this.ballButton.Location = new System.Drawing.Point(139, 28);
            this.ballButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ballButton.Name = "ballButton";
            this.ballButton.Size = new System.Drawing.Size(100, 50);
            this.ballButton.TabIndex = 2;
            this.ballButton.Text = "BALL";
            this.ballButton.UseVisualStyleBackColor = true;
            this.ballButton.Click += new System.EventHandler(this.ballButton_Click);
            // 
            // carButton
            // 
            this.carButton.Location = new System.Drawing.Point(19, 27);
            this.carButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carButton.Name = "carButton";
            this.carButton.Size = new System.Drawing.Size(100, 52);
            this.carButton.TabIndex = 1;
            this.carButton.Text = "CAR";
            this.carButton.UseVisualStyleBackColor = true;
            this.carButton.Click += new System.EventHandler(this.carButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coming next:";
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Red;
            this.buttonColor.Location = new System.Drawing.Point(139, 86);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(100, 26);
            this.buttonColor.TabIndex = 3;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // presentButton
            // 
            this.presentButton.Location = new System.Drawing.Point(258, 27);
            this.presentButton.Margin = new System.Windows.Forms.Padding(4);
            this.presentButton.Name = "presentButton";
            this.presentButton.Size = new System.Drawing.Size(100, 50);
            this.presentButton.TabIndex = 4;
            this.presentButton.Text = "PRESENT";
            this.presentButton.UseVisualStyleBackColor = true;
            this.presentButton.Click += new System.EventHandler(this.presentButton_Click);
            // 
            // buttonBoxcolor
            // 
            this.buttonBoxcolor.BackColor = System.Drawing.Color.Yellow;
            this.buttonBoxcolor.Location = new System.Drawing.Point(258, 86);
            this.buttonBoxcolor.Name = "buttonBoxcolor";
            this.buttonBoxcolor.Size = new System.Drawing.Size(100, 26);
            this.buttonBoxcolor.TabIndex = 5;
            this.buttonBoxcolor.UseVisualStyleBackColor = false;
            this.buttonBoxcolor.Click += new System.EventHandler(this.buttonBoxcolor_Click);
            // 
            // buttonRibboncolor
            // 
            this.buttonRibboncolor.BackColor = System.Drawing.Color.Green;
            this.buttonRibboncolor.Location = new System.Drawing.Point(258, 118);
            this.buttonRibboncolor.Name = "buttonRibboncolor";
            this.buttonRibboncolor.Size = new System.Drawing.Size(100, 26);
            this.buttonRibboncolor.TabIndex = 6;
            this.buttonRibboncolor.UseVisualStyleBackColor = false;
            this.buttonRibboncolor.Click += new System.EventHandler(this.buttonRibboncolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button ballButton;
        private System.Windows.Forms.Button carButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button presentButton;
        private System.Windows.Forms.Button buttonBoxcolor;
        private System.Windows.Forms.Button buttonRibboncolor;
    }
}

