namespace UIGeneratorApp
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.rbPerson = new System.Windows.Forms.RadioButton();
            this.rbEmployee = new System.Windows.Forms.RadioButton();
            this.rbOrder = new System.Windows.Forms.RadioButton();
            this.rbNone = new System.Windows.Forms.RadioButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(674, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Choose Object:";
            // 
            // rbPerson
            // 
            this.rbPerson.AutoSize = true;
            this.rbPerson.Location = new System.Drawing.Point(678, 55);
            this.rbPerson.Name = "rbPerson";
            this.rbPerson.Size = new System.Drawing.Size(58, 17);
            this.rbPerson.TabIndex = 2;
            this.rbPerson.TabStop = true;
            this.rbPerson.Text = "Person";
            this.rbPerson.UseVisualStyleBackColor = true;
            this.rbPerson.CheckedChanged += new System.EventHandler(this.rbPerson_CheckedChanged);
            // 
            // rbEmployee
            // 
            this.rbEmployee.AutoSize = true;
            this.rbEmployee.Location = new System.Drawing.Point(678, 81);
            this.rbEmployee.Name = "rbEmployee";
            this.rbEmployee.Size = new System.Drawing.Size(71, 17);
            this.rbEmployee.TabIndex = 3;
            this.rbEmployee.TabStop = true;
            this.rbEmployee.Text = "Employee";
            this.rbEmployee.UseVisualStyleBackColor = true;
            this.rbEmployee.CheckedChanged += new System.EventHandler(this.rbEmployee_CheckedChanged);
            // 
            // rbOrder
            // 
            this.rbOrder.AutoSize = true;
            this.rbOrder.Location = new System.Drawing.Point(678, 107);
            this.rbOrder.Name = "rbOrder";
            this.rbOrder.Size = new System.Drawing.Size(51, 17);
            this.rbOrder.TabIndex = 4;
            this.rbOrder.TabStop = true;
            this.rbOrder.Text = "Order";
            this.rbOrder.UseVisualStyleBackColor = true;
            this.rbOrder.CheckedChanged += new System.EventHandler(this.rbOrder_CheckedChanged);
            // 
            // rbNone
            // 
            this.rbNone.AutoSize = true;
            this.rbNone.Location = new System.Drawing.Point(678, 130);
            this.rbNone.Name = "rbNone";
            this.rbNone.Size = new System.Drawing.Size(51, 17);
            this.rbNone.TabIndex = 5;
            this.rbNone.TabStop = true;
            this.rbNone.Text = "None";
            this.rbNone.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(672, 450);
            this.pnlContainer.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.rbNone);
            this.Controls.Add(this.rbOrder);
            this.Controls.Add(this.rbEmployee);
            this.Controls.Add(this.rbPerson);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton rbPerson;
        private System.Windows.Forms.RadioButton rbEmployee;
        private System.Windows.Forms.RadioButton rbOrder;
        private System.Windows.Forms.RadioButton rbNone;
        private System.Windows.Forms.Panel pnlContainer;
    }
}

