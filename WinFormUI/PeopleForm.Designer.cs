namespace WinFormUI
{
  partial class PeopleForm
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
      this.headerAddPersonLabel = new System.Windows.Forms.Label();
      this.headerListPeopleLabel = new System.Windows.Forms.Label();
      this.headerFirstNameLabel = new System.Windows.Forms.Label();
      this.headerLastNameLabel = new System.Windows.Forms.Label();
      this.firstNameTextBox = new System.Windows.Forms.TextBox();
      this.lastNameTextBox = new System.Windows.Forms.TextBox();
      this.addPersonButton = new System.Windows.Forms.Button();
      this.refreshListButton = new System.Windows.Forms.Button();
      this.listPeopleListBox = new System.Windows.Forms.ListBox();
      this.SuspendLayout();
      // 
      // headerAddPersonLabel
      // 
      this.headerAddPersonLabel.AutoSize = true;
      this.headerAddPersonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerAddPersonLabel.Location = new System.Drawing.Point(25, 22);
      this.headerAddPersonLabel.Name = "headerAddPersonLabel";
      this.headerAddPersonLabel.Size = new System.Drawing.Size(165, 31);
      this.headerAddPersonLabel.TabIndex = 0;
      this.headerAddPersonLabel.Text = "Add Person";
      // 
      // headerListPeopleLabel
      // 
      this.headerListPeopleLabel.AutoSize = true;
      this.headerListPeopleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerListPeopleLabel.Location = new System.Drawing.Point(298, 22);
      this.headerListPeopleLabel.Name = "headerListPeopleLabel";
      this.headerListPeopleLabel.Size = new System.Drawing.Size(159, 31);
      this.headerListPeopleLabel.TabIndex = 1;
      this.headerListPeopleLabel.Text = "List People";
      // 
      // headerFirstNameLabel
      // 
      this.headerFirstNameLabel.AutoSize = true;
      this.headerFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerFirstNameLabel.Location = new System.Drawing.Point(27, 86);
      this.headerFirstNameLabel.Name = "headerFirstNameLabel";
      this.headerFirstNameLabel.Size = new System.Drawing.Size(86, 20);
      this.headerFirstNameLabel.TabIndex = 2;
      this.headerFirstNameLabel.Text = "First Name";
      // 
      // headerLastNameLabel
      // 
      this.headerLastNameLabel.AutoSize = true;
      this.headerLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerLastNameLabel.Location = new System.Drawing.Point(27, 156);
      this.headerLastNameLabel.Name = "headerLastNameLabel";
      this.headerLastNameLabel.Size = new System.Drawing.Size(86, 20);
      this.headerLastNameLabel.TabIndex = 3;
      this.headerLastNameLabel.Text = "Last Name";
      // 
      // firstNameTextBox
      // 
      this.firstNameTextBox.Location = new System.Drawing.Point(30, 109);
      this.firstNameTextBox.Name = "firstNameTextBox";
      this.firstNameTextBox.Size = new System.Drawing.Size(194, 31);
      this.firstNameTextBox.TabIndex = 4;
      // 
      // lastNameTextBox
      // 
      this.lastNameTextBox.Location = new System.Drawing.Point(29, 179);
      this.lastNameTextBox.Name = "lastNameTextBox";
      this.lastNameTextBox.Size = new System.Drawing.Size(195, 31);
      this.lastNameTextBox.TabIndex = 5;
      // 
      // addPersonButton
      // 
      this.addPersonButton.Location = new System.Drawing.Point(29, 249);
      this.addPersonButton.Name = "addPersonButton";
      this.addPersonButton.Size = new System.Drawing.Size(195, 57);
      this.addPersonButton.TabIndex = 6;
      this.addPersonButton.Text = "Add Person";
      this.addPersonButton.UseVisualStyleBackColor = true;
      this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
      // 
      // refreshListButton
      // 
      this.refreshListButton.Location = new System.Drawing.Point(29, 345);
      this.refreshListButton.Name = "refreshListButton";
      this.refreshListButton.Size = new System.Drawing.Size(195, 57);
      this.refreshListButton.TabIndex = 7;
      this.refreshListButton.Text = "Refresh List";
      this.refreshListButton.UseVisualStyleBackColor = true;
      this.refreshListButton.Click += new System.EventHandler(this.refreshListButton_Click);
      // 
      // listPeopleListBox
      // 
      this.listPeopleListBox.FormattingEnabled = true;
      this.listPeopleListBox.ItemHeight = 25;
      this.listPeopleListBox.Location = new System.Drawing.Point(304, 86);
      this.listPeopleListBox.Name = "listPeopleListBox";
      this.listPeopleListBox.Size = new System.Drawing.Size(297, 329);
      this.listPeopleListBox.TabIndex = 8;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(626, 434);
      this.Controls.Add(this.listPeopleListBox);
      this.Controls.Add(this.refreshListButton);
      this.Controls.Add(this.addPersonButton);
      this.Controls.Add(this.lastNameTextBox);
      this.Controls.Add(this.firstNameTextBox);
      this.Controls.Add(this.headerLastNameLabel);
      this.Controls.Add(this.headerFirstNameLabel);
      this.Controls.Add(this.headerListPeopleLabel);
      this.Controls.Add(this.headerAddPersonLabel);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "Form1";
      this.Text = "SQLite Demo";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label headerAddPersonLabel;
    private System.Windows.Forms.Label headerListPeopleLabel;
    private System.Windows.Forms.Label headerFirstNameLabel;
    private System.Windows.Forms.Label headerLastNameLabel;
    private System.Windows.Forms.TextBox firstNameTextBox;
    private System.Windows.Forms.TextBox lastNameTextBox;
    private System.Windows.Forms.Button addPersonButton;
    private System.Windows.Forms.Button refreshListButton;
    private System.Windows.Forms.ListBox listPeopleListBox;
  }
}

