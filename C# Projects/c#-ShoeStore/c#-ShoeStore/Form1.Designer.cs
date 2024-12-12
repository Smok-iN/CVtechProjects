namespace c__ShoeStore
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
            Add_Inventory = new Button();
            View_Inventory = new Button();
            Exit_Button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            UPC_input = new TextBox();
            Item_input = new TextBox();
            Quantity_input = new TextBox();
            Price_input = new TextBox();
            SuspendLayout();
            // 
            // Add_Inventory
            // 
            Add_Inventory.Location = new Point(12, 235);
            Add_Inventory.Name = "Add_Inventory";
            Add_Inventory.Size = new Size(97, 23);
            Add_Inventory.TabIndex = 0;
            Add_Inventory.Text = "Add Inventory";
            Add_Inventory.UseVisualStyleBackColor = true;
            Add_Inventory.Click += Add_Inventory_Click;
            // 
            // View_Inventory
            // 
            View_Inventory.Location = new Point(130, 235);
            View_Inventory.Name = "View_Inventory";
            View_Inventory.Size = new Size(97, 23);
            View_Inventory.TabIndex = 0;
            View_Inventory.Text = "View Inventory";
            View_Inventory.UseVisualStyleBackColor = true;
            View_Inventory.Click += View_Inventory_Click;
            // 
            // Exit_Button
            // 
            Exit_Button.Location = new Point(252, 235);
            Exit_Button.Name = "Exit_Button";
            Exit_Button.Size = new Size(97, 23);
            Exit_Button.TabIndex = 0;
            Exit_Button.Text = "Exit";
            Exit_Button.UseVisualStyleBackColor = true;
            Exit_Button.Click += Exit_Button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 165);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "List Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 131);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 1;
            label3.Text = "Item Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 62);
            label4.Name = "label4";
            label4.Size = new Size(80, 15);
            label4.TabIndex = 1;
            label4.Text = "UPC(10-Digit)";
            // 
            // UPC_input
            // 
            UPC_input.Location = new Point(127, 59);
            UPC_input.Name = "UPC_input";
            UPC_input.Size = new Size(222, 23);
            UPC_input.TabIndex = 2;
            // 
            // Item_input
            // 
            Item_input.Location = new Point(127, 93);
            Item_input.Name = "Item_input";
            Item_input.Size = new Size(222, 23);
            Item_input.TabIndex = 2;
            // 
            // Quantity_input
            // 
            Quantity_input.Location = new Point(127, 128);
            Quantity_input.Name = "Quantity_input";
            Quantity_input.Size = new Size(222, 23);
            Quantity_input.TabIndex = 2;
            // 
            // Price_input
            // 
            Price_input.Location = new Point(127, 162);
            Price_input.Name = "Price_input";
            Price_input.Size = new Size(222, 23);
            Price_input.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 281);
            Controls.Add(Price_input);
            Controls.Add(Quantity_input);
            Controls.Add(Item_input);
            Controls.Add(UPC_input);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Exit_Button);
            Controls.Add(View_Inventory);
            Controls.Add(Add_Inventory);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add_Inventory;
        private Button View_Inventory;
        private Button Exit_Button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox UPC_input;
        private TextBox Item_input;
        private TextBox Quantity_input;
        private TextBox Price_input;
    }
}
