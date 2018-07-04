namespace PlotGraph
{
    partial class MainControlForm
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
            this.oneSLineGraphPress = new PlotGraph.OneSLineGraph();
            this.oneSLineGraphTemp = new PlotGraph.OneSLineGraph();
            this.comPortDD = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // oneSLineGraphPress
            // 
            this.oneSLineGraphPress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oneSLineGraphPress.Location = new System.Drawing.Point(12, 309);
            this.oneSLineGraphPress.Name = "oneSLineGraphPress";
            this.oneSLineGraphPress.Size = new System.Drawing.Size(475, 278);
            this.oneSLineGraphPress.TabIndex = 1;
            // 
            // oneSLineGraphTemp
            // 
            this.oneSLineGraphTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.oneSLineGraphTemp.Location = new System.Drawing.Point(12, 40);
            this.oneSLineGraphTemp.Name = "oneSLineGraphTemp";
            this.oneSLineGraphTemp.Size = new System.Drawing.Size(475, 253);
            this.oneSLineGraphTemp.TabIndex = 0;
            // 
            // comPortDD
            // 
            this.comPortDD.FormattingEnabled = true;
            this.comPortDD.Location = new System.Drawing.Point(13, 13);
            this.comPortDD.Name = "comPortDD";
            this.comPortDD.Size = new System.Drawing.Size(121, 21);
            this.comPortDD.TabIndex = 2;
            // 
            // MainControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 599);
            this.Controls.Add(this.comPortDD);
            this.Controls.Add(this.oneSLineGraphPress);
            this.Controls.Add(this.oneSLineGraphTemp);
            this.Name = "MainControlForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private OneSLineGraph oneSLineGraphTemp;
        private OneSLineGraph oneSLineGraphPress;
        private System.Windows.Forms.ComboBox comPortDD;
    }
}

