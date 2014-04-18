namespace GroupProject
{
    partial class AddPopup
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
            this.QuantityQuestionInput = new System.Windows.Forms.NumericUpDown();
            this.QuantityQuestionLabel = new System.Windows.Forms.Label();
            this.AddButtonCancel = new System.Windows.Forms.Button();
            this.AddButtonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityQuestionInput)).BeginInit();
            this.SuspendLayout();
            // 
            // QuantityQuestionInput
            // 
            this.QuantityQuestionInput.Location = new System.Drawing.Point(231, 80);
            this.QuantityQuestionInput.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.QuantityQuestionInput.Name = "QuantityQuestionInput";
            this.QuantityQuestionInput.Size = new System.Drawing.Size(172, 31);
            this.QuantityQuestionInput.TabIndex = 0;
            this.QuantityQuestionInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityQuestionInput.ValueChanged += new System.EventHandler(this.QuantityQuestionInput_ValueChanged);
            // 
            // QuantityQuestionLabel
            // 
            this.QuantityQuestionLabel.AutoSize = true;
            this.QuantityQuestionLabel.Location = new System.Drawing.Point(85, 40);
            this.QuantityQuestionLabel.Name = "QuantityQuestionLabel";
            this.QuantityQuestionLabel.Size = new System.Drawing.Size(70, 25);
            this.QuantityQuestionLabel.TabIndex = 1;
            this.QuantityQuestionLabel.Text = "label1";
            // 
            // AddButtonCancel
            // 
            this.AddButtonCancel.Location = new System.Drawing.Point(249, 124);
            this.AddButtonCancel.Name = "AddButtonCancel";
            this.AddButtonCancel.Size = new System.Drawing.Size(110, 47);
            this.AddButtonCancel.TabIndex = 2;
            this.AddButtonCancel.Text = "Cancel";
            this.AddButtonCancel.UseVisualStyleBackColor = true;
            // 
            // AddButtonOk
            // 
            this.AddButtonOk.Location = new System.Drawing.Point(121, 124);
            this.AddButtonOk.Name = "AddButtonOk";
            this.AddButtonOk.Size = new System.Drawing.Size(90, 47);
            this.AddButtonOk.TabIndex = 3;
            this.AddButtonOk.Text = "Ok";
            this.AddButtonOk.UseVisualStyleBackColor = true;
            // 
            // AddPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 183);
            this.Controls.Add(this.AddButtonOk);
            this.Controls.Add(this.AddButtonCancel);
            this.Controls.Add(this.QuantityQuestionLabel);
            this.Controls.Add(this.QuantityQuestionInput);
            this.Name = "AddPopup";
            this.Text = "AddPopup";
            ((System.ComponentModel.ISupportInitialize)(this.QuantityQuestionInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown QuantityQuestionInput;
        private System.Windows.Forms.Label QuantityQuestionLabel;
        private System.Windows.Forms.Button AddButtonCancel;
        private System.Windows.Forms.Button AddButtonOk;
    }
}